using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DACKW
{
    public partial class ForgetPasswordForm : Form
    {
        Random random = new Random();
        MY_DB db = new MY_DB();
        Login login = new Login();
        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        private void ForgetPasswordForm_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }
        bool isValidEmail(string email)
        {
            int count = 0;
            string user = guna2TextBoxUsername.Text;
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            Regex regex = new Regex(pattern);

            if (regex.IsMatch(email)) count++;

            string query = "SELECT * FROM login WHERE username = @user and mail = @mail";

            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            cmd.Parameters.Add("@user", SqlDbType.NVarChar).Value = user;
            cmd.Parameters.Add("@mail", SqlDbType.NVarChar).Value = email;
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0) count++;
            if (count == 2) return true;
            return false;
        }
        int otp;
        bool confirmPassWord(string a, string b)
        {
            if (a == b) return true;
            else return false;
        }
        private void otpbtn_Click(object sender, EventArgs e)
        {
            try
            {
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
                MessageBox.Show("Gửi OTP không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            if (!otp.ToString().Equals(guna2TextBoxOTP.Text))
                MessageBox.Show("OTP không đúng", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (guna2TextBoxUsername.Text == "" || guna2TextBoxGmail.Text == "" || guna2TextBoxOTP.Text == "" || guna2TextBoxpass.Text == "" || guna2TextBoxConfirmPass.Text == "")
                MessageBox.Show("Thiếu thông tin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!isValidEmail(guna2TextBoxGmail.Text))
                MessageBox.Show("Username không tồn tại hoặc Gmail sai", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //else if(checkEmailExist(guna2TextBoxGmail.Text))
            //    MessageBox.Show("Gmail không tồn tại trong hệ thống", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!confirmPassWord(guna2TextBoxpass.Text, guna2TextBoxConfirmPass.Text))
                MessageBox.Show("Mật khẩu không trùng khớp", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //else if(!usernameExist(guna2TextBoxUsername.Text))
            //    MessageBox.Show("Username không tồn tại", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                if (login.updateAccount(guna2TextBoxUsername.Text, guna2TextBoxpass.Text))
                    MessageBox.Show("Cập nhật mật khẩu mới thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
