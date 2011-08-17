using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OEmbed.Net.Utilities
{
    /// <summary>
    /// Build up the service call
    /// </summary>
    public class ServiceCallBuilder : OEmbed.Net.Utilities.IServiceCallBuilder
    {
        public ServiceCallBuilder(string apiEndpoint, string url, DataType dataType)
        {
            ApiEndpoint = HttpUtility.HtmlEncode(apiEndpoint);
            Url = HttpUtility.HtmlEncode(url);
            Type = dataType;
        }

        public ServiceCallBuilder() { }
        public ServiceCallBuilder(string apiEndpoint, string url) : this(apiEndpoint, url, DataType.json) { }
        
        public enum DataType
        {
            json,
            xml
        }

        /// <summary>
        /// The URL of the service
        /// </summary>
        public string ApiEndpoint { get; set; }
        
        /// <summary>
        /// The URL of the item to get
        /// </summary>
        public string Url { get; set; }
        
        /// <summary>
        /// The data type requested (XML/Json)
        /// </summary>
        public DataType Type { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(ApiEndpoint);
            builder.Append("?url=");
            builder.Append(Url);
            builder.Append("&format=");
            builder.Append(Type);

            return builder.ToString();
        }
    }
}
