using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACKW
{
    public class Submission
    {
        MY_DB mydb = new MY_DB();
        public bool insert(int Id, int studentID, string name, string path, DateTime submitTime, float grade, string feedback)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Submission (AssignmentID, StudentID, SubmissionName, Path, TimeSubmit, Grade, Feedback)" +
    " VALUES (@Id, @sid, @name, @path, @time, @grade, @fb)", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@path", SqlDbType.NVarChar).Value = path;
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = submitTime;
            command.Parameters.Add("@grade", SqlDbType.Float).Value = grade;
            command.Parameters.Add("@fb", SqlDbType.NVarChar).Value = feedback;

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
        public bool update(int Id, int studentID, string name, string path, DateTime submitTime, float grade, string feedback)
        {
            SqlCommand command = new SqlCommand("update Submission set StudentID=@sid,SubmissionName=@name,Path=@path,TimeSubmit=@time,Grade=@grade,Feedback=@fb where AssignmentID=@Id", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@path", SqlDbType.NVarChar).Value = path;
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = submitTime;
            command.Parameters.Add("@grade", SqlDbType.Float).Value = grade;
            command.Parameters.Add("@fb", SqlDbType.NVarChar).Value = feedback;
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
        public bool updateDiem(int Id,int sid, float grade, string feedback)
        {
            SqlCommand command = new SqlCommand("update Submission set Grade=@grade,Feedback=@fb where AssignmentID=@Id and studentID=@sid ", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@sid", SqlDbType.Int).Value = sid;
            command.Parameters.Add("@grade", SqlDbType.Float).Value = grade;
            command.Parameters.Add("@fb", SqlDbType.NVarChar).Value = feedback;
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
        public bool delete(int Id)
        {
            SqlCommand command = new SqlCommand("delete from Submission where AssignmentID=@Id", mydb.getConnection);
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
