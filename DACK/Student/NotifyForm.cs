using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class NotifyForm : Form
    {
        MY_DB mydb = new MY_DB();
        DataTable dt1 = new DataTable();
        public NotifyForm()
        {
            InitializeComponent();
        }

        private void NotifyClass_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select CONCAT(FirstName, ' ', LastName) AS [Nguoi Gui], Title as [Tieu De],Date as [Thoi Gian], Text from (select announce.TeacherID, CourseID,Title,Text,Date, FirstName,LastName  from announce inner join Teacher on announce.TeacherID=Teacher.TeacherID where type = 'Teacher') Q inner join Score on Q.CourseID = Score.Course_id where student_id = @sid", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@sid", Globals.GlobaUserID);
            mydb.openConnection();
            adapter.Fill(dt1);
            mydb.closeConnection();
            guna2DataGridView1.DataSource = dt1;
            guna2DataGridView1.Columns[3].Visible = false;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
