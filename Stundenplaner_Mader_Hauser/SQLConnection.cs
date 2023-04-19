using MySql.Data.MySqlClient;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        #region Connection
        //sets the connection string
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

                cmd.CommandText = ("IF NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'swp5_student') CREATE TABLE swp5_student ([Id] INT IDENTITY (1, 1) NOT NULL, [name] VARCHAR(50) NULL,[surname] VARCHAR(50) NULL, [sex] VARCHAR(10) NULL, [birth] VARCHAR(50) NULL, [adress] VARCHAR(250) NULL, [email] VARCHAR(150) NULL, [ID_login] INT NULL, [school_class] INT NULL, PRIMARY KEY CLUSTERED([Id] ASC))");
                cmd.ExecuteNonQuery();

                cmd.CommandText = ("IF NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'swp5_teacher') CREATE TABLE swp5_teacher ([Id] INT IDENTITY (1, 1) NOT NULL, [name] VARCHAR(50) NULL,[surname] VARCHAR(50) NULL, [sex] VARCHAR(10) NULL, [birth] VARCHAR(50) NULL, [adress] VARCHAR(250) NULL, [email] VARCHAR(150) NULL, [ID_login] INT NULL, PRIMARY KEY CLUSTERED([Id] ASC))");
                cmd.ExecuteNonQuery();

                cmd.CommandText = ("IF NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'swp5_subject') CREATE TABLE swp5_subject ([Id] INT IDENTITY (1, 1) NOT NULL, [name] VARCHAR(50) NULL, [fullname] VARCHAR(150) NULL, [exam] INT, PRIMARY KEY CLUSTERED([Id] ASC))");
                cmd.ExecuteNonQuery();

                cmd.CommandText = ("IF NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'swp5_subject_teacher') CREATE TABLE swp5_subject_teacher ([Id] INT IDENTITY (1, 1) NOT NULL, [ID_teacher] INT NULL, [ID_subject] INT NULL, PRIMARY KEY CLUSTERED([Id] ASC))");
                cmd.ExecuteNonQuery();

                cmd.CommandText = ("IF NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'swp5_class') CREATE TABLE swp5_class ([Id] INT IDENTITY (1, 1) NOT NULL, [name] VARCHAR(50) NULL, [room] VARCHAR(50) NULL, PRIMARY KEY CLUSTERED([Id] ASC))");
                cmd.ExecuteNonQuery();

                cmd.CommandText = ("IF NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'swp5_schedule') CREATE TABLE swp5_schedule ([Id] INT IDENTITY (1, 1) NOT NULL, [dayOfWeek] INT NULL, [hour] INT NULL, [subject] INT NULL, [classID] INT NULL, PRIMARY KEY CLUSTERED([Id] ASC))");
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

        public static string checkRole(string username)
        {
            //checks the Role from a user
            string userRole;

            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("SELECT role FROM swp5_login WHERE username = '" + username + "';");
            userRole = (string)cmd.ExecuteScalar();
            con.Close();

            return userRole;
        }

        public static int GetIDLogin(string username)
        {
            //get the ID from the logged in user
            int IDLogin;

            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("SELECT ID FROM swp5_login WHERE username = '" + username + "';");
            IDLogin = (int)cmd.ExecuteScalar();
            con.Close();

            return IDLogin;
        }

        public static bool check(int ID)
        {
            //checks if the logged in user is a student
            con.Open();
            cmd.CommandText = ("SELECT name FROM swp5_student WHERE ID_login = '" + ID + "';");
            string temp = (string)cmd.ExecuteScalar();
            con.Close();
            if(temp == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static int GetClassID(int ID_login)
        {
            //get the CLASS from the logged in user
            int ClassID;

            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("SELECT school_class FROM swp5_student WHERE ID_login = '" + ID_login + "';");
            ClassID = (int)cmd.ExecuteScalar();
            con.Close();

            return ClassID;
        }

        public static DataTable LoadDGuser()
        {
            //clears the DataTable
            dt.Clear();
            //shows the data in the DataGrid
            try
            {
                cmd = new SqlCommand("SELECT Id, username, role FROM swp5_login", con);
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

        #region Subject_teacher
        public static void DeleteTeacherSubject(int teacherID)
        {
            //delete a subject from a teacher
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("DELETE FROM swp5_subject_teacher WHERE ID_teacher = '" + teacherID + "';");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static void AddTeacherSubject(int teacherID, int subjectID)
        {
            //add a subject to a teacher
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("INSERT INTO swp5_subject_teacher(ID_teacher, ID_subject) VALUES('" + teacherID + "', '" + subjectID + "');");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static List<int> IDLoadSubjectTeacher = new List<int>();
        public static List<int> LoadSubjectTeacher(int TeacherID)
        {
            //load all subjects from a teacher
            try
            {
                IDLoadSubjectTeacher.Clear();
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID_subject FROM swp5_subject_teacher where ID_teacher = '" + TeacherID + "'";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int temp = reader.GetInt32(0);
                        IDLoadSubjectTeacher.Add(temp);
                    }
                }
                con.Close();
                return IDLoadSubjectTeacher;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return IDLoadSubjectTeacher;
            }
        }
        #endregion

    }
}
