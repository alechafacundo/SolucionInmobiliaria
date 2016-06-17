using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InmobiliariaForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //En este new va el Formulario que arranca la aplicación,
            // por ejemplo, si queres que inicie en frmInmueble el codigo sria:
            //Application.Run(new frmInmueble());

            ServiceHelper.Connect();
            Application.Run(new Prueba());
        }
    }
}
