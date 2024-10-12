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
    public partial class all2022 : Form
    {
        public all2022()
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
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 2218992975128065135 -username {textBox1.Text} -dir {textBox2.Text}/Winter2022";
            process.Start();
            process.WaitForExit();
        }
    }
}
