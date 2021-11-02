using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class Podcast : Media
    {
        private DateTime SubscriptionDate {get; set;}

        public Podcast(string name, string url, string type, int freq, Category cate) :base(name, url, type, freq, cate)
        {
            this.SubscriptionDate = DateTime.Now;
            
        }

        public Podcast()
        {

        }

        public override string DisplayInfo()
        {
            return "Det här podden kommer läggas till i ditt flöde:\n" + base.DisplayInfo() + "\n du började prenumerera" + SubscriptionDate.ToString();
        }
    }
}

