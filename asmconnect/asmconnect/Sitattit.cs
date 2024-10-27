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
    public partial class Sitattit : Form
    {
        string str = @"Data Source=TRUONG-NGOC-HOA\SQLEXPRESS;Initial Catalog=asm;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dttb;
        public Sitattit()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Static", sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtgrv.DataSource = dttb;
            sql.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            //string test = ("select * from lai");
            //string delete = ("delete from lai");
            string nhap = ("Delete from Static; Insert into Static(Customer_ID, Product_ID, Employee_ID, day) select Customer_ID, Product_ID, Employee_ID, Convert(Varchar(50), getdate(), 103) from Product, Customer, Employee group by Product_ID, Customer_ID, Employee_ID");
            //cmd = new SqlCommand(delete,sql);
            cmd = new SqlCommand(nhap, sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dtgrv.DataSource = dt;
            //cmd.ExecuteNonQuery();
            LoadData();
            sql.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.Show();
            this.Hide();
        }
    }
}
