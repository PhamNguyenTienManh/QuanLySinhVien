using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACKW
{
    public class Announce
    {
        MY_DB mydb = new MY_DB();
        public bool insert(string courseID, string TeacherID, string Title, string Text, DateTime Date, string type)
        {
            SqlCommand command = new SqlCommand("INSERT INTO announce (CourseID,TeacherID, Title, Text, Date, type)" +
                " VALUES (@cid,@tid, @title, @text, @date, @type)", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.NVarChar).Value = courseID;
            command.Parameters.Add("@tid", SqlDbType.NVarChar).Value = TeacherID;
            command.Parameters.Add("@title", SqlDbType.NVarChar).Value = Title;
            command.Parameters.Add("@text", SqlDbType.Text).Value = Text;
            command.Parameters.Add("@date", SqlDbType.DateTime).Value = Date;
            command.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
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
        public bool update(string courseID, string TeacherID, string Title, string Text, DateTime Date)
        {
            SqlCommand command = new SqlCommand("update announce set CourseID = @cid, TeacherID=@tid, Title=@title, Text = @text, Date=@date ", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@tid", SqlDbType.NVarChar).Value = TeacherID;
            command.Parameters.Add("@title", SqlDbType.NVarChar).Value = Title;
            command.Parameters.Add("@text", SqlDbType.Text).Value = Text;
            command.Parameters.Add("@date", SqlDbType.DateTime).Value = Date;
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
    }
}
