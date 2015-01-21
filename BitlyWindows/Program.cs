using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitlyDotNET;
using BitlyDotNET.Interfaces;
using BitlyDotNET.Implementations;
using System.Diagnostics;

namespace BitlyWindows
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
            MainModal main = new MainModal();
            Application.Run(main);
        }
    }
}
