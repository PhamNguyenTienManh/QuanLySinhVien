using DACKW.Student;
using DACKW.Teacher;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACKW
{
    public partial class UserControlAssignment : UserControl
    {
        MY_DB mydb = new MY_DB();
        public int ID;
        Submission submission = new Submission();
        ThemBaiTapBtn themBaiTapBtn = new ThemBaiTapBtn();
        public string FolderName;
        public static string fileName;
        static string fileUrl;
        StudentMainForm studentMainForm;
        AccessCourseForm accessCourseForm;
        public UserControlAssignment()
        {
            InitializeComponent();
        }
        public UserControlAssignment(StudentMainForm studentMainForm, AccessCourseForm accessCourseForm)
        {
            InitializeComponent();
            this.studentMainForm = studentMainForm;
            this.accessCourseForm = accessCourseForm;
        }
        private string[] BrowseFiles()
        {
            fileName = Globals.GlobaUserID.ToString()+" nop bai "+ themBaiTapBtn.tenFile;
            using (System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileNames;
                }
                else
                {
                    return null;
                }
            }
        }


        static void UploadFileToGoogleDrive(string credentialsPath, string parentFolderId, string folderName, string[] filePaths)
        {
            GoogleCredential credential;
            using (var stream = new FileStream(credentialsPath, FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream).CreateScoped(new[]
                {
            DriveService.ScopeConstants.DriveFile
        });
            }

            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Google Drive Upload"
            });

            string folderID = GetFolderIdByName(service, parentFolderId, folderName);

            if (folderID == null)
            {
                folderID = CreateFolder(service, folderName, parentFolderId);
                if (folderID == null)
                {
                    MessageBox.Show("Failed to create folder on Google Drive.");
                    return;
                }
            }

            foreach (var filePath in filePaths)
            {
                var fileMetaData = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = fileName,
                    Parents = new List<string> { folderID }
                };

                FilesResource.CreateMediaUpload request;
                using (var stream = new FileStream(filePath, FileMode.Open))
                {
                    request = service.Files.Create(fileMetaData, stream, "");
                    request.Fields = "id";
                    request.Upload();
                }

                var uploadFile = request.ResponseBody;
                fileUrl = GetFileUrl(service, uploadFile.Id);
                MessageBox.Show("File uploaded successfully!");
            }
        }

        static string CreateFolder(DriveService service, string folderName, string parentFolderId)
        {
            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = folderName,
                MimeType = "application/vnd.google-apps.folder",
                Parents = new List<string> { parentFolderId }
            };

            var request = service.Files.Create(fileMetadata);
            request.Fields = "id";

            var folder = request.Execute();
            return folder.Id;
        }
        static string GetFileUrl(DriveService service, string fileId)
        {
            FilesResource.GetRequest request = service.Files.Get(fileId);
            request.Fields = "webViewLink"; // Lấy đường dẫn xem tệp

            var file = request.Execute();
            return file.WebViewLink;
        }
        static string GetFolderIdByName(DriveService service, string parentFolderId, string folderName)
        {
            var request = service.Files.List();
            request.Q = $"'{parentFolderId}' in parents and mimeType='application/vnd.google-apps.folder' and name='{folderName}'";
            request.Fields = "files(id)";

            var result = request.Execute();
            var folder = result.Files.FirstOrDefault();

            return folder?.Id;
        }
        private void guna2ButtonSubmit_Click(object sender, EventArgs e)
        {
            //string credentialsPath = "credentials.json";
            //string parentFolderId = "1bRdkClFCevAcQ98bXJaKUCiw2EUiKds3";
            //string folderName = FolderName;
            //string[] fileToUpload = BrowseFiles();
            //UploadFileToGoogleDrive(credentialsPath, parentFolderId, folderName, fileToUpload);
            FormNopBai formNopBai = new FormNopBai(studentMainForm, accessCourseForm );
            formNopBai.url = textBox2.Text;
            studentMainForm.OpenForm(formNopBai, formNopBai, studentMainForm);
        }

        private void UserControlAssignment_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string chromePath = GetBrowserPath("chrome.exe");

            if (chromePath != null)
            {
                OpenLinkWithBrowser(chromePath, textBox2.Text);
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
        public string findFileID(string filePath)
        {
            string fileId = "";
            string pattern = @"/d/([a-zA-Z0-9-_]+)";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(filePath);

            if (match.Success)
            {
                fileId = match.Groups[1].Value;

            }
            return fileId;
        }
        public void delete(string filePath)
        {
            // Đường dẫn đến tệp cần xóa trên Google Drive
            string fileId = findFileID(filePath);

            // Thông tin xác thực từ tài khoản dịch vụ
            string serviceAccountEmail = "driveauthapproject@sustained-spark-422114-c2.iam.gserviceaccount.com";
            string privateKey = "-----BEGIN PRIVATE KEY-----\nMIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQDgP1TPWNR19vI1\n8vK24Ey//KmHohEJ7stV/nTYdEVK3Z7yEJh4e+0SYVyuQ/g1r19uA4p6C0KTUTnd\nh+eRz0Fn+GIrqiGUh7T8RkXxXGA0NmBMFB9TEZNHBF2JB7mofa/QFfmWKDgSFAux\nS8+h8oqtVYFghc6QfcbuQku/uDXRgWkpXLqye53Vaipr0+2WeHgkfdOwj/k6IAb6\nVoIiWdDmITRmjSygu5cdDckFBq1ASMZalPGrDmKOFn9JmCIAgPVh1e05NhKS+PHe\n5CfkNRUOxVzA7cbBalEJ/b3j4V/zu8oqOx3EBXq4JFB9vo1qIUowPXyEVRj68qwp\nQZ3Gn+uJAgMBAAECgf9c2dxD/oP6VEX2EKJvFnCxDe0kO/bSJg4LjVDUT1Bhr2Ig\n2L5JJQcElUvK3Fnp4LOi2dR8tCzc0sUi9SLtPOPYKQB9E/TTi11lF7PePGGZPOqi\nlbJisuRIg4Y3NvuoyGIDxxWRFxYgZixxPPK8G7FQFBd93+mn6mx0Ov8iYyPlmuks\n3D6M+rtjP+73EsgrX8wOuCYbWUZZuGVlqu6VmHz3lUlySl4cmYHEgSAJDaQgE0YQ\npVK5ofekfnNtGaOyCHcGxMTyal2lJwcmWT4/L91NKbXF173xVDdvIQHHt+hapDh7\nJ3VDP1AVG3xSjPg5kNohKZ5GcXtNzqApFm5UIiECgYEA/irYeSOa9I32kP2CyG74\ni1vIx7z1Q4YZsj2sHxk97O4xvkTmFhnCTtVI5qwoHdqzp+OABqEY95yqhDdDKgHq\nhXd1CejeK0HCIS63Hl9Jmme3ClJyyx/TvTnrWSPA8gXopXnPBGV/DI1PukrExG2x\ncww3iFDRmZkRZhZqj39LMEUCgYEA4d1CCQStQvVh6wZzkT9GCyM7yynzJYYmVt5S\npgyqNLj4giKsXgI4/vDMY3Vrar0193wbOddZLealt6RSZSrZrCYxFE17X+zxkSpv\ntffOOq48Llw9XMDQJ7Sr5PhWUMXbam5PQ9WTh+/adcPLMWCT4Ylr/zgx+L9fB1v8\nRNILLHUCgYB7xwndFMXlyy0EtzD1w3UvCOfivdcDp07kSryD+Jr7w5ReANe8c5b5\nJU13aOewgk1zuYsjr1ilXZp9ARyoXH6FuQM6bDml/0Q3PLTZCbaih1fQow5cdYd8\nY7SFmK/iLZZ637M9hOA2kKr/ImJo9rKwQIbaz+EDWFPsz4XdlDRdsQKBgQCFAIWi\nSd69T0IZ4/Kp1ViptlW/jTRhJF3vSXvhzBNueH3eJAzcTvLBLYsuBjb64/Cji7F8\nnhMltGxhd6INcO49MUA1dGryUdTuZs7hmMsYQwGtSyPXOrNYrkuKybIKXniWc965\nU0tNATDjqCg/K1/pr8Kox66ljAupicFDxWxPAQKBgQCHFn/Me96/xWrLsCtR9Zlx\nLe/on74drSAmsvul7M+sUQEl8EXoQYqIgi+QYOj6Mf7mi/WNDxhnAo7QPxtPh5VS\nADybUAuZjHjeb1ZnngenlcOI/dzZzI7Lt23ZJPy+jFDdNspMofCoMDcElN8K9gr0\npqqdJLGZAerzhM0zMia4pA==\n-----END PRIVATE KEY-----\n";

            try
            {
                // Xác thực và tạo dịch vụ Drive API
                var credential = new ServiceAccountCredential(new ServiceAccountCredential.Initializer(serviceAccountEmail)
                {
                    Scopes = new[] { DriveService.Scope.Drive }
                }.FromPrivateKey(privateKey));

                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Sample",
                });

                // Xóa tệp từ Google Drive
                service.Files.Delete(fileId).Execute();
                MessageBox.Show("File deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void guna2ButtonDelete_Click(object sender, EventArgs e)
        {
            string url = textBoxSubmitted.Text;
            SqlCommand cmd = new SqlCommand("select * from Submission where Path = @url", mydb.getConnection);
            cmd.Parameters.AddWithValue("@url", url);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            mydb.openConnection();
            adapter.Fill(dt);
            mydb.closeConnection();
            delete(textBoxSubmitted.Text);
            submission.delete(Convert.ToInt32(dt.Rows[0][0].ToString()));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string chromePath = GetBrowserPath("chrome.exe");

            if (chromePath != null)
            {
                OpenLinkWithBrowser(chromePath, textBoxSubmitted.Text);
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

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ButtonSubmit_Click_1(object sender, EventArgs e)
        {
            if (textBoxSubmitted.Text != "")
                MessageBox.Show("Bạn đã nộp bài", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                FormNopBai formNopBai = new FormNopBai(studentMainForm, accessCourseForm);
                formNopBai.url = textBox2.Text;
                studentMainForm.OpenForm(formNopBai, formNopBai, studentMainForm);
            }
        }

        private void guna2ButtonDelete_Click_1(object sender, EventArgs e)
        {
            if (textBoxSubmitted.Text == "")
            {
                MessageBox.Show("Không có bài để xóa","Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string url = textBoxSubmitted.Text;
                SqlCommand cmd = new SqlCommand("select * from Submission where Path = @url", mydb.getConnection);
                cmd.Parameters.AddWithValue("@url", url);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                mydb.openConnection();
                adapter.Fill(dt);
                mydb.closeConnection();
                delete(textBoxSubmitted.Text);
                if (submission.delete(Convert.ToInt32(dt.Rows[0][0].ToString())))
                    textBoxSubmitted.Text = "";
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (textBoxSubmitted.Text == "")
            {
                MessageBox.Show("Không có bài", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string chromePath = GetBrowserPath("chrome.exe");

                if (chromePath != null)
                {
                    OpenLinkWithBrowser(chromePath, textBoxSubmitted.Text);
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
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            string chromePath = GetBrowserPath("chrome.exe");

            if (chromePath != null)
            {
                OpenLinkWithBrowser(chromePath, textBox2.Text);
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
    }
    }

