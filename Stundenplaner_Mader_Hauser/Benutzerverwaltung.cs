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
    public partial class Benutzerverwaltung : Form
    {
        public Benutzerverwaltung()
        {
            InitializeComponent();
        }

        private void Benutzerverwaltung_Load(object sender, EventArgs e)
        {
            dG_teacher.DataSource = Teacher.LoadDGteacher();

            dG_student.DataSource = Student.LoadDGstudent();

            dG_user.DataSource = SQLConnection.LoadDGuser();
        }

        private void btn_studentBack_Click(object sender, EventArgs e)
        {
            //on the button back you get back into the main form
            Main_admin temp = new Main_admin();
            this.Close();
            temp.Show();
        }
    }
}
