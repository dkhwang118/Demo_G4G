using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G4G_DEMO_DKH052719
{
    public class Model_MetaData
    {
        private string _fileName;
        private List<string> _elements;
        private Dictionary<string, string> _texts;




        public Model_MetaData(string fileName)
        {
            _fileName = fileName;
            _elements = new List<string>();
            _texts = new Dictionary<string, string>();
        }

        public void AddXmlElement(string elemName)
        {
            _elements.Add(elemName);
        }
    }
}
