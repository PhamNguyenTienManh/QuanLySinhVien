namespace DACKW.Student
{
    partial class AccessCourseForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.labelTeacherName = new System.Windows.Forms.Label();
            this.labelCourseIdAndName = new System.Windows.Forms.Label();
            this.buttonForum = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonScore = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(957, 477);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DACKW.Properties.Resources.librarypic;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBoxExit);
            this.panel1.Controls.Add(this.labelTeacherName);
            this.panel1.Controls.Add(this.labelCourseIdAndName);
            this.panel1.Controls.Add(this.buttonForum);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 224);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Giảng viên:";
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExit.Image = global::DACKW.Properties.Resources.logout1;
            this.pictureBoxExit.Location = new System.Drawing.Point(843, 9);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(77, 51);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 7;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // labelTeacherName
            // 
            this.labelTeacherName.AutoSize = true;
            this.labelTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeacherName.Location = new System.Drawing.Point(9, 106);
            this.labelTeacherName.Name = "labelTeacherName";
            this.labelTeacherName.Size = new System.Drawing.Size(132, 25);
            this.labelTeacherName.TabIndex = 2;
            this.labelTeacherName.Text = "Giảng viên:";
            // 
            // labelCourseIdAndName
            // 
            this.labelCourseIdAndName.AutoSize = true;
            this.labelCourseIdAndName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseIdAndName.Location = new System.Drawing.Point(9, 45);
            this.labelCourseIdAndName.Name = "labelCourseIdAndName";
            this.labelCourseIdAndName.Size = new System.Drawing.Size(234, 25);
            this.labelCourseIdAndName.TabIndex = 1;
            this.labelCourseIdAndName.Text = "Cơ sở dữ liệu / DBSY";
            // 
            // buttonForum
            // 
            this.buttonForum.BackColor = System.Drawing.Color.Transparent;
            this.buttonForum.BorderRadius = 20;
            this.buttonForum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonForum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonForum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonForum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonForum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonForum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForum.ForeColor = System.Drawing.Color.White;
            this.buttonForum.Location = new System.Drawing.Point(707, 159);
            this.buttonForum.Name = "buttonForum";
            this.buttonForum.Size = new System.Drawing.Size(180, 45);
            this.buttonForum.TabIndex = 0;
            this.buttonForum.Text = "Diễn đàn";
            this.buttonForum.Click += new System.EventHandler(this.buttonForum_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.buttonScore);
            this.panel2.Location = new System.Drawing.Point(3, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 145);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttonScore
            // 
            this.buttonScore.BackColor = System.Drawing.Color.Transparent;
            this.buttonScore.BorderRadius = 20;
            this.buttonScore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonScore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonScore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonScore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonScore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonScore.ForeColor = System.Drawing.Color.White;
            this.buttonScore.Location = new System.Drawing.Point(707, 65);
            this.buttonScore.Name = "buttonScore";
            this.buttonScore.Size = new System.Drawing.Size(180, 45);
            this.buttonScore.TabIndex = 1;
            this.buttonScore.Text = "Điểm số";
            this.buttonScore.Click += new System.EventHandler(this.buttonScore_Click);
            // 
            // AccessCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 477);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccessCourseForm";
            this.Text = "AccessCourseForm";
            this.Load += new System.EventHandler(this.AccessCourseForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button buttonForum;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button buttonScore;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        public System.Windows.Forms.Label labelTeacherName;
        public System.Windows.Forms.Label labelCourseIdAndName;
        public System.Windows.Forms.Label label2;
    }
}