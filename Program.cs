using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace csharppractise.aodb
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NORTHWND;Data Source=Sanjeev\\SQLEXPRESS";
            // OleDbConnection con=new OleDbConnection(constr);
            SqlConnection con = new SqlConnection(constr);//the provider in string removed to prevent exception
            con.Open();
            Console.WriteLine("connection successful");
        }
    }
}
