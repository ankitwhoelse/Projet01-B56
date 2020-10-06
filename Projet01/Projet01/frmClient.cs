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
    public partial class frmClient : Form
    {
        public bool booAjout;
        public dynamic NoClient;

        String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56TP11;User ID=B56TP11;Password=B56Password";

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

            if (booAjout)
            {
                // Rechercher le plus gros numero client dans la DataTable contrat
                decimal noClientMax = 0;
                foreach (BDB56AnkitDataSet.P01_ClientRow uneLigne in bDB56AnkitDataSet.P01_Client.Rows)
                    if (uneLigne.NoClient > noClientMax)
                        noClientMax = uneLigne.NoClient;
                noClientMax += 10;
                noClientTextBox.Text = noClientMax.ToString();

                // Date d'aujourd'hui
                dateInscriptionDateTimePicker.Value = DateTime.Today;
            }
            else if (!booAjout) {
                using (SqlConnection con = new SqlConnection(maChaineDeConnexion)) {
                    string requete = "SELECT * FROM P01_Client WHERE NoClient = " + NoClient;
                    SqlCommand com = new SqlCommand(requete, con);
                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read()) {

                    }
                    
                
                }
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (booAjout)
            {           // AJOUT
                // Creer un nouveau contrat en memoire
                BDB56AnkitDataSet.P01_ClientRow unClient = bDB56AnkitDataSet.P01_Client.NewP01_ClientRow();
                
                // Ajout des autres donnees
                unClient.NoClient = (short) int.Parse(noClientTextBox.Text);
                unClient.Nom = nomTextBox.Text;
                unClient.Prenom = prenomTextBox.Text;
                unClient.Ville = villeTextBox.Text;
                unClient.Pays = paysTextBox.Text;
                unClient.Adresse = adresseTextBox.Text;
                unClient.CodePostal = codePostalTextBox.Text;
                unClient.DateInscription = dateInscriptionDateTimePicker.Value;

                if (this.Controls.OfType<TextBox>().Any(tBox => string.IsNullOrEmpty(tBox.Text)))
                    MessageBox.Show("Veuillez remplir toutes les cases", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else {
                    bDB56AnkitDataSet.P01_Client.AddP01_ClientRow(unClient);
                    this.p01_ClientBindingSource.EndEdit();
                    this.p01_ClientTableAdapter.Update(this.bDB56AnkitDataSet.P01_Client);
                    MessageBox.Show("Le nouveau client a ete ajoute.", "Nouveau client enregistre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else if (!booAjout)
            {           // MODIFICATION
                
                
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(tBox => string.IsNullOrEmpty(tBox.Text)))
            {
                DialogResult resulat = MessageBox.Show("Etes vous certain d'annuler l'ajout?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resulat == DialogResult.Yes)
                    this.Close();
                else if (resulat == DialogResult.No)
                {
                    return;
                }
            }
        }
    }
}
