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
        public ProvaGreenHouseDataContext db;
        public FormSupervisore()
        {
            InitializeComponent();
            db = new ProvaGreenHouseDataContext();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //var result = (from a in db.DIPENDENTI

            //              select new Person { Name = a.Name, Age = a.Age }).ToList();

            //var result = (from a in db.DIPENDENTI
            //              select new { a.Nome, a. }).ToList();

            //var foo = from a in db.DIPENDENTI
            //          select a.Nome;

            //dataGridView1.DataSource = foo;
        }
    }
}
