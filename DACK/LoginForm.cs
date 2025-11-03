using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2TextBox1.BackColor = Color.Transparent;
            guna2TextBox2.BackColor = Color.Transparent;
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
                StudentMainForm form = new StudentMainForm();
                form.ShowDialog();
            }
            else if (ComboBoxTypeOfAcc.Text == "Teacher")
            {
                TeacherForm form = new TeacherForm();
                form.ShowDialog();
            }    
            else
            {
                MessageBox.Show("Bạn chưa chọn loại tài khoản");
            }
        }
    }
}
