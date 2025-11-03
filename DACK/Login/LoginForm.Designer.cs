namespace DACKW
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBoxTypeOfAcc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Faceloginbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Loginbtn = new Guna.UI2.WinForms.Guna2Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guna2TextBoxUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.ComboBoxTypeOfAcc);
            this.groupBox1.Controls.Add(this.Faceloginbtn);
            this.groupBox1.Controls.Add(this.Loginbtn);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.guna2TextBoxUserName);
            this.groupBox1.Controls.Add(this.guna2TextBoxPassword);
            this.groupBox1.Location = new System.Drawing.Point(44, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 591);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // ComboBoxTypeOfAcc
            // 
            this.ComboBoxTypeOfAcc.AutoRoundedCorners = true;
            this.ComboBoxTypeOfAcc.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxTypeOfAcc.BorderRadius = 17;
            this.ComboBoxTypeOfAcc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxTypeOfAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTypeOfAcc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxTypeOfAcc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxTypeOfAcc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ComboBoxTypeOfAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxTypeOfAcc.ItemHeight = 30;
            this.ComboBoxTypeOfAcc.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Admin"});
            this.ComboBoxTypeOfAcc.Location = new System.Drawing.Point(98, 363);
            this.ComboBoxTypeOfAcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxTypeOfAcc.Name = "ComboBoxTypeOfAcc";
            this.ComboBoxTypeOfAcc.Size = new System.Drawing.Size(208, 36);
            this.ComboBoxTypeOfAcc.TabIndex = 7;
            // 
            // Faceloginbtn
            // 
            this.Faceloginbtn.Animated = true;
            this.Faceloginbtn.BorderRadius = 10;
            this.Faceloginbtn.BorderThickness = 2;
            this.Faceloginbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Faceloginbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Faceloginbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Faceloginbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Faceloginbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Faceloginbtn.ForeColor = System.Drawing.Color.White;
            this.Faceloginbtn.Location = new System.Drawing.Point(376, 502);
            this.Faceloginbtn.Name = "Faceloginbtn";
            this.Faceloginbtn.Size = new System.Drawing.Size(180, 72);
            this.Faceloginbtn.TabIndex = 6;
            this.Faceloginbtn.Text = "Đăng nhập khuôn mặt";
            this.Faceloginbtn.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // Loginbtn
            // 
            this.Loginbtn.Animated = true;
            this.Loginbtn.BorderRadius = 10;
            this.Loginbtn.BorderThickness = 2;
            this.Loginbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Loginbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Loginbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Loginbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Loginbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.Location = new System.Drawing.Point(93, 502);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(180, 72);
            this.Loginbtn.TabIndex = 5;
            this.Loginbtn.Text = "Log in";
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel2.Location = new System.Drawing.Point(480, 457);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(77, 20);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Register";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.pictureBox1.Image = global::DACKW.Properties.Resources.logo_hcmute;
            this.pictureBox1.Location = new System.Drawing.Point(226, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(76, 457);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(154, 20);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forget Password?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // guna2TextBoxUserName
            // 
            this.guna2TextBoxUserName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2TextBoxUserName.BorderRadius = 20;
            this.guna2TextBoxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxUserName.DefaultText = "";
            this.guna2TextBoxUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxUserName.IconRight = ((System.Drawing.Image)(resources.GetObject("guna2TextBoxUserName.IconRight")));
            this.guna2TextBoxUserName.Location = new System.Drawing.Point(98, 225);
            this.guna2TextBoxUserName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.guna2TextBoxUserName.Name = "guna2TextBoxUserName";
            this.guna2TextBoxUserName.PasswordChar = '\0';
            this.guna2TextBoxUserName.PlaceholderText = "Enter Your Username";
            this.guna2TextBoxUserName.SelectedText = "";
            this.guna2TextBoxUserName.Size = new System.Drawing.Size(464, 60);
            this.guna2TextBoxUserName.TabIndex = 0;
            this.guna2TextBoxUserName.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2TextBoxPassword
            // 
            this.guna2TextBoxPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2TextBoxPassword.BorderRadius = 20;
            this.guna2TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxPassword.DefaultText = "";
            this.guna2TextBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxPassword.IconRight = ((System.Drawing.Image)(resources.GetObject("guna2TextBoxPassword.IconRight")));
            this.guna2TextBoxPassword.Location = new System.Drawing.Point(93, 294);
            this.guna2TextBoxPassword.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.guna2TextBoxPassword.Name = "guna2TextBoxPassword";
            this.guna2TextBoxPassword.PasswordChar = '●';
            this.guna2TextBoxPassword.PlaceholderText = "Enter Password";
            this.guna2TextBoxPassword.SelectedText = "";
            this.guna2TextBoxPassword.Size = new System.Drawing.Size(464, 60);
            this.guna2TextBoxPassword.TabIndex = 1;
            this.guna2TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Turquoise;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(270, 2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(218, 63);
            this.guna2CustomGradientPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOG IN";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(747, 669);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxPassword;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Loginbtn;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private Guna.UI2.WinForms.Guna2Button Faceloginbtn;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxTypeOfAcc;
    }
}

