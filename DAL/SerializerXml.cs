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

            //string path = Directory.GetCurrentDirectory();
            //path += @"..\..\..\..\Dal\XML\Categories.xml";
            XmlSerializer xmlSerializer = new XmlSerializer(listOfCategorys.GetType());
            //XmlWriterSettings settings = new XmlWriterSettings();
            ////settings.Indent = true;
            //XmlWriter writer = XmlWriter.Create("Kategorier.xml", settings);
            //Category king = cat;
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

        //public void SerializeCategory(Category cat)
        //{
        //    string path = Directory.GetCurrentDirectory();
        //    path += @"..\..\..\..\Dal\XML\Categories.xml";
        //    XmlWriterSettings settings = new XmlWriterSettings();
        //    settings.OmitXmlDeclaration = true;



        //        XElement categories = XElement.Load(path);
        //    categories = new XElement("Categories",
        //        new XElement("Category",
        //        new XElement("Name", cat.Name),
        //        new XElement("Podcasts",
        //        new XElement("Podcast", "Placeholder")
        //        )));
        //    //using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
        //    using (StringWriter fs = new StringWriter())
        //    using (XmlWriter writer = XmlWriter.Create(path, settings))
        //    {
        //        categories.Save(fs);
        //        writer.Close();
        //        fs.Close();
        //    }



        //}

        public void SerializeCategory(Category cat)
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            XmlSerializer serialize = new XmlSerializer(typeof(Category));
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            settings.IndentChars = "    ";
            settings.NewLineOnAttributes = true;

            string path = Directory.GetCurrentDirectory();

            path += @"..\..\..\..\Dal\XML\Categories.xml"; //Det gick inte att hitta en del av sökvägen C:\Users\jonat\Documents\GitHub\Grupp33\.
            XmlDocument xdoc = new XmlDocument();  //C:\Users\jonat\Documents\GitHub\Grupp33\   DAL\XML path + @"DAL\XML\
            xdoc.Load(path);
            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            //using (StringWriter stream = new StringWriter())
            using (XmlWriter writer = XmlWriter.Create(fs, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Categories");

                serialize.Serialize(writer, cat, ns);
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
                fs.Close();
            }


            //var rootNode = xdoc.GetElementsByTagName("Categories")[0];
            //using (XmlWriter writer = rootNode.CreateNavigator().AppendChild())
            //{
            //    new XmlSerializer(cat.GetType()).Serialize(writer,cat);
            //}


        }

    }


}
