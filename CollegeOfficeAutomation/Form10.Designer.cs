namespace CollegeOfficeAutomation
{
    partial class show_teacher_attendance
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
            this.show_teacher_attendance_btn = new System.Windows.Forms.Button();
            this.teacher_attendance_dataGridView = new System.Windows.Forms.DataGridView();
            this.teach_att_back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_attendance_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // show_teacher_attendance_btn
            // 
            this.show_teacher_attendance_btn.Location = new System.Drawing.Point(120, 40);
            this.show_teacher_attendance_btn.Name = "show_teacher_attendance_btn";
            this.show_teacher_attendance_btn.Size = new System.Drawing.Size(281, 23);
            this.show_teacher_attendance_btn.TabIndex = 0;
            this.show_teacher_attendance_btn.Text = "Click To See Teacher Attendance";
            this.show_teacher_attendance_btn.UseVisualStyleBackColor = true;
            // 
            // teacher_attendance_dataGridView
            // 
            this.teacher_attendance_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacher_attendance_dataGridView.Location = new System.Drawing.Point(96, 111);
            this.teacher_attendance_dataGridView.Name = "teacher_attendance_dataGridView";
            this.teacher_attendance_dataGridView.Size = new System.Drawing.Size(343, 150);
            this.teacher_attendance_dataGridView.TabIndex = 1;
            // 
            // teach_att_back_btn
            // 
            this.teach_att_back_btn.Location = new System.Drawing.Point(458, 40);
            this.teach_att_back_btn.Name = "teach_att_back_btn";
            this.teach_att_back_btn.Size = new System.Drawing.Size(75, 23);
            this.teach_att_back_btn.TabIndex = 2;
            this.teach_att_back_btn.Text = "Back";
            this.teach_att_back_btn.UseVisualStyleBackColor = true;
            this.teach_att_back_btn.Click += new System.EventHandler(this.teach_att_back_btn_Click);
            // 
            // show_teacher_attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 372);
            this.Controls.Add(this.teach_att_back_btn);
            this.Controls.Add(this.teacher_attendance_dataGridView);
            this.Controls.Add(this.show_teacher_attendance_btn);
            this.Name = "show_teacher_attendance";
            this.Text = "Show Teacher Attendance";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacher_attendance_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button show_teacher_attendance_btn;
        private System.Windows.Forms.DataGridView teacher_attendance_dataGridView;
        private System.Windows.Forms.Button teach_att_back_btn;
    }
}