namespace Group14
{
    partial class VolunteerCRUD
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
            this.button_WatchExistVolunteer = new System.Windows.Forms.Button();
            this.button_CreateNewVolunteer = new System.Windows.Forms.Button();
            this.button_ReturnToHomePage = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "ניהול מתנדבים";
            // 
            // button_WatchExistVolunteer
            // 
            this.button_WatchExistVolunteer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_WatchExistVolunteer.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_WatchExistVolunteer.Location = new System.Drawing.Point(279, 274);
            this.button_WatchExistVolunteer.Name = "button_WatchExistVolunteer";
            this.button_WatchExistVolunteer.Size = new System.Drawing.Size(134, 29);
            this.button_WatchExistVolunteer.TabIndex = 1;
            this.button_WatchExistVolunteer.Text = "צפה במתנדב קיים";
            this.button_WatchExistVolunteer.UseVisualStyleBackColor = false;
            this.button_WatchExistVolunteer.Click += new System.EventHandler(this.button_WatchExistVolunteer_Click);
            // 
            // button_CreateNewVolunteer
            // 
            this.button_CreateNewVolunteer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_CreateNewVolunteer.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_CreateNewVolunteer.Location = new System.Drawing.Point(53, 274);
            this.button_CreateNewVolunteer.Name = "button_CreateNewVolunteer";
            this.button_CreateNewVolunteer.Size = new System.Drawing.Size(130, 29);
            this.button_CreateNewVolunteer.TabIndex = 2;
            this.button_CreateNewVolunteer.Text = "צור מתנדב חדש";
            this.button_CreateNewVolunteer.UseVisualStyleBackColor = false;
            this.button_CreateNewVolunteer.Click += new System.EventHandler(this.button_CreateNewVolunteer_Click);
            // 
            // button_ReturnToHomePage
            // 
            this.button_ReturnToHomePage.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_ReturnToHomePage.Location = new System.Drawing.Point(184, 347);
            this.button_ReturnToHomePage.Name = "button_ReturnToHomePage";
            this.button_ReturnToHomePage.Size = new System.Drawing.Size(75, 23);
            this.button_ReturnToHomePage.TabIndex = 3;
            this.button_ReturnToHomePage.Text = "חזור";
            this.button_ReturnToHomePage.UseVisualStyleBackColor = true;
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Exit.Location = new System.Drawing.Point(184, 388);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "יציאה";
            this.button_Exit.UseVisualStyleBackColor = true;
            // 
            // VolunteerCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 513);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_ReturnToHomePage);
            this.Controls.Add(this.button_CreateNewVolunteer);
            this.Controls.Add(this.button_WatchExistVolunteer);
            this.Controls.Add(this.label1);
            this.Name = "VolunteerCRUD";
            this.Text = "VolunteerCRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_WatchExistVolunteer;
        private System.Windows.Forms.Button button_CreateNewVolunteer;
        private System.Windows.Forms.Button button_ReturnToHomePage;
        private System.Windows.Forms.Button button_Exit;
    }
}