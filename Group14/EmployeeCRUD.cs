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
    public partial class EmployeeCRUD : Form
    {
        public EmployeeCRUD()
        {
            InitializeComponent();
        }

        private void button_WatchExistEmployee_Click(object sender, EventArgs e)
        {
            UpdateDeleteEmployee upE = new UpdateDeleteEmployee();
            upE.Show();
            this.Hide();
        }

        private void button_CreateNewEmployee_Click(object sender, EventArgs e)
        {
            CreateEmployee cE = new CreateEmployee();
            cE.Show();
            this.Hide();
        }

        private void button_ReturnToHomePage_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void EmployeeCRUD_Load(object sender, EventArgs e)
        {

        }
    }
}
