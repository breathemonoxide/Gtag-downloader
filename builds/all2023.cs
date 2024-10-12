using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorillaTag_Downloader.builds
{
    public partial class _2023 : Form
    {
        public _2023()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 5272615492296865291 -username {textBox1.Text} -dir {textBox2.Text}/HolidayOverstock";
            process.Start();
            process.WaitForExit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 1024065649513604747 -username {textBox1.Text} -dir {textBox2.Text}/Winter 2023";
            process.Start();
            process.WaitForExit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 8226996632576406070 -username {textBox1.Text} -dir {textBox2.Text}/Valentine's 2023";
            process.Start();
            process.WaitForExit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 4849975928796061895 -username {textBox1.Text} -dir {textBox2.Text}/FebruaryWinter";
            process.Start();
            process.WaitForExit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 5234510482746716599 -username {textBox1.Text} -dir {textBox2.Text}/MountainsRevamp";
            process.Start();
            process.WaitForExit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 5941115482047217695 -username {textBox1.Text} -dir {textBox2.Text}/Basement";
            process.Start();
            process.WaitForExit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 8953216585901271401 -username {textBox1.Text} -dir {textBox2.Text}/EarlySpring";
            process.Start();
            process.WaitForExit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 3656866934728343993 -username {textBox1.Text} -dir {textBox2.Text}/SpringCleaning";
            process.Start();
            process.WaitForExit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 5296372619910715608 -username {textBox1.Text} -dir {textBox2.Text}/HouseFlash+CanyonRevamp";
            process.Start();
            process.WaitForExit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 6583276257667612942 -username {textBox1.Text} -dir {textBox2.Text}/SummerSplash";
            process.Start();
            process.WaitForExit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 3197800337588223997 -username {textBox1.Text} -dir {textBox2.Text}/RainFlashback";
            process.Start();
            process.WaitForExit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 5909999775995420795 -username {textBox1.Text} -dir {textBox2.Text}/MusicFlashback";
            process.Start();
            process.WaitForExit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 1161533665635074987 -username {textBox1.Text} -dir {textBox2.Text}/SummerCelebration";
            process.Start();
            process.WaitForExit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 4598513446787189059 -username {textBox1.Text} -dir {textBox2.Text}/UnderTheSunFlashback";
            process.Start();
            process.WaitForExit();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 4517667507007620373 -username {textBox1.Text} -dir {textBox2.Text}/CrystalCaverns(caves revamp)";
            process.Start();
            process.WaitForExit();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 910642836555163397 -username {textBox1.Text} -dir {textBox2.Text}/PaintBrawlFlashback";
            process.Start();
            process.WaitForExit();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 5178239895382560605 -username {textBox1.Text} -dir {textBox2.Text}/BackToSchool";
            process.Start();
            process.WaitForExit();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 4429018437186357961 -username {textBox1.Text} -dir {textBox2.Text}/GTLaunchFlashback";
            process.Start();
            process.WaitForExit();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 7879805303656311610 -username {textBox1.Text} -dir {textBox2.Text}/ForestLava";
            process.Start();
            process.WaitForExit();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 3530923920245697258 -username {textBox1.Text} -dir {textBox2.Text}/Halloween 2023";
            process.Start();
            process.WaitForExit();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 3530923920245697258 -username {textBox1.Text} -dir {textBox2.Text}/Halloween2022Flashback";
            process.Start();
            process.WaitForExit();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 3182699544820941765 -username {textBox1.Text} -dir {textBox2.Text}/Fall2023";
            process.Start();
            process.WaitForExit();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 413034153916417182 -username {textBox1.Text} -dir {textBox2.Text}/Fall2022Flashback";
            process.Start();
            process.WaitForExit();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 7362717951501930919 -username {textBox1.Text} -dir {textBox2.Text}/Holiday 2023";
            process.Start();
            process.WaitForExit();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string direc = textBox2.Text;

            Process process = new Process();
            process.StartInfo.FileName = "depotdownloader.exe";
            process.StartInfo.Arguments = $"-app 1533390 -depot 1533391 -manifest 5702136978519485499 -username {textBox1.Text} -dir {textBox2.Text}/HolidayFlashback";
            process.Start();
            process.WaitForExit();
        }
    }
}
