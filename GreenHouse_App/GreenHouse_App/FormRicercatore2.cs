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


            //TODO
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

            //var checkMyExperiment = from esp in db.ESPERIMENTI
            //                        where (esp.IDRicercatoreCapo == ord.IDRicercatore) || (from clo in db.COLLABORAZIONI
            //                                                                               where clo.IDRicercatore == ord.IDRicercatore
            //                                                                               select new { clo.IDEsperimento }).Contains(new { IDEsperimento = esp.IDEsperimento })
            //                                                                               select esp;
            //if (!checkMyExperiment.Any())
            //{
            //    throw new Exception();
            //};




        }

        private void Annulla_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IDEsperimento_TextChanged(object sender, EventArgs e)
        {
            var tempLastAnnotation = from foo
                                     in db.ANNOTAZIONI
                                     where (Convert.ToString(foo.IDEsperimento) == IDEsperimentoTextBox.Text)
                                     select foo.NumeroAnnotazione;


           
            try
            {
                LastAnnotation = tempLastAnnotation.Max() + 1;
            }
            catch (Exception)
            {
                //Nothing to do
            }
            
            }

        private void FormRicercatore2_Load(object sender, EventArgs e)
        {

        }


    }
}
