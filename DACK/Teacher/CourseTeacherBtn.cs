using DACKW.admin;
using Microsoft.Office.Interop.Excel;
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
    public partial class CourseTeacherBtn : Form
    {
        MY_DB mydb = new MY_DB();
        string query = "";
        public CourseTeacherBtn()
        {
            InitializeComponent();
        }
        TeacherForm teacherForm;
        int type;
        public CourseTeacherBtn(TeacherForm teacherForm)
        {
            InitializeComponent();
            this.teacherForm = teacherForm;
        }
        public CourseTeacherBtn(TeacherForm teacherForm, int type)
        {
            InitializeComponent();
            this.teacherForm = teacherForm;
            this.type = type;
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void fillgrid(string query)
        {
            SqlCommand cmd = new SqlCommand("select course_id from curriculum where teacher_id = @UserID", mydb.getConnection);
            cmd.Parameters.AddWithValue("@UserID", Globals.GlobaStringUserID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            mydb.openConnection();
            adapter.Fill(dt);
            mydb.closeConnection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string course_id = dt.Rows[i][0].ToString();
                SqlCommand command = new SqlCommand(query, mydb.getConnection);
                command.Parameters.AddWithValue("@CourseID", course_id);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                mydb.openConnection();
                sqlDataAdapter.Fill(table);
                mydb.closeConnection();
                if (table.Rows.Count > 0)
                {
                    KhoaHocGiaoVien form = new KhoaHocGiaoVien(teacherForm, this, type);
                    form.labelCourseID.Text = table.Rows[0][0].ToString();
                    form.labelCourseName.Text = table.Rows[0][1].ToString();
                    form.labelSemester.Text = table.Rows[0][2].ToString();
                    form.Margin = new Padding(15, 15, 15, 15);
                    flowLayoutPanel1.Controls.Add(form);
                }
            }
        }
        private void CourseTeacherBtn_Load_1(object sender, EventArgs e)
        {
            query = "SELECT id, name, semester FROM Course INNER JOIN curriculum ON Course.id = curriculum.course_id WHERE id = @CourseID";
            fillgrid(query);
            //SqlCommand cmd = new SqlCommand("select course_id from curriculum where teacher_id = @UserID", mydb.getConnection);
            //cmd.Parameters.AddWithValue("@UserID", Globals.GlobaStringUserID);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //mydb.openConnection();
            //adapter.Fill(dt);
            //mydb.closeConnection();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    string course_id = dt.Rows[i][0].ToString();
            //    SqlCommand command = new SqlCommand("SELECT id, name, semester FROM Course INNER JOIN curriculum ON Course.id = curriculum.course_id WHERE id = @CourseID", mydb.getConnection);
            //    command.Parameters.AddWithValue("@CourseID", course_id);
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            //    DataTable table = new DataTable();
            //    mydb.openConnection();
            //    sqlDataAdapter.Fill(table);
            //    mydb.closeConnection();
            //    if (table.Rows.Count > 0)
            //    {
            //        KhoaHocGiaoVien form = new KhoaHocGiaoVien(teacherForm,this);
            //        form.labelCourseID.Text = table.Rows[0][0].ToString();
            //        form.labelCourseName.Text = table.Rows[0][1].ToString();
            //        form.labelSemester.Text = table.Rows[0][2].ToString();
            //        form.Margin = new Padding(15, 15, 15, 15);
            //        flowLayoutPanel1.Controls.Add(form);
            //    }
            //}
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            query = "SELECT id, name, semester FROM Course INNER JOIN curriculum ON Course.id = curriculum.course_id WHERE id = @CourseID and concat(id,name) like '%"+guna2TextBoxSearch.Text+"%'";
            fillgrid(query);
        }
    }

}
