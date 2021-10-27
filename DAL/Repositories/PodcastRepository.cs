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
        SerializerXml serializerXml;
        List<Podcast> listOfPodcasts;
        //CRUDO
        public PodcastRepository()
        {
            serializerXml = new SerializerXml();
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

        public List<Podcast> GetByCategory(Category category)  // kan fucka kanske, ger han rätt lista tbx?
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.Category.Name == category.Name
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
    }
}
