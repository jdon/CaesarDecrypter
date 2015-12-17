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
            m = new Gui(); // creates the main gui
            Application.Run(m);// starts the main gui
        }

        public static void writeToConsole(String text) // prints to the black textbox on screen
        {
            m.getTextBox().AppendText(text);
        }

        public static Gui getGui()
        {
            return m;
        }

        public static bool isCoPrime(int a) // uses euclidean algorithm to determine the coprime integers of 26
        {
            int b = 26;
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            if (Math.Max(a, b) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
