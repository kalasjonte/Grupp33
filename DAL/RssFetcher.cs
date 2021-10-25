using MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
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

        public Podcast FetchRss(Podcast pod)
        {
            
                string url = pod.URL;
                XmlReader xmlReader = XmlReader.Create(url);
                SyndicationFeed feed = SyndicationFeed.Load(xmlReader);

                //IEnumerable<SyndicationItem> test = feed.Items; här ska vi splitta till ny metod med IEnumerable
                pod.items = new List<Item>();
                
            try
            {
                foreach (var item in feed.Items)
            {
                // kanske ändra till validering?
                

                    Item ep = new Item(item.Title.Text, item.Summary.Text);

                    pod.items.Add(ep);
                    //Console.WriteLine(item.Title.Text);
                    //Console.WriteLine("->" + item.Summary.Text);

                }
                }
            catch (Exception e)
            {
                
                MessageBox.Show("Rss hämtaren kunde ej hitta ITEM title eller så kunde den inte hitta item DESCRIPTION, felskriven rss? Kontrollera hemsidan");
            }

            pod.NumberOfItems = pod.items.Count;
            return pod;
            //upp i listview

        }


        public async Task<Podcast> FetchRssAsync(Podcast pod)
        {

            string url = pod.URL;
            XmlReader xmlReader = XmlReader.Create(url);
            Task<SyndicationFeed> taskAvsnitt = Task.Run(()=>SyndicationFeed.Load(xmlReader));
            SyndicationFeed feed = await taskAvsnitt;
            pod.items = new List<Item>();
            pod.NumberOfItems = feed.Items.Count();
            

            try
            {
                foreach (var item in feed.Items)
                {
                    


                    Item ep = new Item(item.Title.Text, item.Summary.Text);

                    pod.items.Add(ep);
                    

                }

                
            }
            catch (Exception e)
            {

                MessageBox.Show("Rss hämtaren kunde ej hitta ITEM title eller så kunde den inte hitta item DESCRIPTION, felskriven rss? Kontrollera hemsidan");
            }
            
            return pod;
            //upp i listview

        }



    }
}

