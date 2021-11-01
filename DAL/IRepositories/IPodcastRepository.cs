using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELS;

namespace DAL
{
    public interface IPodcastRepository<T> : IMediaRepository<T> where T : Media
    {
        List<T> GetByUpdateFrequency(int uFreq);
        List<T> GetByCategory(string name);
        List<T> GetByTypeNumberOfItems(int number);
        T GetPodByName(string name);
        T GetByListOfItems(List<Item> itemList);
        

        int GetUpFreqByPodName(string name);
        Category GetCatByPodName(string name);
        int GetNumberOfItemsByPodName(string name);
        List<Item> GetItemListByPodName(string name);
        string GetItemGuidFromItenName(Media pod,string name);
        string GetItemDescriptionFromGuid(Media pod, string guid);

        Task UpdatePodcastFromRss(Media podcast);
        void UpdatePodcastCat(string olddName, string newName);
        void UpdatePodcastByName(Category cat, int freq, string oldName, string newName);

        void DeletePodcastOnCategory(Category cat);
        List<T> DescendOrder();

    }
}
