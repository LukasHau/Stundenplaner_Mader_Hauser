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

        private void Lehrer_Load(object sender, EventArgs e)
        {
            dG_teacher.DataSource = Teacher.LoadDG();
        }

        private void btn_teacherLoad_Click(object sender, EventArgs e)
        {
            if (cb_teacherAdd.Checked)
            {
                //checks if all required data is filled
                if (String.IsNullOrEmpty(tb_teacherName.Text) || String.IsNullOrEmpty(tb_teacherSurname.Text) || String.IsNullOrEmpty(tB_teacherEmail.Text))
                {
                    MessageBox.Show("Bitte füllen Sie alle Felder aus!");
                }
                else
                {
                    Teacher.CreateTeacher(tb_teacherName.Text, tb_teacherSurname.Text, dtp_teacherBirth.Value.Date, tb_teacherAdress.Text, tB_teacherEmail.Text, 0);
                    clear();
                }
            }
            else
            {
                if (dG_teacher.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dG_teacher.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedtRow = dG_teacher.Rows[selectedRowIndex];
                    string cellValue = Convert.ToString(selectedtRow.Cells["ID"].Value);

                    teacherID = Convert.ToInt32(cellValue);

                    Teacher.LoadTeacher(teacherID);
                    tb_teacherName.Text = Teacher.TeacherName;
                    tb_teacherSurname.Text = Teacher.TeacherSurname;
                    dtp_teacherBirth.Value = Convert.ToDateTime(Teacher.TeacherBirth);
                    tB_teacherEmail.Text = Teacher.TeacherEmail;
                    tb_teacherAdress.Text = Teacher.TeacherAdress;
                }
            }
        }

        private void btn_teacherBack_Click(object sender, EventArgs e)
        {
            Main_admin temp = new Main_admin();
            this.Close();
            temp.Show();
        }

        private void tb_teacherSearchDatabase_TextChanged(object sender, EventArgs e)
        {
            (dG_teacher.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '{0}%' OR surname LIKE '{0}%'", tb_teacherSearchDatabase.Text);
        }

        private void clear()
        {
            dG_teacher.ClearSelection();
            dG_teacher.DataSource = Teacher.LoadDG();
            tb_teacherName.Text = "";
            tb_teacherSurname.Text = "";
            tB_teacherEmail.Text = "";
            tb_teacherAdress.Text = "";
            dtp_teacherBirth.Text = "";
        }

        private void cb_teacherAdd_CheckedChanged(object sender, EventArgs e)
        {
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
            if (dG_teacher.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dG_teacher.SelectedCells[0].RowIndex;
                DataGridViewRow selectedtRow = dG_teacher.Rows[selectedRowIndex];
                string cellValue = Convert.ToString(selectedtRow.Cells["ID"].Value);

                teacherID = Convert.ToInt32(cellValue);

                Teacher.DeleteTeacher(teacherID);
                clear();
            }
        }

        private void btn_teacherSave_Click(object sender, EventArgs e)
        {
            Teacher.updateTeacher(teacherID, tb_teacherName.Text, tb_teacherSurname.Text, dtp_teacherBirth.Value.Date, tb_teacherAdress.Text, tB_teacherEmail.Text);
            clear();
        }
    }
}
