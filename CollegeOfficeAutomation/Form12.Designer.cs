namespace CollegeOfficeAutomation
{
    partial class show_staff_info
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
            this.staff_info_btn = new System.Windows.Forms.Button();
            this.staff_info_dataGridView = new System.Windows.Forms.DataGridView();
            this.staff_info_back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.staff_info_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // staff_info_btn
            // 
            this.staff_info_btn.Location = new System.Drawing.Point(89, 35);
            this.staff_info_btn.Name = "staff_info_btn";
            this.staff_info_btn.Size = new System.Drawing.Size(346, 23);
            this.staff_info_btn.TabIndex = 0;
            this.staff_info_btn.Text = "Click to See Staff Information";
            this.staff_info_btn.UseVisualStyleBackColor = true;
            // 
            // staff_info_dataGridView
            // 
            this.staff_info_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staff_info_dataGridView.Location = new System.Drawing.Point(53, 96);
            this.staff_info_dataGridView.Name = "staff_info_dataGridView";
            this.staff_info_dataGridView.Size = new System.Drawing.Size(526, 150);
            this.staff_info_dataGridView.TabIndex = 1;
            // 
            // staff_info_back_btn
            // 
            this.staff_info_back_btn.Location = new System.Drawing.Point(537, 35);
            this.staff_info_back_btn.Name = "staff_info_back_btn";
            this.staff_info_back_btn.Size = new System.Drawing.Size(75, 23);
            this.staff_info_back_btn.TabIndex = 2;
            this.staff_info_back_btn.Text = "Back";
            this.staff_info_back_btn.UseVisualStyleBackColor = true;
            this.staff_info_back_btn.Click += new System.EventHandler(this.staff_info_back_btn_Click);
            // 
            // show_staff_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 374);
            this.Controls.Add(this.staff_info_back_btn);
            this.Controls.Add(this.staff_info_dataGridView);
            this.Controls.Add(this.staff_info_btn);
            this.Name = "show_staff_info";
            this.Text = "Show Insert Information";
            ((System.ComponentModel.ISupportInitialize)(this.staff_info_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button staff_info_btn;
        private System.Windows.Forms.DataGridView staff_info_dataGridView;
        private System.Windows.Forms.Button staff_info_back_btn;
    }
}