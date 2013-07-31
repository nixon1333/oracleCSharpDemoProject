namespace CollegeOfficeAutomation
{
    partial class show_teacher_info
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
            this.show_teacher_info_btn = new System.Windows.Forms.Button();
            this.teacher_info_dataGridView = new System.Windows.Forms.DataGridView();
            this.show_teach_info_back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_info_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // show_teacher_info_btn
            // 
            this.show_teacher_info_btn.Location = new System.Drawing.Point(121, 40);
            this.show_teacher_info_btn.Name = "show_teacher_info_btn";
            this.show_teacher_info_btn.Size = new System.Drawing.Size(307, 23);
            this.show_teacher_info_btn.TabIndex = 0;
            this.show_teacher_info_btn.Text = "Click To See Teacher Information";
            this.show_teacher_info_btn.UseVisualStyleBackColor = true;
            this.show_teacher_info_btn.Click += new System.EventHandler(this.show_teacher_info_btn_Click);
            // 
            // teacher_info_dataGridView
            // 
            this.teacher_info_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacher_info_dataGridView.Location = new System.Drawing.Point(12, 90);
            this.teacher_info_dataGridView.Name = "teacher_info_dataGridView";
            this.teacher_info_dataGridView.Size = new System.Drawing.Size(713, 238);
            this.teacher_info_dataGridView.TabIndex = 1;
            // 
            // show_teach_info_back_btn
            // 
            this.show_teach_info_back_btn.Location = new System.Drawing.Point(612, 39);
            this.show_teach_info_back_btn.Name = "show_teach_info_back_btn";
            this.show_teach_info_back_btn.Size = new System.Drawing.Size(75, 23);
            this.show_teach_info_back_btn.TabIndex = 2;
            this.show_teach_info_back_btn.Text = "Back";
            this.show_teach_info_back_btn.UseVisualStyleBackColor = true;
            this.show_teach_info_back_btn.Click += new System.EventHandler(this.show_teach_info_back_btn_Click);
            // 
            // show_teacher_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 395);
            this.Controls.Add(this.show_teach_info_back_btn);
            this.Controls.Add(this.teacher_info_dataGridView);
            this.Controls.Add(this.show_teacher_info_btn);
            this.Name = "show_teacher_info";
            this.Text = "Show Teacher Information";
            ((System.ComponentModel.ISupportInitialize)(this.teacher_info_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button show_teacher_info_btn;
        private System.Windows.Forms.DataGridView teacher_info_dataGridView;
        private System.Windows.Forms.Button show_teach_info_back_btn;
    }
}