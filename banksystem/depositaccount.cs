using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
using MySqlConnector;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Data
{
    public class DBConnection
    {
        private DBConnection()
        {
        }

        public string Server { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public MySql.Data.MySqlClient.MySqlConnection Connection { get; set; }

        private static DBConnection _instance = null;
        public static DBConnection Instance()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        public bool IsConnect()
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(DatabaseName))
                    return false;
                string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", Server, DatabaseName, UserName, Password);
                Connection = new MySql.Data.MySqlClient.MySqlConnection(connstring);
                Connection.Open();
            }

            return true;
        }

        public void Close()
        {
            Connection.Close();
        }
    }
}
*/

namespace banksystem
{
    public partial class depositaccount : Form
    {
        public depositaccount()
        {
            InitializeComponent();
        }

        private void depositbtn_click(object sender, EventArgs e)
        {
            var dbCon = DBConnection.Instance();
            if (dbCon.Connection!=null)
            {
                if (dbCon.Connection.State == ConnectionState.Closed)
                {
                    dbCon = DBConnection.Instance();
                }
            }
            //else
                //dbCon.Close();
            
               

            dbCon.Server = "153.92.215.169";
            dbCon.DatabaseName = "chiangra_banksystem";
            dbCon.UserName = "chiangra_isara";
            dbCon.Password = "23153645hI";
            if (dbCon.IsConnect())
            {
                string amount = deposit_amount_tf.Text;
                double amount_dbl = Convert.ToDouble(amount);
                amount_dbl *= (100-0.1)/100.0; //fee = 0.1%
                string query = "update account set balance=balance+" + amount_dbl + " where account_number='"+deposit_accountnumber_tf.Text+"'";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon.Connection);
                //var reader = cmd.ExecuteReader();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    string message = "Deposit..successful";
                    MessageBox.Show(message);
                }
                else
                {
                    string message = "Deposit..not successful";
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
                home_button_Click(sender, e);
            }
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form home = new brandnewday.banksystem_app();
            home.Show();
            //dbCon.Close();
        }
    }
}
