using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G4G_DEMO_DKH052719
{
    static class G4G
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           // Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Console.WriteLine("******** DEBUG START*******\n");

            MDG_fromXML generator = new MDG_fromXML();
            generator.GetMDTag(@"C:\\Users\\David\\source\\repos\\G4G-DEMO_DKH052719\\G4G-DEMO_DKH052719\\XML_Bills\\H. R. 1027 (Introduced-in-House).xml");

            Console.ReadLine();

        }
    }
}
