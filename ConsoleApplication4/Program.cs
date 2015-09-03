using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeITA
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleFile mySimpleFile = new SimpleFile();
            mySimpleFile.CreateFile();

            var userXml = new UserXmlFile(mySimpleFile.FileText);
            userXml.CreateFileXML();
            userXml.ReadXMLFile();
        }
    }
}
