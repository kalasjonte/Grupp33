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

        public Podcast FetchRss(Podcast pod)
        {
            string url = pod.URL;
            XmlReader xmlReader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(xmlReader);

            //IEnumerable<SyndicationItem> test = feed.Items; här ska vi splitta till ny metod med IEnumerable
            pod.items = new List<Item>();


            foreach (var item in feed.Items)
            {
                Item ep = new Item(item.Title.Text, item.Summary.Text);
                pod.items.Add(ep);
                //Console.WriteLine(item.Title.Text);
                //Console.WriteLine("->" + item.Summary.Text);
            }

            pod.NumberOfItems = pod.items.Count;
            return pod;
            //upp i listview


        }
    }
}
