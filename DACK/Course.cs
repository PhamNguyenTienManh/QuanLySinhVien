using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACKW.admin
{
    internal class Course
    {
        MY_DB mydb = new MY_DB();
        public bool insertCourse(string Id, string label, int period, int semester, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Course (id, name, period,semester, description)" +
                " VALUES (@Id,@label, @period,@semester, @description)", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Char).Value = Id;
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@semester", SqlDbType.Int).Value = semester;
            command.Parameters.Add("@description", SqlDbType.Text).Value = description;

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

        public bool checkCourseName(string courseName)
        {
            SqlCommand cmd = new SqlCommand("Select * From Course Where name=@cName ", mydb.getConnection);
            cmd.Parameters.Add("@cName", SqlDbType.NVarChar).Value = courseName;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
                return false;
            else
                return true;
        }
        public bool checkCourseID(string courseID)
        {
            SqlCommand cmd = new SqlCommand("Select * From Course Where id=@cid ", mydb.getConnection);
            cmd.Parameters.Add("@cid", SqlDbType.Char).Value = courseID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
                return false;
            else
                return true;
        }

        public bool updateCourse(string Id, string label, int period, int semester, string description)
        {
            SqlCommand command = new SqlCommand("UPDATE Course SET name=@label, period=@period,semester=@semester, description=@description WHERE Id=@Id", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Char).Value = Id;
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@semester", SqlDbType.Int).Value = semester;
            command.Parameters.Add("@description", SqlDbType.Text).Value = description;

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

        public bool deleteCourse(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Course WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Char).Value = id;
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

        public DataTable getCourses(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable getCourseByID(string id)
        {
            string query = "Select * from Course Where Id= @id";
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Char).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable getCourseBySemester(int semester)
        {
            SqlCommand cmd = new SqlCommand("Select FirstName, LastName, course_id, course.name, semester " +
                  "From course inner join ( Select FirstName, LastName, course_id From teacher inner join curriculum On teacher.teacherID = curriculum.teacher_ID) Q " +
                  "On course.id = Q.course_id " +
                  "Where semester=@semester and course_id in (Select score.Course_id From score Where Student_id = @UserID)", mydb.getConnection);
            cmd.Parameters.AddWithValue("@UserID", Globals.GlobaUserID);
            cmd.Parameters.Add("@semester", SqlDbType.Int).Value = semester;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable getCourseBySemester2(int semester)
        {
            SqlCommand cmd = new SqlCommand("Select FirstName, LastName, course_id, course.name, semester " +
                  "From course inner join ( Select FirstName, LastName, course_id From teacher inner join curriculum On teacher.teacherID = curriculum.teacher_ID) Q " +
                  "On course.id = Q.course_id " +
                  "Where semester=@semester and course_id not in (Select score.Course_id From score Where Student_id = @UserID)", mydb.getConnection);
            cmd.Parameters.AddWithValue("@UserID", Globals.GlobaUserID);
            cmd.Parameters.Add("@semester", SqlDbType.Int).Value = semester;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
