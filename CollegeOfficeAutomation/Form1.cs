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
    public partial class insert_stdnt_info : Form
    {
        public insert_stdnt_info()
        {
            InitializeComponent();
        }

        private void stdnt_info_back_btn_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
            this.Hide();
        }
    }
}
