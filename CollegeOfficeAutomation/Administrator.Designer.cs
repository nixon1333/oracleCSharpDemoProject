namespace CollegeOfficeAutomation
{
    partial class Administrator
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
            this.stdnt_btn = new System.Windows.Forms.Button();
            this.teacher_btn = new System.Windows.Forms.Button();
            this.staff_btn = new System.Windows.Forms.Button();
            this.log_out_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click Below Option ";
            // 
            // stdnt_btn
            // 
            this.stdnt_btn.Location = new System.Drawing.Point(146, 99);
            this.stdnt_btn.Name = "stdnt_btn";
            this.stdnt_btn.Size = new System.Drawing.Size(192, 23);
            this.stdnt_btn.TabIndex = 1;
            this.stdnt_btn.Text = "Student";
            this.stdnt_btn.UseVisualStyleBackColor = true;
            this.stdnt_btn.Click += new System.EventHandler(this.stdnt_btn_Click);
            // 
            // teacher_btn
            // 
            this.teacher_btn.Location = new System.Drawing.Point(146, 157);
            this.teacher_btn.Name = "teacher_btn";
            this.teacher_btn.Size = new System.Drawing.Size(192, 23);
            this.teacher_btn.TabIndex = 2;
            this.teacher_btn.Text = "Teacher";
            this.teacher_btn.UseVisualStyleBackColor = true;
            this.teacher_btn.Click += new System.EventHandler(this.teacher_btn_Click);
            // 
            // staff_btn
            // 
            this.staff_btn.Location = new System.Drawing.Point(146, 214);
            this.staff_btn.Name = "staff_btn";
            this.staff_btn.Size = new System.Drawing.Size(192, 23);
            this.staff_btn.TabIndex = 3;
            this.staff_btn.Text = "Staff";
            this.staff_btn.UseVisualStyleBackColor = true;
            this.staff_btn.Click += new System.EventHandler(this.staff_btn_Click);
            // 
            // log_out_btn
            // 
            this.log_out_btn.Location = new System.Drawing.Point(463, 319);
            this.log_out_btn.Name = "log_out_btn";
            this.log_out_btn.Size = new System.Drawing.Size(75, 23);
            this.log_out_btn.TabIndex = 4;
            this.log_out_btn.Text = "Log Out";
            this.log_out_btn.UseVisualStyleBackColor = true;
            this.log_out_btn.Click += new System.EventHandler(this.log_out_btn_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 354);
            this.Controls.Add(this.log_out_btn);
            this.Controls.Add(this.staff_btn);
            this.Controls.Add(this.teacher_btn);
            this.Controls.Add(this.stdnt_btn);
            this.Controls.Add(this.label1);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stdnt_btn;
        private System.Windows.Forms.Button teacher_btn;
        private System.Windows.Forms.Button staff_btn;
        private System.Windows.Forms.Button log_out_btn;
    }
}