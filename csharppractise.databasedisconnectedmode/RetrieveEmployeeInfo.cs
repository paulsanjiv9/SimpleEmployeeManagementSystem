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
    public partial class RetrieveEmployeeInfo : Form
    {
        public RetrieveEmployeeInfo()
        {
            InitializeComponent();
        }

        private void RetrieveEmployeeInfo_Load(object sender, EventArgs e)
        {
             string constr = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Employee;Data Source=Sanjeev\\SQLEXPRESS";
            // OleDbConnection con=new OleDbConnection(constr);
            SqlConnection con = new SqlConnection(constr);//the provider in string removed to prevent exception
            con.Open();
            Console.WriteLine("connection successful");
            SqlDataAdapter da = new SqlDataAdapter("Select * from dbo.tbl_employee", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            
        }
    }
}
