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
        public PodcastController()
        {

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
