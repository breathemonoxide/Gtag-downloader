using GorillaTag_Downloader.QuestBuilds;

namespace GorillaTag_Downloader
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Steam_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main man = new Main();
            man.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            historical histq = new historical();
            histq.Show();
        }
    }
}
