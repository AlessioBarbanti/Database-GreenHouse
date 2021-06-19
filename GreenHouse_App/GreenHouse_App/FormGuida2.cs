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
    public partial class FormGuida2 : Form
    {
        private GreenHouseDataContext db;
        public FormGuida2()
        {
            InitializeComponent();
            db = new GreenHouseDataContext();
        }



        private void Inserisci_Click_1(object sender, EventArgs e)
        {

            VISITE foo;
            try
            {
                foo = new VISITE
                {
                    IDViaggio = Convert.ToInt32(textBoxIDViaggio.Text),
                    DataOra = Convert.ToDateTime(Data.Text),
                    IDStruttura = Convert.ToInt32(textBoxIDStruttura.Text),
                    IDSerra = Convert.ToInt32(textBoxIDSerra.Text)
                };

                var tempIDGuida = from a in db.VIAGGI_ISTRUZIONE
                                  where a.IDViaggio == Convert.ToInt32(textBoxIDViaggio.Text)
                                  select a.IDGuida;

                foo.IDGuida = tempIDGuida.First();
                if (Convert.ToDateTime(Data.Text) < DateTime.Now) {

                    throw new Exception();
                }
                db.VISITE.InsertOnSubmit(foo);
                db.SubmitChanges();
                Close();
            }
            catch
            {
                MessageBox.Show("Dati inseriti non corretti.", "Errore!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
