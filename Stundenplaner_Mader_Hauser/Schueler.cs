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
    public partial class Schueler : Form
    {
        public Schueler()
        {
            InitializeComponent();
        }

        private static int studentID;

        private void Schueler_Load_1(object sender, EventArgs e)
        {
            dG_student.DataSource = Student.LoadDG();
        }

        private void btn_studentLoad_Click(object sender, EventArgs e)
        {
            if (cb_studentAdd.Checked)
            {
                //checks if all required data is filled
                if (String.IsNullOrEmpty(tb_studentName.Text) || String.IsNullOrEmpty(tb_studentSurname.Text) || String.IsNullOrEmpty(tB_email.Text))
                {
                    MessageBox.Show("Bitte füllen Sie alle Felder aus!");
                }
                else
                {
                    Student.CreateStudent(tb_studentName.Text, tb_studentSurname.Text, dtp_studentBirth.Value.Date, tb_studentAdress.Text, tB_email.Text, 0, "to fill");
                    clear();
                }
            }
            else
            {
                if (dG_student.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dG_student.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedtRow = dG_student.Rows[selectedRowIndex];
                    string cellValue = Convert.ToString(selectedtRow.Cells["ID"].Value);

                    studentID = Convert.ToInt32(cellValue);

                    Student.LoadStudent(studentID);
                    tb_studentName.Text = Student.StudentName;
                    tb_studentSurname.Text = Student.StudentSurname;
                    dtp_studentBirth.Value = Convert.ToDateTime(Student.StudentBirth);
                    tB_email.Text = Student.StudentEmail;
                    tb_studentAdress.Text = Student.StudentAdress;
                    tb_studentClass.Text = Student.StudentSchool_class;        
                }
            }     
        }

        private void btn_studentBack_Click(object sender, EventArgs e)
        {
            Main_admin temp = new Main_admin();
            this.Close();
            temp.Show();
        }

        private void dG_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_searchDatabase_TextChanged(object sender, EventArgs e)
        {
            (dG_student.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '{0}%' OR surname LIKE '{0}%'", tb_searchDatabase.Text);
        }

        private void dG_student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
               
        }

        private void clear()
        {
            dG_student.ClearSelection();
            dG_student.DataSource = Student.LoadDG();
            tb_studentName.Text = "";
            tb_studentSurname.Text = "";
            tB_email.Text = "";
            tb_studentClass.Text = "";
            tb_studentAdress.Text = "";
            dtp_studentBirth.Text = "";
        }

        private void cb_studentAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_studentAdd.Checked)
            {
                btn_studentLoad.Text = "Hinzufügen";
                btn_studentDelete.Enabled = false;
                btn_studentSave.Enabled = false;
                clear();
            }
            else
            {
                btn_studentLoad.Text = "Laden";
                btn_studentDelete.Enabled = true;
                btn_studentSave.Enabled = true;
            }
        }

        private void btn_studentDelete_Click(object sender, EventArgs e)
        {
            if (dG_student.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dG_student.SelectedCells[0].RowIndex;
                DataGridViewRow selectedtRow = dG_student.Rows[selectedRowIndex];
                string cellValue = Convert.ToString(selectedtRow.Cells["ID"].Value);

                studentID = Convert.ToInt32(cellValue);

                Student.DeleteStudent(studentID);
                clear();
            }
        }

        
        private void btn_studentSave_Click(object sender, EventArgs e)
        {
            Student.updateStudent(studentID, tb_studentName.Text, tb_studentSurname.Text, dtp_studentBirth.Value.Date, tb_studentAdress.Text, tB_email.Text);
            clear();
        }
    }
}
