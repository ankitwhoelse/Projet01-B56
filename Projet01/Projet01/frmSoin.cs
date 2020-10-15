using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Ankit;Persist Security Info=True;User ID=B56Ankit;Password=Summit11g";

        public frmSoin()
        {
            InitializeComponent();
        }
        
        private void frmSoin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Soin' table. You can move, or remove it, as needed.
            this.p01_SoinTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Soin);
            
            //  Vider tout les textBox
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";

            if (booAjout)
            {   
                int intSoin = 0;
                SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                maConnexion.Open();
                // Création du Id
                String maRequeteSQL = "select max(NoSoin) from P01_Soin ";
                SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                Object resultat = maCommande.ExecuteScalar();

                if (resultat.ToString() != "")
                    intSoin = Convert.ToInt32(resultat);

                intSoin = intSoin + 1;
                noSoinTextBox.Text = intSoin.ToString();
                maConnexion.Close();

                lblTitre.Text = "Ajouter un soin";
                btnConfirmer.Text = "Ajouter";
                this.Text = "Ajouter un soin";
            }
            else if (!booAjout)
            {
                // Remplir automatiquement les champs
                noSoinTextBox.Text = NoSoin;

                using (SqlConnection con = new SqlConnection(maChaineDeConnexion))
                {
                    con.Open();
                    string requete = "SELECT * FROM P01_Soin WHERE NoSoin = " + NoSoin;
                    SqlCommand com = new SqlCommand(requete, con);

                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        descriptionTextBox.Text = dr[1].ToString();
                        dureeTextBox.Text = dr[2].ToString();
                        noTypeSoinTextBox.Text = dr[3].ToString();
                        prixTextBox.Text = dr[4].ToString();
                    }

                    con.Close();
                }
                
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
                if (this.Controls.OfType<TextBox>().Any(tBox => string.IsNullOrEmpty(tBox.Text)))
                    MessageBox.Show("empty at least 1");
                else
                {
                    // AJOUT
                    SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                    maConnexion.Open();
                    String maRequeteSQL = "insert into P01_Soin(NoSoin,Description,Duree,NoTypeSoin,prix) values('" + int.Parse(noSoinTextBox.Text.ToString()) + "','" + descriptionTextBox.Text.ToString() + "','" + int.Parse(dureeTextBox.Text.ToString()) + "','" + int.Parse(noTypeSoinTextBox.Text.ToString()) + "','" + int.Parse(prixTextBox.Text.ToString()) + "')";
                    SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                    maCommande.ExecuteScalar();
                    maConnexion.Close();
                    
                    this.Close();
                }
            }
            else if (!booAjout)
            {
                // MODIF
                if (this.Controls.OfType<TextBox>().Any(tBox => string.IsNullOrEmpty(tBox.Text)))
                    MessageBox.Show("empty at least 1");
                else
                {
                    // MODIF
                    SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                    maConnexion.Open();
                    String maRequeteSQL = "update P01_Soin set Description = '" + descriptionTextBox.Text.ToString() + "', Duree = " + int.Parse(dureeTextBox.Text.ToString()) + ", NoTypeSoin = " + int.Parse(noTypeSoinTextBox.Text.ToString()) + ", prix = " + Math.Round(double.Parse(prixTextBox.Text.ToString()))  + " where NoSoin ="+ noSoinTextBox.Text.ToString();
                    SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                    maCommande.ExecuteScalar();
                    maConnexion.Close();
                    this.Close();
                    //Update bd not sure?? 
                   // this.p01_SoinBindingSource.ResetBindings(false);
                }
            }
        }
    }
}
