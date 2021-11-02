using System.Collections.Generic;
using System.Threading.Tasks;
using MODELS;

namespace DAL
{
    public interface IMediaRepository<T> : IRepository<T> where T : Media
    {
 
        List<T> GetByCategory(string name);

        T GetPodByName(string name);

        int GetNumberOfItemsByPodName(string name);


        Task UpdatePodcastFromRss(Media podcast);
        void UpdatePodcastCat(string olddName, string newName);
        void UpdatePodcastByName(Category cat, int freq, string oldName, string newName);

        void DeletePodcastOnCategory(Category cat);
        List<T> DescendOrder();

        T GetByName(string name);

    }
}
