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
using System.Net;
using System.Reflection;

namespace asmconnect
{
    public partial class Customer : Form
    {
        string str = @"Data Source=TRUONG-NGOC-HOA\SQLEXPRESS;Initial Catalog=asm;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dttb;
        public Customer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 from1 = new Form1();
            from1.Show();
            this.Hide();
        }
        private void LoadData(){
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Customer", sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtgrv.DataSource = dttb;
            sql.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("select * from Customer", sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtgrv.DataSource = dttb;
            LoadData();
            sql.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = new SqlConnection(str); 
                sql.Open();
                string add = ("Insert into Customer(Customer_ID, Customer_Name, Phone_Number, Address) values(@Customer_ID, @Customer_Name, @Phone_Number, @Address)");
                cmd = new SqlCommand(add, sql);
                cmd.Parameters.AddWithValue("@Customer_ID", txtcode.Text);
                cmd.Parameters.AddWithValue("@Customer_Name", txtname.Text);
                cmd.Parameters.AddWithValue("@Phone_Number", txtphone.Text);
                cmd.Parameters.AddWithValue("@Address", txtadr.Text);
                
                //adt = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                DataTable dttb = new DataTable();
                //adt.Fill(dttb);
                //dtgrv.DataSource = dttb;
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string dele = ("delete from Customer where Customer_ID = @Customer_ID");
            cmd = new SqlCommand(dele,sql);
            cmd.Parameters.AddWithValue("@Customer_ID", txtcode.Text);
            cmd.ExecuteNonQuery();
            //adt = new SqlDataAdapter(cmd);  
            //adt.Fill(dttb);
            //dtgrv.DataSource = dttb;
            LoadData();
            sql.Close();    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string update = ("update Customer set Customer_ID = @Customer_ID, Customer_Name = @Customer_Name, Phone_Number = @Phone_Number, Address = @Address where Customer_ID = @Customer_ID");
            cmd = new SqlCommand(update, sql);
            cmd.Parameters.AddWithValue("@Customer_ID", txtcode.Text);
            cmd.Parameters.AddWithValue("@Customer_Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Phone_Number", txtphone.Text);
            cmd.Parameters.AddWithValue("@Address", txtadr.Text);
            cmd.ExecuteNonQuery();
            LoadData();
            sql.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string search = ("select * from Customer where Customer_ID = @Customer_ID");
            cmd = new SqlCommand(search,sql);
            cmd.Parameters.AddWithValue("@Customer_ID",txtcode.Text);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            LoadData();
            if (dttb.Rows.Count > 0)
            {
                txtname.Text = dttb.Rows[0]["Customer_ID"].ToString();
                txtphone.Text = dttb.Rows[0]["Phone_Number"].ToString();
                txtadr.Text = dttb.Rows[0]["Address"].ToString() ;
            }
            else
            {
                MessageBox.Show("Mã Nhân Viên Này Không tồn tại");
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
