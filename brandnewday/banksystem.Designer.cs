namespace brandnewday
{
    partial class banksystem_app
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.banksystem_lbl = new System.Windows.Forms.Label();
            this.createaccount_btn = new System.Windows.Forms.Button();
            this.deposity_btn = new System.Windows.Forms.Button();
            this.transfermoney_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // banksystem_lbl
            // 
            this.banksystem_lbl.AutoSize = true;
            this.banksystem_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.banksystem_lbl.Location = new System.Drawing.Point(358, 71);
            this.banksystem_lbl.Name = "banksystem_lbl";
            this.banksystem_lbl.Size = new System.Drawing.Size(126, 25);
            this.banksystem_lbl.TabIndex = 0;
            this.banksystem_lbl.Text = "BANK SYSTEM";
            // 
            // createaccount_btn
            // 
            this.createaccount_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.createaccount_btn.Location = new System.Drawing.Point(344, 207);
            this.createaccount_btn.Name = "createaccount_btn";
            this.createaccount_btn.Size = new System.Drawing.Size(160, 34);
            this.createaccount_btn.TabIndex = 1;
            this.createaccount_btn.Text = "Create Account";
            this.createaccount_btn.UseVisualStyleBackColor = false;
            this.createaccount_btn.Click += new System.EventHandler(this.createaccount_btn_Click);
            // 
            // deposity_btn
            // 
            this.deposity_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.deposity_btn.Location = new System.Drawing.Point(344, 274);
            this.deposity_btn.Name = "deposity_btn";
            this.deposity_btn.Size = new System.Drawing.Size(160, 34);
            this.deposity_btn.TabIndex = 2;
            this.deposity_btn.Text = "Deposit Money";
            this.deposity_btn.UseVisualStyleBackColor = false;
            this.deposity_btn.Click += new System.EventHandler(this.deposity_btn_Click);
            // 
            // transfermoney_btn
            // 
            this.transfermoney_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.transfermoney_btn.Location = new System.Drawing.Point(344, 349);
            this.transfermoney_btn.Name = "transfermoney_btn";
            this.transfermoney_btn.Size = new System.Drawing.Size(160, 34);
            this.transfermoney_btn.TabIndex = 3;
            this.transfermoney_btn.Text = "Transfer Money";
            this.transfermoney_btn.UseVisualStyleBackColor = false;
            this.transfermoney_btn.Click += new System.EventHandler(this.transfermoney_btn_Click);
            // 
            // banksystem_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transfermoney_btn);
            this.Controls.Add(this.deposity_btn);
            this.Controls.Add(this.createaccount_btn);
            this.Controls.Add(this.banksystem_lbl);
            this.Name = "banksystem_app";
            this.Text = "Bank System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label banksystem_lbl;
        private Button createaccount_btn;
        private Button deposity_btn;
        private Button transfermoney_btn;
    }
}