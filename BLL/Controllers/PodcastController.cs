using DAL;
using MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PodcastController
    {
        public IPodcastRepository<Media> podcastRepo;
        public PodcastController()
        {
           podcastRepo = new PodcastRepository();
        }

        public async Task<bool> FetchNewPodcastAsync(Media pod)
        {

            bool returnvalue = false;

            RssFetcher rssFetcher = new RssFetcher();
            Media podcastFull = await rssFetcher.FetchRssAsync(pod);
            podcastRepo.Create(podcastFull);
            podcastRepo.GetAll();

            returnvalue = true;
            return returnvalue;
        }

        public async Task<bool> FetchPodcastIntervalAsync(Media pod)
        {
            bool returnvalue = false;

            RssFetcher rssFetcher = new RssFetcher();
            Media podcastFull = await rssFetcher.FetchRssAsync(pod);

            Task go = podcastRepo.UpdatePodcastFromRss(podcastFull);
            await go;

            returnvalue = true;
            return returnvalue;
        }

        public void SerializePodcasts(List<Media> podList)
        {
            SerializerXml serializer = new SerializerXml();
            serializer.SerializePodcast(podList);
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

        public List<Media> OrderByDescending()
        {
            return podcastRepo.DescendOrder();
        }

        public Media GetPodByName(string name)
        {
            return podcastRepo.GetPodByName(name);
        }


        public int getNumberOfEpisodes(string name)
        {
            return podcastRepo.GetNumberOfItemsByPodName(name);
        }

        public void DeleteOnCategory(Category cat)
        {
            podcastRepo.DeletePodcastOnCategory(cat);
        }

        public void DeletePodOnName(string name)
        {
            podcastRepo.DeleteFromName(name);
        }

        public List<Media> GetMediaListOnName(string name)
        {
           return podcastRepo.GetMediaListOnName(name);
        }
    }


}
