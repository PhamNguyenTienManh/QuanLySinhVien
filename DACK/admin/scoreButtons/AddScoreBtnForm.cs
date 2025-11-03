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

namespace DACKW.admin.scoreButtons
{
    public partial class AddScoreBtnForm : Form
    {
        MY_DB mydb = new MY_DB();
        Score score = new Score();
        DataTable dt = new DataTable();
        public AddScoreBtnForm()
        {
            InitializeComponent();
        }
        AdminForm adminForm;
        ScoreButtonForm scoreButtonForm;
        public AddScoreBtnForm(AdminForm adminForm, ScoreButtonForm scoreButtonForm)
        {
            InitializeComponent();
            this.scoreButtonForm = scoreButtonForm;
            this.adminForm = adminForm;
        }

        private void AddScoreBtnForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from course", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            mydb.openConnection();
            adapter.Fill(dt);
            mydb.closeConnection();
            guna2ComboBox1.DataSource = dt;
            guna2ComboBox1.DisplayMember = "name";
            guna2ComboBox1.ValueMember = "id";
           // guna2ComboBox1.SelectedItem = null;
        }
        public float DTB(int studentID, string courseID)
        {
            SqlCommand cmd = new SqlCommand("select * from Submission inner join Assignment on Submission.AssignmentID=Assignment.ID where StudentID = @sid and CourseID=@cid", mydb.getConnection);
            cmd.Parameters.AddWithValue("@sid", studentID);
            cmd.Parameters.AddWithValue("@cid", courseID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            mydb.openConnection();
            adapter.Fill(table);
            mydb.closeConnection();
            float DTB = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                //MessageBox.Show(dt.Rows[i]["Grade"].ToString());
                if (table.Rows[i]["Grade"].ToString() != "")
                    DTB += float.Parse(table.Rows[i]["Grade"].ToString());
                
            }
            if (table.Rows.Count > 0)
                DTB /= table.Rows.Count;
            else DTB = 0;
            return DTB;
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select studentID, firstname,lastname from score inner join student on score.student_id=student.StudentID where course_id=@cid", mydb.getConnection);
            cmd.Parameters.AddWithValue("@cid", guna2ComboBox1.SelectedValue.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            mydb.openConnection();
            adapter.Fill(dt);
            mydb.closeConnection();
 // Khởi tạo DataTable
            dt.Columns.Add("Average Score");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["Average Score"] = DTB(Convert.ToInt32(dt.Rows[i][0]), guna2ComboBox1.SelectedValue.ToString());
            }
            guna2DataGridView1.DataSource = dt;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                string des = "";
                for (int i = 0; i < guna2DataGridView1.Rows.Count; i++)
                {
                    string courseID = guna2ComboBox1.SelectedValue.ToString();
                    if (DTB(Convert.ToInt32(dt.Rows[i][0]), guna2ComboBox1.SelectedValue.ToString()) >= 5)
                        des = "Pass";
                    else
                        des = "Fail";

                    // score.update(Convert.ToInt32(dt.Rows[i][0].ToString()), float.Parse(dt.Rows[i]["Average Score"].ToString()), des);
                    if (score.update(Convert.ToInt32(dt.Rows[i][0].ToString()),courseID, float.Parse(dt.Rows[i]["Average Score"].ToString()), des))
                        MessageBox.Show("Lưu điểm thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Lưu điểm không thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            //}
            //catch (Exception ex) 
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            
        }
    }
}
