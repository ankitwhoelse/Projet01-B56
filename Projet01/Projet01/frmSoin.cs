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
    public partial class frmSoin : Form
    {
        public bool booAjout;
        public dynamic NoSoin;

        public frmSoin()
        {
            InitializeComponent();
        }

        private void p01_SoinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.p01_SoinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56AnkitDataSet);

        }

        private void frmSoin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Soin' table. You can move, or remove it, as needed.
            this.p01_SoinTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Soin);

            if (booAjout)
            {
                lblTitre.Text = "Ajouter un soin";
                btnConfirmer.Text = "Ajouter";
                this.Text = "Ajouter un soin";
            }
            else if (!booAjout)
            {
                lblTitre.Text = "Modifier un soin";
                btnConfirmer.Text = "Modifier";
                this.Text = "Modifier un soin";
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
