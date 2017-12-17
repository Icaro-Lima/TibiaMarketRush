using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Testador
{
    class Program
    {
        static void Main(string[] args)
        {
            Process tibiaProcess = Process.GetProcessesByName("client")[0];
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine(WindowFunctions.GetWindowRectangle(tibiaProcess.MainWindowHandle));
        }
    }
}
