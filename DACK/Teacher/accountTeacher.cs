using DACKW.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACKW.Teacher
{
    public partial class accountTeacher : Form
    {
        TeacherForm teacherForm;
        public accountTeacher()
        {
            InitializeComponent();
        }
        public accountTeacher(TeacherForm teacherForm)
        {
            InitializeComponent();
            this.teacherForm = teacherForm;
        }

        DataTable table = new DataTable();
       TEACHER teacher = new TEACHER();
     
        private void accountTeacher_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("Select * from teacher where teacherID = @teacherID");
                command.Parameters.Add("@teacherID", SqlDbType.NVarChar).Value = Globals.GlobaStringUserID;
                table = teacher.getTeacher(command);
                guna2TextBoxID.Text = table.Rows[0][0].ToString();
                guna2TextBoxFname.Text = table.Rows[0][1].ToString();
                guna2TextBoxLname.Text = table.Rows[0][2].ToString();
                dateTimePickerBdate.Value = (DateTime)table.Rows[0][3];
                if (table.Rows[0]["Gender"].ToString() == "Female")
                {
                    radioButtonFemale.Checked = true;
                }
                else if (table.Rows[0]["Gender"].ToString() == "Male")
                {
                    radioButtonMale.Checked = true;
                }


                guna2TextBoxEmail.Text = table.Rows[0][7].ToString();
                guna2TextBoxPhoneNo.Text = table.Rows[0][5].ToString();
                richTextBoxAddress.Text = table.Rows[0][8].ToString();
                if (!table.Rows[0].IsNull("avatar"))
                {
                    byte[] pic;
                    pic = (byte[])table.Rows[0]["avatar"];
                    MemoryStream picture = new MemoryStream(pic);
                    guna2PictureBoxTeacher.Image = Image.FromStream(picture);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            guna2TextBoxID.ReadOnly = true;
            guna2TextBoxFname.ReadOnly = true;
            guna2TextBoxLname.ReadOnly = true;
            guna2TextBoxEmail.ReadOnly = true;
            guna2TextBoxPhoneNo.ReadOnly = true;
            richTextBoxAddress.ReadOnly = true;
            dateTimePickerBdate.Enabled = false;
            radioButtonFemale.Enabled = false;
            radioButtonMale.Enabled = false;
        }

        private void guna2ButtonChangePWord_Click(object sender, EventArgs e)
        {
            teacherForm.OpenForm(new UpdatePasswordTeacherForm(teacherForm), teacherForm);
        }

        private void guna2ButtonUpdateIn4_Click(object sender, EventArgs e)
        {
            teacherForm.OpenForm(new UpdateInfoTeacherform(teacherForm), teacherForm);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UserFace form = new UserFace();
            form.teacherid = guna2TextBoxID.Text;
            form.Show();
        }

    }
}

