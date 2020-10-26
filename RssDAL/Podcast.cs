using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel.Syndication;
using System.Text;
using System.Xml.Serialization;

namespace PodcastModel
{
    public class Podcast
    {
       
        [XmlIgnore]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int RefreshInterval { get; set; }
        public int Episodes { get; set; }
        [System.Xml.Serialization.XmlIgnore]
        public IEnumerable<SyndicationItem> Items{ get; set; }
        public string Category { get; set; }

        public double UpdateInterval { get; set; }
        public DateTime nextUpdate { get; set; }

        public Podcast() { }

        public Podcast(double intervall)
        {
            UpdateInterval = intervall;
        }

        public bool NeedsUpdate
        {
            get
            {
                return nextUpdate <= DateTime.Now;
            }
        }

        public DateTime Update()
        {
            nextUpdate = DateTime.Now.AddMinutes(UpdateInterval);
            return nextUpdate;
        }

    }
}
