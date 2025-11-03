using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DACKW.admin.scoreButtons
{
    public partial class PrintResultBtnForm : Form
    {
        MY_DB mydb = new MY_DB();
        public PrintResultBtnForm()
        {
            InitializeComponent();
        }
        DataTable dt1 = new DataTable();
        private void guna2ButtonSearch_Click(object sender, EventArgs e)
        {
            dt1.Rows.Clear();
            //SqlCommand command = new SqlCommand("select * from " +
            //    "student " +
            //    "where concat(fname,lname,address) like '%" + textBoxSearch.Text + "%'");
            SqlCommand cmd = new SqlCommand("select StudentID,FirstName,LastName from " + "student " + "where concat(StudentID,FirstName) like '%" + textBoxSearch.Text + "%'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dt1);
            //dataGridView1.DataSource = dt1;
            DataTable dt2 = new DataTable();
            cmd = new SqlCommand("select name from Course", mydb.getConnection);
            mydb.openConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string columnName = dr["name"].ToString();

                if (!dt1.Columns.Contains(columnName))
                {
                    dt1.Columns.Add(columnName);
                }

            }
            mydb.closeConnection();
            if (!dt1.Columns.Contains("AverageScore") || !dt1.Columns.Contains("Result"))
            {
                dt1.Columns.Add("AverageScore");
                dt1.Columns.Add("Result");
            }



            // Lặp qua mỗi hàng trong dt1 để lấy điểm của từng sinh viên
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                string studentId = dt1.Rows[i]["StudentID"].ToString();
                string query = "select Course_id, student_score from score where Student_id = " + studentId;

                SqlCommand scoreCmd = new SqlCommand(query, mydb.getConnection);
                mydb.openConnection();
                SqlDataReader scoreReader = scoreCmd.ExecuteReader();
                double avg = 0;
                int count = 0;


                while (scoreReader.Read())
                {
                    count++;
                    string courseId = scoreReader["Course_id"].ToString();
                    double StudentScore = Convert.ToDouble(scoreReader["student_score"]);
                    dt1.Rows[i][courseId] = StudentScore.ToString();
                    if (Convert.ToDouble(scoreReader["student_score"]) != -1)
                        avg += Convert.ToDouble(scoreReader["student_score"]);
                }
                mydb.closeConnection();

                double average = (avg / count);


                if (!double.IsNaN(average))
                    dt1.Rows[i]["AverageScore"] = average.ToString();
                else dt1.Rows[i]["AverageScore"] = "";

                if (average < 3)
                {
                    dt1.Rows[i]["Result"] = "Fail";
                }
                else if (average >= 3 && average < 5) dt1.Rows[i]["Result"] = "Odinary";
                else if (average >= 5 && average < 8) dt1.Rows[i]["Result"] = "Good";
                else if (average >= 8) dt1.Rows[i]["Result"] = "Very Good";
                else dt1.Rows[i]["Result"] = "";

            }
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns["StudentID"].HeaderText = "MSSV";
            dataGridView1.Columns["FirstName"].HeaderText = "First Name";
            dataGridView1.Columns["LastName"].HeaderText = "Last Name";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells["StudentID"].Value.ToString();
            textBoxFirstName.Text = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
            textBoxLastName.Text = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
        }

        private void guna2ButtonPrintBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

                printPreviewDialog.Document = printDocument1;
                printPreviewDialog.ShowDialog();
            }
            else MessageBox.Show("Danh sách trống","Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        int mRow = 0;
        bool newPage = true;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int printWidth = 1000;

            System.Drawing.Image pictureBoxImage = pictureBox1.Image;

            Point pictureBoxLocation = new Point(0, 0);
            if (pictureBoxImage != null)
                e.Graphics.DrawImage(pictureBoxImage, new Rectangle(pictureBoxLocation, pictureBoxImage.Size));

            string textToPrint = label1.Text = "Khoa Công Nghệ Thông Tin" + "\n" + "Trường Đại Học Sư Phạm Kỹ Thuật" + "\n\n\n";

            Font printFont = new Font("Times New Roman", 25, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Black);
            float width = 800;
            float height = 400;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            RectangleF layoutRectangle = new RectangleF(150, 50, width, height);
            e.Graphics.DrawString(textToPrint, printFont, brush, layoutRectangle, stringFormat);

            layoutRectangle = new RectangleF(300, 300, width, height);
            e.Graphics.DrawString(label2.Text="Kết Quả Học Tập", printFont, brush, layoutRectangle);
            string chuThich = "Ho Chi Minh, Ngay...Thang...Nam..." + "\n " + "Chu Nhiem Khoa";
            layoutRectangle = new RectangleF(280, 1000, width, height);
            e.Graphics.DrawString(chuThich, printFont = new Font("Times New Roman", 15), brush, layoutRectangle, stringFormat);

            int x = 0;
            int y = 370;
            DataGridViewRow headerRow = dataGridView1.Rows[0];

            foreach (DataGridViewCell headerCell in headerRow.Cells)
            {
                if (headerCell.Visible)
                {
                    Rectangle headerRect = new Rectangle(x, y, headerCell.Size.Width, headerCell.Size.Height);
                    e.Graphics.FillRectangle(Brushes.Cyan, headerRect);
                    e.Graphics.DrawRectangle(Pens.Black, headerRect);
                    e.Graphics.DrawString(dataGridView1.Columns[headerCell.ColumnIndex].HeaderText,
                        dataGridView1.Font, Brushes.Black, headerRect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                    x += headerRect.Width;
                }
            }
            y += dataGridView1.Rows[0].Height;

            for (int i = mRow; i < dataGridView1.RowCount; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                x = 0;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Visible)
                    {
                        Rectangle cellRect = new Rectangle(x, y, cell.Size.Width, cell.Size.Height);
                        e.Graphics.FillRectangle(Brushes.LightGray, cellRect);
                        e.Graphics.DrawRectangle(Pens.Black, cellRect);
                        e.Graphics.DrawString(cell.FormattedValue.ToString(),
                            dataGridView1.Font, Brushes.Black, cellRect, new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                        x += cellRect.Width;
                    }
                }
                y += row.Height;
                if (y + row.Height > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    mRow = i + 1;
                    return;
                }
            }
            mRow = 0;
            newPage = true;

            // Đặt kích thước của trang in để phù hợp với chiều rộng được chỉ định
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", printWidth, e.PageBounds.Height);
        }
    }
}
