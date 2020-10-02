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
    public partial class frmClient : Form
    {
        public bool booAjout;
        public dynamic NoClient;

        public frmClient()
        {
            InitializeComponent();
        }

        private void p01_ClientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.p01_ClientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56AnkitDataSet);

        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Client' table. You can move, or remove it, as needed.
            this.p01_ClientTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Client);

            if (booAjout)
            {
                lblTitre.Text = "Ajouter un client";
                btnConfirmer.Text = "Ajouter";
                this.Text = "Ajouter un client";
            }
            else if (!booAjout)
            {
                lblTitre.Text = "Modifier un client";
                btnConfirmer.Text = "Modifier";
                this.Text = "Modifier un client";
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
