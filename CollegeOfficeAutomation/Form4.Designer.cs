namespace CollegeOfficeAutomation
{
    partial class add_student_attendance
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
            this.stdnt_id_txt = new System.Windows.Forms.TextBox();
            this.stdnt_attendance_btn = new System.Windows.Forms.Button();
            this.add_stdnt_att_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // stdnt_id_txt
            // 
            this.stdnt_id_txt.Location = new System.Drawing.Point(130, 40);
            this.stdnt_id_txt.Name = "stdnt_id_txt";
            this.stdnt_id_txt.Size = new System.Drawing.Size(155, 20);
            this.stdnt_id_txt.TabIndex = 1;
            // 
            // stdnt_attendance_btn
            // 
            this.stdnt_attendance_btn.Location = new System.Drawing.Point(130, 106);
            this.stdnt_attendance_btn.Name = "stdnt_attendance_btn";
            this.stdnt_attendance_btn.Size = new System.Drawing.Size(155, 23);
            this.stdnt_attendance_btn.TabIndex = 2;
            this.stdnt_attendance_btn.Text = "Add Attendance";
            this.stdnt_attendance_btn.UseVisualStyleBackColor = true;
            // 
            // add_stdnt_att_btn
            // 
            this.add_stdnt_att_btn.Location = new System.Drawing.Point(369, 106);
            this.add_stdnt_att_btn.Name = "add_stdnt_att_btn";
            this.add_stdnt_att_btn.Size = new System.Drawing.Size(75, 23);
            this.add_stdnt_att_btn.TabIndex = 3;
            this.add_stdnt_att_btn.Text = "Back";
            this.add_stdnt_att_btn.UseVisualStyleBackColor = true;
            this.add_stdnt_att_btn.Click += new System.EventHandler(this.add_stdnt_att_btn_Click);
            // 
            // add_student_attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 262);
            this.Controls.Add(this.add_stdnt_att_btn);
            this.Controls.Add(this.stdnt_attendance_btn);
            this.Controls.Add(this.stdnt_id_txt);
            this.Controls.Add(this.label1);
            this.Name = "add_student_attendance";
            this.Text = "Add Attendance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stdnt_id_txt;
        private System.Windows.Forms.Button stdnt_attendance_btn;
        private System.Windows.Forms.Button add_stdnt_att_btn;
    }
}