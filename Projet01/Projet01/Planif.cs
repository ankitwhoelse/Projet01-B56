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
    public partial class Planif : Form
    {
        public Planif()
        {
            InitializeComponent();
        }

        private void p01_SoinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.p01_SoinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56AnkitDataSet);

        }

        private void Planif_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56AnkitDataSet.NoEtNomComplet_Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.noEtNomComplet_ClientTableAdapter.Fill(this.bDB56AnkitDataSet.NoEtNomComplet_Client);
            // TODO: cette ligne de code charge les données dans la table 'bDB56AnkitDataSet.P01_Assistant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.p01_AssistantTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Assistant);
            // TODO: cette ligne de code charge les données dans la table 'bDB56AnkitDataSet.P01_Soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.p01_SoinTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Soin);

        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }
    }
}
