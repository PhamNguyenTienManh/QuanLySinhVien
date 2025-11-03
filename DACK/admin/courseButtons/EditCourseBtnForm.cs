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

namespace DACKW.admin.courseButtons
{
    public partial class EditCourseBtnForm : Form
    {
        Course course=  new Course();
        DataTable table = new DataTable();
        MY_DB myDB = new MY_DB();
        public EditCourseBtnForm()
        {
            InitializeComponent();
        }
        public void fillCombo(int index)
        {
            string query = "Select id From Course";
            SqlCommand cmd = new SqlCommand(query);
            table = course.getCourses(cmd);
            guna2ComboBoxSelectCourse.DataSource = table;
            guna2ComboBoxSelectCourse.DisplayMember = "name";
            guna2ComboBoxSelectCourse.ValueMember = "id";
            guna2ComboBoxSelectCourse.SelectedIndex = index;
        }
        public bool checkID(string courseId)
        {
            SqlCommand cmd = new SqlCommand("Select * From Course Where Id = @cID", myDB.getConnection);
            cmd.Parameters.Add("@cID", SqlDbType.Char).Value = courseId;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        private void EditCourseBtnForm_Load(object sender, EventArgs e)
        {
            string query = "Select id From Course";
            SqlCommand cmd = new SqlCommand(query);
            table = course.getCourses(cmd);
            guna2ComboBoxSelectCourse.DataSource = table;
            guna2ComboBoxSelectCourse.DisplayMember = "name";
            guna2ComboBoxSelectCourse.ValueMember = "id";
            guna2ComboBoxSelectCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSemester.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void guna2ButtonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string id = guna2ComboBoxSelectCourse.Text;
                if (guna2ComboBoxSelectCourse.Text == "")
                {
                    MessageBox.Show("Select a course id", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (checkID(id))
                {

                    DialogResult result = MessageBox.Show("Bạn có chắn chắn xóa khóa học không ?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {

                        if (course.deleteCourse(id))
                        {
                            MessageBox.Show("Remove course successfully!", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EditCourseBtnForm_Load(sender, e);
                            guna2TextBoxCourseName.Text = null;
                            numericUpDownPeriod.Value = 1;
                            richTextBoxDes.Text = null;
                           comboBoxSemester.SelectedIndex = 0;



                        }
                        else
                        {
                            MessageBox.Show("Can not remove course", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("ID not exists", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = guna2TextBoxCourseName.Text;
                int hours = (int)numericUpDownPeriod.Value;
                int semester = Convert.ToInt32(comboBoxSemester.Text);
                string des = richTextBoxDes.Text;
                string id = guna2ComboBoxSelectCourse.SelectedValue.ToString();

                if (course.updateCourse(id, name, hours, semester, des))
                {
                    MessageBox.Show("Course updated", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillCombo(guna2ComboBoxSelectCourse.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Coure not updated", "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ComboBoxSelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                numericUpDownPeriod.Minimum = 1;  // Giá trị tối thiểu
                numericUpDownPeriod.Maximum = 100;  // Giá trị tối đa, bạn có thể điều chỉnh tùy theo nhu cầu
                string id = "";
                id = guna2ComboBoxSelectCourse.SelectedValue.ToString();
                DataTable table = new DataTable();
                table = course.getCourseByID(id);
                guna2TextBoxCourseName.Text = table.Rows[0][1].ToString();
                numericUpDownPeriod.Value = Int64.Parse(table.Rows[0][2].ToString());
                richTextBoxDes.Text = table.Rows[0][4].ToString();
                comboBoxSemester.Text = table.Rows[0][3].ToString();
               
            }
            catch //(Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
        }
    }
}
