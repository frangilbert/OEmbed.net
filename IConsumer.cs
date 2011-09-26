using OEmbed.Net.Domain;
using OEmbed.Net.Utilities;

namespace OEmbed.Net
{
    public interface IConsumer<out T> where T : Base
    {
        /// <summary>
        /// Get the oEmbed URL and return as the relevant object
        /// </summary>
        /// <param name="url">Full URL</param>
        /// <returns></returns>
        T GetObject(string url);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="dataType"></param>
        /// <returns></returns>
        T GetObject(string url, ServiceCallBuilder.DataType dataType);

        /// <summary>
        /// Make oembed call
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        T GetObject(IServiceCallBuilder builder);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="url"></param>
        /// <param name="dataType"></param>
        /// <returns></returns>
        T GetObject(Service service, string url, ServiceCallBuilder.DataType dataType);

        /// <summary>
        /// Get the oEmbed service
        /// </summary>
        /// <param name="service">Service API Endpoint to use (Templates are in Services class)</param>
        /// <param name="url">URL to get</param>
        /// <returns>Deserialized object</returns>
        T GetObject(Service service, string url);
    }
}