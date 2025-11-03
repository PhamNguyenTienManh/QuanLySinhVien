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

namespace DACKW.admin.teacherButtons
{
    public partial class CourseTeacherBtnForm : Form
    {
        MY_DB mydb = new MY_DB();
        TEACHER teacher = new TEACHER();
        Curriculum curriculum = new Curriculum();
        Course course = new Course();
        public CourseTeacherBtnForm()
        {
            InitializeComponent();
        }

    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2TextBoxTeacherID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            guna2TextBoxTeacherName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SqlCommand cmd = new SqlCommand("select Course.name as name, Course.id from Course inner join (select course_id from curriculum where teacher_id=@id) Q on Course.id=Q.course_id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            mydb.openConnection();
            adapter.Fill(dt);
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "name";
            listBox1.ValueMember = "id";

        }

        private void CourseTeacherBtnForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Teacher", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            mydb.openConnection();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            mydb.closeConnection();
            dataGridView1.RowTemplate.Height = 88;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;



        }
        public bool checkExist(string course_id, string teacher_id)
        {
            SqlCommand cmd = new SqlCommand("select * from curriculum where Course_id=@cid and Teacher_id=@tid",mydb.getConnection);
            cmd.Parameters.AddWithValue("@cid", course_id);
            cmd.Parameters.AddWithValue("@tid",teacher_id);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            mydb.openConnection();
            adapter.Fill(dt);
            mydb.closeConnection();
            if (dt.Rows.Count > 0)
                return true;
            else return false;

        }
        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            string course_id = listBox1.SelectedValue.ToString().Trim();
            string teacher_id = guna2TextBoxTeacherID.Text;
            if (teacher_id == "" || guna2TextBoxTeacherName.Text == "")
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(checkExist(course_id, teacher_id))
                MessageBox.Show("Giáo viên đã có khóa học này rồi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (curriculum.insert(course_id, teacher_id)) MessageBox.Show("Thêm thành công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Thêm không thành công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void guna2ComboBoxSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            int se = Convert.ToInt32(guna2ComboBoxSemester.SelectedItem.ToString());
            SqlCommand cmd = new SqlCommand("select * from Course where semester = @se", mydb.getConnection);
            cmd.Parameters.Add("@se", SqlDbType.Int).Value = se;
            DataTable dt = new DataTable();
            dt = course.getCourses(cmd);
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "name";
            listBox1.ValueMember = "id";
        }

        private void guna2ButtonDelete_Click(object sender, EventArgs e)
        {
            string course_id = listBox1.SelectedValue.ToString();
            if (guna2TextBoxTeacherName.Text == "" || listBox1.SelectedIndex < 0)
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {

                MessageBox.Show(course_id);
                if (curriculum.delete(course_id)) MessageBox.Show("Đã xóa", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Xóa không thành công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ComboBoxSemester_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int se = Convert.ToInt32(guna2ComboBoxSemester.SelectedItem.ToString());
            SqlCommand cmd = new SqlCommand("select * from Course where semester = @se and id not in (select Course_id from curriculum)", mydb.getConnection);
            cmd.Parameters.Add("@se", SqlDbType.Int).Value = se;
            DataTable dt = new DataTable();
            dt = course.getCourses(cmd);
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "name";
            listBox1.ValueMember = "id";
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2ButtonDelete_Click_1(object sender, EventArgs e)
        {
            string course_id = listBox1.SelectedValue.ToString();
            if (guna2TextBoxTeacherName.Text == "" || listBox1.SelectedIndex < 0)
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show(course_id);
                if (curriculum.delete(course_id)) MessageBox.Show("Đã xóa", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Xóa không thành công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
