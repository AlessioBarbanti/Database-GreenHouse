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
    public partial class FormViaggio : Form
    {
        public GreenHouseDataContext db;
        public FormViaggio()
        {
            InitializeComponent();
            db = new GreenHouseDataContext();
        }

        private void Inserisci_Click(object sender, EventArgs e)
        {


            VIAGGI_ISTRUZIONE foo;
            //try
            //{
            foo = new VIAGGI_ISTRUZIONE
            {
                    IDGuida = Convert.ToInt32(textBoxIDGuida.Text),
                    Scuola = textBoxScuola.Text,
                    NumeroPartecipanti = Convert.ToInt32(textBoxNPax.Text)
                };

                var tempIDViaggio = from a in db.VIAGGI_ISTRUZIONE
                                    select a.IDViaggio;
                foo.IDViaggio = tempIDViaggio.Max() + 1;

                if (radioButton1.Checked) {
                    foo.OrdineScolastico = radioButton1.Text;
                }
                if (radioButton2.Checked) {
                    foo.OrdineScolastico = radioButton2.Text;

                }
                if (radioButton3.Checked) {
                    foo.OrdineScolastico = radioButton3.Text;
                }

                db.VIAGGI_ISTRUZIONE.InsertOnSubmit(foo);
                db.SubmitChanges();
                Close();
            //}
            //catch
            //{
            //    MessageBox.Show("Dati inseriti non corretti.", "Errore!",
            //    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }



        private void Annulla_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
