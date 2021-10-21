using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class Episode
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Episode()
        {

        }

        public Episode(string name, string desc)
        {
            this.Name = name;
            this.Description = desc;
        }
    }
}
