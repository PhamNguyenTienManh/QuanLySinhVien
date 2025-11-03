namespace DACKW.admin.scoreButtons
{
    partial class PrintResultBtnForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintResultBtnForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labellname = new System.Windows.Forms.Label();
            this.labelfname = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ButtonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonPrintBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(477, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(817, 275);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(23, 378);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(307, 26);
            this.textBoxSearch.TabIndex = 19;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(215, 267);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(163, 26);
            this.textBoxLastName.TabIndex = 18;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(215, 198);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(163, 26);
            this.textBoxFirstName.TabIndex = 17;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(215, 129);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(163, 26);
            this.textBoxID.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Search By ID, First Name:";
            // 
            // labellname
            // 
            this.labellname.AutoSize = true;
            this.labellname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellname.Location = new System.Drawing.Point(18, 263);
            this.labellname.Name = "labellname";
            this.labellname.Size = new System.Drawing.Size(144, 29);
            this.labellname.TabIndex = 14;
            this.labellname.Text = "Last Name:";
            // 
            // labelfname
            // 
            this.labelfname.AutoSize = true;
            this.labelfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfname.Location = new System.Drawing.Point(18, 194);
            this.labelfname.Name = "labelfname";
            this.labelfname.Size = new System.Drawing.Size(148, 29);
            this.labelfname.TabIndex = 13;
            this.labelfname.Text = "First Name:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(18, 129);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(141, 29);
            this.labelID.TabIndex = 12;
            this.labelID.Text = "Student ID:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DACKW.Properties.Resources.logo_hcmute1;
            this.pictureBox1.Location = new System.Drawing.Point(477, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // guna2ButtonSearch
            // 
            this.guna2ButtonSearch.Animated = true;
            this.guna2ButtonSearch.BorderRadius = 15;
            this.guna2ButtonSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2ButtonSearch.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonSearch.Image = global::DACKW.Properties.Resources.search1;
            this.guna2ButtonSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButtonSearch.Location = new System.Drawing.Point(100, 449);
            this.guna2ButtonSearch.Name = "guna2ButtonSearch";
            this.guna2ButtonSearch.Size = new System.Drawing.Size(152, 65);
            this.guna2ButtonSearch.TabIndex = 23;
            this.guna2ButtonSearch.Text = "Search";
            this.guna2ButtonSearch.Click += new System.EventHandler(this.guna2ButtonSearch_Click);
            // 
            // guna2ButtonPrintBtn
            // 
            this.guna2ButtonPrintBtn.Animated = true;
            this.guna2ButtonPrintBtn.BorderRadius = 15;
            this.guna2ButtonPrintBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonPrintBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonPrintBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonPrintBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonPrintBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2ButtonPrintBtn.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonPrintBtn.Image = global::DACKW.Properties.Resources.save1;
            this.guna2ButtonPrintBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButtonPrintBtn.Location = new System.Drawing.Point(797, 449);
            this.guna2ButtonPrintBtn.Name = "guna2ButtonPrintBtn";
            this.guna2ButtonPrintBtn.Size = new System.Drawing.Size(152, 65);
            this.guna2ButtonPrintBtn.TabIndex = 22;
            this.guna2ButtonPrintBtn.Text = "Print";
            this.guna2ButtonPrintBtn.Click += new System.EventHandler(this.guna2ButtonPrintBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "label5";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(713, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // PrintResultBtnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 546);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2ButtonSearch);
            this.Controls.Add(this.guna2ButtonPrintBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labellname);
            this.Controls.Add(this.labelfname);
            this.Controls.Add(this.labelID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintResultBtnForm";
            this.Text = "PrintResultBtnForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labellname;
        private System.Windows.Forms.Label labelfname;
        private System.Windows.Forms.Label labelID;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonPrintBtn;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonSearch;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}