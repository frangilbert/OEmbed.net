using System.IO;

namespace OEmbed.Net.Utilities
{
    public interface ISerializer<T>
    {
        string Serialize(T content);
        T Deserialize(string content);
        T Deserialize(Stream content);
    }
}
