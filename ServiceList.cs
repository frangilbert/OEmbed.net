using System;
using OEmbed.Net.Entities;

namespace OEmbed.Net
{
    /// <summary>
    /// A list of current API Endpoints
    /// </summary>
    public static class ServiceList
    {
        public static Service Flickr
        {
            get
            { 
                return new Service{ApiEndpoint = "http://www.flickr.com/services/oembed/" };
            }
        }

        public static Service YouTube
        {
            get
            {
                return new Service { ApiEndpoint = "http://www.youtube.com/oembed" };
            }
        }

        public static Service Viddler
        {
            get
            {
                return new Service { ApiEndpoint = "http://lab.viddler.com/services/oembed/" };
            }
        }

        public static Service Qik
        {
            get
            {
                return new Service { ApiEndpoint = "http://revision3.com/api/oembed/" };
            }
        }

        public static Service Revision3
        {
            get
            {
                return new Service { ApiEndpoint = "http://revision3.com/api/oembed/" };
            }
        }

        public static Service Hulu
        {
            get
            {
                return new Service { ApiEndpoint = "http://www.hulu.com/api/oembed.json" };
            }
        }

        public static Service Vimeo
        {
            get
            {
                return new Service { ApiEndpoint = "http://www.vimeo.com/api/oembed.json" };
            }
        }

        public static Service OohEmbed
        {
            get
            {
                return new Service { ApiEndpoint = "http://oohembed.com/oohembed/" };
            }
        }

        public static Service PollEverywhere
        {
            get
            {
                return new Service { ApiEndpoint = "http://www.polleverywhere.com/services/oembed/" };
            }
        }

        public static Service MyOpera
        {
            get
            {
                return new Service { ApiEndpoint = "http://my.opera.com/service/oembed" };
            }
        }

        public static Service ClearSpring
        {
            get
            {
                return new Service { ApiEndpoint = "http://widgets.clearspring.com/widget/v1/oembed/" };
            }
        }
    }
}
