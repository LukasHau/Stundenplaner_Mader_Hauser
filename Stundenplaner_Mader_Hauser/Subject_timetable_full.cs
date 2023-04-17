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
    public partial class Subject_timetable_full : UserControl
    {
        public Subject_timetable_full()
        {
            InitializeComponent();
        }

        private void Subjcet_timetable_full_Load(object sender, EventArgs e)
        {

        }
        public void Subject_Name(string Subject)
        {
            lbl_subject.Text = Subject;
        }
    }
}
