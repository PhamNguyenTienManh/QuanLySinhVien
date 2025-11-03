namespace DACKW
{
    partial class StudentButtonForm
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ButtonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.AutoScroll = true;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(11, 57);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(924, 391);
            this.guna2GradientPanel1.TabIndex = 4;
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // guna2ButtonEdit
            // 
            this.guna2ButtonEdit.Animated = true;
            this.guna2ButtonEdit.BorderRadius = 15;
            this.guna2ButtonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2ButtonEdit.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonEdit.Image = global::DACKW.Properties.Resources.pencil2;
            this.guna2ButtonEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButtonEdit.Location = new System.Drawing.Point(230, 11);
            this.guna2ButtonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ButtonEdit.Name = "guna2ButtonEdit";
            this.guna2ButtonEdit.Size = new System.Drawing.Size(222, 42);
            this.guna2ButtonEdit.TabIndex = 28;
            this.guna2ButtonEdit.Text = "Add/Edit/Remove";
            this.guna2ButtonEdit.Click += new System.EventHandler(this.guna2ButtonEdit_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::DACKW.Properties.Resources.checklist1;
            this.guna2Button2.Location = new System.Drawing.Point(615, 11);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(197, 42);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "Student List";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // StudentButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 459);
            this.Controls.Add(this.guna2ButtonEdit);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2Button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentButtonForm";
            this.Text = "StudentButtonForm";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonEdit;
    }
}