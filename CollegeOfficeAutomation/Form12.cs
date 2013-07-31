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
    public partial class show_staff_info : Form
    {
        public show_staff_info()
        {
            InitializeComponent();
        }

        private void staff_info_back_btn_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
            this.Hide();
        }
    }
}
