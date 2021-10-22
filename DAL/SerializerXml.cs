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
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Category>));
            using (FileStream fs = new FileStream("Categorys.xml", FileMode.Open, FileAccess.Read))
            {
                categories = (List<Category>)xmlSerializer.Deserialize(fs);
            }

            foreach (var item in categories)
            {
                Console.WriteLine(item.Name);
            }

            return categories;
        }

        public void SerializePodcast(List<Podcast> listOfPodcast)
        {
            //Behövs kanske en egen generic list klass för att lösa detta
            
            XmlSerializer xmlSerializer = new XmlSerializer(listOfPodcast.GetType());

            using (FileStream fs = new FileStream("Podcast.xml", FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(fs, listOfPodcast);
            }


        }

        public List<Podcast> DeserializePodcast()
        {
            List<Podcast> podcastList;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
            using (FileStream fs = new FileStream("Podcast.xml", FileMode.Open, FileAccess.Read))
            {
                podcastList = (List<Podcast>)xmlSerializer.Deserialize(fs);
            }

            foreach (var item in podcastList)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.URL);
                Console.WriteLine(item.NumberOfItems);
                foreach (var episode in item.items)
                {
                    Console.WriteLine(episode.Name);
                    Console.WriteLine(episode.Description);
                }
            }

            return podcastList;
        }



    }


}
