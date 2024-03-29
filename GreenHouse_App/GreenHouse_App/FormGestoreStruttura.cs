﻿using System;
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
    public partial class FormGestoreStruttura : Form
    {
        public GreenHouseDataContext db;
        public FormGestoreStruttura()
        {
            InitializeComponent();
            db = new GreenHouseDataContext();
        }


        private void RevisioniInScadenza_Click(object sender, EventArgs e)
        {
            try
            {
                var foo = from a in db.MACCHINARI
                          where (a.DataRevisione - DateTime.Now).Days < 10 && (DateTime.Now - a.DataRevisione).Days < 0 && (Convert.ToString(a.IDStruttura) == textBoxIDStrutturaDiRiferimento.Text)
                          select new { a.Marca, a.Modello, a.Targa, a.DataRevisione };

                dataGridView1.DataSource = foo;
            }
            catch {
                MessageBox.Show("Errore Connessione al database, si prega di riavviare l'applicazione.", "Errore!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
