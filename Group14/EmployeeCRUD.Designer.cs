namespace Group14
{
    partial class EmployeeCRUD
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
            this.button_WatchExistEmployee = new System.Windows.Forms.Button();
            this.button_CreateNewEmployee = new System.Windows.Forms.Button();
            this.button_ReturnToHomePage = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(51, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "ניהול עובדים";
            // 
            // button_WatchExistEmployee
            // 
            this.button_WatchExistEmployee.Location = new System.Drawing.Point(312, 278);
            this.button_WatchExistEmployee.Name = "button_WatchExistEmployee";
            this.button_WatchExistEmployee.Size = new System.Drawing.Size(103, 23);
            this.button_WatchExistEmployee.TabIndex = 1;
            this.button_WatchExistEmployee.Text = "צפה בעובד קיים";
            this.button_WatchExistEmployee.UseVisualStyleBackColor = true;
            this.button_WatchExistEmployee.Click += new System.EventHandler(this.button_WatchExistEmployee_Click);
            // 
            // button_CreateNewEmployee
            // 
            this.button_CreateNewEmployee.Location = new System.Drawing.Point(47, 278);
            this.button_CreateNewEmployee.Name = "button_CreateNewEmployee";
            this.button_CreateNewEmployee.Size = new System.Drawing.Size(90, 23);
            this.button_CreateNewEmployee.TabIndex = 2;
            this.button_CreateNewEmployee.Text = "צור עובד חדש";
            this.button_CreateNewEmployee.UseVisualStyleBackColor = true;
            this.button_CreateNewEmployee.Click += new System.EventHandler(this.button_CreateNewEmployee_Click);
            // 
            // button_ReturnToHomePage
            // 
            this.button_ReturnToHomePage.Location = new System.Drawing.Point(189, 341);
            this.button_ReturnToHomePage.Name = "button_ReturnToHomePage";
            this.button_ReturnToHomePage.Size = new System.Drawing.Size(75, 23);
            this.button_ReturnToHomePage.TabIndex = 3;
            this.button_ReturnToHomePage.Text = "חזור";
            this.button_ReturnToHomePage.UseVisualStyleBackColor = true;
            this.button_ReturnToHomePage.Click += new System.EventHandler(this.button_ReturnToHomePage_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(189, 407);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "יציאה";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // EmployeeCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 466);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_ReturnToHomePage);
            this.Controls.Add(this.button_CreateNewEmployee);
            this.Controls.Add(this.button_WatchExistEmployee);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeCRUD";
            this.Text = "EmployeeCRUD";
            this.Load += new System.EventHandler(this.EmployeeCRUD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_WatchExistEmployee;
        private System.Windows.Forms.Button button_CreateNewEmployee;
        private System.Windows.Forms.Button button_ReturnToHomePage;
        private System.Windows.Forms.Button button_Exit;
    }
}