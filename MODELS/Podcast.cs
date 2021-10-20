using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class Podcast
    {
        public string Name { get; set; }
        public int NumberOfEpisodes { get; set; }
        public string UpdateFrequency { get; set; }

        public Category Category { get; set; }

        public List<Episode> episodes;

        public Podcast ()
        {

        }
    }
}
