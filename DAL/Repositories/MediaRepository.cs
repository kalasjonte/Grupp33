using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELS;

namespace DAL
{
    public class MediaRepository : IMediaRepository<Media>
    {
        SerializerXml serializerXml = new SerializerXml();
        List<Media> listOfPodcasts;
        
        public MediaRepository()
        {
            listOfPodcasts = new List<Media>();
            listOfPodcasts = GetAll();
        }
        public void Create(Media entity)
        {
            
            listOfPodcasts.Add(entity);
            SaveChanges();
            GetAll();
            
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

        public List<Media> GetAll()
        {
             return serializerXml.DeserializePodcast();

        }

        public void SaveChanges()
        {
            serializerXml.SerializePodcast(listOfPodcasts);
        }

        public void Update(int index, Media entity)
        {
            listOfPodcasts[index] = entity;
            SaveChanges();
        }


        public Media GetByName(string name)
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.Name == name
                           select pod;
            if (podQuery.Count() > 0)
            {
                return podQuery.First();
            }
            else return null;

        }

        public Media GetByType(string type)  // Returnerar en pod men ska returnera en list, ta bort?
        {
            throw new NotImplementedException();
        }
        public Media GetByUrl(string url)
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.URL == url
                           select pod;
            return podQuery.First();
        }

        
        public Media GetByListOfItems(List<Item> itemList)
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.items == itemList
                           select pod;
            return podQuery.First();
        }


        public List<Media> GetByTypeNumberOfItems(int number)
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.NumberOfItems == number 
                           select pod;
            return podQuery.ToList();
        }

        public List<Media> GetByUpdateFrequency(int uFreq)
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

        public List<Media> GetByCategory(string name)  // ska vi ha fler respos?
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.Category.Name == name
                           select pod;
            return podQuery.ToList();
        }

        public string GetItemGuidFromItenName(Media pod, string name)
        {
            var itemQuery = from item in pod.items
                        where item.Name == name
                        select item.Guid;


            return itemQuery.First();
        }

        public string GetItemDescriptionFromGuid(Media pod, string guid)
        {
            var itemQuery = from item in pod.items
                        where item.Guid == guid
                        select item.Description;

            return itemQuery.First();
        }

        public List<Media> SortDesending()
        {
            var podQuery = from pod in listOfPodcasts
                           orderby pod.Name
                           select pod;

             listOfPodcasts = podQuery.ToList();
            return listOfPodcasts;
        }

        public  Task UpdatePodcastFromRss(Media podcast)
        {
            
            var podQuery = from pod in listOfPodcasts
                           where pod.Name != podcast.Name
                           select pod;
            
            listOfPodcasts = podQuery.ToList();
            Create(podcast);
            GetAll();
            return Task.CompletedTask;
        }

        public void UpdatePodcastCat(string oldName, string newName)
        {

            List<Media> oldList = GetByCategory(oldName);

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
            Media podcast = GetByName(oldName);   
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

        public Media GetPodByName(string name)
        {
            listOfPodcasts = GetAll();
            var podQuery = from pod in listOfPodcasts
                           where pod.Name == name
                           select pod;

           
           
            if (podQuery.Count() > 0)
            {
                return podQuery.First();
            }
            else return null;
        }

        public List<Media> DescendOrder()
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
