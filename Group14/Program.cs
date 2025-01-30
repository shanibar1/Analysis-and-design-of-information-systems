using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Group14
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static System.Collections.Generic.List<Employee> Employees;
        public static System.Collections.Generic.List<Volunteer> Volunteers;
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //init_All();
            Application.Run(new HomePage());
        }

        public static void init_Employees()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Employees";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Employees = new List<Employee>();

            while (rdr.Read())
            {
                EmployeeRole er = (EmployeeRole)Enum.Parse(typeof(EmployeeRole), rdr.GetValue(5).ToString());
                bool isActive = bool.Parse(rdr.GetValue(6).ToString());
                Employee e = new Employee(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), er, isActive, false);
                if (e.get_isEmployeeActive())
                    Employees.Add(e);
            }
        }

        public static Employee seekEmployee(string id)
        {
            foreach (Employee e in Employees)
            {
                if (e.get_employeeId() == id)
                    return e;
            }
            return null;
        }

        public static void init_All()
        {
            init_Employees();
        }
    }
}
