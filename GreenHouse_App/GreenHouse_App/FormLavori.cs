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
    public partial class FormLavori : Form
    {
        public FormLavori()
        {
            InitializeComponent();
        }

        private void Inserisci_Click(object sender, EventArgs e)
        {
            //TODO
            Close();
        }

        private void Annulla_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = true;
            ProvaGreenHouseDataContext db = new ProvaGreenHouseDataContext();

            if (comboBox2.SelectedItem.ToString() == "LAVORO TERRA")
            {
                var foo = from s in db.LAVORI where s.Categoria == "LAVORO TERRA" select s.Nome;
                comboBox3.DataSource = foo;

            }
            if (comboBox2.SelectedItem.ToString() == "LAVORO PIANTA")
            {
                var foo = from s in db.LAVORI where s.Categoria == "LAVORO PIANTA" select s.Nome;
                comboBox3.DataSource = foo;

            }
            if (comboBox2.SelectedItem.ToString() == "TRATTAMENTO")
            {
                var foo = from s in db.LAVORI where s.Categoria == "TRATTAMENTO" select s.Nome;
                comboBox3.DataSource = foo;

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IDGuida_TextChanged(object sender, EventArgs e)
        {
            //TODO

        }
    }
}
