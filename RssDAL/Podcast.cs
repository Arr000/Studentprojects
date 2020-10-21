using System;
using System.Collections.Generic;
using System.Text;

namespace PodcastModel
{
    public class Podcast
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int RefreshInterval { get; set; }
        public int Episodes { get; set; }
        public string Category { get; set; }
    }
}
