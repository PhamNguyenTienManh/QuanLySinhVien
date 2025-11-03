using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawingFont = System.Drawing.Font;
using ITextSharpFont = iTextSharp.text.Font;

namespace DACKW.admin.teacherButtons
{
    public partial class ListTeacherBtnForm : Form
    {
        TEACHER teacher = new TEACHER();
        MY_DB mydb = new MY_DB();
        public ListTeacherBtnForm()
        {
            InitializeComponent();
        }

        private void ListTeacherBtnForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Teacher", mydb.getConnection);
            guna2DataGridView1.DataSource = teacher.getTeacher(cmd);
            guna2DataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            guna2DataGridView1.RowTemplate.Height = 80;            
            picCol = (DataGridViewImageColumn)guna2DataGridView1.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            guna2DataGridView1.AllowUserToAddRows = false;
        }
        public bool checkID(string id)
        {
            SqlCommand cmd = new SqlCommand("select * from Teacher where TeacherID = @tid", mydb.getConnection);
            cmd.Parameters.AddWithValue("@tid", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            mydb.openConnection();
            adapter.Fill(dt);
            mydb.closeConnection();
            if (dt.Rows.Count > 0)
                return true;
            else return false;
        }
        private void guna2ButtonSave_Click(object sender, EventArgs e)
        {
            bool add = false;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                string id = row.Cells[0].Value.ToString();
                string firstName = row.Cells[1].Value.ToString();
                string lastName = row.Cells[2].Value.ToString();
                DateTime birthDay = (DateTime)row.Cells[3].Value;
                string Email = row.Cells[8].Value.ToString();
                //try
                //{
                if (checkID(id))
                {
                    MessageBox.Show("Trùng ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else if (teacher.insertTeacher(id, firstName, lastName, birthDay, Email))
                {
                    add = true;

                }
                //}
                //catch { }
            }
            if (add == true)
            {
                MessageBox.Show("Danh sách sinh viên thêm thành công:", "ADD STUDENT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể thêm giáo viên", "ADD TEACHER", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ButtonPrint_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "teacherList";
                bool errorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)
                {

                    using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                    {
                        Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                        PdfWriter.GetInstance(document, fileStream);
                        document.Open();



                        // Create a table with 2 columns
                        PdfPTable table = new PdfPTable(2);
                        table.WidthPercentage = 100;

                        float[] columnWidth = { 1f, 3f };
                        table.SetWidths(columnWidth);

                        // Create an image object
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\Users\Dell\OneDrive\Desktop\DACKmoinhat\DACKmoinhat\DACK\Resources\logo-hcmute.jpg");
                        logo.ScaleAbsolute(100f, 100f);

                        // Add image to a cell and add the cell to the table
                        PdfPCell imageCell = new PdfPCell(logo);
                        imageCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        table.AddCell(imageCell);

                        // Create a paragraph for the title
                        Paragraph title1 = new Paragraph();
                        ITextSharpFont font2 = new ITextSharpFont(ITextSharpFont.FontFamily.HELVETICA, 30f, ITextSharpFont.BOLD, BaseColor.RED);
                        title1.Add(new Phrase("Ho Chi Minh University of Technology and Education", font2));
                        //  title1.Alignment = Element.ALIGN_LEFT;

                        // Add title paragraph to a cell and add the cell to the table
                        PdfPCell textCell = new PdfPCell(title1);
                        textCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        textCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        table.AddCell(textCell);

                        // Add spacing before and after
                        title1.SpacingBefore = 10f;
                        title1.SpacingAfter = 20;

                        // Add table to document
                        document.Add(table);


                        ITextSharpFont font3 = new ITextSharpFont(ITextSharpFont.FontFamily.HELVETICA, 20f, ITextSharpFont.BOLD);
                        //Add title to the PDF document 
                        Paragraph title = new Paragraph("DANH SACH GIAO VIEN", font3);
                        title.Alignment = Element.ALIGN_CENTER;

                        //Thiet lap khoang cach le tren va le duoi
                        title.SpacingBefore = 20f;
                        title.SpacingAfter = 40f;

                        document.Add(title);

                        PdfPTable pTable = new PdfPTable(guna2DataGridView1.Columns.Count);
                        pTable.DefaultCell.Padding = 2;
                        pTable.WidthPercentage = 100;
                        pTable.HorizontalAlignment = Element.ALIGN_CENTER;

                        float[] columnWidths = new float[guna2DataGridView1.Columns.Count];
                        float equalWidth = 100f / guna2DataGridView1.Columns.Count; // Calculate equal width for each column
                        for (int i = 0; i < guna2DataGridView1.Columns.Count; i++)
                        {
                            columnWidths[i] = equalWidth; // Set equal width for each column
                        }
                        pTable.SetWidths(columnWidths);

                        ITextSharpFont font1 = new ITextSharpFont(ITextSharpFont.FontFamily.HELVETICA, 9f, ITextSharpFont.BOLD, BaseColor.BLUE);
                        // Add column headers to the PDF table
                        foreach (DataGridViewColumn col in guna2DataGridView1.Columns)
                        {
                            PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText, font1));
                            pCell.BackgroundColor = new BaseColor(System.Drawing.Color.LightGray);
                            pCell.Padding = 5;
                            pCell.HorizontalAlignment = Element.ALIGN_CENTER;
                            pTable.AddCell(pCell);
                        }

                        //set Font
                        ITextSharpFont font = new ITextSharpFont(
                         BaseFont.CreateFont(@"C:\Users\Dell\Documents\Zalo Received Files\Roboto\Roboto-Regular.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED),
                        8f,
                      iTextSharp.text.Font.NORMAL,
                         BaseColor.BLACK
                         );

                        // Add rows and cells to the PDF table
                        foreach (DataGridViewRow viewRow in guna2DataGridView1.Rows)
                        {
                            foreach (DataGridViewCell cell in viewRow.Cells)
                            {
                                if (cell.ColumnIndex == guna2DataGridView1.Columns.Count - 3) // Check if last column
                                {
                                    // Handle image cell
                                    if (cell.Value != DBNull.Value && cell.Value != null)
                                    {
                                        // Convert image to iTextSharp Image
                                        byte[] imageData = (byte[])cell.Value;
                                        iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imageData);
                                        pTable.AddCell(image);
                                    }
                                    else
                                    {
                                        pTable.AddCell(""); // Add empty cell if image is null
                                    }
                                }
                                else if (cell.ColumnIndex == 3)
                                {
                                    PdfPCell contentCell = new PdfPCell(new Phrase(((DateTime)cell.Value).ToString("yyyy-MM-dd"), font));
                                    pTable.AddCell(contentCell);
                                }
                                else
                                {
                                    PdfPCell contentCell = new PdfPCell(new Phrase(cell.Value?.ToString(), font));
                                    contentCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                    pTable.AddCell(contentCell); // Handle other cells
                                }
                            }
                        }

                        document.Add(pTable);



                        //Add title to the PDF document 
                        Paragraph ending = new Paragraph("Tp.HCM, day...month...year 2024", font);
                        ending.Alignment = Element.ALIGN_RIGHT;

                        //Thiet lap khoang cach le tren va le duoi
                        ending.SpacingBefore = 20f;

                        document.Add(ending);

                        ITextSharpFont font5 = new ITextSharpFont(ITextSharpFont.FontFamily.HELVETICA, 25f, ITextSharpFont.BOLDITALIC, BaseColor.RED);
                        Paragraph sign = new Paragraph("MANH      ", font5);
                        sign.Alignment = Element.ALIGN_RIGHT;
                        sign.SpacingBefore = 15f;
                        document.Add(sign);

                        ITextSharpFont font4 = new ITextSharpFont(ITextSharpFont.FontFamily.HELVETICA, 20f, ITextSharpFont.BOLDITALIC, BaseColor.DARK_GRAY);
                        Paragraph hoTen = new Paragraph("Pham Nguyen Tien Manh", font4);
                        hoTen.Alignment = Element.ALIGN_RIGHT;

                        hoTen.SpacingBefore = 15f;

                        document.Add(hoTen);

                        document.Close();
                    }
                    MessageBox.Show("Data Printed Successfully", "Info");

                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }

        }

        private void guna2ButtonImport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = null;
            Workbook xlWorkbook = null;
            Worksheet xlWorksheet = null;
            Range xlRange = null;

            string strFilename;
            openFD.Filter = "Excel Office |*.xls; *.xlsx";
            openFD.ShowDialog();
            strFilename = openFD.FileName;


            if (strFilename != "")
            {
                try
                {
                    xlApp = new Microsoft.Office.Interop.Excel.Application();
                    xlWorkbook = xlApp.Workbooks.Open(strFilename);
                    xlWorksheet = xlWorkbook.Worksheets[1]; // Assuming the first sheet, change if needed
                    xlRange = xlWorksheet.UsedRange;

                    // Create a DataTable to hold the imported data
                    System.Data.DataTable dataTable = new System.Data.DataTable();

                    // Add columns to the DataTable

                    dataTable.Columns.Add("Teacher ID");
                    dataTable.Columns.Add("First Name");
                    dataTable.Columns.Add("Last Name");
                    dataTable.Columns.Add("Birth Date", typeof(DateTime));
                    dataTable.Columns.Add("Gender");
                    dataTable.Columns.Add("Phone");
                    dataTable.Columns.Add("Address");
                    dataTable.Columns.Add("Avatar", typeof(byte[]));
                    dataTable.Columns.Add("Email");

                    Regex regex = new Regex("[^a-zA-Z ]");

                    // Loop through Excel data and populate DataTable
                    for (int row = 2; row <= xlRange.Rows.Count; row++)
                    {
                        DataRow newRow = dataTable.NewRow();

                        //newRow["id"] = xlRange.Cells[row, 3].Value != null ? xlRange.Cells[row, 3].Value.ToString() : "";
                        string idStr = xlRange.Cells[row, 3].Value != null ? xlRange.Cells[row, 3].Value.ToString() : "";

                        //if (int.TryParse(idStr, out id))
                        //{
                        newRow["Teacher ID"] = idStr;
                        string fname = xlRange.Cells[row, 4].Value != null ? xlRange.Cells[row, 4].Value.ToString() : "";
                        string lname = xlRange.Cells[row, 5].Value != null ? xlRange.Cells[row, 5].Value.ToString() : "";
                        fname = regex.Replace(fname, ""); // Loại bỏ các ký tự không phù hợp từ fname
                        lname = regex.Replace(lname, ""); // Loại bỏ các ký tự không phù hợp từ lname

                        newRow["First Name"] = fname;
                        newRow["Last Name"] = lname;


                        //newRow["fname"] = xlRange.Cells[row, 4].Value != null ? xlRange.Cells[row, 4].Value.ToString() : "";
                        //newRow["lname"] = xlRange.Cells[row, 5].Value != null ? xlRange.Cells[row, 5].Value.ToString() : "";

                        string dateFormat = "dd/MM/yyyy";
                        DateTime dateValue = DateTime.MinValue;
                        if (xlRange.Cells[row, 6].Value != null && DateTime.TryParseExact(xlRange.Cells[row, 6].Value.ToString(), dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue))
                        {
                            newRow["Birth Date"] = dateValue;
                        }

                        newRow["Gender"] = ""; // Placeholder for Gender
                        newRow["Phone"] = ""; // Placeholder for Phone
                        newRow["Address"] = ""; // Placeholder for Address
                        newRow["Avatar"] = DBNull.Value; // Placeholder for Picture
                        newRow["Email"] = xlRange.Cells[row, 7].Value != null ? xlRange.Cells[row, 7].Value.ToString() : "";



                        dataTable.Rows.Add(newRow.ItemArray); // Use ItemArray to avoid "this row already belongs to this table" error
                    
                    }

                    // Bind the DataTable to the DataGridView
                    guna2DataGridView1.DataSource = dataTable;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            
        }
    }
}
