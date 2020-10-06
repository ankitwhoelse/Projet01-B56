namespace Projet01
{
    partial class frmAssistant
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
            System.Windows.Forms.Label noAssistantLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label specialitesLabel;
            System.Windows.Forms.Label remarquesLabel;
            this.bDB56AnkitDataSet = new Projet01.BDB56AnkitDataSet();
            this.p01_AssistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p01_AssistantTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_AssistantTableAdapter();
            this.tableAdapterManager = new Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager();
            this.noAssistantTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.specialitesTextBox = new System.Windows.Forms.TextBox();
            this.remarquesTextBox = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            noAssistantLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            specialitesLabel = new System.Windows.Forms.Label();
            remarquesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_AssistantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noAssistantLabel
            // 
            noAssistantLabel.AutoSize = true;
            noAssistantLabel.Location = new System.Drawing.Point(17, 84);
            noAssistantLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            noAssistantLabel.Name = "noAssistantLabel";
            noAssistantLabel.Size = new System.Drawing.Size(91, 17);
            noAssistantLabel.TabIndex = 0;
            noAssistantLabel.Text = "No Assistant:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(17, 116);
            prenomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(61, 17);
            prenomLabel.TabIndex = 2;
            prenomLabel.Text = "Prenom:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(17, 148);
            nomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(41, 17);
            nomLabel.TabIndex = 4;
            nomLabel.Text = "Nom:";
            // 
            // specialitesLabel
            // 
            specialitesLabel.AutoSize = true;
            specialitesLabel.Location = new System.Drawing.Point(17, 180);
            specialitesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            specialitesLabel.Name = "specialitesLabel";
            specialitesLabel.Size = new System.Drawing.Size(80, 17);
            specialitesLabel.TabIndex = 6;
            specialitesLabel.Text = "Specialites:";
            // 
            // remarquesLabel
            // 
            remarquesLabel.AutoSize = true;
            remarquesLabel.Location = new System.Drawing.Point(17, 212);
            remarquesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            remarquesLabel.Name = "remarquesLabel";
            remarquesLabel.Size = new System.Drawing.Size(85, 17);
            remarquesLabel.TabIndex = 8;
            remarquesLabel.Text = "Remarques:";
            // 
            // bDB56AnkitDataSet
            // 
            this.bDB56AnkitDataSet.DataSetName = "BDB56AnkitDataSet";
            this.bDB56AnkitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.P01_AssistantSoinTableAdapter = null;
            this.tableAdapterManager.P01_AssistantTableAdapter = this.p01_AssistantTableAdapter;
            this.tableAdapterManager.P01_ChambreTableAdapter = null;
            this.tableAdapterManager.P01_ClientTableAdapter = null;
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
            // noAssistantTextBox
            // 
            this.noAssistantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_AssistantBindingSource, "NoAssistant", true));
            this.noAssistantTextBox.Location = new System.Drawing.Point(148, 80);
            this.noAssistantTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noAssistantTextBox.Name = "noAssistantTextBox";
            this.noAssistantTextBox.ReadOnly = true;
            this.noAssistantTextBox.Size = new System.Drawing.Size(132, 22);
            this.noAssistantTextBox.TabIndex = 1;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_AssistantBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(148, 112);
            this.prenomTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(132, 22);
            this.prenomTextBox.TabIndex = 3;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_AssistantBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(148, 144);
            this.nomTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(132, 22);
            this.nomTextBox.TabIndex = 5;
            // 
            // specialitesTextBox
            // 
            this.specialitesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_AssistantBindingSource, "Specialites", true));
            this.specialitesTextBox.Location = new System.Drawing.Point(148, 176);
            this.specialitesTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.specialitesTextBox.Name = "specialitesTextBox";
            this.specialitesTextBox.Size = new System.Drawing.Size(132, 22);
            this.specialitesTextBox.TabIndex = 7;
            // 
            // remarquesTextBox
            // 
            this.remarquesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_AssistantBindingSource, "Remarques", true));
            this.remarquesTextBox.Location = new System.Drawing.Point(148, 208);
            this.remarquesTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.remarquesTextBox.Name = "remarquesTextBox";
            this.remarquesTextBox.Size = new System.Drawing.Size(132, 22);
            this.remarquesTextBox.TabIndex = 9;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(16, 11);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(58, 25);
            this.lblTitre.TabIndex = 13;
            this.lblTitre.Text = "label";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(148, 263);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(133, 69);
            this.btnAnnuler.TabIndex = 15;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(21, 263);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(119, 69);
            this.btnConfirmer.TabIndex = 14;
            this.btnConfirmer.Text = "button1";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // frmAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 347);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(noAssistantLabel);
            this.Controls.Add(this.noAssistantTextBox);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(specialitesLabel);
            this.Controls.Add(this.specialitesTextBox);
            this.Controls.Add(remarquesLabel);
            this.Controls.Add(this.remarquesTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAssistant";
            this.Text = "frmAssistant";
            this.Load += new System.EventHandler(this.frmAssistant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_AssistantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56AnkitDataSet bDB56AnkitDataSet;
        private System.Windows.Forms.BindingSource p01_AssistantBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_AssistantTableAdapter p01_AssistantTableAdapter;
        private BDB56AnkitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox noAssistantTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox specialitesTextBox;
        private System.Windows.Forms.TextBox remarquesTextBox;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
    }
}