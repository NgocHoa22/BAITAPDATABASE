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
using System.Windows.Markup;

namespace asmconnect
{
    public partial class Form1 : Form
    {
        //string str = @"Data Source=TRUONG-NGOC-HOA\SQLEXPRESS;Initial Catalog=asm;Integrated Security=True;TrustServerCertificate=True";
        //SqlConnection sql;
        //SqlCommand cmd;
        //SqlDataAdapter adt;
        //DataTable dttb;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Hide();
            //try
            //{
            //    sql = new SqlConnection(str);
            //    sql.Open();
            //    cmd = new SqlCommand("Select * from Product_management", sql);
            //    adt = new SqlDataAdapter(cmd);
            //    DataTable dttb = new DataTable();
            //    adt.Fill(dttb);
            //    dtgrv.DataSource = dttb;
            //    sql.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("Lỗi");
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }

        private void txtvv_TextChanged(object sender, EventArgs e)
        {

        }
        //private void LoadData()
        //{
        //    sql = new SqlConnection(str);
        //    sql.Open();
        //    cmd = new SqlCommand("Select * Product_Management", sql);
        //    adt = new SqlDataAdapter(cmd);
        //    DataTable dttb = new DataTable();
        //    adt.Fill(dttb);
        //    sql.Close();
        //}
        private void button2_Click(object sender, EventArgs e)
        {
            Sitattit sitattit = new Sitattit();
            sitattit.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "1234")
            {
                button2.Visible = true;
            }
            else
            {
                MessageBox.Show("NO");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
