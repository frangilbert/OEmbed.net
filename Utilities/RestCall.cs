using System.IO;
using System.Net;
using System;

namespace OEmbed.Net.Utilities
{
    internal class RestCall : IRestCall
    {
        private readonly WebClient client = new WebClient();
        
        /// <summary>
        /// Download Data to get the response
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public Stream Call(string url)
        {
            WebRequest request = WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            switch (response.StatusCode)
            {
                case HttpStatusCode.NotFound:
                    throw new Exception("URL Not found");
                case HttpStatusCode.Unauthorized:
                    throw new Exception("URL Unauthorize");
                case HttpStatusCode.NotImplemented:
                    throw new Exception("OEmbed has not been implemented yet.");
            }
            
            return response.GetResponseStream ();
        }
    }
}
