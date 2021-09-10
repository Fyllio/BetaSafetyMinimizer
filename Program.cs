using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        [DllImport("user32.dll")]

        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        static bool running = true;
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(5000);
            while (running)
            {
                foreach (Process p in Process.GetProcesses())
                {

                    if (p.ProcessName == "javaw")
                    {
                        ShowWindow(p.MainWindowHandle, 2);
                        running = false;
                    }
                }
            }
        }
    }
}