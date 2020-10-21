using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Text;

namespace PodcastModel
{
    public class Podcast
    {
        public int ID { get; internal set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int RefreshInterval { get; set; }
        public int Episodes { get; set; }

        public IEnumerable<SyndicationItem> Items{ get; set; }
        public string Category { get; set; }


    }
}
