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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void back_teacher_btn_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator();
            admin.Show();
            this.Hide();
        }

        private void insert_teacher_btn_Click(object sender, EventArgs e)
        {
            insert_teacher_info info = new insert_teacher_info();
            info.Show();
            this.Hide();
        }

        private void teacher_info_btn_Click(object sender, EventArgs e)
        {
            show_teacher_info info = new show_teacher_info();
            info.Show();
            this.Hide();
        }

        private void teacher_salary_btn_Click(object sender, EventArgs e)
        {
            teacher_salary salary = new teacher_salary();
            salary.Show();
            this.Hide();
        }

        private void add_teacher_attendance_btn_Click(object sender, EventArgs e)
        {
            add_teacher_attendance att = new add_teacher_attendance();
            att.Show();
            this.Hide();
        }

        private void show_teacher_attendance_btn_Click(object sender, EventArgs e)
        {
            show_teacher_attendance att1 = new show_teacher_attendance();
            att1.Show();
            this.Hide();
        }
    }
}
