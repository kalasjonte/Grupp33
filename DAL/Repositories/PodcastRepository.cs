using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELS;

namespace DAL
{
    class PodcastRepository : IPodcastRepository<Podcast>
    {
        public void Create(Podcast entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int index)
        {
            throw new NotImplementedException();
        }

        public List<Podcast> GetAll()
        {
            throw new NotImplementedException();
        }

        public Podcast GetByCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public Podcast GetByListOfItems(List<Item> itemList)
        {
            throw new NotImplementedException();
        }

        public Podcast GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Podcast GetByType(string type)
        {
            throw new NotImplementedException();
        }

        public Podcast GetByTypeNumberOfItems(int number)
        {
            throw new NotImplementedException();
        }

        public Podcast GetByUpdateFrequency(int uFreq)
        {
            throw new NotImplementedException();
        }

        public Podcast GetByUrl(string url)
        {
            throw new NotImplementedException();
        }

        public Category GetCatByPodName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Item> GetItemListByPodName(string name)
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfItemsByPodName(string name)
        {
            throw new NotImplementedException();
        }

        public int GetUpFreqByPodName(string name)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(int index, Podcast entity)
        {
            throw new NotImplementedException();
        }
    }
}
