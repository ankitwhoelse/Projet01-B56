using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projet01
{
    public partial class frmInvite : Form
    {
        public bool booAjout;
        public dynamic NoClient;
        public dynamic NoInvite;

        String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Ankit;Persist Security Info=True;User ID=B56Ankit;Password=Summit11g";

        public frmInvite()
        {
            InitializeComponent();
        }

        private void p01_InviteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.p01_InviteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56AnkitDataSet);

        }

        private void frmInvite_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Invite' table. You can move, or remove it, as needed.
            this.p01_InviteTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Invite);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Invite' table. You can move, or remove it, as needed.
            this.p01_InviteTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Invite);

            if (booAjout)
            {
                nomClientTextBox.Text = "";
                nomPrenomTextBox.Text = "";
                noInviteTextBox.Text = "";
                lblTitre.Text = "Ajouter un invite";
                btnConfirmer.Text = "Ajouter";
                this.Text = "Ajouter un invite";
            }
            else if (!booAjout)
            {
                lblTitre.Text = "Modifier un invite";
                btnConfirmer.Text = "Modifier";
                this.Text = "Modifier un invite";
            }
            

            // Remplir automatiquement le champ du NoInvite puis celui du nom du client
            using (SqlConnection con = new SqlConnection(maChaineDeConnexion))
            {   
                con.Open();
                string requete = "SELECT Nom FROM P01_Client WHERE NoClient = " + NoClient;
                SqlCommand com = new SqlCommand(requete, con);

                dynamic retour = com.ExecuteScalar();
                nomClientTextBox.Text = retour.ToString();

                string requete2 = "SELECT MAX(NoInvite) FROM P01_Invite WHERE NoInvite > NoClient AND NoInvite < NoClient+10";
                SqlCommand com2 = new SqlCommand(requete2, con);

                dynamic max = com2.ExecuteScalar();
                max++;
                // Verification du nombre d'invite pour le client
                if (max % 10 != 0)
                    noInviteTextBox.Text = max.ToString();
                else
                {
                    noInviteTextBox.Enabled = false;
                    nomPrenomTextBox.Enabled = false;
                    btnConfirmer.Enabled = false;
                    lblTitre.Text = "Nombre maximal d'invite atteint.\nVeuillez quitter ce menu.";
                }
                con.Close();
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (booAjout)
            {           // AJOUT
                // Creer un nouveau invite en memoire
                BDB56AnkitDataSet.P01_InviteRow unInvite = bDB56AnkitDataSet.P01_Invite.NewP01_InviteRow();
                // Ajout des donnees
                unInvite.NoInvite = (short) int.Parse(noInviteTextBox.Text);
                unInvite.NomPrenom = nomPrenomTextBox.Text;
                unInvite.NoClient = (short) int.Parse(NoClient);
                    
                if (string.IsNullOrEmpty(nomPrenomTextBox.Text))
                    MessageBox.Show("Veuillez remplir la case pour le nom de l'invite", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    bDB56AnkitDataSet.P01_Invite.AddP01_InviteRow(unInvite);
                    this.p01_InviteBindingSource.EndEdit();
                    this.p01_InviteTableAdapter.Update(this.bDB56AnkitDataSet.P01_Invite);
                    MessageBox.Show("Le nouveau invite a ete ajoute.", "Nouveau invite enregistre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else if (!booAjout)
            {           // MODIFICATION

            }
        }

        private void p01_InviteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.p01_InviteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56AnkitDataSet);

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(tBox => string.IsNullOrEmpty(tBox.Text)))
            {
                DialogResult resulat = MessageBox.Show("Etes vous certain d'annuler l'ajout?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resulat == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (resulat == DialogResult.No)
                {
                    return;
                }
            }
        }
    }
}
