using PodcastModel;
using System.Collections.Generic;
using System.Linq;

namespace PodcastDataAccess
{
    public class PodcastDal : IPodcastDal
    {
        List<Podcast> podcasts = new List<Podcast>();
        public void Delete(Podcast podcast)
        {
            podcasts.Remove(podcast);
        }

        public IEnumerable<Podcast> List()
        {
            return podcasts.ToList();
        }

        public void Save(Podcast podcast)
        {
            podcasts.Add(podcast);
        }
    }
}
