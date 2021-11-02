using MODELS;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
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
                    foreach (var item in feed.Items)
                    {
                        if (item.Summary != null)
                        {
                            Item ep = new Item(item.Title.Text, item.Summary.Text, item.Id);

                            pod.items.Add(ep);
                        }
                        else
                        {
                           
                            return pod;
                        }
                    }
                
                return pod;
        }

        

    }
}

