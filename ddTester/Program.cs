/*
     Junk message DDoS bug testing tool for Shenzhen High School of Science

     By Jackson Ming Hu in RMIT University, Melbourne, Australia
     December 20, 2015   huming2207@gmail.com

     Warning: This tool is written for IT Management Department in SHSS only.
              I will obviously NOT publish its binary files and/or source code, 
              until they fix their bugs.
  
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ddTester
{
    static class Program
    {
        // You must remove this stuff if you want to run it on Mono Environment.
        // Then use app.manifest and set dpiAware instead.
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Add support for High-DPI screen (e.g. Macbook Pro)
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}
