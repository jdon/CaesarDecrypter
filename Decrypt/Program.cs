using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decrypt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        private static Gui m;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            m = new Gui();
            Application.Run(m);
        }

        public static void WriteText(String text) {
            m.getTextBox().AppendText(text);
        }

        public static Gui getGui() {
            return m;
        }
    }
}
