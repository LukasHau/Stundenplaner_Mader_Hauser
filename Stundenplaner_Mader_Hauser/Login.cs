using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stundenplaner_Mader_Hauser
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SQLConnection.TryConnectTODB();
            //hides the Password
            tB_login_password.PasswordChar = '*';
        }

        public static string userrole;
        public static string username;

        private void pB_Login_Click(object sender, EventArgs e)
        {
            username = tB_login_name.Text;
            string password = tB_login_password.Text;

            userrole = SQLConnection.checkRole(username);

            //Checks if the username and the password are correct
            if (SQLConnection.CheckUsername(username, password))
            {
                SQLConnection.choosen_username = username;

                Main_admin temp = new Main_admin();
                this.Hide();

                temp.Show();
            }

            tB_login_password.Text = string.Empty;
        }

        private void cB_passwordChar_CheckedChanged(object sender, EventArgs e)
        {
            //shows the user his password before pressing any button
            if (cB_passwordChar.Checked)
            {
                tB_login_password.PasswordChar = '\0';
            }
            else
            {
                tB_login_password.PasswordChar = '*';
            }
        }

        private void pB_addUser_Click(object sender, EventArgs e)
        {
            username = tB_login_name.Text;
            string password = tB_login_password.Text;

            SQLConnection.create_user(username, password);
            
            //toDo Registration
        }

        private void tB_login_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                username = tB_login_name.Text;
                string password = tB_login_password.Text;

                userrole = SQLConnection.checkRole(username);

                //Checks if the username and the password are correct
                if (SQLConnection.CheckUsername(username, password))
                {
                    SQLConnection.choosen_username = username;

                    Main_admin temp = new Main_admin();
                    this.Hide();

                    temp.Show();
                }

                tB_login_password.Text = "";

                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void tB_login_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                username = tB_login_name.Text;
                string password = tB_login_password.Text;

                userrole = SQLConnection.checkRole(username);

                //Checks if the username and the password are correct
                if (SQLConnection.CheckUsername(username, password))
                {
                    SQLConnection.choosen_username = username;

                    Main_admin temp = new Main_admin();
                    this.Hide();

                    temp.Show();
                }

                tB_login_password.Text = "";

                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
