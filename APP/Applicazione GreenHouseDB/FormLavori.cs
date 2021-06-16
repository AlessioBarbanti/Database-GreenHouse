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
    public partial class FormLavori : Form
    {
        public FormLavori()
        {
            InitializeComponent();
        }

        private void Inserisci_Click(object sender, EventArgs e)
        {
            //TODO
            Close();
        }

        private void Annulla_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLavori_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'provaDataSet1.RICERCATORI'. È possibile spostarla o rimuoverla se necessario.
            this.rICERCATORITableAdapter.Fill(this.provaDataSet1.RICERCATORI);
            

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rICERCATORITableAdapter.Fill(this.provaDataSet1.RICERCATORI);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


    }
}
