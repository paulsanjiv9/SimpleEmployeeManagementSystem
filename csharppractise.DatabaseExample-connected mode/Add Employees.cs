using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace csharppractise.DatabaseExample_connected_mode
{
    public partial class AddEmployee : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        struct Employee
        {
            int emp_id;
            string emp_name;
            string salary;
            DateTime dateofjoin;
            DateTime dob;
            string dept;
            string address;
            public int Emp_id
            {
                get { return emp_id; }
                set { emp_id = value; }
            }

            public string Emp_name
            {
                get { return emp_name; }
                set { emp_name = value; }
            }


            public string Salary
            {
                get { return salary; }
                set { salary = value; }
            }


            public DateTime Dateofjoin
            {
                get { return dateofjoin; }
                set { dateofjoin = value; }
            }




            public DateTime Dob
            {
                get { return dob; }
                set { dob = value; }
            }




            public string Dept
            {
                get { return dept; }
                set { dept = value; }
            }


            public string Address
            {
                get { return address; }
                set { address = value; }
            }

        };
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string cs = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Employee;Data Source=Sanjeev\\SQLEXPRESS";
                con = new SqlConnection(cs);
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                MessageBox.Show("good upto here");
                loaddataingrid();
                generateid();
                combo_department.SelectedItem = "Please Select";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void generateid()
        {
            cmd.CommandText = "Select MAX(Empno) from dbo.tbl_employee";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

                int maxId = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                maxId = maxId + 1;
                txt_number.Text = maxId.ToString();
            }
        }

        private void loaddataingrid()
        {
            cmd.CommandText = "Select * from dbo.tbl_employee";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                con.Close();
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_salary.Text == "" || combo_department.Text == "Please Select" || txt_address.Text == "")
            {
                MessageBox.Show("Please fill all the details");
            }
            else
            {
                Employee em = new Employee();
                em.Emp_id = int.Parse(txt_number.Text);


                em.Emp_name = txt_name.Text;
                em.Salary = txt_salary.Text;
                em.Dateofjoin = doj.Value;
                em.Dob = dob.Value;
                em.Dept = combo_department.Text;
                em.Address = txt_address.Text;
                cmd.CommandText = "insert into dbo.tbl_employee values (@id,@emp_name,@salary,@dateofjoin,@dateofbirth,@dept,@address)";
                cmd.Parameters.AddWithValue("@id", em.Emp_id);
                cmd.Parameters.AddWithValue("@emp_name", em.Emp_name);
                cmd.Parameters.AddWithValue("@salary", em.Salary);
                cmd.Parameters.AddWithValue("@dateofjoin", em.Dateofjoin);
                cmd.Parameters.AddWithValue("@dateofbirth", em.Dob);
                cmd.Parameters.AddWithValue("@dept", em.Dept);
                cmd.Parameters.AddWithValue("@address", em.Address);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Inserted Successfully");

                    loaddataingrid();
                    
                }
                txt_name.Text = "";
                txt_salary.Text = "";
                combo_department.Text = "";
                txt_address.Text = "";



            }
        }

    }
}
