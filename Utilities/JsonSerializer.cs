using System.Runtime.Serialization.Json;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OEmbed.Net.Utilities
{
    internal class JsonSerializer<T> : ISerializer<T>
    {
        /// <summary>
        /// Serialize from Objects to JSON content
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public string Serialize(T content)
        {
            return JsonConvert.SerializeObject(content);
        }

        /// <summary>
        /// Deserialize to objects from a JSON stream
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public T Deserialize(string content)
        {
            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(content));
            return Deserialize(memoryStream);
        }

        public T Deserialize(Stream content)
        {
            var streamRead = new StreamReader(content);
            var deserializedObject = JsonConvert.DeserializeObject<T>(streamRead.ReadToEnd());
            return deserializedObject;
        }
    }
}
