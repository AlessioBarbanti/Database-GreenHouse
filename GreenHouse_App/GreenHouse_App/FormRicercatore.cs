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
    

    public partial class FormRicercatore : Form
    {
        public GreenHouseDataContext db;

        public FormRicercatore()
        {
            InitializeComponent();
            db = new GreenHouseDataContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRicercatore2 f2 = new FormRicercatore2();
            f2.ShowDialog();
        }

        private void RevisioniInScadenza_Click(object sender, EventArgs e)
        {
            var foo = from E    in db.ESPERIMENTI
                      from COLL in (from CO in db.COLLABORAZIONI where CO.IDRicercatore == 1 select new { CO })
                      from CL   in db.CLUSTER_PIANTE
                      where
                        E.IDRicercatoreCapo == 1 && CL.IDEsperimento == E.IDEsperimento && CL.NumeroPianteMorte > 0 || E.IDEsperimento == COLL.CO.IDEsperimento
                      group new { E, CL } by new
                      {
                          E.IDEsperimento,E.Descrizione
                      } into g orderby g.Sum(p => p.CL.NumeroPianteMorte) descending
                      select new
                      {
                          g.Key.IDEsperimento,
                          g.Key.Descrizione,
                          PianteMorte = (int)g.Sum(p => p.CL.NumeroPianteMorte)
                      };



            /*  SELECT E.IDEsperimento,Descrizione, SUM(CL.NumeroPianteMorte) AS PianteMorte
                FROM ESPERIMENTI E, (SELECT * FROM COLLABORAZIONI CO WHERE  CO.IDRicercatore = 1) AS COLL,CLUSTER_PIANTE CL
                WHERE (E.IDRicercatoreCapo = 1 OR  ) AND CL.IDEsperimento = E.IDEsperimento AND CL.NumeroPianteMorte > 0
                GROUP BY E.IDEsperimento,Descrizione
                ORDER BY SUM(CL.NumeroPianteMorte) DESC;
            */


            dataGridView1.DataSource = foo;
        }
    }
}
