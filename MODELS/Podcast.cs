using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class Podcast : MediaItem
    {
        public int NumberOfEpisodes { get; set; }
        public int UpdateFrequency { get; set; }

        public Category Category { get; set; }

        public List<Episode> episodes;

        public Podcast (string name, Category cate, int freq, string url, string type) : base(url, name, type)
        {
            
            this.Category = cate;
            this.UpdateFrequency = freq;
            this.NumberOfEpisodes = 11;
            Console.WriteLine("hej nu skapades pod " + Name);
        }

        public override string DisplayInfo()
        {
            string baseString = base.DisplayInfo();
            baseString += "/n med kategorin " + Category + "/nsom har " + NumberOfEpisodes.ToString() + " avsnitt";
            return baseString;
        }
    }
}
