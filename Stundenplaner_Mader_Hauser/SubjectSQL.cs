using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Stundenplaner_Mader_Hauser
{
    internal class SubjectSQL : SQLConnection
    {
        public static DataTable dt = new DataTable();
        private static SqlDataAdapter adp = new SqlDataAdapter();

        public static List<int> IDSelectSubject = new List<int>();
        public static List<string> SelectSubject = new List<string>();
        public static string NameSelectSubject;

        #region Variables
        public static string SubjectName;
        public static string SubjectFullname;
        public static int SubjectSA;
        #endregion

        public static void CreateSubject(string name, string fullname, int SA)
        {
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("INSERT INTO swp5_subject(name, fullname, exam) VALUES('" + name + "', '" + fullname + "', '" +
                    SA + "');");
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
                cmd = new SqlCommand("SELECT Id, name FROM swp5_subject", con);
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

        public static void LoadSubject(int id)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT name FROM swp5_subject WHERE ID = '" + id + "';");
                SubjectName = (string)cmd.ExecuteScalar();
                cmd.CommandText = ("SELECT fullname FROM swp5_subject WHERE ID = '" + id + "';");
                SubjectFullname = (string)cmd.ExecuteScalar();
                cmd.CommandText = ("SELECT exam FROM swp5_subject WHERE ID = '" + id + "';");
                SubjectSA = (int)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static void DeleteSubject(int id)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT name FROM swp5_subject WHERE ID = '" + id + "';");
                string tempName = (string)cmd.ExecuteScalar();
                con.Close();


                DialogResult dialogResult = MessageBox.Show("Wollen Sie " + tempName + " wirklich löschen?", "Achtung!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("DELETE FROM swp5_subject WHERE ID = '" + id + "';");
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

        public static void updateSubject(int id, string name, string fullname, int exam)
        {
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("UPDATE swp5_subject set name = '" + name + "', fullname = '" + fullname + "', exam = '" + exam  + "' where ID = '" + id + "';");
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

        public static List<int> SelectSubjectID()
        {
            try
            {
                IDSelectSubject.Clear();
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID FROM swp5_subject";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int temp = reader.GetInt32(0);
                        IDSelectSubject.Add(temp);
                    }
                }
                else
                {

                }
                con.Close();
                return IDSelectSubject;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return IDSelectSubject;
            }
        }
        public static void SelectSubjectName(int ID)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT name FROM swp5_subject where ID = '" + ID + "';");
                NameSelectSubject = (string)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static void SelectSubjectFullname(int ID)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT fullname FROM swp5_subject where ID = '" + ID + "';");
                NameSelectSubject = (string)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static List<string> AllSubjects()
        {
            try
            {
                SelectSubject.Clear();
                con.Open();
                cmd.CommandText = ("SELECT name FROM swp5_subject");
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string temp = reader.GetString(0);
                        SelectSubject.Add(temp);
                    }
                }
                else
                {

                }
                con.Close();
                return SelectSubject;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return SelectSubject;
            }

        }

        public static void FillSchedule(int dayOfWeek, int hour, int subject, int classID)
        {
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("INSERT INTO swp5_schedule(dayOfWeek, hour, subject, classID) VALUES('" + dayOfWeek + "', '" + hour + "', '" + subject + "', '" +
                classID + "');");
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static int SelectSubjectID(string name)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT ID FROM swp5_subject where name = '" + name + "';");
                int temp = (int)cmd.ExecuteScalar();
                con.Close();
                return temp;
            }
            catch (Exception e)
            {
                con.Close();
                return 0;
                MessageBox.Show(e.ToString());

            }
        }

        public static void DeleteSchedule(int ID)
        {
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("DELETE FROM swp5_schedule WHERE classID = '" + ID + "';");
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static int GetScheduleEdit(int classID, int day, int hour)
        {
            int temp;
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT subject FROM swp5_schedule WHERE classID = '" + classID + "' AND dayOfWeek = '" + day + "' AND hour = '" + hour + "';");
                var x = cmd.ExecuteScalar();
                if(x == null)
                {
                    temp = -1;
                }
                else
                {
                    temp = (int)cmd.ExecuteScalar();
                }
                con.Close();
                return temp;

            }
            catch (Exception e)
            {
                con.Close();
                return -1;
                MessageBox.Show(e.ToString());
            }
        }


    }
}
