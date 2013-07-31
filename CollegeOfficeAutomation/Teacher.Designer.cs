namespace CollegeOfficeAutomation
{
    partial class Teacher
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
            this.insert_teacher_btn = new System.Windows.Forms.Button();
            this.teacher_info_btn = new System.Windows.Forms.Button();
            this.teacher_salary_btn = new System.Windows.Forms.Button();
            this.add_teacher_attendance_btn = new System.Windows.Forms.Button();
            this.show_teacher_attendance_btn = new System.Windows.Forms.Button();
            this.back_teacher_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click Below The Option";
            // 
            // insert_teacher_btn
            // 
            this.insert_teacher_btn.Location = new System.Drawing.Point(195, 85);
            this.insert_teacher_btn.Name = "insert_teacher_btn";
            this.insert_teacher_btn.Size = new System.Drawing.Size(163, 23);
            this.insert_teacher_btn.TabIndex = 1;
            this.insert_teacher_btn.Text = "Insert Teacher";
            this.insert_teacher_btn.UseVisualStyleBackColor = true;
            this.insert_teacher_btn.Click += new System.EventHandler(this.insert_teacher_btn_Click);
            // 
            // teacher_info_btn
            // 
            this.teacher_info_btn.Location = new System.Drawing.Point(195, 128);
            this.teacher_info_btn.Name = "teacher_info_btn";
            this.teacher_info_btn.Size = new System.Drawing.Size(163, 23);
            this.teacher_info_btn.TabIndex = 2;
            this.teacher_info_btn.Text = "Show Teacher Information";
            this.teacher_info_btn.UseVisualStyleBackColor = true;
            this.teacher_info_btn.Click += new System.EventHandler(this.teacher_info_btn_Click);
            // 
            // teacher_salary_btn
            // 
            this.teacher_salary_btn.Location = new System.Drawing.Point(195, 173);
            this.teacher_salary_btn.Name = "teacher_salary_btn";
            this.teacher_salary_btn.Size = new System.Drawing.Size(163, 23);
            this.teacher_salary_btn.TabIndex = 3;
            this.teacher_salary_btn.Text = "Show Teacher Salary";
            this.teacher_salary_btn.UseVisualStyleBackColor = true;
            this.teacher_salary_btn.Click += new System.EventHandler(this.teacher_salary_btn_Click);
            // 
            // add_teacher_attendance_btn
            // 
            this.add_teacher_attendance_btn.Location = new System.Drawing.Point(195, 213);
            this.add_teacher_attendance_btn.Name = "add_teacher_attendance_btn";
            this.add_teacher_attendance_btn.Size = new System.Drawing.Size(163, 23);
            this.add_teacher_attendance_btn.TabIndex = 4;
            this.add_teacher_attendance_btn.Text = "Add Teacher Attendance";
            this.add_teacher_attendance_btn.UseVisualStyleBackColor = true;
            this.add_teacher_attendance_btn.Click += new System.EventHandler(this.add_teacher_attendance_btn_Click);
            // 
            // show_teacher_attendance_btn
            // 
            this.show_teacher_attendance_btn.Location = new System.Drawing.Point(195, 262);
            this.show_teacher_attendance_btn.Name = "show_teacher_attendance_btn";
            this.show_teacher_attendance_btn.Size = new System.Drawing.Size(163, 23);
            this.show_teacher_attendance_btn.TabIndex = 5;
            this.show_teacher_attendance_btn.Text = "Show Teacher Attendance";
            this.show_teacher_attendance_btn.UseVisualStyleBackColor = true;
            this.show_teacher_attendance_btn.Click += new System.EventHandler(this.show_teacher_attendance_btn_Click);
            // 
            // back_teacher_btn
            // 
            this.back_teacher_btn.Location = new System.Drawing.Point(458, 328);
            this.back_teacher_btn.Name = "back_teacher_btn";
            this.back_teacher_btn.Size = new System.Drawing.Size(126, 23);
            this.back_teacher_btn.TabIndex = 6;
            this.back_teacher_btn.Text = "Back";
            this.back_teacher_btn.UseVisualStyleBackColor = true;
            this.back_teacher_btn.Click += new System.EventHandler(this.back_teacher_btn_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 363);
            this.Controls.Add(this.back_teacher_btn);
            this.Controls.Add(this.show_teacher_attendance_btn);
            this.Controls.Add(this.add_teacher_attendance_btn);
            this.Controls.Add(this.teacher_salary_btn);
            this.Controls.Add(this.teacher_info_btn);
            this.Controls.Add(this.insert_teacher_btn);
            this.Controls.Add(this.label1);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insert_teacher_btn;
        private System.Windows.Forms.Button teacher_info_btn;
        private System.Windows.Forms.Button teacher_salary_btn;
        private System.Windows.Forms.Button add_teacher_attendance_btn;
        private System.Windows.Forms.Button show_teacher_attendance_btn;
        private System.Windows.Forms.Button back_teacher_btn;
    }
}