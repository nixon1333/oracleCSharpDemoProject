namespace CollegeOfficeAutomation
{
    partial class add_staff_attendance
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
            this.staff_id_txt = new System.Windows.Forms.TextBox();
            this.staff_attendance_btn = new System.Windows.Forms.Button();
            this.staff_att_back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff ID";
            // 
            // staff_id_txt
            // 
            this.staff_id_txt.Location = new System.Drawing.Point(165, 44);
            this.staff_id_txt.Name = "staff_id_txt";
            this.staff_id_txt.Size = new System.Drawing.Size(100, 20);
            this.staff_id_txt.TabIndex = 1;
            // 
            // staff_attendance_btn
            // 
            this.staff_attendance_btn.Location = new System.Drawing.Point(146, 127);
            this.staff_attendance_btn.Name = "staff_attendance_btn";
            this.staff_attendance_btn.Size = new System.Drawing.Size(210, 23);
            this.staff_attendance_btn.TabIndex = 2;
            this.staff_attendance_btn.Text = "Add Attendance";
            this.staff_attendance_btn.UseVisualStyleBackColor = true;
            // 
            // staff_att_back_btn
            // 
            this.staff_att_back_btn.Location = new System.Drawing.Point(465, 126);
            this.staff_att_back_btn.Name = "staff_att_back_btn";
            this.staff_att_back_btn.Size = new System.Drawing.Size(75, 23);
            this.staff_att_back_btn.TabIndex = 3;
            this.staff_att_back_btn.Text = "Back";
            this.staff_att_back_btn.UseVisualStyleBackColor = true;
            this.staff_att_back_btn.Click += new System.EventHandler(this.staff_att_back_btn_Click);
            // 
            // add_staff_attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 262);
            this.Controls.Add(this.staff_att_back_btn);
            this.Controls.Add(this.staff_attendance_btn);
            this.Controls.Add(this.staff_id_txt);
            this.Controls.Add(this.label1);
            this.Name = "add_staff_attendance";
            this.Text = "Add Staff Attendance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox staff_id_txt;
        private System.Windows.Forms.Button staff_attendance_btn;
        private System.Windows.Forms.Button staff_att_back_btn;
    }
}