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
    public partial class FaceLogin : Form
    {
        FaceDetect faceDetect = new FaceDetect();
        public FaceLogin()
        {
            InitializeComponent();
        }

        private void FaceLogin_Load(object sender, EventArgs e)
        {
           pictureBox3.Visible = true;
            pictureBox3.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
        }

        private void guna2ButtonOpen_Click(object sender, EventArgs e)
        {
            faceDetect.openCamera(pictureBox1, pictureBox2);
            faceDetect.isTrained = true;

        }
        private void checkLogin(string Username)
        {
            string recognizedName = faceDetect.DetectName();
            if (recognizedName == Username)
            {
                MessageBox.Show("Đăng nhập thành công!");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }




        }
        private void guna2ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = guna2TextBoxUsername.Text;
            
            checkLogin(username);
        }

        private void pictureBox3_PaddingChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
