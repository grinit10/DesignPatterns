using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Prototype
{
    public static class Extensions
    {
        public static T DeepCopyUsingBinarySerializer<T>(T self)
        {
            var stream = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, self);
            stream.Seek(0, SeekOrigin.Begin);
            T copy = (T)formatter.Deserialize(stream);
            stream.Close();
            return copy;
        }

        public static T DeepCopyUsingXmlSerializer<T>(T self)
        {
            var stream = new MemoryStream();
            var formatter = new XmlSerializer(typeof(T));
            formatter.Serialize(stream, self);
            stream.Seek(0, SeekOrigin.Begin);
            T copy = (T)formatter.Deserialize(stream);
            stream.Close();
            return copy;
        }
    }
}
