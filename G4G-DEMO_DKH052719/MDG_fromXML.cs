using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace G4G_DEMO_DKH052719
{
    public class MDG_fromXML : Interface_MetaDataGenerator
    {
        public void GetMDTag(object fileName)
        {
            _readInXml_fromFile((string)fileName);
        }


        private void _readInXml_fromFile(string fielName)
        {
            // from https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmlreader.read?view=netframework-4.8

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            XmlReader reader = XmlReader.Create("items.xml", settings);

            reader.MoveToContent();
            // Parse the file and display each of the nodes.
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.WriteLine("<{0}>", reader.Name);
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.CDATA:
                        Console.WriteLine("<![CDATA[{0}]]>", reader.Value);
                        break;
                    case XmlNodeType.ProcessingInstruction:
                        Console.Write("<?{0} {1}?>", reader.Name, reader.Value);
                        break;
                    case XmlNodeType.Comment:
                        Console.WriteLine("<!--{0}-->", reader.Value);
                        break;
                    case XmlNodeType.XmlDeclaration:
                        Console.WriteLine("<?xml version='1.0'?>");
                        break;
                    case XmlNodeType.Document:
                        break;
                    case XmlNodeType.DocumentType:
                        Console.WriteLine("<!DOCTYPE {0} [{1}]", reader.Name, reader.Value);
                        break;
                    case XmlNodeType.EntityReference:
                        Console.WriteLine(reader.Name);
                        break;
                    case XmlNodeType.EndElement:
                        Console.WriteLine("</{0}>", reader.Name);
                        break;
                }
            }
        }
    }
}
