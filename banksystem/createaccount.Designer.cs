using HtmlAgilityPack;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
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


namespace brandnewday
{
    partial class createaccount
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
        /// 
        public static async Task StartCrawlerasync(string html)
        {
            var httpClient = new HttpClient();
            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            await Task.Delay(5000);
            htmlDocument.LoadHtml(html);
            HtmlNode body24 = htmlDocument.DocumentNode.SelectSingleNode("//*[@id=\"demo\"]");
            string content24 = body24.InnerHtml;
            //newaccountnumber_lbl.Text = content24;
        }
        private async Task InitializeComponentAsync()
        {
            this.createaccount_lbl = new System.Windows.Forms.Label();
            this.newaccountnumber_lbl = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createaccount_lbl
            // 
            this.createaccount_lbl.AutoSize = true;
            this.createaccount_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createaccount_lbl.Location = new System.Drawing.Point(108, 38);
            this.createaccount_lbl.Name = "createaccount_lbl";
            this.createaccount_lbl.Size = new System.Drawing.Size(579, 25);
            this.createaccount_lbl.TabIndex = 0;
            this.createaccount_lbl.Text = "You are creating the new bank account. Your information is as followed:";
            this.createaccount_lbl.Click += new System.EventHandler(this.createaccount_lbl_Click);
            // 
            // newaccountnumber_lbl
            // 
            this.newaccountnumber_lbl.AutoSize = true;
            this.newaccountnumber_lbl.Location = new System.Drawing.Point(108, 138);
            this.newaccountnumber_lbl.Name = "newaccountnumber_lbl";
            this.newaccountnumber_lbl.Size = new System.Drawing.Size(200, 25);
            this.newaccountnumber_lbl.TabIndex = 1;

            string url = "http://randomiban.com/?country=Netherlands";
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Size = new System.Drawing.Size(0, 0);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl(url);
            var result = driver.FindElement(By.TagName("body")).GetAttribute("innerHTML");
            var httpClient = new HttpClient();
            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(result);
            HtmlNode body24 = htmlDocument.DocumentNode.SelectSingleNode("//*[@id=\"demo\"]");
            string content24 = body24.InnerHtml;
            driver.Quit();
            this.newaccountnumber_lbl.Text = content24;

            var dbCon = DBConnection.Instance();
            dbCon.Server = "153.92.215.169";
            dbCon.DatabaseName = "chiangra_banksystem";
            dbCon.UserName = "chiangra_isara";
            dbCon.Password = "23153645hI";
            if (dbCon.IsConnect())
            {
                //suppose col0 and col1 are defined as VARCHAR in the DB
                string query = "insert into account(account_number,balance) values ('" + this.newaccountnumber_lbl.Text + "',0.0)";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                /*
                while (reader.Read())
                {
                    string someStringFromColumnZero = reader.GetString(0);
                    string someStringFromColumnOne = reader.GetString(1);
                    Console.WriteLine(someStringFromColumnZero + "," + someStringFromColumnOne);
                }
                */
                dbCon.Close();
            }

            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(355, 257);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(112, 34);
            this.home.TabIndex = 2;
            this.home.Text = "HOME";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // createaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.home);
            this.Controls.Add(this.newaccountnumber_lbl);
            this.Controls.Add(this.createaccount_lbl);
            this.Name = "createaccount";
            this.Text = "Create New Account";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.CenterToScreen();
        }

        #endregion

        private Label newaccountnumber_lbl;
        private Button home;
    }
}