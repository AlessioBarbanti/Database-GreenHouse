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
        public ProvaGreenHouseDataContext db;

        public FormRicercatore()
        {
            InitializeComponent();
            db = new ProvaGreenHouseDataContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRicercatore2 f2 = new FormRicercatore2();
            f2.ShowDialog();
        }

        private void RevisioniInScadenza_Click(object sender, EventArgs e)
        {
            var foo = from a in db.MACCHINARI
                      where (a.DataRevisione - DateTime.Now).Days < 10
                      select a;
            Console.WriteLine(foo.First());
            dataGridView1.DataSource = foo;
        }
    }
}
