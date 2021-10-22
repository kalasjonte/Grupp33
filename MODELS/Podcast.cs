using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class Podcast : Media
    {
        public int UpdateFrequency { get; set; }

        public Category Category { get; set; }

        public int NumberOfItems { get; set; }

        
        public List<Item> items;

        public Podcast(string name, string url, string type, int freq, Category cate) : base(name, url, type)
        {
            this.Category = cate;
            this.UpdateFrequency = freq;
            this.NumberOfItems = 0;
        }
        public Podcast()
        {
            base.Name = "test";
            base.URL = "test";
            this.UpdateFrequency = 15;
        }
    }
}
