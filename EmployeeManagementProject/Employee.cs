using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagementProject
{
    class Employee
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
}
