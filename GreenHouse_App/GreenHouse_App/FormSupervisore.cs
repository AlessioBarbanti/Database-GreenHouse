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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void VisualizzaPermessiButton_Click(object sender, EventArgs e)
        {


            //var foo = from b in (from a in db.PERMESSI_STRUMENTI_COMPLESSI
            //                     select a.DIPENDENTI)
            //          where Convert.ToInt32(textBoxIDStrutturaDiRiferimento.Text) == b.IDStruttura
            //          select new { b.IDDipendente, b.Nome,b.Cognome, var = from c in db.STRUMENTI_COMPLESSI
            //                                                               where c.IDStruttura == 
            //                                                               select c.Nome};
            var ciao = from d in db.DIPENDENTI
                       where d.IDStruttura == Convert.ToInt32(textBoxIDStrutturaDiRiferimento.Text) //Manca un and se non è presente in IDMANOVALE in permessi strumewnto complesso

                       select new
                       {
                           d.IDDipendente,
                           d.Nome,
                           d.IDStruttura,
                           nomeacaso = String.Join(", ", (from a in db.STRUMENTI_COMPLESSI
                                                         where (from f in db.PERMESSI_STRUMENTI_COMPLESSI where d.IDDipendente == f.IDManovale /*where d.IDStruttura == f.IDStruttura*/ select f.IDStrumentoComplesso).Contains(a.IDStrumentoComplesso)
                                                         select a.Nome))
                       };



            var hello = from d in db.DIPENDENTI
                        where d.IDStruttura == Convert.ToInt32(textBoxIDStrutturaDiRiferimento.Text) //Manca un and se non è presente in IDMANOVALE in permessi strumewnto complesso
                        select d;

                       //select new
                                //{
                                        //    d.IDDipendente,
                                                                //    d.Nome,
                            //    d.IDStruttura,
                       //    nomeacaso = String.Join(", ", (from a in db.STRUMENTI_COMPLESSI
                       //                                   where (from f in db.PERMESSI_STRUMENTI_COMPLESSI where d.IDDipendente == f.IDManovale /*where d.IDStruttura == f.IDStruttura*/ select f.IDStrumentoComplesso).Contains(a.IDStrumentoComplesso)
                       //                                   select a.Nome))
                       //};




            //QUERY MARI

            //from h in db.DIPENDENTI
            //from ps in db.PERMESSI_STRUMENTI_COMPLESSI
            //from s in db.STRUMENTI_COMPLESSI
            //where h.IDDipendente == ps.IDManovale && ps.IDStrumentoComplesso == s.IDStrumentoComplesso
            //select s.Nome)





            try
            {
                dataGridViewSerra.DataSource = hello;
            dataGridViewStrumentoComplesso.DataSource = ciao;
            }
            catch {
            
            }



            //var tempFoo = from a in db.PERMESSI_MACCHINARI
            //      select a.DIPENDENTI;

            //foo =   from b in tempFoo
            //        where Convert.ToInt32(textBoxIDStrutturaDiRiferimento.Text) == b.IDStruttura
            //        select b;

            //dataGridViewMacchinario.DataSource = foo;

        }

        private void IDSerraDiRiferimento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
