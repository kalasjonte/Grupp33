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
        public List<Podcast> podList = new List<Podcast>();
        public PodcastController()
        {
            podList = DeserializePodcast();
        }

        public async Task<bool> FetchNewPodcastAsync(Podcast pod)
        {

                bool returnvalue = false;
                RssFetcher rssFetcher = new RssFetcher();
                Podcast podcastFull = await rssFetcher.FetchRssAsync(pod);
                podList = DeserializePodcast();
                podList.Add(podcastFull);
               //SerializePodcasts(podList); //behövs inte för vi serialiserar på frekvens
                //en lista av poddar , ha kvar eller inte
                returnvalue = true;
                return returnvalue;
            

        }

        public async Task<bool> FetchPodcastIntervalAsync(Podcast pod)
        {
            bool returnvalue = false;
            RssFetcher rssFetcher = new RssFetcher();
            Podcast podcastFull = await rssFetcher.FetchRssAsync(pod);


            var podQuery = from podis in podList
                           where podis.Name != pod.Name
                           select podis;

            podList = podQuery.ToList();
            podList.Add(podcastFull);
            SerializePodcasts(podList);
            podList = DeserializePodcast();  //en lista av poddar , ha kvar eller inte
            returnvalue = true;
            return returnvalue;


        }



        public void SerializePodcasts(List<Podcast> podList)
        {
            SerializerXml serializer = new SerializerXml();
            serializer.SerializePodcast(podList);
        }

        public List<Podcast> DeserializePodcast()
        {
            SerializerXml serializer = new SerializerXml();
            return serializer.DeserializePodcast();
        }

    }


}
