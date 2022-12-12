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
    public partial class Subject : Form
    {
        public Subject()
        {
            InitializeComponent();
        }

        int exam = 0;
        private static int subjectID;

        private void Subject_Load(object sender, EventArgs e)
        {
            dG_subject.DataSource = SubjectSQL.LoadDG();
        }

        private void btn_teacherSave_Click(object sender, EventArgs e)
        {
            SubjectSQL.updateSubject(subjectID, tb_SubjectName.Text, tb_SubjectFullname.Text, exam);
            clear();
        }

        private void btn_subjectLoad_Click(object sender, EventArgs e)
        {
            if (cb_subjectAdd.Checked)
            {
                    SubjectSQL.CreateSubject(tb_SubjectName.Text, tb_SubjectFullname.Text, exam);
                    clear();
            }
            else
            {
                if (dG_subject.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dG_subject.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedtRow = dG_subject.Rows[selectedRowIndex];
                    string cellValue = Convert.ToString(selectedtRow.Cells["ID"].Value);

                    subjectID = Convert.ToInt32(cellValue);

                    SubjectSQL.LoadSubject(subjectID);
                    tb_SubjectName.Text = SubjectSQL.SubjectName;
                    tb_SubjectFullname.Text = SubjectSQL.SubjectFullname;
                    if(SubjectSQL.SubjectSA == 1)
                    {
                        cB_subjectSchularbeit.Checked = true;
                    }
                    else
                    {
                        cB_subjectSchularbeit.Checked = false;
                    }
                }
            }
        }

        private void cB_subjectSchularbeit_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_subjectSchularbeit.Checked)
            {
                exam = 1;
            }
            else
            {
                exam = 0;
            }
        }

        private void btn_subejctDelete_Click(object sender, EventArgs e)
        {
            if (dG_subject.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dG_subject.SelectedCells[0].RowIndex;
                DataGridViewRow selectedtRow = dG_subject.Rows[selectedRowIndex];
                string cellValue = Convert.ToString(selectedtRow.Cells["ID"].Value);

                subjectID = Convert.ToInt32(cellValue);

                SubjectSQL.DeleteSubject(subjectID);
                clear();
            }
        }

        private void clear()
        {
            dG_subject.ClearSelection();
            dG_subject.DataSource = SubjectSQL.LoadDG();
            tb_SubjectName.Text = "";
            tb_SubjectFullname.Text = "";
            cB_subjectSchularbeit.Checked = false;
        }

        private void cb_subjectAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_subjectAdd.Checked)
            {
                btn_subjectLoad.Text = "Hinzufügen";
                btn_subejctDelete.Enabled = false;
                btn_subejctSave.Enabled = false;
                clear();
            }
            else
            {
                btn_subjectLoad.Text = "Laden";
                btn_subejctDelete.Enabled = true;
                btn_subejctSave.Enabled = true;
            }
        }

        private void btn_subjectBack_Click(object sender, EventArgs e)
        {
            Main_admin temp = new Main_admin();
            this.Close();
            temp.Show();
        }

        private void btn_subjectSearch_Click(object sender, EventArgs e)
        {

        }

        private void tb_subjectSearchDatabase_TextChanged(object sender, EventArgs e)
        {
            (dG_subject.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '{0}%'", tb_subjectSearchDatabase.Text);
        }
    }
}
