using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Markup;
using System.Windows;

namespace asmconnect
{
    public partial class login : Form
    {
        string str = @"Data Source=TRUONG-NGOC-HOA\SQLEXPRESS;Initial Catalog=asm;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dttb;
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btcreate.Visible = true;
            lblcf.Visible = true;
            txtcf.Visible = true;
            button1.Visible = false;
        }
        private void LoadData()
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from thongtin", sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            sql.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(txtpass.Text == txtcf.Text)
            {
                sql = new SqlConnection(str);
            sql.Open();
            string add = ("Insert into thongtin(taikhoan, matkhau) values (@taikhoan, @matkhau)");
            cmd = new SqlCommand(add,sql);
            cmd.Parameters.AddWithValue("@taikhoan", txtname.Text);
            cmd.Parameters.AddWithValue("@matkhau", txtpass.Text);
            cmd.ExecuteNonQuery();
            LoadData();
                System.Windows.Forms.MessageBox.Show("Tạo Tài Khoản Thành Công");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Tài khoản và mật khẩu không trùng");
            }
            button1.Visible = true;
            btcreate.Visible = false;
            txtcf.Visible = false;
            lblcf.Visible = false;
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection (str);
            sql.Open();
            string login = ("Select * from thongtin where taikhoan = @taikhoan and matkhau = @matkhau");
            cmd = new SqlCommand(login, sql);
            cmd.Parameters.AddWithValue("@taikhoan", txtname.Text);
            cmd.Parameters.AddWithValue("@matkhau", txtpass.Text);
            SqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.HasRows)
            {
                System.Windows.Forms.MessageBox.Show("Success");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {                                                  
                System.Windows.Forms.MessageBox.Show("Tài Khoản Không Tôn Tại");
            }
            rdr.Close();
            sql.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtcf.PasswordChar = '\0';
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
                txtcf.PasswordChar = '*';
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
