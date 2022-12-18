using banksystem;

namespace brandnewday
{
    public partial class banksystem_app : Form
    {
        public banksystem_app()
        {
            InitializeComponent();
        }

        private void createaccount_btn_Click(object sender, EventArgs e)
        {
            //string message = "Test1";
            //MessageBox.Show(message);

            Form createaccount_frm = new createaccount();
            createaccount_frm.Show();
            this.Hide();
        }

        private void deposity_btn_Click(object sender, EventArgs e)
        {
            //string message = "Test2";
            //MessageBox.Show(message);

            Form depositaccount_frm = new depositaccount();
            depositaccount_frm.Show();
            this.Hide();
        }

        private void transfermoney_btn_Click(object sender, EventArgs e)
        {
            string message = "Test3";
            MessageBox.Show(message);

        }
    }
}