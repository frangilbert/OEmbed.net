using System;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OEmbed.Net.Utilities
{
    internal class JsonSerializer<T> : ISerializer<T>
    {
        private readonly DataContractJsonSerializer _jsonSerializer = new DataContractJsonSerializer(typeof(T));
        
        /// <summary>
        /// Serialize from Objects to JSON content
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public string Serialize(T content)
        {
            MemoryStream jsonStream = new MemoryStream();
            _jsonSerializer.WriteObject(jsonStream, content);

            string json = Encoding.Default.GetString(jsonStream.ToArray());

            jsonStream.Close();
            jsonStream.Dispose();

            return json;
        }

        /// <summary>
        /// Deserialize to objects from a JSON stream
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public T Deserialize(string content)
        {
            MemoryStream memStream = new MemoryStream(Encoding.UTF8.GetBytes(content));
            return this.Deserialize(memStream);
        }

        public T Deserialize(Stream content)
        {
            T t = (T)_jsonSerializer.ReadObject(content);
            return t;
        }
    }
}
