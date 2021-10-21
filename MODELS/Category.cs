using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class Category
    {
        public string Name { get; set; }

        public List<Podcast> podcastsList;

        public Category (string name)
        {
            this.Name = name;
            this.podcastsList = new List<Podcast>();
        }

        public Category (string name, List<Podcast> podLista)
        {
            this.Name = name;
            this.podcastsList = podLista;
        }

        public void addPodcastToList(Podcast podcast)
        {
            podcastsList.Add(podcast);
        }

    }
}
