using GorillaTag_Downloader.QuestBuilds;
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

namespace GorillaTag_Downloader.main_stuff
{
    public partial class mainquest : Form
    {
        public mainquest()
        {
            InitializeComponent();
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
            historical his = new historical();
            his.Show();
        }

        private void mainquest_Load(object sender, EventArgs e)
        {

        }
    }
}
