using DACKW.Student;
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
    public partial class UserControlRegisteredCourse : UserControl
    {
        public UserControlRegisteredCourse()
        {
            InitializeComponent();
        }
        StudentMainForm studentMainForm;
        CourseForm courseForm;
        
        public UserControlRegisteredCourse(StudentMainForm stdmainform, CourseForm courseForm)
        {
            InitializeComponent();
            this.courseForm = courseForm;
            this.studentMainForm = stdmainform;
        }

        private void linkLabelAccess_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string courseID = labelCourseID.Text;
            string courseName = labelCourseName.Text;
            string teacherName = labelTeacherName.Text;
            AccessCourseForm accessCourseForm = new AccessCourseForm(studentMainForm, courseForm);
            accessCourseForm.labelCourseIdAndName.Text = courseName + "/" + courseID;
            accessCourseForm.courseID = courseID;
            accessCourseForm.courseName = courseName;
            accessCourseForm.label2.Text = teacherName;
            studentMainForm.OpenForm(accessCourseForm,courseForm, studentMainForm);
        }
    }
}
