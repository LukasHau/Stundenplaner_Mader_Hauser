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
    }
}
