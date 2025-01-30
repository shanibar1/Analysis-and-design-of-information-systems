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
    public partial class CreateVolunteer : Form
    {
        public CreateVolunteer()
        {
            InitializeComponent();
            comboBox_VolunteerRole.DataSource = Enum.GetValues(typeof(VolunteerRole));
            comboBox_VolunteerDrivingLicence.DataSource = Enum.GetValues(typeof(VolunteerDrivingLicence));
            comboBox_VolunteerDrivingLicence.SelectedText = "";
        }

        private void comboBox_VolunteerRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox_VolunteerRole.Text.Equals("Driver"))
            {
                comboBox_VolunteerDrivingLicence.Enabled = false;
            }
            else
            comboBox_VolunteerDrivingLicence.Enabled = true;
        }
    }
}
