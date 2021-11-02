using MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DAL
{
    public class RssFetcher
    {
        public RssFetcher()
        {
        }
        public async Task<Media> FetchRssAsync(Media media)
        {
            Media pod = media;
           
            string url = pod.URL;
            XmlReader xmlReader = XmlReader.Create(url);
           
            
            
            Task<SyndicationFeed> taskAvsnitt = Task.Run(() => SyndicationFeed.Load(xmlReader));
            SyndicationFeed feed = await taskAvsnitt;
            pod.items = new List<Item>(); 
            pod.NumberOfItems = feed.Items.Count();
            bool check = Checkit(url);
            if (check == true)
            {
                    foreach (var item in feed.Items)
                    {
                        if (item.Summary != null)
                        {
                            Item ep = new Item(item.Title.Text, item.Summary.Text, item.Id);

                            pod.items.Add(ep);
                        }
                        else
                        {
                            MessageBox.Show("Denna podcasten " + pod.Name + "har ingen summary / title på avsnittet, så därav har han inte instansierats korrekt");
                            return pod;
                        }
                    }
                
                return pod;
            }
            return pod;



        }

        public bool Checkit(string url)
        {
            bool king = false;
            XmlReader xmlReader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(xmlReader);
            foreach (var item in feed.Items)
            {
                if(item.Summary == null)
                {
                    return false;
                    
                }
                
            }
            king = true;
            return king;
        }

    }
}

