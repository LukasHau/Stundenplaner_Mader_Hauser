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

        private void Schueler_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_studentLoad_Click(object sender, EventArgs e)
        {

        }

        private void btn_studentBack_Click(object sender, EventArgs e)
        {
            Main_admin temp = new Main_admin();
            this.Close();
            temp.Show();
        }
    }
}
