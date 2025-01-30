namespace Group14
{
    partial class UpdateDeleteVolunteer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_VolunteerId = new System.Windows.Forms.TextBox();
            this.textBox_VolunteerFirstName = new System.Windows.Forms.TextBox();
            this.textBox_VolunteerLastName = new System.Windows.Forms.TextBox();
            this.textBox_VolunteerMail = new System.Windows.Forms.TextBox();
            this.textBox_VolunteerPhoneNumber = new System.Windows.Forms.TextBox();
            this.comboBox_VolunteerRole = new System.Windows.Forms.ComboBox();
            this.button_UpdateVolunteer = new System.Windows.Forms.Button();
            this.button_DeleteVolunteer = new System.Windows.Forms.Button();
            this.button_ReturnToVolunteerCRUD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(352, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = ":הכנס ת.ז מתנדב";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(388, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = ":שם פרטי";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(376, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = ":שם משפחה";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(408, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = ":מייל";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(363, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = ":מספר פלאפון";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(399, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = ":תפקיד";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox_VolunteerId
            // 
            this.textBox_VolunteerId.Location = new System.Drawing.Point(208, 126);
            this.textBox_VolunteerId.Name = "textBox_VolunteerId";
            this.textBox_VolunteerId.Size = new System.Drawing.Size(100, 20);
            this.textBox_VolunteerId.TabIndex = 6;
            // 
            // textBox_VolunteerFirstName
            // 
            this.textBox_VolunteerFirstName.Location = new System.Drawing.Point(208, 194);
            this.textBox_VolunteerFirstName.Name = "textBox_VolunteerFirstName";
            this.textBox_VolunteerFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBox_VolunteerFirstName.TabIndex = 7;
            // 
            // textBox_VolunteerLastName
            // 
            this.textBox_VolunteerLastName.Location = new System.Drawing.Point(208, 249);
            this.textBox_VolunteerLastName.Name = "textBox_VolunteerLastName";
            this.textBox_VolunteerLastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_VolunteerLastName.TabIndex = 8;
            // 
            // textBox_VolunteerMail
            // 
            this.textBox_VolunteerMail.Location = new System.Drawing.Point(208, 307);
            this.textBox_VolunteerMail.Name = "textBox_VolunteerMail";
            this.textBox_VolunteerMail.Size = new System.Drawing.Size(100, 20);
            this.textBox_VolunteerMail.TabIndex = 9;
            // 
            // textBox_VolunteerPhoneNumber
            // 
            this.textBox_VolunteerPhoneNumber.Location = new System.Drawing.Point(208, 360);
            this.textBox_VolunteerPhoneNumber.Name = "textBox_VolunteerPhoneNumber";
            this.textBox_VolunteerPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBox_VolunteerPhoneNumber.TabIndex = 10;
            // 
            // comboBox_VolunteerRole
            // 
            this.comboBox_VolunteerRole.FormattingEnabled = true;
            this.comboBox_VolunteerRole.Location = new System.Drawing.Point(187, 418);
            this.comboBox_VolunteerRole.Name = "comboBox_VolunteerRole";
            this.comboBox_VolunteerRole.Size = new System.Drawing.Size(121, 21);
            this.comboBox_VolunteerRole.TabIndex = 11;
            this.comboBox_VolunteerRole.SelectedIndexChanged += new System.EventHandler(this.comboBox_VolunteerRole_SelectedIndexChanged);
            // 
            // button_UpdateVolunteer
            // 
            this.button_UpdateVolunteer.Location = new System.Drawing.Point(366, 496);
            this.button_UpdateVolunteer.Name = "button_UpdateVolunteer";
            this.button_UpdateVolunteer.Size = new System.Drawing.Size(75, 23);
            this.button_UpdateVolunteer.TabIndex = 12;
            this.button_UpdateVolunteer.Text = "עדכן";
            this.button_UpdateVolunteer.UseVisualStyleBackColor = true;
            // 
            // button_DeleteVolunteer
            // 
            this.button_DeleteVolunteer.Location = new System.Drawing.Point(208, 496);
            this.button_DeleteVolunteer.Name = "button_DeleteVolunteer";
            this.button_DeleteVolunteer.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteVolunteer.TabIndex = 13;
            this.button_DeleteVolunteer.Text = "מחק";
            this.button_DeleteVolunteer.UseVisualStyleBackColor = true;
            // 
            // button_ReturnToVolunteerCRUD
            // 
            this.button_ReturnToVolunteerCRUD.Location = new System.Drawing.Point(51, 496);
            this.button_ReturnToVolunteerCRUD.Name = "button_ReturnToVolunteerCRUD";
            this.button_ReturnToVolunteerCRUD.Size = new System.Drawing.Size(75, 23);
            this.button_ReturnToVolunteerCRUD.TabIndex = 14;
            this.button_ReturnToVolunteerCRUD.Text = "חזור";
            this.button_ReturnToVolunteerCRUD.UseVisualStyleBackColor = true;
            // 
            // UpdateDeleteVolunteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 615);
            this.Controls.Add(this.button_ReturnToVolunteerCRUD);
            this.Controls.Add(this.button_DeleteVolunteer);
            this.Controls.Add(this.button_UpdateVolunteer);
            this.Controls.Add(this.comboBox_VolunteerRole);
            this.Controls.Add(this.textBox_VolunteerPhoneNumber);
            this.Controls.Add(this.textBox_VolunteerMail);
            this.Controls.Add(this.textBox_VolunteerLastName);
            this.Controls.Add(this.textBox_VolunteerFirstName);
            this.Controls.Add(this.textBox_VolunteerId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateDeleteVolunteer";
            this.Text = "UpdateDeleteVolunteer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_VolunteerId;
        private System.Windows.Forms.TextBox textBox_VolunteerFirstName;
        private System.Windows.Forms.TextBox textBox_VolunteerLastName;
        private System.Windows.Forms.TextBox textBox_VolunteerMail;
        private System.Windows.Forms.TextBox textBox_VolunteerPhoneNumber;
        private System.Windows.Forms.ComboBox comboBox_VolunteerRole;
        private System.Windows.Forms.Button button_UpdateVolunteer;
        private System.Windows.Forms.Button button_DeleteVolunteer;
        private System.Windows.Forms.Button button_ReturnToVolunteerCRUD;
    }
}