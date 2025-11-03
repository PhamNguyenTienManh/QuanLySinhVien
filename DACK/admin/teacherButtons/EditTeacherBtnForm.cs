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

namespace DACKW.admin.teacherButtons
{
    public partial class EditTeacherBtnForm : Form
    {
        MY_DB mydb = new MY_DB();
        TEACHER teacher = new TEACHER();
        public EditTeacherBtnForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2TextBoxMSSV.ReadOnly = true;
            guna2TextBoxMSSV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            guna2TextBoxfname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            guna2TextBoxlname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            guna2TextBoxEmail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            guna2DateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Male") guna2CustomRadioButtonMale.Checked = true;
            else guna2CustomRadioButtonFemale.Checked = true;
           
            guna2TextBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            guna2TextBoxAddress.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            byte[] pic;
            object cellValue = dataGridView1.CurrentRow.Cells[6].Value;
            if (cellValue != DBNull.Value)
            {
                pic = (byte[])cellValue;
                if (pic != null && pic.Length > 0)
                {
                    MemoryStream picture = new MemoryStream(pic);
                    guna2PictureBox1.Image = Bitmap.FromStream(picture);
                    Show();
                }
                else
                {
                    guna2PictureBox1.Image = null;
                }
            }
            else
            {
                guna2PictureBox1.Image = null;
            }
        }

        private void EditTeacherBtnForm_Load(object sender, EventArgs e)
        {
            string query = "select * from Teacher";
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            dataGridView1.DataSource = teacher.getTeacher(cmd);
            dataGridView1.RowTemplate.Height = 88;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        public bool validPhone(string phone)
        {
            for (int i = 0; i < phone.Length; i++)
            {
                if (phone[i] < '0' || phone[i] > '9')
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
            if (guna2TextBoxMSSV.Text == "" || guna2TextBoxlname.Text == "" || guna2TextBoxfname.Text == "" || guna2TextBoxPhone.Text == ""
                 || guna2PictureBox1.Image == null)
            {
                MessageBox.Show("Thiếu dữ kiện", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if (!validPhone(guna2TextBoxPhone.Text)) MessageBox.Show("Số điện thoại không hợp lệ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!validDateTime(guna2DateTimePicker1.Value)) MessageBox.Show("Ngày sinh không hợp lệ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!onlyLetter(guna2TextBoxlname.Text) || !onlyLetter(guna2TextBoxfname.Text)) MessageBox.Show("First Name và Last Name phải là chữ cái", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                guna2PictureBox1.Image.Save(pic, guna2PictureBox1.Image.RawFormat);
                if (teacher.insertTeacher(guna2TextBoxMSSV.Text, guna2TextBoxfname.Text, guna2TextBoxlname.Text, guna2DateTimePicker1.Value
                    ,gender, guna2TextBoxPhone.Text, pic, guna2TextBoxEmail.Text, guna2TextBoxAddress.Text))
                {
                    MessageBox.Show("New Teacher Added", "Add Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EditTeacherBtnForm_Load(sender, e);
                }
                else MessageBox.Show("Error", "Add Teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ButtonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif; *.jfif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                guna2PictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void guna2ButtonEdit_Click(object sender, EventArgs e)
        {
            
            if (!validPhone(guna2TextBoxPhone.Text)) MessageBox.Show("Số điện thoại không hợp lệ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!validDateTime(guna2DateTimePicker1.Value)) MessageBox.Show("Ngày sinh không hợp lệ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!onlyLetter(guna2TextBoxlname.Text) || !onlyLetter(guna2TextBoxfname.Text)) MessageBox.Show("First Name và Last Name phải là chữ cái", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MemoryStream image = new MemoryStream();
                string gender = "";
                if (guna2CustomRadioButtonMale.Checked)
                    gender = "Male";
                else gender = "Female";
                guna2PictureBox1.Image.Save(image, guna2PictureBox1.Image.RawFormat);
                if (teacher.updateTeacher(guna2TextBoxMSSV.Text, guna2TextBoxfname.Text, guna2TextBoxlname.Text, guna2DateTimePicker1.Value
                        , gender, guna2TextBoxPhone.Text, image, guna2TextBoxEmail.Text, guna2TextBoxAddress.Text))
                {
                    MessageBox.Show("Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EditTeacherBtnForm_Load(sender, e);
                }
                else MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ButtonRemove_Click(object sender, EventArgs e)
        {
            if (guna2TextBoxMSSV.Text == "") MessageBox.Show("Thiếu Mã GV", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                if (teacher.deleteTeacher(guna2TextBoxMSSV.Text))
                {
                    MessageBox.Show("Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EditTeacherBtnForm_Load(sender, e);
                }
                else MessageBox.Show("Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
