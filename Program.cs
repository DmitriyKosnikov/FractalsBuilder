using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalsDrawer
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MessageBox.Show("Привет! Есть проблемка с кривой Коха, там надо просто ждать пока отрисуется. А еще нет доп функционала (Если не считать автоматическое перерисование при изменении размеров окна)");
            Application.Run(new Form1());
        }
    }
}
