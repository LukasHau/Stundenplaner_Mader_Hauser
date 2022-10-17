using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Stundenplaner_Mader_Hauser
{
    internal class Student : SQLConnection
    {

        public static DataTable dt = new DataTable();
        private static SqlDataAdapter adp = new SqlDataAdapter();

        public static void CreateStudent(string name, string surname, DateTime birth, string adress, string email, int ID_login, string school_class)
        {
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("INSERT INTO swp5_student(name, surname, birth, adress, email, ID_login, school_class) VALUES('" + name + "', '" +
                    surname + "', '" + birth.ToString() + "', '" + adress + "', '" + email + "', '" + ID_login + "', '" + school_class + "');");
                cmd.ExecuteNonQuery();
                con.Close();

                errormessage = false;
                MessageBox.Show(name + " wurde hinzugefügt!");
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
            
        }

        public static DataTable LoadDG()
        {
            //clears the DataTable
            dt.Clear();
            //shows the data in the DataGrid
            try
            {
                cmd = new SqlCommand("SELECT Id, name, surname FROM swp5_student", con);
                adp.SelectCommand = cmd;
                adp.Fill(dt);
                return dt;
            }
            catch
            {
                MessageBox.Show("Ein Fehler ist aufgetreten!");
                return dt;
            }
        }
    }
}
