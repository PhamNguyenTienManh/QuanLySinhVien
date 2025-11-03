using DACKW.admin.accountButtons;
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
    public partial class AccountButtonForm : Form
    {
        public AccountButtonForm()
        {
            InitializeComponent();
        }

        private void AccountButtonForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            WaitingAccount form = new WaitingAccount();
            guna2GradientPanel1.Controls.Clear();
            form.TopLevel = false;
            guna2GradientPanel1.Controls.Add(form);
            form.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ListAccountBtnForm form = new ListAccountBtnForm();
            guna2GradientPanel1.Controls.Clear();
            form.TopLevel = false;
            guna2GradientPanel1.Controls.Add(form);
            form.Show();
        }
    }
}
