namespace Projet01
{
    partial class frmAdmin
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
            System.Windows.Forms.Label noUtilisateurLabel;
            System.Windows.Forms.Label nomUtilisateurLabel;
            System.Windows.Forms.Label motDePasseLabel;
            System.Windows.Forms.Label noTypeLabel;
            System.Windows.Forms.Label noClientLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label villeLabel;
            System.Windows.Forms.Label paysLabel;
            System.Windows.Forms.Label adresseLabel;
            System.Windows.Forms.Label codePostalLabel;
            System.Windows.Forms.Label dateInscriptionLabel;
            System.Windows.Forms.Label noAssistantLabel;
            System.Windows.Forms.Label prenomLabel1;
            System.Windows.Forms.Label nomLabel1;
            System.Windows.Forms.Label specialitesLabel;
            System.Windows.Forms.Label remarquesLabel;
            System.Windows.Forms.Label noSoinLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label dureeLabel;
            System.Windows.Forms.Label noTypeSoinLabel;
            System.Windows.Forms.Label prixLabel;
            System.Windows.Forms.Label noChambreLabel;
            System.Windows.Forms.Label emplacementLabel;
            System.Windows.Forms.Label decorationsLabel;
            System.Windows.Forms.Label noTypeChambreLabel;
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsEtLeursInvitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assistantsEtLesSoinsOffertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chambresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bDB56AnkitDataSet = new Projet01.BDB56AnkitDataSet();
            this.p01_UtilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p01_UtilisateurTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_UtilisateurTableAdapter();
            this.tableAdapterManager = new Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager();
            this.p01_ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p01_ClientTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_ClientTableAdapter();
            this.p01_ChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p01_ChambreTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_ChambreTableAdapter();
            this.cboUtilisateurs = new System.Windows.Forms.ComboBox();
            this.lblChoix = new System.Windows.Forms.Label();
            this.lblSelection = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.cboClients = new System.Windows.Forms.ComboBox();
            this.noUtilisateurTextBox = new System.Windows.Forms.TextBox();
            this.nomUtilisateurTextBox = new System.Windows.Forms.TextBox();
            this.motDePasseTextBox = new System.Windows.Forms.TextBox();
            this.noTypeTextBox = new System.Windows.Forms.TextBox();
            this.gbInfoUtilisateur = new System.Windows.Forms.GroupBox();
            this.gbInfoClient = new System.Windows.Forms.GroupBox();
            this.villeTextBox = new System.Windows.Forms.TextBox();
            this.dateInscriptionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.noClientTextBox = new System.Windows.Forms.TextBox();
            this.codePostalTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.adresseTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.paysTextBox = new System.Windows.Forms.TextBox();
            this.p01_AssistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p01_AssistantTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_AssistantTableAdapter();
            this.cboAssistants = new System.Windows.Forms.ComboBox();
            this.gbInfoAssistants = new System.Windows.Forms.GroupBox();
            this.noAssistantTextBox = new System.Windows.Forms.TextBox();
            this.remarquesTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox1 = new System.Windows.Forms.TextBox();
            this.specialitesTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox1 = new System.Windows.Forms.TextBox();
            this.p01_SoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p01_SoinTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_SoinTableAdapter();
            this.cboSoins = new System.Windows.Forms.ComboBox();
            this.gbInfoSoins = new System.Windows.Forms.GroupBox();
            this.noSoinTextBox = new System.Windows.Forms.TextBox();
            this.prixTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.noTypeSoinTextBox = new System.Windows.Forms.TextBox();
            this.dureeTextBox = new System.Windows.Forms.TextBox();
            this.cboChambres = new System.Windows.Forms.ComboBox();
            this.gbInfoChambre = new System.Windows.Forms.GroupBox();
            this.noChambreTextBox = new System.Windows.Forms.TextBox();
            this.emplacementTextBox = new System.Windows.Forms.TextBox();
            this.decorationsTextBox = new System.Windows.Forms.TextBox();
            this.noTypeChambreTextBox = new System.Windows.Forms.TextBox();
            noUtilisateurLabel = new System.Windows.Forms.Label();
            nomUtilisateurLabel = new System.Windows.Forms.Label();
            motDePasseLabel = new System.Windows.Forms.Label();
            noTypeLabel = new System.Windows.Forms.Label();
            noClientLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            paysLabel = new System.Windows.Forms.Label();
            adresseLabel = new System.Windows.Forms.Label();
            codePostalLabel = new System.Windows.Forms.Label();
            dateInscriptionLabel = new System.Windows.Forms.Label();
            noAssistantLabel = new System.Windows.Forms.Label();
            prenomLabel1 = new System.Windows.Forms.Label();
            nomLabel1 = new System.Windows.Forms.Label();
            specialitesLabel = new System.Windows.Forms.Label();
            remarquesLabel = new System.Windows.Forms.Label();
            noSoinLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            dureeLabel = new System.Windows.Forms.Label();
            noTypeSoinLabel = new System.Windows.Forms.Label();
            prixLabel = new System.Windows.Forms.Label();
            noChambreLabel = new System.Windows.Forms.Label();
            emplacementLabel = new System.Windows.Forms.Label();
            decorationsLabel = new System.Windows.Forms.Label();
            noTypeChambreLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_UtilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_ClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_ChambreBindingSource)).BeginInit();
            this.gbInfoUtilisateur.SuspendLayout();
            this.gbInfoClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p01_AssistantBindingSource)).BeginInit();
            this.gbInfoAssistants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p01_SoinBindingSource)).BeginInit();
            this.gbInfoSoins.SuspendLayout();
            this.gbInfoChambre.SuspendLayout();
            this.SuspendLayout();
            // 
            // noUtilisateurLabel
            // 
            noUtilisateurLabel.AutoSize = true;
            noUtilisateurLabel.Location = new System.Drawing.Point(6, 16);
            noUtilisateurLabel.Name = "noUtilisateurLabel";
            noUtilisateurLabel.Size = new System.Drawing.Size(73, 13);
            noUtilisateurLabel.TabIndex = 10;
            noUtilisateurLabel.Text = "No Utilisateur:";
            // 
            // nomUtilisateurLabel
            // 
            nomUtilisateurLabel.AutoSize = true;
            nomUtilisateurLabel.Location = new System.Drawing.Point(6, 42);
            nomUtilisateurLabel.Name = "nomUtilisateurLabel";
            nomUtilisateurLabel.Size = new System.Drawing.Size(81, 13);
            nomUtilisateurLabel.TabIndex = 12;
            nomUtilisateurLabel.Text = "Nom Utilisateur:";
            // 
            // motDePasseLabel
            // 
            motDePasseLabel.AutoSize = true;
            motDePasseLabel.Location = new System.Drawing.Point(6, 68);
            motDePasseLabel.Name = "motDePasseLabel";
            motDePasseLabel.Size = new System.Drawing.Size(77, 13);
            motDePasseLabel.TabIndex = 14;
            motDePasseLabel.Text = "Mot De Passe:";
            // 
            // noTypeLabel
            // 
            noTypeLabel.AutoSize = true;
            noTypeLabel.Location = new System.Drawing.Point(6, 94);
            noTypeLabel.Name = "noTypeLabel";
            noTypeLabel.Size = new System.Drawing.Size(51, 13);
            noTypeLabel.TabIndex = 16;
            noTypeLabel.Text = "No Type:";
            // 
            // noClientLabel
            // 
            noClientLabel.AutoSize = true;
            noClientLabel.Location = new System.Drawing.Point(6, 16);
            noClientLabel.Name = "noClientLabel";
            noClientLabel.Size = new System.Drawing.Size(53, 13);
            noClientLabel.TabIndex = 18;
            noClientLabel.Text = "No Client:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(6, 42);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 20;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(6, 68);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 22;
            prenomLabel.Text = "Prenom:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Location = new System.Drawing.Point(6, 94);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(29, 13);
            villeLabel.TabIndex = 24;
            villeLabel.Text = "Ville:";
            // 
            // paysLabel
            // 
            paysLabel.AutoSize = true;
            paysLabel.Location = new System.Drawing.Point(6, 120);
            paysLabel.Name = "paysLabel";
            paysLabel.Size = new System.Drawing.Size(33, 13);
            paysLabel.TabIndex = 26;
            paysLabel.Text = "Pays:";
            // 
            // adresseLabel
            // 
            adresseLabel.AutoSize = true;
            adresseLabel.Location = new System.Drawing.Point(6, 146);
            adresseLabel.Name = "adresseLabel";
            adresseLabel.Size = new System.Drawing.Size(48, 13);
            adresseLabel.TabIndex = 28;
            adresseLabel.Text = "Adresse:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Location = new System.Drawing.Point(6, 172);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(67, 13);
            codePostalLabel.TabIndex = 30;
            codePostalLabel.Text = "Code Postal:";
            // 
            // dateInscriptionLabel
            // 
            dateInscriptionLabel.AutoSize = true;
            dateInscriptionLabel.Location = new System.Drawing.Point(6, 199);
            dateInscriptionLabel.Name = "dateInscriptionLabel";
            dateInscriptionLabel.Size = new System.Drawing.Size(84, 13);
            dateInscriptionLabel.TabIndex = 32;
            dateInscriptionLabel.Text = "Date Inscription:";
            // 
            // noAssistantLabel
            // 
            noAssistantLabel.AutoSize = true;
            noAssistantLabel.Location = new System.Drawing.Point(6, 16);
            noAssistantLabel.Name = "noAssistantLabel";
            noAssistantLabel.Size = new System.Drawing.Size(69, 13);
            noAssistantLabel.TabIndex = 35;
            noAssistantLabel.Text = "No Assistant:";
            // 
            // prenomLabel1
            // 
            prenomLabel1.AutoSize = true;
            prenomLabel1.Location = new System.Drawing.Point(6, 42);
            prenomLabel1.Name = "prenomLabel1";
            prenomLabel1.Size = new System.Drawing.Size(46, 13);
            prenomLabel1.TabIndex = 37;
            prenomLabel1.Text = "Prenom:";
            // 
            // nomLabel1
            // 
            nomLabel1.AutoSize = true;
            nomLabel1.Location = new System.Drawing.Point(6, 68);
            nomLabel1.Name = "nomLabel1";
            nomLabel1.Size = new System.Drawing.Size(32, 13);
            nomLabel1.TabIndex = 39;
            nomLabel1.Text = "Nom:";
            // 
            // specialitesLabel
            // 
            specialitesLabel.AutoSize = true;
            specialitesLabel.Location = new System.Drawing.Point(6, 94);
            specialitesLabel.Name = "specialitesLabel";
            specialitesLabel.Size = new System.Drawing.Size(61, 13);
            specialitesLabel.TabIndex = 41;
            specialitesLabel.Text = "Specialites:";
            // 
            // remarquesLabel
            // 
            remarquesLabel.AutoSize = true;
            remarquesLabel.Location = new System.Drawing.Point(6, 120);
            remarquesLabel.Name = "remarquesLabel";
            remarquesLabel.Size = new System.Drawing.Size(64, 13);
            remarquesLabel.TabIndex = 43;
            remarquesLabel.Text = "Remarques:";
            // 
            // noSoinLabel
            // 
            noSoinLabel.AutoSize = true;
            noSoinLabel.Location = new System.Drawing.Point(6, 16);
            noSoinLabel.Name = "noSoinLabel";
            noSoinLabel.Size = new System.Drawing.Size(48, 13);
            noSoinLabel.TabIndex = 36;
            noSoinLabel.Text = "No Soin:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(6, 42);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 38;
            descriptionLabel.Text = "Description:";
            // 
            // dureeLabel
            // 
            dureeLabel.AutoSize = true;
            dureeLabel.Location = new System.Drawing.Point(6, 68);
            dureeLabel.Name = "dureeLabel";
            dureeLabel.Size = new System.Drawing.Size(39, 13);
            dureeLabel.TabIndex = 40;
            dureeLabel.Text = "Duree:";
            // 
            // noTypeSoinLabel
            // 
            noTypeSoinLabel.AutoSize = true;
            noTypeSoinLabel.Location = new System.Drawing.Point(6, 94);
            noTypeSoinLabel.Name = "noTypeSoinLabel";
            noTypeSoinLabel.Size = new System.Drawing.Size(75, 13);
            noTypeSoinLabel.TabIndex = 42;
            noTypeSoinLabel.Text = "No Type Soin:";
            // 
            // prixLabel
            // 
            prixLabel.AutoSize = true;
            prixLabel.Location = new System.Drawing.Point(6, 120);
            prixLabel.Name = "prixLabel";
            prixLabel.Size = new System.Drawing.Size(27, 13);
            prixLabel.TabIndex = 44;
            prixLabel.Text = "Prix:";
            // 
            // noChambreLabel
            // 
            noChambreLabel.AutoSize = true;
            noChambreLabel.Location = new System.Drawing.Point(6, 16);
            noChambreLabel.Name = "noChambreLabel";
            noChambreLabel.Size = new System.Drawing.Size(69, 13);
            noChambreLabel.TabIndex = 0;
            noChambreLabel.Text = "No Chambre:";
            // 
            // emplacementLabel
            // 
            emplacementLabel.AutoSize = true;
            emplacementLabel.Location = new System.Drawing.Point(6, 42);
            emplacementLabel.Name = "emplacementLabel";
            emplacementLabel.Size = new System.Drawing.Size(74, 13);
            emplacementLabel.TabIndex = 2;
            emplacementLabel.Text = "Emplacement:";
            // 
            // decorationsLabel
            // 
            decorationsLabel.AutoSize = true;
            decorationsLabel.Location = new System.Drawing.Point(6, 68);
            decorationsLabel.Name = "decorationsLabel";
            decorationsLabel.Size = new System.Drawing.Size(67, 13);
            decorationsLabel.TabIndex = 4;
            decorationsLabel.Text = "Decorations:";
            // 
            // noTypeChambreLabel
            // 
            noTypeChambreLabel.AutoSize = true;
            noTypeChambreLabel.Location = new System.Drawing.Point(6, 94);
            noTypeChambreLabel.Name = "noTypeChambreLabel";
            noTypeChambreLabel.Size = new System.Drawing.Size(96, 13);
            noTypeChambreLabel.TabIndex = 6;
            noTypeChambreLabel.Text = "No Type Chambre:";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(441, 308);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(129, 33);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(306, 308);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(129, 33);
            this.btnDeconnexion.TabIndex = 0;
            this.btnDeconnexion.Text = "Deconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.visualiserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateursToolStripMenuItem,
            this.clientsEtLeursInvitesToolStripMenuItem,
            this.assistantsEtLesSoinsOffertsToolStripMenuItem,
            this.soinsToolStripMenuItem,
            this.chambresToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // utilisateursToolStripMenuItem
            // 
            this.utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            this.utilisateursToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.utilisateursToolStripMenuItem.Text = "Utilisateurs";
            this.utilisateursToolStripMenuItem.Click += new System.EventHandler(this.utilisateursToolStripMenuItem_Click);
            // 
            // clientsEtLeursInvitesToolStripMenuItem
            // 
            this.clientsEtLeursInvitesToolStripMenuItem.Name = "clientsEtLeursInvitesToolStripMenuItem";
            this.clientsEtLeursInvitesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.clientsEtLeursInvitesToolStripMenuItem.Text = "Clients et leurs invites";
            this.clientsEtLeursInvitesToolStripMenuItem.Click += new System.EventHandler(this.clientsEtLeursInvitesToolStripMenuItem_Click);
            // 
            // assistantsEtLesSoinsOffertsToolStripMenuItem
            // 
            this.assistantsEtLesSoinsOffertsToolStripMenuItem.Name = "assistantsEtLesSoinsOffertsToolStripMenuItem";
            this.assistantsEtLesSoinsOffertsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.assistantsEtLesSoinsOffertsToolStripMenuItem.Text = "Assistants";
            this.assistantsEtLesSoinsOffertsToolStripMenuItem.Click += new System.EventHandler(this.assistantsEtLesSoinsOffertsToolStripMenuItem_Click);
            // 
            // soinsToolStripMenuItem
            // 
            this.soinsToolStripMenuItem.Name = "soinsToolStripMenuItem";
            this.soinsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.soinsToolStripMenuItem.Text = "Soins";
            this.soinsToolStripMenuItem.Click += new System.EventHandler(this.soinsToolStripMenuItem_Click);
            // 
            // chambresToolStripMenuItem
            // 
            this.chambresToolStripMenuItem.Name = "chambresToolStripMenuItem";
            this.chambresToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.chambresToolStripMenuItem.Text = "Chambres";
            this.chambresToolStripMenuItem.Click += new System.EventHandler(this.chambresToolStripMenuItem_Click);
            // 
            // visualiserToolStripMenuItem
            // 
            this.visualiserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapportsToolStripMenuItem});
            this.visualiserToolStripMenuItem.Name = "visualiserToolStripMenuItem";
            this.visualiserToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.visualiserToolStripMenuItem.Text = "Visualiser";
            // 
            // rapportsToolStripMenuItem
            // 
            this.rapportsToolStripMenuItem.Name = "rapportsToolStripMenuItem";
            this.rapportsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.rapportsToolStripMenuItem.Text = "Rapports";
            // 
            // bDB56AnkitDataSet
            // 
            this.bDB56AnkitDataSet.DataSetName = "BDB56AnkitDataSet";
            this.bDB56AnkitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p01_UtilisateurBindingSource
            // 
            this.p01_UtilisateurBindingSource.DataMember = "P01_Utilisateur";
            this.p01_UtilisateurBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // p01_UtilisateurTableAdapter
            // 
            this.p01_UtilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.P01_AssistantTableAdapter = null;
            this.tableAdapterManager.P01_ChambreTableAdapter = null;
            this.tableAdapterManager.P01_ClientTableAdapter = null;
            this.tableAdapterManager.P01_InviteTableAdapter = null;
            this.tableAdapterManager.P01_ReversationChambreTableAdapter = null;
            this.tableAdapterManager.P01_SoinTableAdapter = null;
            this.tableAdapterManager.P01_TypeChambreTableAdapter = null;
            this.tableAdapterManager.P01_TypeSoinTableAdapter = null;
            this.tableAdapterManager.P01_TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.P01_UtilisateurTableAdapter = this.p01_UtilisateurTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // p01_ChambreBindingSource
            // 
            this.p01_ChambreBindingSource.DataMember = "P01_Chambre";
            this.p01_ChambreBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // p01_ChambreTableAdapter
            // 
            this.p01_ChambreTableAdapter.ClearBeforeFill = true;
            // 
            // cboUtilisateurs
            // 
            this.cboUtilisateurs.DataSource = this.p01_UtilisateurBindingSource;
            this.cboUtilisateurs.DisplayMember = "NomUtilisateur";
            this.cboUtilisateurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUtilisateurs.FormattingEnabled = true;
            this.cboUtilisateurs.Location = new System.Drawing.Point(17, 115);
            this.cboUtilisateurs.Name = "cboUtilisateurs";
            this.cboUtilisateurs.Size = new System.Drawing.Size(133, 21);
            this.cboUtilisateurs.TabIndex = 3;
            this.cboUtilisateurs.ValueMember = "NoUtilisateur";
            // 
            // lblChoix
            // 
            this.lblChoix.AutoSize = true;
            this.lblChoix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoix.Location = new System.Drawing.Point(13, 34);
            this.lblChoix.Name = "lblChoix";
            this.lblChoix.Size = new System.Drawing.Size(71, 20);
            this.lblChoix.TabIndex = 4;
            this.lblChoix.Text = "lblChoix";
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelection.Location = new System.Drawing.Point(14, 79);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(78, 16);
            this.lblSelection.TabIndex = 5;
            this.lblSelection.Text = "lblSelection";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(17, 289);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(156, 23);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(98, 318);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(17, 318);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // cboClients
            // 
            this.cboClients.DataSource = this.p01_ClientBindingSource;
            this.cboClients.DisplayMember = "Nom";
            this.cboClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClients.FormattingEnabled = true;
            this.cboClients.Location = new System.Drawing.Point(17, 142);
            this.cboClients.Name = "cboClients";
            this.cboClients.Size = new System.Drawing.Size(133, 21);
            this.cboClients.TabIndex = 9;
            this.cboClients.ValueMember = "NoClient";
            // 
            // noUtilisateurTextBox
            // 
            this.noUtilisateurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_UtilisateurBindingSource, "NoUtilisateur", true));
            this.noUtilisateurTextBox.Location = new System.Drawing.Point(93, 13);
            this.noUtilisateurTextBox.Name = "noUtilisateurTextBox";
            this.noUtilisateurTextBox.Size = new System.Drawing.Size(100, 20);
            this.noUtilisateurTextBox.TabIndex = 11;
            // 
            // nomUtilisateurTextBox
            // 
            this.nomUtilisateurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_UtilisateurBindingSource, "NomUtilisateur", true));
            this.nomUtilisateurTextBox.Location = new System.Drawing.Point(93, 39);
            this.nomUtilisateurTextBox.Name = "nomUtilisateurTextBox";
            this.nomUtilisateurTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomUtilisateurTextBox.TabIndex = 13;
            // 
            // motDePasseTextBox
            // 
            this.motDePasseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_UtilisateurBindingSource, "MotDePasse", true));
            this.motDePasseTextBox.Location = new System.Drawing.Point(93, 65);
            this.motDePasseTextBox.Name = "motDePasseTextBox";
            this.motDePasseTextBox.Size = new System.Drawing.Size(100, 20);
            this.motDePasseTextBox.TabIndex = 15;
            // 
            // noTypeTextBox
            // 
            this.noTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_UtilisateurBindingSource, "NoType", true));
            this.noTypeTextBox.Location = new System.Drawing.Point(93, 91);
            this.noTypeTextBox.Name = "noTypeTextBox";
            this.noTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.noTypeTextBox.TabIndex = 17;
            // 
            // gbInfoUtilisateur
            // 
            this.gbInfoUtilisateur.Controls.Add(this.nomUtilisateurTextBox);
            this.gbInfoUtilisateur.Controls.Add(noUtilisateurLabel);
            this.gbInfoUtilisateur.Controls.Add(this.noTypeTextBox);
            this.gbInfoUtilisateur.Controls.Add(this.noUtilisateurTextBox);
            this.gbInfoUtilisateur.Controls.Add(noTypeLabel);
            this.gbInfoUtilisateur.Controls.Add(nomUtilisateurLabel);
            this.gbInfoUtilisateur.Controls.Add(this.motDePasseTextBox);
            this.gbInfoUtilisateur.Controls.Add(motDePasseLabel);
            this.gbInfoUtilisateur.Location = new System.Drawing.Point(233, 65);
            this.gbInfoUtilisateur.Name = "gbInfoUtilisateur";
            this.gbInfoUtilisateur.Size = new System.Drawing.Size(201, 119);
            this.gbInfoUtilisateur.TabIndex = 18;
            this.gbInfoUtilisateur.TabStop = false;
            this.gbInfoUtilisateur.Text = "Informations sur l\'utilisateur";
            // 
            // gbInfoClient
            // 
            this.gbInfoClient.Controls.Add(this.villeTextBox);
            this.gbInfoClient.Controls.Add(noClientLabel);
            this.gbInfoClient.Controls.Add(this.dateInscriptionDateTimePicker);
            this.gbInfoClient.Controls.Add(this.noClientTextBox);
            this.gbInfoClient.Controls.Add(dateInscriptionLabel);
            this.gbInfoClient.Controls.Add(nomLabel);
            this.gbInfoClient.Controls.Add(this.codePostalTextBox);
            this.gbInfoClient.Controls.Add(this.nomTextBox);
            this.gbInfoClient.Controls.Add(codePostalLabel);
            this.gbInfoClient.Controls.Add(prenomLabel);
            this.gbInfoClient.Controls.Add(this.adresseTextBox);
            this.gbInfoClient.Controls.Add(this.prenomTextBox);
            this.gbInfoClient.Controls.Add(adresseLabel);
            this.gbInfoClient.Controls.Add(villeLabel);
            this.gbInfoClient.Controls.Add(this.paysTextBox);
            this.gbInfoClient.Controls.Add(paysLabel);
            this.gbInfoClient.Location = new System.Drawing.Point(441, 65);
            this.gbInfoClient.Name = "gbInfoClient";
            this.gbInfoClient.Size = new System.Drawing.Size(304, 225);
            this.gbInfoClient.TabIndex = 34;
            this.gbInfoClient.TabStop = false;
            this.gbInfoClient.Text = "Informations sur le client";
            this.gbInfoClient.Visible = false;
            // 
            // villeTextBox
            // 
            this.villeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "Ville", true));
            this.villeTextBox.Location = new System.Drawing.Point(96, 91);
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.Size = new System.Drawing.Size(200, 20);
            this.villeTextBox.TabIndex = 25;
            // 
            // dateInscriptionDateTimePicker
            // 
            this.dateInscriptionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.p01_ClientBindingSource, "DateInscription", true));
            this.dateInscriptionDateTimePicker.Location = new System.Drawing.Point(96, 195);
            this.dateInscriptionDateTimePicker.Name = "dateInscriptionDateTimePicker";
            this.dateInscriptionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateInscriptionDateTimePicker.TabIndex = 33;
            // 
            // noClientTextBox
            // 
            this.noClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "NoClient", true));
            this.noClientTextBox.Location = new System.Drawing.Point(96, 13);
            this.noClientTextBox.Name = "noClientTextBox";
            this.noClientTextBox.Size = new System.Drawing.Size(200, 20);
            this.noClientTextBox.TabIndex = 19;
            // 
            // codePostalTextBox
            // 
            this.codePostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "CodePostal", true));
            this.codePostalTextBox.Location = new System.Drawing.Point(96, 169);
            this.codePostalTextBox.Name = "codePostalTextBox";
            this.codePostalTextBox.Size = new System.Drawing.Size(200, 20);
            this.codePostalTextBox.TabIndex = 31;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(96, 39);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomTextBox.TabIndex = 21;
            // 
            // adresseTextBox
            // 
            this.adresseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "Adresse", true));
            this.adresseTextBox.Location = new System.Drawing.Point(96, 143);
            this.adresseTextBox.Name = "adresseTextBox";
            this.adresseTextBox.Size = new System.Drawing.Size(200, 20);
            this.adresseTextBox.TabIndex = 29;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(96, 65);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(200, 20);
            this.prenomTextBox.TabIndex = 23;
            // 
            // paysTextBox
            // 
            this.paysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "Pays", true));
            this.paysTextBox.Location = new System.Drawing.Point(96, 117);
            this.paysTextBox.Name = "paysTextBox";
            this.paysTextBox.Size = new System.Drawing.Size(200, 20);
            this.paysTextBox.TabIndex = 27;
            // 
            // p01_AssistantBindingSource
            // 
            this.p01_AssistantBindingSource.DataMember = "P01_Assistant";
            this.p01_AssistantBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // p01_AssistantTableAdapter
            // 
            this.p01_AssistantTableAdapter.ClearBeforeFill = true;
            // 
            // cboAssistants
            // 
            this.cboAssistants.DataSource = this.p01_AssistantBindingSource;
            this.cboAssistants.DisplayMember = "Nom";
            this.cboAssistants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAssistants.FormattingEnabled = true;
            this.cboAssistants.Location = new System.Drawing.Point(17, 169);
            this.cboAssistants.Name = "cboAssistants";
            this.cboAssistants.Size = new System.Drawing.Size(133, 21);
            this.cboAssistants.TabIndex = 18;
            this.cboAssistants.ValueMember = "NoAssistant";
            // 
            // gbInfoAssistants
            // 
            this.gbInfoAssistants.Controls.Add(noAssistantLabel);
            this.gbInfoAssistants.Controls.Add(this.noAssistantTextBox);
            this.gbInfoAssistants.Controls.Add(this.remarquesTextBox);
            this.gbInfoAssistants.Controls.Add(prenomLabel1);
            this.gbInfoAssistants.Controls.Add(remarquesLabel);
            this.gbInfoAssistants.Controls.Add(this.prenomTextBox1);
            this.gbInfoAssistants.Controls.Add(this.specialitesTextBox);
            this.gbInfoAssistants.Controls.Add(nomLabel1);
            this.gbInfoAssistants.Controls.Add(specialitesLabel);
            this.gbInfoAssistants.Controls.Add(this.nomTextBox1);
            this.gbInfoAssistants.Location = new System.Drawing.Point(233, 347);
            this.gbInfoAssistants.Name = "gbInfoAssistants";
            this.gbInfoAssistants.Size = new System.Drawing.Size(193, 148);
            this.gbInfoAssistants.TabIndex = 35;
            this.gbInfoAssistants.TabStop = false;
            this.gbInfoAssistants.Text = "Informations sur l\'assistant";
            // 
            // noAssistantTextBox
            // 
            this.noAssistantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_AssistantBindingSource, "NoAssistant", true));
            this.noAssistantTextBox.Location = new System.Drawing.Point(81, 13);
            this.noAssistantTextBox.Name = "noAssistantTextBox";
            this.noAssistantTextBox.Size = new System.Drawing.Size(100, 20);
            this.noAssistantTextBox.TabIndex = 36;
            // 
            // remarquesTextBox
            // 
            this.remarquesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_AssistantBindingSource, "Remarques", true));
            this.remarquesTextBox.Location = new System.Drawing.Point(81, 117);
            this.remarquesTextBox.Name = "remarquesTextBox";
            this.remarquesTextBox.Size = new System.Drawing.Size(100, 20);
            this.remarquesTextBox.TabIndex = 44;
            // 
            // prenomTextBox1
            // 
            this.prenomTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_AssistantBindingSource, "Prenom", true));
            this.prenomTextBox1.Location = new System.Drawing.Point(81, 39);
            this.prenomTextBox1.Name = "prenomTextBox1";
            this.prenomTextBox1.Size = new System.Drawing.Size(100, 20);
            this.prenomTextBox1.TabIndex = 38;
            // 
            // specialitesTextBox
            // 
            this.specialitesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_AssistantBindingSource, "Specialites", true));
            this.specialitesTextBox.Location = new System.Drawing.Point(81, 91);
            this.specialitesTextBox.Name = "specialitesTextBox";
            this.specialitesTextBox.Size = new System.Drawing.Size(100, 20);
            this.specialitesTextBox.TabIndex = 42;
            // 
            // nomTextBox1
            // 
            this.nomTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_AssistantBindingSource, "Nom", true));
            this.nomTextBox1.Location = new System.Drawing.Point(81, 65);
            this.nomTextBox1.Name = "nomTextBox1";
            this.nomTextBox1.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox1.TabIndex = 40;
            // 
            // p01_SoinBindingSource
            // 
            this.p01_SoinBindingSource.DataMember = "P01_Soin";
            this.p01_SoinBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // p01_SoinTableAdapter
            // 
            this.p01_SoinTableAdapter.ClearBeforeFill = true;
            // 
            // cboSoins
            // 
            this.cboSoins.DataSource = this.p01_SoinBindingSource;
            this.cboSoins.DisplayMember = "Description";
            this.cboSoins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSoins.FormattingEnabled = true;
            this.cboSoins.Location = new System.Drawing.Point(16, 196);
            this.cboSoins.Name = "cboSoins";
            this.cboSoins.Size = new System.Drawing.Size(134, 21);
            this.cboSoins.TabIndex = 35;
            this.cboSoins.ValueMember = "NoSoin";
            // 
            // gbInfoSoins
            // 
            this.gbInfoSoins.Controls.Add(noSoinLabel);
            this.gbInfoSoins.Controls.Add(this.noSoinTextBox);
            this.gbInfoSoins.Controls.Add(this.prixTextBox);
            this.gbInfoSoins.Controls.Add(descriptionLabel);
            this.gbInfoSoins.Controls.Add(prixLabel);
            this.gbInfoSoins.Controls.Add(this.descriptionTextBox);
            this.gbInfoSoins.Controls.Add(this.noTypeSoinTextBox);
            this.gbInfoSoins.Controls.Add(dureeLabel);
            this.gbInfoSoins.Controls.Add(noTypeSoinLabel);
            this.gbInfoSoins.Controls.Add(this.dureeTextBox);
            this.gbInfoSoins.Location = new System.Drawing.Point(441, 347);
            this.gbInfoSoins.Name = "gbInfoSoins";
            this.gbInfoSoins.Size = new System.Drawing.Size(200, 148);
            this.gbInfoSoins.TabIndex = 36;
            this.gbInfoSoins.TabStop = false;
            this.gbInfoSoins.Text = "Information sur le soin";
            // 
            // noSoinTextBox
            // 
            this.noSoinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_SoinBindingSource, "NoSoin", true));
            this.noSoinTextBox.Location = new System.Drawing.Point(87, 13);
            this.noSoinTextBox.Name = "noSoinTextBox";
            this.noSoinTextBox.Size = new System.Drawing.Size(100, 20);
            this.noSoinTextBox.TabIndex = 37;
            // 
            // prixTextBox
            // 
            this.prixTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_SoinBindingSource, "prix", true));
            this.prixTextBox.Location = new System.Drawing.Point(87, 117);
            this.prixTextBox.Name = "prixTextBox";
            this.prixTextBox.Size = new System.Drawing.Size(100, 20);
            this.prixTextBox.TabIndex = 45;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_SoinBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(87, 39);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 39;
            // 
            // noTypeSoinTextBox
            // 
            this.noTypeSoinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_SoinBindingSource, "NoTypeSoin", true));
            this.noTypeSoinTextBox.Location = new System.Drawing.Point(87, 91);
            this.noTypeSoinTextBox.Name = "noTypeSoinTextBox";
            this.noTypeSoinTextBox.Size = new System.Drawing.Size(100, 20);
            this.noTypeSoinTextBox.TabIndex = 43;
            // 
            // dureeTextBox
            // 
            this.dureeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_SoinBindingSource, "Duree", true));
            this.dureeTextBox.Location = new System.Drawing.Point(87, 65);
            this.dureeTextBox.Name = "dureeTextBox";
            this.dureeTextBox.Size = new System.Drawing.Size(100, 20);
            this.dureeTextBox.TabIndex = 41;
            // 
            // cboChambres
            // 
            this.cboChambres.DataSource = this.p01_ChambreBindingSource;
            this.cboChambres.DisplayMember = "NoChambre";
            this.cboChambres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChambres.FormattingEnabled = true;
            this.cboChambres.Location = new System.Drawing.Point(16, 223);
            this.cboChambres.Name = "cboChambres";
            this.cboChambres.Size = new System.Drawing.Size(134, 21);
            this.cboChambres.TabIndex = 36;
            this.cboChambres.ValueMember = "NoChambre";
            // 
            // gbInfoChambre
            // 
            this.gbInfoChambre.Controls.Add(noChambreLabel);
            this.gbInfoChambre.Controls.Add(this.noChambreTextBox);
            this.gbInfoChambre.Controls.Add(emplacementLabel);
            this.gbInfoChambre.Controls.Add(this.emplacementTextBox);
            this.gbInfoChambre.Controls.Add(decorationsLabel);
            this.gbInfoChambre.Controls.Add(this.decorationsTextBox);
            this.gbInfoChambre.Controls.Add(noTypeChambreLabel);
            this.gbInfoChambre.Controls.Add(this.noTypeChambreTextBox);
            this.gbInfoChambre.Location = new System.Drawing.Point(648, 347);
            this.gbInfoChambre.Name = "gbInfoChambre";
            this.gbInfoChambre.Size = new System.Drawing.Size(217, 119);
            this.gbInfoChambre.TabIndex = 37;
            this.gbInfoChambre.TabStop = false;
            this.gbInfoChambre.Text = "Information sur une chambre";
            // 
            // noChambreTextBox
            // 
            this.noChambreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ChambreBindingSource, "NoChambre", true));
            this.noChambreTextBox.Location = new System.Drawing.Point(108, 13);
            this.noChambreTextBox.Name = "noChambreTextBox";
            this.noChambreTextBox.Size = new System.Drawing.Size(100, 20);
            this.noChambreTextBox.TabIndex = 1;
            // 
            // emplacementTextBox
            // 
            this.emplacementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ChambreBindingSource, "Emplacement", true));
            this.emplacementTextBox.Location = new System.Drawing.Point(108, 39);
            this.emplacementTextBox.Name = "emplacementTextBox";
            this.emplacementTextBox.Size = new System.Drawing.Size(100, 20);
            this.emplacementTextBox.TabIndex = 3;
            // 
            // decorationsTextBox
            // 
            this.decorationsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ChambreBindingSource, "Decorations", true));
            this.decorationsTextBox.Location = new System.Drawing.Point(108, 65);
            this.decorationsTextBox.Name = "decorationsTextBox";
            this.decorationsTextBox.Size = new System.Drawing.Size(100, 20);
            this.decorationsTextBox.TabIndex = 5;
            // 
            // noTypeChambreTextBox
            // 
            this.noTypeChambreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ChambreBindingSource, "NoTypeChambre", true));
            this.noTypeChambreTextBox.Location = new System.Drawing.Point(108, 91);
            this.noTypeChambreTextBox.Name = "noTypeChambreTextBox";
            this.noTypeChambreTextBox.Size = new System.Drawing.Size(100, 20);
            this.noTypeChambreTextBox.TabIndex = 7;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 551);
            this.Controls.Add(this.gbInfoChambre);
            this.Controls.Add(this.cboChambres);
            this.Controls.Add(this.gbInfoSoins);
            this.Controls.Add(this.cboSoins);
            this.Controls.Add(this.gbInfoAssistants);
            this.Controls.Add(this.gbInfoClient);
            this.Controls.Add(this.cboAssistants);
            this.Controls.Add(this.gbInfoUtilisateur);
            this.Controls.Add(this.cboClients);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.lblChoix);
            this.Controls.Add(this.cboUtilisateurs);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdmin";
            this.Text = "Administrateur";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_UtilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_ChambreBindingSource)).EndInit();
            this.gbInfoUtilisateur.ResumeLayout(false);
            this.gbInfoUtilisateur.PerformLayout();
            this.gbInfoClient.ResumeLayout(false);
            this.gbInfoClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p01_AssistantBindingSource)).EndInit();
            this.gbInfoAssistants.ResumeLayout(false);
            this.gbInfoAssistants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p01_SoinBindingSource)).EndInit();
            this.gbInfoSoins.ResumeLayout(false);
            this.gbInfoSoins.PerformLayout();
            this.gbInfoChambre.ResumeLayout(false);
            this.gbInfoChambre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnDeconnexion;
        private BDB56AnkitDataSet bDB56AnkitDataSet;
        private System.Windows.Forms.BindingSource p01_UtilisateurBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_UtilisateurTableAdapter p01_UtilisateurTableAdapter;
        private BDB56AnkitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsEtLeursInvitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assistantsEtLesSoinsOffertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chambresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportsToolStripMenuItem;
        private System.Windows.Forms.BindingSource p01_ClientBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_ClientTableAdapter p01_ClientTableAdapter;
        private System.Windows.Forms.BindingSource p01_ChambreBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_ChambreTableAdapter p01_ChambreTableAdapter;
        private System.Windows.Forms.ComboBox cboUtilisateurs;
        private System.Windows.Forms.Label lblChoix;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ComboBox cboClients;
        private System.Windows.Forms.TextBox noUtilisateurTextBox;
        private System.Windows.Forms.TextBox nomUtilisateurTextBox;
        private System.Windows.Forms.TextBox motDePasseTextBox;
        private System.Windows.Forms.TextBox noTypeTextBox;
        private System.Windows.Forms.GroupBox gbInfoUtilisateur;
        private System.Windows.Forms.GroupBox gbInfoClient;
        private System.Windows.Forms.TextBox villeTextBox;
        private System.Windows.Forms.DateTimePicker dateInscriptionDateTimePicker;
        private System.Windows.Forms.TextBox noClientTextBox;
        private System.Windows.Forms.TextBox codePostalTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox adresseTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox paysTextBox;
        private System.Windows.Forms.BindingSource p01_AssistantBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_AssistantTableAdapter p01_AssistantTableAdapter;
        private System.Windows.Forms.ComboBox cboAssistants;
        private System.Windows.Forms.GroupBox gbInfoAssistants;
        private System.Windows.Forms.TextBox noAssistantTextBox;
        private System.Windows.Forms.TextBox remarquesTextBox;
        private System.Windows.Forms.TextBox prenomTextBox1;
        private System.Windows.Forms.TextBox specialitesTextBox;
        private System.Windows.Forms.TextBox nomTextBox1;
        private System.Windows.Forms.BindingSource p01_SoinBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_SoinTableAdapter p01_SoinTableAdapter;
        private System.Windows.Forms.ComboBox cboSoins;
        private System.Windows.Forms.GroupBox gbInfoSoins;
        private System.Windows.Forms.TextBox noSoinTextBox;
        private System.Windows.Forms.TextBox prixTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox noTypeSoinTextBox;
        private System.Windows.Forms.TextBox dureeTextBox;
        private System.Windows.Forms.ComboBox cboChambres;
        private System.Windows.Forms.GroupBox gbInfoChambre;
        private System.Windows.Forms.TextBox noChambreTextBox;
        private System.Windows.Forms.TextBox emplacementTextBox;
        private System.Windows.Forms.TextBox decorationsTextBox;
        private System.Windows.Forms.TextBox noTypeChambreTextBox;
    }
}