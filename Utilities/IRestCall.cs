using System.IO;

namespace OEmbed.Net.Utilities
{
    public interface IRestCall
    {
        Stream Call(string url);
    }
}
