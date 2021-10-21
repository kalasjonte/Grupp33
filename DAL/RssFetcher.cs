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
            Podcast pod = new Podcast();
            pod.episodes = new List<Episode>();


            //serializer typeof(<products>)
            //filestream
            //List<Podcast>
            //serializer.serialize(fs, product)
            //


            foreach (var item in feed.Items)
            {
                Episode ep = new Episode(item.Title.Text, item.Summary.Text);
                pod.episodes.Add(ep);
                //Console.WriteLine(item.Title.Text);
                //Console.WriteLine("->" + item.Summary.Text);
            }

            foreach (var item in pod.episodes)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Description);
            }

            
        }
    }
}
