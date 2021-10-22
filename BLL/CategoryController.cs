using DAL;
using MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class CategoryController
    {
        public CategoryController()
        {

        }

        public void SerializeCat(Category cat)
        {
            SerializerXml xml = new SerializerXml();
            xml.SerializeCategory(cat);
        }
    }

    
}
