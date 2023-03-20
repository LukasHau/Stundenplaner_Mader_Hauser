﻿using System;
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
    public partial class Stundenplanbearbeitung : Form
    {
        public Stundenplanbearbeitung()
        {
            InitializeComponent();
        }

        int ClassID;

        private void Stundenplanbearbeitung_Load(object sender, EventArgs e)
        {
            CBonForm("monday", 108);
            CBonForm("tuesday", 234);
            CBonForm("wednesday", 360);
            CBonForm("thursday", 486);
            CBonForm("friday", 612);

            //select class name
            foreach (int x in ClassSQL.LoadClassNamesID())
            {
                x.ToString();
                ClassSQL.SelectClassName(x);

                cB_class.Items.Add(x + ".    " + ClassSQL.NameSelectClass);
            }
        }

        public List<ComboBox> cB = new List<ComboBox>();

        public void CreateCB(string day, int x1, int y1)
        {
            for (int i = 1; i < 9; i++)
            {              
                ComboBox b = new ComboBox();
                b.Name = "cB_" + day;
                b.Location = new Point(x1, y1);
                b.Size = new Size(102, 23);
                foreach (string x in SubjectSQL.AllSubjects())
                {
                    b.Items.Add(x);
                }
                this.Controls.Add(b);
            }           
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //on the button back you get back into the main form
            Main_admin temp = new Main_admin();
            this.Close();
            temp.Show();
        }

        private void cB_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassID = Convert.ToInt32(cB_class.Text.Substring(0, cB_class.Text.IndexOf(".")));
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SubjectSQL.DeleteSchedule(ClassID);
            GetSubjectName("monday", 1);
            GetSubjectName("tuesday", 2);
            GetSubjectName("wednesday", 3);
            GetSubjectName("thursday", 4);
            GetSubjectName("friday", 5);
        }

        private void GetSubjectName(string day, int day_number)
        {
            foreach (Control c in Controls)
            {
                for (int i = 1; i < 9; i++)
                {
                    if (!c.Name.Equals("cB_" + day + i))
                    {
                        continue;
                    }

                    ComboBox cB = c as ComboBox;
                    if (cB.SelectedItem == null)
                    {
                        continue;
                    }

                    SubjectSQL.FillSchedule(day_number, i, SubjectSQL.SelectSubjectID(cB.SelectedItem.ToString()), ClassID);
                }
            }
        }

        private void CBonForm(string day_name, int x)
        {
            int y = 94;
            for (int i = 1; i < 9; i++)
            {
                string temp = day_name + i;
                CreateCB(temp, x, y);
                y = y + 36;
            }
        }
    }
}
