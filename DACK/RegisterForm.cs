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
    public partial class RegisterForm : Form
    {
        FaceDetect faceDetect = new FaceDetect();
      
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        private void Camerabtn_Click(object sender, EventArgs e)
        {
            faceDetect.openCamera(pictureBox1, pictureBox2);
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            faceDetect.Save_IMAGE(guna2TextBoxUsername.Text);
            MessageBox.Show("Face Saved");
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
