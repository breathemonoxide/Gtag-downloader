using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorillaTag_Downloader.builds
{
    public partial class all2021 : Form
    {
        public all2021()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.InitialDirectory = "C:\\";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dialog.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 2218992975128065135 -username {textBox1.Text} -dir {textBox2.Text}/initial release";
            process.Start();
            process.WaitForExit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 8480223242740007278 -username {textBox1.Text} -dir {textBox2.Text}/Caves";
            process.Start();
            process.WaitForExit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 5830392302374695549 -username {textBox1.Text} -dir {textBox2.Text}/HatRoom";
            process.Start();
            process.WaitForExit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 7345723381055924397 -username {textBox1.Text} -dir {textBox2.Text}/CasualQueue";
            process.Start();
            process.WaitForExit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 2519821153393002943 -username {textBox1.Text} -dir {textBox2.Text}/Canyon";
            process.Start();
            process.WaitForExit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 1361357891413913381 -username {textBox1.Text} -dir {textBox2.Text}/MoreServerLocations";
            process.Start();
            process.WaitForExit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 8743855303106200649 -username {textBox1.Text} -dir {textBox2.Text}/LavaParticles";
            process.Start();
            process.WaitForExit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 1831142320395008381 -username {textBox1.Text} -dir {textBox2.Text}/Sound";
            process.Start();
            process.WaitForExit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 3777416459781165037 -username {textBox1.Text} -dir {textBox2.Text}/SecurityPatch";
            process.Start();
            process.WaitForExit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 8234126159354437183 -username {textBox1.Text} -dir {textBox2.Text}/PerfPatch";
            process.Start();
            process.WaitForExit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 8786485081868183496 -username {textBox1.Text} -dir {textBox2.Text}/MusicPatch";
            process.Start();
            process.WaitForExit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 8486188048224112520 -username {textBox1.Text} -dir {textBox2.Text}/City";
            process.Start();
            process.WaitForExit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 8773026304241958081 -username {textBox1.Text} -dir {textBox2.Text}/Halloween";
            process.Start();
            process.WaitForExit();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 2272834128493042718 -username {textBox1.Text} -dir {textBox2.Text}/Night";
            process.Start();
            process.WaitForExit();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 960269214136590756 -username {textBox1.Text} -dir {textBox2.Text}/Fall";
            process.Start();
            process.WaitForExit();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 8796064944490370744 -username {textBox1.Text} -dir {textBox2.Text}/Fall 2.0";
            process.Start();
            process.WaitForExit();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 3936509119522672028 -username {textBox1.Text} -dir {textBox2.Text}/NetworkTuneup";
            process.Start();
            process.WaitForExit();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 3791532127930956811 -username {textBox1.Text} -dir {textBox2.Text}/RoomJoinBugsFix";
            process.Start();
            process.WaitForExit();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 769327410266909938 -username {textBox1.Text} -dir {textBox2.Text}/InvisibleFix";
            process.Start();
            process.WaitForExit();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 2952807174378250716 -username {textBox1.Text} -dir {textBox2.Text}/FixCityEscape";
            process.Start();
            process.WaitForExit();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 1790232358016968157 -username {textBox1.Text} -dir {textBox2.Text}/Holiday2021";
            process.Start();
            process.WaitForExit();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 977662270706390562 -username {textBox1.Text} -dir {textBox2.Text}/Hunt";
            process.Start();
            process.WaitForExit();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}
