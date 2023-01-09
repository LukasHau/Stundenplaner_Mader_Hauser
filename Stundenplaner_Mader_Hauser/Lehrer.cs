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
    public partial class Lehrer : Form
    {
        public Lehrer()
        {
            InitializeComponent();
        }

        private static int teacherID;
        private static int subjectID;

        private void Lehrer_Load(object sender, EventArgs e)
        {
            dG_teacher.DataSource = Teacher.LoadDG();

            //add the subjects in the form
            foreach (int x in SubjectSQL.SelectSubjectID())
            {
                x.ToString();
                SubjectSQL.SelectSubjectName(x);

                cLBTeacher.Items.Add(x + ".       " + SubjectSQL.NameSelectSubject);
            }
        }

        private void btn_teacherLoad_Click(object sender, EventArgs e)
        {
            if (cb_teacherAdd.Checked)
            {
                //checks if all required data is filled
                if (String.IsNullOrEmpty(tb_teacherName.Text) || String.IsNullOrEmpty(tb_teacherSurname.Text) || String.IsNullOrEmpty(tB_teacherEmail.Text) || cB_sex.SelectedItem == null)
                {
                    MessageBox.Show("Bitte füllen Sie alle Felder aus!");
                }
                else
                {
                    //create teacher in the database
                    Teacher.CreateTeacher(tb_teacherName.Text, tb_teacherSurname.Text, cB_sex.Text, dtp_teacherBirth.Value.Date, tb_teacherAdress.Text, tB_teacherEmail.Text, 0);

                    int teacher_temp = Teacher.GetTeacherID(tb_teacherName.Text, tb_teacherSurname.Text, cB_sex.Text, dtp_teacherBirth.Value.Date);

                    SQLConnection.DeleteTeacherSubject(teacher_temp);

                    if (cLBTeacher.CheckedItems.Count != 0)
                    {
                        // If so, loop through all checked items and print results.

                        for (int x = 0; x < cLBTeacher.CheckedItems.Count; x++)
                        {
                            //cuts the string after the point, to get the ID of the subject
                            subjectID = Convert.ToInt32(cLBTeacher.CheckedItems[x].ToString().Substring(0, cLBTeacher.CheckedItems[x].ToString().IndexOf(".")));

                            SQLConnection.AddTeacherSubject(teacher_temp, subjectID);
                        }
                    }

                    clear();
                }
            }
            else
            {              
                if (dG_teacher.SelectedCells.Count > 0)
                {
                    //load teacher from database into the form
                    int selectedRowIndex = dG_teacher.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedtRow = dG_teacher.Rows[selectedRowIndex];
                    string cellValue = Convert.ToString(selectedtRow.Cells["ID"].Value);

                    teacherID = Convert.ToInt32(cellValue);

                    Teacher.LoadTeacher(teacherID);

                    clear();

                    tb_teacherName.Text = Teacher.TeacherName;
                    tb_teacherSurname.Text = Teacher.TeacherSurname;
                    cB_sex.SelectedItem = Teacher.TeacherSex;
                    dtp_teacherBirth.Value = Convert.ToDateTime(Teacher.TeacherBirth);
                    tB_teacherEmail.Text = Teacher.TeacherEmail;
                    tb_teacherAdress.Text = Teacher.TeacherAdress;

                    //load the subject from the teacher
                    foreach (int x in SQLConnection.LoadSubjectTeacher(teacherID))
                    {
                        //for every item in the CheckedListBox
                        for (int i = 0; i < cLBTeacher.Items.Count; i++)
                        {
                            //checks if the value of the item before the '.' = the Index, is the same, if so it checks the value
                            if (cLBTeacher.Items[i].ToString().Substring(0, cLBTeacher.Items[i].ToString().IndexOf(".")).Contains(x.ToString()))
                            {
                                cLBTeacher.SetItemChecked(i, true);
                            }
                        }
                    }

                }
            }
        }

        private void btn_teacherBack_Click(object sender, EventArgs e)
        {
            //on the button back you get back into the main form
            Main_admin temp = new Main_admin();
            this.Close();
            temp.Show();
        }

        private void tb_teacherSearchDatabase_TextChanged(object sender, EventArgs e)
        {
            //if you search something in the searchbar it shows in the datagrid
            (dG_teacher.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '{0}%' OR surname LIKE '{0}%'", tb_teacherSearchDatabase.Text);
        }

        private void clear()
        {
            //clear everything
            dG_teacher.ClearSelection();
            dG_teacher.DataSource = Teacher.LoadDG();
            tb_teacherName.Text = "";
            tb_teacherSurname.Text = "";
            tB_teacherEmail.Text = "";
            tb_teacherAdress.Text = "";
            dtp_teacherBirth.Text = "";
            cB_sex.SelectedIndex = -1;

            //uncheck all items on the CheckedListbox
            for (int i = 0; i < cLBTeacher.Items.Count; i++)
            {
                cLBTeacher.SetItemChecked(i, false);
            }
        }

        private void cb_teacherAdd_CheckedChanged(object sender, EventArgs e)
        {
            //if checkbox is checked the buttons get enabled and a text shows up
            if (cb_teacherAdd.Checked)
            {
                btn_teacherLoad.Text = "Hinzufügen";
                btn_teacherDelete.Enabled = false;
                btn_teacherSave.Enabled = false;
                clear();
            }
            else
            {
                btn_teacherLoad.Text = "Laden";
                btn_teacherDelete.Enabled = true;
                btn_teacherSave.Enabled = true;
            }
        }

        private void btn_teacherDelete_Click(object sender, EventArgs e)
        {
            //select a cell in the datagrid and press delete, the whole teacher gets deleted
            if (dG_teacher.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dG_teacher.SelectedCells[0].RowIndex;
                DataGridViewRow selectedtRow = dG_teacher.Rows[selectedRowIndex];
                string cellValue = Convert.ToString(selectedtRow.Cells["ID"].Value);

                teacherID = Convert.ToInt32(cellValue);

                Teacher.DeleteTeacher(teacherID);
                SQLConnection.DeleteTeacherSubject(teacherID);
                clear();
            }
        }

        private void btn_teacherSave_Click(object sender, EventArgs e)
        {
            //if you press the button the teacher will be saved
            Teacher.updateTeacher(teacherID, tb_teacherName.Text, tb_teacherSurname.Text, cB_sex.Text, dtp_teacherBirth.Value.Date, tb_teacherAdress.Text, tB_teacherEmail.Text);

            SQLConnection.DeleteTeacherSubject(teacherID);

            if (cLBTeacher.CheckedItems.Count != 0)
            {
                // If so, loop through all checked items and print results.

                for (int x = 0; x < cLBTeacher.CheckedItems.Count; x++)
                {
                    //cuts the string after the point, to get the ID of the subject
                    subjectID = Convert.ToInt32(cLBTeacher.CheckedItems[x].ToString().Substring(0, cLBTeacher.CheckedItems[x].ToString().IndexOf(".")));

                    SQLConnection.AddTeacherSubject(teacherID, subjectID);

                }
            }
            clear();
        }
    }
}
