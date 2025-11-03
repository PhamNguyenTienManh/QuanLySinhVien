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
    public partial class AvgScoreBtnForm : Form
    {
        Score score = new Score();
        MY_DB mydb = new MY_DB();
        public AvgScoreBtnForm()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int semester = Convert.ToInt32(guna2ComboBox1.SelectedItem.ToString());
            SqlCommand cmd = new SqlCommand("select Course.name as Name, avg(score.student_score) as [Average Grade] from Course inner join score on Course.id= score.Course_id where Course.semester = @se group by Course.name", mydb.getConnection);
            cmd.Parameters.Add("@se", SqlDbType.Int).Value = semester;
            dataGridView1.DataSource = score.getAvgScoreByCourse(cmd);
        }

        private void AvgScoreBtnForm_Load(object sender, EventArgs e)
        {

        }
    }
}
