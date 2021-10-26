using DAL;
using MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RssController
    {
        public RssController()
        {
            
        }

        public Podcast PodcastRss(Podcast pod)
        {
            RssFetcher fetcher = new RssFetcher();
            return fetcher.FetchRss(pod);
        }
    }
}
