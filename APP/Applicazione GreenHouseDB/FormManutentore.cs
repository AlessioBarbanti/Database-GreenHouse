using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicazione_GreenHouseDB
{
    public partial class FormManutentore : Form
    {
        public FormManutentore()
        {
            InitializeComponent();

        }

        private void RevisioniInScadenza_Click(object sender, EventArgs e)
        {
            FormLavori f2 = new FormLavori();
            f2.ShowDialog();
        }

        private void ButtonManutenzione_Click(object sender, EventArgs e)
        {
            FormManutenzioni f2 = new FormManutenzioni();
            f2.ShowDialog();
        }
    }
}
