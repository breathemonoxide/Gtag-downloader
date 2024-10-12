
using GorillaTag_Downloader.builds;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void button11_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo

            {

                FileName = "https://discord.gg/NuAr8ny3DC",

                UseShellExecute = true

            };

            Process.Start(psi);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo

            {

                FileName = "https://github.com/NTkernell/GorillaTag-downloader",

                UseShellExecute = true

            };

            Process.Start(psi);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo

            {

                FileName = "https://x.com/ntkernell",

                UseShellExecute = true

            };

            Process.Start(psi);
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

            settings sett = new settings();
            sett.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            notice not = new notice();
            not.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            _2023 all23 = new _2023();
            all23.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            all2021 all21 = new all2021();
            all21.Show();   
        }
    }
}
