using System;
namespace OEmbed.Net.Utilities
{
    public interface IServiceCallBuilder
    {
        string ApiEndpoint { get; set; }
        string ToString();
        ServiceCallBuilder.DataType Type { get; set; }
        string Url { get; set; }
    }
}
