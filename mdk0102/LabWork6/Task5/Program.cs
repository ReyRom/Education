using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    static class Program
    {
        [DllImport("kernel32.dll", EntryPoint = "GetStdHandle",
        SetLastError = true, CharSet = CharSet.Auto, CallingConvention =
        CallingConvention.StdCall)]
        public static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", EntryPoint = "AllocConsole",
        SetLastError = true, CharSet = CharSet.Auto, CallingConvention =
        CallingConvention.StdCall)]
        public static extern int AllocConsole();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0] == "-console")
                {
                    AllocConsole();
                    Console.WriteLine("test");
                    Console.ReadLine();
                }
            }
            else
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}
