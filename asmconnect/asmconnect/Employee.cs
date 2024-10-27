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
    public partial class Employee : Form
    {
        string str = @"Data Source=TRUONG-NGOC-HOA\SQLEXPRESS;Initial Catalog=asm;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dttb;
        public Employee()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Employee",sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtgrv.DataSource = dttb;
            sql.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 from1 = new Form1();
            from1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Employee", sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtgrv.DataSource = dttb;
            LoadData();
            sql.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string add = ("Insert into Employee(Employee_ID, Employee_Name, Position, Authority) values(@Employee_ID, @Employee_Name, @Position, @Authority)");
            cmd = new SqlCommand(add,sql);
            cmd.Parameters.AddWithValue("@Employee_ID", txtcode.Text);
            cmd.Parameters.AddWithValue("@Employee_name", txtname.Text);
            cmd.Parameters.AddWithValue("@Position", txtpost.Text);
            cmd.Parameters.AddWithValue("@Authority", txtautho.Text);
            cmd.ExecuteNonQuery();
            adt = new SqlDataAdapter(cmd);
            LoadData();
            sql.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string delete = ("delete from Employee where Employee_ID = @Employee_ID");
            cmd = new SqlCommand(delete,sql);
            cmd.Parameters.AddWithValue("@Employee_ID", txtcode.Text);
            cmd.ExecuteNonQuery();
            //adt = new SqlDataAdapter(cmd);
            //adt.Fill(dttb);
            //dtgrv.DataSource = dttb;
            LoadData(); 
            sql.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection (str);  
            sql.Open();
            string update = ("update Employee set Employee_ID = @Employee_ID, Employee_Name = @Employee_Name, Position = @Position, Authority = @Authority where Employee_ID = @Employee_ID");
            cmd = new SqlCommand(update, sql);
            cmd.Parameters.AddWithValue("@Employee_ID", txtcode.Text);
            cmd.Parameters.AddWithValue("Employee_Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Position", txtpost.Text);
            cmd.Parameters.AddWithValue("@Authority", txtautho.Text);
            cmd.ExecuteNonQuery();
            LoadData();
            sql.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string seach = ("Select * from Employee where Employee_ID = @Employee_ID");
            cmd = new SqlCommand(seach,sql);
            cmd.Parameters.AddWithValue("@Employee_ID", txtcode.Text);
            //cmd.ExecuteNonQuery ();
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            if(dttb.Rows.Count > 0)
            {
                txtname.Text = dttb.Rows[0]["Employee_Name"].ToString();
                txtpost.Text = dttb.Rows[0]["Position"].ToString();
                txtautho.Text = dttb.Rows[0]["Authority"].ToString();
            }
            else
            {
                MessageBox.Show("code khong ton tai");
            }
            LoadData();
            sql.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtautho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgrv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }
    }
}
