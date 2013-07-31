namespace CollegeOfficeAutomation
{
    partial class Student_Result
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
            this.stdnt_result_dataGridView = new System.Windows.Forms.DataGridView();
            this.stdnt_result_back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stdnt_result_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click To See Student Result";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // stdnt_result_dataGridView
            // 
            this.stdnt_result_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stdnt_result_dataGridView.Location = new System.Drawing.Point(109, 67);
            this.stdnt_result_dataGridView.Name = "stdnt_result_dataGridView";
            this.stdnt_result_dataGridView.Size = new System.Drawing.Size(240, 150);
            this.stdnt_result_dataGridView.TabIndex = 1;
            // 
            // stdnt_result_back_btn
            // 
            this.stdnt_result_back_btn.Location = new System.Drawing.Point(463, 24);
            this.stdnt_result_back_btn.Name = "stdnt_result_back_btn";
            this.stdnt_result_back_btn.Size = new System.Drawing.Size(75, 23);
            this.stdnt_result_back_btn.TabIndex = 2;
            this.stdnt_result_back_btn.Text = "Back";
            this.stdnt_result_back_btn.UseVisualStyleBackColor = true;
            this.stdnt_result_back_btn.Click += new System.EventHandler(this.stdnt_result_back_btn_Click);
            // 
            // Student_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 312);
            this.Controls.Add(this.stdnt_result_back_btn);
            this.Controls.Add(this.stdnt_result_dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "Student_Result";
            this.Text = "Student_Result";
            ((System.ComponentModel.ISupportInitialize)(this.stdnt_result_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView stdnt_result_dataGridView;
        private System.Windows.Forms.Button stdnt_result_back_btn;
    }
}