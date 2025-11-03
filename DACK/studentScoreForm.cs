using DACKW.Teacher;
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
    public partial class studentScoreForm : Form
    {
        public string course_id;
        MY_DB mydb = new MY_DB();
        STUDENT student = new STUDENT();
        public studentScoreForm()
        {
            InitializeComponent();
        }
        TeacherForm teacherForm;
        CourseTeacherBtn courseTeacherBtn;
        public studentScoreForm(TeacherForm teacherForm, CourseTeacherBtn courseTeacherBtn)
        {
            InitializeComponent();
            this.teacherForm = teacherForm;
            this.courseTeacherBtn = courseTeacherBtn;
        }
        private void studentScoreForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select StudentID,FirstName,LastName from student inner join Score on student.StudentID=Score.Student_id where Course_id=@cid", mydb.getConnection);
            cmd.Parameters.AddWithValue("@cid", course_id);
            DataTable dt = student.getStudent(cmd);
            dt.Columns.Add("AvgScore");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["AvgScore"] = DTB(Convert.ToInt32(dt.Rows[i][0]), course_id);
            }
            guna2DataGridView1.DataSource = dt;
        }
        public decimal DTB(int studentID, string courseID)
        {
            SqlCommand cmd = new SqlCommand("select * from Submission inner join Assignment on Submission.AssignmentID=Assignment.ID where StudentID = @sid and CourseID=@cid", mydb.getConnection);
            cmd.Parameters.AddWithValue("@sid", studentID);
            cmd.Parameters.AddWithValue("@cid", courseID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            mydb.openConnection();
            adapter.Fill(dt);
            mydb.closeConnection();
            decimal DTB = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTB += Convert.ToDecimal(dt.Rows[i][5]);
            }
            if (dt.Rows.Count > 0)
                DTB /= dt.Rows.Count;
            else DTB = 0;
            return DTB;
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            
                teacherForm.OpenForm(courseTeacherBtn, this, teacherForm);
            
        }
    }
}
