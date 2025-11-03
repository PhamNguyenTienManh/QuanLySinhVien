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

namespace DACKW
{
    public partial class accountStudent : Form
    {
        public accountStudent()
        {
           InitializeComponent();
           
                   
        }
        StudentMainForm studentMainForm;
        public accountStudent(StudentMainForm formtag)
        {
            InitializeComponent();
            this.studentMainForm = formtag;

        }
        DataTable table = new DataTable();
        STUDENT student = new STUDENT();
        private void account_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("Select * from student where studentID = @stdID");
                command.Parameters.Add("@stdID", DbType.Int32).Value = Globals.GlobaUserID;
                table = student.getStudent(command);
                guna2TextBoxID.Text = table.Rows[0][0].ToString();
                guna2TextBoxFname.Text = table.Rows[0][1].ToString();
                guna2TextBoxLname.Text = table.Rows[0][2].ToString();
                dateTimePickerBdate.Value = (DateTime)table.Rows[0][3];
                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    radioButtonFemale.Checked = true;
                }
                else if (table.Rows[0]["gender"].ToString() == "Male")
                {
                    radioButtonMale.Checked = true; 
                }


                guna2TextBoxEmail.Text = table.Rows[0][5].ToString();
                guna2TextBoxPhoneNo.Text = table.Rows[0][6].ToString();
                richTextBoxAddress.Text = table.Rows[0][7].ToString();
                if ( ! table.Rows[0].IsNull("avatar") )
                {
                    byte[] pic;
                    pic = (byte[])table.Rows[0]["avatar"];
                    MemoryStream picture = new MemoryStream(pic);
                    guna2PictureBoxStd.Image = Image.FromStream(picture);
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

        private void guna2ButtonUpdateIn4_Click(object sender, EventArgs e)
        {
            studentMainForm.OpenForm(new UpdateInfoForm(studentMainForm), studentMainForm);
        }

        private void guna2ButtonChangePWord_Click(object sender, EventArgs e)
        {
            studentMainForm.OpenForm(new UpdatePasswordForm(studentMainForm), studentMainForm);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UserFace form  = new UserFace();
            form.studentid = Convert.ToInt32(guna2TextBoxID.Text);
            form.Show();
        }
    }
}
