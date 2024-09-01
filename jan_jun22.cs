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
    public partial class jan_jun22 : Form
    {
        public jan_jun22()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 8111326296022235960 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 3402940780410030277 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 3644302578111614762 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 7171810605217611623 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 9222093099666950138 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 2472938543210547501 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 100037988040314385 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 3587467932664632345 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 8786639128413977059 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 161764784450726358 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 3335121328833824494 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 5371989015659460738 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 179363100641937740 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 4435887754547797182 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 2283373238264001065 -username {textBox1.Text}";
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
