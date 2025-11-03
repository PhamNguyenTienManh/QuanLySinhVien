using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACKW.Teacher
{
    public partial class UserControlStudentAssignment : UserControl
    {
        Submission submission = new Submission();
        public int ID;
        public int student_id;
        public string name;
        MY_DB mydb = new MY_DB();
        public UserControlStudentAssignment()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string chromePath = GetBrowserPath("chrome.exe");

            if (chromePath != null)
            {
                OpenLinkWithBrowser(chromePath, guna2TextBoxFilePath.Text);
            }
            else
            {
                // Tìm đường dẫn của trình duyệt Edge nếu Chrome không tồn tại
                string edgePath = GetBrowserPath("msedge.exe");
                if (edgePath != null)
                {
                    OpenLinkWithBrowser(edgePath, "https://www.example.com");
                }
                else
                {
                    Console.WriteLine("Không thể tìm thấy trình duyệt Chrome hoặc Edge trên máy tính này.");
                }
            }
        }
        static string GetBrowserPath(string browserExe)
        {
            string browserKey = $@"Software\Microsoft\Windows\CurrentVersion\App Paths\{browserExe}";

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(browserKey))
            {
                if (key != null)
                {
                    Object o = key.GetValue("");
                    if (o != null)
                    {
                        return o.ToString();
                    }
                }
            }

            return null;
        }

        static void OpenLinkWithBrowser(string browserPath, string link)
        {
            try
            {
                // Khởi tạo một quy trình mới
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = browserPath,
                    Arguments = link
                };

                // Khởi chạy quy trình để mở link bằng trình duyệt
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }


        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBoxDiem.Text == "" || richTextBoxFeedback.Text == "")
                    MessageBox.Show("Thiếu thông tin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if(float.TryParse(guna2TextBoxDiem.Text, out float value))
                {
                    if (value < 0 || value > 10)
                    {
                        MessageBox.Show("Điểm không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (submission.updateDiem(ID,student_id, float.Parse(guna2TextBoxDiem.Text), richTextBoxFeedback.Text))
                        MessageBox.Show("Đã lưu điểm", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Lưu điểm không thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Điểm không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
