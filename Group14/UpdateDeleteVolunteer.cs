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
    public partial class UpdateDeleteVolunteer : Form
    {
        public UpdateDeleteVolunteer()
        {
        
            InitializeComponent();
            comboBox_VolunteerRole.DataSource = Enum.GetValues(typeof(VolunteerRole));
            //נטרול תיבות הטקסט כך שלא ניתן יהיה לרשום בהן
            textBox_VolunteerFirstName.Enabled = false;
            textBox_VolunteerLastName.Enabled = false;
            textBox_VolunteerMail.Enabled = false;
            textBox_VolunteerPhoneNumber.Enabled = false;
            comboBox_VolunteerRole.Enabled = false;
            //הסתרת הכפתורים
            button_DeleteVolunteer.Hide();
            button_UpdateVolunteer.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_VolunteerRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
