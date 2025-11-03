using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DACKW
{
    public partial class RegisterForm : Form
    {
        FaceDetect faceDetect = new FaceDetect();
        Random random = new Random();
        int otp;
        Login login = new Login();
        MY_DB db = new MY_DB();
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
            
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            faceDetect.Save_IMAGE(guna2TextBoxUsername.Text);
            MessageBox.Show("Face Saved");
        }
        bool verif ()
        {
            if (guna2TextBoxUsername.Text == "" 
            || guna2TextBoxPassword.Text == ""
            || guna2TextBoxConfirmPass.Text ==""
            ||  guna2TextBoxGmail.Text == "" )
          //  || pictureBoxOpenCam.Image == null )
            
            {
                return false;
            }
            else
                return true;          
        }
        string typeOfAccount ()
        {
            if (guna2CustomRadioButtonAdmin.Checked == true)
                return "admin";
            else if (guna2CustomRadioButtonStudent.Checked == true)
                return "student";
            else if (guna2CustomRadioButtonTeacher.Checked == true)
                return "teacher";
            else
                return null;
        }
        string OldOTP = null;
        private void registerbtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (verif() == true)
                {
                    string username = guna2TextBoxUsername.Text;
                    string password = guna2TextBoxPassword.Text;
                    string repassword = guna2TextBoxConfirmPass.Text;
                    string email = guna2TextBoxGmail.Text;
                    string otpString = guna2TextBoxOTP.Text;
                    string typeAccount;
                   
                    if (typeOfAccount() != null)
                    {
                        typeAccount = typeOfAccount();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn loại tài khoản", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (guna2TextBoxOTP.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập mã OTP để xác thực", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }
                    else if (checkUserName() == true)
                    {
                        MessageBox.Show("Tên người dùng đã tồn tại", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (checkEmailRegistered(email))
                    {
                        MessageBox.Show("Email này đã có người đăng ký", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (confirmPassWord(password, repassword) == false)
                    {
                        MessageBox.Show("Mật khẩu không trùng khớp", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (isValidEmail(email)==false)
                    {
                        MessageBox.Show("Email không hợp lệ", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }                   
                    else if (checkEmailStudentExist(email)==false && typeAccount=="student")
                    {
                        MessageBox.Show("Email không thuộc hệ thống nhà trường", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (checkEmailTeacherExist(email) == false && typeAccount == "teacher")
                    {
                        MessageBox.Show("Email không thuộc hệ thống nhà trường", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (otp.ToString().Equals(guna2TextBoxOTP.Text) == false)
                    {
                        MessageBox.Show("OTP không chính xác", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (OldOTP == guna2TextBoxOTP.Text)
                    {
                        MessageBox.Show("Vui lòng gửi lại OTP!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (login.insertAccount(username,password, email, typeAccount))
                        {
                            MessageBox.Show("Vui lòng chờ admin phê duyệt !");
                            OldOTP = guna2TextBoxOTP.Text;
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký người dùng không thành công!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Thiếu thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool confirmPassWord(string a, string b)
        {
            if (a == b) return true;
            else return false;
        }
        bool checkUserName()
        {
            string connectionString = "Data Source=DESKTOP-J6I016E\\SQLEXPRESS05;Initial Catalog=DACK;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string userName = guna2TextBoxUsername.Text;
            // Thêm các tham số vào chuỗi truy vấn để kiểm tra tên người dùng
            string checkUsernameQuery = "SELECT COUNT(*) FROM login WHERE username = @userName";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand checkCommand = new SqlCommand(checkUsernameQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@userName", userName);

                    int userCount = (int)checkCommand.ExecuteScalar();

                    if (userCount > 0)
                    {
                        return true;
                    }
                    else
                    { return false; }
                }

                connection.Close();
            }
        }
        bool checkEmailStudentExist (string email)
        {
            string query = "Select * from student where email = @email";
            SqlCommand command = new SqlCommand(query, db.getConnection);
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.closeConnection();
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            { return false; }
        }

        bool checkEmailTeacherExist(string email)
        {
            string query = "Select * from Teacher where email = @email";
            SqlCommand command = new SqlCommand(query, db.getConnection);
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.closeConnection();
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            { return false; }
        }
        bool checkEmailRegistered(string email)
        {
            string query = "Select * from login where mail = @email";
            SqlCommand command = new SqlCommand(query, db.getConnection);
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.closeConnection();
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            { return false; }
        }
        

        bool isValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        private void ButtonSendOTP_Click(object sender, EventArgs e)
        {
            try
            {
                string typeAccount="";
               if (verif()==false)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi gửi OTP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (typeOfAccount() != null)
                {
                    typeAccount = typeOfAccount();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại tài khoản", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string email = guna2TextBoxGmail.Text;
                if (checkEmailStudentExist(email) == false && typeAccount == "student")
                {
                    MessageBox.Show("Email không thuộc hệ thống nhà trường", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (checkEmailTeacherExist(email) == false && typeAccount == "teacher")
                {
                    MessageBox.Show("Email không thuộc hệ thống nhà trường", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (checkEmailRegistered(email))
                {
                    MessageBox.Show("Email này đã có người đăng ký", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (isValidEmail(guna2TextBoxGmail.Text))
                {
                    otp = random.Next(100000, 1000000);
                    var from = new MailAddress("minh.dox.555@gmail.com");
                    var to = new MailAddress(guna2TextBoxGmail.Text);
                    const string pass = "glowzetyctgqxdmb";
                    const string subject = "OTP code";
                    string body = otp.ToString();
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(from.Address, pass),
                        Timeout = 200000
                    };
                    using (var message = new MailMessage(from, to)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(message);
                    }
                    MessageBox.Show("Gửi OTP thành công", "Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Email không hợp lệ, vui lòng nhập lại!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxOpenCam_Click(object sender, EventArgs e)
        {

        }
    }
}
