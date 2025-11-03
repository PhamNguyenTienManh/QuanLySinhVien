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

namespace DACKW.Teacher
{
    public partial class TruyCapKhoaHoc : Form
    {
        MY_DB mydb = new MY_DB();
        public TruyCapKhoaHoc()
        {
            InitializeComponent();
        }
        TeacherForm teacherForm;
        CourseTeacherBtn courseTeacherBtn;
        public TruyCapKhoaHoc(TeacherForm teacherForm)
        {
            InitializeComponent();
            this.teacherForm = teacherForm;
        }
        public TruyCapKhoaHoc(TeacherForm teacherForm, CourseTeacherBtn courseTeacherBtn)
        {
            InitializeComponent();
            this.teacherForm = teacherForm;
            this.courseTeacherBtn = courseTeacherBtn;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ClearUserControl()
        {
            for (int i = flowLayoutPanel1.Controls.Count - 1; i >= 0; i--)
            {
                // Kiểm tra xem control có phải là UserControl không
                if (flowLayoutPanel1.Controls[i] is UserControl userControl)
                {
                    // Nếu là UserControl, xóa nó khỏi panel
                    flowLayoutPanel1.Controls.RemoveAt(i);
                    userControl.Dispose(); // Giải phóng tài nguyên của UserControl
                }
            }
        }
        public void TruyCapKhoaHoc_Load_1(object sender, EventArgs e)
        {
            ClearUserControl();
            flowLayoutPanel1.Controls.Clear();
            guna2ButtonDienDan.BackColor = Color.Transparent;
            guna2ButtonDanhSach.BackColor = Color.Transparent;
            guna2ButtonThemBaiTap.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(guna2Panel1);
            SqlCommand cmd = new SqlCommand("SELECT * FROM curriculum INNER JOIN Assignment ON curriculum.course_id = Assignment.CourseID WHERE curriculum.course_id = @course_id", mydb.getConnection);
            cmd.Parameters.AddWithValue("@course_id", label2.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            mydb.openConnection();
            adapter.Fill(dt);
            mydb.closeConnection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                UserControlBaiTapDaDang form = new UserControlBaiTapDaDang(this);
                form.guna2TextBoxAssignmentName.Text = dt.Rows[i][4].ToString();
                form.guna2TextBoxFilePath.Text = dt.Rows[i][6].ToString();
                form.guna2DateTimePicker1.Value = (DateTime)dt.Rows[i][7];
                form.richTextBoxDes.Text = dt.Rows[i][5].ToString();
                form.ID = Convert.ToInt32(dt.Rows[i][2].ToString());
                form.CourseID = label2.Text;
                form.Margin = new Padding(15, 15, 15, 15);
                flowLayoutPanel1.Controls.Add(form);
            }
        }

        private void guna2ButtonThemBaiTap_Click_1(object sender, EventArgs e)
        {
            ThemBaiTapBtn themBaiTapBtn = new ThemBaiTapBtn(teacherForm, this);
            themBaiTapBtn.FolderName = label2.Text;
            teacherForm.OpenForm(themBaiTapBtn,this, teacherForm);
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2ButtonDanhSach_Click(object sender, EventArgs e)
        {
            StudentRegisterCourseForrm studentRegisterCourseForrm = new StudentRegisterCourseForrm(teacherForm, this);
            studentRegisterCourseForrm.courseID = label2.Text;
            teacherForm.OpenForm(studentRegisterCourseForrm,this, teacherForm);
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {

            teacherForm.OpenForm(courseTeacherBtn,this, teacherForm);
        }

        private void guna2ButtonDienDan_Click(object sender, EventArgs e)
        {
            ForumForm forumForm = new ForumForm(teacherForm, this);
            forumForm.courseID = label2.Text;
            forumForm.lblCourseID.Text = label2.Text;
            forumForm.lblCoursename.Text = label6.Text;
            teacherForm.OpenForm(forumForm, this, teacherForm);
        }
    }
}
