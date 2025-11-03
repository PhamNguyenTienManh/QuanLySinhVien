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

namespace DACKW
{
    public partial class GiveNoticeToStdForm : Form
    {
        MY_DB mydb = new MY_DB();
        Announce announce = new Announce();
        public GiveNoticeToStdForm()
        {
            InitializeComponent();
        }

        private void GiveNoticeToStdForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select course_id from curriculum where teacher_id = @tid", mydb.getConnection);
            cmd.Parameters.AddWithValue("@tid", Globals.GlobaStringUserID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            mydb.openConnection();
            adapter.Fill(dt);
            guna2ComboBoxCourse.DataSource = dt;
            guna2ComboBoxCourse.DisplayMember = "course_id";
            guna2ComboBoxCourse.ValueMember = "course_id";
        }

        private void buttonGiveNotice_Click(object sender, EventArgs e)
        {

            if (guna2TextBox1.Text == "" || richTextBox1.Text == "")
                MessageBox.Show("Thiếu thông tin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (announce.insert(guna2ComboBoxCourse.Text, Globals.GlobaStringUserID, guna2TextBox1.Text, richTextBox1.Text,
                    DateTime.Now, "Teacher"))
                    MessageBox.Show("Gửi thông báo thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Gửi thông báo không thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
