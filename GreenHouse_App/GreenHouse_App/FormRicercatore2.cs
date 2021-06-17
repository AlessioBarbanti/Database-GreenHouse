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
        public ProvaGreenHouseDataContext db; 

        public FormRicercatore2()
        {
            InitializeComponent();
            db = new ProvaGreenHouseDataContext();
        }

        private void Inserisci_Click(object sender, EventArgs e)
        {


            //TODO
            ANNOTAZIONI ord = new ANNOTAZIONI
            {
                IDEsperimento = Convert.ToInt32(IDEsperimentoTextBox.Text),
                NumeroAnnotazione = LastAnnotation,
                DataOra = dateTimePicker1.Value,
                Testo = textBox2.Text,
                IDRicercatore = Convert.ToInt32(IDRicercatore.Text)
            };

            // Add the new object to the Orders collection.
            db.ANNOTAZIONI.InsertOnSubmit(ord);
            db.SubmitChanges();
            Close();
        }

        private void Annulla_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IDEsperimento_TextChanged(object sender, EventArgs e)
        {
            var tempLastAnnotation = from foo
                                     in db.ANNOTAZIONI
                                     where (foo.IDEsperimento == Convert.ToInt32(IDEsperimentoTextBox.Text)) 
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
