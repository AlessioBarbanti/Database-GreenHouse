using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicazione_GreenHouseDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Ricercatore_Click(object sender, EventArgs e)
        {
            FormRicercatore f2 = new FormRicercatore();
            f2.ShowDialog();
        }



        private void gestoreStruttura_Click(object sender, EventArgs e)
        {
            FormGestoreStruttura f2 = new FormGestoreStruttura();
            f2.ShowDialog();
        }

        private void guida_Click(object sender, EventArgs e)
        {
            FormGuida f2 = new FormGuida();
            f2.ShowDialog();
        }

        private void ricercatoreCapo_Click(object sender, EventArgs e)
        {
            FormRicercatoreCapo f2 = new FormRicercatoreCapo();
            f2.ShowDialog();
        }


        private void manutentore_Click(object sender, EventArgs e)
        {
            FormManutentore f2 = new FormManutentore();
            f2.ShowDialog();
        }


        private void supervisore_Click(object sender, EventArgs e)
        {
            FormSupervisore f2 = new FormSupervisore();
            f2.ShowDialog();
        }

    }
}
