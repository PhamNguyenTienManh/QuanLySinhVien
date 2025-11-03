using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms;

namespace DACKW
{
    public class Curriculum
    {
        MY_DB mydb = new MY_DB();
        public bool insert(string courseID, string teacherID)
        {
            SqlCommand command = new SqlCommand("INSERT INTO curriculum (course_id, teacher_id)" +
               " VALUES (@cid,@tid)", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.NVarChar).Value = courseID;

            command.Parameters.Add("@tid", SqlDbType.NVarChar).Value = teacherID;

            
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
        public bool update(string courseID, string teacherID)
        {
            SqlCommand command = new SqlCommand("update curriculum set teacher_id=@tid where course_id=@cid", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.NVarChar).Value = courseID;

            command.Parameters.Add("@tid", SqlDbType.NVarChar).Value = teacherID;


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
        public bool delete(string courseID)
        {
            SqlCommand command = new SqlCommand("delete from curriculum where course_id=@cid", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.NVarChar).Value = courseID;


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
