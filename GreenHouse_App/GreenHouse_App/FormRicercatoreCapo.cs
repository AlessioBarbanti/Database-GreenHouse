using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenHouse_App
{
    public partial class FormRicercatoreCapo : Form
    {
        public FormRicercatoreCapo()
        {
            InitializeComponent();
        }

        private void RevisioniInScadenza_Click(object sender, EventArgs e)
        {
            FormRicercatoreCapo2 f2 = new FormRicercatoreCapo2();
            f2.ShowDialog();
        }
    }
}
