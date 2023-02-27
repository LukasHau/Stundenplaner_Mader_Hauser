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
    public partial class Stundenplanbearbeitung : Form
    {
        public Stundenplanbearbeitung()
        {
            InitializeComponent();
        }

        int ClassID;

        private void Stundenplanbearbeitung_Load(object sender, EventArgs e)
        {
            ls.Clear();
            //select class name
            foreach (int x in ClassSQL.LoadClassNamesID())
            {
                x.ToString();
                ClassSQL.SelectClassName(x);

                cB_class.Items.Add(x + ".    " + ClassSQL.NameSelectClass);
            }
        }

        public List<ComboBox> cB = new List<ComboBox>();

        public void CreateCB(string day)
        {
            for (int i = 1; i < 9; i++)
            {              
                ComboBox b = new ComboBox();
                b.Name = "cB_" + day + i;
                //Location machen!!!!
                b.Location = new Point(100, 50);
                //Liste geht :)
                foreach (string x in SubjectSQL.AllSubjects())
                {
                    b.Items.Add(x);
                }
                b.Items.Add("Freistunde");                           
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
            MessageBox.Show(ClassID.ToString());
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            CreateCB("monday1");
        }
    }
}
