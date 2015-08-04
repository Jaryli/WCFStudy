using System;
using System.Windows.Forms;
using Artech.ImageTransfer.Service;

namespace Service
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
            Application.Run(new Recevier());
        }
    }
}
