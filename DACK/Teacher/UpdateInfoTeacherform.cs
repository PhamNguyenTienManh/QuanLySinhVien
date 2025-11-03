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
    public partial class UpdateInfoTeacherform : Form
    {
        TeacherForm teacherForm;
        accountTeacher accountTeacher = new accountTeacher();   
        public UpdateInfoTeacherform()
        {
            InitializeComponent();
        }

        public UpdateInfoTeacherform(TeacherForm teacherForm)
        {
            InitializeComponent();
            this.teacherForm = teacherForm;
        }
        bool verif()
        {
            if ((guna2TextBoxFname.Text.Trim() == "")
                        || (guna2TextBoxLname.Text.Trim() == "")
                      //  || (richTextBoxAddress.Text.Trim() == "")
                        || (guna2TextBoxPhoneNo.Text.Trim() == "")
                        || (guna2PictureBoxStd.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        bool kiemTraTen(string s)
        {
            int dem = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z') || (s[i] == ' '))
                    dem++;
            }
            if (dem == s.Length)
            {
                return true;
            }
            else { return false; }
        }

        bool kiemTraSDT(string s)
        {
            int dem = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                    dem++;
            }
            if ((dem == s.Length))
            { return true; }
            else
            { return false; }
        }

        DataTable table = new DataTable();
        TEACHER teacher = new TEACHER();
        string teacherID;
        private void UpdateInfoTeacherform_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("Select * from teacher where teacherID = @teacherID");
                command.Parameters.Add("@teacherID", SqlDbType.NVarChar).Value = Globals.GlobaStringUserID;
                table = teacher.getTeacher(command);
                teacherID = table.Rows[0][0].ToString();
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
                guna2TextBoxPhoneNo.Text = table.Rows[0][5].ToString();
                richTextBoxAddress.Text = table.Rows[0][8].ToString();
                if (!table.Rows[0].IsNull("avatar"))
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
        }
        private void guna2ButtonUpdateIn4_Click(object sender, EventArgs e)
        {
            string id = teacherID;
            string fname = guna2TextBoxFname.Text;
            string lname = guna2TextBoxLname.Text;
            DateTime bdate = dateTimePickerBdate.Value;
            string phone = guna2TextBoxPhoneNo.Text;
            string adrs = richTextBoxAddress.Text;
            string gender = "Male";
            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }
            try
            {
                MemoryStream pic = new MemoryStream();
                int born_year = dateTimePickerBdate.Value.Year;
                int this_year = DateTime.Now.Year;
             

                if (verif())
                {
                    if (kiemTraSDT(phone) == false)
                    {
                        MessageBox.Show("Not valid phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!kiemTraTen(fname) || !kiemTraTen(lname))
                    {
                        MessageBox.Show("Not valid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        if (((this_year - born_year) < 22) || ((this_year - born_year) > 100))
                        {
                            MessageBox.Show("The teacher Age must Be Between 22 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            guna2PictureBoxStd.Image.Save(pic, guna2PictureBoxStd.Image.RawFormat);
                            if (teacher.updateTeacher(id, fname, lname, bdate, gender, phone, pic, adrs))
                            {
                                MessageBox.Show("Edit teacher successfully", "Edit teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Can not edit teacher", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ButtonUpImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif; *.jfif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                guna2PictureBoxStd.Image = Image.FromFile(opf.FileName);
            }
        }

        private void guna2ButtonGoBack_Click(object sender, EventArgs e)
        {
            teacherForm.OpenForm(new accountTeacher(teacherForm), teacherForm);
        }
    }
}
