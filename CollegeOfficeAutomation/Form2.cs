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
    public partial class show_stdnt_info : Form
    {
        public show_stdnt_info()
        {
            InitializeComponent();
        }

        private void showinfo_Load(object sender, EventArgs e)
        {

        }

        private void show_info_back_btn_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
            this.Hide();
        }

        private void show_stdnt_info_btn_Click(object sender, EventArgs e)
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
            cmd.CommandText = "student_info_procedure";
            cmd.Parameters.Add(parOut);
            

            conn.Open();

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataSet myset = new DataSet("res_cur");
            adapter.Fill(myset);
            stdnt_dataGridView.DataSource = myset;
            stdnt_dataGridView.DataSource = myset.Tables[0];

            conn.Close();
        }

        private void stdnt_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
