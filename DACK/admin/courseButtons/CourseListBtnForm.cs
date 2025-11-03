using Guna.UI2.WinForms;
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

namespace DACKW.admin.courseButtons
{
    public partial class CourseListBtnForm : Form
    {
        public CourseListBtnForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        DataTable table = new DataTable();
        int mRow = 0;
        bool newPage = true;
        private void CourseListBtnForm_Load(object sender, EventArgs e)
        {
            string query = "Select * From Course";
            SqlCommand cmd = new SqlCommand(query);
            table = course.getCourses(cmd);
            dataGridView1.DataSource = table;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns["id"].HeaderText = "Course ID";
            dataGridView1.Columns["name"].HeaderText = "Course Name";
            dataGridView1.Columns["period"].HeaderText = "Số Tiết";
            dataGridView1.Columns["description"].HeaderText = "Description";
            //dataGridView1.Columns["doc"].HeaderText = "Document";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            

            int printWidth = 1000;

            Image pictureBoxImage = pictureBox1.Image;
            Point pictureBoxLocation = new Point(0, 0);
            if (pictureBoxImage != null)
                e.Graphics.DrawImage(pictureBoxImage, new Rectangle(pictureBoxLocation, pictureBoxImage.Size));

            string textToPrint = "\n" + "Trường Đại Học Sư Phạm Kỹ Thuật" + "\n\n\n";

            Font printFont = new Font("Times New Roman", 25, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Black);
            float width = 800;
            float height = 400;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            RectangleF layoutRectangle = new RectangleF(150, 50, width, height);
            e.Graphics.DrawString(textToPrint, printFont, brush, layoutRectangle, stringFormat);

            layoutRectangle = new RectangleF(220, 270, width, height);
            e.Graphics.DrawString("Danh sách các khóa học", printFont = new Font("Times New Roman", 30, FontStyle.Bold), brush, layoutRectangle);
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
                    Rectangle headerRect = new Rectangle(x + 160, y, headerCell.Size.Width, headerCell.Size.Height);
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
                        Rectangle cellRect = new Rectangle(x + 160, y, cell.Size.Width, cell.Size.Height);
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
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", printWidth + 1000, e.PageBounds.Height);
        }

        private void guna2ButtonPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
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
