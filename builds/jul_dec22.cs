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

namespace GorillaTag_Downloader
{
    public partial class jul_dec22 : Form
    {
        public jul_dec22()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 6212573569393666544 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 974246606874981992 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 6724256960126827536 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 3195133226763662362 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 3151533928486249672 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 2826399377161966619 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 9211530748056500720 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 1271825903989683260 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main man = new Main();
            man.Show();
        }
    }
}
