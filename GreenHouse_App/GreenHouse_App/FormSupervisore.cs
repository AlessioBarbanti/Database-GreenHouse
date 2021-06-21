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
    public partial class FormSupervisore : Form
    {
        public GreenHouseDataContext db;
        public FormSupervisore()
        {
            InitializeComponent();
            db = new GreenHouseDataContext();
        }




        private void VisualizzaPermessiButton_Click(object sender, EventArgs e)
        {

            try
            {

                var idStruttura = textBoxIDStrutturaDiRiferimento.Text;

            var manovaliMacchinari = from permesso in db.PERMESSI_MACCHINARI
                                     where Convert.ToString(permesso.MACCHINARI.GARAGE.IDStruttura) == idStruttura
                                     && permesso.Validità == "valido"
                                     select new { permesso.IDManovale, permesso.DIPENDENTI.Nome,
                                         permesso.DIPENDENTI.Cognome, Garage = permesso.MACCHINARI.IDGarage,
                                         permesso.NumeroTelaio, permesso.MACCHINARI.Marca, permesso.MACCHINARI.Modello };

            var manovaliPermessiMacchinari = from d in db.PERMESSI_STRUMENTI_COMPLESSI
                        where Convert.ToString(d.IDStruttura) == idStruttura
                        && d.Validità == "valido"
                        select new { d.IDManovale, d.DIPENDENTI.Nome, d.DIPENDENTI.Cognome,Magazzino = d.STRUMENTI_COMPLESSI.IDMagazzino, Strumento = d.STRUMENTI_COMPLESSI.Nome };





                dataGridViewStrumentoComplesso.DataSource = manovaliPermessiMacchinari;
                dataGridViewMacchinario.DataSource = manovaliMacchinari;
            }
            catch
            {
                MessageBox.Show("Errore Immissione.", "Errore!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }
    }
}
