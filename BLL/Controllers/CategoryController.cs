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

        public void SerializeCat(List<Category> categorys)
        {
            SerializerXml xml = new SerializerXml();
            xml.SerializeCategory(categorys);
        }

        public List<Category> DeSerializeCat()
        {
            SerializerXml xml = new SerializerXml();
            return xml.DeserializeCategory();
        }
    }

    
}
