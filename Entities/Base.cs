using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Web;
using System.Runtime.Serialization;

namespace OEmbed.Net.Entities
{
    [DataContract]
    public class Base
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "version")]
        public string Version { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "author_name")]
        public string AuthorName { get; set; }

        [DataMember(Name = "author_url")]
        public string AuthorUrl { get; set; }

        [DataMember(Name = "provider_name")]
        public string ProviderName { get; set; }

        [DataMember(Name = "provider_url")]
        public string ProviderUrl { get; set; }

        [DataMember(Name = "cache_age")]
        public string CacheAge { get; set; }

        [DataMember(Name = "thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [DataMember(Name = "thumbnail_width")]
        public string ThumbnailWidth { get; set; }

        [DataMember(Name = "thumbnail_height")]
        public string ThumbnailHeight { get; set; }
    }
}
