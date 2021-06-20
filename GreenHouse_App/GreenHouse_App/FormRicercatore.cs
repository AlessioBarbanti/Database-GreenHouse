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

            try
            {
                var deathExperiment = (from clu in db.CLUSTER_PIANTE
                                       where (Convert.ToString(clu.ESPERIMENTI.IDRicercatoreCapo) == textBoxIDRicercatore.Text ||
                                       (from clo in db.COLLABORAZIONI
                                        where Convert.ToString(clo.IDRicercatore) == textBoxIDRicercatore.Text
                                        select new { clo.IDEsperimento }).Contains(new { IDEsperimento = clu.IDEsperimento })) && clu.NumeroPianteMorte > 0
                                       group clu by new { clu.IDEsperimento, clu.ESPERIMENTI.Descrizione } into g
                                       orderby g.Sum(p => p.NumeroPianteMorte) descending
                                       select new { g.Key.IDEsperimento, g.Key.Descrizione, NumeroPianteMorte = g.Sum(clu => clu.NumeroPianteMorte) });

                dataGridView1.DataSource = deathExperiment;
            }
            catch { 
                //Do nothing
            }
            

            
        }
    }
}
