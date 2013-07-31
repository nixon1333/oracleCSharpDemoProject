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
    public partial class staff_salary : Form
    {
        public staff_salary()
        {
            InitializeComponent();
        }

        private void staff_salary_Load(object sender, EventArgs e)
        {

        }

        private void staff_salary_btn_back_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
            this.Hide();
        }
    }
}
