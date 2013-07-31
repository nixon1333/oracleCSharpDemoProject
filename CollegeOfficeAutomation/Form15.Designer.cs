namespace CollegeOfficeAutomation
{
    partial class show_staff_attendance
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
            this.show_staff_attendance_btn = new System.Windows.Forms.Button();
            this.staff_attendance_dataGridView = new System.Windows.Forms.DataGridView();
            this.show_staff_att_back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.staff_attendance_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // show_staff_attendance_btn
            // 
            this.show_staff_attendance_btn.Location = new System.Drawing.Point(140, 34);
            this.show_staff_attendance_btn.Name = "show_staff_attendance_btn";
            this.show_staff_attendance_btn.Size = new System.Drawing.Size(218, 23);
            this.show_staff_attendance_btn.TabIndex = 0;
            this.show_staff_attendance_btn.Text = "Click to See Staff Attendance";
            this.show_staff_attendance_btn.UseVisualStyleBackColor = true;
            // 
            // staff_attendance_dataGridView
            // 
            this.staff_attendance_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staff_attendance_dataGridView.Location = new System.Drawing.Point(77, 104);
            this.staff_attendance_dataGridView.Name = "staff_attendance_dataGridView";
            this.staff_attendance_dataGridView.Size = new System.Drawing.Size(340, 150);
            this.staff_attendance_dataGridView.TabIndex = 1;
            // 
            // show_staff_att_back_btn
            // 
            this.show_staff_att_back_btn.Location = new System.Drawing.Point(445, 33);
            this.show_staff_att_back_btn.Name = "show_staff_att_back_btn";
            this.show_staff_att_back_btn.Size = new System.Drawing.Size(75, 23);
            this.show_staff_att_back_btn.TabIndex = 2;
            this.show_staff_att_back_btn.Text = "Back";
            this.show_staff_att_back_btn.UseVisualStyleBackColor = true;
            this.show_staff_att_back_btn.Click += new System.EventHandler(this.show_staff_att_back_btn_Click);
            // 
            // show_staff_attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 356);
            this.Controls.Add(this.show_staff_att_back_btn);
            this.Controls.Add(this.staff_attendance_dataGridView);
            this.Controls.Add(this.show_staff_attendance_btn);
            this.Name = "show_staff_attendance";
            this.Text = "Show Staff Attendance";
            this.Load += new System.EventHandler(this.show_staff_attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staff_attendance_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button show_staff_attendance_btn;
        private System.Windows.Forms.DataGridView staff_attendance_dataGridView;
        private System.Windows.Forms.Button show_staff_att_back_btn;
    }
}