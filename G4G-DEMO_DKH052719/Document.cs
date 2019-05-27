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


        public Document()
        {
            _docId_softwareSessionId = _docId_SSID_tick++;
        }
    }
}
