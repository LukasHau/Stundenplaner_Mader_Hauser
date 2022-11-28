using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stundenplaner_Mader_Hauser
{
    public class SQLConnection
    {
        public static SqlConnection con = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand();
        public static DataTable dt = new DataTable();
        private static SqlDataAdapter adp = new SqlDataAdapter();
        public static SqlCommandBuilder CommandBuilder = new SqlCommandBuilder(adp);
        public static bool errormessage;
        public static string choosen_username;


        #region VariablesForEventLoad
        public static string EventPlace;
        public static string EventTime;
        public static string EventeventName;
        public static string EventClient;
        public static string EventContactPerson;
        public static string EventDescription;
        #endregion

        #region Connection
        //sets the conncetion string
        public static void SetConnectionString(string userCon)
        {
            try
            {
                con.ConnectionString = userCon;
                cmd.Connection = con;
            }
            catch
            {
                errormessage = true;
            }
        }

        public static void TryConnectTODB()
        {
            try
            {
                SetConnectionString("server = (localdb)\\MSSQLLocalDB; Integrated Security = true;");
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("if not exists(select * from sys.databases where name = 'swp5_StundenplanerDB') begin create database [swp5_StundenplanerDB] end");
                cmd.ExecuteNonQuery();
                con.Close();


                SetConnectionString("server=(localdb)\\MSSQLLocalDB; Integrated Security = true; Database = 'swp5_StundenplanerDB'");


                con.Open();
                cmd.CommandText = ("IF NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'swp5_login') CREATE TABLE swp5_login ([Id] INT IDENTITY (1, 1) NOT NULL, [username] VARCHAR(50) NULL,[password] VARCHAR(200) NULL, [role] VARCHAR(50) NULL, PRIMARY KEY CLUSTERED([Id] ASC))");
                cmd.ExecuteNonQuery();

                cmd.CommandText = ("IF NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'swp5_student') CREATE TABLE swp5_student ([Id] INT IDENTITY (1, 1) NOT NULL, [name] VARCHAR(50) NULL,[surname] VARCHAR(50) NULL, [birth] VARCHAR(50) NULL, [adress] VARCHAR(250) NULL, [email] VARCHAR(150) NULL, [ID_login] INT NULL, [school_class] VARCHAR(50) NULL, PRIMARY KEY CLUSTERED([Id] ASC))");
                cmd.ExecuteNonQuery();

                cmd.CommandText = ("IF NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'swp5_teacher') CREATE TABLE swp5_teacher ([Id] INT IDENTITY (1, 1) NOT NULL, [name] VARCHAR(50) NULL,[surname] VARCHAR(50) NULL, [birth] VARCHAR(50) NULL, [adress] VARCHAR(250) NULL, [email] VARCHAR(150) NULL, [ID_login] INT NULL, PRIMARY KEY CLUSTERED([Id] ASC))");
                cmd.ExecuteNonQuery();

                cmd.CommandText = ("IF NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'swp5_subject') CREATE TABLE swp5_subject ([Id] INT IDENTITY (1, 1) NOT NULL, [name] VARCHAR(50) NULL, [exam] BIT, PRIMARY KEY CLUSTERED([Id] ASC))");
                cmd.ExecuteNonQuery();

                cmd.CommandText = ("IF NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'swp5_subject_teacher') CREATE TABLE swp5_subject_teacher ([Id] INT IDENTITY (1, 1) NOT NULL, [ID_teacher] INT NULL, [ID_subject] INT NULL, PRIMARY KEY CLUSTERED([Id] ASC))");
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region Login
        public static bool CheckUsername(string chosen_username, string password)
        {
            //checks if the username and password are correct
            string hashedpw;

            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("SELECT password FROM swp5_login WHERE username = '" + chosen_username + "';");
                hashedpw = (string)cmd.ExecuteScalar();
                con.Close();

                if (hashedpw != null)
                {
                    if (BCrypt.CheckPassword(password, hashedpw))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Das Passwort ist falsch!");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Dieser Benutzername existiert nicht!");
                    return false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public static void create_user(string username, string password)
        {
            string salt;
            string hashedpw;
            //creates a user and proofs if the username or password are empty
            try
            {
                if (username == "" || password == "")
                {
                    MessageBox.Show("Falsche Eingabe");
                }
                else
                {
                    con.Open();
                    cmd.CommandText = ("SELECT password FROM swp5_login WHERE username = '" + username + "';");
                    string temp = (string)cmd.ExecuteScalar();
                    con.Close();



                    if (temp == null)
                    {
                        salt = BCrypt.GenerateSalt();
                        hashedpw = BCrypt.HashPassword(password, salt);



                        con.Open();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = ("INSERT INTO swp5_login (username, password, role) VALUES ('" + username + "', '" + hashedpw + "', 'admin');");
                        cmd.ExecuteNonQuery();
                        con.Close();



                        MessageBox.Show("Benutzer wurde erfolgreich erstellt!");
                        errormessage = false;
                    }
                    else
                    {
                        MessageBox.Show("Der Benutzername wird bereits verwendet!");
                        errormessage = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region DataGridView
        public static void SaveDG()
        {
            //saves the DataGrid in Verwaltung
            try
            {
                adp.UpdateCommand = CommandBuilder.GetUpdateCommand();
                adp.Update(dt);
                MessageBox.Show("Gespeichert!");
            }
            catch
            {
                MessageBox.Show("Ein Fehler ist aufgetreten!");
            }
        }

        #endregion

        public static string checkRole(string username)
        {
            //Checks the Role from a user
            string userRole;

            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("SELECT role FROM swp5_login WHERE username = '" + username + "';");
            userRole = (string)cmd.ExecuteScalar();
            con.Close();

            return userRole;
        }

        #region EVENT

        public static bool CheckEvent(string date)
        {
            con.Open();
            cmd.CommandText = ("SELECT Id FROM swp5_event where date = '" + date + "';");
            string temp = Convert.ToString(cmd.ExecuteScalar());
            con.Close();

            if (String.IsNullOrEmpty(temp))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void CreateEvent(string date, string place, string time, string eventName, string client, string contactPerson, string description)
        {
            //checks if all required data is filled
            if (String.IsNullOrEmpty(place) || String.IsNullOrEmpty(time) || String.IsNullOrEmpty(eventName) || String.IsNullOrEmpty(client))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus!");
                errormessage = true;
            }
            else
            {
                try
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("INSERT INTO swp5_event(date, place, time, eventName, client, contactPerson, description) VALUES('" + date + "', '" + place + "', '" + time + "', '" + eventName + "', '" + client + "', '" + contactPerson + "', '" + description + "');");
                    cmd.ExecuteNonQuery();
                    con.Close();

                    errormessage = false;
                    MessageBox.Show(eventName + " wurde hinzugefügt!");
                }
                catch (Exception e)
                {
                    con.Close();
                    MessageBox.Show(e.ToString());
                }
            }
        }

        public static void LoadEvent(string date)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT place FROM swp5_event where date = '" + date + "';");
                EventPlace = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT time FROM swp5_event where date = '" + date + "';");
                EventTime = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT eventName FROM swp5_event where date = '" + date + "';");
                EventeventName = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT client FROM swp5_event where date = '" + date + "';");
                EventClient = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT contactPerson FROM swp5_event where date = '" + date + "';");
                EventContactPerson = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT description FROM swp5_event where date = '" + date + "';");
                EventDescription = (string)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static void ChangeEvent(string date, string place, string time, string eventName, string client, string contactPerson, string description)
        {
            //checks if all required data is filled
            if (String.IsNullOrEmpty(place) || String.IsNullOrEmpty(time) || String.IsNullOrEmpty(eventName) || String.IsNullOrEmpty(client))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus!");
                errormessage = true;
            }
            else
            {
                try
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("UPDATE swp5_event set place = '" + place + "', time = '" + time + "', eventName = '" + eventName + "', client = '" + client + "', contactPerson = '" + contactPerson + "', description = '" + description + "' where date = '" + date + "';");
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(eventName + " wurde bearbeitet!");
                }
                catch (Exception e)
                {
                    con.Close();
                    MessageBox.Show(e.ToString());
                }
            }
        }

        #region StaffInUse
        public static void DeleteStaffInUse(string date)
        {
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("DELETE FROM swp5_staffInUse WHERE date = '" + date + "';");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static void AddStaffInUse(int staffID, string date)
        {
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("INSERT INTO swp5_staffInUse(staffID, date) VALUES('" + staffID + "', '" + date + "');");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static List<int> IDLoadStaffInUse = new List<int>();
        public static List<int> LoadStaffInUse(string date)
        {
            try
            {
                IDLoadStaffInUse.Clear();
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT staffID FROM swp5_staffInUse where date = '" + date + "'";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int temp = reader.GetInt32(0);
                        IDLoadStaffInUse.Add(temp);
                    }
                }
                con.Close();
                return IDLoadStaffInUse;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return IDLoadStaffInUse;
            }
        }
        #endregion

        #region EquipmentInUse
        public static void DeleteEquipInUse(string date)
        {
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("DELETE FROM swp5_equipInUse WHERE date = '" + date + "';");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }
        public static void AddEquipInUse(int equipID, string date)
        {
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("INSERT INTO swp5_equipInUse(equipID, date) VALUES('" + equipID + "', '" + date + "');");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static List<int> IDLoadEquipInUse = new List<int>();
        public static List<int> LoadEquipInUse(string date)
        {
            try
            {
                IDLoadEquipInUse.Clear();
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT equipID FROM swp5_equipInUse where date = '" + date + "'";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int temp = reader.GetInt32(0);
                        IDLoadEquipInUse.Add(temp);
                    }
                }
                con.Close();
                return IDLoadEquipInUse;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return IDLoadEquipInUse;
            }
        }
        #endregion
        #endregion

    }
}
