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
    public partial class StudentMainForm : Form
    {
        public StudentMainForm()
        {
            InitializeComponent();
        }
        Form currentForm = null;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LabelShow.Text = "Thông tin sinh viên";
            OpenForm(new accountStudent(this), this);
           
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonNotify_Click(object sender, EventArgs e)
        {
            LabelShow.Text = "Thông báo";
            NotifyForm notifyForm = new NotifyForm();
            panel1.Controls.Clear();
            notifyForm.TopLevel = false;
            panel1.Controls.Add(notifyForm);
            notifyForm.BringToFront();
            notifyForm.Show();

        }

        public void OpenForm(Form form, Form formTag)
        {
            panel1.Controls.Clear();
            currentForm = form;
            form.TopLevel = false;
            panel1.Controls.Add(form);
            currentForm.BringToFront();
            form.Show();
            form.Tag = formTag;
        }
        public void OpenForm(Form form, Form formTag, StudentMainForm studentMainForm)
        {
            panel1.Controls.Clear();
            currentForm = form;
            form.TopLevel = false;
            panel1.Controls.Add(form);
            currentForm.BringToFront();
            form.Show();
            form.Tag = formTag;
        }
        private void buttonCourse_Click(object sender, EventArgs e)
        {
            LabelShow.Text = "Khóa học của bạn";
            OpenForm(new CourseForm(this, 1), this, this);
        }

        private void buttonRegisterCourse_Click(object sender, EventArgs e)
        {
            
            LabelShow.Text = "Đăng ký Khóa học";
            OpenForm(new CourseForm(this, 0), this, this);
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelShow_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
