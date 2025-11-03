using DACKW.Teacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACKW
{
    public partial class UserControlBaiTapDaDang : UserControl
    {
        TruyCapKhoaHoc truyCapKhoaHoc;
        ThemBaiTapBtn themBaiTapBtn = new ThemBaiTapBtn();
        Assignment assignment = new Assignment();
        MY_DB mydb = new MY_DB();
        public int ID;
        public string CourseID;
        public UserControlBaiTapDaDang()
        {
            InitializeComponent();
        }
        public UserControlBaiTapDaDang(TruyCapKhoaHoc truyCapKhoaHoc)
        {
            InitializeComponent();
            this.truyCapKhoaHoc = truyCapKhoaHoc;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            themBaiTapBtn.delete(guna2TextBoxFilePath.Text);
            if (assignment.delete(ID))
            {
                MessageBox.Show("Xóa thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                truyCapKhoaHoc.TruyCapKhoaHoc_Load_1(sender, e);
            }
            else MessageBox.Show("Xóa không thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
