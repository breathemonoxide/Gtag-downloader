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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace GorillaTag_Downloader
{
    public partial class feb_aug21 : Form
    {
        public feb_aug21()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 2218992975128065135 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();







        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 8480223242740007278 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 5830392302374695549 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 7345723381055924397 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 2519821153393002943 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 1361357891413913381 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 8743855303106200649 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 1831142320395008381 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 3777416459781165037 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 8234126159354437183 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 8786485081868183496 -username {textBox1.Text}";
            process.Start();
            process.WaitForExit();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main man = new Main();
            man.Show();
        }

        private void feb_aug21_Load(object sender, EventArgs e)
        {

        }
    }
}

