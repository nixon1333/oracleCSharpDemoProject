﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CollegeOfficeAutomation
{
    public partial class insert_teacher_info : Form
    {
        public insert_teacher_info()
        {
            InitializeComponent();
        }

        private void teach_back_btn_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.Show();
            this.Hide();
        }
    }
}
