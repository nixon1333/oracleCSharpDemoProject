namespace CollegeOfficeAutomation
{
    partial class Student
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
            this.insert_student_btn = new System.Windows.Forms.Button();
            this.show_student_info_btn = new System.Windows.Forms.Button();
            this.show_sudent_pay_btn = new System.Windows.Forms.Button();
            this.add_student_attend_btn = new System.Windows.Forms.Button();
            this.show_student_attend_btn = new System.Windows.Forms.Button();
            this.back_stdnt_btn = new System.Windows.Forms.Button();
            this.result_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click Below The Option";
            // 
            // insert_student_btn
            // 
            this.insert_student_btn.Location = new System.Drawing.Point(156, 84);
            this.insert_student_btn.Name = "insert_student_btn";
            this.insert_student_btn.Size = new System.Drawing.Size(157, 23);
            this.insert_student_btn.TabIndex = 1;
            this.insert_student_btn.Text = "Insert Student";
            this.insert_student_btn.UseVisualStyleBackColor = true;
            this.insert_student_btn.Click += new System.EventHandler(this.insert_student_btn_Click);
            // 
            // show_student_info_btn
            // 
            this.show_student_info_btn.Location = new System.Drawing.Point(156, 132);
            this.show_student_info_btn.Name = "show_student_info_btn";
            this.show_student_info_btn.Size = new System.Drawing.Size(157, 23);
            this.show_student_info_btn.TabIndex = 2;
            this.show_student_info_btn.Text = "Show Student Information";
            this.show_student_info_btn.UseVisualStyleBackColor = true;
            this.show_student_info_btn.Click += new System.EventHandler(this.show_student_info_btn_Click);
            // 
            // show_sudent_pay_btn
            // 
            this.show_sudent_pay_btn.Location = new System.Drawing.Point(156, 185);
            this.show_sudent_pay_btn.Name = "show_sudent_pay_btn";
            this.show_sudent_pay_btn.Size = new System.Drawing.Size(157, 23);
            this.show_sudent_pay_btn.TabIndex = 3;
            this.show_sudent_pay_btn.Text = "Show Student Payment Information";
            this.show_sudent_pay_btn.UseVisualStyleBackColor = true;
            this.show_sudent_pay_btn.Click += new System.EventHandler(this.show_sudent_pay_btn_Click);
            // 
            // add_student_attend_btn
            // 
            this.add_student_attend_btn.Location = new System.Drawing.Point(156, 225);
            this.add_student_attend_btn.Name = "add_student_attend_btn";
            this.add_student_attend_btn.Size = new System.Drawing.Size(157, 23);
            this.add_student_attend_btn.TabIndex = 4;
            this.add_student_attend_btn.Text = "Add Student Attendance";
            this.add_student_attend_btn.UseVisualStyleBackColor = true;
            this.add_student_attend_btn.Click += new System.EventHandler(this.add_student_attend_btn_Click);
            // 
            // show_student_attend_btn
            // 
            this.show_student_attend_btn.Location = new System.Drawing.Point(156, 267);
            this.show_student_attend_btn.Name = "show_student_attend_btn";
            this.show_student_attend_btn.Size = new System.Drawing.Size(157, 23);
            this.show_student_attend_btn.TabIndex = 5;
            this.show_student_attend_btn.Text = "Show Student Attendance Information";
            this.show_student_attend_btn.UseVisualStyleBackColor = true;
            this.show_student_attend_btn.Click += new System.EventHandler(this.show_student_attend_btn_Click);
            // 
            // back_stdnt_btn
            // 
            this.back_stdnt_btn.Location = new System.Drawing.Point(444, 324);
            this.back_stdnt_btn.Name = "back_stdnt_btn";
            this.back_stdnt_btn.Size = new System.Drawing.Size(106, 23);
            this.back_stdnt_btn.TabIndex = 6;
            this.back_stdnt_btn.Text = "Back";
            this.back_stdnt_btn.UseVisualStyleBackColor = true;
            this.back_stdnt_btn.Click += new System.EventHandler(this.back_stdnt_btn_Click);
            // 
            // result_btn
            // 
            this.result_btn.Location = new System.Drawing.Point(156, 314);
            this.result_btn.Name = "result_btn";
            this.result_btn.Size = new System.Drawing.Size(157, 23);
            this.result_btn.TabIndex = 7;
            this.result_btn.Text = "Show Student Result";
            this.result_btn.UseVisualStyleBackColor = true;
            this.result_btn.Click += new System.EventHandler(this.result_btn_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 362);
            this.Controls.Add(this.result_btn);
            this.Controls.Add(this.back_stdnt_btn);
            this.Controls.Add(this.show_student_attend_btn);
            this.Controls.Add(this.add_student_attend_btn);
            this.Controls.Add(this.show_sudent_pay_btn);
            this.Controls.Add(this.show_student_info_btn);
            this.Controls.Add(this.insert_student_btn);
            this.Controls.Add(this.label1);
            this.Name = "Student";
            this.Text = "Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insert_student_btn;
        private System.Windows.Forms.Button show_student_info_btn;
        private System.Windows.Forms.Button show_sudent_pay_btn;
        private System.Windows.Forms.Button add_student_attend_btn;
        private System.Windows.Forms.Button show_student_attend_btn;
        private System.Windows.Forms.Button back_stdnt_btn;
        private System.Windows.Forms.Button result_btn;
    }
}