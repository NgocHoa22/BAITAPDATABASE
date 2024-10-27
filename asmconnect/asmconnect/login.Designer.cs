namespace asmconnect
{
    partial class login
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtcf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcf = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btlogin = new System.Windows.Forms.Button();
            this.btcreate = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(341, 80);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(423, 30);
            this.txtname.TabIndex = 0;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(341, 160);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(423, 30);
            this.txtpass.TabIndex = 1;
            // 
            // txtcf
            // 
            this.txtcf.Location = new System.Drawing.Point(341, 246);
            this.txtcf.Margin = new System.Windows.Forms.Padding(4);
            this.txtcf.Name = "txtcf";
            this.txtcf.PasswordChar = '*';
            this.txtcf.Size = new System.Drawing.Size(423, 30);
            this.txtcf.TabIndex = 2;
            this.txtcf.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pass Word";
            // 
            // lblcf
            // 
            this.lblcf.AutoSize = true;
            this.lblcf.Location = new System.Drawing.Point(173, 254);
            this.lblcf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcf.Name = "lblcf";
            this.lblcf.Size = new System.Drawing.Size(149, 25);
            this.lblcf.TabIndex = 1;
            this.lblcf.Text = "ConFormPass";
            this.lblcf.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(803, 170);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 69);
            this.button1.TabIndex = 2;
            this.button1.Text = "You do not have an account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(803, 80);
            this.btlogin.Margin = new System.Windows.Forms.Padding(4);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(194, 69);
            this.btlogin.TabIndex = 3;
            this.btlogin.Text = "Login";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // btcreate
            // 
            this.btcreate.Location = new System.Drawing.Point(803, 170);
            this.btcreate.Margin = new System.Windows.Forms.Padding(4);
            this.btcreate.Name = "btcreate";
            this.btcreate.Size = new System.Drawing.Size(194, 69);
            this.btcreate.TabIndex = 4;
            this.btcreate.Text = "Create Account";
            this.btcreate.UseVisualStyleBackColor = true;
            this.btcreate.Visible = false;
            this.btcreate.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(341, 214);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 29);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Hiện Mật Khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 601);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btcreate);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblcf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcf);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtcf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btcreate;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}