/*
     Junk message DDoS bug testing tool for Shenzhen High School of Science (SHSS), see: http://www.szkegao.net

     By Jackson Ming Hu in RMIT University, Melbourne, Australia
     December 20, 2015   huming2207@gmail.com

     This is also a chance for me to learn the asynchronous and synchronous stuff in C#. :)

     Warning: This tool is written for IT Management Department in SHSS only.
              I will obviously NOT publish its binary files and/or source code, 
              until they fix their bugs.
  
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Reflection;


namespace ddTester
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            // Disable Thread-safe detection. It's okay for a testing tool, 
            // although it may causes troubles. Don't be so serious. We'll be fine then. :)
            Control.CheckForIllegalCrossThreadCalls = false; 
        }

        private void resultTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            Int32.TryParse(threadTextbox.Text, out Controller.ctrlVar.thread);
            Int32.TryParse(runCrTextbox.Text, out Controller.ctrlVar.runTimes);
            Controller.ctrlVar.name = HttpUtility.UrlEncode(nameTextbox.Text);
            Controller.ctrlVar.phone = HttpUtility.UrlEncode(phoneTextbox.Text);
            Controller.ctrlVar.email = HttpUtility.UrlEncode(emailTextbox.Text);
            Controller.ctrlVar.title = HttpUtility.UrlEncode(titleTextbox.Text);
            Controller.ctrlVar.comment = HttpUtility.UrlEncode(commentTextbox.Text);
            Controller.ctrlVar.noResult = checkBox1.Checked;
            MessageBox.Show("Now running \r\n Do not press this button again.");
            resultLabel.Text = "Now running...";

            RunParallel(Controller.ctrlVar.thread, Controller.ctrlVar.runTimes);
            Controller.ReleaseMemory(false);
          
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("THIS TOOL IS FOR TESTING THE BUGS ONLY, NOT FOR HACKING! \r\nI AM SERIOUS!! NOT FOR HACKING!!", "WARNING");
            resultTextbox.AppendText("\r\n=============================================\r\n" +
                "Version: " + Assembly.GetEntryAssembly().GetName().Version.ToString() + "\r\n" +
                "Architecture: " + Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE").ToString() + "\r\n");
        }




        public void RunParallel(int thread, int runTimes)
        {
            ParallelLoopResult result = Parallel.For(0, runTimes, new ParallelOptions { MaxDegreeOfParallelism = thread }, index =>
            {
                // See: http://stackoverflow.com/questions/14485115/synchronously-waiting-for-an-async-operation-and-why-does-wait-freeze-the-pro
                // This is a solution for making the async stuff to be "sync" correctly.
                var task = Task.Run(async () => { await Controller.SendHTTP(); }); 
                task.Wait();

                if (Controller.ctrlVar.noResult == false)
                {
                    resultTextbox.Text = Controller.ctrlVar.returnResult;
                }
            });
            // Fix memory leak (TODO: Seems not necessary? I don't know, need to be re-considered later.)
            Controller.ReleaseMemory(true);
            if (result.IsCompleted)
            {
                startButton.Enabled = true;
                MessageBox.Show("Done, please check your server and/or your packet tracing tool.");
                resultLabel.Text = "Done!";
            }
        }


    }
}
