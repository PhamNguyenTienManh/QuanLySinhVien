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
    public partial class UserControlCourse : UserControl
    {
        public UserControlCourse()
        {
            InitializeComponent();
        }
        Score score = new Score();
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng ký khóa học này ?", "Register course", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                if (score.insertScore(Globals.GlobaUserID, labelCourseID.Text))
                {
                    radioButton1.Text = "Đăng ký thành công !";
                    radioButton1.ForeColor = Color.Blue;
                }
            }
        }
    }
}
