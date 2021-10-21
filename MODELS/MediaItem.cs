using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class MediaItem
    {
        public string Url { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public MediaItem(string url, string name, string type)
        {
            this.Url = url;
            this.Name = name;
            this.Type = type;
        }

        public virtual string DisplayInfo ()
        {
            return "Du har skapat en " + Type + "/nMed adressen: " + Url + "/nsom har namnet: " + Name;
        }
    }
}
