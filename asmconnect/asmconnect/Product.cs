using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asmconnect
{
    public partial class Product : Form
    {
        string str = @"Data Source=TRUONG-NGOC-HOA\SQLEXPRESS;Initial Catalog=asm;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dttb;
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Product", sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtgrv.DataSource = dttb;
            sql.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string add = ("insert into Product(Product_ID,Product_Name, Entry_Price, Selling_Price, Quantity) values (@Product_ID, @Product_Name, @Entry_Price, @Selling_Price, @Quantity)");
            cmd = new SqlCommand(add, sql);
            cmd.Parameters.AddWithValue("@Product_ID", txtcode.Text);
            cmd.Parameters.AddWithValue("@product_Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Entry_Price", txtentry.Text);
            cmd.Parameters.AddWithValue("@Selling_Price", txtselling.Text);
            cmd.Parameters.AddWithValue("Quantity", txtqtt.Text);
            cmd.ExecuteNonQuery();
            LoadData();
            sql.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Product", sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtgrv.DataSource = dttb;
            LoadData();
            sql.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string delete = ("delete from Product where Product_ID = @Product_ID");
            cmd = new SqlCommand(delete,sql);
            cmd.Parameters.AddWithValue("@Product_ID", txtcode.Text);
            //cmd = new SqlCommand("Select * from Product_mamnagement");
            cmd.ExecuteNonQuery();
            //cmd.ExecuteNonQuery();
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtgrv.DataSource = dttb;
            LoadData();
            sql.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string edit = ("update Product set Product_ID = @Product_ID, Product_Name = @Product_Name, Entry_Price = @Entry_Price, Selling_Price = @Selling_Price, Quantity = @Quantity where Product_ID = @Product_ID");
            cmd = new SqlCommand(edit,sql);
            cmd.Parameters.AddWithValue("@Product_ID", txtcode.Text);
            cmd.Parameters.AddWithValue("@Product_Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Entry_Price", txtentry.Text);
            cmd.Parameters.AddWithValue("@Selling_Price", txtselling.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtqtt.Text);
            cmd.ExecuteNonQuery();
            LoadData();
            sql.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 from1 = new Form1();
            from1.Show();
            this.Hide();
        }
        private void btsearch_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string search = ("Select * from Product where Product_ID = @Product_ID");
            cmd = new SqlCommand(search,sql);
            cmd.Parameters.AddWithValue("@Product_ID", txtcode.Text);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            if(dttb.Rows.Count > 0)
            {
                txtname.Text = dttb.Rows[0]["Product_Name"].ToString();
                txtentry.Text = dttb.Rows[0]["Entry_Price"].ToString();
                txtselling.Text = dttb.Rows[0]["Selling_Price"].ToString();
                txtqtt.Text = dttb.Rows[0]["Quantity"].ToString();
            }
            else
            {
                MessageBox.Show("Mat Hang Nay Khong Ton Tai");
            }
            LoadData();
            sql.Close ();
        }
    }
}
