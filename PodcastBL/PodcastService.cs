
using PodcastDataAccess;
using PodcastModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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

        public List<Podcast> DeSerialize()
        {
            return _podcastDataaccess.DeSerialize();
        }

        public void Initialize()
        {
            var savedPodcasts = DeSerialize();
            foreach (var p in savedPodcasts)
            {
                _podcastDataaccess.Save(p);
            }
        }

        public void Serialize()
        {
            _podcastDataaccess.Serialize();           
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


        
        public void Delete(Podcast podcast)
        {
            _podcastDataaccess.Delete(podcast);
        }
        public Podcast Get(int id)
        {
           return _podcastDataaccess.List().Where(p => p.ID == id).FirstOrDefault();
        }

        //public podcast refreshintervall

        public IEnumerable<Podcast> GetAllPodcast()
        {
            return _podcastDataaccess.List();
        }

        public void Save(Podcast podcast)
        {
            _podcastDataaccess.Save(podcast);
        }
    }
}
