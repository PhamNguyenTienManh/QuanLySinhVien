using DACKW.admin;
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
    public partial class AdminForm : Form
    {
        StudentButtonForm studentButtonForm = new StudentButtonForm();
        Form currentForm = null;
        public AdminForm()
        {
            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
               
        }

        public void OpenForm(Form form, Form formTag, AdminForm adminForm)
        {
            panel1.Controls.Clear();
            currentForm = form;
            form.TopLevel = false;
            panel1.Controls.Add(form);
            currentForm.BringToFront();
            form.Show();
            form.Tag = formTag;
        }
        private void buttonAccountTeacher_Click(object sender, EventArgs e)
        {
            StudentButtonForm studentButtonForm = new StudentButtonForm();
            guna2GradientPanel1.Controls.Clear();
            studentButtonForm.TopLevel = false;
            guna2GradientPanel1.Controls.Add(studentButtonForm);
            studentButtonForm.BringToFront();
            studentButtonForm.Show();
        }

        private void buttonCourse_Click(object sender, EventArgs e)
        {
            GiaoVienButtonForm giaoVienButtonForm = new GiaoVienButtonForm();
            guna2GradientPanel1.Controls.Clear();
            giaoVienButtonForm.TopLevel = false;
            guna2GradientPanel1.Controls.Add(giaoVienButtonForm);
            giaoVienButtonForm.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            CourseButtonForm  form = new CourseButtonForm();
            guna2GradientPanel1.Controls.Clear();
            form.TopLevel = false;
            guna2GradientPanel1.Controls.Add(form);
            form.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ScoreButtonForm form = new ScoreButtonForm();
            guna2GradientPanel1.Controls.Clear();
            form.TopLevel = false;
            guna2GradientPanel1.Controls.Add(form);
            form.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AccountButtonForm form = new AccountButtonForm();
            guna2GradientPanel1.Controls.Clear();
            form.TopLevel = false;
            guna2GradientPanel1.Controls.Add(form);
            form.Show();
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
