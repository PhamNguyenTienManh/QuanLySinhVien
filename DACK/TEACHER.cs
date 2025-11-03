using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Common;
using static System.Net.Mime.MediaTypeNames;
using DACKW;
using System.Net;

namespace DACKW
{
    class TEACHER
    {

        MY_DB mydb = new MY_DB();
        public bool insertTeacher(string Id, string fname, string lname, DateTime bdate, string email)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Teacher (TeacherID, FirstName, LastName, BirthDate, email)" +
                " VALUES (@id,@fn, @ln, @bdt, @email)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.SmallDateTime).Value = bdate;

            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;



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
        public bool insertTeacher(string Id, string fname, string lname, DateTime bdate, string gender, string Phone,  MemoryStream picture, string email, string address)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Teacher (TeacherID, FirstName, LastName, BirthDate, Gender, Phone, Avatar, email, address)" +
                " VALUES (@id,@fn, @ln, @bdt, @gdr, @phn, @pic, @email, @address)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.SmallDateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = address;
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

        public DataTable getTeacher(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adaper = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adaper.Fill(dataTable);
            return dataTable;
        }
        public bool deleteTeacher(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Teacher WHERE TeacherID = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
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




        public bool updateTeacher(string id, string fname, string lname, DateTime bdate, string gender, string phone, MemoryStream picture, string email, string address)
        {
            SqlCommand command = new SqlCommand("UPDATE Teacher SET FirstName=@fn, LastName=@ln, BirthDate=@bdt, Gender=@gdr, Phone=@phn,Avatar=@pic, email=@email, address=@address WHERE @id=TeacherID", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = address;
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
        public bool updateTeacher(string id, string fname, string lname, DateTime bdate, string gender, string phone, MemoryStream picture, string address)
        {
            SqlCommand command = new SqlCommand("UPDATE Teacher SET FirstName=@fn, LastName=@ln, BirthDate=@bdt, Gender=@gdr, Phone=@phn,Avatar=@pic, address=@address WHERE @id=TeacherID", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = address;
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
            return count("select count(*) from Teacher");
        }

        public string male()
        {
            return count("select count(*) from Teacher where Gender = 'Male'");
        }

        public string nu()
        {
            return count("select count(*) from Teacher where Gender = 'Female'");
        }

        public DataTable getTeacherIDByUserName(string username)
        {
            SqlCommand command = new SqlCommand("Select teacherID From Teacher inner join login " +
                                                 "On teacher.email = login.mail " +
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







