using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banksystem
{
    public partial class transfermoney : Form
    {
        public transfermoney()
        {
            InitializeComponent();
        }

        private void transfermoney_Load(object sender, EventArgs e)
        {

        }

        private void transfermoney_btn_Click(object sender, EventArgs e)
        {
            var dbCon = Data.DBConnection.Instance();
            if (dbCon.Connection != null)
            {
                if (dbCon.Connection.State == ConnectionState.Closed)
                {
                    dbCon = Data.DBConnection.Instance();
                }
            }
            dbCon.Server = "153.92.215.169";
            dbCon.DatabaseName = "chiangra_banksystem";
            dbCon.UserName = "chiangra_isara";
            dbCon.Password = "23153645hI";
            if (dbCon.IsConnect())
            {
              
                string query1 = "update account set balance=balance-" + transferamount_tf.Text + " where account_number='" + fromaccount_tf.Text + "' and balance >= " + transferamount_tf.Text;
                var cmd1 = new MySql.Data.MySqlClient.MySqlCommand(query1, dbCon.Connection);

                if (cmd1.ExecuteNonQuery() > 0)
                {
                    string query2 = "update account set balance=balance+" + transferamount_tf.Text + " where account_number='" + toaccount_tf.Text + "'";
                    var cmd2 = new MySql.Data.MySqlClient.MySqlCommand(query2, dbCon.Connection);
                    if (cmd2.ExecuteNonQuery() > 0)
                    {
                        string message = "Transfer..successful";
                        MessageBox.Show(message);
                    }
                    else
                    {
                        string message = "Transfer..not successful";
                        MessageBox.Show(message);
                    }
                }
                else
                {
                    string message = "Transfer..not successful";
                    MessageBox.Show(message);
                }

                /*
                while (reader.Read())
                {
                    string someStringFromColumnZero = reader.GetString(0);
                    string someStringFromColumnOne = reader.GetString(1);
                    Console.WriteLine(someStringFromColumnZero + "," + someStringFromColumnOne);
                }
                */
                //dbCon.Close();
                home_btn_Click(sender, e);
            }
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form home = new banksystem.banksystem_app();
            home.Show();
            //dbCon.Close();


        }
    }
}
