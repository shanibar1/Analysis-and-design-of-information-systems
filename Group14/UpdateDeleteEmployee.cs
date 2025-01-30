using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group14
{
    public partial class UpdateDeleteEmployee : Form
    {
        private Employee exist_Employee;

        public UpdateDeleteEmployee()
        {
            InitializeComponent();
            comboBox_EmployeeRole.DataSource = Enum.GetValues(typeof(EmployeeRole));
            //נטרול תיבות הטקסט כך שלא ניתן יהיה לרשום בהן
            textBox_EmployeeFirstName.Enabled = false;
            textBox_EmployeeLastName.Enabled = false;
            textBox_EmployeeMail.Enabled = false;
            textBox_EmployeePhoneNumber.Enabled = false;
            comboBox_EmployeeRole.Enabled = false;
            //הסתרת הכפתורים
            button_DeleteEmployee.Hide();
            button_UpdateEmployee.Hide();
        }

        private void textBox_EmployeeFirstName_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox_EmployeeLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_EmployeeMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_EmployeePhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_EmployeeRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_UpdateEmployee_Click(object sender, EventArgs e)
        {
            exist_Employee.set_employeeFirstName(textBox_EmployeeFirstName.Text);
            exist_Employee.set_employeeLastName(textBox_EmployeeLastName.Text);
            exist_Employee.set_employeeMail(textBox_EmployeeMail.Text);
            exist_Employee.set_employeePhone(textBox_EmployeePhoneNumber.Text);
            exist_Employee.set_employeeRole((EmployeeRole)Enum.Parse(typeof(EmployeeRole), comboBox_EmployeeRole.Text));
            exist_Employee.UpdateEmployee();

            EmployeeCRUD ecrud = new EmployeeCRUD();
            ecrud.Show();
            this.Close();
        }

        private void button_DeleteEmployee_Click(object sender, EventArgs e)
        {
            exist_Employee.Delete_Employee();

            EmployeeCRUD ecrud = new EmployeeCRUD();
            ecrud.Show();
            this.Close(); ;
        }

        private void button_ReturnToEmployeeCRUD_Click(object sender, EventArgs e)
        {
            EmployeeCRUD ec = new EmployeeCRUD();
            ec.Show();
            this.Hide();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (textBox_EmployeeId != null)
            {
                //הצגת הכפתורים
                button_DeleteEmployee.Show();
                button_UpdateEmployee.Show();
                //איתור המופע המתאים והצגת הפרטים
                exist_Employee = Program.seekEmployee(textBox_EmployeeId.Text);
                textBox_EmployeeFirstName.Enabled = true;
                textBox_EmployeeMail.Enabled = true;
                textBox_EmployeePhoneNumber.Enabled = true;
                comboBox_EmployeeRole.Enabled = true;
                textBox_EmployeeFirstName.Text = exist_Employee.get_employeeFirstName();
                textBox_EmployeeLastName.Text = exist_Employee.get_employeeLastName();
                textBox_EmployeeMail.Text = exist_Employee.get_employeeMail();
                textBox_EmployeePhoneNumber.Text = exist_Employee.get_employeePhone();
                comboBox_EmployeeRole.DataSource = Enum.GetValues(typeof(EmployeeRole));
                comboBox_EmployeeRole.Text = exist_Employee.get_employeeRole().ToString();
            }
        }

        
    }
}
