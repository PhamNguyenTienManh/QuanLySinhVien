namespace DACKW
{
    partial class UserControlBaiTapDaDang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.richTextBoxDes = new System.Windows.Forms.RichTextBox();
            this.guna2TextBoxFilePath = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxAssignmentName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(1091, 185);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(57, 29);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Xóa";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Đường dẫn:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tên bài tập:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.Enabled = false;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.Cyan;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(678, 34);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(397, 35);
            this.guna2DateTimePicker1.TabIndex = 22;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 5, 2, 14, 43, 3, 910);
            this.guna2DateTimePicker1.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Deadline:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel1.Controls.Add(this.richTextBoxDes);
            this.guna2Panel1.Controls.Add(this.guna2TextBoxFilePath);
            this.guna2Panel1.Controls.Add(this.guna2TextBoxAssignmentName);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.linkLabel1);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.guna2DateTimePicker1);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1172, 232);
            this.guna2Panel1.TabIndex = 18;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // richTextBoxDes
            // 
            this.richTextBoxDes.Location = new System.Drawing.Point(678, 105);
            this.richTextBoxDes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxDes.Name = "richTextBoxDes";
            this.richTextBoxDes.ReadOnly = true;
            this.richTextBoxDes.Size = new System.Drawing.Size(397, 109);
            this.richTextBoxDes.TabIndex = 30;
            this.richTextBoxDes.Text = " ";
            // 
            // guna2TextBoxFilePath
            // 
            this.guna2TextBoxFilePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxFilePath.DefaultText = "";
            this.guna2TextBoxFilePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxFilePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxFilePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxFilePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxFilePath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxFilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxFilePath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxFilePath.Location = new System.Drawing.Point(204, 185);
            this.guna2TextBoxFilePath.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.guna2TextBoxFilePath.Name = "guna2TextBoxFilePath";
            this.guna2TextBoxFilePath.PasswordChar = '\0';
            this.guna2TextBoxFilePath.PlaceholderText = "";
            this.guna2TextBoxFilePath.ReadOnly = true;
            this.guna2TextBoxFilePath.SelectedText = "";
            this.guna2TextBoxFilePath.Size = new System.Drawing.Size(270, 34);
            this.guna2TextBoxFilePath.TabIndex = 29;
            // 
            // guna2TextBoxAssignmentName
            // 
            this.guna2TextBoxAssignmentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxAssignmentName.DefaultText = "";
            this.guna2TextBoxAssignmentName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxAssignmentName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxAssignmentName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxAssignmentName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxAssignmentName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxAssignmentName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxAssignmentName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxAssignmentName.Location = new System.Drawing.Point(204, 38);
            this.guna2TextBoxAssignmentName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.guna2TextBoxAssignmentName.Name = "guna2TextBoxAssignmentName";
            this.guna2TextBoxAssignmentName.PasswordChar = '\0';
            this.guna2TextBoxAssignmentName.PlaceholderText = "";
            this.guna2TextBoxAssignmentName.ReadOnly = true;
            this.guna2TextBoxAssignmentName.SelectedText = "";
            this.guna2TextBoxAssignmentName.Size = new System.Drawing.Size(270, 34);
            this.guna2TextBoxAssignmentName.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(519, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mô tả:";
            // 
            // UserControlBaiTapDaDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlBaiTapDaDang";
            this.Size = new System.Drawing.Size(1176, 240);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        internal System.Windows.Forms.LinkLabel linkLabel1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.RichTextBox richTextBoxDes;
        internal Guna.UI2.WinForms.Guna2TextBox guna2TextBoxFilePath;
        internal Guna.UI2.WinForms.Guna2TextBox guna2TextBoxAssignmentName;
    }
}
