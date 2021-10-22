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

        public Media (string name, string url, string type) 
        {
            this.Name = name;
            this.URL = url;
            this.Type = type;
        }

        //SKA BORT SEN E BARA FÖR ATT TESTA
        public Media()
        {
        }

        public virtual string DisplayInfo()
        {
            string hej = "";
            return hej;
        }
    }
}
