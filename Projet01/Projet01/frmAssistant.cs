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
    public partial class frmAssistant : Form
    {
        public dynamic NoAssistant;
        public bool booAjout;
        
        String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Ankit;Persist Security Info=True;User ID=B56Ankit;Password=Summit11g";
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
            //vider les text box
            if (booAjout)
            {
                Action<Control.ControlCollection> func = null;

                func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                            (control as TextBox).Clear();
                        else
                            func(control.Controls);
                };

                func(Controls);
                int intAssistant = 0;
                SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                maConnexion.Open();
                // Création du Id
                String maRequeteSQL = "select max(NoAssistant) from P01_Assistant ";
                SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                Object resultat = maCommande.ExecuteScalar();
                
                if (resultat.ToString() != "")
                    intAssistant =Convert.ToInt32(resultat);

                intAssistant = intAssistant+1;
                noAssistantTextBox.Text = intAssistant.ToString();
                maConnexion.Close();
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
                
                if (this.Controls.OfType<TextBox>().Any(tBox => string.IsNullOrEmpty(tBox.Text)))
                    MessageBox.Show("empty at least 1");
                else {

                    // AJOUT
                    SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                    maConnexion.Open();
                    String maRequeteSQL = "insert into P01_Assistant(NoAssistant,Prenom,Nom,Specialites,Remarques) values(" + int.Parse(noAssistantTextBox.Text.ToString()) + ",'" + prenomTextBox.Text.ToString() + "','" + nomTextBox.Text.ToString() + "','" + specialitesTextBox.Text.ToString() + "','" + remarquesTextBox.Text.ToString() + "')";
                    SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                    maCommande.ExecuteScalar();
                    maConnexion.Close();
                    this.Close();
                }
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
