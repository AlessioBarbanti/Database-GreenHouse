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
    public partial class FormRicercatore2 : Form
    {
        private int LastAnnotation;
        public GreenHouseDataContext db; 

        public FormRicercatore2()
        {
            InitializeComponent();
            db = new GreenHouseDataContext();
        }

        private void Inserisci_Click(object sender, EventArgs e)
        {


            ANNOTAZIONI ord;

            try
            {
                ord = new ANNOTAZIONI
                {
                    IDEsperimento = Convert.ToInt32(IDEsperimentoTextBox.Text),
                    NumeroAnnotazione = LastAnnotation,
                    DataOra = Convert.ToDateTime(Convert.ToString(dateTimePicker1.Value.ToShortDateString()) + " " + maskedTextBox1.Text),
                    Testo = textBox2.Text,
                    IDRicercatore = Convert.ToInt32(IDRicercatore.Text)
                };
                db.ANNOTAZIONI.InsertOnSubmit(ord);
                db.SubmitChanges();
                Close();
            
            }
            catch {
                MessageBox.Show("Dati inseriti non corretti.", "Errore!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Annulla_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IDEsperimento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var tempLastAnnotation = from foo
                                     in db.ANNOTAZIONI
                                     where (Convert.ToString(foo.IDEsperimento) == IDEsperimentoTextBox.Text)
                                     select foo.NumeroAnnotazione;
                LastAnnotation = tempLastAnnotation.Max() + 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Errore Connessione al database, si prega di riavviare l'applicazione.", "Errore!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FormRicercatore2_Load(object sender, EventArgs e)
        {

        }


    }
}
