namespace DACKW.admin.teacherButtons
{
    partial class CourseTeacherBtnForm
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
            this.guna2ComboBoxSemester = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2TextBoxTeacherName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxTeacherID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2ButtonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ComboBoxSemester
            // 
            this.guna2ComboBoxSemester.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxSemester.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxSemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxSemester.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBoxSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBoxSemester.ItemHeight = 30;
            this.guna2ComboBoxSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.guna2ComboBoxSemester.Location = new System.Drawing.Point(710, 209);
            this.guna2ComboBoxSemester.Name = "guna2ComboBoxSemester";
            this.guna2ComboBoxSemester.Size = new System.Drawing.Size(259, 36);
            this.guna2ComboBoxSemester.TabIndex = 26;
            this.guna2ComboBoxSemester.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBoxSemester_SelectedIndexChanged_1);
            // 
            // guna2TextBoxTeacherName
            // 
            this.guna2TextBoxTeacherName.Animated = true;
            this.guna2TextBoxTeacherName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxTeacherName.DefaultText = "";
            this.guna2TextBoxTeacherName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxTeacherName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxTeacherName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxTeacherName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxTeacherName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxTeacherName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxTeacherName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxTeacherName.Location = new System.Drawing.Point(696, 98);
            this.guna2TextBoxTeacherName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.guna2TextBoxTeacherName.Name = "guna2TextBoxTeacherName";
            this.guna2TextBoxTeacherName.PasswordChar = '\0';
            this.guna2TextBoxTeacherName.PlaceholderText = "Tên giảng viên";
            this.guna2TextBoxTeacherName.ReadOnly = true;
            this.guna2TextBoxTeacherName.SelectedText = "";
            this.guna2TextBoxTeacherName.Size = new System.Drawing.Size(260, 65);
            this.guna2TextBoxTeacherName.TabIndex = 22;
            // 
            // guna2TextBoxTeacherID
            // 
            this.guna2TextBoxTeacherID.Animated = true;
            this.guna2TextBoxTeacherID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxTeacherID.DefaultText = "";
            this.guna2TextBoxTeacherID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxTeacherID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxTeacherID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxTeacherID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxTeacherID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxTeacherID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxTeacherID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxTeacherID.Location = new System.Drawing.Point(696, 25);
            this.guna2TextBoxTeacherID.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.guna2TextBoxTeacherID.Name = "guna2TextBoxTeacherID";
            this.guna2TextBoxTeacherID.PasswordChar = '\0';
            this.guna2TextBoxTeacherID.PlaceholderText = "Mã giảng viên";
            this.guna2TextBoxTeacherID.ReadOnly = true;
            this.guna2TextBoxTeacherID.SelectedText = "";
            this.guna2TextBoxTeacherID.Size = new System.Drawing.Size(260, 75);
            this.guna2TextBoxTeacherID.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(705, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Học Kì:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(652, 514);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // guna2ButtonAdd
            // 
            this.guna2ButtonAdd.Animated = true;
            this.guna2ButtonAdd.BorderRadius = 15;
            this.guna2ButtonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonAdd.Image = global::DACKW.Properties.Resources.add;
            this.guna2ButtonAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButtonAdd.Location = new System.Drawing.Point(1092, 98);
            this.guna2ButtonAdd.Name = "guna2ButtonAdd";
            this.guna2ButtonAdd.Size = new System.Drawing.Size(180, 65);
            this.guna2ButtonAdd.TabIndex = 28;
            this.guna2ButtonAdd.Text = "Thêm";
            this.guna2ButtonAdd.Click += new System.EventHandler(this.guna2ButtonAdd_Click);
            // 
            // guna2ButtonDelete
            // 
            this.guna2ButtonDelete.Animated = true;
            this.guna2ButtonDelete.BorderRadius = 15;
            this.guna2ButtonDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonDelete.Image = global::DACKW.Properties.Resources.trash2;
            this.guna2ButtonDelete.Location = new System.Drawing.Point(1092, 290);
            this.guna2ButtonDelete.Name = "guna2ButtonDelete";
            this.guna2ButtonDelete.Size = new System.Drawing.Size(180, 65);
            this.guna2ButtonDelete.TabIndex = 27;
            this.guna2ButtonDelete.Text = "Xóa";
            this.guna2ButtonDelete.Click += new System.EventHandler(this.guna2ButtonDelete_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(710, 299);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 184);
            this.listBox1.TabIndex = 41;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(706, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Khóa Học:";
            // 
            // CourseTeacherBtnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 566);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2ButtonAdd);
            this.Controls.Add(this.guna2ButtonDelete);
            this.Controls.Add(this.guna2ComboBoxSemester);
            this.Controls.Add(this.guna2TextBoxTeacherName);
            this.Controls.Add(this.guna2TextBoxTeacherID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseTeacherBtnForm";
            this.Text = "CourseTeacherBtnForm";
            this.Load += new System.EventHandler(this.CourseTeacherBtnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAdd;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonDelete;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxSemester;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxTeacherName;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxTeacherID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}