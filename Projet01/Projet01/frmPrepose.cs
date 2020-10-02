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
    public partial class frmPrepose : Form
    {
        public dynamic NoUtilisateur;
        private bool booAjout;

        private int choixMenu;

        public frmPrepose()
        {
            InitializeComponent();
        }

        private void frmPrepose_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Client' table. You can move, or remove it, as needed.
            this.p01_ClientTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Client);

        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            frmConnexion frmConnexion = new frmConnexion();
            this.Hide();
            frmConnexion.ShowDialog();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void p01_ClientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.p01_ClientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56AnkitDataSet);

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            booAjout = true;


        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            booAjout = false;
        }

        private void gestionDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choixMenu = 1;
            gbInfoClient.Visible = true;
            cboClients.Visible = true;
        }

        private void reservationDesChambreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choixMenu = 2;
        }
    }
}
