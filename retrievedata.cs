using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace csharppractise.aodb
{
    public partial class retrievedata : Form
    {
        public retrievedata()
        {
            InitializeComponent();
        }

        private void retrievedata_Load(object sender, EventArgs e)
        {
             string constr = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Employee;Data Source=Sanjeev\\SQLEXPRESS";
            // OleDbConnection con=new OleDbConnection(constr);
            SqlConnection con = new SqlConnection(constr);//the provider in string removed to prevent exception
            con.Open();
            Console.WriteLine("connection successful");
            SqlDataAdapter da=new SqlDataAdapter(con);

        }
        }
    }
}
