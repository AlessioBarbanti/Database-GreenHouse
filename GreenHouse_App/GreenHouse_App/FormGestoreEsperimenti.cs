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
    public partial class FormGestoreEsperimenti : Form
    {
        public FormGestoreEsperimenti()
        {
            InitializeComponent();
        }

        private void RevisioniInScadenza_Click(object sender, EventArgs e)
        {
            FormGestoreEsperimenti2 f2 = new FormGestoreEsperimenti2();
            f2.ShowDialog();
        }
    }
}
