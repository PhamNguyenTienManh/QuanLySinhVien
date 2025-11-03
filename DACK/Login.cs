using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACKW
{
    public class Login
    {
        MY_DB mydb = new MY_DB();
        public Login() { }
        public bool insertAccount(string username, string password,string mail, string type)
        {
            SqlCommand command = new SqlCommand("INSERT INTO login (username, password,mail,type,accept)" +
                " VALUES (@user,@pass,@mail, @type,@accept)", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.Char).Value = username;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password;
            command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = mail;
            command.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
            command.Parameters.Add("@accept", SqlDbType.Int).Value = 0;

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool updateAccount(string username, string password)
        {
            SqlCommand command = new SqlCommand("update login set password=@pass where username = @user", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.Char).Value = username;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password;
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool acceptAccount (string username)
        {
            SqlCommand command = new SqlCommand("update login set accept = 1 where username = @user", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.Char).Value = username;
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool deleteAccount(string username)
        {
            SqlCommand command = new SqlCommand("DELETE FROM login WHERE username = @user", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.Char).Value = username;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }
        public DataTable getAccount(SqlCommand cmd)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            mydb.openConnection();
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
