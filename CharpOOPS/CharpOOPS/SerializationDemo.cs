using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CharpOOPS
{
    [Serializable]
    public class Demo
    {
        public string ApplicationName { get; set; }// = "Binary Serialize";
        public int ApplicationId { get; set; }// = 1001;
       
    }
    class SerializationDemo
    {
        public static void Serialize()
        {
            //object ->binaryformatter serialize()
            //object <-binaryformatter deserialize();
            Demo sample = new Demo();
            sample.ApplicationId = 1001;
            sample.ApplicationName = "Binary";
            FileStream fileStream = new FileStream(@"C:\Test\binary.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);
            fileStream.Close();
        }
        public static void DeSeriazlize()
        {
            FileStream fileStream = new FileStream(@"C:\Test\binary.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializedSampledemo =(Demo) formatter.Deserialize(fileStream);
            Console.WriteLine($"ApplicationName { deserializedSampledemo.ApplicationName} --- ApplicationId       { deserializedSampledemo.ApplicationId}");
            fileStream.Close();
        }

        public static void XMLSerialize(AddressDetails details)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AddressDetails));
            using (TextWriter writer = new StreamWriter(@"C:\Test\XmlData.xml"))
            {
                serializer.Serialize(writer, details);
            }
        }
        public static void XMLDeSerialize(string xmlPath)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(AddressDetails));
            TextReader reader = new StreamReader(xmlPath);
            object obj = deserializer.Deserialize(reader);
            AddressDetails XmlData = (AddressDetails)obj;
            Console.WriteLine(XmlData.City);
            reader.Close();
        }
    }

    public class AddressDetails
    {
        public int HouseNo { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        private string PoAddress { get; set; }
    }
}
