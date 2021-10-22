using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class Media
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public string Type { get; set; }
        public int UpdateFrequency { get; set; }

        public Category Category { get; set; }

        public int NumberOfItems { get; set; }

        public List<Item> items;

        public Media (string name, string url, string type, int freq , Category cate) 
        {
            this.Name = name;
            this.URL = url;
            this.Type = type;
            this.Category = cate;
            this.UpdateFrequency = freq;
            this.NumberOfItems = 0;
            
        }

        //SKA BORT SEN E BARA FÖR ATT TESTA
        public Media()
        {
            this.URL = "test";
            this.Name = "test";
            this.UpdateFrequency = 15;
        }

        public virtual string DisplayInfo()
        {
            string hej = "";
            return hej;
        }
    }
}
