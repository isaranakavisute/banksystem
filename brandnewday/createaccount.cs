using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brandnewday
{
    public partial class createaccount : Form
    {
        public createaccount()
        {
            InitializeComponent();
        }
        private Label createaccount_lbl;

        private void createaccount_lbl_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form home = new banksystem_app();
            home.Show();
            int i=2;
        }
    }
}
