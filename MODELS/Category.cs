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

        public List<Media> podcastsList;

        public Category (string name)
        {
            Console.WriteLine("skapad sånhär");
            this.Name = name;
            this.podcastsList = new List<Media>();
            Console.WriteLine(Name);
        }

        public Category (string name, List<Media> podLista)
        {
            this.Name = name;
            this.podcastsList = podLista;
        }

        public void addPodcastToList(Media podcast)
        {
            podcastsList.Add(podcast);
        }

    }
}
