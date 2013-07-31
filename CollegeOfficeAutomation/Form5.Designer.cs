namespace CollegeOfficeAutomation
{
    partial class show_stdnt_attendance_info
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
            this.stdnt_attendance_dataGridView = new System.Windows.Forms.DataGridView();
            this.stdnt_atendance_info_btn = new System.Windows.Forms.Button();
            this.stdnt_att_back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stdnt_attendance_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stdnt_attendance_dataGridView
            // 
            this.stdnt_attendance_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stdnt_attendance_dataGridView.Location = new System.Drawing.Point(63, 110);
            this.stdnt_attendance_dataGridView.Name = "stdnt_attendance_dataGridView";
            this.stdnt_attendance_dataGridView.Size = new System.Drawing.Size(369, 221);
            this.stdnt_attendance_dataGridView.TabIndex = 1;
            // 
            // stdnt_atendance_info_btn
            // 
            this.stdnt_atendance_info_btn.Location = new System.Drawing.Point(63, 28);
            this.stdnt_atendance_info_btn.Name = "stdnt_atendance_info_btn";
            this.stdnt_atendance_info_btn.Size = new System.Drawing.Size(244, 23);
            this.stdnt_atendance_info_btn.TabIndex = 2;
            this.stdnt_atendance_info_btn.Text = "Click To See Student Attendance Information";
            this.stdnt_atendance_info_btn.UseVisualStyleBackColor = true;
            this.stdnt_atendance_info_btn.Click += new System.EventHandler(this.stdnt_atendance_info_btn_Click);
            // 
            // stdnt_att_back_btn
            // 
            this.stdnt_att_back_btn.Location = new System.Drawing.Point(357, 28);
            this.stdnt_att_back_btn.Name = "stdnt_att_back_btn";
            this.stdnt_att_back_btn.Size = new System.Drawing.Size(75, 23);
            this.stdnt_att_back_btn.TabIndex = 3;
            this.stdnt_att_back_btn.Text = "Back";
            this.stdnt_att_back_btn.UseVisualStyleBackColor = true;
            this.stdnt_att_back_btn.Click += new System.EventHandler(this.stdnt_att_back_btn_Click);
            // 
            // show_stdnt_attendance_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 362);
            this.Controls.Add(this.stdnt_att_back_btn);
            this.Controls.Add(this.stdnt_atendance_info_btn);
            this.Controls.Add(this.stdnt_attendance_dataGridView);
            this.Name = "show_stdnt_attendance_info";
            this.Text = "Attendance Information";
            this.Load += new System.EventHandler(this.attendanceinfobtn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stdnt_attendance_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView stdnt_attendance_dataGridView;
        private System.Windows.Forms.Button stdnt_atendance_info_btn;
        private System.Windows.Forms.Button stdnt_att_back_btn;
    }
}