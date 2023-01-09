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

        private int ClassID;

        public Schueler()
        {
            InitializeComponent();

            //select class name
            foreach (int x in ClassSQL.LoadClassNamesID())
            {
                x.ToString();
                ClassSQL.SelectClassName(x);

                cB_class.Items.Add(x + ".    " + ClassSQL.NameSelectClass);
            }

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
                if (String.IsNullOrEmpty(tb_studentName.Text) || String.IsNullOrEmpty(tb_studentSurname.Text) || String.IsNullOrEmpty(tB_email.Text) || cB_sex.SelectedItem == null)
                {
                    MessageBox.Show("Bitte füllen Sie alle Felder aus!");
                }
                else
                {
                    if (!String.IsNullOrEmpty(cB_class.Text))
                    {
                        ClassID = Convert.ToInt32(cB_class.Text.Substring(0, cB_class.Text.IndexOf(".")));
                    }
                    else
                    {
                        ClassID = -1;
                    }

                    Student.CreateStudent(tb_studentName.Text, tb_studentSurname.Text, cB_sex.Text, dtp_studentBirth.Value.Date, tb_studentAdress.Text, tB_email.Text, 0, ClassID);
                    clear();
                }
            }
            else
            {
                if (dG_student.SelectedCells.Count > 0)
                {
                    //load student from database into the form
                    int selectedRowIndex = dG_student.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedtRow = dG_student.Rows[selectedRowIndex];
                    string cellValue = Convert.ToString(selectedtRow.Cells["ID"].Value);
                 
                    studentID = Convert.ToInt32(cellValue);

                    Student.LoadStudent(studentID);

                    clear();

                    tb_studentName.Text = Student.StudentName;
                    tb_studentSurname.Text = Student.StudentSurname;
                    cB_sex.SelectedItem = Student.StudentSex;
                    dtp_studentBirth.Value = Convert.ToDateTime(Student.StudentBirth);
                    tB_email.Text = Student.StudentEmail;
                    tb_studentAdress.Text = Student.StudentAdress;
                    ClassID = Student.StudentSchool_class;

                    for (int i = 0; i < cB_class.Items.Count; i++)
                    {
                        //checks if the value of the item before the '.' = the Index, is the same, if so it checks the value
                        if (cB_class.Items[i].ToString().Substring(0, cB_class.Items[i].ToString().IndexOf(".")).Contains(ClassID.ToString()))
                        {
                            cB_class.SelectedIndex = i;
                        }
                    }                 
                }
            }     
        }

        private void btn_studentBack_Click(object sender, EventArgs e)
        {
            //on the button back you get back into the main form
            Main_admin temp = new Main_admin();
            this.Close();
            temp.Show();
        }

        private void dG_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_searchDatabase_TextChanged(object sender, EventArgs e)
        {
            //if you search something in the searchbar it shows in the datagrid
            (dG_student.DataSource as DataTable).DefaultView.RowFilter = 
                string.Format("name LIKE '{0}%' OR surname LIKE '{0}%'", tb_searchDatabase.Text);
        }

        private void dG_student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
               
        }

        private void clear()
        {
            //clears everything
            dG_student.ClearSelection();
            dG_student.DataSource = Student.LoadDG();
            tb_studentName.Text = "";
            tb_studentSurname.Text = "";
            tB_email.Text = "";
            tb_studentAdress.Text = "";
            dtp_studentBirth.Text = "";
            cB_sex.SelectedIndex = -1;
            cB_class.SelectedIndex = -1;
        }

        private void cb_studentAdd_CheckedChanged(object sender, EventArgs e)
        {
            //if checkbox is checked the buttons get enabled and a text shows up
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
            //select a cell in the datagrid and press delete, the whole student gets deleted
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
            //if you press the button the student will be saved
            if (!String.IsNullOrEmpty(cB_class.Text))
            {
                ClassID = Convert.ToInt32(cB_class.Text.Substring(0, cB_class.Text.IndexOf(".")));
            }
            else
            {
                ClassID = -1;
            }
            Student.updateStudent(studentID, tb_studentName.Text, tb_studentSurname.Text, cB_sex.Text, dtp_studentBirth.Value.Date, tb_studentAdress.Text, tB_email.Text, ClassID);
            clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cB_sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
