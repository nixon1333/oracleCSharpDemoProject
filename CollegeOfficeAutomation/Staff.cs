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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void back_staff_btn_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator();
            admin.Show();
            this.Hide();
        }

        private void insert_staff_btn_Click(object sender, EventArgs e)
        {
            insert_staff_info inf = new insert_staff_info();
            inf.Show();
            this.Hide();
        }

        private void staff_info_btn_Click(object sender, EventArgs e)
        {
            show_staff_info inf = new show_staff_info();
            inf.Show();
            this.Hide();
        }

        private void staff_salary_btn_Click(object sender, EventArgs e)
        {
            staff_salary sal = new staff_salary();
            sal.Show();
            this.Hide();
        }

        private void add_staff_attendance_btn_Click(object sender, EventArgs e)
        {
            add_staff_attendance att2 = new add_staff_attendance();
            att2.Show();
            this.Hide();
        }

        private void show_staff_attendance_btn_Click(object sender, EventArgs e)
        {
            show_staff_attendance att3 = new show_staff_attendance();
            att3.Show();
            this.Hide();
        }
    }
}
