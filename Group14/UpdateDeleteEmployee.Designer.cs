namespace Group14
{
    partial class UpdateDeleteEmployee
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
            this.textBox_EmployeeId = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_EmployeeFirstName = new System.Windows.Forms.TextBox();
            this.textBox_EmployeeMail = new System.Windows.Forms.TextBox();
            this.textBox_EmployeePhoneNumber = new System.Windows.Forms.TextBox();
            this.comboBox_EmployeeRole = new System.Windows.Forms.ComboBox();
            this.button_UpdateEmployee = new System.Windows.Forms.Button();
            this.button_DeleteEmployee = new System.Windows.Forms.Button();
            this.button_ReturnToEmployeeCRUD = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_EmployeeLastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = ":הכנס ת.ז עובד";
            // 
            // textBox_EmployeeId
            // 
            this.textBox_EmployeeId.Location = new System.Drawing.Point(317, 92);
            this.textBox_EmployeeId.Name = "textBox_EmployeeId";
            this.textBox_EmployeeId.Size = new System.Drawing.Size(100, 20);
            this.textBox_EmployeeId.TabIndex = 1;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(192, 92);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 2;
            this.button_Search.Text = "חפש";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = ":שם פרטי";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = ":מייל";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = ":מספר פלאפון";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = ":תפקיד";
            // 
            // textBox_EmployeeFirstName
            // 
            this.textBox_EmployeeFirstName.Location = new System.Drawing.Point(321, 183);
            this.textBox_EmployeeFirstName.Name = "textBox_EmployeeFirstName";
            this.textBox_EmployeeFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBox_EmployeeFirstName.TabIndex = 7;
            this.textBox_EmployeeFirstName.TextChanged += new System.EventHandler(this.textBox_EmployeeFirstName_TextChanged);
            // 
            // textBox_EmployeeMail
            // 
            this.textBox_EmployeeMail.Location = new System.Drawing.Point(321, 247);
            this.textBox_EmployeeMail.Name = "textBox_EmployeeMail";
            this.textBox_EmployeeMail.Size = new System.Drawing.Size(100, 20);
            this.textBox_EmployeeMail.TabIndex = 8;
            this.textBox_EmployeeMail.TextChanged += new System.EventHandler(this.textBox_EmployeeMail_TextChanged);
            // 
            // textBox_EmployeePhoneNumber
            // 
            this.textBox_EmployeePhoneNumber.Location = new System.Drawing.Point(321, 280);
            this.textBox_EmployeePhoneNumber.Name = "textBox_EmployeePhoneNumber";
            this.textBox_EmployeePhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBox_EmployeePhoneNumber.TabIndex = 9;
            this.textBox_EmployeePhoneNumber.TextChanged += new System.EventHandler(this.textBox_EmployeePhoneNumber_TextChanged);
            // 
            // comboBox_EmployeeRole
            // 
            this.comboBox_EmployeeRole.FormattingEnabled = true;
            this.comboBox_EmployeeRole.Location = new System.Drawing.Point(321, 313);
            this.comboBox_EmployeeRole.Name = "comboBox_EmployeeRole";
            this.comboBox_EmployeeRole.Size = new System.Drawing.Size(121, 21);
            this.comboBox_EmployeeRole.TabIndex = 10;
            this.comboBox_EmployeeRole.SelectedIndexChanged += new System.EventHandler(this.comboBox_EmployeeRole_SelectedIndexChanged);
            // 
            // button_UpdateEmployee
            // 
            this.button_UpdateEmployee.Location = new System.Drawing.Point(437, 387);
            this.button_UpdateEmployee.Name = "button_UpdateEmployee";
            this.button_UpdateEmployee.Size = new System.Drawing.Size(75, 23);
            this.button_UpdateEmployee.TabIndex = 11;
            this.button_UpdateEmployee.Text = "עדכן";
            this.button_UpdateEmployee.UseVisualStyleBackColor = true;
            this.button_UpdateEmployee.Click += new System.EventHandler(this.button_UpdateEmployee_Click);
            // 
            // button_DeleteEmployee
            // 
            this.button_DeleteEmployee.Location = new System.Drawing.Point(321, 387);
            this.button_DeleteEmployee.Name = "button_DeleteEmployee";
            this.button_DeleteEmployee.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteEmployee.TabIndex = 12;
            this.button_DeleteEmployee.Text = "מחק";
            this.button_DeleteEmployee.UseVisualStyleBackColor = true;
            this.button_DeleteEmployee.Click += new System.EventHandler(this.button_DeleteEmployee_Click);
            // 
            // button_ReturnToEmployeeCRUD
            // 
            this.button_ReturnToEmployeeCRUD.Location = new System.Drawing.Point(192, 387);
            this.button_ReturnToEmployeeCRUD.Name = "button_ReturnToEmployeeCRUD";
            this.button_ReturnToEmployeeCRUD.Size = new System.Drawing.Size(75, 23);
            this.button_ReturnToEmployeeCRUD.TabIndex = 13;
            this.button_ReturnToEmployeeCRUD.Text = "חזור";
            this.button_ReturnToEmployeeCRUD.UseVisualStyleBackColor = true;
            this.button_ReturnToEmployeeCRUD.Click += new System.EventHandler(this.button_ReturnToEmployeeCRUD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = ":שם משפחה";
            // 
            // textBox_EmployeeLastName
            // 
            this.textBox_EmployeeLastName.Location = new System.Drawing.Point(321, 214);
            this.textBox_EmployeeLastName.Name = "textBox_EmployeeLastName";
            this.textBox_EmployeeLastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_EmployeeLastName.TabIndex = 15;
            this.textBox_EmployeeLastName.TextChanged += new System.EventHandler(this.textBox_EmployeeLastName_TextChanged);
            // 
            // UpdateDeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 456);
            this.Controls.Add(this.textBox_EmployeeLastName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_ReturnToEmployeeCRUD);
            this.Controls.Add(this.button_DeleteEmployee);
            this.Controls.Add(this.button_UpdateEmployee);
            this.Controls.Add(this.comboBox_EmployeeRole);
            this.Controls.Add(this.textBox_EmployeePhoneNumber);
            this.Controls.Add(this.textBox_EmployeeMail);
            this.Controls.Add(this.textBox_EmployeeFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_EmployeeId);
            this.Controls.Add(this.label1);
            this.Name = "UpdateDeleteEmployee";
            this.Text = "UpdateDeleteEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_EmployeeId;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_EmployeeFirstName;
        private System.Windows.Forms.TextBox textBox_EmployeeMail;
        private System.Windows.Forms.TextBox textBox_EmployeePhoneNumber;
        private System.Windows.Forms.ComboBox comboBox_EmployeeRole;
        private System.Windows.Forms.Button button_UpdateEmployee;
        private System.Windows.Forms.Button button_DeleteEmployee;
        private System.Windows.Forms.Button button_ReturnToEmployeeCRUD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_EmployeeLastName;
    }
}