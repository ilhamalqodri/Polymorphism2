using System;

using System.IO;
using System.Xml.Serialization;

namespace polymorphism2
{
    class ConvertToXml : IConvertObject
    {
        public void Convert(Mahasiswa mhs)
        {
            using (StringWriter writer = new StringWriter())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Mahasiswa));
                serializer.Serialize(writer, mhs);

                string xml = writer.ToString();

                Console.WriteLine("Hasil Konversi ke xml :\n");
                Console.WriteLine(xml);
            }
            }
    }
}
