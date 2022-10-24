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

        #region Variables
        public static string StudentName;
        public static string StudentSurname;
        public static string StudentBirth;
        public static string StudentAdress;
        public static string StudentEmail;
        public static int StudentID_login;
        public static string StudentSchool_class;
                    

        #endregion

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

        public static void LoadStudent(int id)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT name FROM swp5_student WHERE ID = '" + id + "';");
                StudentName = (string)cmd.ExecuteScalar();
                cmd.CommandText = ("SELECT surname FROM swp5_student WHERE ID = '" + id + "';");
                StudentSurname = (string)cmd.ExecuteScalar();
                cmd.CommandText = ("SELECT birth FROM swp5_student WHERE ID = '" + id + "';");
                StudentBirth = (string)cmd.ExecuteScalar();
                cmd.CommandText = ("SELECT adress FROM swp5_student WHERE ID = '" + id + "';");
                StudentAdress = (string)cmd.ExecuteScalar();
                cmd.CommandText = ("SELECT email FROM swp5_student WHERE ID = '" + id + "';");
                StudentEmail = (string)cmd.ExecuteScalar();
                cmd.CommandText = ("SELECT ID_login FROM swp5_student WHERE ID = '" + id + "';");
                StudentID_login = (int)cmd.ExecuteScalar();
                cmd.CommandText = ("SELECT school_class FROM swp5_student WHERE ID = '" + id + "';");
                StudentSchool_class = (string)cmd.ExecuteScalar();
                con.Close();
            }
            catch(Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static void DeleteStudent(int id)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT name FROM swp5_student WHERE ID = '" + id + "';");
                string tempName = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT surname FROM swp5_student WHERE ID = '" + id + "';");
                string tempSurname = (string)cmd.ExecuteScalar();
                con.Close();


                DialogResult dialogResult = MessageBox.Show("Wollen Sie " + tempName + " " + tempSurname + " wirklich löschen?", "Achtung!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("DELETE FROM swp5_student WHERE ID = '" + id + "';");
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(tempName + " " + tempSurname + " wurde gelöscht!");
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }                
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static void updateStudent(int id, string name, string surname, DateTime birth, string adress, string email)
        {
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("UPDATE swp5_student set name = '" + name + "', surname = '" + surname + "', birth = '" + birth.ToString() + "', adress = '" + adress + "', email = '" + email + "' where ID = '" + id + "';");
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(name + " " + surname + " wurde bearbeitet!");
                
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show (e.ToString());
            }
        }
    }
}
