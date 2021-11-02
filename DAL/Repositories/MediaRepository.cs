using System.Collections.Generic;
using System.Linq;
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



        public int GetNumberOfItemsByPodName(string name)
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.Name == name
                           select pod.NumberOfItems;
            return podQuery.First();
        }


        public List<Media> GetByCategory(string name) 
        {
            var podQuery = from pod in listOfPodcasts
                           where pod.Category.Name == name
                           select pod;
            return podQuery.ToList();
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
