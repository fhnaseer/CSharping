using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Library.Standard
{
    public static class XmlObjectSerializer
    {
        public static void WriteXml<T>(string path, T source)
        {

            WriteXml(path, source, false);
        }

        public static void WriteXml<T>(string path, T source, bool skipNamespace)
        {
            File.WriteAllText(path, Serialize(source, skipNamespace).ToString());
        }

        public static XDocument Serialize<T>(T source)
        {
            return Serialize(source, false);
        }

        public static XDocument Serialize<T>(T source, bool skipNamespace)
        {
            var target = new XDocument();
            var serializer = new XmlSerializer(typeof(T));
            using (var writer = target.CreateWriter())
            {
                if (skipNamespace)
                {
                    var ns = new XmlSerializerNamespaces();
                    ns.Add(string.Empty, string.Empty);
                    serializer.Serialize(writer, source, ns);
                }
                else
                    serializer.Serialize(writer, source);
            }

            return target;
        }

        public static T Read<T>(string path)
        {
            return Deserialize<T>(XDocument.Load(path));
        }

        public static T Deserialize<T>(XNode document)
        {
            if (document is null)
                throw new ArgumentNullException(nameof(document));

            var serializer = new XmlSerializer(typeof(T));

            T result;
            using (var reader = document.CreateReader())
                result = (T)serializer.Deserialize(reader);

            return result;
        }
    }
}
