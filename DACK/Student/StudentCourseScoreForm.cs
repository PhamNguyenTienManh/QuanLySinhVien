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

namespace DACKW.Student
{
    public partial class StudentCourseScoreForm : Form
    {
        MY_DB mydb = new MY_DB();
        float DTB = 0;
        public string courseID;
        public StudentCourseScoreForm()
        {
            InitializeComponent();
        }
        StudentMainForm studentMainForm = new StudentMainForm();
        AccessCourseForm accessCourseForm;
        public StudentCourseScoreForm(StudentMainForm studentMainForm, AccessCourseForm accessCourseForm)
        {
            InitializeComponent();
            this.studentMainForm = studentMainForm;
            this.accessCourseForm = accessCourseForm;
        }

        private void StudentCourseScoreForm_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.ColumnHeadersHeight = 20;
            SqlCommand cmd = new SqlCommand(" select AssignmentName, Grade , Feedback from (select AssignmentName,CourseID,Grade,Feedback, StudentID from Assignment inner join Submission on Assignment.ID = Submission.AssignmentID) Q inner join Score on Q.CourseID = Score.Course_id where Q.StudentID=@sid and Course_id=@cid", mydb.getConnection);
            cmd.Parameters.AddWithValue("@sid",Globals.GlobaUserID);
            cmd.Parameters.AddWithValue("@cid", courseID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            mydb.openConnection();
            adapter.Fill(dt);
            mydb.closeConnection();
            guna2DataGridView1.DataSource = dt;
            for(int i=0;i<dt.Rows.Count;i++)
            {
                DTB += float.Parse(dt.Rows[i][1].ToString());
            }
            DTB /= dt.Rows.Count;
            labelDTB.Text = DTB.ToString();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            studentMainForm.OpenForm(accessCourseForm, this, studentMainForm);
        }
    }
}
