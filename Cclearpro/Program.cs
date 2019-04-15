//библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cclearpro
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Data.nameself == true)
            {
                Application.Run(new login());
                Application.Run(new main());
                Data.nameform = true;
            }
            else
            {
                Application.Run(new login());
            }
        }
        //зачем я тут пишу?
        //Ладно
        //И да это я сделал!
        //damiralmaev~!~
    }
}
