using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorillaTag_Downloader.QuestBuilds
{
    public partial class historical : Form
    {
        public historical()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaTag101.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaTag101";
            string fileName = "GorillaTag101.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk inside the root of your C drive in the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaTag100.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaTag100";
            string fileName = "GorillaTag100.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/PreAlpha1dot8.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\PreAlpha1dot8";
            string fileName = "PreAlpha1dot8.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/PreAlpha1dot7.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\PreAlpha1dot7";
            string fileName = "PreAlpha1dot7.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/PreAlpha1dot6.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\PreAlpha1dot6";
            string fileName = "PreAlpha1dot6.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/PreAlpha1dot5v3hotfix.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\PreAlpha1dot5v3hotfix";
            string fileName = "PreAlpha1dot5v3hotfix.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/PreAlpha1dot5v2.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\PreAlpha1dot5v2";
            string fileName = "PreAlpha1dot5v2.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/PreAlpha1dot5.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\PreAlpha1dot5";
            string fileName = "PreAlpha1dot5.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/PreAlpha1dot4.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\PreAlpha1dot4";
            string fileName = "PreAlpha1dot4.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/PreAlpha1dot2.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\PreAlpha1dot2";
            string fileName = "PreAlpha1dot2.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/PreAlpha1dot1.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\PreAlpha1dot1";
            string fileName = "PreAlpha1dot1.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/PreAlpha.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\PreAlpha";
            string fileName = "PreAlpha.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/PitForest.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\PitForest";
            string fileName = "PitForest.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/StickTurnFix.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\StickTurnFix";
            string fileName = "StickTurnFix.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/newmovement.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\newmovement";
            string fileName = "newmovement.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/BodyTagPerf.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\BodyTagPerf";
            string fileName = "BodyTagPerf.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/BodyTag.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\BodyTag";
            string fileName = "BodyTag.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/1v1UntestedLol.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\1v1UntestedLol";
            string fileName = "1v1UntestedLol.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/PerfFix.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\PerfFix";
            string fileName = "PerfFix.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/XPfix.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\XPfix";
            string fileName = "XPfix.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/XP.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\XP";
            string fileName = "XP.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/Scoreboard.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\Scoreboard";
            string fileName = "Scoreboard.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/TagRumble.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\TagRumble";
            string fileName = "TagRumble.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/WowGraphics.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\WowGraphics";
            string fileName = "WowGraphics.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/cave.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\cave";
            string fileName = "cave.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/fingers.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\fingers";
            string fileName = "fingers.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/tutorialname.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\tutorialname";
            string fileName = "tutorialname.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/PVEfix.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\PVEfix";
            string fileName = "PVEfix.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/PVE.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\PVE";
            string fileName = "PVE.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/ColorPick.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\ColorPick";
            string fileName = "ColorPick.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/Lobby.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\Lobby";
            string fileName = "Lobby.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/CTFProtoSpirit.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\CTFProtoSpirit";
            string fileName = "CTFProtoSpirit.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/CTFProtoAlive.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\CTFProtoAlive";
            string fileName = "CTFProtoAlive.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/CTFProtoDead.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\CTFProtoDead";
            string fileName = "CTFProtoDead.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/CTFProtoSleepTime.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\CTFProtoSleepTime";
            string fileName = "CTFProtoSleepTime.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/CTFProtoNapTime.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\CTFProtoNapTime";
            string fileName = "CTFProtoNapTime.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/CTFProtoBetterer.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\CTFProtoBetterer";
            string fileName = "CTFProtoBetterer.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/CTFProtoBetter.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\CTFProtoBetter";
            string fileName = "CTFProtoBetter.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/CTFProto.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\CTFProto";
            string fileName = "CTFProto.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/Crusher.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\Crusher";
            string fileName = "Crusher.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/MessagesOptimize.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\MessagesOptimize";
            string fileName = "MessagesOptimize.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/ServerIsKill.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\ServerIsKill";
            string fileName = "ServerIsKill.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/TransparentBlue.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\TransparentBlue";
            string fileName = "TransparentBlue.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaTagCaveJune9.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaTagCaveJune9";
            string fileName = "GorillaTagCaveJune9.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaTagCaveTestJune9.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaTagCaveTestJune9";
            string fileName = "GorillaTagCaveTestJune9.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaTagJun7hotfix.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaTagJun7hotfix";
            string fileName = "GorillaTagJun7hotfix.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaTagJun6.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaTagJun6";
            string fileName = "GorillaTagJun6.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaTagJun5.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaTagJun5";
            string fileName = "GorillaTagJun5.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaTagJun1Live.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaTagJun1Live";
            string fileName = "GorillaTagJun1Live.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaTagMay31Final.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaTagMay31Final";
            string fileName = "GorillaTagMay31Final.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaTagMay31SpectatorCam.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaTagMay31SpectatorCam";
            string fileName = "GorillaTagMay31SpectatorCam.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaTagMay30InfectionBreakFix.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaTagMay30InfectionBreakFix";
            string fileName = "GorillaTagMay30InfectionBreakFix.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaTagMay30CollisionHotpatch2.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaTagMay30CollisionHotpatch2";
            string fileName = "GorillaTagMay30CollisionHotpatch2.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaTagMay30Collision.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaTagMay30";
            string fileName = "GorillaTagMay30Collision.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaTagMay30InfectionUpdateFingersCrossed.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaTagMay30InfectionUpdateFingersCrossed";
            string fileName = "GorillaTagMay30InfectionUpdateFingersCrossed.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaTagMay29early.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaTagMay29early";
            string fileName = "GorillaTagMay29early.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaTagMay28Final.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaTagMay28Final";
            string fileName = "GorillaTagMay28Final.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaTagMay27final.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaTagMay27final";
            string fileName = "GorillaTagMay27final.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaTagMay27.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaTagMay27";
            string fileName = "GorillaTagMay27.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaTagMay26Final.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaTagMay26Final";
            string fileName = "GorillaTagMay26Final.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaTagMay25v2.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaTagMay25v2";
            string fileName = "GorillaTagMay25v2.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/GorillaLocoFeb20.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\GorillaLocoFeb20";
            string fileName = "GorillaLocoFeb20.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/NTkernell/The-Archives/releases/download/quest/Gorilla124.apk";
            string directoryPath = @"\GTAG downloader\quest\historical\Gorilla124";
            string fileName = "Gorilla124.apk";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                try
                {

                    webclient.DownloadFile(url, filePath);
                    MessageBox.Show("Successful download! You can find your apk in the root of your C drive inside the GTAG downloader folder! ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error during download: {ex.Message}");
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

        
    

