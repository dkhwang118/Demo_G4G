using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G4G_DEMO_DKH052719
{
    /// <summary>
    /// Parent class that encapuslates a document's address, metadata, and necessary strings
    /// </summary>
    public class Document
    {
        private static int _docId_SSID_tick = 1;
        private int _docId_softwareSessionId;
        private int _docId_ExternalId;
        private string _xmlFileLoc;

        public Document()
        {
            _docId_softwareSessionId = _docId_SSID_tick++;
        }

        public Document(int externalId)
        {
            _docId_softwareSessionId = _docId_SSID_tick++;
            _docId_ExternalId = externalId;
        }

        public Document(string fileLocation)
        {
            _docId_softwareSessionId = _docId_SSID_tick++;
            _xmlFileLoc = fileLocation;
        }
    }
}
