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
            Warning warn = new Warning();
            warn.Show();
        }
    }
}
