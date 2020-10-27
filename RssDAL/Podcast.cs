using RssDALInmemory;
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
        [XmlArray("Items")]
        public ItemDescription[] Items{ get; set; }
        public string Category { get; set; }
    }
}
