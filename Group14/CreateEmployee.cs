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
    public partial class CreateEmployee : Form
    {
        public CreateEmployee()
        {
            InitializeComponent();
            comboBox_EmployeeRole.DataSource = Enum.GetValues(typeof(EmployeeRole));//אתחול הקומבובוקס

        }

        private void textBox_EmployeeId_TextChanged(object sender, EventArgs e)
        {

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

        private void button_AddNewEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(textBox_EmployeeId.Text, textBox_EmployeeFirstName.Text, textBox_EmployeeLastName.Text, textBox_EmployeeMail.Text, textBox_EmployeePhoneNumber.Text, (EmployeeRole)Enum.Parse(typeof(EmployeeRole), comboBox_EmployeeRole.Text), true, true);//יצירת עובד חדש

            EmployeeCRUD ec = new EmployeeCRUD();
            ec.Show();
            this.Close();
        }

        private void button_ReturnToEmployeeCRUD_Click(object sender, EventArgs e)
        {
            EmployeeCRUD ec = new EmployeeCRUD();
            ec.Show();
            this.Hide();
        }
    }
}
