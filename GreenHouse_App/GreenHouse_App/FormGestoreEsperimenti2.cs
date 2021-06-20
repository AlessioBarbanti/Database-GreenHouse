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
    public partial class FormGestoreEsperimenti2 : Form
    {
        public GreenHouseDataContext db;
        public FormGestoreEsperimenti2()
        {
            InitializeComponent();
            db = new GreenHouseDataContext();
        }


        private void Inserisci_Click(object sender, EventArgs e)
        {
            ESPERIMENTI foo;
            COLLABORAZIONI foo2;
            try
            {
                foo = new ESPERIMENTI
                {
                    DataInizio = dateTimePickerInizio.Value,
                    DataFine = dateTimePickerFine.Value,
                    DataApprovazione = DateTime.Now,
                    Descrizione = textBoxDescrizione.Text,
                    IDAutorizzante = Convert.ToInt32(textBoxIDAutorizzante.Text),
                    IDRicercatoreCapo = Convert.ToInt32(textBoxRicercatoreCapo.Text)
                };
                db.ESPERIMENTI.InsertOnSubmit(foo);
                db.SubmitChanges();




            foreach (string a in textBoxIDCollaboratori.Text.Split(';'))
            {
                foo2 = new COLLABORAZIONI
                {
                    IDEsperimento = (from d in db.ESPERIMENTI select d.IDEsperimento).Max(),
                    IDRicercatore = Convert.ToInt32(a)
                };
                db.COLLABORAZIONI.InsertOnSubmit(foo2);
            }

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
    }
}
