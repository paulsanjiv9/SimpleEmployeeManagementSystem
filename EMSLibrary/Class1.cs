using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace EMSLibrary
{
    public class DealwithDatabase
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;

        public SqlConnection createconnection()
        {
            //ConnectionStringSettings cset = ConfigurationManager.ConnectionStrings["mycstring"];
            // string cstring = cset.ConnectionString;
            string constr = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Employee;Data Source=Sanjeev\\SQLEXPRESS";
            con = new SqlConnection(constr);
            con.Open();
            return con;
        }
        public void closeconnection()
        {
            con.Close();
        }
        public int insertdata(Employee em)
        {
            cmd = new SqlCommand();
            cmd.Connection = createconnection();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into dbo.tbl_employee values (@id,@emp_name,@salary,@dateofjoin,@dateofbirth,@dept,@address)";
            cmd.Parameters.AddWithValue("@id", em.Emp_id);
            cmd.Parameters.AddWithValue("@emp_name", em.Emp_name);
            cmd.Parameters.AddWithValue("@salary", em.Salary);
            cmd.Parameters.AddWithValue("@dateofjoin", em.Dateofjoin);
            cmd.Parameters.AddWithValue("@dateofbirth", em.Dob);
            cmd.Parameters.AddWithValue("@dept", em.Dept);
            cmd.Parameters.AddWithValue("@address", em.managerid);


            return cmd.ExecuteNonQuery();

        }
        public DataTable RetrieveData()
        {
            cmd = new SqlCommand();
            cmd.Connection = createconnection();
            cmd.CommandText = "Select * from dbo.tbl_employee";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
            
        }
        public DataTable RetrieveManagerList()
        {
            cmd = new SqlCommand();
            cmd.Connection = createconnection();
            cmd.CommandText = "Select * from dbo.tbl_manager";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
          

        }
         public DataTable RetrieveEmployeeVsManager()//used a inner join here
        {
            cmd = new SqlCommand();
            cmd.Connection = createconnection();
            cmd.CommandText =  "SELECT Empno, EName, manager_name FROM dbo.tbl_employee INNER JOIN dbo.tbl_manager ON dbo.tbl_employee.manager_id=dbo.tbl_manager.manager_id"; 
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public int FetchMaxId()
        {
            cmd = new SqlCommand();
            cmd.Connection = createconnection();
                        cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select MAX(Empno) from dbo.tbl_employee";
            
                int maxId = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                maxId = maxId + 1;
                return maxId;
        }
        public int InsertManager(Manager mger)
        {
            cmd = new SqlCommand();
            cmd.Connection = createconnection();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into dbo.tbl_manager values (@id,@manager_name,@department)";
            cmd.Parameters.AddWithValue("@id", mger.Managerid);
            cmd.Parameters.AddWithValue("@manager_name", mger.Managername);
            cmd.Parameters.AddWithValue("@department", mger.Department);     
             return cmd.ExecuteNonQuery();
        }

        public int FetchManagerID()
        {
            cmd = new SqlCommand();
            cmd.Connection = createconnection();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select MAX(manager_id) from dbo.tbl_manager";

            int maxId = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            maxId = maxId + 1;
            return maxId;
        }
        public void InsertDepartment()
        {

        }
        public int FetchDepartmentId()
        {
            cmd = new SqlCommand();
            cmd.Connection = createconnection();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select MAX(Empno) from dbo.tbl_employee";

            int maxId = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            maxId = maxId + 1;
            return maxId;
        }
    }
}

