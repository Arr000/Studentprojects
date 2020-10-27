using PodcastDataAccess;
using System;
using System.Collections.Generic;

namespace PodcastModel
{
    public interface IPodcastDal : IPodCastSerializable
    {
        void Save(Podcast podcast);
        IEnumerable<Podcast> List();
        void Delete(Podcast podcast);
    }
}
