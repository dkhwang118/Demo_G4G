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
        public Model_MetaData GetMDTag(object fileName)
        {
            // create metaData model instance
            Model_MetaData md = new Model_MetaData((string)fileName);



            _readInXml_fromFile((string)fileName, md);




            return md;
        }

        private void _getMDfromFile(string fn, Model_MetaData model)
        {

            int _elementDepth = 0;


            // from https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmlreader.read?view=netframework-4.8

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            XmlReader reader = XmlReader.Create(fn, settings);

            reader.MoveToContent();
            // Parse the file and display each of the nodes.
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        model.AddXmlElement(reader.Name);
                        _elementDepth++;
                        Console.WriteLine("Element: <{0}> added to MD List", reader.Name);
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine("TEXT:    " + reader.Value);
                        break;
                    case XmlNodeType.CDATA:
                        Console.WriteLine("CDATA:    <![CDATA[{0}]]>", reader.Value);
                        break;
                    case XmlNodeType.ProcessingInstruction:
                        Console.WriteLine("ProcessingInstruction:    <?{0} {1}?>", reader.Name, reader.Value);
                        break;
                    case XmlNodeType.Comment:
                        Console.WriteLine("Comment:    <!--{0}-->", reader.Value);
                        break;
                    case XmlNodeType.XmlDeclaration:
                        Console.WriteLine("XmlDeclatration:     <?xml version='1.0'?>");
                        break;
                    case XmlNodeType.Document:
                        Console.WriteLine("Encountered Document!");
                        break;
                    case XmlNodeType.DocumentType:
                        Console.WriteLine("DocumentType:    <!DOCTYPE {0} [{1}]", reader.Name, reader.Value);
                        break;
                    case XmlNodeType.EntityReference:
                        Console.WriteLine("Entity Reference:    " + reader.Name);
                        break;
                    case XmlNodeType.EndElement:
                        Console.WriteLine("END ELEMENT:    </{0}>", reader.Name);
                        break;
                }
            }
        }


        private void _readInXml_fromFile(string fileName, Model_MetaData model)
        {
            // from https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmlreader.read?view=netframework-4.8

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            XmlReader reader = XmlReader.Create(fileName, settings);

            reader.MoveToContent();
            // Parse the file and display each of the nodes.
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.WriteLine("Element:    <{0}>", reader.Name);
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine("TEXT:    " + reader.Value);
                        break;
                    case XmlNodeType.CDATA:
                        Console.WriteLine("CDATA:    <![CDATA[{0}]]>", reader.Value);
                        break;
                    case XmlNodeType.ProcessingInstruction:
                        Console.WriteLine("ProcessingInstruction:    <?{0} {1}?>", reader.Name, reader.Value);
                        break;
                    case XmlNodeType.Comment:
                        Console.WriteLine("Comment:    <!--{0}-->", reader.Value);
                        break;
                    case XmlNodeType.XmlDeclaration:
                        Console.WriteLine("XmlDeclatration:     <?xml version='1.0'?>");
                        break;
                    case XmlNodeType.Document:
                        Console.WriteLine("Encountered Document!");
                        break;
                    case XmlNodeType.DocumentType:
                        Console.WriteLine("DocumentType:    <!DOCTYPE {0} [{1}]", reader.Name, reader.Value);
                        break;
                    case XmlNodeType.EntityReference:
                        Console.WriteLine("Entity Reference:    " + reader.Name);
                        break;
                    case XmlNodeType.EndElement:
                        Console.WriteLine("END ELEMENT:    </{0}>", reader.Name);
                        break;
                }
            }
        }
    }
}
