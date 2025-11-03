using DACKW.admin;
using DACKW.admin.studentButtons;
using Guna.UI2.WinForms;
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
    public partial class StudentButtonForm : Form
    {
        public StudentButtonForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            AddStudentAccountForm form = new AddStudentAccountForm();
            guna2GradientPanel1.Controls.Clear();
            form.TopLevel = false;
            guna2GradientPanel1.Controls.Add(form);
            form.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            StudentListButtonForm form = new StudentListButtonForm();
            guna2GradientPanel1.Controls.Clear();
            form.TopLevel = false;
            guna2GradientPanel1.Controls.Add(form);
            form.Show();


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AddStudentAccountForm form = new AddStudentAccountForm();
            guna2GradientPanel1.Controls.Clear();
            form.TopLevel = false;
            guna2GradientPanel1.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2ButtonEdit_Click(object sender, EventArgs e)
        {
            EditRemoveBtnForm form = new EditRemoveBtnForm();
            guna2GradientPanel1.Controls.Clear();
            form.TopLevel = false;
            guna2GradientPanel1.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void guna2ButtonImport_Click(object sender, EventArgs e)
        {

        }
    }
}
