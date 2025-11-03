using DACKW.Teacher;
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
    public partial class TeacherForm : Form
    {
        Form currentForm = null;
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void ButtonNotify_Click(object sender, EventArgs e)
        {
            LabelShow.Text = "Gửi thông báo";
            GiveNoticeToStdForm giveNoticeToStdForm = new GiveNoticeToStdForm();
            panel1.Controls.Clear();
            giveNoticeToStdForm.TopLevel = false;
            panel1.Controls.Add(giveNoticeToStdForm);
            giveNoticeToStdForm.BringToFront();
            giveNoticeToStdForm.Show();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
        public void OpenForm(Form form, Form formTag, TeacherForm teacherForm)
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
            LabelShow.Text = "Khóa học bạn dạy";
            OpenForm(new CourseTeacherBtn(this),this, this);
        }

        private void LabelShow_Click(object sender, EventArgs e)
        {

        }

        private void buttonAccountTeacher_Click(object sender, EventArgs e)
        {
            LabelShow.Text = "Thông tin giáo viên";
            OpenForm(new accountTeacher(this), this);
        }

        private void ButtonGiveScore_Click(object sender, EventArgs e)
        {
            LabelShow.Text = "Danh sách điểm các môn";
            OpenForm(new CourseTeacherBtn(this, 1), this, this);
        }
    }
}
