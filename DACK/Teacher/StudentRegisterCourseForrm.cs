using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace DACKW.Teacher
{
    public partial class StudentRegisterCourseForrm : Form
    {
        MY_DB mydb = new MY_DB();
        string query = "";
        STUDENT student=  new STUDENT();
        public StudentRegisterCourseForrm()
        {
            InitializeComponent();
        }
        TeacherForm teacherForm;
        public string courseID;
        TruyCapKhoaHoc truycapkhoahoc;
        public StudentRegisterCourseForrm(TeacherForm teacherForm)
        {
            InitializeComponent();
            this.teacherForm = teacherForm;
        }
        public StudentRegisterCourseForrm(TeacherForm teacherForm, TruyCapKhoaHoc truyCapKhoaHoc)
        {
            InitializeComponent();
            this.teacherForm = teacherForm;
            this.truycapkhoahoc = truyCapKhoaHoc;
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            teacherForm.OpenForm(truycapkhoahoc,this, teacherForm);
        }

        private void StudentRegisterCourseForrm_Load(object sender, EventArgs e)
        {
            //guna2CustomRadioButtonAll.Checked = true;
            SqlCommand command = new SqlCommand("Select StudentID, FirstName, LastName, BirthDate, Gender, Email, Phone, Address, Avatar " +
                "From student inner join score " +
                "On student.studentID = score.Student_id " +
                "Where score.Course_id = @courseID", mydb.getConnection);
            command.Parameters.Add("@courseID", SqlDbType.NVarChar).Value = courseID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowTemplate.Height = 88;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

        }

        private void guna2CustomRadioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            query = "select * from student";
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            dataGridView1.DataSource = student.getStudent(cmd);
        }

        private void guna2CustomRadioButtonSubmitted_CheckedChanged(object sender, EventArgs e)
        {
            query = " select * from student where StudentID in (select StudentID from Submission)";
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            dataGridView1.DataSource = student.getStudent(cmd);
        }

        private void guna2CustomRadioButtonNotsubmitted_CheckedChanged(object sender, EventArgs e)
        {
            query = " select * from student where StudentID not in (select StudentID from Submission)";
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            dataGridView1.DataSource = student.getStudent(cmd);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentInfo studentInfo = new StudentInfo(teacherForm, this);
            studentInfo.labelMSSV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            studentInfo.labelName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString();
            studentInfo.labelEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            studentInfo.CourseID = courseID;
            //studentInfo.studentid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            teacherForm.OpenForm(studentInfo, this, teacherForm);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from student where concat(StudentID,FirstName,LastName) like '%"+guna2TextBoxSearch.Text+"%'", mydb.getConnection);
            dataGridView1.DataSource = student.getStudent(cmd);
        }
    }
}
