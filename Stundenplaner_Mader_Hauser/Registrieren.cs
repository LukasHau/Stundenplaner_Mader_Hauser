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
    public partial class Registrieren : Form
    {
        public Registrieren()
        {
            InitializeComponent();
        }

        private void Registrieren_Load(object sender, EventArgs e)
        {
            tB_password.PasswordChar = '*';
            tB_password2.PasswordChar = '*';
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string username = tB_name.Text;
            string password = tB_password.Text;
            string password2 = tB_password2.Text;

            if (password == password2)
            {
                SQLConnection.create_user(username, password);

                //close the form, but only if the registration was succesfull
                if (SQLConnection.errormessage == false)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Passwörter stimmen nicht überein!", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_password.Clear();
                tB_password2.Clear();
            }
        }
    }
}
