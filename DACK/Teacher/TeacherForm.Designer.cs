namespace DACKW
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelShow = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonGiveScore = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonExit = new Guna.UI2.WinForms.Guna2Button();
            this.buttonCourse = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonNotify = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAccountTeacher = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(153, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 478);
            this.panel1.TabIndex = 5;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Blue;
            this.guna2Panel2.Controls.Add(this.LabelShow);
            this.guna2Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel2.Location = new System.Drawing.Point(153, -7);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(957, 47);
            this.guna2Panel2.TabIndex = 4;
            // 
            // LabelShow
            // 
            this.LabelShow.AutoSize = false;
            this.LabelShow.BackColor = System.Drawing.Color.Transparent;
            this.LabelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelShow.Location = new System.Drawing.Point(376, 13);
            this.LabelShow.Name = "LabelShow";
            this.LabelShow.Size = new System.Drawing.Size(321, 27);
            this.LabelShow.TabIndex = 0;
            this.LabelShow.Text = "Trang chủ";
            this.LabelShow.Click += new System.EventHandler(this.LabelShow_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.ButtonGiveScore);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.buttonExit);
            this.guna2Panel1.Controls.Add(this.buttonCourse);
            this.guna2Panel1.Controls.Add(this.ButtonNotify);
            this.guna2Panel1.Controls.Add(this.buttonAccountTeacher);
            this.guna2Panel1.Location = new System.Drawing.Point(-3, -4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(158, 524);
            this.guna2Panel1.TabIndex = 3;
            // 
            // ButtonGiveScore
            // 
            this.ButtonGiveScore.BorderThickness = 1;
            this.ButtonGiveScore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonGiveScore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonGiveScore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonGiveScore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonGiveScore.FillColor = System.Drawing.Color.White;
            this.ButtonGiveScore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonGiveScore.ForeColor = System.Drawing.Color.Black;
            this.ButtonGiveScore.Image = global::DACKW.Properties.Resources.learning;
            this.ButtonGiveScore.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonGiveScore.Location = new System.Drawing.Point(-3, 279);
            this.ButtonGiveScore.Name = "ButtonGiveScore";
            this.ButtonGiveScore.Size = new System.Drawing.Size(160, 56);
            this.ButtonGiveScore.TabIndex = 6;
            this.ButtonGiveScore.Text = "Danh sách điểm";
            this.ButtonGiveScore.Click += new System.EventHandler(this.ButtonGiveScore_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(152, 118);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BorderThickness = 1;
            this.buttonExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonExit.FillColor = System.Drawing.Color.White;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Image = global::DACKW.Properties.Resources.logout;
            this.buttonExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonExit.Location = new System.Drawing.Point(-4, 331);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(161, 57);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCourse
            // 
            this.buttonCourse.BorderThickness = 1;
            this.buttonCourse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCourse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCourse.FillColor = System.Drawing.Color.White;
            this.buttonCourse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCourse.ForeColor = System.Drawing.Color.Black;
            this.buttonCourse.Image = global::DACKW.Properties.Resources.learning;
            this.buttonCourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonCourse.Location = new System.Drawing.Point(-3, 228);
            this.buttonCourse.Name = "buttonCourse";
            this.buttonCourse.Size = new System.Drawing.Size(160, 56);
            this.buttonCourse.TabIndex = 2;
            this.buttonCourse.Text = "Khóa học";
            this.buttonCourse.Click += new System.EventHandler(this.buttonCourse_Click);
            // 
            // ButtonNotify
            // 
            this.ButtonNotify.BorderThickness = 1;
            this.ButtonNotify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonNotify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonNotify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonNotify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonNotify.FillColor = System.Drawing.Color.White;
            this.ButtonNotify.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonNotify.ForeColor = System.Drawing.Color.Black;
            this.ButtonNotify.Image = global::DACKW.Properties.Resources.bell;
            this.ButtonNotify.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonNotify.Location = new System.Drawing.Point(0, 178);
            this.ButtonNotify.Name = "ButtonNotify";
            this.ButtonNotify.Size = new System.Drawing.Size(158, 55);
            this.ButtonNotify.TabIndex = 1;
            this.ButtonNotify.Text = "Thông báo";
            this.ButtonNotify.Click += new System.EventHandler(this.ButtonNotify_Click);
            // 
            // buttonAccountTeacher
            // 
            this.buttonAccountTeacher.BackColor = System.Drawing.Color.Black;
            this.buttonAccountTeacher.BorderThickness = 1;
            this.buttonAccountTeacher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAccountTeacher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAccountTeacher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAccountTeacher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAccountTeacher.FillColor = System.Drawing.Color.White;
            this.buttonAccountTeacher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAccountTeacher.ForeColor = System.Drawing.Color.Black;
            this.buttonAccountTeacher.Image = global::DACKW.Properties.Resources.user;
            this.buttonAccountTeacher.Location = new System.Drawing.Point(-5, 127);
            this.buttonAccountTeacher.Name = "buttonAccountTeacher";
            this.buttonAccountTeacher.Size = new System.Drawing.Size(162, 55);
            this.buttonAccountTeacher.TabIndex = 0;
            this.buttonAccountTeacher.Text = "Thông tin giáo viên";
            this.buttonAccountTeacher.Click += new System.EventHandler(this.buttonAccountTeacher_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelShow;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button buttonExit;
        private Guna.UI2.WinForms.Guna2Button buttonCourse;
        private Guna.UI2.WinForms.Guna2Button ButtonNotify;
        private Guna.UI2.WinForms.Guna2Button buttonAccountTeacher;
        private Guna.UI2.WinForms.Guna2Button ButtonGiveScore;
    }
}