using DACKW.admin;
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
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        Course course = new Course();
        StudentMainForm studentMainForm;
        int Check;
        public CourseForm(StudentMainForm studentMainForm, int check)
        {
            InitializeComponent();
            this.studentMainForm = studentMainForm;
            Check= check;
            if (check == 0)
            {
                //SqlCommand cmd = new SqlCommand("Select FirstName, LastName, course_id, course.name, semester " +
                //    "From course inner join ( Select FirstName, LastName, course_id From teacher inner join curriculum On teacher.teacherID = curriculum.teacher_ID) Q " +
                //    "On course.id = Q.course_id " +
                //    "Where course_id in (Select score.Course_id From score Where Student_id = @UserID)", mydb.getConnection);
                //cmd.Parameters.AddWithValue("@UserID", Globals.GlobaUserID);
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //DataTable dt = new DataTable();
                //mydb.openConnection();
                //adapter.Fill(dt);
                //mydb.closeConnection();
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    UserControlCourse userControl = new UserControlCourse();
                //    userControl.labelTeacherName.Text = dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString();
                //    userControl.labelCourseID.Text = dt.Rows[i][2].ToString();
                //    userControl.labelCourseName.Text = dt.Rows[i][3].ToString();
                //    userControl.labelSemester.Text = dt.Rows[i][4].ToString();
                //    // Đặt margin cho UserControl
                //    userControl.Margin = new Padding(15, 15, 15, 15); // Thay đổi 10 thành giá trị mong muốn

                //    flowLayoutPanel1.Controls.Add(userControl);

                //}
                SqlCommand cmd = new SqlCommand("Select FirstName, LastName, course_id, course.name, semester " +
                    "From course inner join ( Select FirstName, LastName, course_id From teacher inner join curriculum On teacher.teacherID = curriculum.teacher_ID) Q " +
                    "On course.id = Q.course_id ", mydb.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                mydb.openConnection();
                adapter.Fill(dt);
                mydb.closeConnection();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string courseID = dt.Rows[i]["course_id"].ToString();
                    SqlCommand command = new SqlCommand("Select * From Score Where course_ID= @courseID and Student_ID = @studentID", mydb.getConnection);
                    command.Parameters.Add("@courseID", SqlDbType.NVarChar).Value = courseID;
                    command.Parameters.Add("@studentID", SqlDbType.Int).Value = Globals.GlobaUserID;
                    SqlDataAdapter adapter2 = new SqlDataAdapter(command);                  
                    DataTable table = new DataTable();
                    mydb.openConnection();
                    adapter2.Fill(table);
                    mydb.closeConnection();

                    if (table.Rows.Count > 0)
                    {
                        UserControlCourse userControl = new UserControlCourse();
                        userControl.labelTeacherName.Text = dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString();
                        userControl.labelCourseID.Text = dt.Rows[i][2].ToString();
                        userControl.labelCourseName.Text = dt.Rows[i][3].ToString();
                        userControl.labelSemester.Text = dt.Rows[i][4].ToString();
                        userControl.radioButton1.Enabled = false;
                        userControl.radioButton1.Text = "Đã đăng ký !";
                        // Đặt margin cho UserControl
                        userControl.Margin = new Padding(15, 15, 15, 15); // Thay đổi 10 thành giá trị mong muốn

                        flowLayoutPanel1.Controls.Add(userControl);
                    }
                    else
                    {
                        UserControlCourse userControl = new UserControlCourse();
                        userControl.labelTeacherName.Text = dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString();
                        userControl.labelCourseID.Text = dt.Rows[i][2].ToString();
                        userControl.labelCourseName.Text = dt.Rows[i][3].ToString();
                        userControl.labelSemester.Text = dt.Rows[i][4].ToString();
                        // Đặt margin cho UserControl
                        userControl.Margin = new Padding(15, 15, 15, 15); // Thay đổi 10 thành giá trị mong muốn

                        flowLayoutPanel1.Controls.Add(userControl);
                    }

                }

            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select FirstName, LastName, course_id, course.name, semester " +
                    "From course inner join ( Select FirstName, LastName, course_id From teacher inner join curriculum On teacher.teacherID = curriculum.teacher_ID) Q " +
                    "On course.id = Q.course_id " +
                    "Where course_id in (Select score.Course_id From score Where Student_id = @UserID)", mydb.getConnection);
                cmd.Parameters.AddWithValue("@UserID", Globals.GlobaUserID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                mydb.openConnection();
                adapter.Fill(dt);
                mydb.closeConnection();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    UserControlRegisteredCourse userControl = new UserControlRegisteredCourse(studentMainForm, this);
                    userControl.labelTeacherName.Text = dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString();
                    userControl.labelCourseID.Text = dt.Rows[i][2].ToString();
                    userControl.labelCourseName.Text = dt.Rows[i][3].ToString();
                    // Đặt margin cho UserControl
                    userControl.Margin = new Padding(15, 15, 15, 15); // Thay đổi 10 thành giá trị mong muốn

                    flowLayoutPanel1.Controls.Add(userControl);

                }

            }
        }
        private void CourseForm_Load(object sender, EventArgs e)
        {
                
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Check == 0)
            {
                flowLayoutPanel1.Controls.Clear();
                int semester = Convert.ToInt32(guna2ComboBox1.Text);
                SqlCommand cmd = new SqlCommand("Select FirstName, LastName, course_id, course.name, semester " +
                   "From course inner join ( Select FirstName, LastName, course_id From teacher inner join curriculum On teacher.teacherID = curriculum.teacher_ID) Q " +
                   "On course.id = Q.course_id Where semester = @semester ", mydb.getConnection);
                cmd.Parameters.AddWithValue("@semester", semester);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                mydb.openConnection();
                adapter.Fill(dt);
                mydb.closeConnection();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string courseID = dt.Rows[i]["course_id"].ToString();
                    SqlCommand command = new SqlCommand("Select * From Score Where course_ID= @courseID and Student_ID = @studentID", mydb.getConnection);
                    command.Parameters.Add("@courseID", SqlDbType.NVarChar).Value = courseID;
                    command.Parameters.Add("@studentID", SqlDbType.Int).Value = Globals.GlobaUserID;
                    SqlDataAdapter adapter2 = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    mydb.openConnection();
                    adapter2.Fill(table);
                    mydb.closeConnection();

                    if (table.Rows.Count > 0)
                    {
                        UserControlCourse userControl = new UserControlCourse();
                        userControl.labelTeacherName.Text = dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString();
                        userControl.labelCourseID.Text = dt.Rows[i][2].ToString();
                        userControl.labelCourseName.Text = dt.Rows[i][3].ToString();
                        userControl.labelSemester.Text = dt.Rows[i][4].ToString();
                        userControl.radioButton1.Enabled = false;
                        userControl.radioButton1.Text = "Đã đăng ký !";
                        // Đặt margin cho UserControl
                        userControl.Margin = new Padding(15, 15, 15, 15); // Thay đổi 10 thành giá trị mong muốn

                        flowLayoutPanel1.Controls.Add(userControl);
                    }
                    else
                    {
                        UserControlCourse userControl = new UserControlCourse();
                        userControl.labelTeacherName.Text = dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString();
                        userControl.labelCourseID.Text = dt.Rows[i][2].ToString();
                        userControl.labelCourseName.Text = dt.Rows[i][3].ToString();
                        userControl.labelSemester.Text = dt.Rows[i][4].ToString();
                        // Đặt margin cho UserControl
                        userControl.Margin = new Padding(15, 15, 15, 15); // Thay đổi 10 thành giá trị mong muốn

                        flowLayoutPanel1.Controls.Add(userControl);
                    }

                }
            }
            else
            {
                flowLayoutPanel1.Controls.Clear();
                DataTable dt = new DataTable();
                int semester = Convert.ToInt32(guna2ComboBox1.Text);
                dt = course.getCourseBySemester(semester);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    UserControlRegisteredCourse userControl = new UserControlRegisteredCourse(studentMainForm, this );
                    userControl.labelTeacherName.Text = dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString();
                    userControl.labelCourseID.Text = dt.Rows[i][2].ToString();
                    userControl.labelCourseName.Text = dt.Rows[i][3].ToString();
                    // Đặt margin cho UserControl
                    userControl.Margin = new Padding(15, 15, 15, 15); // Thay đổi 10 thành giá trị mong muốn

                    flowLayoutPanel1.Controls.Add(userControl);

                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
