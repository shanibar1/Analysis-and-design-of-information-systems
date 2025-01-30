using System;
using System.Data.SqlClient;

namespace Group14
{
    public class Employee {
        private string employeeId;
        private string employeeFirstName;
        private string employeeLastName;
        private string employeeMail;
        private string employeePhone;
        private EmployeeRole employeeRole;
        private bool isEmployeeActive;

        public Employee(string employeeId, string employeeFirstName, string employeeLastName, string employeeMail, string employeePhone, EmployeeRole employeeRole, bool isEmployeeActive, bool is_new)
        {
            this.employeeId = employeeId;
            this.employeeFirstName = employeeFirstName;
            this.employeeLastName = employeeLastName;
            this.employeeMail = employeeMail;
            this.employeePhone = employeePhone;
            this.employeeRole = employeeRole;
            this.isEmployeeActive = isEmployeeActive;
            if (is_new)
            {
                this.CreateEmployee();
                Program.Employees.Add(this);
            }
        }

        public void CreateEmployee() {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Create_Employee @Id, @firstName, @lastName, @Email, @Phone, @Role, @isActive";
            c.Parameters.AddWithValue("@Id", this.employeeId);
            c.Parameters.AddWithValue("@firstName", this.employeeFirstName);
            c.Parameters.AddWithValue("@lastName", this.employeeLastName);
            c.Parameters.AddWithValue("@Email", this.employeeMail);
            c.Parameters.AddWithValue("@Phone", this.employeePhone);
            c.Parameters.AddWithValue("@Role", this.employeeRole.ToString());
            c.Parameters.AddWithValue("@isActive", this.isEmployeeActive);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void UpdateEmployee() {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.UpdateEmployee @Id, @firstName, @lastName, @Email, @Phone, @Role, @isActive";
            c.Parameters.AddWithValue("@Id", this.employeeId);
            c.Parameters.AddWithValue("@firstName", this.employeeFirstName);
            c.Parameters.AddWithValue("@lastName", this.employeeLastName);
            c.Parameters.AddWithValue("@Email", this.employeeMail);
            c.Parameters.AddWithValue("@Phone", this.employeePhone);
            c.Parameters.AddWithValue("@Role", this.employeeRole.ToString());
            c.Parameters.AddWithValue("@isActive", this.isEmployeeActive);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
            
        }
        public void Delete_Employee()
        {
            Program.Employees.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.DeleteEmployee @Id";
            c.Parameters.AddWithValue("@Id", this.employeeId);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void ScheduleDistributionEvent() {
            throw new System.NotImplementedException("Not implemented");
        }
        public void OrderItems() {
            throw new System.NotImplementedException("Not implemented");
        }
        public void CommunicateWithVendors() {
            throw new System.NotImplementedException("Not implemented");
        }
        public void SendMessageToContributors() {
            throw new System.NotImplementedException("Not implemented");
        }
        public void GetItemsToOrder() {
            throw new System.NotImplementedException("Not implemented");
        }
        public void GetExpired() {
            throw new System.NotImplementedException("Not implemented");
        }
        public void ManageFinances() {
            throw new System.NotImplementedException("Not implemented");
        }
        public void GenerateReports() {
            throw new System.NotImplementedException("Not implemented");
        }
        public void ReviewLegalDocuments() {
            throw new System.NotImplementedException("Not implemented");
        }
        public void ProvideLegalAdvice() {
            throw new System.NotImplementedException("Not implemented");
        }

        public string get_employeeId()
        {
            return this.employeeId;
        }
        public void set_employeeId(string employeeId)
        {
            this.employeeId = employeeId;
        }

        public string get_employeeFirstName()
        {
            return this.employeeFirstName;
        }
        public void set_employeeFirstName(string employeeFirstName)
        {
            this.employeeFirstName = employeeFirstName;
        }

        public string get_employeeLastName()
        {
            return this.employeeLastName;
        }
        public void set_employeeLastName(string employeeLastName)
        {
            this.employeeLastName = employeeLastName;
        }

        public string get_employeeMail()
        {
            return this.employeeMail;
        }
        public void set_employeeMail(string employeeMail)
        {
            this.employeeMail = employeeMail;
        }
        
        public string get_employeePhone()
        {
            return this.employeePhone;
        }
        public void set_employeePhone(string employeePhone)
        {
            this.employeePhone = employeePhone;
        }
        
        public EmployeeRole get_employeeRole()
        {
            return this.employeeRole;
        }
        public void set_employeeRole(EmployeeRole employeeRole)
        {
            this.employeeRole = employeeRole;
        }
        
        public bool get_isEmployeeActive()
        {
            return this.isEmployeeActive;
        }
        public void set_isEmployeeActive(bool isEmployeeActive)
        {
            this.isEmployeeActive = isEmployeeActive;
        }
    }
}