using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACKW
{
    public partial class FormListSV : Form
    {
        MY_DB mydb = new MY_DB();
        STUDENT student = new STUDENT();
        string query = "";
        public FormListSV()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormListSV_Load(object sender, EventArgs e)
        {
            guna2CustomRadioButtonAll.Checked = true;
            
            if(guna2CustomRadioButtonAll.Checked== true)
            {
                query = "select * from student";
                SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
                guna2DataGridView1.DataSource = student.getStudent(cmd);
            }    
              
        }

        private void guna2CustomRadioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            
                query = "select * from student";
                SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
                guna2DataGridView1.DataSource = student.getStudent(cmd);
            
        }

        private void guna2CustomRadioButtonSubmitted_CheckedChanged(object sender, EventArgs e)
        {
            query = " select * from student where StudentID in (select StudentID from Submission)";
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            guna2DataGridView1.DataSource = student.getStudent(cmd);
        }

        private void guna2CustomRadioButtonNotsubmitted_CheckedChanged(object sender, EventArgs e)
        {
            query = " select * from student where StudentID not in (select StudentID from Submission)";
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            guna2DataGridView1.DataSource = student.getStudent(cmd);
        }
    }
}
