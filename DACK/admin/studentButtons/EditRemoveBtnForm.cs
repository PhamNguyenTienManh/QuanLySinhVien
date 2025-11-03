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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DACKW.admin.studentButtons
{
    public partial class EditRemoveBtnForm : Form
    {
        MY_DB mydb = new MY_DB();
        STUDENT student = new STUDENT();
        public EditRemoveBtnForm()
        {
            InitializeComponent();
        }

        private void EditRemoveBtnForm_Load(object sender, EventArgs e)
        {
            string query = "select * from student";
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            dataGridView1.DataSource=student.getStudent(cmd);
            dataGridView1.RowTemplate.Height = 88;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void guna2ButtonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif; *.jfif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                guna2PictureBoxStd.Image = Image.FromFile(opf.FileName);
            }
        }
        public bool validPhone(string phone)
        {
            for(int i=0; i<phone.Length; i++)
            {
                if (phone[i] <'0' || phone[i]>'9')
                    return false;
            }    
            return true;
        }
        bool onlyLetter(string s)
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
        public bool validDateTime(DateTime dateTime)
        {
            int born_year = dateTime.Year;
            int this_year = DateTime.Now.Year;
            //  sv tu 10-100,  co the thay doi
            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                return false;
            }
            return true;
        }
        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            MemoryStream pic = new MemoryStream();
            string gender = "";
            if (guna2CustomRadioButtonMale.Checked)
                gender = "Male";
            else gender = "Female";
            string Email = guna2TextBoxMSSV.Text + "@student.hcmute.edu.vn";
            if (guna2TextBoxMSSV.Text == "" || guna2TextBoxlname.Text == "" || guna2TextBoxfname.Text == ""|| guna2TextBoxPhone.Text == ""
                || richTextBoxAddress.Text == ""  || guna2PictureBoxStd.Image == null)
            {
                MessageBox.Show("Thiếu dữ kiện","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!validPhone(guna2TextBoxMSSV.Text)) MessageBox.Show("Mã SV không hợp lệ", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!validPhone(guna2TextBoxPhone.Text)) MessageBox.Show("Số điện thoại không hợp lệ", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!validDateTime(guna2DateTimePickerStd.Value)) MessageBox.Show("Ngày sinh không hợp lệ", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!onlyLetter(guna2TextBoxlname.Text) || !onlyLetter(guna2TextBoxfname.Text)) MessageBox.Show("First Name và Last Name phải là chữ cái", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                guna2PictureBoxStd.Image.Save(pic, guna2PictureBoxStd.Image.RawFormat);
                if (student.insertStudent(Convert.ToInt32(guna2TextBoxMSSV.Text), guna2TextBoxfname.Text, guna2TextBoxlname.Text, guna2DateTimePickerStd.Value
                    , gender, Email, guna2TextBoxPhone.Text,richTextBoxAddress.Text, pic))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EditRemoveBtnForm_Load(sender, e);
                }
                else MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2TextBoxMSSV.ReadOnly = true;
            guna2TextBoxMSSV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            guna2TextBoxfname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            guna2TextBoxlname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            guna2DateTimePickerStd.Value =(DateTime) dataGridView1.CurrentRow.Cells[3].Value;
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Male") guna2CustomRadioButtonMale.Checked = true;
            else guna2CustomRadioButtonFemale.Checked = true;
            richTextBoxAddress.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            guna2TextBoxPhone.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            object cellValue = dataGridView1.CurrentRow.Cells[8].Value;
            if (cellValue != DBNull.Value)
            {
                pic = (byte[])cellValue;
                if (pic != null && pic.Length > 0)
                {
                    MemoryStream picture = new MemoryStream(pic);
                    guna2PictureBoxStd.Image = Bitmap.FromStream(picture);
                    Show();
                }
                else
                {
                    guna2PictureBoxStd.Image = null;
                }
            }
            else
            {
                guna2PictureBoxStd.Image = null;
            }
            
        }

        private void guna2ButtonEdit_Click(object sender, EventArgs e)
        {
            guna2TextBoxMSSV.ReadOnly = true;
            if (!validPhone(guna2TextBoxPhone.Text)) MessageBox.Show("Số điện thoại không hợp lệ", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!validDateTime(guna2DateTimePickerStd.Value)) MessageBox.Show("Ngày sinh không hợp lệ", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!onlyLetter(guna2TextBoxlname.Text) || !onlyLetter(guna2TextBoxfname.Text)) MessageBox.Show("First Name và Last Name phải là chữ cái", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MemoryStream image = new MemoryStream();
                string gender = "";
                if (guna2CustomRadioButtonMale.Checked)
                    gender = "Male";
                else gender = "Female";
                guna2PictureBoxStd.Image.Save(image, guna2PictureBoxStd.Image.RawFormat);
               // string Email = guna2TextBoxMSSV.Text + "@student.hcmute.edu.vn";
                if (student.updateStudent(Convert.ToInt32(guna2TextBoxMSSV.Text), guna2TextBoxfname.Text, guna2TextBoxlname.Text, guna2DateTimePickerStd.Value
                        , gender, guna2TextBoxPhone.Text, richTextBoxAddress.Text, image))
                {
                    MessageBox.Show("Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EditRemoveBtnForm_Load(sender, e);
                }
                else MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ButtonRemove_Click(object sender, EventArgs e)
        {
            
            if (guna2TextBoxMSSV.Text == "") 
                MessageBox.Show("Thiếu MSSV", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            else
            {
                if (student.deleteStudent(Convert.ToInt32(guna2TextBoxMSSV.Text)))
                {
                    MessageBox.Show("Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EditRemoveBtnForm_Load(sender, e);
                }
                else MessageBox.Show("Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
