namespace Group14
{
    partial class CreateEmployee
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_EmployeeId = new System.Windows.Forms.TextBox();
            this.textBox_EmployeeFirstName = new System.Windows.Forms.TextBox();
            this.textBox_EmployeeLastName = new System.Windows.Forms.TextBox();
            this.textBox_EmployeeMail = new System.Windows.Forms.TextBox();
            this.textBox_EmployeePhoneNumber = new System.Windows.Forms.TextBox();
            this.comboBox_EmployeeRole = new System.Windows.Forms.ComboBox();
            this.button_ReturnToEmployeeCRUD = new System.Windows.Forms.Button();
            this.button_AddNewEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("David", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(626, 63);
            this.label2.TabIndex = 0;
            this.label2.Text = ":מלא את הפרטים הבאים";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = ":תעודת זהות";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = ":שם פרטי";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = ":שם משפחה";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = ":מייל";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = ":מספר פלאפון";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(574, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = ":תפקיד";
            // 
            // textBox_EmployeeId
            // 
            this.textBox_EmployeeId.Location = new System.Drawing.Point(406, 144);
            this.textBox_EmployeeId.Name = "textBox_EmployeeId";
            this.textBox_EmployeeId.Size = new System.Drawing.Size(100, 20);
            this.textBox_EmployeeId.TabIndex = 7;
            this.textBox_EmployeeId.TextChanged += new System.EventHandler(this.textBox_EmployeeId_TextChanged);
            // 
            // textBox_EmployeeFirstName
            // 
            this.textBox_EmployeeFirstName.Location = new System.Drawing.Point(406, 193);
            this.textBox_EmployeeFirstName.Name = "textBox_EmployeeFirstName";
            this.textBox_EmployeeFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBox_EmployeeFirstName.TabIndex = 8;
            this.textBox_EmployeeFirstName.TextChanged += new System.EventHandler(this.textBox_EmployeeFirstName_TextChanged);
            // 
            // textBox_EmployeeLastName
            // 
            this.textBox_EmployeeLastName.Location = new System.Drawing.Point(406, 238);
            this.textBox_EmployeeLastName.Name = "textBox_EmployeeLastName";
            this.textBox_EmployeeLastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_EmployeeLastName.TabIndex = 9;
            this.textBox_EmployeeLastName.TextChanged += new System.EventHandler(this.textBox_EmployeeLastName_TextChanged);
            // 
            // textBox_EmployeeMail
            // 
            this.textBox_EmployeeMail.Location = new System.Drawing.Point(406, 281);
            this.textBox_EmployeeMail.Name = "textBox_EmployeeMail";
            this.textBox_EmployeeMail.Size = new System.Drawing.Size(100, 20);
            this.textBox_EmployeeMail.TabIndex = 10;
            this.textBox_EmployeeMail.TextChanged += new System.EventHandler(this.textBox_EmployeeMail_TextChanged);
            // 
            // textBox_EmployeePhoneNumber
            // 
            this.textBox_EmployeePhoneNumber.Location = new System.Drawing.Point(406, 324);
            this.textBox_EmployeePhoneNumber.Name = "textBox_EmployeePhoneNumber";
            this.textBox_EmployeePhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBox_EmployeePhoneNumber.TabIndex = 11;
            this.textBox_EmployeePhoneNumber.TextChanged += new System.EventHandler(this.textBox_EmployeePhoneNumber_TextChanged);
            // 
            // comboBox_EmployeeRole
            // 
            this.comboBox_EmployeeRole.FormattingEnabled = true;
            this.comboBox_EmployeeRole.Location = new System.Drawing.Point(406, 365);
            this.comboBox_EmployeeRole.Name = "comboBox_EmployeeRole";
            this.comboBox_EmployeeRole.Size = new System.Drawing.Size(121, 21);
            this.comboBox_EmployeeRole.TabIndex = 12;
            this.comboBox_EmployeeRole.SelectedIndexChanged += new System.EventHandler(this.comboBox_EmployeeRole_SelectedIndexChanged);
            // 
            // button_ReturnToEmployeeCRUD
            // 
            this.button_ReturnToEmployeeCRUD.Location = new System.Drawing.Point(211, 434);
            this.button_ReturnToEmployeeCRUD.Name = "button_ReturnToEmployeeCRUD";
            this.button_ReturnToEmployeeCRUD.Size = new System.Drawing.Size(75, 23);
            this.button_ReturnToEmployeeCRUD.TabIndex = 13;
            this.button_ReturnToEmployeeCRUD.Text = "חזור";
            this.button_ReturnToEmployeeCRUD.UseVisualStyleBackColor = true;
            this.button_ReturnToEmployeeCRUD.Click += new System.EventHandler(this.button_ReturnToEmployeeCRUD_Click);
            // 
            // button_AddNewEmployee
            // 
            this.button_AddNewEmployee.Location = new System.Drawing.Point(377, 434);
            this.button_AddNewEmployee.Name = "button_AddNewEmployee";
            this.button_AddNewEmployee.Size = new System.Drawing.Size(75, 23);
            this.button_AddNewEmployee.TabIndex = 14;
            this.button_AddNewEmployee.Text = "צור עובד";
            this.button_AddNewEmployee.UseVisualStyleBackColor = true;
            this.button_AddNewEmployee.Click += new System.EventHandler(this.button_AddNewEmployee_Click);
            // 
            // CreateEmployee
            // 
            this.ClientSize = new System.Drawing.Size(653, 506);
            this.Controls.Add(this.button_AddNewEmployee);
            this.Controls.Add(this.button_ReturnToEmployeeCRUD);
            this.Controls.Add(this.comboBox_EmployeeRole);
            this.Controls.Add(this.textBox_EmployeePhoneNumber);
            this.Controls.Add(this.textBox_EmployeeMail);
            this.Controls.Add(this.textBox_EmployeeLastName);
            this.Controls.Add(this.textBox_EmployeeFirstName);
            this.Controls.Add(this.textBox_EmployeeId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "CreateEmployee";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_EmployeeId;
        private System.Windows.Forms.TextBox textBox_EmployeeFirstName;
        private System.Windows.Forms.TextBox textBox_EmployeeLastName;
        private System.Windows.Forms.TextBox textBox_EmployeeMail;
        private System.Windows.Forms.TextBox textBox_EmployeePhoneNumber;
        private System.Windows.Forms.ComboBox comboBox_EmployeeRole;
        private System.Windows.Forms.Button button_ReturnToEmployeeCRUD;
        private System.Windows.Forms.Button button_AddNewEmployee;
    }
}