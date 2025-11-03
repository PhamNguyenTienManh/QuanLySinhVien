using Guna.UI2.WinForms;
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
    public partial class UpdateInfoForm : Form
    {
        public UpdateInfoForm()
        {
            InitializeComponent();
        }
        StudentMainForm studentMainForm;
        accountStudent accountStudent= new accountStudent();
        public UpdateInfoForm(StudentMainForm studentMainForm)
        {
            InitializeComponent();
            this.studentMainForm = studentMainForm;
        }

        private void guna2ButtonGoBack_Click(object sender, EventArgs e)
        {
            studentMainForm.OpenForm(new accountStudent(studentMainForm), studentMainForm);
        }
        DataTable table = new DataTable();
        STUDENT student = new STUDENT();
        int studentID;
        private void UpdateInfoForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("Select * from student where studentID = @stdID");
                command.Parameters.Add("@stdID", DbType.Int32).Value = Globals.GlobaUserID;
                table = student.getStudent(command);             
                studentID = Convert.ToInt32(table.Rows[0][0].ToString());
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
                guna2TextBoxPhoneNo.Text = table.Rows[0][6].ToString();
                richTextBoxAddress.Text = table.Rows[0][7].ToString();
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
        bool verif()
        {
            if ((guna2TextBoxFname.Text.Trim() == "")
                        || (guna2TextBoxLname.Text.Trim() == "")
                        || (richTextBoxAddress.Text.Trim() == "")
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


        private void guna2ButtonUpdateIn4_Click(object sender, EventArgs e)
        {
            int id = studentID;
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
                //  sv tu 10-100,  co the thay doi

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
                           
                            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                            {
                                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                guna2PictureBoxStd.Image.Save(pic, guna2PictureBoxStd.Image.RawFormat);
                                if (student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                                {
                                    MessageBox.Show("Edit student successfully", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Can not edit student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
