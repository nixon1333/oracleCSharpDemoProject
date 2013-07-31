using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CollegeOfficeAutomation
{
    public partial class add_teacher_attendance : Form
    {
        public add_teacher_attendance()
        {
            InitializeComponent();
        }

        private void add_teach_att_back_btn_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.Show();
            this.Hide();
        }
    }
}
