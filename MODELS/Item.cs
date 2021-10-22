using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Item()
        {

        }

        public Item(string name, string desc)
        {
            this.Name = name;
            this.Description = desc;
        }
    }
}
