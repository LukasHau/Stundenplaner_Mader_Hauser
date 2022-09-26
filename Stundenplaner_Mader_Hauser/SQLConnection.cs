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


        #region VariablesForEquipmentLoad
        public static string EqipmentName;
        public static string EqipmentDescription;
        public static string EqipmentPrice;
        public static string EqipmentInstallation;
        public static string EqipmentState;
        public static string EqipmentWarranty;
        public static string EqipmentInfo;

        public static List<int> IDSelectEquipment = new List<int>();
        public static string NameSelectEquipment;
        public static string DescriptionEquipment;
        #endregion

        #region VaiablesForStaffLoad
        public static string StaffName;
        public static string StaffSurname;
        public static string StaffAge;
        public static string StaffAdress;
        public static string StaffStartingDate;
        public static string StaffJob;
        public static string StaffInfo;

        public static List<int> IDSelectStaff = new List<int>();
        public static string SurnameSelectStaff;
        public static string NameSelectStaff;
        #endregion

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

        //Before the User connects to a Database, the program double checks the connection to the Database
        public static bool TryConnection()
        {
            try
            {
                con.Open();
                con.Close();
                return true;
            }

            catch (Exception e)
            {
                MessageBox.Show("Test at TryConnection\n" + e.Message);
                return false;
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

        public static DataTable LoadDataInDG()
        {
            //clears the DataTable
            dt.Clear();
            //shows the data in the DataGrid
            try
            {
                cmd = new SqlCommand("SELECT * FROM swp5_login", con);
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

        #region EQIPMENT
        public static void FillEquipment(string name, string description, decimal price, DateTime installation, string state, int warranty, string info)
        {
            //checks if all required data is filled
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(description) || price == 0 || String.IsNullOrEmpty(state))
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
                    cmd.CommandText = ("INSERT INTO swp5_equipment(name, description, price, installation, state, warranty, info) VALUES('" + name + "', '" +
                        description + "', '" + price + "', '" + installation.ToString() + "', '" + state + "', '" + warranty + "', '" + info + "');");
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
        }

        public static void LoadEqipment(int ID)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT name FROM swp5_equipment where ID = '" + ID + "';");
                EqipmentName = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT description FROM swp5_equipment where ID = '" + ID + "';");
                EqipmentDescription = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT price FROM swp5_equipment where ID = '" + ID + "';");
                EqipmentPrice = Convert.ToString((decimal)cmd.ExecuteScalar());

                cmd.CommandText = ("SELECT installation FROM swp5_equipment where ID = '" + ID + "';");
                EqipmentInstallation = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT state FROM swp5_equipment where ID = '" + ID + "';");
                EqipmentState = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT warranty FROM swp5_equipment where ID = '" + ID + "';");
                EqipmentWarranty = Convert.ToString((int)cmd.ExecuteScalar());

                cmd.CommandText = ("SELECT info FROM swp5_equipment where ID = '" + ID + "';");
                EqipmentInfo = (string)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static void ChangeEqipment(string name, string description, decimal price, DateTime installation, string state, int warranty, string info, int ID)
        {
            //checks if all required data is filled
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(description) || price == 0 || String.IsNullOrEmpty(state))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus!");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("UPDATE swp5_equipment set name = '" + name + "', description = '" + description + "', price = '" + price + "', installation = '" + installation.ToString() + "', state = '" + state + "', warranty = '" + warranty + "', info = '" + info + "' where ID = '" + ID + "';");
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

        public static void DeleteEqipment(int ID)
        {
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("DELETE FROM swp5_equipment WHERE ID = '" + ID + "';");
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(EqipmentName + " wurde gelöscht!");
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        #region GetEquipmentIndex

        public static List<int> SelectEquipmentID()
        {
            try
            {
                IDSelectEquipment.Clear();
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID FROM swp5_equipment";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int temp = reader.GetInt32(0);
                        IDSelectEquipment.Add(temp);
                    }
                }
                else
                {

                }
                con.Close();
                return IDSelectEquipment;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return IDSelectEquipment;
            }
        }

        public static void SelectEquipmentName(int ID)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT name FROM swp5_equipment where ID = '" + ID + "';");
                NameSelectEquipment = (string)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static void SelectEquipmentDescription(int ID)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT description FROM swp5_equipment where ID = '" + ID + "';");
                DescriptionEquipment = (string)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }
        #endregion
        #endregion

        #region WORKERS
        public static void FillStaff(string name, string surname, DateTime age, string adress, DateTime startingDate, string job, string info)
        {
            //checks if all required data is filled
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname) || String.IsNullOrEmpty(job))
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
                    cmd.CommandText = ("INSERT INTO swp5_staff(name, surname, age, adress, starting_date, job, info) VALUES('" + name + "', '" +
                        surname + "', '" + age.ToString() + "', '" + adress + "', '" + startingDate.ToString() + "', '" + job + "', '" + info + "');");
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
        }

        public static void LoadStaff(int ID)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT name FROM swp5_staff where ID = '" + ID + "';");
                StaffName = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT surname FROM swp5_staff where ID = '" + ID + "';");
                StaffSurname = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT age FROM swp5_staff where ID = '" + ID + "';");
                StaffAge = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT adress FROM swp5_staff where ID = '" + ID + "';");
                StaffAdress = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT starting_date FROM swp5_staff where ID = '" + ID + "';");
                StaffStartingDate = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT job FROM swp5_staff where ID = '" + ID + "';");
                StaffJob = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT info FROM swp5_staff where ID = '" + ID + "';");
                StaffInfo = (string)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static void ChangeStaff(string name, string surname, DateTime age, string adress, DateTime startingDate, string job, string info, int ID)
        {
            //checks if all required data is filled
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname) || String.IsNullOrEmpty(job))
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
                    cmd.CommandText = ("UPDATE swp5_staff set name = '" + name + "', surname = '" + surname + "', age = '" + age.ToString() + "', adress = '" + adress + "', starting_date = '" + startingDate.ToString() + "', info = '" + info + "',job = '" + job + "' where ID = '" + ID + "';");
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

        public static void DeleteStaff(int ID)
        {
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("DELETE FROM swp5_staff WHERE ID = '" + ID + "';");
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(StaffName + " wurde gelöscht!");
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        #region GetStaffIndex

        public static List<int> SelectStaffID()
        {
            try
            {
                IDSelectStaff.Clear();
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID FROM swp5_staff";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int temp = reader.GetInt32(0);
                        IDSelectStaff.Add(temp);
                    }
                }
                else
                {

                }
                con.Close();
                return IDSelectStaff;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return IDSelectStaff;
            }
        }

        public static void SelectStaffSurname(int ID)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT surname FROM swp5_staff where ID = '" + ID + "';");
                SurnameSelectStaff = (string)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static void SelectStaffName(int ID)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT name FROM swp5_staff where ID = '" + ID + "';");
                NameSelectStaff = (string)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }
        #endregion
        #endregion

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
