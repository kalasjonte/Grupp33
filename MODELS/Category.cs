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

        public List<string> podcastsList;

        public Category (string name)
        {
            this.Name = name;
            this.podcastsList = new List<string>();
        }

        public Category()
        {

        }

        public Category (string name, List<string> podLista)
        {
            this.Name = name;
            this.podcastsList = podLista;
        }

        public void addPodcastToList(string podcast)
        {
            podcastsList.Add(podcast);
        }

    }
}
