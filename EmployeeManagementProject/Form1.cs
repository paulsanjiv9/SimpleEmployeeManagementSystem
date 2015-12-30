using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EMSLibrary;
using System.Data.SqlClient;
namespace EmployeeManagementProject
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        DealwithDatabase deal = new DealwithDatabase();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            int newEmpId = deal.FetchMaxId();
            txt_number.Text = newEmpId.ToString();
            int newManagerId = deal.FetchManagerID();
           txt_mid.Text = newManagerId.ToString();
           DataTable dt = deal.RetrieveData();
            dataGridView1.DataSource = dt;
            combo_department.SelectedItem = "Please Select";
            combo_department2.SelectedItem = "Please Select";
            combo_department.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_department2.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_dept.SelectedItem = "Please Select";
            combo_dept.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void btn_submit_Click_1(object sender, EventArgs e)
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
                deal.insertdata(em);
                deal.closeconnection();
                MessageBox.Show("Record Inserted Successfully");
                MakeBoxesEmpty();
                DataTable dt = deal.RetrieveData();
                dataGridView1.DataSource = dt;
            }
        }

        private void MakeBoxesEmpty()
        {
            int newEmpId = deal.FetchMaxId();
            txt_number.Text = newEmpId.ToString();
            txt_name.Text = "";
            txt_salary.Text = "";
            combo_department.Text = "";
            txt_address.Text = "";
            combo_department.SelectedItem = "Please Select";
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_mid.Text == "" || txt_mname.Text == "" || combo_department2.Text=="Please Select")
            {
                MessageBox.Show("Please fill all the entries");
            }
            Manager thismanager = new Manager();
            thismanager.Managerid =int.Parse( txt_mid.Text);
            thismanager.Managername = txt_mname.Text;
            thismanager.Department = combo_department2.Text;
            deal.InsertManager(thismanager);
            deal.closeconnection();
            MessageBox.Show("Record Inserted Successfully");
            MakeBoxesEmpty2();
            //DataTable dt = deal.RetrieveData();
            //dataGridView1.DataSource = dt;
        }

        private void MakeBoxesEmpty2()
        {
            txt_mname.Text = "";
            combo_department2.SelectedItem = "Please Select";
            int newManagerId = deal.FetchManagerID();
            txt_mid.Text = newManagerId.ToString();
        }

        private void combo_dept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
