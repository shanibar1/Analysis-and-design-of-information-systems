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
    public partial class VolunteerCRUD : Form
    {
        public VolunteerCRUD()
        {
            InitializeComponent();
        }

        private void button_WatchExistVolunteer_Click(object sender, EventArgs e)
        {

        }

        private void button_CreateNewVolunteer_Click(object sender, EventArgs e)
        {
            CreateVolunteer cv = new CreateVolunteer();

            cv.Show();
            this.Hide();
        }
    }
}
