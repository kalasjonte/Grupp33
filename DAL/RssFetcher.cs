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

            //XmlReader xmlReader = XmlReader.Create("https://www.espn.com/espn/rss/news");
            //SyndicationFeed feed = SyndicationFeed.Load(xmlReader);
            //Console.WriteLine("--- Title: " + feed.Title.Text);
            //Console.WriteLine("--- Desc: " + feed.Description.Text);
            ////Podcast pod = new Podcast(feed.Title.Text);

            //serializer typeof(<products>)
            //filestream
            //List<Podcast>
            //serializer.serialize(fs, product)
            //


            //foreach (var item in feed.Items)
            //{
            // Episode ep = new Ep(item.title.text, item.title.desc)
            //Episodelista.add(ep);
            //    Console.WriteLine(item.Title.Text);
            //    Console.WriteLine("->" + item.Summary.Text);
            //}
        }
    }
}
