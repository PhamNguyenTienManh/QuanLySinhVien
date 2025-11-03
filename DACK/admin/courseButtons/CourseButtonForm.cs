using DACKW.admin.courseButtons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACKW.admin
{
    public partial class CourseButtonForm : Form
    {
        public CourseButtonForm()
        {
            InitializeComponent();
        }

        private void guna2ButtonAddCourse_Click(object sender, EventArgs e)
        {
            AddNewCourseBtnForm form = new AddNewCourseBtnForm();
            guna2GradientPanel1.Controls.Clear();
            form.TopLevel = false;
            guna2GradientPanel1.Controls.Add(form);
            form.Show();
        }

        private void guna2ButtonEditCourse_Click(object sender, EventArgs e)
        {
            EditCourseBtnForm form = new EditCourseBtnForm();
            guna2GradientPanel1.Controls.Clear();
            form.TopLevel = false;
            guna2GradientPanel1.Controls.Add(form);
            form.Show();
        }

        private void guna2ButtonCourseList_Click(object sender, EventArgs e)
        {
            CourseListBtnForm form = new CourseListBtnForm();
            guna2GradientPanel1.Controls.Clear();
            form.TopLevel = false;
            guna2GradientPanel1.Controls.Add(form);
            form.Show();
        }
    }
}
