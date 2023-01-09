using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Stundenplaner_Mader_Hauser
{
    class Teacher : SQLConnection
    {
        public static DataTable dt = new DataTable();
        private static SqlDataAdapter adp = new SqlDataAdapter();

        #region Variables
        public static string TeacherName;
        public static string TeacherSurname;
        public static string TeacherSex;
        public static string TeacherBirth;
        public static string TeacherAdress;
        public static string TeacherEmail;
        public static int TeacherID_login;
        #endregion

        public static void CreateTeacher(string name, string surname, string sex, DateTime birth, string adress, string email, int ID_login)
        {
            try
            {
                //create the teacher and write it into the database
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("INSERT INTO swp5_teacher(name, surname, sex, birth, adress, email, ID_login) VALUES('" + name + "', '" +
                    surname + "', '" + sex + "', '" + birth.ToString() + "', '" + adress + "', '" + email + "', '" + ID_login + "');");
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
                cmd = new SqlCommand("SELECT Id, name, surname FROM swp5_teacher", con);
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

        public static void LoadTeacher(int id)
        {
            try
            {
                //load the teacher into the form
                con.Open();
                cmd.CommandText = ("SELECT name FROM swp5_teacher WHERE ID = '" + id + "';");
                TeacherName = (string)cmd.ExecuteScalar();
                cmd.CommandText = ("SELECT surname FROM swp5_teacher WHERE ID = '" + id + "';");
                TeacherSurname = (string)cmd.ExecuteScalar();
                cmd.CommandText = ("SELECT sex FROM swp5_teacher WHERE ID = '" + id + "';");
                TeacherSex = (string)cmd.ExecuteScalar();
                cmd.CommandText = ("SELECT birth FROM swp5_teacher WHERE ID = '" + id + "';");
                TeacherBirth = (string)cmd.ExecuteScalar();
                cmd.CommandText = ("SELECT adress FROM swp5_teacher WHERE ID = '" + id + "';");
                TeacherAdress = (string)cmd.ExecuteScalar();
                cmd.CommandText = ("SELECT email FROM swp5_teacher WHERE ID = '" + id + "';");
                TeacherEmail = (string)cmd.ExecuteScalar();
                cmd.CommandText = ("SELECT ID_login FROM swp5_teacher WHERE ID = '" + id + "';");
                TeacherID_login = (int)cmd.ExecuteScalar();
                con.Close();

            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static void DeleteTeacher(int id)
        {
            try
            {
                //delete the whole teacher
                con.Open();
                cmd.CommandText = ("SELECT name FROM swp5_teacher WHERE ID = '" + id + "';");
                string tempName = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT surname FROM swp5_teacher WHERE ID = '" + id + "';");
                string tempSurname = (string)cmd.ExecuteScalar();
                con.Close();


                DialogResult dialogResult = MessageBox.Show("Wollen Sie " + tempName + " " + tempSurname + " wirklich löschen?", "Achtung!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("DELETE FROM swp5_teacher WHERE ID = '" + id + "';");
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

        public static void updateTeacher(int id, string name, string surname, string sex, DateTime birth, string adress, string email)
        {
            try
            {
                //update the teacher
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("UPDATE swp5_teacher set name = '" + name + "', surname = '" + surname + "', sex = '" + sex + "', birth = '" + birth.ToString() + "', adress = '" + adress + "', email = '" + email + "' where ID = '" + id + "';");
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(name + " " + surname + " wurde bearbeitet!");

            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static int GetTeacherID(string name, string surname, string sex, DateTime birth)
        {
            try
            {
                //get the teacher ID
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("SELECT ID from swp5_teacher where name = '" + name + "' AND surname = '" + surname + "' AND sex = '" + sex + "' AND birth = '" + birth.ToString() + "';");
                int TeacherID = (int)cmd.ExecuteScalar();
                con.Close();

                return TeacherID;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
                return -1;
            }
        }

    }
}
