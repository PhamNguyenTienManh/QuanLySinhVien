namespace DACKW
{
    partial class StudentListButtonForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.guna2ButtonSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonImport = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonPrint = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(809, 286);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // guna2ButtonSave
            // 
            this.guna2ButtonSave.Animated = true;
            this.guna2ButtonSave.BorderRadius = 15;
            this.guna2ButtonSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2ButtonSave.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonSave.Image = global::DACKW.Properties.Resources.save;
            this.guna2ButtonSave.Location = new System.Drawing.Point(461, 338);
            this.guna2ButtonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ButtonSave.Name = "guna2ButtonSave";
            this.guna2ButtonSave.Size = new System.Drawing.Size(120, 42);
            this.guna2ButtonSave.TabIndex = 7;
            this.guna2ButtonSave.Text = "Save";
            this.guna2ButtonSave.Click += new System.EventHandler(this.guna2ButtonSave_Click);
            // 
            // guna2ButtonImport
            // 
            this.guna2ButtonImport.Animated = true;
            this.guna2ButtonImport.BorderRadius = 15;
            this.guna2ButtonImport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonImport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonImport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonImport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonImport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2ButtonImport.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonImport.Image = global::DACKW.Properties.Resources.import;
            this.guna2ButtonImport.Location = new System.Drawing.Point(190, 338);
            this.guna2ButtonImport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ButtonImport.Name = "guna2ButtonImport";
            this.guna2ButtonImport.Size = new System.Drawing.Size(120, 42);
            this.guna2ButtonImport.TabIndex = 6;
            this.guna2ButtonImport.Text = "Import";
            this.guna2ButtonImport.Click += new System.EventHandler(this.guna2ButtonImport_Click);
            // 
            // guna2ButtonPrint
            // 
            this.guna2ButtonPrint.Animated = true;
            this.guna2ButtonPrint.BorderRadius = 15;
            this.guna2ButtonPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2ButtonPrint.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonPrint.Image = global::DACKW.Properties.Resources.save;
            this.guna2ButtonPrint.Location = new System.Drawing.Point(718, 338);
            this.guna2ButtonPrint.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ButtonPrint.Name = "guna2ButtonPrint";
            this.guna2ButtonPrint.Size = new System.Drawing.Size(120, 42);
            this.guna2ButtonPrint.TabIndex = 30;
            this.guna2ButtonPrint.Text = "Print";
            this.guna2ButtonPrint.Click += new System.EventHandler(this.guna2ButtonPrint_Click);
            // 
            // StudentListButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 391);
            this.Controls.Add(this.guna2ButtonPrint);
            this.Controls.Add(this.guna2ButtonSave);
            this.Controls.Add(this.guna2ButtonImport);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentListButtonForm";
            this.Text = "StudentListButtonForm";
            this.Load += new System.EventHandler(this.StudentListButtonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonImport;
        private System.Windows.Forms.OpenFileDialog openFD;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonSave;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonPrint;
    }
}