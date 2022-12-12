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
    public partial class Main_admin : Form
    {
        public Main_admin()
        {
            InitializeComponent();
        }

        private void Main_admin_Load(object sender, EventArgs e)
        {
            lbl_wellcome.Text = "Willkommen, " + Login.username;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login temp = new Login();
            this.Close();
            temp.Show();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            Schueler temp = new Schueler();
            this.Close();
            temp.Show();
        }

        private void btn_teacher_Click(object sender, EventArgs e)
        {
            Lehrer temp = new Lehrer();
            this.Close();
            temp.Show();
        }

        private void btn_classes_Click(object sender, EventArgs e)
        {
            Klasse temp = new Klasse();
            this.Close();
            temp.Show();
        }

        private void btn_subjects_Click(object sender, EventArgs e)
        {
            Subject temp = new Subject();
            this.Close();
            temp.Show();
        }
    }
}
