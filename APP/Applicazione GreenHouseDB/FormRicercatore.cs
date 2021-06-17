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
    public partial class FormRicercatore : Form
    {
        public FormRicercatore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRicercatore2 f2 = new FormRicercatore2();
            f2.ShowDialog();
        }
    }
}
