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
        public GreenHouseDataContext db;
        public FormLavori()
        {
            InitializeComponent();
        }

        private void Inserisci_Click(object sender, EventArgs e)
        {



            LAVORI_EFFETTUATI foo;

            try
            {
                if (Convert.ToDateTime(maskedTextBoxDateTimeInizio.Text) > Convert.ToDateTime(maskedTextBoxDateTimeFine.Text))
                {
                    throw new Exception();
                }

                foo = new LAVORI_EFFETTUATI
                {
                    IDLavoroEffettuato = 0,
                    IDManovale = Convert.ToInt32(textBoxIDManovale.Text),
                    IDClusterPiante = Convert.ToInt32(taxtBoxIDClusters.Text),
                    DataOraInizio = Convert.ToDateTime(maskedTextBoxDateTimeInizio.Text),
                    DataOraFine = Convert.ToDateTime(maskedTextBoxDateTimeFine.Text),
                    IDLavoro = (from a in db.LAVORI
                            where a.Nome == comboBox3.Text
                            select a.IDLavoro).Single()
        };





            var tempIDLavoroEffettutato = from b in db.LAVORI_EFFETTUATI
                                     where b.IDLavoro == foo.IDLavoro
                                     select b.IDLavoroEffettuato;

            try
            {
                foo.IDLavoroEffettuato = tempIDLavoroEffettutato.Max() + 1;
            }
            catch {
                foo.IDLavoroEffettuato = 1;
            }


            db.LAVORI_EFFETTUATI.InsertOnSubmit(foo);
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = true;
            db = new GreenHouseDataContext();

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxDateTimeFine_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


    }
}
