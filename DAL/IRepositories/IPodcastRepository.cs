using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELS;

namespace DAL
{
    interface IPodcastRepository<T> : IMediaRepository<T> where T : Podcast
    {
        Podcast GetByUpdateFrequency(int uFreq);
        Podcast GetByCategory(Category category);
        Podcast GetByTypeNumberOfItems(int number);
        Podcast GetByListOfItems(List<Item> itemList);

        int GetUpFreqByPodName(string name);
        Category GetCatByPodName(string name);
        int GetNumberOfItemsByPodName(string name);
        List<Item> GetItemListByPodName(string name);

    }
}
