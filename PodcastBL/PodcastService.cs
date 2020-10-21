
using PodcastModel;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Xml;

namespace PodcastBL
{
    public class PodcastService
    {
        private IPodcastDal _podcastDataaccess;

        public PodcastService(IPodcastDal podcastDataaccess)
        {
            _podcastDataaccess = podcastDataaccess;
        }

        public Podcast Load(string url)
        {
            XmlReader FD_readxml = XmlReader.Create(url);
            SyndicationFeed FD_feed = SyndicationFeed.Load(FD_readxml);
            var podcast = new Podcast();

            podcast.Address = url;
            podcast.Name = FD_feed.Title.Text;
            podcast.Episodes = FD_feed.Items.Count();
            podcast.Items= FD_feed.Items;
            podcast.Description = FD_feed.Description.Text;

            _podcastDataaccess.Save(podcast);
            
            return podcast;

        }
        
        public Podcast Get(int id)
        {
           return _podcastDataaccess.List().Where(p => p.ID == id).FirstOrDefault();
        }


        public IEnumerable<Podcast> GetAllPodcast()
        {
            return _podcastDataaccess.List();
        }
    }
}
