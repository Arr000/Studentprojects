using PodcastModel;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace PodcastDataAccess
{
    public class PodcastDal : IPodcastDal
    {
        const string xmlPodCasetFileName = "PodcastTest.xml";
        List<Podcast> podcasts = new List<Podcast>();
       

        public void Delete(Podcast podcast)
        {
           podcasts.Remove(podcast);
            Serialize();
        }

        public IEnumerable<Podcast> List()
        {
            return podcasts;
        }

        public void Save(Podcast podcast)
        {
            if (podcast.ID == 0)
            {
                podcast.ID = podcasts.Count+1;
                podcasts.Add(podcast);
            }
            else
            {
                var savedPodcast = podcasts.Where(p => p.ID == podcast.ID).Single();
                savedPodcast.Description = podcast.Description;
                savedPodcast.Address = podcast.Address;
                savedPodcast.Items = podcast.Items;
                savedPodcast.Episodes = podcast.Episodes;
                savedPodcast.Name = podcast.Name;
                savedPodcast.RefreshInterval = podcast.RefreshInterval;
                savedPodcast.Category = podcast.Category;
            }
        }
        public void Serialize()
        {
            XmlSerializer xmlserializer = new XmlSerializer(podcasts.GetType());
            using(FileStream outFile = new FileStream(xmlPodCasetFileName, FileMode.Create, FileAccess.Write))
            {
                xmlserializer.Serialize(outFile, podcasts);
            }
        }

        public List<Podcast> DeSerialize()
        {
            List<Podcast> listofPodcast;
            if (!File.Exists(xmlPodCasetFileName)) return new List<Podcast>();
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Podcast>));
            using(FileStream inFile = new FileStream(xmlPodCasetFileName, FileMode.Open, FileAccess.Read))
            {
                listofPodcast = (List<Podcast>)xmlserializer.Deserialize(inFile);
            }
            return listofPodcast;
        }
    }
}