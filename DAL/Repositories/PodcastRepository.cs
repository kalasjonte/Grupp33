using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELS;

namespace DAL
{
    public class PodcastRepository : IPodcastRepository<Podcast>
    {
        SerializerXml serializerXml = new SerializerXml();
        List<Podcast> listOfPodcasts;
        //CRUDO
        public PodcastRepository()
        {
            listOfPodcasts = new List<Podcast>();
            listOfPodcasts = GetAll();
        }
        public void Create(Podcast entity)
        {
            listOfPodcasts.Add(entity);
            SaveChanges();
        }

        public void Delete(int index)
        {
            listOfPodcasts.RemoveAt(index);
            SaveChanges();
        }

        public void DeleteFromName(string name)
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.Name != name
                           select pod;

            listOfPodcasts = podQuery.ToList();
            SaveChanges();
            GetAll();
        }

        public List<Podcast> GetAll()
        {
             return serializerXml.DeserializePodcast();

        }

        public void SaveChanges()
        {
            serializerXml.SerializePodcast(listOfPodcasts);
        }

        public void Update(int index, Podcast entity)
        {
            listOfPodcasts[index] = entity;
            SaveChanges();
        }


        //_____________________

        public Podcast GetByName(string name)
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.Name == name
                           select pod;
            return podQuery.First();
            
        }

        public Podcast GetByType(string type)  // Returnerar en pod men ska returnera en list, ta bort?
        {
            throw new NotImplementedException();
        }
        public Podcast GetByUrl(string url)
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.URL == url
                           select pod;
            return podQuery.First();
        }


        //_________________________

        
        public Podcast GetByListOfItems(List<Item> itemList)
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.items == itemList
                           select pod;
            return podQuery.First();
        }


        public List<Podcast> GetByTypeNumberOfItems(int number)
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.NumberOfItems == number 
                           select pod;
            return podQuery.ToList();
        }

        public List<Podcast> GetByUpdateFrequency(int uFreq)
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.UpdateFrequency == uFreq
                           select pod;
            return podQuery.ToList();
        }



        public Category GetCatByPodName(string name) //cast eller first? -- .equals eller ==?
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.Name == name
                           select pod.Category;
            return podQuery.First();
        }

        public List<Item> GetItemListByPodName(string name)
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.Name == name
                           select pod.items;
            return (List<Item>)podQuery;
        }

        public int GetNumberOfItemsByPodName(string name)
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.Name == name
                           select pod.NumberOfItems;
            return podQuery.First();
        }

        public int GetUpFreqByPodName(string name)
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.Name == name
                           select pod.UpdateFrequency;
            return podQuery.First();
        }

        public List<Podcast> GetByCategory(string name)  // ska vi ha fler respos?
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.Category.Name == name
                           select pod;
            return podQuery.ToList();
        }

        public string GetItemGuidFromItenName(Podcast pod, string name)
        {
            var itemQuery = from item in pod.items
                        where item.Name == name
                        select item.Guid;


            return itemQuery.First();
        }

        public string GetItemDescriptionFromGuid(Podcast pod, string guid)
        {
            var itemQuery = from item in pod.items
                        where item.Guid == guid
                        select item.Description;

            return itemQuery.First();
        }

        public List<Podcast> SortDesending()
        {
            var podQuery = from pod in listOfPodcasts
                           orderby pod.Name
                           select pod;

             listOfPodcasts = podQuery.ToList();
            return listOfPodcasts;
        }

        public async Task UpdatePodcastFromRss(Podcast podcast)
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.Name != podcast.Name
                           select pod;
            
            listOfPodcasts = podQuery.ToList();
            Create(podcast);
            GetAll();
        }

        public void UpdatePodcastCat(string oldName, string newName)
        {

            List<Podcast> oldList = GetByCategory(oldName);

            var podquery = from pod in listOfPodcasts
                            where pod.Category.Name != oldName
                            select pod;
            listOfPodcasts = podquery.ToList();   

            foreach (var item in oldList)
            {
                item.Category.Name = newName;
                listOfPodcasts.Add(item);
            }
            SaveChanges();
            GetAll();
        }

        public void UpdatePodcastByName(Category cat, int freq, string oldName, string newName)
        {
            Podcast podcast = GetByName(oldName);   
            var podquery = from pod in listOfPodcasts
                           where pod.Name != oldName
                           select pod;
            listOfPodcasts = podquery.ToList();

            podcast.Category = cat;
            podcast.UpdateFrequency = freq;
            podcast.Name = newName;
            listOfPodcasts.Add(podcast);
            
            SaveChanges();
            GetAll();
        }

        public Podcast GetPodByName(string name)
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.Name == name
                           select pod;
            return podQuery.First();
        }

        public List<Podcast> DescendOrder()
        {
            var queryDescend = from pod in listOfPodcasts
                               orderby pod.Name
                               select pod;
            listOfPodcasts = queryDescend.ToList();
            SaveChanges();
            return GetAll();
        }

        public void DeletePodcastOnCategory(Category cat)
        {
            var podInCat = from pod in listOfPodcasts
                           where pod.Category.Name != cat.Name
                           select pod;

            listOfPodcasts = podInCat.ToList();
            SaveChanges();
            GetAll();
        }
    }
}
