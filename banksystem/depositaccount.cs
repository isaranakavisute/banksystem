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
            dbCon.Server = "153.92.215.169";
            dbCon.DatabaseName = "chiangra_banksystem";
            dbCon.UserName = "chiangra_isara";
            dbCon.Password = "23153645hI";
            if (dbCon.IsConnect())
            {
                //suppose col0 and col1 are defined as VARCHAR in the DB
                //string query = "insert into account(account_number,balance) values ('" + this.newaccountnumber_lbl.Text + "',0.0)";
                //var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon.Connection);
                //var reader = cmd.ExecuteReader();
                /*
                while (reader.Read())
                {
                    string someStringFromColumnZero = reader.GetString(0);
                    string someStringFromColumnOne = reader.GetString(1);
                    Console.WriteLine(someStringFromColumnZero + "," + someStringFromColumnOne);
                }
                */
                //dbCon.Close();
            }
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form home = new brandnewday.banksystem_app();
            home.Show();
        }
    }
}
