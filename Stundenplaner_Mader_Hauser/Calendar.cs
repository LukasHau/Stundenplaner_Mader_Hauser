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
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }

        int ClassID;
        int daysMultiplyer = 0;

        private void Calendar_Load(object sender, EventArgs e)
        {
            lbl_name.Text = Login.username;
            displayDays();

            //select class name
            foreach (int x in ClassSQL.LoadClassNamesID())
            {
                x.ToString();
                ClassSQL.SelectClassName(x);

                cB_class.Items.Add(x + ".    " + ClassSQL.NameSelectClass);
            }
        }

        private void displayDays()
        {
            var monday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + daysMultiplyer + (int)DayOfWeek.Monday);
            var tuesday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + daysMultiplyer + (int)DayOfWeek.Tuesday);
            var wednesday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + daysMultiplyer + (int)DayOfWeek.Wednesday);
            var thursday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + daysMultiplyer + (int)DayOfWeek.Thursday);
            var friday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + daysMultiplyer + (int)DayOfWeek.Friday);

            lbl_date1.Text = monday.ToString("dd. MMMM");
            lbl_date2.Text = tuesday.ToString("dd. MMMM");
            lbl_date3.Text = wednesday.ToString("dd. MMMM");
            lbl_date4.Text = thursday.ToString("dd. MMMM");
            lbl_date5.Text = friday.ToString("dd. MMMM");

            int subjectClass = 2;

            for (int i = 1; i < 9; i++)
            {
                Subject_timetable_full SubjectFull = new Subject_timetable_full();               
                SubjectFull.Subject_Name(ClassSQL.SelectSubjectID(subjectClass, 1, i));
                subjectContainerMonday.Controls.Add(SubjectFull);
            }

            for (int i = 1; i < 9; i++)
            {
                Subject_timetable_full SubjectFull = new Subject_timetable_full();
                SubjectFull.Subject_Name(ClassSQL.SelectSubjectID(subjectClass, 2, i));
                subjectContainerThuesday.Controls.Add(SubjectFull);
            }

            for (int i = 1; i < 9; i++)
            {
                Subject_timetable_full SubjectFull = new Subject_timetable_full();
                SubjectFull.Subject_Name(ClassSQL.SelectSubjectID(subjectClass, 3, i));
                subjectContainerWednesday.Controls.Add(SubjectFull);
            }

            for (int i = 1; i < 9; i++)
            {
                Subject_timetable_full SubjectFull = new Subject_timetable_full();
                SubjectFull.Subject_Name(ClassSQL.SelectSubjectID(subjectClass, 4, i));
                subjectContainerThursday.Controls.Add(SubjectFull);
            }

            for (int i = 1; i < 9; i++)
            {
                Subject_timetable_full SubjectFull = new Subject_timetable_full();
                SubjectFull.Subject_Name(ClassSQL.SelectSubjectID(subjectClass, 5, i));
                subjectContainerFriday.Controls.Add(SubjectFull);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //on the button back you get back into the main form
            Main_admin temp = new Main_admin();
            this.Close();
            temp.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_nextWeek_Click(object sender, EventArgs e)
        {
            daysMultiplyer = daysMultiplyer + 7;
            displayDays();
        }

        private void btn_previousWeek_Click(object sender, EventArgs e)
        {
            daysMultiplyer = daysMultiplyer - 7;
            displayDays();
        }

        private void btn_today_Click(object sender, EventArgs e)
        {
            daysMultiplyer = 0;
            displayDays();
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void cB_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassID = Convert.ToInt32(cB_class.Text.Substring(0, cB_class.Text.IndexOf(".")));
            MessageBox.Show(ClassID.ToString());
        }
    }
}
