namespace DACKW
{
    partial class UserFace
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
            this.Savebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Camerabtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxOpenCam = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenCam)).BeginInit();
            this.SuspendLayout();
            // 
            // Savebtn
            // 
            this.Savebtn.Animated = true;
            this.Savebtn.BorderRadius = 10;
            this.Savebtn.BorderThickness = 2;
            this.Savebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Savebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Savebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Savebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Savebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Savebtn.ForeColor = System.Drawing.Color.White;
            this.Savebtn.Location = new System.Drawing.Point(776, 426);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(166, 48);
            this.Savebtn.TabIndex = 23;
            this.Savebtn.Text = "Save Image";
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Camerabtn
            // 
            this.Camerabtn.Animated = true;
            this.Camerabtn.BorderRadius = 10;
            this.Camerabtn.BorderThickness = 2;
            this.Camerabtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Camerabtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Camerabtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Camerabtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Camerabtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Camerabtn.ForeColor = System.Drawing.Color.White;
            this.Camerabtn.Location = new System.Drawing.Point(802, 12);
            this.Camerabtn.Name = "Camerabtn";
            this.Camerabtn.Size = new System.Drawing.Size(129, 62);
            this.Camerabtn.TabIndex = 22;
            this.Camerabtn.Text = "Open Camera";
            this.Camerabtn.Click += new System.EventHandler(this.Camerabtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Location = new System.Drawing.Point(776, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 241);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBoxOpenCam
            // 
            this.pictureBoxOpenCam.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxOpenCam.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxOpenCam.Name = "pictureBoxOpenCam";
            this.pictureBoxOpenCam.Size = new System.Drawing.Size(741, 462);
            this.pictureBoxOpenCam.TabIndex = 20;
            this.pictureBoxOpenCam.TabStop = false;
            // 
            // UserFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 483);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Camerabtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxOpenCam);
            this.Name = "UserFace";
            this.Text = "UserFace";
            this.Load += new System.EventHandler(this.UserFace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenCam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Savebtn;
        private Guna.UI2.WinForms.Guna2Button Camerabtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxOpenCam;
    }
}