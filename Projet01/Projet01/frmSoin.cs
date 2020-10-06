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
                SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                maConnexion.Open();
                String maRequeteSQL = "insert into P01_Soin(NoSoin,Description,Duree,NoTypeSoin,prix) values('" + int.Parse(noSoinTextBox.ToString()) + "','" + descriptionTextBox.ToString() + "','" + int.Parse(dureeTextBox.ToString()) + "','" + int.Parse(noTypeSoinTextBox.ToString()) +"','"+int.Parse(prixTextBox.ToString())+ "')";
                SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                maCommande.ExecuteScalar();
                maConnexion.Close();

            }
            else if (!booAjout)
            {
                // MODIF
            }
        }
    }
}
