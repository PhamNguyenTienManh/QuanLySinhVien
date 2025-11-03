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
    public partial class AccessCourseForm : Form
    {
        FormNopBai formNopBai = new FormNopBai();
        public string courseID;
        public string courseName;
        MY_DB mydb = new MY_DB();
        public AccessCourseForm()
        {
            InitializeComponent();
        }

        StudentMainForm studentMainForm;
        CourseForm courseForm;
        public AccessCourseForm(StudentMainForm studentMainForm)
        {
            InitializeComponent();
            this.studentMainForm = studentMainForm;
        }
        public AccessCourseForm(StudentMainForm studentMainForm,CourseForm courseForm )
        {
            InitializeComponent();
            this.studentMainForm = studentMainForm;
            this.courseForm = courseForm;
        }

        private void ClearUserControl()
        {
            for (int i = flowLayoutPanel1.Controls.Count - 1; i >= 0; i--)
            {
                // Kiểm tra xem control có phải là UserControl không
                if (flowLayoutPanel1.Controls[i] is UserControl userControl)
                {
                    // Nếu là UserControl, xóa nó khỏi panel
                    flowLayoutPanel1.Controls.RemoveAt(i);
                    userControl.Dispose(); // Giải phóng tài nguyên của UserControl
                }
            }
        }

        public void AccessCourseForm_Load(object sender, EventArgs e)
        {
            ClearUserControl();
            //SqlCommand cmd = new SqlCommand("select * from (select ID,AssignmentName, Assignment.Description,CourseID,Deadline,Path from Score inner join Assignment on Score.course_id = Assignment.CourseID where Student_id = @sid and Course_id=@cid) Q  left outer join Submission on Submission.AssignmentID=Q.ID", mydb.getConnection);
            SqlCommand cmd = new SqlCommand("select * from ((select * from Assignment where CourseID = @cid) P left outer join ( select * from submission where Studentid = @sid) Q on P.ID = Q.AssignmentID)", mydb.getConnection);
            cmd.Parameters.AddWithValue("@sid",Globals.GlobaUserID);
            cmd.Parameters.AddWithValue("@cid", courseID );
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            mydb.openConnection();
            adapter.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{

            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        UserControlAssignment userControlAssignment = new UserControlAssignment(studentMainForm, this);
            //        userControlAssignment.label5.Text = dt.Rows[i][1].ToString();
            //        userControlAssignment.richTextBox1.Text = dt.Rows[i][2].ToString();
            //        userControlAssignment.guna2DateTimePicker1.Value = (DateTime)dt.Rows[i][4];
            //        userControlAssignment.Margin = new Padding(15, 15, 15, 15);
            //        userControlAssignment.textBox2.Text = dt.Rows[i][5].ToString();
            //        userControlAssignment.textBoxSubmitted.Text = dt.Rows[i][9].ToString();
            //        if (userControlAssignment.guna2DateTimePicker1.Value < DateTime.Now)
            //            userControlAssignment.guna2ButtonSubmit.Visible = false;
            //        flowLayoutPanel1.Controls.Add(userControlAssignment);
            //    }
            //}
            if (dt.Rows.Count > 0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    UserControlAssignment userControlAssignment = new UserControlAssignment(studentMainForm, this);
                    userControlAssignment.label5.Text = dt.Rows[i][2].ToString();
                    userControlAssignment.richTextBox1.Text = dt.Rows[i][3].ToString();
                    userControlAssignment.guna2DateTimePicker1.Value = (DateTime)dt.Rows[i][5];
                    userControlAssignment.Margin = new Padding(15, 15, 15, 15);
                    userControlAssignment.textBox2.Text = dt.Rows[i][4].ToString();
                    userControlAssignment.textBoxSubmitted.Text = dt.Rows[i][9].ToString();
                    if (userControlAssignment.guna2DateTimePicker1.Value < DateTime.Now)
                        userControlAssignment.guna2ButtonSubmit.Visible = false;
                    flowLayoutPanel1.Controls.Add(userControlAssignment);
                }
            }
        }

        private void buttonForum_Click(object sender, EventArgs e)
        {
            ForumForm forumForm = new ForumForm(studentMainForm, this);
            forumForm.lblCourseID.Text = courseID;
            forumForm.lblCoursename.Text = courseName;
            forumForm.courseID = courseID;
            studentMainForm.OpenForm(forumForm,this, studentMainForm);
          
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {           
            studentMainForm.OpenForm (courseForm,this, studentMainForm); 
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonScore_Click(object sender, EventArgs e)
        {
            StudentCourseScoreForm studentCourseScoreForm = new StudentCourseScoreForm(studentMainForm, this);
            studentCourseScoreForm.labelCourseIdAndName.Text = labelCourseIdAndName.Text;
            studentCourseScoreForm.label2.Text = label2.Text;
            studentCourseScoreForm.courseID = courseID;
            studentMainForm.OpenForm(studentCourseScoreForm, this, studentMainForm);
            //studentCourseScoreForm.Show();
        }
    }
}
