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
            string output = process.StandardOutput.ReadToEnd();
            Console.WriteLine(output);






        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}

