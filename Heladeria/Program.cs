using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Heladeria.FronEnd;
using Heladeria.FronEnd.Factura;
using Heladeria.FronEnd.Helado;

namespace Heladeria
{



    internal static class Program
    {
         /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frm_AltaUsuarios());
            //Application.Run(new frm_ABM_Usuario());
            //Application.Run(new frm_ABM_Helado());
            //Application.Run(new frm_ABM_Proveedor());
            Application.Run(new frm_ABM_Factura());


            //Application.Run(new frm_Escritorio());
        }
    }
}
