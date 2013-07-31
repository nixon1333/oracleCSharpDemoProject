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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void back_stdnt_btn_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator();
            admin.Show();
            this.Hide();
        }

        private void insert_student_btn_Click(object sender, EventArgs e)
        {
            insert_stdnt_info student_info = new insert_stdnt_info();
            student_info.Show();
            this.Hide();
        }

        private void show_student_info_btn_Click(object sender, EventArgs e)
        {
            show_stdnt_info info = new show_stdnt_info();
            info.Show();
            this.Hide();
        }

        private void show_sudent_pay_btn_Click(object sender, EventArgs e)
        {
            show_student_payment_info pay = new show_student_payment_info();
            pay.Show();
            this.Hide();
        }

        private void add_student_attend_btn_Click(object sender, EventArgs e)
        {
            add_student_attendance add = new add_student_attendance();
            add.Show();
            this.Hide();
        }

        private void show_student_attend_btn_Click(object sender, EventArgs e)
        {
            show_stdnt_attendance_info info = new show_stdnt_attendance_info();
            info.Show();
            this.Hide();
        }

        private void result_btn_Click(object sender, EventArgs e)
        {
            Student_Result result = new Student_Result();
            result.Show();
            this.Hide();
        }

    }
}
