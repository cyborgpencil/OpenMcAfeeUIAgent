using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMcAfeeAgent
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check system for 32bit or 64bit
            bool envType = Environment.Is64BitOperatingSystem;
            string fileLocation32 = "C:\\Program Files\\McAfee\\Agent\\UpdaterUI.exe";
            string fileLocation64 = "C:\\Program Files\\McAfee\\Agent\\x86\\UpdaterUI.exe";

            // if 32bit
            if (envType)
            {
                ProcessStartInfo mcAfeeUI = new ProcessStartInfo(fileLocation64);
                mcAfeeUI.CreateNoWindow = true;
                
                using (Process proc = new Process())
                {
                    proc.StartInfo = mcAfeeUI;
                    proc.Start();
                }
            }
            else
            {
                ProcessStartInfo mcAfeeUI = new ProcessStartInfo(fileLocation32);
                mcAfeeUI.CreateNoWindow = true;

                using (Process proc = new Process())
                {
                    proc.StartInfo = mcAfeeUI;
                    proc.Start();
                }
            }


        }
    }
}
