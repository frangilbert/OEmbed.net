using System.IO;
using OEmbed.Net.Domain;
using OEmbed.Net.Utilities;

namespace OEmbed.Net
{
    public class Consumer<T> : IConsumer<T> where T : Base
    {
        private readonly IRestCall _restCall;

        public Consumer(IRestCall restCall)
        {
            _restCall = restCall;
        }
        
        public Consumer()
        {
            _restCall = new RestCall();
        }

        /// <summary>
        /// Get the oEmbed URL and return as the relevant object
        /// </summary>
        /// <param name="url">Full URL</param>
        /// <returns></returns>
        public T GetObject(string url)
        {
            //Make the call
            Stream callResponse = _restCall.Call(url);

            //Deserialize feed
            ISerializer<T> data = new JsonSerializer<T>();
            return data.Deserialize(callResponse);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="dataType"></param>
        /// <returns></returns>
        public T GetObject(string url, ServiceCallBuilder.DataType dataType)
        {
            //Make the call
            Stream callResponse = _restCall.Call(url);
            ISerializer<T> data;

            //Deserialize feed
            switch (dataType)
            {
                case ServiceCallBuilder.DataType.json:
                    data = new JsonSerializer<T>();
                    break;
                case ServiceCallBuilder.DataType.xml:
                    data = new XmlSerializer<T>();
                    break;
                default:
                    data = new JsonSerializer<T>();
                    break;
            }

            return data.Deserialize(callResponse);
        }

        /// <summary>
        /// Make oembed call
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public T GetObject(IServiceCallBuilder builder)
        {
            return GetObject(builder.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="url"></param>
        /// <param name="dataType"></param>
        /// <returns></returns>
        public T GetObject(Service service, string url, ServiceCallBuilder.DataType dataType)
        {
            //Build up the url
            IServiceCallBuilder serviceBuilder = new ServiceCallBuilder();
            serviceBuilder.ApiEndpoint = service.ApiEndpoint;
            serviceBuilder.Url = url;
            serviceBuilder.Type = dataType;

            return GetObject(serviceBuilder.ToString());
        }

        /// <summary>
        /// Get the oEmbed service
        /// </summary>
        /// <param name="service">Service API Endpoint to use (Templates are in Services class)</param>
        /// <param name="url">URL to get</param>
        /// <returns>Deserialized object</returns>
        public T GetObject(Service service, string url)
        {
            return GetObject(service, url, ServiceCallBuilder.DataType.json);
        }
    }
}
