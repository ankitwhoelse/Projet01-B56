namespace Projet01
{
    partial class Planif
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bDB56AnkitDataSet = new Projet01.BDB56AnkitDataSet();
            this.p01_SoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p01_SoinTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_SoinTableAdapter();
            this.tableAdapterManager = new Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager();
            this.p01_AssistantTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_AssistantTableAdapter();
            this.p01_SoinComboBox = new System.Windows.Forms.ComboBox();
            this.p01_AssistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p01_AssistantComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.noEtNomComplet_ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noEtNomComplet_ClientTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.NoEtNomComplet_ClientTableAdapter();
            this.noEtNomComplet_ClientComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_SoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_AssistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomComplet_ClientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soins:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invité ou client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Assistant";
            // 
            // bDB56AnkitDataSet
            // 
            this.bDB56AnkitDataSet.DataSetName = "BDB56AnkitDataSet";
            this.bDB56AnkitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.P01_SoinTableAdapter = this.p01_SoinTableAdapter;
            this.tableAdapterManager.P01_TypeChambreTableAdapter = null;
            this.tableAdapterManager.P01_TypeSoinTableAdapter = null;
            this.tableAdapterManager.P01_TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.P01_UtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // p01_AssistantTableAdapter
            // 
            this.p01_AssistantTableAdapter.ClearBeforeFill = true;
            // 
            // p01_SoinComboBox
            // 
            this.p01_SoinComboBox.DataSource = this.p01_SoinBindingSource;
            this.p01_SoinComboBox.DisplayMember = "Description";
            this.p01_SoinComboBox.FormattingEnabled = true;
            this.p01_SoinComboBox.Location = new System.Drawing.Point(163, 60);
            this.p01_SoinComboBox.Name = "p01_SoinComboBox";
            this.p01_SoinComboBox.Size = new System.Drawing.Size(176, 24);
            this.p01_SoinComboBox.TabIndex = 4;
            this.p01_SoinComboBox.ValueMember = "NoSoin";
            // 
            // p01_AssistantBindingSource
            // 
            this.p01_AssistantBindingSource.DataMember = "P01_Assistant";
            this.p01_AssistantBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // p01_AssistantComboBox
            // 
            this.p01_AssistantComboBox.DataSource = this.p01_AssistantBindingSource;
            this.p01_AssistantComboBox.DisplayMember = "Prenom";
            this.p01_AssistantComboBox.FormattingEnabled = true;
            this.p01_AssistantComboBox.Location = new System.Drawing.Point(163, 212);
            this.p01_AssistantComboBox.Name = "p01_AssistantComboBox";
            this.p01_AssistantComboBox.Size = new System.Drawing.Size(176, 24);
            this.p01_AssistantComboBox.TabIndex = 4;
            this.p01_AssistantComboBox.ValueMember = "NoAssistant";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(290, 298);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(91, 59);
            this.btn_Annuler.TabIndex = 6;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // noEtNomComplet_ClientBindingSource
            // 
            this.noEtNomComplet_ClientBindingSource.DataMember = "NoEtNomComplet_Client";
            this.noEtNomComplet_ClientBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // noEtNomComplet_ClientTableAdapter
            // 
            this.noEtNomComplet_ClientTableAdapter.ClearBeforeFill = true;
            // 
            // noEtNomComplet_ClientComboBox
            // 
            this.noEtNomComplet_ClientComboBox.DataSource = this.noEtNomComplet_ClientBindingSource;
            this.noEtNomComplet_ClientComboBox.DisplayMember = "Nom";
            this.noEtNomComplet_ClientComboBox.FormattingEnabled = true;
            this.noEtNomComplet_ClientComboBox.Location = new System.Drawing.Point(163, 136);
            this.noEtNomComplet_ClientComboBox.Name = "noEtNomComplet_ClientComboBox";
            this.noEtNomComplet_ClientComboBox.Size = new System.Drawing.Size(176, 24);
            this.noEtNomComplet_ClientComboBox.TabIndex = 7;
            this.noEtNomComplet_ClientComboBox.ValueMember = "NoClient";
            // 
            // Planif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.noEtNomComplet_ClientComboBox);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.p01_AssistantComboBox);
            this.Controls.Add(this.p01_SoinComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Planif";
            this.Text = "Ajout d\'une planification de soin";
            this.Load += new System.EventHandler(this.Planif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_SoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_AssistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomComplet_ClientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private BDB56AnkitDataSet bDB56AnkitDataSet;
        private System.Windows.Forms.BindingSource p01_SoinBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_SoinTableAdapter p01_SoinTableAdapter;
        private BDB56AnkitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox p01_SoinComboBox;
        private BDB56AnkitDataSetTableAdapters.P01_AssistantTableAdapter p01_AssistantTableAdapter;
        private System.Windows.Forms.BindingSource p01_AssistantBindingSource;
        private System.Windows.Forms.ComboBox p01_AssistantComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.BindingSource noEtNomComplet_ClientBindingSource;
        private BDB56AnkitDataSetTableAdapters.NoEtNomComplet_ClientTableAdapter noEtNomComplet_ClientTableAdapter;
        private System.Windows.Forms.ComboBox noEtNomComplet_ClientComboBox;
    }
}