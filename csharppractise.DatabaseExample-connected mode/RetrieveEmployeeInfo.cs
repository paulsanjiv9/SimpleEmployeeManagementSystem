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
    public partial class RetrieveEmployeeInfo : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public RetrieveEmployeeInfo()
        {
            InitializeComponent();
        }

        private void RetrieveEmployeeInfo_Load(object sender, EventArgs e)
        {
            string cs = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Employee;Data Source=Sanjeev\\SQLEXPRESS";
            con = new SqlConnection(cs);
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
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
    }
}
