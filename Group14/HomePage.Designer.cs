namespace Group14
{
    partial class HomePage
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
            this.button_EmployeeCRUD = new System.Windows.Forms.Button();
            this.button_VolunteerCRUD = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_EmployeeCRUD
            // 
            this.button_EmployeeCRUD.Location = new System.Drawing.Point(159, 86);
            this.button_EmployeeCRUD.Name = "button_EmployeeCRUD";
            this.button_EmployeeCRUD.Size = new System.Drawing.Size(101, 23);
            this.button_EmployeeCRUD.TabIndex = 0;
            this.button_EmployeeCRUD.Text = "לניהול עובדים";
            this.button_EmployeeCRUD.UseVisualStyleBackColor = true;
            this.button_EmployeeCRUD.Click += new System.EventHandler(this.button_EmployeeCRUD_Click);
            // 
            // button_VolunteerCRUD
            // 
            this.button_VolunteerCRUD.Location = new System.Drawing.Point(28, 86);
            this.button_VolunteerCRUD.Name = "button_VolunteerCRUD";
            this.button_VolunteerCRUD.Size = new System.Drawing.Size(100, 23);
            this.button_VolunteerCRUD.TabIndex = 1;
            this.button_VolunteerCRUD.Text = "לניהול מתנדבים";
            this.button_VolunteerCRUD.UseVisualStyleBackColor = true;
            this.button_VolunteerCRUD.Click += new System.EventHandler(this.button_VolunteerCRUD_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(101, 174);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "יציאה";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_VolunteerCRUD);
            this.Controls.Add(this.button_EmployeeCRUD);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_EmployeeCRUD;
        private System.Windows.Forms.Button button_VolunteerCRUD;
        private System.Windows.Forms.Button button_Exit;
    }
}