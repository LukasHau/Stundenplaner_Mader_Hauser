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
            if (cb_classAdd.Checked)
            {
                ClassSQL.CreateClass(tb_className.Text, tb_classRoom.Text);
                clear();
            }
            else
            {
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
            ClassSQL.updateClass(classID, tb_className.Text, tb_classRoom.Text);
            clear();
        }

        private void cb_classAdd_CheckedChanged(object sender, EventArgs e)
        {
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
            dG_class.ClearSelection();
            dG_class.DataSource = ClassSQL.LoadDG();
            tb_className.Text = "";
            tb_classRoom.Text = "";
        }

        private void btn_classBack_Click(object sender, EventArgs e)
        {
            Main_admin temp = new Main_admin();
            this.Close();
            temp.Show();
        }
    }
}
