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
    public partial class FormGuida : Form
    {
        public GreenHouseDataContext db;
        public FormGuida()
        {
            InitializeComponent();
            db = new GreenHouseDataContext();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormGuida2 f2 = new FormGuida2();
            f2.ShowDialog();
        }



        private void InserisciViaggio_Click(object sender, EventArgs e)
        {
            FormViaggio f2 = new FormViaggio();
            f2.ShowDialog();
        }

        private void VisualizzaVisite_Click(object sender, EventArgs e)
        {
            try
            {
                var foo = from a in db.VISITE
                          where (DateTime.Now - a.DataOra).Days <= 10 && (DateTime.Now - a.DataOra).Days < 0 && Convert.ToString(a.IDStruttura) == textBoxIDStruttura.Text
                          select new
                          {
                              Data = a.DataOra,
                              IDGuida = a.IDGuida,
                              IDViaggio = a.IDViaggio,
                              Struttura = a.IDStruttura,
                              Serra = a.IDSerra
                          };

                dataGridView1.DataSource = foo;
            }
            catch {
                MessageBox.Show("Errore Connessione al database, si prega di riavviare l'applicazione.", "Errore!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
