namespace CollegeOfficeAutomation
{
    partial class teacher_salary
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
            this.teach_salary_back_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.teacher_salary_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_salary_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // teach_salary_back_btn
            // 
            this.teach_salary_back_btn.Location = new System.Drawing.Point(405, 22);
            this.teach_salary_back_btn.Name = "teach_salary_back_btn";
            this.teach_salary_back_btn.Size = new System.Drawing.Size(75, 23);
            this.teach_salary_back_btn.TabIndex = 0;
            this.teach_salary_back_btn.Text = "Back";
            this.teach_salary_back_btn.UseVisualStyleBackColor = true;
            this.teach_salary_back_btn.Click += new System.EventHandler(this.teach_salary_back_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click to See Teacher Salary";
            // 
            // teacher_salary_dataGridView
            // 
            this.teacher_salary_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacher_salary_dataGridView.Location = new System.Drawing.Point(96, 107);
            this.teacher_salary_dataGridView.Name = "teacher_salary_dataGridView";
            this.teacher_salary_dataGridView.Size = new System.Drawing.Size(240, 150);
            this.teacher_salary_dataGridView.TabIndex = 2;
            // 
            // teacher_salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 364);
            this.Controls.Add(this.teacher_salary_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teach_salary_back_btn);
            this.Name = "teacher_salary";
            this.Text = "Teacher Salary";
            ((System.ComponentModel.ISupportInitialize)(this.teacher_salary_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button teach_salary_back_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView teacher_salary_dataGridView;
    }
}