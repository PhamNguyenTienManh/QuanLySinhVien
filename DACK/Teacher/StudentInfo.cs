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

namespace DACKW.Teacher
{
    public partial class StudentInfo : Form
    {
        MY_DB mydb = new MY_DB();
        public string CourseID;
        public int studentid;
        public StudentInfo()
        {
            InitializeComponent();
        }
        TeacherForm teacherForm;
        StudentRegisterCourseForrm studentRegisterCourseForrm;
        public StudentInfo(TeacherForm teacherForm, StudentRegisterCourseForrm studentRegisterCourseForrm)
        {
            InitializeComponent();
            this.teacherForm = teacherForm;
            this.studentRegisterCourseForrm = studentRegisterCourseForrm;
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            studentid = Convert.ToInt32(labelMSSV.Text);
            SqlCommand cmd = new SqlCommand("select * from Submission inner join Assignment on Submission.AssignmentID=Assignment.ID where StudentID = @sid and CourseID = @cid",mydb.getConnection);
            cmd.Parameters.AddWithValue("@sid", Convert.ToInt32(labelMSSV.Text));
            cmd.Parameters.AddWithValue("@cid", CourseID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            mydb.openConnection();
            adapter.Fill(dt);
            mydb.closeConnection();
            for(int i=0;i<dt.Rows.Count;i++)
            {
                UserControlStudentAssignment userControlStudentAssignment = new UserControlStudentAssignment();
                userControlStudentAssignment.guna2TextBoxAssignmentName.Text = dt.Rows[i][9].ToString();
                userControlStudentAssignment.guna2TextBoxFilePath.Text = dt.Rows[i][3].ToString();
                userControlStudentAssignment.guna2DateTimePicker1.Value = (DateTime)dt.Rows[i][12];
                userControlStudentAssignment.guna2DateTimePicker2.Value = (DateTime)dt.Rows[i][4];
                userControlStudentAssignment.guna2TextBoxDiem.Text = dt.Rows[i][5].ToString();
                userControlStudentAssignment.richTextBoxFeedback.Text = dt.Rows[i][6].ToString();
                userControlStudentAssignment.Margin = new Padding(15, 15, 15, 15);
                userControlStudentAssignment.ID = Convert.ToInt32(dt.Rows[i][0].ToString());
                userControlStudentAssignment.student_id = studentid;
                flowLayoutPanel1.Controls.Add(userControlStudentAssignment);
            }    

        }

        private void guna2ButtonTruyCap_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            teacherForm.OpenForm(studentRegisterCourseForrm, this, teacherForm);
        }
    }
}
