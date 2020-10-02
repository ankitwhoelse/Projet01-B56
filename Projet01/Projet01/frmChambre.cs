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
    public partial class frmChambre : Form
    {
        public dynamic NoChambre;
        public bool booAjout;


        public frmChambre()
        {
            InitializeComponent();
        }

        private void p01_ChambreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.p01_ChambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56AnkitDataSet);

        }

        private void frmChambre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Chambre' table. You can move, or remove it, as needed.
            this.p01_ChambreTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Chambre);

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (booAjout)
            {
                // Ajout chambre
            }
            else if (!booAjout)
            {
                // Modif chambre
            }
        }


    }
}
