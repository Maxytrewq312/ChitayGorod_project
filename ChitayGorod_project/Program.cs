using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChitayGorod_project
{
    static class Program
    {
        public static ChitayGorod_projectEntities1 CGDb = new ChitayGorod_projectEntities1();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAutorization());
        }
    }
}
