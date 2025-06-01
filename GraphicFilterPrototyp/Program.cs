using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace GraphicFilter
{
    static class Program
    {
        public const string cppFunctionsDLL = @"..\..\..\Debug\CppCode.dll";

        [DllImport(cppFunctionsDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int intAdd(int a, int b);


        [DllImport(cppFunctionsDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern string cppImageFilter(string fileName);
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
       {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
