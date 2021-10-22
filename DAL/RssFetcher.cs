using MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL
{
    public class RssFetcher
    {
        public List<Category> categories;
        public RssFetcher()
        {

        }

        public void FetchRss()
        {

            XmlReader xmlReader = XmlReader.Create("https://www.espn.com/espn/rss/news");
            SyndicationFeed feed = SyndicationFeed.Load(xmlReader);
            Console.WriteLine("--- Title: " + feed.Title.Text);
            Console.WriteLine("--- Desc: " + feed.Description.Text);

            //IEnumerable<SyndicationItem> test = feed.Items; här ska vi splitta till ny metod med IEnumerable
            Media pod = new Media();
            pod.items = new List<Item>();


            //serializer typeof(<products>)
            //filestream
            //List<Podcast>
            //serializer.serialize(fs, product)
            //


            foreach (var item in feed.Items)
            {
                Item ep = new Item(item.Title.Text, item.Summary.Text);
                pod.items.Add(ep);
                //Console.WriteLine(item.Title.Text);
                //Console.WriteLine("->" + item.Summary.Text);
            }

            //Ner i xml fil 
            foreach (var item in pod.items)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Description);
            }

            //upp i listview


        }
    }
}
