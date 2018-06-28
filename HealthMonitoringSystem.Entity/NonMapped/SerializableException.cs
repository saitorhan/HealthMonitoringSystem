using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace HealthMonitoringSystem.Entity
{
    [XmlRoot("exception")]
    public class SerializableException
    {
        [XmlElement("message")]
        public string Message { get; set; }

        [XmlElement("innerException")]
        public SerializableException InnerException { get; set; }

        public static string GetXmlString(Exception exception)
        {
            if (exception == null) throw new ArgumentNullException("exception");
            StringWriter sw = new StringWriter();
            using (XmlWriter xw = XmlWriter.Create(sw))
            {
                WriteException(xw, "exception", exception);
            }
            return sw.ToString();
        }
        static void WriteException(XmlWriter writer, string name, Exception exception)
        {
            if (exception == null) return;
            writer.WriteStartElement(name);
            writer.WriteElementString("message", exception.Message);
            writer.WriteElementString("source", exception.Source);
            WriteException(writer, "innerException", exception.InnerException);
            writer.WriteEndElement();
        }
    }
}