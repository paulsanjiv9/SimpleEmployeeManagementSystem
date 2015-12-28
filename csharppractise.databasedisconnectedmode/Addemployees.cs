using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace csharppractise.databasedisconnectedmode
{
    public partial class Addemployees : Form
    {
        public Addemployees()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Employee;Data Source=Sanjeev\\SQLEXPRESS";
            // OleDbConnection con=new OleDbConnection(constr);
            SqlConnection con = new SqlConnection(constr);//the provider in string removed to prevent exception
            con.Open();
            MessageBox.Show("connected");
            SqlDataAdapter da = new SqlDataAdapter("Select * from dbo.tbl_employee", con);
            SqlCommandBuilder cmb = new SqlCommandBuilder();
            DataSet ds = new DataSet();
            MessageBox.Show("connected");
            da.Fill(ds,"Employee");
            MessageBox.Show("connected");
            ds.Tables[0].Constraints.Add("empno_pk", ds.Tables[0].Columns[0], true);
            DataRow row;
            row = ds.Tables[0].NewRow();
            row["Empno"] = textBox1.Text;
            row["Ename"] = textBox2.Text;
            row["Salary"] = textBox3.Text;
            row["Hiredate"] = textBox4.Text;
            ds.Tables[0].Rows.Add(row);
            da.Update(ds.Tables[0]);
            MessageBox.Show("record added successfully");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
