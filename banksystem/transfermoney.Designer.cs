namespace banksystem
{
    partial class transfermoney
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
            this.transfermoney_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.fromaccount_lbl = new System.Windows.Forms.Label();
            this.fromaccount_tf = new System.Windows.Forms.TextBox();
            this.toaacount_lbl = new System.Windows.Forms.Label();
            this.toaccount_tf = new System.Windows.Forms.TextBox();
            this.transferamount_tf = new System.Windows.Forms.TextBox();
            this.transferamount_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // transfermoney_btn
            // 
            this.transfermoney_btn.Location = new System.Drawing.Point(253, 301);
            this.transfermoney_btn.Name = "transfermoney_btn";
            this.transfermoney_btn.Size = new System.Drawing.Size(112, 34);
            this.transfermoney_btn.TabIndex = 0;
            this.transfermoney_btn.Text = "OK";
            this.transfermoney_btn.UseVisualStyleBackColor = true;
            this.transfermoney_btn.Click += new System.EventHandler(this.transfermoney_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.Location = new System.Drawing.Point(447, 301);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(112, 34);
            this.home_btn.TabIndex = 1;
            this.home_btn.Text = "HOME";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // fromaccount_lbl
            // 
            this.fromaccount_lbl.AutoSize = true;
            this.fromaccount_lbl.Location = new System.Drawing.Point(175, 85);
            this.fromaccount_lbl.Name = "fromaccount_lbl";
            this.fromaccount_lbl.Size = new System.Drawing.Size(125, 25);
            this.fromaccount_lbl.TabIndex = 2;
            this.fromaccount_lbl.Text = "From account:";
            // 
            // fromaccount_tf
            // 
            this.fromaccount_tf.Location = new System.Drawing.Point(362, 82);
            this.fromaccount_tf.Name = "fromaccount_tf";
            this.fromaccount_tf.Size = new System.Drawing.Size(150, 31);
            this.fromaccount_tf.TabIndex = 3;
            // 
            // toaacount_lbl
            // 
            this.toaacount_lbl.AutoSize = true;
            this.toaacount_lbl.Location = new System.Drawing.Point(175, 157);
            this.toaacount_lbl.Name = "toaacount_lbl";
            this.toaacount_lbl.Size = new System.Drawing.Size(103, 25);
            this.toaacount_lbl.TabIndex = 4;
            this.toaacount_lbl.Text = "To account:";
            // 
            // toaccount_tf
            // 
            this.toaccount_tf.Location = new System.Drawing.Point(364, 159);
            this.toaccount_tf.Name = "toaccount_tf";
            this.toaccount_tf.Size = new System.Drawing.Size(150, 31);
            this.toaccount_tf.TabIndex = 5;
            // 
            // transferamount_tf
            // 
            this.transferamount_tf.Location = new System.Drawing.Point(364, 234);
            this.transferamount_tf.Name = "transferamount_tf";
            this.transferamount_tf.Size = new System.Drawing.Size(150, 31);
            this.transferamount_tf.TabIndex = 6;
            // 
            // transferamount_lbl
            // 
            this.transferamount_lbl.AutoSize = true;
            this.transferamount_lbl.Location = new System.Drawing.Point(175, 240);
            this.transferamount_lbl.Name = "transferamount_lbl";
            this.transferamount_lbl.Size = new System.Drawing.Size(77, 25);
            this.transferamount_lbl.TabIndex = 7;
            this.transferamount_lbl.Text = "Amount";
            // 
            // transfermoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transferamount_lbl);
            this.Controls.Add(this.transferamount_tf);
            this.Controls.Add(this.toaccount_tf);
            this.Controls.Add(this.toaacount_lbl);
            this.Controls.Add(this.fromaccount_tf);
            this.Controls.Add(this.fromaccount_lbl);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.transfermoney_btn);
            this.Name = "transfermoney";
            this.Text = "Transfer Money";
            this.Load += new System.EventHandler(this.transfermoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.CenterToScreen();

        }

        #endregion

        private Button transfermoney_btn;
        private Button home_btn;
        private Label fromaccount_lbl;
        private TextBox fromaccount_tf;
        private Label toaacount_lbl;
        private TextBox toaccount_tf;
        private TextBox transferamount_tf;
        private Label transferamount_lbl;
    }
}