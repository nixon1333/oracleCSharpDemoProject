namespace CollegeOfficeAutomation
{
    partial class add_teacher_attendance
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
            this.teacher_id_txt = new System.Windows.Forms.TextBox();
            this.add_teacher_attendace_btn = new System.Windows.Forms.Button();
            this.add_teach_att_back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher ID";
            // 
            // teacher_id_txt
            // 
            this.teacher_id_txt.Location = new System.Drawing.Point(159, 48);
            this.teacher_id_txt.Name = "teacher_id_txt";
            this.teacher_id_txt.Size = new System.Drawing.Size(100, 20);
            this.teacher_id_txt.TabIndex = 1;
            // 
            // add_teacher_attendace_btn
            // 
            this.add_teacher_attendace_btn.Location = new System.Drawing.Point(139, 121);
            this.add_teacher_attendace_btn.Name = "add_teacher_attendace_btn";
            this.add_teacher_attendace_btn.Size = new System.Drawing.Size(210, 23);
            this.add_teacher_attendace_btn.TabIndex = 2;
            this.add_teacher_attendace_btn.Text = "Add Attendance";
            this.add_teacher_attendace_btn.UseVisualStyleBackColor = true;
            // 
            // add_teach_att_back_btn
            // 
            this.add_teach_att_back_btn.Location = new System.Drawing.Point(427, 120);
            this.add_teach_att_back_btn.Name = "add_teach_att_back_btn";
            this.add_teach_att_back_btn.Size = new System.Drawing.Size(75, 23);
            this.add_teach_att_back_btn.TabIndex = 3;
            this.add_teach_att_back_btn.Text = "Back";
            this.add_teach_att_back_btn.UseVisualStyleBackColor = true;
            this.add_teach_att_back_btn.Click += new System.EventHandler(this.add_teach_att_back_btn_Click);
            // 
            // add_teacher_attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 262);
            this.Controls.Add(this.add_teach_att_back_btn);
            this.Controls.Add(this.add_teacher_attendace_btn);
            this.Controls.Add(this.teacher_id_txt);
            this.Controls.Add(this.label1);
            this.Name = "add_teacher_attendance";
            this.Text = "Add Teacher Attendance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teacher_id_txt;
        private System.Windows.Forms.Button add_teacher_attendace_btn;
        private System.Windows.Forms.Button add_teach_att_back_btn;
    }
}