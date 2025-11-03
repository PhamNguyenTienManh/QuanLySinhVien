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
    public partial class ListAccountBtnForm : Form
    {
        MY_DB mydb = new MY_DB();
        Login login = new Login();
        public ListAccountBtnForm()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex != -1)
            {
                string type = guna2ComboBox1.SelectedItem.ToString();
                SqlCommand cmd = new SqlCommand("Select username as Username, password as Password,mail as Email,type as Type From login Where type = @type and accept=1", mydb.getConnection);
                cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
                dataGridView1.DataSource = login.getAccount(cmd);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListAccountBtnForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select username as Username, password as Password ,mail as Email,type as Type From login Where accept = 1", mydb.getConnection);
            dataGridView1.DataSource = login.getAccount(cmd);
        }

        private void guna2ButtonDeleteAccount_Click(object sender, EventArgs e)
        {
            string user = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (login.deleteAccount(user))
            {
                MessageBox.Show("Đã xóa", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListAccountBtnForm_Load(sender, e);
            }
            else MessageBox.Show("Lỗi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
