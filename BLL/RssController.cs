using DAL;
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
            RssFetcher fetcher = new RssFetcher();
            fetcher.FetchRss();
        }
    }
}
