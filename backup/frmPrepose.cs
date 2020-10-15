﻿using System;
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
    public partial class frmPrepose : Form
    {
        public dynamic NoUtilisateur;
        public dynamic NoClient;
        public dynamic NoInvite;
        public dynamic NoChambre;
        
        frmClient frmCli = new frmClient();
        frmInvite frmInv = new frmInvite();
        frmReservationChambre frmResCh = new frmReservationChambre();

        String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Ankit;Persist Security Info=True;User ID=B56Ankit;Password=Summit11g";

        public frmPrepose()
        {
            InitializeComponent();
        }

        private void frmPrepose_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Invite' table. You can move, or remove it, as needed.
            this.p01_InviteTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Invite);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Chambre' table. You can move, or remove it, as needed.
            this.p01_ChambreTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Chambre);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Client' table. You can move, or remove it, as needed.
            this.p01_ClientTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Client);

            using (SqlConnection con = new SqlConnection(maChaineDeConnexion))
            {
                con.Open();
                string requete = "SELECT NomUtilisateur FROM P01_Utilisateur WHERE NoUtilisateur = " + NoUtilisateur;
                SqlCommand comm = new SqlCommand(requete, con);
                string nomUtil = comm.ExecuteScalar().ToString();

                lblBonjour.Text = "Bonjour " + nomUtil + ",\nveuillez selectionner un client, invité\nou une chambre avant de procéder";
                con.Close();
            }
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            frmConnexion frmConnexion = new frmConnexion();
            this.Hide();
            frmConnexion.ShowDialog();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {           // AJOUTER CLIENT
            this.Hide();
            frmCli.booAjout = true;
            frmCli.ShowDialog();
            this.Show();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {           // MODIFIER CLIENT
            this.Hide();
            NoClient = cboClients.SelectedValue.ToString();
            frmCli.NoClient = NoClient;
            frmCli.booAjout = false;
            frmCli.ShowDialog();
            this.Show();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {           // SUPPRIMER CLIENT
            // hold on this till its done admin side 
        }

        private void btnAjoutInvite_Click(object sender, EventArgs e)
        {           // AJOUTER INVITE
            this.Hide();
            frmInv.NoClient = cboClients.SelectedValue.ToString();
            frmInv.booAjout = true;
            frmInv.ShowDialog();
            this.Show();
        }

        private void btnModifInvite_Click(object sender, EventArgs e)
        {           // MODIFIER INVITE
            this.Hide();
            frmInv.NoClient = cboClients.SelectedValue.ToString();
            frmInv.NoInvite = cboInvite.SelectedValue.ToString();
            frmInv.booAjout = false;
            frmInv.ShowDialog();
            this.Show();
        }

        private void btnSupprimeInvite_Click(object sender, EventArgs e)
        {           // SUPPRIMER INVITE
            // hold on this till its done admin side
        }

        private void btnAjouterReservation_Click(object sender, EventArgs e)
        {           // RESERVER CHAMBRE
            NoChambre = cboChambre.SelectedValue.ToString();
            frmResCh.NoChambre = NoChambre;
            this.Hide();
            frmResCh.ShowDialog();
            this.Show();
        }
    }
}
