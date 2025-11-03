using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class AddNewCourse : Form
    {
        MY_DB my_db = new MY_DB();
        Course course = new Course();
        public AddNewCourse()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (labeltxt.Text.Trim() == "" )
                MessageBox.Show("Hãy nhập tên khóa học", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(comboBoxSemester.SelectedIndex == -1 ) MessageBox.Show("Hãy chọn học kì", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if((int)periodNum.Value < 10)
                MessageBox.Show("Giá trị tiết học phải lớn hơn 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (course.CheckCourseName(labeltxt.Text,""))
            {
                if(course.insertCourse(idtxt.Text, labeltxt.Text, (int)periodNum.Value, descriptiontxt.Text, int.Parse(comboBoxSemester.SelectedItem.ToString())))
                {
                    MessageBox.Show("Course inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Course not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            else MessageBox.Show("Course name already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void periodNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void descriptiontxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void labeltxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
        

    
}
