using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet01
{
    public partial class frmAssistant : Form
    {
        public dynamic NoAssistant;
        public bool booAjout;

        public frmAssistant()
        {
            InitializeComponent();
        }

        private void p01_AssistantBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.p01_AssistantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56AnkitDataSet);

        }

        private void frmAssistant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Assistant' table. You can move, or remove it, as needed.
            this.p01_AssistantTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Assistant);

            if (booAjout)
            {
                lblTitre.Text = "Ajouter un assistant";
                btnConfirmer.Text = "Ajouter";
                this.Text = "Ajouter un assistant";
            }
            else if (!booAjout)
            {
                lblTitre.Text = "Modifier un assistant";
                btnConfirmer.Text = "Modifier";
                this.Text = "Modifier un assistant";
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (booAjout)
            {
                // AJOUT
            }
            else if (!booAjout)
            {
                // MODIF
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
