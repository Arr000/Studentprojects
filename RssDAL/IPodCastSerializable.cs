using PodcastModel;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;

namespace PodcastDataAccess
{
    public interface IPodCastSerializable
    {
        void Serialize();
        List<Podcast> DeSerialize();
    }
}