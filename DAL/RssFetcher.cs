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
        public List<Category> categories;
        public RssFetcher()
        {
        }
        public async Task<Media> FetchRssAsync(Media media)
        {
            Media pod = media;
           
            string url = pod.URL;
            XmlReader xmlReader = XmlReader.Create(url);
            //XmlDocument.Validate();: https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmldocument.validate?view=net-5.0
            
            
            Task<SyndicationFeed> taskAvsnitt = Task.Run(() => SyndicationFeed.Load(xmlReader));
            SyndicationFeed feed = await taskAvsnitt;
            pod.items = new List<Item>();
            pod.NumberOfItems = feed.Items.Count();

            try
            {
                foreach (var item in feed.Items)
                {
                    Item ep = new Item(item.Title.Text, item.Summary.Text,item.Id);
                   
                    pod.items.Add(ep);
                }           
            }
            catch (Exception e)
            {
                MessageBox.Show("Rss hämtaren kunde ej hitta ITEM title eller så kunde den inte hitta item DESCRIPTION, felskriven rss? Kontrollera hemsidan");
            }
            return pod;
            
        }

    }
}

