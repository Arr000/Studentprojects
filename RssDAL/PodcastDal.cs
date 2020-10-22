using PodcastModel;
using System.Collections.Generic;
using System.Linq;

namespace PodcastDataAccess
{
    public class PodcastDal : IPodcastDal
    {
        List<Podcast> podcasts = new List<Podcast>();
        public int NextID = 0;
        public void Delete(Podcast podcast)
        {
            podcasts.Remove(podcast);
        
        }

        public IEnumerable<Podcast> List()
        {
            return podcasts;
        }

        public void Save(Podcast podcast)
        {
           if(podcast.ID == 0)
            {
                podcast.ID = ++NextID;
                podcasts.Add(podcast);
            }
            else
            {
                var savedPodcast = podcasts.Where(p => p.ID == podcast.ID).Single();
                savedPodcast.Description = podcast.Description;
                savedPodcast.Address = podcast.Address;
                savedPodcast.Items  = podcast.Items;
                
            }

        }
    }
}
