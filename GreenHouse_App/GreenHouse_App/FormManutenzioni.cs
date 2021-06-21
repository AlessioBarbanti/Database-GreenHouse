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
        public GreenHouseDataContext db;
        public FormManutenzioni()
        {
            InitializeComponent();
            db = new GreenHouseDataContext();
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
            catch
            {
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
            try
            {
                var foo = from a in db.CONTRATTI
                          where a.IDDipendente == Convert.ToInt32(textBoxIDManutentore.Text) && a.TipoContratto == "Manutentore"
                          select a.IDStruttura;



                if (textBoxIDManutentore.Text != "")
                {
                    try
                    {
                        textBoxIDStruttura.Text = Convert.ToString(foo.Single());
                        Inserisci.Enabled = true;
                    }
                    catch
                    {
                        textBoxIDStruttura.Text = "ID errato.";
                        Inserisci.Enabled = false;
                    }
                }
            }
            catch {
                MessageBox.Show("Errore Connessione al database, si prega di riavviare l'applicazione.", "Errore!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void textBoxIDStruttura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
