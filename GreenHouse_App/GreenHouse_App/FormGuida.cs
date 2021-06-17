using System;
using System.Windows.Forms;

namespace GreenHouse_App
{
    public partial class FormGuida : Form
    {
        public FormGuida()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormGuida2 f2 = new FormGuida2();
            f2.ShowDialog();
        }

        private void RevisioniInScadenza_Click(object sender, EventArgs e)
        {

        }
    }
}
