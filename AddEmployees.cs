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
    public partial class AddEmployees : Form
    {
        public AddEmployees()
        {
            InitializeComponent();
        }

        private void AddEmployees_Load(object sender, EventArgs e)
        {
            string constr = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NORTHWND;Data Source=Sanjeev\\SQLEXPRESS";
            // OleDbConnection con=new OleDbConnection(constr);
            SqlConnection con = new SqlConnection(constr);//the provider in string removed to prevent exception
            con.Open();
            Console.WriteLine("connection successfula");
        }
    }
}
