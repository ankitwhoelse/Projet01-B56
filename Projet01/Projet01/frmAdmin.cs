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
    public partial class frmAdmin : Form
    {
        public dynamic NoUtilisateur;
        public dynamic NoClient;
        public dynamic NoInvite;
        public dynamic NoAssistant;
        public dynamic NoSoin;
        public dynamic NoChambre;
        public dynamic NoTypeChambre;

        private int choixMenu;
        private bool booAjout;

        frmUtilisateur frmU = new frmUtilisateur();
        frmClient frmCl = new frmClient();
        frmInvite frmI = new frmInvite();
        frmAssistant frmAss = new frmAssistant();
        frmSoin frmS = new frmSoin();
        frmChambre frmCh = new frmChambre();
        frmTypeChambre frmTyCh = new frmTypeChambre();


        String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Ankit;Persist Security Info=True;User ID=B56Ankit;Password=Summit11g";


        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            frmConnexion frmConnexion = new frmConnexion();
            this.Hide();
            frmConnexion.ShowDialog();
        }

        private void p01_UtilisateurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.p01_UtilisateurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56AnkitDataSet);
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.noTypeEtIdentifiactionUtilisateur' table. You can move, or remove it, as needed.
            this.noTypeEtIdentifiactionUtilisateurTableAdapter.Fill(this.bDB56AnkitDataSet.noTypeEtIdentifiactionUtilisateur);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_TypeUtilisateur' table. You can move, or remove it, as needed.
            this.p01_TypeUtilisateurTableAdapter.Fill(this.bDB56AnkitDataSet.P01_TypeUtilisateur);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_TypeChambre' table. You can move, or remove it, as needed.
            this.p01_TypeChambreTableAdapter.Fill(this.bDB56AnkitDataSet.P01_TypeChambre);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Invite' table. You can move, or remove it, as needed.
            this.p01_InviteTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Invite);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Soin' table. You can move, or remove it, as needed.
            this.p01_SoinTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Soin);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Assistant' table. You can move, or remove it, as needed.
            this.p01_AssistantTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Assistant);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Chambre' table. You can move, or remove it, as needed.
            this.p01_ChambreTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Chambre);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Client' table. You can move, or remove it, as needed.
            this.p01_ClientTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Client);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Utilisateur' table. You can move, or remove it, as needed.
            this.p01_UtilisateurTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Utilisateur);

            utilisateursToolStripMenuItem_Click(this, e);
        }


        /*
         *  Ajouter un element
         */
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            booAjout = true;
            this.Hide();

            switch (choixMenu) {
                case 1:
                    frmU.booAjout = booAjout;
                    frmU.ShowDialog();
                    break;
                case 2:
                    frmCl.booAjout = booAjout;
                    frmCl.ShowDialog();
                    break;
                case 3:
                    frmAss.booAjout = booAjout;
                    frmAss.ShowDialog();
                    break;
                case 4:
                    frmS.booAjout = booAjout;
                    frmS.ShowDialog();
                    break;
                case 5:
                    frmCh.booAjout = booAjout;
                    frmCh.ShowDialog();
                    break;
                default:    MessageBox.Show("this aint right", "bug");
                    break;
            }
            
            this.Show();
        }
        

        /*
         *  Modifier les proprietes  
         */
        private void btnModifier_Click(object sender, EventArgs e)
        {
            booAjout = false;
            this.Hide();

            switch (choixMenu)
            {
                case 1:
                    frmU.booAjout = booAjout;
                    NoUtilisateur = cboUtilisateurs.SelectedValue.ToString();
                    frmU.NoUtilisateur = NoUtilisateur;
                    frmU.ShowDialog();
                    break;
                case 2:
                    frmCl.booAjout = booAjout;
                    NoClient = cboClients.SelectedValue.ToString();
                    frmCl.NoClient = NoClient;
                    frmCl.ShowDialog();
                    break;
                case 3:
                    frmAss.booAjout = booAjout;
                    NoAssistant = cboAssistants.SelectedValue.ToString();
                    frmAss.NoAssistant = NoAssistant;
                    frmAss.ShowDialog();
                    break;
                case 4:
                    frmS.booAjout = booAjout;
                    NoSoin = cboSoins.SelectedValue.ToString();
                    frmS.NoSoin = NoSoin;
                    frmS.ShowDialog();
                    break;
                case 5:
                    frmCh.booAjout = booAjout;
                    NoChambre = cboChambres.SelectedValue.ToString();
                    frmCh.NoChambre = NoChambre;
                    frmCh.ShowDialog();
                    break;
                default:
                    MessageBox.Show("this aint right", "bug");
                    break;
            }
            this.Show();
        }

        private void utilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choixMenu = 1;
            lblChoix.Text = "Gestion des utilisateurs";
            lblSelection.Text = "Veuillez selectionnez \nun utilisateur:";
            cboUtilisateurs.Visible = true;
            gbInfoUtilisateur.Visible = true;

            gbInfoTypeChambre.Visible = false;
            gbInfoInvite.Visible = false;
            cboSoins.Visible = false;
            gbInfoSoins.Visible = false;
            cboChambres.Visible = false;
            gbInfoChambre.Visible = false;
            cboClients.Visible = false;
            gbInfoClient.Visible = false;
            cboAssistants.Visible = false;
            gbInfoAssistants.Visible = false;
        }

        private void clientsEtLeursInvitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choixMenu = 2;
            lblChoix.Text = "Gestion des clients et leurs invites";
            lblSelection.Text = "Veuillez selectionnez \nun utilisateur:";
            cboClients.Visible = true;
            gbInfoClient.Visible = true;
            gbInfoInvite.Visible = true;

            gbInfoTypeChambre.Visible = false;
            cboSoins.Visible = false;
            gbInfoSoins.Visible = false;
            cboChambres.Visible = false;
            gbInfoChambre.Visible = false;
            cboAssistants.Visible = false;
            gbInfoAssistants.Visible = false;
            cboUtilisateurs.Visible = false;
            gbInfoUtilisateur.Visible = false;
        }

        private void assistantsEtLesSoinsOffertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choixMenu = 3;
            lblChoix.Text = "Gestion des assistants et leurs soins";
            lblSelection.Text = "Veuillez selectionnez \nun(e) assistant(e).";
            cboAssistants.Visible = true;
            gbInfoAssistants.Visible = true;

            gbInfoTypeChambre.Visible = false;
            gbInfoInvite.Visible = false;
            cboSoins.Visible = false;
            gbInfoSoins.Visible = false;
            cboChambres.Visible = false;
            gbInfoChambre.Visible = false;
            cboClients.Visible = false;
            gbInfoClient.Visible = false;
            cboUtilisateurs.Visible = false;
            gbInfoUtilisateur.Visible = false;
        }

        private void soinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choixMenu = 4;
            lblChoix.Text = "Gestion des soins";
            lblSelection.Text = "Veuillez selectionnez \nun soin.";
            cboSoins.Visible = true;
            gbInfoSoins.Visible = true;
            
            gbInfoTypeChambre.Visible = false;
            gbInfoInvite.Visible = false;
            cboClients.Visible = false;
            gbInfoClient.Visible = false;
            cboChambres.Visible = false;
            gbInfoChambre.Visible = false;
            cboAssistants.Visible = false;
            gbInfoAssistants.Visible = false;
            cboUtilisateurs.Visible = false;
            gbInfoUtilisateur.Visible = false;
        }

        private void chambresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choixMenu = 5;
            lblChoix.Text = "Gestion des chambres";
            lblSelection.Text = "Veuillez selectionnez \nune chambre.";
            cboChambres.Visible = true;
            gbInfoChambre.Visible = true;
            gbInfoTypeChambre.Visible = true;

            gbInfoInvite.Visible = false;
            cboSoins.Visible = false;
            gbInfoSoins.Visible = false;
            cboClients.Visible = false;
            gbInfoClient.Visible = false;
            cboAssistants.Visible = false;
            gbInfoAssistants.Visible = false;
            cboUtilisateurs.Visible = false;
            gbInfoUtilisateur.Visible = false;
        }
        
        private void btnAjoutInvite_Click(object sender, EventArgs e)
        {
            NoClient = cboClients.SelectedValue.ToString();
            frmI.NoClient = NoClient;
            frmI.booAjout = true;
            this.Hide();
            frmI.ShowDialog();
            this.Show();
        }

        private void btnModifInvite_Click(object sender, EventArgs e)
        {
            NoClient = cboClients.SelectedValue.ToString();
            frmI.NoClient = NoClient;
            frmI.booAjout = false;
            NoInvite = cboInvite.SelectedValue.ToString();
            frmI.NoInvite = NoInvite;
            this.Hide();
            frmI.ShowDialog();
            this.Show();
        }

        private void btnSupprimeInvite_Click(object sender, EventArgs e)
        {
            NoInvite = cboInvite.SelectedValue.ToString();
            // Suprimmer invite
        }

        private void btnAjoutTypeChambre_Click(object sender, EventArgs e)
        {
            frmTyCh.booAjout = true;
            this.Hide();
            frmTyCh.ShowDialog();
            this.Show();
        }

        private void btnModifTypeChambre_Click(object sender, EventArgs e)
        {
            NoTypeChambre = cboTypeChambre.SelectedValue.ToString();
            frmTyCh.NoTypeChambre = NoTypeChambre;
            frmTyCh.booAjout = false;
            this.Hide();
            frmTyCh.ShowDialog();
            this.Show();

        }

        private void btnSupprTypeChambre_Click(object sender, EventArgs e)
        {
            NoTypeChambre = cboTypeChambre.SelectedValue.ToString();
            // Supprimer type chambre
        }

        private void btnAjouterReservation_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnulerReservation_Click(object sender, EventArgs e)
        {

            
        }

        private void p01_TypeUtilisateurComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
