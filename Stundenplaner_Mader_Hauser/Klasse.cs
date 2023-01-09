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
    public partial class Klasse : Form
    {
        public Klasse()
        {
            InitializeComponent();
        }

        private static int classID;


        private void Klasse_Load(object sender, EventArgs e)
        {
            dG_class.DataSource = ClassSQL.LoadDG();
        }

        private void btn_classLoad_Click(object sender, EventArgs e)
        {
            //if the checkbox is true a class gets added
            if (cb_classAdd.Checked)
            {
                ClassSQL.CreateClass(tb_className.Text, tb_classRoom.Text);
                clear();
            }
            else
            {
                //select a cell in the datagrid and load it into the forms
                if (dG_class.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dG_class.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedtRow = dG_class.Rows[selectedRowIndex];
                    string cellValue = Convert.ToString(selectedtRow.Cells["ID"].Value);

                    classID = Convert.ToInt32(cellValue);

                    ClassSQL.LoadClass(classID);
                    tb_className.Text = ClassSQL.ClassName;
                    tb_classRoom.Text = ClassSQL.ClassRoom;
                }
            }
        }

        private void btn_classDelete_Click(object sender, EventArgs e)
        {
            //select a cell in the datagrid and press delete, the whole class gets deleted
            if (dG_class.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dG_class.SelectedCells[0].RowIndex;
                DataGridViewRow selectedtRow = dG_class.Rows[selectedRowIndex];
                string cellValue = Convert.ToString(selectedtRow.Cells["ID"].Value);

                classID = Convert.ToInt32(cellValue);

                ClassSQL.DeleteClass(classID);
                clear();
            }
        }

        private void btn_classSave_Click(object sender, EventArgs e)
        {
            //if you press the button the class will be saved
            ClassSQL.updateClass(classID, tb_className.Text, tb_classRoom.Text);
            clear();
        }

        private void cb_classAdd_CheckedChanged(object sender, EventArgs e)
        {
            //if checkbox is checked the buttons get enabled and a text shows up
            if (cb_classAdd.Checked)
            {
                btn_classLoad.Text = "Hinzufügen";
                btn_classDelete.Enabled = false;
                btn_classSave.Enabled = false;
                clear();
            }
            else
            {
                btn_classLoad.Text = "Laden";
                btn_classDelete.Enabled = true;
                btn_classSave.Enabled = true;
            }
        }

        private void clear()
        {
            //clears all data
            dG_class.ClearSelection();
            dG_class.DataSource = ClassSQL.LoadDG();
            tb_className.Text = "";
            tb_classRoom.Text = "";
        }

        private void btn_classBack_Click(object sender, EventArgs e)
        {
            //on the button back you get to the main form
            Main_admin temp = new Main_admin();
            this.Close();
            temp.Show();
        }

        private void tb_classSearchDatabase_TextChanged(object sender, EventArgs e)
        {
            //if you search something in the searchbar it shows in the datagrid
            (dG_class.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '{0}%'", tb_classSearchDatabase.Text);
        }
    }
}
