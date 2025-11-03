using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACKW.admin.courseButtons
{
    public partial class AddNewCourseBtnForm : Form
    {
        Course course = new Course();
        public AddNewCourseBtnForm()
        {
            InitializeComponent();
        }
        bool kiemTraTen(string s)
        {
            int dem = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z') || (s[i] == ' ') || (s[i] >= '0' && s[i] <= '9'))
                    dem++;
            }
            if (dem == s.Length)
            {
                return true;
            }
            else { return false; }
        }

        bool verif()
        {
            if ((guna2TextBoxCourseID.Text.Trim() == "")
                        || (guna2TextBoxCourseName.Text.Trim() == "")
                        || (guna2ComboBoxSemester.Text.Trim() == "")
                        || (richTextBoxDes.Text.Trim() == ""))

            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void guna2ButtonAddCourse_Click(object sender, EventArgs e)
        {
            try
            {

                if (verif())
                {

                    string id = guna2TextBoxCourseID.Text;
                    string name = guna2TextBoxCourseName.Text;
                    int period;
                    int semester = Convert.ToInt32(guna2ComboBoxSemester.Text);
                    string description = richTextBoxDes.Text;
                    if (!kiemTraTen(name) || !kiemTraTen(id))
                    {
                        MessageBox.Show("Lỗi format !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (course.checkCourseID(id) == false)
                    {
                        MessageBox.Show("This id already exists", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (int.TryParse(guna2TextBoxPeriod.Text, out period))
                    {
                        period = Convert.ToInt32(guna2TextBoxPeriod.Text);
                        if (period > 100 || period <1)
                        {
                            MessageBox.Show("Period must from 1 to 100", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (course.checkCourseName(name))
                        {
                            if (course.insertCourse(id, name, period, semester, description))
                            {
                                MessageBox.Show("New course inserted", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Course not inserted", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("This Course name already exists", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Period must be integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lack of information", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
