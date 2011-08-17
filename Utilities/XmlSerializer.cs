using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OEmbed.Net.Utilities
{
    internal class XmlSerializer<T> : ISerializer<T>
    {
        private readonly DataContractSerializer _xmlSerializer = new DataContractSerializer(typeof(T));

        /// <summary>
        /// Serialize XML Content to a string
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public string Serialize(T content)
        {
            MemoryStream xmlStream = new MemoryStream();
            _xmlSerializer.WriteObject(xmlStream, content);

            string xml = Encoding.Default.GetString(xmlStream.ToArray());

            xmlStream.Close();
            xmlStream.Dispose();

            return xml;
        }

        /// <summary>
        /// Deserialize XML Content to a generic type
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public T Deserialize(string content)
        {
            MemoryStream memStream = new MemoryStream(Encoding.UTF8.GetBytes(content));
            return this.Deserialize(memStream);
        }

        /// <summary>
        /// Deserialize XML Content to a generic type
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public T Deserialize(Stream content)
        {
            T t = (T)_xmlSerializer.ReadObject(content);
            return t;
        }
    }
}
