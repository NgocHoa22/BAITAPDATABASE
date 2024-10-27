namespace asmconnect
{
    partial class Employee
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtautho = new System.Windows.Forms.TextBox();
            this.txtpost = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.dtgrv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btseach = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.Location = new System.Drawing.Point(51, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(319, 32);
            this.button4.TabIndex = 40;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Location = new System.Drawing.Point(51, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(319, 32);
            this.button3.TabIndex = 39;
            this.button3.Text = "delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(51, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(319, 32);
            this.button2.TabIndex = 38;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(289, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Authority";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(297, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Position";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(36, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Employee Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Employee Code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtautho
            // 
            this.txtautho.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtautho.Location = new System.Drawing.Point(238, 127);
            this.txtautho.Name = "txtautho";
            this.txtautho.Size = new System.Drawing.Size(186, 26);
            this.txtautho.TabIndex = 31;
            this.txtautho.TextChanged += new System.EventHandler(this.txtautho_TextChanged);
            // 
            // txtpost
            // 
            this.txtpost.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtpost.Location = new System.Drawing.Point(238, 61);
            this.txtpost.Name = "txtpost";
            this.txtpost.Size = new System.Drawing.Size(186, 26);
            this.txtpost.TabIndex = 30;
            this.txtpost.TextChanged += new System.EventHandler(this.txtpost_TextChanged);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtname.Location = new System.Drawing.Point(6, 127);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(186, 26);
            this.txtname.TabIndex = 29;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtcode
            // 
            this.txtcode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtcode.Location = new System.Drawing.Point(6, 61);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(186, 26);
            this.txtcode.TabIndex = 28;
            this.txtcode.TextChanged += new System.EventHandler(this.txtcode_TextChanged);
            // 
            // dtgrv
            // 
            this.dtgrv.BackgroundColor = System.Drawing.Color.Lavender;
            this.dtgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtgrv.Location = new System.Drawing.Point(492, 55);
            this.dtgrv.Name = "dtgrv";
            this.dtgrv.RowHeadersWidth = 62;
            this.dtgrv.RowTemplate.Height = 28;
            this.dtgrv.Size = new System.Drawing.Size(978, 556);
            this.dtgrv.TabIndex = 33;
            this.dtgrv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrv_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(51, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 32);
            this.button1.TabIndex = 32;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btseach
            // 
            this.btseach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btseach.Location = new System.Drawing.Point(51, 258);
            this.btseach.Name = "btseach";
            this.btseach.Size = new System.Drawing.Size(315, 25);
            this.btseach.TabIndex = 41;
            this.btseach.Text = "Search";
            this.btseach.UseVisualStyleBackColor = false;
            this.btseach.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(1371, 627);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 30);
            this.button6.TabIndex = 42;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btseach);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 397);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtpost);
            this.groupBox2.Controls.Add(this.txtcode);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtautho);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 196);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infomation";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(802, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(446, 55);
            this.label6.TabIndex = 45;
            this.label6.Text = "Employee Information";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1498, 673);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dtgrv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtautho;
        private System.Windows.Forms.TextBox txtpost;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.DataGridView dtgrv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btseach;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
    }
}