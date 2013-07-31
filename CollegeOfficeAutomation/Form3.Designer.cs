namespace CollegeOfficeAutomation
{
    partial class show_student_payment_info
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
            this.stdnt_payment_dataGridView = new System.Windows.Forms.DataGridView();
            this.stdnt_payment_info_btn = new System.Windows.Forms.Button();
            this.stdnt_pay_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stdnt_payment_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stdnt_payment_dataGridView
            // 
            this.stdnt_payment_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stdnt_payment_dataGridView.Location = new System.Drawing.Point(71, 104);
            this.stdnt_payment_dataGridView.Name = "stdnt_payment_dataGridView";
            this.stdnt_payment_dataGridView.Size = new System.Drawing.Size(543, 255);
            this.stdnt_payment_dataGridView.TabIndex = 0;
            // 
            // stdnt_payment_info_btn
            // 
            this.stdnt_payment_info_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stdnt_payment_info_btn.Location = new System.Drawing.Point(102, 29);
            this.stdnt_payment_info_btn.Name = "stdnt_payment_info_btn";
            this.stdnt_payment_info_btn.Size = new System.Drawing.Size(421, 23);
            this.stdnt_payment_info_btn.TabIndex = 1;
            this.stdnt_payment_info_btn.Text = "Click To See Student Payment Information";
            this.stdnt_payment_info_btn.UseVisualStyleBackColor = false;
            this.stdnt_payment_info_btn.Click += new System.EventHandler(this.stdnt_payment_info_btn_Click);
            // 
            // stdnt_pay_btn
            // 
            this.stdnt_pay_btn.Location = new System.Drawing.Point(601, 29);
            this.stdnt_pay_btn.Name = "stdnt_pay_btn";
            this.stdnt_pay_btn.Size = new System.Drawing.Size(75, 23);
            this.stdnt_pay_btn.TabIndex = 2;
            this.stdnt_pay_btn.Text = "Back";
            this.stdnt_pay_btn.UseVisualStyleBackColor = true;
            this.stdnt_pay_btn.Click += new System.EventHandler(this.stdnt_pay_btn_Click);
            // 
            // show_student_payment_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 407);
            this.Controls.Add(this.stdnt_pay_btn);
            this.Controls.Add(this.stdnt_payment_info_btn);
            this.Controls.Add(this.stdnt_payment_dataGridView);
            this.Name = "show_student_payment_info";
            this.Text = "Student Payment Information";
            ((System.ComponentModel.ISupportInitialize)(this.stdnt_payment_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView stdnt_payment_dataGridView;
        private System.Windows.Forms.Button stdnt_payment_info_btn;
        private System.Windows.Forms.Button stdnt_pay_btn;
    }
}