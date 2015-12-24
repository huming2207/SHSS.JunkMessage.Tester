using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http; // You may need to add this library manually by NuGet if you force re-compile this project by using .NET 4.0 or Mono.
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ddTester
{
    class Controller
    {
        public static class ctrlVar
        {
            public static string comment = string.Empty;
            public static string name = string.Empty;
            public static string email = string.Empty;
            public static string phone = "13800138000";
            public static string title = string.Empty;
            public static int thread = 10;
            public static int runTimes = 500;
            public static int returnProgress = 0 ;
            public static string returnResult = string.Empty;
            public static bool noResult = false;
        }

        public static  async Task SendHTTP()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("http://www.szkegao.net/feedmail.aspx?txtUserName=" + ctrlVar.name + // Add name and main URL
                "&txtUserTel=" + ctrlVar.phone + // Add phone text
                "&txtUserEmail=" + ctrlVar.email  // Add Email text
                + "&txtTitle=" + ctrlVar.title  // Add title text
                + "&txtContent=" + ctrlVar.comment // Add comment text
                + "&txtCode=TRMO&btnSubmit=%E5%8F%91%E8%A1%A8%E7%95%99%E8%A8%80"); // I don't know what the hell it is here, but it does work.
            //ReleaseMemory(true);
            
           if(ctrlVar.noResult == false)
           {
               ctrlVar.returnResult += response.ToString() + "\r\n";
           }
           
        }
        


        // This function originally came from Shadowsocks-CSharp.
        // For controlling memory leak.

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetProcessWorkingSetSize(IntPtr process,
            UIntPtr minimumWorkingSetSize, UIntPtr maximumWorkingSetSize);

        public static void ReleaseMemory(bool removePages)
        {
            // release any unused pages
            // making the numbers look good in task manager
            // this is totally nonsense in programming
            // but good for those users who care
            // making them happier with their everyday life
            // which is part of user experience
            GC.Collect(GC.MaxGeneration);
            GC.WaitForPendingFinalizers();
            if (removePages)
            {
                // as some users have pointed out
                // removing pages from working set will cause some IO
                // which lowered user experience for another group of users
                //
                // so we do 2 more things here to satisfy them:
                // 1. only remove pages once when configuration is changed
                // 2. add more comments here to tell users that calling
                //    this function will not be more frequent than
                //    IM apps writing chat logs, or web browsers writing cache files
                //    if they're so concerned about their disk, they should
                //    uninstall all IM apps and web browsers
                //
                // please open an issue if you're worried about anything else in your computer
                // no matter it's GPU performance, monitor contrast, audio fidelity
                // or anything else in the task manager
                // we'll do as much as we can to help you
                //
                // just kidding
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle,
                    (UIntPtr)0xFFFFFFFF, (UIntPtr)0xFFFFFFFF);
            }
        }


    }
}
