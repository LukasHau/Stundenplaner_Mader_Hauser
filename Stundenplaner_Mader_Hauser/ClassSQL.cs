using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Stundenplaner_Mader_Hauser
{
    internal class ClassSQL : SQLConnection
    {
        public static DataTable dt = new DataTable();
        private static SqlDataAdapter adp = new SqlDataAdapter();

        public static List<int> ClassNamesID = new List<int>();
        public static string NameSelectClass;

        #region Variables
        public static string ClassName;
        public static string ClassRoom;
        #endregion

        public static void CreateClass(string name, string room)
        {
            //creates a class
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("INSERT INTO swp5_class(name, room) VALUES('" + name + "', '" + room + "');");
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
                cmd = new SqlCommand("SELECT Id, name FROM swp5_class", con);
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

        public static void LoadClass(int id)
        {
            //loads a class
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT name FROM swp5_class WHERE ID = '" + id + "';");
                ClassName = (string)cmd.ExecuteScalar();
                cmd.CommandText = ("SELECT room FROM swp5_class WHERE ID = '" + id + "';");
                ClassRoom = (string)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static void DeleteClass(int id)
        {
            //deletes a class
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT name FROM swp5_class WHERE ID = '" + id + "';");
                string tempName = (string)cmd.ExecuteScalar();
                con.Close();


                DialogResult dialogResult = MessageBox.Show("Wollen Sie " + tempName + " wirklich löschen?", "Achtung!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("DELETE FROM swp5_class WHERE ID = '" + id + "';");
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(tempName + " wurde gelöscht!");
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

        public static void updateClass(int id, string name, string room)
        {
            //update a class
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("UPDATE swp5_class set name = '" + name + "', room = '" + room + "' where ID = '" + id + "';");
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(name + " wurde bearbeitet!");

            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }


        public static List<int> LoadClassNamesID()
        {
            //puts all class names into a list for a dropdownlist
            try
            {
                ClassNamesID.Clear();
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("SELECT ID FROM swp5_class");
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int temp = reader.GetInt32(0);
                        ClassNamesID.Add(temp);
                    }
                }
                else
                {

                }
                con.Close();
                return ClassNamesID;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return ClassNamesID;
            }
        }

        public static void SelectClassName(int ID)
        {
            //select a class
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT name FROM swp5_class where ID = '" + ID + "';");
                NameSelectClass = (string)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }


        public static string SelectSubjectID(int IDclass, int day, int hour)
        {
            //select a subject
            string NameOfSubject;
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT subject FROM swp5_schedule where classID = '" + IDclass.ToString() + "' AND dayOfWeek ='" + day.ToString() + "' AND hour='" + hour.ToString() + "';");               
                object SubjectID = cmd.ExecuteScalar();
                con.Close();
                if (SubjectID != null)
                {
                    con.Open();
                    cmd.CommandText = ("SELECT name FROM swp5_subject where ID = '" + SubjectID.ToString() + "';");
                    NameOfSubject = (string)cmd.ExecuteScalar();
                    con.Close();
                    return NameOfSubject;
                }
                else
                {
                    //no text when the student have no subject
                    return "";     
                }
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
                return e.ToString();

            }
        }
    }
}
