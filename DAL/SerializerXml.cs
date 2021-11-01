using MODELS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace DAL
{
    public class SerializerXml
    {

        //string path = Directory.GetCurrentDirectory();

       // path += @"..\..\..\..\Dal\XML\Categories.xml";

        public SerializerXml()
        {

        }

        public void SerializeCategory(List<Category> listOfCategorys)
        {

            XmlSerializer xmlSerializer = new XmlSerializer(listOfCategorys.GetType());
            
                using (FileStream fs = new FileStream("Categorys.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(fs, listOfCategorys);
                }

        }

        public List<Category> DeserializeCategory()
        {

            List<Category> categories;
            List<Category> categoriesEmpty = new List<Category>();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Category>));

            if (File.Exists(Environment.CurrentDirectory + @"\Categorys.xml"))
            {
                using (FileStream fs = new FileStream("Categorys.xml", FileMode.Open, FileAccess.Read))
                {
                    categories = (List<Category>)xmlSerializer.Deserialize(fs);
                    return categories;
                }
            }
            else
            {
                return categoriesEmpty;
            }

        }

        public void SerializePodcast(List<Media> listOfPodcast)
        {
            
            XmlSerializer xmlSerializer = new XmlSerializer(listOfPodcast.GetType());

                using (FileStream fs = new FileStream("Podcast.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(fs, listOfPodcast);
                }         

        }

        public List<Media> DeserializePodcast()
        {
            List<Media> podcastList;
            List<Media> podcastListEmpty = new List<Media>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Media>));
            
            if (File.Exists(Environment.CurrentDirectory + @"\Podcast.xml"))
            {
                using (FileStream fs = new FileStream("Podcast.xml", FileMode.Open, FileAccess.Read))
                {
                    podcastList = (List<Media>)xmlSerializer.Deserialize(fs);
                    return podcastList;
                }
          
            }
            else
            {
                return podcastListEmpty;
            }

        }



    }


}
