using BarBarevich.Forms.Startup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarBarevich
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var splash = new SplashScreen())
            {
                splash.ShowDialog(); 
            }
            Application.Run(new Authorization());
        }
    }
}
