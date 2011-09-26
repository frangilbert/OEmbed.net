using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace OEmbed.Net.Domain
{
    [DataContract]
    public class Video : Base
    {
        [DataMember(Name = "html")]
        public string Html { get; set; }

        [DataMember(Name = "width")]
        public string Width { get; set; }

        [DataMember(Name = "height")]
        public string Height { get; set; }
    }
}
