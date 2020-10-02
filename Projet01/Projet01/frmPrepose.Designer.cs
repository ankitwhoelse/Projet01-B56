namespace Projet01
{
    partial class frmPrepose
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label noClientLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label villeLabel;
            System.Windows.Forms.Label paysLabel;
            System.Windows.Forms.Label adresseLabel;
            System.Windows.Forms.Label codePostalLabel;
            System.Windows.Forms.Label dateInscriptionLabel;
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.bDB56AnkitDataSet = new Projet01.BDB56AnkitDataSet();
            this.p01_ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p01_ClientTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_ClientTableAdapter();
            this.tableAdapterManager = new Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager();
            this.cboClients = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPreposeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationDesChambreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.noClientTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.villeTextBox = new System.Windows.Forms.TextBox();
            this.paysTextBox = new System.Windows.Forms.TextBox();
            this.adresseTextBox = new System.Windows.Forms.TextBox();
            this.codePostalTextBox = new System.Windows.Forms.TextBox();
            this.dateInscriptionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gbInfoClient = new System.Windows.Forms.GroupBox();
            this.btnAjoutSoin = new System.Windows.Forms.Button();
            noClientLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            paysLabel = new System.Windows.Forms.Label();
            adresseLabel = new System.Windows.Forms.Label();
            codePostalLabel = new System.Windows.Forms.Label();
            dateInscriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_ClientBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbInfoClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // noClientLabel
            // 
            noClientLabel.AutoSize = true;
            noClientLabel.Location = new System.Drawing.Point(6, 16);
            noClientLabel.Name = "noClientLabel";
            noClientLabel.Size = new System.Drawing.Size(53, 13);
            noClientLabel.TabIndex = 11;
            noClientLabel.Text = "No Client:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(6, 42);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 13;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(6, 68);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 15;
            prenomLabel.Text = "Prenom:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Location = new System.Drawing.Point(6, 94);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(29, 13);
            villeLabel.TabIndex = 17;
            villeLabel.Text = "Ville:";
            // 
            // paysLabel
            // 
            paysLabel.AutoSize = true;
            paysLabel.Location = new System.Drawing.Point(6, 120);
            paysLabel.Name = "paysLabel";
            paysLabel.Size = new System.Drawing.Size(33, 13);
            paysLabel.TabIndex = 19;
            paysLabel.Text = "Pays:";
            // 
            // adresseLabel
            // 
            adresseLabel.AutoSize = true;
            adresseLabel.Location = new System.Drawing.Point(6, 146);
            adresseLabel.Name = "adresseLabel";
            adresseLabel.Size = new System.Drawing.Size(48, 13);
            adresseLabel.TabIndex = 21;
            adresseLabel.Text = "Adresse:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Location = new System.Drawing.Point(6, 172);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(67, 13);
            codePostalLabel.TabIndex = 23;
            codePostalLabel.Text = "Code Postal:";
            // 
            // dateInscriptionLabel
            // 
            dateInscriptionLabel.AutoSize = true;
            dateInscriptionLabel.Location = new System.Drawing.Point(6, 199);
            dateInscriptionLabel.Name = "dateInscriptionLabel";
            dateInscriptionLabel.Size = new System.Drawing.Size(84, 13);
            dateInscriptionLabel.TabIndex = 25;
            dateInscriptionLabel.Text = "Date Inscription:";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(524, 405);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(129, 33);
            this.btnDeconnexion.TabIndex = 1;
            this.btnDeconnexion.Text = "Deconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(659, 405);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(129, 33);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // bDB56AnkitDataSet
            // 
            this.bDB56AnkitDataSet.DataSetName = "BDB56AnkitDataSet";
            this.bDB56AnkitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p01_ClientBindingSource
            // 
            this.p01_ClientBindingSource.DataMember = "P01_Client";
            this.p01_ClientBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // p01_ClientTableAdapter
            // 
            this.p01_ClientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.P01_AssistantSoinTableAdapter = null;
            this.tableAdapterManager.P01_AssistantTableAdapter = null;
            this.tableAdapterManager.P01_ChambreTableAdapter = null;
            this.tableAdapterManager.P01_ClientTableAdapter = this.p01_ClientTableAdapter;
            this.tableAdapterManager.P01_InviteTableAdapter = null;
            this.tableAdapterManager.P01_PlanifSoinTableAdapter = null;
            this.tableAdapterManager.P01_ReversationChambreTableAdapter = null;
            this.tableAdapterManager.P01_SoinTableAdapter = null;
            this.tableAdapterManager.P01_TypeChambreTableAdapter = null;
            this.tableAdapterManager.P01_TypeSoinTableAdapter = null;
            this.tableAdapterManager.P01_TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.P01_UtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cboClients
            // 
            this.cboClients.DataSource = this.p01_ClientBindingSource;
            this.cboClients.DisplayMember = "Nom";
            this.cboClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClients.FormattingEnabled = true;
            this.cboClients.Location = new System.Drawing.Point(12, 68);
            this.cboClients.Name = "cboClients";
            this.cboClients.Size = new System.Drawing.Size(155, 21);
            this.cboClients.TabIndex = 4;
            this.cboClients.ValueMember = "NoClient";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPreposeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPreposeToolStripMenuItem
            // 
            this.menuPreposeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesClientsToolStripMenuItem,
            this.reservationDesChambreToolStripMenuItem});
            this.menuPreposeToolStripMenuItem.Name = "menuPreposeToolStripMenuItem";
            this.menuPreposeToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.menuPreposeToolStripMenuItem.Text = "Menu prepose";
            // 
            // gestionDesClientsToolStripMenuItem
            // 
            this.gestionDesClientsToolStripMenuItem.Name = "gestionDesClientsToolStripMenuItem";
            this.gestionDesClientsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.gestionDesClientsToolStripMenuItem.Text = "Gestion des clients";
            this.gestionDesClientsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesClientsToolStripMenuItem_Click);
            // 
            // reservationDesChambreToolStripMenuItem
            // 
            this.reservationDesChambreToolStripMenuItem.Name = "reservationDesChambreToolStripMenuItem";
            this.reservationDesChambreToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.reservationDesChambreToolStripMenuItem.Text = "Reservation des chambre";
            this.reservationDesChambreToolStripMenuItem.Click += new System.EventHandler(this.reservationDesChambreToolStripMenuItem_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(12, 385);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 11;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(93, 385);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 10;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 356);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(156, 23);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // noClientTextBox
            // 
            this.noClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "NoClient", true));
            this.noClientTextBox.Location = new System.Drawing.Point(96, 13);
            this.noClientTextBox.Name = "noClientTextBox";
            this.noClientTextBox.Size = new System.Drawing.Size(200, 20);
            this.noClientTextBox.TabIndex = 12;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(96, 39);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomTextBox.TabIndex = 14;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(96, 65);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(200, 20);
            this.prenomTextBox.TabIndex = 16;
            // 
            // villeTextBox
            // 
            this.villeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "Ville", true));
            this.villeTextBox.Location = new System.Drawing.Point(96, 91);
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.Size = new System.Drawing.Size(200, 20);
            this.villeTextBox.TabIndex = 18;
            // 
            // paysTextBox
            // 
            this.paysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "Pays", true));
            this.paysTextBox.Location = new System.Drawing.Point(96, 117);
            this.paysTextBox.Name = "paysTextBox";
            this.paysTextBox.Size = new System.Drawing.Size(200, 20);
            this.paysTextBox.TabIndex = 20;
            // 
            // adresseTextBox
            // 
            this.adresseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "Adresse", true));
            this.adresseTextBox.Location = new System.Drawing.Point(96, 143);
            this.adresseTextBox.Name = "adresseTextBox";
            this.adresseTextBox.Size = new System.Drawing.Size(200, 20);
            this.adresseTextBox.TabIndex = 22;
            // 
            // codePostalTextBox
            // 
            this.codePostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "CodePostal", true));
            this.codePostalTextBox.Location = new System.Drawing.Point(96, 169);
            this.codePostalTextBox.Name = "codePostalTextBox";
            this.codePostalTextBox.Size = new System.Drawing.Size(200, 20);
            this.codePostalTextBox.TabIndex = 24;
            // 
            // dateInscriptionDateTimePicker
            // 
            this.dateInscriptionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.p01_ClientBindingSource, "DateInscription", true));
            this.dateInscriptionDateTimePicker.Location = new System.Drawing.Point(96, 195);
            this.dateInscriptionDateTimePicker.Name = "dateInscriptionDateTimePicker";
            this.dateInscriptionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateInscriptionDateTimePicker.TabIndex = 26;
            // 
            // gbInfoClient
            // 
            this.gbInfoClient.Controls.Add(this.nomTextBox);
            this.gbInfoClient.Controls.Add(noClientLabel);
            this.gbInfoClient.Controls.Add(this.dateInscriptionDateTimePicker);
            this.gbInfoClient.Controls.Add(this.noClientTextBox);
            this.gbInfoClient.Controls.Add(dateInscriptionLabel);
            this.gbInfoClient.Controls.Add(nomLabel);
            this.gbInfoClient.Controls.Add(this.codePostalTextBox);
            this.gbInfoClient.Controls.Add(codePostalLabel);
            this.gbInfoClient.Controls.Add(prenomLabel);
            this.gbInfoClient.Controls.Add(this.adresseTextBox);
            this.gbInfoClient.Controls.Add(this.prenomTextBox);
            this.gbInfoClient.Controls.Add(adresseLabel);
            this.gbInfoClient.Controls.Add(villeLabel);
            this.gbInfoClient.Controls.Add(this.paysTextBox);
            this.gbInfoClient.Controls.Add(this.villeTextBox);
            this.gbInfoClient.Controls.Add(paysLabel);
            this.gbInfoClient.Location = new System.Drawing.Point(195, 68);
            this.gbInfoClient.Name = "gbInfoClient";
            this.gbInfoClient.Size = new System.Drawing.Size(302, 224);
            this.gbInfoClient.TabIndex = 27;
            this.gbInfoClient.TabStop = false;
            this.gbInfoClient.Text = "Information sur le client";
            // 
            // btnAjoutSoin
            // 
            this.btnAjoutSoin.Enabled = false;
            this.btnAjoutSoin.Location = new System.Drawing.Point(12, 327);
            this.btnAjoutSoin.Name = "btnAjoutSoin";
            this.btnAjoutSoin.Size = new System.Drawing.Size(156, 23);
            this.btnAjoutSoin.TabIndex = 9;
            this.btnAjoutSoin.Text = "Ajouter un soin";
            this.btnAjoutSoin.UseVisualStyleBackColor = true;
            this.btnAjoutSoin.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // frmPrepose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 458);
            this.Controls.Add(this.gbInfoClient);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjoutSoin);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cboClients);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPrepose";
            this.Text = "Prepose";
            this.Load += new System.EventHandler(this.frmPrepose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_ClientBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbInfoClient.ResumeLayout(false);
            this.gbInfoClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnQuitter;
        private BDB56AnkitDataSet bDB56AnkitDataSet;
        private System.Windows.Forms.BindingSource p01_ClientBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_ClientTableAdapter p01_ClientTableAdapter;
        private BDB56AnkitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cboClients;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPreposeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationDesChambreToolStripMenuItem;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox noClientTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox villeTextBox;
        private System.Windows.Forms.TextBox paysTextBox;
        private System.Windows.Forms.TextBox adresseTextBox;
        private System.Windows.Forms.TextBox codePostalTextBox;
        private System.Windows.Forms.DateTimePicker dateInscriptionDateTimePicker;
        private System.Windows.Forms.GroupBox gbInfoClient;
        private System.Windows.Forms.Button btnAjoutSoin;
    }
}