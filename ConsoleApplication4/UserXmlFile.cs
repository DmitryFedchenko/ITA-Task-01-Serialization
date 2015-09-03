using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace HomeITA
{
    class UserXmlFile
    {
        private string textXml;
        public void CreateFileXML()
        {
            var file = new FileStream("TextXML.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var writer = new StreamWriter(file);
            writer.Close();


            var xmlWriter = new XmlTextWriter("TextXML.xml", null)
            {
                Formatting = Formatting.Indented,
                IndentChar = ' ',
                Indentation = 4,
                QuoteChar = '\''
            };
            Console.WriteLine("Файл TextXML.xml создан. \n");
            Console.ReadKey();
            string[] input = textXml.Split(',');
           
            xmlWriter.WriteStartDocument();                  
            xmlWriter.WriteStartElement("TestXml");
            var regex = new Regex(@"(?<item>\S+)");



            int k = 4;
            for (int i = 0; i <4; i++)
            {
                xmlWriter.WriteStartElement("" + regex.Match(input[i])+ "");
                xmlWriter.WriteString(input[k]);
                xmlWriter.WriteEndElement();
                k++;
            }

                xmlWriter.WriteEndElement();
            

            xmlWriter.Close();

        }

        public void ReadXMLFile()
        {
            

            FileStream stream = new FileStream("TextXML.xml", FileMode.Open);

            XmlTextReader xmlReader = new XmlTextReader(stream);

            
            while (xmlReader.Read())
            {
                Console.WriteLine("{0,-5} {1,-5} {2,-5}",
                    xmlReader.NodeType,
                    xmlReader.Name,
                    xmlReader.Value);
            }

            xmlReader.Close();
            stream.Close();

            // Delay.
            Console.ReadKey();
        }

        public UserXmlFile(string text)
        {
            textXml = text;
        }
    }
}
