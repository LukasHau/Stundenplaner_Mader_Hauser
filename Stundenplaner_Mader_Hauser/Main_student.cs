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
    public partial class Main_student : Form
    {
        public Main_student()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            //log out
            Login temp = new Login();
            this.Close();
            temp.Show();
        }

        private void btn_timetalbe_Click(object sender, EventArgs e)
        {
            //changes the form to the schedule
            Calendar temp = new Calendar();
            this.Close();
            temp.Show();
        }

        private void Main_student_Load(object sender, EventArgs e)
        {
            //shows a label, that welcomes the user
            lbl_wellcome.Text = "Willkommen, " + Login.username;
        }
    }
}
