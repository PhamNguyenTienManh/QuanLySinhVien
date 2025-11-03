using DACKW.admin.scoreButtons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACKW.admin
{
    public partial class ScoreButtonForm : Form
    {
        MY_DB mydb = new MY_DB();
        Score score = new Score();
        public ScoreButtonForm()
        {
            InitializeComponent();
        }
        AdminForm adminForm;    
        public ScoreButtonForm(AdminForm adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ButtonPrintBtn_Click(object sender, EventArgs e)
        {
            PrintStdResult form = new PrintStdResult();
            guna2GradientPanel2.Controls.Clear();
            form.TopLevel = false;
            guna2GradientPanel2.Controls.Add(form);
            form.Show();
        }

        private void guna2ButtonStaticBtn_Click(object sender, EventArgs e)
        {
            StaticScoreBtnForm form = new StaticScoreBtnForm();
            guna2GradientPanel2.Controls.Clear();
            form.TopLevel = false;
            guna2GradientPanel2.Controls.Add(form);
            form.Show();
        }

        private void guna2ButtonAvgScore_Click(object sender, EventArgs e)
        {
            AvgScoreBtnForm form = new AvgScoreBtnForm();
            guna2GradientPanel2.Controls.Clear();
            form.TopLevel = false;
            guna2GradientPanel2.Controls.Add(form);
            form.Show();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            AddScoreBtnForm form = new AddScoreBtnForm();
            guna2GradientPanel2.Controls.Clear();
            form.TopLevel = false;
            guna2GradientPanel2.Controls.Add(form);
            form.Show();
            
        }
    }
}
