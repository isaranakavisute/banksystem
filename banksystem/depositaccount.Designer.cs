/*
using MySqlConnector;
using MySql.Data;
using MySql.Data.MySqlClient;
using Data;

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
    partial class depositaccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deposit_accountnumber_lbl = new System.Windows.Forms.Label();
            this.deposit_amount_lbl = new System.Windows.Forms.Label();
            this.deposit_accountnumber_tf = new System.Windows.Forms.TextBox();
            this.deposit_amount_tf = new System.Windows.Forms.TextBox();
            this.deposit_btn = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deposit_accountnumber_lbl
            // 
            this.deposit_accountnumber_lbl.AutoSize = true;
            this.deposit_accountnumber_lbl.Location = new System.Drawing.Point(155, 131);
            this.deposit_accountnumber_lbl.Name = "deposit_accountnumber_lbl";
            this.deposit_accountnumber_lbl.Size = new System.Drawing.Size(147, 25);
            this.deposit_accountnumber_lbl.TabIndex = 0;
            this.deposit_accountnumber_lbl.Text = "Account Number";
            // 
            // deposit_amount_lbl
            // 
            this.deposit_amount_lbl.AutoSize = true;
            this.deposit_amount_lbl.Location = new System.Drawing.Point(155, 242);
            this.deposit_amount_lbl.Name = "deposit_amount_lbl";
            this.deposit_amount_lbl.Size = new System.Drawing.Size(77, 25);
            this.deposit_amount_lbl.TabIndex = 1;
            this.deposit_amount_lbl.Text = "Amount";
            // 
            // deposit_accountnumber_tf
            // 
            this.deposit_accountnumber_tf.Location = new System.Drawing.Point(331, 132);
            this.deposit_accountnumber_tf.Name = "deposit_accountnumber_tf";
            this.deposit_accountnumber_tf.Size = new System.Drawing.Size(150, 31);
            this.deposit_accountnumber_tf.TabIndex = 2;
            // 
            // deposit_amount_tf
            // 
            this.deposit_amount_tf.Location = new System.Drawing.Point(331, 242);
            this.deposit_amount_tf.Name = "deposit_amount_tf";
            this.deposit_amount_tf.Size = new System.Drawing.Size(150, 31);
            this.deposit_amount_tf.TabIndex = 3;
            // 
            // deposit_btn
            // 
            this.deposit_btn.Location = new System.Drawing.Point(212, 345);
            this.deposit_btn.Name = "deposit_btn";
            this.deposit_btn.Size = new System.Drawing.Size(112, 34);
            this.deposit_btn.TabIndex = 4;
            this.deposit_btn.Text = "OK";
            this.deposit_btn.UseVisualStyleBackColor = true;
            this.deposit_btn.Click += new System.EventHandler(this.depositbtn_click);
            // 
            // home_button
            // 
            this.home_button.Location = new System.Drawing.Point(461, 345);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(112, 34);
            this.home_button.TabIndex = 5;
            this.home_button.Text = "HOME";
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // depositaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.deposit_btn);
            this.Controls.Add(this.deposit_accountnumber_tf);
            this.Controls.Add(this.deposit_amount_tf);
            this.Controls.Add(this.deposit_accountnumber_lbl);
            this.Controls.Add(this.deposit_amount_lbl);
            this.Name = "depositaccount";
            this.Text = "Deposit Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label deposit_accountnumber_lbl;
        private Label deposit_amount_lbl;
        private TextBox deposit_accountnumber_tf;
        private TextBox deposit_amount_tf;
        private Button deposit_btn;
        private Button home_button;
    }
}