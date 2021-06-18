using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GreenHouse_App
{
    public partial class FormSupervisore : Form
    {
        public ProvaGreenHouseDataContext db;
        public FormSupervisore()
        {
            InitializeComponent();
            db = new ProvaGreenHouseDataContext();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void VisualizzaPermessiButton_Click(object sender, EventArgs e)
        {
            var foo = from a in db.PERMESSI
                          //where Convert.ToInt32(IDSerraDiRiferimento.Text) == ;
                      select a.PERMESSI_MANOVALI; //a.IDPermesso

        }

        private void IDSerraDiRiferimento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
