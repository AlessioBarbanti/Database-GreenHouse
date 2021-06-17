using System;
using System.Windows.Forms;

namespace Applicazione_GreenHouseDB
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
    }
}
