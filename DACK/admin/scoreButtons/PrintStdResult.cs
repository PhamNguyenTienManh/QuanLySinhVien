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
    public partial class PrintStdResult : Form
    {

        MY_DB mydb = new MY_DB();
        Score score = new Score();
        DataTable dt = new DataTable();
        int mRow = 0;
        bool newPage = true;
        public PrintStdResult()
        {
            InitializeComponent();
        }

        private void PrintStdResult_Load(object sender, EventArgs e)
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
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select Student_id, FirstName, LastName, Student_score, Description from score inner join student on score.student_id=student.StudentID where course_id=@cid", mydb.getConnection);
            cmd.Parameters.AddWithValue("@cid", guna2ComboBox1.SelectedValue.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            mydb.openConnection();
            adapter.Fill(dt);
            mydb.closeConnection();
            // Khởi tạo DataTable
            
            guna2DataGridView1.DataSource = dt;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string course = "";
            string teacher = "";
            SqlCommand cmd = new SqlCommand("Select course_id, name, TeacherID, FirstName, LastName\r\nFrom Course inner join ( Select TeacherID,course_id,FirstName, LastName\r\n\t\t\t\t\t\tFrom curriculum inner join Teacher\r\n\t\t\t\t\t\tOn curriculum.teacher_id = Teacher.TeacherID\r\n\t\t\t\t\t\t) Q\r\nOn Course.id = Q.course_id\r\nWhere course_id = @cid", mydb.getConnection);
            cmd.Parameters.AddWithValue("@cid", guna2ComboBox1.SelectedValue.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            mydb.openConnection();
            adapter.Fill(dt);
            mydb.closeConnection();
            if (dt.Rows.Count > 0)
            {
                course = dt.Rows[0][0].ToString();
                teacher = dt.Rows[0][3].ToString() +" "+ dt.Rows[0][4].ToString() ;
            }
            
            int printWidth = 1000;

            Image pictureBoxImage = pictureBox1.Image;
            Point pictureBoxLocation = new Point(0, 0);
            if (pictureBoxImage != null)
                e.Graphics.DrawImage(pictureBoxImage, new Rectangle(pictureBoxLocation, pictureBoxImage.Size));

            string textToPrint =  "\n" + "Trường Đại Học Sư Phạm Kỹ Thuật" + "\n\n\n";

            Font printFont = new Font("Times New Roman", 25, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Black);
            float width = 800;
            float height = 400;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            RectangleF layoutRectangle = new RectangleF(150, 50, width, height);
            e.Graphics.DrawString(textToPrint, printFont, brush, layoutRectangle, stringFormat);

            layoutRectangle = new RectangleF(280, 150, width, height);
            e.Graphics.DrawString("Mã khóa học: "+course + "\n" +"Tên giáo viên: "+ teacher, printFont, brush, layoutRectangle);
            string chuThich = "Ho Chi Minh, Ngay...Thang...Nam..." + "\n " + "Chu Nhiem Khoa";
            layoutRectangle = new RectangleF(280, 1000, width, height);
            e.Graphics.DrawString(chuThich, printFont = new Font("Times New Roman", 15), brush, layoutRectangle, stringFormat);

            int x = 0;
            int y = 370;
            DataGridViewRow headerRow = guna2DataGridView1.Rows[0];

            foreach (DataGridViewCell headerCell in headerRow.Cells)
            {
                if (headerCell.Visible)
                {
                    Rectangle headerRect = new Rectangle(x+60, y, headerCell.Size.Width, headerCell.Size.Height);
                    e.Graphics.FillRectangle(Brushes.Cyan, headerRect);
                    e.Graphics.DrawRectangle(Pens.Black, headerRect);
                    e.Graphics.DrawString(guna2DataGridView1.Columns[headerCell.ColumnIndex].HeaderText,
                        guna2DataGridView1.Font, Brushes.Black, headerRect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                    x += headerRect.Width;
                }
            }
            y += guna2DataGridView1.Rows[0].Height;

            for (int i = mRow; i < guna2DataGridView1.RowCount; i++)
            {
                DataGridViewRow row = guna2DataGridView1.Rows[i];
                x = 0;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Visible)
                    {
                        Rectangle cellRect = new Rectangle(x+60, y, cell.Size.Width, cell.Size.Height);
                        e.Graphics.FillRectangle(Brushes.LightGray, cellRect);
                        e.Graphics.DrawRectangle(Pens.Black, cellRect);
                        e.Graphics.DrawString(cell.FormattedValue.ToString(),
                            guna2DataGridView1.Font, Brushes.Black, cellRect, new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
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
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", printWidth + 1000, e.PageBounds.Height);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.Rows.Count > 0)
            {
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

                printPreviewDialog.Document = printDocument1;
                printPreviewDialog.Width = 1000;
                printPreviewDialog.ShowDialog();
            }
            else
                MessageBox.Show("Danh sách trống", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
