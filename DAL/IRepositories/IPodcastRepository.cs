using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELS;

namespace DAL
{
    public interface IPodcastRepository<T> : IMediaRepository<T> where T : Podcast
    {
        List<T> GetByUpdateFrequency(int uFreq);
        List<T> GetByCategory(string name);
        List<T> GetByTypeNumberOfItems(int number);
        Podcast GetPodByName(string name);
        Podcast GetByListOfItems(List<Item> itemList);

        int GetUpFreqByPodName(string name);
        Category GetCatByPodName(string name);
        int GetNumberOfItemsByPodName(string name);
        List<Item> GetItemListByPodName(string name);
        string GetItemGuidFromItenName(Podcast pod,string name);// dessa 2, vart ska d vara?
        string GetItemDescriptionFromGuid(Podcast pod, string guid);

        Task UpdatePodcastFromRss(Podcast podcast);
        void UpdatePodcastCat(string olddName, string newName);
        void UpdatePodcastByName(Category cat, int freq, string oldName, string newName);

        void DeletePodcastOnCategory(Category cat);
        List<T> DescendOrder();

    }
}
