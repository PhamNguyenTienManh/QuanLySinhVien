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
    public partial class UserFace : Form
    {
        public int studentid;
        public string username;
        public string email;
        public string teacherid;
        FaceDetect faceDetect = new FaceDetect();
        MY_DB mydb = new MY_DB();
        public UserFace()
        {
            InitializeComponent();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (Globals.Type == "student")
            {
                SqlCommand cmd = new SqlCommand("select * from student inner join login on student.email = login.mail where studentID=@sid", mydb.getConnection);
                cmd.Parameters.AddWithValue("@sid", studentid);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                mydb.openConnection();
                adapter.Fill(dt);
                mydb.closeConnection();
                if (dt.Rows.Count > 0)
                    username = dt.Rows[0][9].ToString();
                faceDetect.Save_IMAGE(username);
                MessageBox.Show("Face Saved");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select * from teacher inner join login on teacher.email = login.mail where teacherid=@tid", mydb.getConnection);
                cmd.Parameters.AddWithValue("@tid", teacherid);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                mydb.openConnection();
                adapter.Fill(dt);
                mydb.closeConnection();
                if (dt.Rows.Count > 0)
                    username = dt.Rows[0][9].ToString();
                faceDetect.Save_IMAGE(username);
                MessageBox.Show("Face Saved");
            }    
        }

        private void Camerabtn_Click(object sender, EventArgs e)
        {
            faceDetect.openCamera(pictureBoxOpenCam, pictureBox2);
            pictureBox2.Visible = false;
        }

        private void UserFace_Load(object sender, EventArgs e)
        {

        }
    }
}
