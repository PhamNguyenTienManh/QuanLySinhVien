using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACKW.Student
{
    public partial class UpdatePasswordForm : Form
    {
        public UpdatePasswordForm()
        {
            InitializeComponent();
        }
        StudentMainForm studentMainForm;
        MY_DB db = new MY_DB();
        Login login = new Login();  
        
        public UpdatePasswordForm(StudentMainForm studentMainForm)
        {
            InitializeComponent();
            this.studentMainForm = studentMainForm;
        }

        private void guna2ButtonCancel_Click(object sender, EventArgs e)
        {
            studentMainForm.OpenForm(new accountStudent(studentMainForm), studentMainForm);
        }
        string username;
        bool checkPassWord (string password)
        {
            String query = "Select studentID, username " +
                "From student inner join login " +
                "On student.email = login.mail " +
                "Where studentID = @stdID and password = @pw ";
            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            cmd.Parameters.Add("@stdID", SqlDbType.Int).Value = Globals.GlobaUserID;
            cmd.Parameters.Add("@pw", SqlDbType.NVarChar).Value = password;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                username = table.Rows[0]["username"].ToString();
                return true;
            }
            else
            { return false; }
        }
        bool verif()
        {
            if (guna2TextBoxOldPass.Text.Trim() == ""
                        || guna2TextBoxNewPass.Text.Trim() == ""
                        || guna2TextBoxReNewPass.Text.Trim() == "")
                        
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        bool checkRePassword (string a, string b)
        {
            if (a == b)
                return true;
            else
            { return false; }
        }

        private void guna2ButtonAccept_Click(object sender, EventArgs e)
        {
           
                if (verif())
                {
                    if (checkPassWord(guna2TextBoxOldPass.Text))
                    {
                        if (checkRePassword(guna2TextBoxNewPass.Text, guna2TextBoxReNewPass.Text))
                        {
                            if (login.updateAccount(username, guna2TextBoxNewPass.Text))
                            {
                                MessageBox.Show("Thay đổi mật khẩu thành công", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu chưa thể thay đổi", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không trùng khớp!", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không đúng!", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lack of information", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            
           
        }
    }
}
