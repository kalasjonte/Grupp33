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
        public DateTime Update { get; set; }

        public int UpdateFrequency { get; set; }

        public Category Category { get; set; }

        public int NumberOfItems { get; set; }

        
        public List<Item> items;

        public Media(string name, string url, string type, int freq, Category cate)
        {
            this.Name = name;
            this.URL = url;
            this.Type = type;
            this.UpdateFrequency = 15;
            this.Category = cate;
            this.UpdateFrequency = freq;
            this.NumberOfItems = 0;
            UpdateTheInterval();

        }

        public Media()
        {
        }

        public bool CheckIfUpdate()
        {
            Boolean returvalue = false;
            if (Update <= DateTime.Now)
            {

                return true;
            }
            else
            {

                returvalue = false;
            }
            return returvalue;
        }

        public void UpdateTheInterval()
        {
            this.Update = DateTime.Now.AddMilliseconds(UpdateFrequency);

        }

        public virtual string DisplayInfo()
        {
            return "Namn: " + Name + ", URL: " + URL + ", Update Frequency: " + UpdateFrequency
                + ", Number of episodes: " + NumberOfItems + "\n\n";
        }
    }
}
