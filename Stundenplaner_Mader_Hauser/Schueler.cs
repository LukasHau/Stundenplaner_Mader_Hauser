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
        private bool buttonStudentLoadWasClicked = false;
        public Schueler()
        {
            InitializeComponent();
        }

        private void Schueler_Load_1(object sender, EventArgs e)
        {
            dG_student.DataSource = Student.LoadDG();
        }

        private void btn_studentLoad_Click(object sender, EventArgs e)
        {
            if (dG_student.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dG_student.SelectedCells[0].RowIndex;
                DataGridViewRow selectedtRow = dG_student.Rows[selectedRowIndex];
                string cellValue = Convert.ToString(selectedtRow.Cells["ID"].Value);

                MessageBox.Show(cellValue);
            }
        }

        private void btn_studentBack_Click(object sender, EventArgs e)
        {
            Main_admin temp = new Main_admin();
            this.Close();
            temp.Show();
        }

        private void btn_studentAdd_Click(object sender, EventArgs e)
        {
            //checks if all required data is filled
            if (String.IsNullOrEmpty(tb_studentName.Text) || String.IsNullOrEmpty(tb_studentSurname.Text) || String.IsNullOrEmpty(tB_email.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus!");
            }
            else
            {
                Student.CreateStudent(tb_studentName.Text, tb_studentSurname.Text, dtp_studentBirth.Value.Date, tb_studentAdress.Text, tB_email.Text, 0, "to fill");
            }
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
    }
}
