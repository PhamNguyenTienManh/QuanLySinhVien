namespace DACKW
{
    partial class StudentMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMainForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonExit = new Guna.UI2.WinForms.Guna2Button();
            this.buttonRegisterCourse = new Guna.UI2.WinForms.Guna2Button();
            this.buttonCourse = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonNotify = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAccount = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelShow = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.buttonExit);
            this.guna2Panel1.Controls.Add(this.buttonRegisterCourse);
            this.guna2Panel1.Controls.Add(this.buttonCourse);
            this.guna2Panel1.Controls.Add(this.ButtonNotify);
            this.guna2Panel1.Controls.Add(this.buttonAccount);
            this.guna2Panel1.Location = new System.Drawing.Point(-7, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(158, 528);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(152, 128);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
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
            this.buttonExit.Location = new System.Drawing.Point(0, 341);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(158, 50);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRegisterCourse
            // 
            this.buttonRegisterCourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRegisterCourse.BorderThickness = 1;
            this.buttonRegisterCourse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonRegisterCourse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonRegisterCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonRegisterCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonRegisterCourse.FillColor = System.Drawing.Color.Transparent;
            this.buttonRegisterCourse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRegisterCourse.ForeColor = System.Drawing.Color.Black;
            this.buttonRegisterCourse.Image = global::DACKW.Properties.Resources.pencil;
            this.buttonRegisterCourse.Location = new System.Drawing.Point(-2, 287);
            this.buttonRegisterCourse.Name = "buttonRegisterCourse";
            this.buttonRegisterCourse.Size = new System.Drawing.Size(160, 60);
            this.buttonRegisterCourse.TabIndex = 3;
            this.buttonRegisterCourse.Text = "Đăng ký học phần";
            this.buttonRegisterCourse.Click += new System.EventHandler(this.buttonRegisterCourse_Click);
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
            this.buttonCourse.Location = new System.Drawing.Point(3, 234);
            this.buttonCourse.Name = "buttonCourse";
            this.buttonCourse.Size = new System.Drawing.Size(157, 56);
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
            this.ButtonNotify.Location = new System.Drawing.Point(5, 183);
            this.ButtonNotify.Name = "ButtonNotify";
            this.ButtonNotify.Size = new System.Drawing.Size(155, 55);
            this.ButtonNotify.TabIndex = 1;
            this.ButtonNotify.Text = "Thông báo";
            this.ButtonNotify.Click += new System.EventHandler(this.ButtonNotify_Click);
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.Color.Black;
            this.buttonAccount.BorderThickness = 1;
            this.buttonAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAccount.FillColor = System.Drawing.Color.White;
            this.buttonAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAccount.ForeColor = System.Drawing.Color.Black;
            this.buttonAccount.Image = global::DACKW.Properties.Resources.user;
            this.buttonAccount.Location = new System.Drawing.Point(0, 125);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(158, 64);
            this.buttonAccount.TabIndex = 0;
            this.buttonAccount.Text = "Thông tin sinh viên";
            this.buttonAccount.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Blue;
            this.guna2Panel2.Controls.Add(this.LabelShow);
            this.guna2Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel2.Location = new System.Drawing.Point(149, -1);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(961, 53);
            this.guna2Panel2.TabIndex = 1;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // LabelShow
            // 
            this.LabelShow.AutoSize = false;
            this.LabelShow.BackColor = System.Drawing.Color.Transparent;
            this.LabelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelShow.Location = new System.Drawing.Point(308, 13);
            this.LabelShow.Name = "LabelShow";
            this.LabelShow.Size = new System.Drawing.Size(362, 37);
            this.LabelShow.TabIndex = 0;
            this.LabelShow.Text = "Trang chủ";
            this.LabelShow.Click += new System.EventHandler(this.LabelShow_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(149, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 479);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "StudentMainForm";
            this.Text = "StudentMainForm";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button buttonAccount;
        private Guna.UI2.WinForms.Guna2Button buttonRegisterCourse;
        private Guna.UI2.WinForms.Guna2Button buttonCourse;
        private Guna.UI2.WinForms.Guna2Button ButtonNotify;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button buttonExit;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelShow;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}