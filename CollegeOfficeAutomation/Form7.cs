using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OracleClient;

namespace CollegeOfficeAutomation
{
    public partial class show_teacher_info : Form
    {
        public show_teacher_info()
        {
            InitializeComponent();
        }

        private void show_teach_info_back_btn_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.Show();
            this.Hide();
        }

        private void show_teacher_info_btn_Click(object sender, EventArgs e)
        {
            dbConnect conObj = new dbConnect();
            OracleConnection conn = conObj.connFunc();
            OracleParameter parOut = new OracleParameter();



            parOut.ParameterName = "res_cur";
            parOut.OracleType = OracleType.Cursor;
            parOut.Size = 32;
            parOut.Direction = System.Data.ParameterDirection.Output;

            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "teacher_info_procedure";
            cmd.Parameters.Add(parOut);


            conn.Open();

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet myset = new DataSet("res_cur");
            adapter.Fill(myset);
            teacher_info_dataGridView.DataSource = myset;
            teacher_info_dataGridView.DataSource = myset.Tables[0];

            conn.Close();
        }
    }
}
