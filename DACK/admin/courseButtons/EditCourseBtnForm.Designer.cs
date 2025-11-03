namespace DACKW.admin.courseButtons
{
    partial class EditCourseBtnForm
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
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.numericUpDownPeriod = new System.Windows.Forms.NumericUpDown();
            this.richTextBoxDes = new System.Windows.Forms.RichTextBox();
            this.guna2TextBoxCourseName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ComboBoxSelectCourse = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ButtonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonRemove = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxSemester.Location = new System.Drawing.Point(432, 285);
            this.comboBoxSemester.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(180, 28);
            this.comboBoxSemester.TabIndex = 25;
            // 
            // numericUpDownPeriod
            // 
            this.numericUpDownPeriod.Location = new System.Drawing.Point(434, 227);
            this.numericUpDownPeriod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownPeriod.Name = "numericUpDownPeriod";
            this.numericUpDownPeriod.Size = new System.Drawing.Size(160, 26);
            this.numericUpDownPeriod.TabIndex = 22;
            // 
            // richTextBoxDes
            // 
            this.richTextBoxDes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDes.Location = new System.Drawing.Point(432, 369);
            this.richTextBoxDes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxDes.Name = "richTextBoxDes";
            this.richTextBoxDes.Size = new System.Drawing.Size(286, 148);
            this.richTextBoxDes.TabIndex = 21;
            this.richTextBoxDes.Text = "";
            // 
            // guna2TextBoxCourseName
            // 
            this.guna2TextBoxCourseName.BorderRadius = 10;
            this.guna2TextBoxCourseName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxCourseName.DefaultText = "";
            this.guna2TextBoxCourseName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxCourseName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxCourseName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxCourseName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxCourseName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxCourseName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxCourseName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxCourseName.Location = new System.Drawing.Point(432, 135);
            this.guna2TextBoxCourseName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.guna2TextBoxCourseName.Name = "guna2TextBoxCourseName";
            this.guna2TextBoxCourseName.PasswordChar = '\0';
            this.guna2TextBoxCourseName.PlaceholderText = "";
            this.guna2TextBoxCourseName.SelectedText = "";
            this.guna2TextBoxCourseName.Size = new System.Drawing.Size(300, 55);
            this.guna2TextBoxCourseName.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 362);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Label:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Period:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 285);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Semester:";
            // 
            // guna2ComboBoxSelectCourse
            // 
            this.guna2ComboBoxSelectCourse.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxSelectCourse.BorderRadius = 10;
            this.guna2ComboBoxSelectCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxSelectCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxSelectCourse.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxSelectCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxSelectCourse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBoxSelectCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBoxSelectCourse.ItemHeight = 30;
            this.guna2ComboBoxSelectCourse.Location = new System.Drawing.Point(434, 42);
            this.guna2ComboBoxSelectCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ComboBoxSelectCourse.Name = "guna2ComboBoxSelectCourse";
            this.guna2ComboBoxSelectCourse.Size = new System.Drawing.Size(298, 36);
            this.guna2ComboBoxSelectCourse.TabIndex = 15;
            this.guna2ComboBoxSelectCourse.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBoxSelectCourse_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select course:";
            // 
            // guna2ButtonEdit
            // 
            this.guna2ButtonEdit.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButtonEdit.BorderColor = System.Drawing.Color.Honeydew;
            this.guna2ButtonEdit.BorderRadius = 20;
            this.guna2ButtonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonEdit.ForeColor = System.Drawing.Color.Black;
            this.guna2ButtonEdit.Location = new System.Drawing.Point(954, 243);
            this.guna2ButtonEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ButtonEdit.Name = "guna2ButtonEdit";
            this.guna2ButtonEdit.Size = new System.Drawing.Size(270, 69);
            this.guna2ButtonEdit.TabIndex = 23;
            this.guna2ButtonEdit.Text = "Edit";
            this.guna2ButtonEdit.Click += new System.EventHandler(this.guna2ButtonEdit_Click);
            // 
            // guna2ButtonRemove
            // 
            this.guna2ButtonRemove.BorderRadius = 20;
            this.guna2ButtonRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonRemove.ForeColor = System.Drawing.Color.Black;
            this.guna2ButtonRemove.Location = new System.Drawing.Point(954, 369);
            this.guna2ButtonRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ButtonRemove.Name = "guna2ButtonRemove";
            this.guna2ButtonRemove.Size = new System.Drawing.Size(270, 69);
            this.guna2ButtonRemove.TabIndex = 24;
            this.guna2ButtonRemove.Text = "Remove";
            this.guna2ButtonRemove.Click += new System.EventHandler(this.guna2ButtonRemove_Click);
            // 
            // EditCourseBtnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 539);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.guna2ButtonRemove);
            this.Controls.Add(this.guna2ButtonEdit);
            this.Controls.Add(this.numericUpDownPeriod);
            this.Controls.Add(this.richTextBoxDes);
            this.Controls.Add(this.guna2TextBoxCourseName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2ComboBoxSelectCourse);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCourseBtnForm";
            this.Text = "EditCourseBtnForm";
            this.Load += new System.EventHandler(this.EditCourseBtnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.NumericUpDown numericUpDownPeriod;
        private System.Windows.Forms.RichTextBox richTextBoxDes;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxCourseName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxSelectCourse;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonEdit;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonRemove;
    }
}