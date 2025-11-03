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
using System.Windows.Forms.DataVisualization.Charting;

namespace DACKW.admin.scoreButtons
{
    public partial class StaticScoreBtnForm : Form
    {
        Score score = new Score();
        MY_DB mydb = new MY_DB();
        public StaticScoreBtnForm()
        {
            InitializeComponent();
        }

        private void StaticScoreBtnForm_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Series series = new Series("Average Score By Course");

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select Course.name, avg(score.student_score) as AverageGrade from Course inner join score on Course.id= score.Course_id group by Course.name", mydb.getConnection);
            
            dt = score.getAvgScoreByCourse(cmd);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string course = dt.Rows[i][0].ToString();
                double score = 0;
                if (dt.Rows[i][1].ToString() != "")
                    score = Convert.ToDouble(dt.Rows[i][1].ToString());
                series.Points.AddXY(course, score);
            }
            chart1.Series.Add(series);
            chart1.Series["Average Score By Course"].ChartType = SeriesChartType.Column;
            chart1.ChartAreas[0].AxisX.Title = "Tên Khóa Học";
            chart1.ChartAreas[0].AxisY.Title = "Điểm";

            chart1.Update();
        }
    }
}
