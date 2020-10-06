namespace Projet01
{
    partial class frmUtilisateur
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
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.noUtilisateurTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomUtilisateurTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MotDePasseTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bDB56AnkitDataSet = new Projet01.BDB56AnkitDataSet();
            this.p01_TypeUtilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager();
            this.lblTitre = new System.Windows.Forms.Label();
            this.p01_TypeUtilisateurBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.p01_TypeUtilisateurTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_TypeUtilisateurTableAdapter();
            this.typeUtilisateurComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_TypeUtilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_TypeUtilisateurBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(20, 251);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(119, 69);
            this.btnConfirmer.TabIndex = 0;
            this.btnConfirmer.Text = "button1";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(147, 251);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(133, 69);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "No utilisateur:";
            // 
            // noUtilisateurTextBox
            // 
            this.noUtilisateurTextBox.Location = new System.Drawing.Point(153, 80);
            this.noUtilisateurTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.noUtilisateurTextBox.Name = "noUtilisateurTextBox";
            this.noUtilisateurTextBox.Size = new System.Drawing.Size(132, 22);
            this.noUtilisateurTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom utilisateur:";
            // 
            // nomUtilisateurTextBox
            // 
            this.nomUtilisateurTextBox.Location = new System.Drawing.Point(153, 112);
            this.nomUtilisateurTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomUtilisateurTextBox.Name = "nomUtilisateurTextBox";
            this.nomUtilisateurTextBox.Size = new System.Drawing.Size(132, 22);
            this.nomUtilisateurTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mot de passe:";
            // 
            // MotDePasseTextBox
            // 
            this.MotDePasseTextBox.Location = new System.Drawing.Point(153, 144);
            this.MotDePasseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MotDePasseTextBox.Name = "MotDePasseTextBox";
            this.MotDePasseTextBox.Size = new System.Drawing.Size(132, 22);
            this.MotDePasseTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Type d\'utilisateur:";
            // 
            // bDB56AnkitDataSet
            // 
            this.bDB56AnkitDataSet.DataSetName = "BDB56AnkitDataSet";
            this.bDB56AnkitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p01_TypeUtilisateurBindingSource
            // 
            this.p01_TypeUtilisateurBindingSource.DataMember = "P01_TypeUtilisateur";
            this.p01_TypeUtilisateurBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.P01_AssistantSoinTableAdapter = null;
            this.tableAdapterManager.P01_AssistantTableAdapter = null;
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
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(20, 16);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(58, 25);
            this.lblTitre.TabIndex = 12;
            this.lblTitre.Text = "label";
            // 
            // p01_TypeUtilisateurBindingSource1
            // 
            this.p01_TypeUtilisateurBindingSource1.DataMember = "P01_TypeUtilisateur";
            this.p01_TypeUtilisateurBindingSource1.DataSource = this.bDB56AnkitDataSet;
            // 
            // p01_TypeUtilisateurTableAdapter
            // 
            this.p01_TypeUtilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // typeUtilisateurComboBox
            // 
            this.typeUtilisateurComboBox.DataSource = this.p01_TypeUtilisateurBindingSource;
            this.typeUtilisateurComboBox.DisplayMember = "Identification";
            this.typeUtilisateurComboBox.FormattingEnabled = true;
            this.typeUtilisateurComboBox.Location = new System.Drawing.Point(153, 185);
            this.typeUtilisateurComboBox.Name = "typeUtilisateurComboBox";
            this.typeUtilisateurComboBox.Size = new System.Drawing.Size(132, 24);
            this.typeUtilisateurComboBox.TabIndex = 12;
            this.typeUtilisateurComboBox.ValueMember = "NoType";
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 438);
            this.Controls.Add(this.typeUtilisateurComboBox);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MotDePasseTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomUtilisateurTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noUtilisateurTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUtilisateur";
            this.Text = "frmUtilisateur";
            this.Load += new System.EventHandler(this.frmUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_TypeUtilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_TypeUtilisateurBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox noUtilisateurTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomUtilisateurTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MotDePasseTextBox;
        private System.Windows.Forms.Label label4;
        private BDB56AnkitDataSet bDB56AnkitDataSet;
        private System.Windows.Forms.BindingSource p01_TypeUtilisateurBindingSource;
        private BDB56AnkitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.BindingSource p01_TypeUtilisateurBindingSource1;
        private BDB56AnkitDataSetTableAdapters.P01_TypeUtilisateurTableAdapter p01_TypeUtilisateurTableAdapter;
        private System.Windows.Forms.ComboBox typeUtilisateurComboBox;
    }
}