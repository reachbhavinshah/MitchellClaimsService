using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ClaimsService.XML
{
    /// <summary>
    /// This is helper class is used to serialize/deserilize xml to and from object
    /// </summary>
    public static class SerializationHelper
    {   
        public static T Deserialize<T>(Stream stream, string xmlNamespace = "")
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }

            var xmlSerializer = new XmlSerializer(typeof(T), xmlNamespace);
            return (T)xmlSerializer.Deserialize(stream);
        }

        public static string Serialize<T>(T typeObject, string namespacePrefix = "", string  xmlNamespace = "")
        {
            if (typeObject == null)
            {
                throw new ArgumentNullException("typeObject");
            }

            var xmlSerializerNamespace = new XmlSerializerNamespaces();
            xmlSerializerNamespace.Add(namespacePrefix, xmlNamespace);

            var xmlSerializer = new XmlSerializer(typeof(T));
            using (MemoryStream buffer = new MemoryStream())
            {
                xmlSerializer.Serialize(buffer, typeObject, xmlSerializerNamespace);
                return Encoding.UTF8.GetString(buffer.ToArray());
            }
        }
    }
}