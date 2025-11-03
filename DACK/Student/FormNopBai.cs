using DACKW.Teacher;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
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

namespace DACKW.Student
{
    public partial class FormNopBai : Form
    {
        string[] fileToUpload;
        Submission submission = new Submission();
        public string url;
        ThemBaiTapBtn themBaiTapBtn = new ThemBaiTapBtn();
        Announce announce = new Announce();
        Assignment assignment = new Assignment();
        static string fileUrl;
        public string FolderName;
        public static string fileName;
        DataTable dt = new DataTable();
        MY_DB mydb = new MY_DB();
        public FormNopBai()
        {
            InitializeComponent();
        }
        StudentMainForm studentMainForm;
        AccessCourseForm accessCourseForm;
        public FormNopBai(StudentMainForm studentMainForm, AccessCourseForm accessCourseForm)
        {
            InitializeComponent();
            this.accessCourseForm = accessCourseForm;
            this.studentMainForm = studentMainForm;
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
           
            accessCourseForm.AccessCourseForm_Load(sender, e);
            studentMainForm.OpenForm(accessCourseForm, this, studentMainForm);
        }
        private string[] BrowseFiles()
        {
            

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox2.Text = Path.GetFileName(openFileDialog.FileNames[0]);
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
        private void guna2Button2_Click(object sender, EventArgs e)
        {
           fileToUpload= BrowseFiles();
            //fileName = textBox1.Text;
            //string credentialsPath = "credentials.json";
            //string parentFolderId = "1bRdkClFCevAcQ98bXJaKUCiw2EUiKds3";
            //string folderName = FolderName;
            //string[] fileToUpload = BrowseFiles();
            //UploadFileToGoogleDrive(credentialsPath, parentFolderId, folderName, fileToUpload);

            //textBox2.Text = fileUrl;
        }

        private void FormNopBai_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Assignment where Path = @url", mydb.getConnection);
            cmd.Parameters.AddWithValue("@url", url);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            mydb.openConnection();
            adapter.Fill(dt);
            mydb.closeConnection();
            fileName = Globals.GlobaUserID.ToString() + " nop bai " + dt.Rows[0][2].ToString();
            FolderName = dt.Rows[0][1].ToString();
            textBox1.Text = fileName;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() == "" || textBox2.Text.Trim()=="")
                {
                    MessageBox.Show("Thiếu thông tin !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                fileName = textBox1.Text;
                string credentialsPath = "credentials.json";
                string parentFolderId = "1bRdkClFCevAcQ98bXJaKUCiw2EUiKds3";
                string folderName = FolderName;
                //fileToUpload = BrowseFiles();


                int id = Convert.ToInt32(dt.Rows[0][0].ToString());
                string name = Globals.GlobaUserID.ToString() + " nop bai " + dt.Rows[0][2].ToString();
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Thiếu thông tin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    UploadFileToGoogleDrive(credentialsPath, parentFolderId, folderName, fileToUpload);
                    if (submission.insert(id, Globals.GlobaUserID, name, fileUrl, DateTime.Now, 0, DBNull.Value.ToString()))
                    {
                        MessageBox.Show("Đã nộp bài", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Nộp bài không thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
