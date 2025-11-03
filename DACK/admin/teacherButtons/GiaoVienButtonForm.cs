using DACKW.admin;
using DACKW.admin.teacherButtons;
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
    public partial class GiaoVienButtonForm : Form
    {
        public GiaoVienButtonForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddTeacherAccountForm form = new AddTeacherAccountForm();
            guna2GradientPanel1.Controls.Clear();
            form.TopLevel = false;
            guna2GradientPanel1.Controls.Add(form);
            form.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            EditTeacherBtnForm form = new EditTeacherBtnForm();
            guna2GradientPanel1.Controls.Clear();
            form.TopLevel = false;
            guna2GradientPanel1.Controls.Add(form);
            form.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ListTeacherBtnForm form = new ListTeacherBtnForm();
            guna2GradientPanel1.Controls.Clear();
            form.TopLevel = false;
            guna2GradientPanel1.Controls.Add(form);
            form.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            CourseTeacherBtnForm form = new CourseTeacherBtnForm();
            guna2GradientPanel1.Controls.Clear();
            form.TopLevel = false;
            guna2GradientPanel1.Controls.Add(form);
            form.Show();
        }
    }
}
