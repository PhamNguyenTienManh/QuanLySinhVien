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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
       MY_DB db = new MY_DB();
        STUDENT student = new STUDENT();
        TEACHER teacher = new TEACHER(); 
        private void Form1_Load(object sender, EventArgs e)
        {
            guna2TextBoxUserName.BackColor = Color.Transparent;
            guna2TextBoxPassword.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FaceLogin faceLogin = new FaceLogin();
            faceLogin.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPasswordForm form = new ForgetPasswordForm();
            form.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (ComboBoxTypeOfAcc.Text == "Student")
            {
               
                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand("SELECT username, password FROM login WHERE username = @User AND password = @Pass AND accept = 1 AND type = 'student'", db.getConnection);

                command.Parameters.Add("@User", SqlDbType.VarChar).Value = guna2TextBoxUserName.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = guna2TextBoxPassword.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    DataTable studentTable = new DataTable();
                    studentTable = student.getStudentIDByUserName(guna2TextBoxUserName.Text);
                    int studentId = Convert.ToInt32(studentTable.Rows[0][0].ToString());
                    Globals.SetGlobalUserID(studentId);
                    Globals.setType("student");
                    StudentMainForm form = new StudentMainForm();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else if (ComboBoxTypeOfAcc.Text == "Teacher")
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand("SELECT username, password FROM login WHERE username = @User AND password = @Pass AND accept = 1 AND type = 'teacher'", db.getConnection);

                command.Parameters.Add("@User", SqlDbType.VarChar).Value = guna2TextBoxUserName.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = guna2TextBoxPassword.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    DataTable teacherTable = new DataTable();
                    teacherTable = teacher.getTeacherIDByUserName(guna2TextBoxUserName.Text);
                    string teacherId = teacherTable.Rows[0][0].ToString();
                    TeacherForm form = new TeacherForm();
                    Globals.SetGlobaStringlUserID(teacherId);
                    Globals.setType("teacher");
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (ComboBoxTypeOfAcc.Text == "Admin")
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand("SELECT username, password FROM login WHERE username = @User AND password = @Pass AND accept = 1 AND type = 'admin'", db.getConnection);

                command.Parameters.Add("@User", SqlDbType.VarChar).Value = guna2TextBoxUserName.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = guna2TextBoxPassword.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    AdminForm form = new AdminForm();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn loại tài khoản");
            }
              
        }
    }
}
