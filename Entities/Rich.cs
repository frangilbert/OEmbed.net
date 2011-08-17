using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace OEmbed.Net.Entities
{
    [DataContract]
    public class Rich : Base
    {
        [DataMember(Name = "html")]
        public string Html { get; set; }

        [DataMember(Name = "width")]
        public string Width { get; set; }

        [DataMember(Name = "height")]
        public string Height { get; set; }
    }
}
