namespace CollegeOfficeAutomation
{
    partial class Staff
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
            this.insert_staff_btn = new System.Windows.Forms.Button();
            this.staff_info_btn = new System.Windows.Forms.Button();
            this.staff_salary_btn = new System.Windows.Forms.Button();
            this.add_staff_attendance_btn = new System.Windows.Forms.Button();
            this.show_staff_attendance_btn = new System.Windows.Forms.Button();
            this.back_staff_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click Below The Option";
            // 
            // insert_staff_btn
            // 
            this.insert_staff_btn.Location = new System.Drawing.Point(151, 84);
            this.insert_staff_btn.Name = "insert_staff_btn";
            this.insert_staff_btn.Size = new System.Drawing.Size(158, 23);
            this.insert_staff_btn.TabIndex = 1;
            this.insert_staff_btn.Text = "Insert Staff";
            this.insert_staff_btn.UseVisualStyleBackColor = true;
            this.insert_staff_btn.Click += new System.EventHandler(this.insert_staff_btn_Click);
            // 
            // staff_info_btn
            // 
            this.staff_info_btn.Location = new System.Drawing.Point(151, 129);
            this.staff_info_btn.Name = "staff_info_btn";
            this.staff_info_btn.Size = new System.Drawing.Size(158, 23);
            this.staff_info_btn.TabIndex = 2;
            this.staff_info_btn.Text = "Show Staff Information";
            this.staff_info_btn.UseVisualStyleBackColor = true;
            this.staff_info_btn.Click += new System.EventHandler(this.staff_info_btn_Click);
            // 
            // staff_salary_btn
            // 
            this.staff_salary_btn.Location = new System.Drawing.Point(151, 177);
            this.staff_salary_btn.Name = "staff_salary_btn";
            this.staff_salary_btn.Size = new System.Drawing.Size(158, 23);
            this.staff_salary_btn.TabIndex = 3;
            this.staff_salary_btn.Text = "Show Staff Salary";
            this.staff_salary_btn.UseVisualStyleBackColor = true;
            this.staff_salary_btn.Click += new System.EventHandler(this.staff_salary_btn_Click);
            // 
            // add_staff_attendance_btn
            // 
            this.add_staff_attendance_btn.Location = new System.Drawing.Point(151, 219);
            this.add_staff_attendance_btn.Name = "add_staff_attendance_btn";
            this.add_staff_attendance_btn.Size = new System.Drawing.Size(158, 23);
            this.add_staff_attendance_btn.TabIndex = 4;
            this.add_staff_attendance_btn.Text = "Add Staff Attendance";
            this.add_staff_attendance_btn.UseVisualStyleBackColor = true;
            this.add_staff_attendance_btn.Click += new System.EventHandler(this.add_staff_attendance_btn_Click);
            // 
            // show_staff_attendance_btn
            // 
            this.show_staff_attendance_btn.Location = new System.Drawing.Point(151, 265);
            this.show_staff_attendance_btn.Name = "show_staff_attendance_btn";
            this.show_staff_attendance_btn.Size = new System.Drawing.Size(158, 23);
            this.show_staff_attendance_btn.TabIndex = 5;
            this.show_staff_attendance_btn.Text = "Show Staff Attendance";
            this.show_staff_attendance_btn.UseVisualStyleBackColor = true;
            this.show_staff_attendance_btn.Click += new System.EventHandler(this.show_staff_attendance_btn_Click);
            // 
            // back_staff_btn
            // 
            this.back_staff_btn.Location = new System.Drawing.Point(450, 331);
            this.back_staff_btn.Name = "back_staff_btn";
            this.back_staff_btn.Size = new System.Drawing.Size(75, 23);
            this.back_staff_btn.TabIndex = 6;
            this.back_staff_btn.Text = "Back";
            this.back_staff_btn.UseVisualStyleBackColor = true;
            this.back_staff_btn.Click += new System.EventHandler(this.back_staff_btn_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 366);
            this.Controls.Add(this.back_staff_btn);
            this.Controls.Add(this.show_staff_attendance_btn);
            this.Controls.Add(this.add_staff_attendance_btn);
            this.Controls.Add(this.staff_salary_btn);
            this.Controls.Add(this.staff_info_btn);
            this.Controls.Add(this.insert_staff_btn);
            this.Controls.Add(this.label1);
            this.Name = "Staff";
            this.Text = "Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insert_staff_btn;
        private System.Windows.Forms.Button staff_info_btn;
        private System.Windows.Forms.Button staff_salary_btn;
        private System.Windows.Forms.Button add_staff_attendance_btn;
        private System.Windows.Forms.Button show_staff_attendance_btn;
        private System.Windows.Forms.Button back_staff_btn;
    }
}