using DAL;
using MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MediaController
    {
        public IMediaRepository<Media> podcastRepo;
        public MediaController()
        {
           podcastRepo = new MediaRepository();
        }

        public async Task<bool> FetchNewPodcastAsync(Media pod)
        {

            bool returnValue = false;

            RssFetcher rssFetcher = new RssFetcher();
            Media podcastFull = await rssFetcher.FetchRssAsync(pod);
            if(!Validation.ItemsContainsAny(podcastFull))
            {
                return returnValue;
            }
            podcastRepo.Create(podcastFull);
            podcastRepo.GetAll();

            returnValue = true;
            return returnValue;
        }

        public async Task<bool> FetchPodcastIntervalAsync(Media pod)
        {
            bool returnValue = false;

            RssFetcher rssFetcher = new RssFetcher();
            Media podcastFull = await rssFetcher.FetchRssAsync(pod);

            Task go = podcastRepo.UpdatePodcastFromRss(podcastFull);
            await go;

            returnValue = true;
            return returnValue;
           
        }


        public List<Media> GetAllPodcasts()
        {
            return podcastRepo.GetAll();
        }

        public List<Media> GetAllPodcastByCat(string name)
        {
            return podcastRepo.GetByCategory(name);
        }

        public void UpdatePodcastCat(string oldName, string newName)
        {
            podcastRepo.UpdatePodcastCat(oldName, newName);
        }

        public void UpdatePodCastByName(Category cat, int freq, string oldName, string newName)
        {
            podcastRepo.UpdatePodcastByName(cat, freq, oldName, newName);
        }


        public Media GetPodByName(string name)
        {
            return podcastRepo.GetPodByName(name);
        }

        public void DeleteOnCategory(Category cat)
        {
            podcastRepo.DeletePodcastOnCategory(cat);
        }

        public void DeletePodOnName(string name)
        {
            podcastRepo.DeleteFromName(name);
        }

    }


}
