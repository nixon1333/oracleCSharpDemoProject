namespace CollegeOfficeAutomation
{
    partial class staff_salary
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
            this.staff_salary_btn_back = new System.Windows.Forms.Button();
            this.staff_salary_btn = new System.Windows.Forms.Button();
            this.staff_salary_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.staff_salary_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // staff_salary_btn_back
            // 
            this.staff_salary_btn_back.Location = new System.Drawing.Point(473, 28);
            this.staff_salary_btn_back.Name = "staff_salary_btn_back";
            this.staff_salary_btn_back.Size = new System.Drawing.Size(75, 23);
            this.staff_salary_btn_back.TabIndex = 0;
            this.staff_salary_btn_back.Text = "Back";
            this.staff_salary_btn_back.UseVisualStyleBackColor = true;
            this.staff_salary_btn_back.Click += new System.EventHandler(this.staff_salary_btn_back_Click);
            // 
            // staff_salary_btn
            // 
            this.staff_salary_btn.Location = new System.Drawing.Point(109, 27);
            this.staff_salary_btn.Name = "staff_salary_btn";
            this.staff_salary_btn.Size = new System.Drawing.Size(232, 23);
            this.staff_salary_btn.TabIndex = 1;
            this.staff_salary_btn.Text = "Click to See Staff Salary";
            this.staff_salary_btn.UseVisualStyleBackColor = true;
            // 
            // staff_salary_dataGridView
            // 
            this.staff_salary_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staff_salary_dataGridView.Location = new System.Drawing.Point(109, 103);
            this.staff_salary_dataGridView.Name = "staff_salary_dataGridView";
            this.staff_salary_dataGridView.Size = new System.Drawing.Size(240, 150);
            this.staff_salary_dataGridView.TabIndex = 2;
            // 
            // staff_salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 347);
            this.Controls.Add(this.staff_salary_dataGridView);
            this.Controls.Add(this.staff_salary_btn);
            this.Controls.Add(this.staff_salary_btn_back);
            this.Name = "staff_salary";
            this.Text = "Staff Salary";
            this.Load += new System.EventHandler(this.staff_salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staff_salary_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button staff_salary_btn_back;
        private System.Windows.Forms.Button staff_salary_btn;
        private System.Windows.Forms.DataGridView staff_salary_dataGridView;
    }
}