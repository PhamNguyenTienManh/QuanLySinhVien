using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DACKW
{
    public class Chat
    {
        MY_DB mydb = new MY_DB();
        public bool insert(int id, string courseID, string type, int studentID, string teacherID, string name, string message, MemoryStream picture, DateTime time)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Chat (id, CourseID, type, studentID, teacherID, name, Message, picture, time)" +
                " VALUES (@Id,@courseId, @type,@studentID, @teacherID, @name, @mess,@pic, @time)", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@courseId", SqlDbType.NVarChar).Value = courseID;
            command.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
            command.Parameters.Add("@studentId", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@teacherId", SqlDbType.NVarChar).Value = teacherID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@mess", SqlDbType.Text).Value = message;
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = time;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
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
        public bool update(string Id, string name, DateTime Time, string message)
        {
            SqlCommand command = new SqlCommand("update Chat set CourseID=@Id, Name=@name, Time=@time, Message=@mess )", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.NVarChar).Value = Id;

            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

            command.Parameters.Add("@time", SqlDbType.DateTime).Value = Time;
            command.Parameters.Add("@mess", SqlDbType.Text).Value = message;
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
        public bool delete(string Id)
        {
            SqlCommand command = new SqlCommand("delete from Chat where CourseID=@Id", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;

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
