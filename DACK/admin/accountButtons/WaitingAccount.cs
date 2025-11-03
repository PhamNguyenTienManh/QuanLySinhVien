using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACKW.admin.accountButtons
{
    public partial class WaitingAccount : Form
    {
        MY_DB mydb = new MY_DB();
        Login login = new Login();  
        public WaitingAccount()
        {
            InitializeComponent();
        }

        private void WaitingAccount_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select username as Username, password as Password,mail as Email, type as Type from login where accept = 0", mydb.getConnection);
            dataGridView1.DataSource = login.getAccount(cmd);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string user = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (login.acceptAccount(user))
            {
                MessageBox.Show("Đã duyệt thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WaitingAccount_Load(sender, e);
            }
            else MessageBox.Show("Lỗi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string user = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
            if (login.deleteAccount(user))
            {
                MessageBox.Show("Đã xóa", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WaitingAccount_Load(sender, e);
            }
            else MessageBox.Show("Lỗi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
