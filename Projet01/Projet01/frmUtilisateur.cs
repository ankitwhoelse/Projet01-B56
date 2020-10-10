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
    public partial class frmUtilisateur : Form
    {
        public dynamic NoUtilisateur;
        public bool booAjout;

        String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Ankit;Persist Security Info=True;User ID=B56Ankit;Password=Summit11g";


        public frmUtilisateur()
        {
            InitializeComponent();
        }

        private void p01_TypeUtilisateurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.p01_TypeUtilisateurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56AnkitDataSet);
        }

        private void frmUtilisateur_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_TypeUtilisateur' table. You can move, or remove it, as needed.
            this.p01_TypeUtilisateurTableAdapter.Fill(this.bDB56AnkitDataSet.P01_TypeUtilisateur);

            //  Vider tout les textBox
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";

            if (booAjout)
            {
                using (SqlConnection con = new SqlConnection(maChaineDeConnexion))
                {
                    con.Open();
                    String requete = "SELECT ISNULL(MAX(NoUtilisateur),0) FROM P01_Utilisateur";
                    SqlCommand com = new SqlCommand(requete, con);

                    dynamic resultat = com.ExecuteScalar();
                    resultat++;

                    noUtilisateurTextBox.Text = resultat.ToString();
                    NoUtilisateur = resultat;

                    con.Close();
                }
                
                lblTitre.Text = "Ajouter un utilisateur";
                btnConfirmer.Text = "Ajouter";
                this.Text = "Ajouter un utilisateur";
            }
            else if (!booAjout)
            {
                // Remplir automatiquement les champs
                noUtilisateurTextBox.Text = NoUtilisateur.ToString();

                using (SqlConnection con = new SqlConnection(maChaineDeConnexion))
                {
                    con.Open();
                    String requete = "SELECT * FROM P01_Utilisateur WHERE NoUtilisateur = " + NoUtilisateur;
                    SqlCommand com = new SqlCommand(requete, con);

                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        nomUtilisateurTextBox.Text = dr[1].ToString();
                        motDePasseUtilisateurTextBox.Text = dr[2].ToString();
                        typeUtilisateurComboBox.SelectedValue = dr[3].ToString();
                    }

                    con.Close();
                }

                lblTitre.Text = "Modifier un utilisateur";
                btnConfirmer.Text = "Modifier";
                this.Text = "Modifier un utilisateur";
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
                // AJOUTER UN UTILISATEUR
                SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                maConnexion.Open();
                String maRequeteSQL = "insert into P01_Utilisateur(NoUtilisateur,Nomutilisateur,MotDepasse,NoType) values('" + noUtilisateurTextBox.ToString() + "','" + nomUtilisateurTextBox.ToString() + "','" + motDePasseUtilisateurTextBox.ToString() +"','"+ typeUtilisateurComboBox.SelectedItem.ToString() + "')";
                SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                maCommande.ExecuteScalar();
                maConnexion.Close();
            }
            else if (!booAjout)
            {
                // MODIFIER UN UTILISATEUR


            }
        }

    }
}
