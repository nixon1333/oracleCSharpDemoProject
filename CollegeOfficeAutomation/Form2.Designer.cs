namespace CollegeOfficeAutomation
{
    partial class show_stdnt_info
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
            this.show_stdnt_info_btn = new System.Windows.Forms.Button();
            this.stdnt_dataGridView = new System.Windows.Forms.DataGridView();
            this.show_info_back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stdnt_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // show_stdnt_info_btn
            // 
            this.show_stdnt_info_btn.Location = new System.Drawing.Point(56, 37);
            this.show_stdnt_info_btn.Name = "show_stdnt_info_btn";
            this.show_stdnt_info_btn.Size = new System.Drawing.Size(252, 23);
            this.show_stdnt_info_btn.TabIndex = 0;
            this.show_stdnt_info_btn.Text = "Click To See Student Information";
            this.show_stdnt_info_btn.UseVisualStyleBackColor = true;
            this.show_stdnt_info_btn.Click += new System.EventHandler(this.show_stdnt_info_btn_Click);
            // 
            // stdnt_dataGridView
            // 
            this.stdnt_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stdnt_dataGridView.Location = new System.Drawing.Point(12, 79);
            this.stdnt_dataGridView.Name = "stdnt_dataGridView";
            this.stdnt_dataGridView.Size = new System.Drawing.Size(741, 298);
            this.stdnt_dataGridView.TabIndex = 1;
            this.stdnt_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stdnt_dataGridView_CellContentClick);
            // 
            // show_info_back_btn
            // 
            this.show_info_back_btn.Location = new System.Drawing.Point(628, 37);
            this.show_info_back_btn.Name = "show_info_back_btn";
            this.show_info_back_btn.Size = new System.Drawing.Size(75, 23);
            this.show_info_back_btn.TabIndex = 2;
            this.show_info_back_btn.Text = "Back";
            this.show_info_back_btn.UseVisualStyleBackColor = true;
            this.show_info_back_btn.Click += new System.EventHandler(this.show_info_back_btn_Click);
            // 
            // show_stdnt_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 406);
            this.Controls.Add(this.show_info_back_btn);
            this.Controls.Add(this.stdnt_dataGridView);
            this.Controls.Add(this.show_stdnt_info_btn);
            this.Name = "show_stdnt_info";
            this.Text = "Show Student Information";
            this.Load += new System.EventHandler(this.showinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stdnt_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button show_stdnt_info_btn;
        private System.Windows.Forms.DataGridView stdnt_dataGridView;
        private System.Windows.Forms.Button show_info_back_btn;
    }
}