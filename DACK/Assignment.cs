using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACKW
{
    public class Assignment
    {
        MY_DB mydb = new MY_DB();
        public bool insert(int Id, string courseID, string name, string description, string path, DateTime deadline)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Assignment (ID, CourseID, AssignmentName, Description, Path, Deadline)" +
                " VALUES (@Id,@cid, @name, @description, @path, @deadline)", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@cid", SqlDbType.NVarChar).Value = courseID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

            command.Parameters.Add("@description", SqlDbType.Text).Value = description;
            command.Parameters.Add("@path", SqlDbType.NVarChar).Value = path;
            command.Parameters.Add("@deadline", SqlDbType.DateTime).Value = deadline;
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
        public bool update(int Id, string courseID, string name, string description, string path, DateTime deadline)
        {
            SqlCommand command = new SqlCommand("update Assignment set CourseID=@cid, AssignmentName = @name, Description=@description, Path=@path,Deadline=@deadline where ID=@Id", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@cid", SqlDbType.NVarChar).Value = courseID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

            command.Parameters.Add("@description", SqlDbType.Text).Value = description;
            command.Parameters.Add("@path", SqlDbType.NVarChar).Value = path;
            command.Parameters.Add("@deadline", SqlDbType.DateTime).Value = deadline;
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
            SqlCommand command = new SqlCommand("delete from Assignment where ID=@Id", mydb.getConnection);
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
        public int GetNextId()
        {
            int nextId = 0;
            string query = "SELECT MAX(ID) + 1 FROM Assignment";
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            object result = command.ExecuteScalar();

            if (result != DBNull.Value && result != null)
            {
                nextId = Convert.ToInt32(result);
            }
            else
            {
                nextId = 1; // Trường hợp không có bản ghi nào trong bảng
            }
            mydb.closeConnection();
            return nextId;
        }
    }
}
