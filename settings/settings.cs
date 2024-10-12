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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            about abt = new about();
            abt.Show();
        }

        private void settings_Load(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
