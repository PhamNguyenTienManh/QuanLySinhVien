using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Common;
using static System.Net.Mime.MediaTypeNames;
using DACKW;

namespace DACKW
{
    class STUDENT
    {

        MY_DB mydb = new MY_DB();

        public bool insertStudent(int Id, string fname, string lname, DateTime bdate, string gender, string Email, string Phone, string Address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO student (StudentID, FirstName, LastName, BirthDate, Gender,Email, Phone, Address, Avatar)" +
                " VALUES (@id,@fn,@ln, @bdt, @gdr,@em, @phn, @adrs, @pic)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.SmallDateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@em", SqlDbType.VarChar).Value = Email;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = Address;
            if (picture != null)
                command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            else command.Parameters.Add("@pic", SqlDbType.Image).Value = new byte[0];

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

        public DataTable getStudent(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adaper = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adaper.Fill(dataTable);
            return dataTable;
        }
        public bool deleteStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM student WHERE StudentID = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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




        public bool updateStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE student SET FirstName=@fn, LastName=@ln, BirthDate=@bdt, Gender=@gdr, Phone=@phn,Address=@adrs,Avatar=@pic WHERE @id=StudentID", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
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

        string count(string query)
        {
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            string count = cmd.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public string total()
        {
            return count("select count(*) from student");
        }

        public string male()
        {
            return count("select count(*) from student where Gender = 'Male'");
        }

        public string female()
        {
            return count("select count(*) from student where Gender = 'Female'");
        }
        public bool insertStudentPartial(int Id, string fname, string lname, DateTime bdate)
        {
            SqlCommand command = new SqlCommand("INSERT INTO student (StudentID, FirstName, LastName, BirthDate, Email)" +
                " VALUES (@id,@fn, @ln, @bdt, @email)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = Id.ToString() + "@student.hcmute.edu.vn";
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

        public DataTable getStudentIDByUserName(string username)
        {
            SqlCommand command = new SqlCommand("Select studentID From student inner join login " +
                                                 "On student.email = login.mail " +
                                                 "Where username = @username", mydb.getConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Connection = mydb.getConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            return table;
        }
    }
}







