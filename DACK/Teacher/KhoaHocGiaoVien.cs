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
    public partial class KhoaHocGiaoVien : UserControl
    {

        public KhoaHocGiaoVien()
        {
            InitializeComponent();
        }
        TeacherForm teacherForm;
        CourseTeacherBtn courseTeacherBtn;
        int type;
        public KhoaHocGiaoVien(TeacherForm teacherForm)
        {
            InitializeComponent();
            this.teacherForm = teacherForm;
        }
        public KhoaHocGiaoVien(TeacherForm teacherForm, CourseTeacherBtn courseTeacherBtn, int type)
        {
            InitializeComponent();
            this.teacherForm = teacherForm;
            this.courseTeacherBtn = courseTeacherBtn;
            this.type = type;
        }



        private void KhoaHocGiaoVien_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelAccess_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (type == 0)
            {
                TruyCapKhoaHoc form = new TruyCapKhoaHoc(teacherForm, courseTeacherBtn);
                form.label2.Text = labelCourseID.Text;
                form.label3.Text = labelSemester.Text;
                form.label6.Text = labelCourseName.Text;
                teacherForm.OpenForm(form, courseTeacherBtn, teacherForm);
            }
            else
            {
                studentScoreForm form = new studentScoreForm(teacherForm, courseTeacherBtn);
                form.guna2HtmlLabelCourseName.Text = "Danh sách điểm môn: " + labelCourseName.Text;
                form.course_id = labelCourseID.Text;
                teacherForm.OpenForm(form, courseTeacherBtn, teacherForm);
            }
        }

        private void KhoaHocGiaoVien_Load_1(object sender, EventArgs e)
        {

        }
    }
}
