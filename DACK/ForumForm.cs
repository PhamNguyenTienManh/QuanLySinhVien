using DACKW.Student;
using DACKW.Teacher;
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
    public partial class ForumForm : Form
    {
        public ForumForm()
        {
            InitializeComponent();
        }
        StudentMainForm studentMainForm;
        TeacherForm teacherForm;
        AccessCourseForm accessCourseForm;
        TruyCapKhoaHoc TruyCapKhoaHoc;
        int phanbiet;
        Chat chat = new Chat();
        MY_DB mydb = new MY_DB();
        public string courseID;
        public ForumForm(StudentMainForm studentMainForm)
        {
            InitializeComponent();
            this.studentMainForm = studentMainForm;
        }
        public ForumForm(StudentMainForm studentMainForm, AccessCourseForm accessCourseForm)
        {
            InitializeComponent();
            this.studentMainForm = studentMainForm;
            this.accessCourseForm = accessCourseForm;
            phanbiet = 0;
        }
        public ForumForm(TeacherForm teacherForm, TruyCapKhoaHoc truyCapKhoaHoc)
        {
            InitializeComponent();
            this.TruyCapKhoaHoc = truyCapKhoaHoc;
            this.teacherForm = teacherForm;
            phanbiet = 1;
        }

        private void ForumForm_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SqlCommand cmd = new SqlCommand("Select * from chat where courseID = @courseID", mydb.getConnection);
            cmd.Parameters.Add("@courseID", SqlDbType.NVarChar).Value = courseID;
            SqlDataAdapter myadapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            myadapter.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["type"].ToString() == "student")
                {
                    ForumUserControl userControl = new ForumUserControl();
                    userControl.Anchor = AnchorStyles.Left;
                    userControl.labelName.Text = dt.Rows[i]["name"].ToString();
                    userControl.richTextBoxMess.Text = dt.Rows[i]["message"].ToString();
                    userControl.labelTime.Text = dt.Rows[i]["time"].ToString();
                    byte[] pic;
                    pic = (byte[])dt.Rows[i]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    userControl.guna2CirclePictureBox1.Image = Image.FromStream(picture);

                    Panel panel = new Panel();
                    panel.Size = new Size(690, 92); // Thay Width và Height bằng kích thước mong muốn hoặc sử dụng SizeMode phù hợp
                    userControl.Dock = DockStyle.Left; // Đặt vị trí của userControl sang bên trái
                    panel.Controls.Add(userControl);
                    panel.Margin = new Padding(15, 15, 15, 15); // Đặt padding cho panel
                    flowLayoutPanel1.Controls.Add(panel);
                  
                }
                else
                {
                    ForumTeacherUserControl userControl = new ForumTeacherUserControl();
                    userControl.Anchor = AnchorStyles.Right;
                    userControl.labelName.Text = dt.Rows[i]["name"].ToString();
                    userControl.richTextBoxMess.Text = dt.Rows[i]["message"].ToString();
                    userControl.labelTime.Text = dt.Rows[i]["time"].ToString();
                    byte[] pic;
                    pic = (byte[])dt.Rows[i]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    userControl.guna2CirclePictureBox1.Image = Image.FromStream(picture);
                    Panel panel = new Panel();
                    panel.Size = new Size(690, 92); // Thay Width và Height bằng kích thước mong muốn hoặc sử dụng SizeMode phù hợp
                    userControl.Dock = DockStyle.Right; // Đặt vị trí của userControl sang bên phải
                    panel.Controls.Add(userControl);
                    panel.Margin = new Padding(15, 15, 15, 15); // Đặt padding cho panel
                    flowLayoutPanel1.Controls.Add(panel);                    
                }
                flowLayoutPanel1.AutoScrollPosition = new Point(0, flowLayoutPanel1.VerticalScroll.Maximum);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //AccessCourseForm accessCourseForm = new AccessCourseForm(studentMainForm);
            if (phanbiet == 0)
            {
                studentMainForm.OpenForm(accessCourseForm, this, studentMainForm);
            }
            else
            {
                teacherForm.OpenForm(TruyCapKhoaHoc, this, teacherForm);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetNextChatId();
                string courseID = lblCourseID.Text;
                string type = Globals.Type;
                int studentID = 0;
                string teacherID = "";
                string name = "";
                MemoryStream picture = new MemoryStream();
                string message = guna2TextBoxMess.Text;
                if (message.Trim().Length == 0)
                {
                    MessageBox.Show("Please Enter The Message !", "Is Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DateTime time = DateTime.Now;
                DataTable dt = new DataTable();

                if (type == "student")
                {
                    SqlCommand cmd = new SqlCommand("SELECT studentID, firstname, lastname, avatar FROM student WHERE studentID = @studentID", mydb.getConnection);
                    cmd.Parameters.Add("@studentID", SqlDbType.Int).Value = Globals.GlobaUserID;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        studentID = Convert.ToInt32(dt.Rows[0]["studentID"]);
                        string fname = dt.Rows[0]["firstname"].ToString();
                        string lname = dt.Rows[0]["lastname"].ToString();
                        name = fname + " " + lname;
                        byte[] avatarBytes = (byte[])dt.Rows[0]["avatar"];
                        picture = new MemoryStream(avatarBytes);
                    }
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SELECT teacherID, firstname, lastname, avatar FROM teacher WHERE teacherID = @teacherID", mydb.getConnection);
                    cmd.Parameters.Add("@teacherID", SqlDbType.NVarChar).Value = Globals.GlobaStringUserID;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        teacherID = dt.Rows[0]["teacherID"].ToString();
                        string fname = dt.Rows[0]["firstname"].ToString();
                        string lname = dt.Rows[0]["lastname"].ToString();
                        name = fname + " " + lname;
                        byte[] avatarBytes = (byte[])dt.Rows[0]["avatar"];
                        picture = new MemoryStream(avatarBytes);
                    }
                }
                if (chat.insert(id, courseID, type, studentID, teacherID, name, message, picture, time))
                {
                    guna2TextBoxMess.Text = "";
                    ForumForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Gui that bai !", "Error");
                }

            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private int GetNextChatId()
        {
            int nextId = 0;
            string query = "SELECT MAX(id) + 1 FROM chat";
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            object result = command.ExecuteScalar();

            if (result != DBNull.Value && result != null)
            {
                nextId = Convert.ToInt32(result);
            }
            else
            {
                nextId = 1; // Trường hợp không có bản ghi nào trong bảng
            }
            mydb.closeConnection();
            return nextId;
        }
    }
}
