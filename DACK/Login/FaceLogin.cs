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
    public partial class FaceLogin : Form
    {
        FaceDetect faceDetect = new FaceDetect();
        MY_DB mydb = new MY_DB();
        STUDENT student = new STUDENT();
        TEACHER teacher = new TEACHER();
        public FaceLogin()
        {
            InitializeComponent();
        }

        private void FaceLogin_Load(object sender, EventArgs e)
        {
           pictureBox3.Visible = true;
            pictureBox3.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
        }

        private void guna2ButtonOpen_Click(object sender, EventArgs e)
        {
            faceDetect.openCamera(pictureBox1, pictureBox2);
            faceDetect.isTrained = true;

        }
        private bool checkLogin(string Username)
        {
            string recognizedName = faceDetect.DetectName();
            if (recognizedName == Username)
            {
                return true;
            }
            else
            {
                return false;
            }




        }

        private void guna2ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = guna2TextBoxUsername.Text;
            SqlCommand cmd = new SqlCommand("select * from login where username = @un", mydb.getConnection);
            cmd.Parameters.AddWithValue("@un", username);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            mydb.openConnection();
            adapter.Fill(dt);
            mydb.closeConnection();
            if (dt.Rows.Count > 0)
            {
                string type = dt.Rows[0][3].ToString();
                if (checkLogin(username))
                {
                    if (type == "admin")
                    {
                        AdminForm form = new AdminForm();
                        form.Show();
                    }
                    else if (type == "student")
                    {
                        DataTable studentTable = student.getStudentIDByUserName(guna2TextBoxUsername.Text);
                        int studentId = Convert.ToInt32(studentTable.Rows[0][0].ToString());
                        Globals.SetGlobalUserID(studentId);
                        Globals.setType("student");
                        StudentMainForm form = new StudentMainForm();
                        form.ShowDialog();
                    }
                    else if (type == "teacher")
                    {
                        DataTable teacherTable = new DataTable();
                        teacherTable = teacher.getTeacherIDByUserName(guna2TextBoxUsername.Text);
                        string teacherId = teacherTable.Rows[0][0].ToString();
                        TeacherForm form = new TeacherForm();
                        Globals.SetGlobaStringlUserID(teacherId);
                        Globals.setType("teacher");
                        form.ShowDialog();
                    }
                }
            }
            else MessageBox.Show("Không có khuôn mặt trong dữ liệu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox3_PaddingChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
