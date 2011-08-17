using System.IO;

namespace OEmbed.Net.Utilities
{
    internal interface IRestCall
    {
        Stream Call(string url);
    }
}
