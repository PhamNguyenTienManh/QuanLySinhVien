using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACKW
{
    public class Score
    {
        MY_DB mydb = new MY_DB();
        public Score() { }
        public bool update(int studentID, string courseID, float scoreValue, string description)
        {
            SqlCommand cmd = new SqlCommand("update score set student_score=@scr,description = @descr where student_id=@sid and course_id=@cid", mydb.getConnection);
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            cmd.Parameters.Add("@cid", SqlDbType.NVarChar).Value = courseID;
            cmd.Parameters.Add("@scr", SqlDbType.Float).Value = scoreValue;
            cmd.Parameters.Add("@descr", SqlDbType.NVarChar).Value = description;
            mydb.openConnection();
            if ((cmd.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else { return false; }
        }
        public bool insertScore(int studentID, string courseID, float scoreValue, string description)
        {
            SqlCommand cmd = new SqlCommand("insert into score (Course_id,Student_id,  student_score, description) values (@cid,@tid,@sid, @scr, @descr)", mydb.getConnection);
            cmd.Parameters.Add("@cid", SqlDbType.NVarChar).Value = courseID;
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            cmd.Parameters.Add("@scr", SqlDbType.Float).Value = scoreValue;
            cmd.Parameters.Add("@descr", SqlDbType.NVarChar).Value = description;
            mydb.openConnection();
            if ((cmd.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else { return false; }
        }
        public bool insertScore(int student_id, string course_id)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Score (student_id, course_id)" +
                " VALUES (@student_id,@course_id)", mydb.getConnection);
            command.Parameters.Add("@student_id", SqlDbType.Int).Value = student_id;
            command.Parameters.Add("@course_id", SqlDbType.NChar).Value = course_id;
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
        public bool studentScoreExist(int studentID, string courseID)
        {
            SqlCommand cmd = new SqlCommand("select * from score where Student_id = @sid and Course_id = @cid", mydb.getConnection);
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            cmd.Parameters.Add("@cid", SqlDbType.NVarChar).Value = courseID;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return true;
            }
            else return false;
        }
        //public DataTable getAvgScoreByCourse()
        //{
        //    SqlCommand cmd = new SqlCommand("select Course_table.label, avg(score.student_score) as AverageGrade from Course_table, score where Course_table.label= score.course_id group by Course_table.label", mydb.getConnection);
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    adapter.Fill(dt);
        //    return dt;
        //}
        public bool deleteScore(int studentID, string courseID)
        {
            SqlCommand cmd = new SqlCommand("delete from score where Student_id = @sid and Course_id = @cid", mydb.getConnection);
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            cmd.Parameters.Add("@cid", SqlDbType.NVarChar).Value = courseID;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
                return false;
        }
        public DataTable getScore()
        {
            SqlCommand sql = new SqlCommand("select * from score", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable getAvgScoreByCourse(SqlCommand cmd)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
