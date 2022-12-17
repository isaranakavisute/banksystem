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
        private void InitializeComponent()
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
            this.newaccountnumber_lbl.Text = "NL02ABNA2532528516";
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

        }

        #endregion

        private Label newaccountnumber_lbl;
        private Button home;
    }
}