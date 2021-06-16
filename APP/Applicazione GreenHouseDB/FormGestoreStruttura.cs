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
    public partial class FormGestoreStruttura : Form
    {
        public FormGestoreStruttura()
        {
            InitializeComponent();
            DataClassesDataContext db = new DataClassesDataContext();
        }

        private void PermessiManovale_Click(object sender, EventArgs e)
        {
           // DataClassesDataContext db = new DataClassesDataContext();
            //TODO
            //dataGridView1.DataSource = foo;
        }

        private void RevisioniInScadenza_Click(object sender, EventArgs e)
        {
            //DataClassesDataContext db = new DataClassesDataContext();
            //TODO
            //dataGridView1.DataSource = foo;
        }
    }
}
