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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button_EmployeeCRUD_Click(object sender, EventArgs e)
        {
            EmployeeCRUD ec = new EmployeeCRUD();
            ec.Show();
            this.Hide();
        }

        private void button_VolunteerCRUD_Click(object sender, EventArgs e)
        {
            VolunteerCRUD vc = new VolunteerCRUD();
            vc.Show();
            this.Hide();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
