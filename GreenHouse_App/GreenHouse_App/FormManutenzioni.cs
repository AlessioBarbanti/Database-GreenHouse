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
    public partial class FormManutenzioni : Form
    {
        public ProvaGreenHouseDataContext db;
        public FormManutenzioni()
        {
            InitializeComponent();
            db = new ProvaGreenHouseDataContext();
        }

        private void Inserisci_Click(object sender, EventArgs e)
        {
            MANUTENZIONI foo;
            try
            {
                foo = new MANUTENZIONI
                {
                    IDManutentore = Convert.ToInt32(textBoxIDManutentore.Text),
                    DataOra = Convert.ToDateTime(dateTime.Text),
                    Descrizione = textBox2.Text,
                    IDStruttura = Convert.ToInt32(textBoxIDStruttura.Text),
                    IDSerra = Convert.ToInt32(textBoxIDSerra.Text)
                };
                db.MANUTENZIONI.InsertOnSubmit(foo);
                db.SubmitChanges();
                Close();
            }
            catch {
                dateTime.Text = "";
                textBoxIDSerra.Text = "";
                textBoxIDManutentore.Text = "";
                MessageBox.Show("Dati inseriti non corretti.", "Errore!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Annulla_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxIDManutentore_TextChanged(object sender, EventArgs e)
        {

            var foo = from a in db.CONTRATTI
                      where a.IDDipendente == Convert.ToInt32(textBoxIDManutentore.Text)
                      select a.IDStruttura;

            if (textBoxIDManutentore.Text != "")
            {
                try
                {
                    textBoxIDStruttura.Text = Convert.ToString(foo.First());
                    Inserisci.Enabled = true;
                }
                catch {
                    textBoxIDStruttura.Text = "Errore!";
                    Inserisci.Enabled = false;
                }
            }




        }

        private void textBoxIDStruttura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
