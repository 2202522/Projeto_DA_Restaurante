﻿namespace Projeto_DA_Restaurante
{
    partial class CRUD_Morada
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
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label codPostalLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label ruaLabel;
            System.Windows.Forms.Label label1;
            this.btnSeguinte = new System.Windows.Forms.Button();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.codPostalTextBox = new System.Windows.Forms.TextBox();
            this.paisTextBox = new System.Windows.Forms.TextBox();
            this.ruaTextBox = new System.Windows.Forms.TextBox();
            this.restGestDBDataSet = new Projeto_DA_Restaurante.RestGestDBDataSet();
            this.pessoaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.PessoaSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.TableAdapterManager();
            this.nomeComboBox = new System.Windows.Forms.ComboBox();
            cidadeLabel = new System.Windows.Forms.Label();
            codPostalLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            ruaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cidadeLabel.Location = new System.Drawing.Point(12, 47);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(54, 16);
            cidadeLabel.TabIndex = 24;
            cidadeLabel.Text = "Cidade:";
            // 
            // codPostalLabel
            // 
            codPostalLabel.AutoSize = true;
            codPostalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codPostalLabel.Location = new System.Drawing.Point(12, 73);
            codPostalLabel.Name = "codPostalLabel";
            codPostalLabel.Size = new System.Drawing.Size(76, 16);
            codPostalLabel.TabIndex = 26;
            codPostalLabel.Text = "Cod Postal:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paisLabel.Location = new System.Drawing.Point(195, 47);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(37, 16);
            paisLabel.TabIndex = 28;
            paisLabel.Text = "Pais:";
            // 
            // ruaLabel
            // 
            ruaLabel.AutoSize = true;
            ruaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ruaLabel.Location = new System.Drawing.Point(195, 73);
            ruaLabel.Name = "ruaLabel";
            ruaLabel.Size = new System.Drawing.Size(35, 16);
            ruaLabel.TabIndex = 30;
            ruaLabel.Text = "Rua:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(12, 99);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 16);
            label1.TabIndex = 32;
            label1.Text = "Pessoa:";
            // 
            // btnSeguinte
            // 
            this.btnSeguinte.Location = new System.Drawing.Point(295, 142);
            this.btnSeguinte.Name = "btnSeguinte";
            this.btnSeguinte.Size = new System.Drawing.Size(82, 38);
            this.btnSeguinte.TabIndex = 21;
            this.btnSeguinte.Text = "Seguinte";
            this.btnSeguinte.UseVisualStyleBackColor = true;
            this.btnSeguinte.Click += new System.EventHandler(this.btnSeguinte_Click);
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeTextBox.Location = new System.Drawing.Point(89, 44);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(100, 22);
            this.cidadeTextBox.TabIndex = 25;
            // 
            // codPostalTextBox
            // 
            this.codPostalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codPostalTextBox.Location = new System.Drawing.Point(89, 70);
            this.codPostalTextBox.Name = "codPostalTextBox";
            this.codPostalTextBox.Size = new System.Drawing.Size(100, 22);
            this.codPostalTextBox.TabIndex = 27;
            // 
            // paisTextBox
            // 
            this.paisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paisTextBox.Location = new System.Drawing.Point(262, 44);
            this.paisTextBox.Name = "paisTextBox";
            this.paisTextBox.Size = new System.Drawing.Size(100, 22);
            this.paisTextBox.TabIndex = 29;
            // 
            // ruaTextBox
            // 
            this.ruaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruaTextBox.Location = new System.Drawing.Point(262, 70);
            this.ruaTextBox.Name = "ruaTextBox";
            this.ruaTextBox.Size = new System.Drawing.Size(100, 22);
            this.ruaTextBox.TabIndex = 31;
            // 
            // restGestDBDataSet
            // 
            this.restGestDBDataSet.DataSetName = "RestGestDBDataSet";
            this.restGestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaSetBindingSource
            // 
            this.pessoaSetBindingSource.DataMember = "PessoaSet";
            this.pessoaSetBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // pessoaSetTableAdapter
            // 
            this.pessoaSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaSetTableAdapter = null;
            this.tableAdapterManager.EstadoSetTableAdapter = null;
            this.tableAdapterManager.ItemMenuSetTableAdapter = null;
            this.tableAdapterManager.MetodoPagamentoSetTableAdapter = null;
            this.tableAdapterManager.MoradaSetTableAdapter = null;
            this.tableAdapterManager.PagamentoSetTableAdapter = null;
            this.tableAdapterManager.PedidoItemMenuTableAdapter = null;
            this.tableAdapterManager.PedidoSetTableAdapter = null;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_TrabalhadorTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = this.pessoaSetTableAdapter;
            this.tableAdapterManager.PromocaosTableAdapter = null;
            this.tableAdapterManager.RestauranteItemMenuTableAdapter = null;
            this.tableAdapterManager.RestauranteSetTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nomeComboBox
            // 
            this.nomeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSetBindingSource, "Nome", true));
            this.nomeComboBox.DataSource = this.pessoaSetBindingSource;
            this.nomeComboBox.DisplayMember = "Nome";
            this.nomeComboBox.FormattingEnabled = true;
            this.nomeComboBox.Location = new System.Drawing.Point(89, 99);
            this.nomeComboBox.Name = "nomeComboBox";
            this.nomeComboBox.Size = new System.Drawing.Size(100, 21);
            this.nomeComboBox.TabIndex = 34;
            this.nomeComboBox.ValueMember = "Id";
            // 
            // CRUD_Morada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 200);
            this.Controls.Add(this.nomeComboBox);
            this.Controls.Add(label1);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(codPostalLabel);
            this.Controls.Add(this.codPostalTextBox);
            this.Controls.Add(paisLabel);
            this.Controls.Add(this.paisTextBox);
            this.Controls.Add(ruaLabel);
            this.Controls.Add(this.ruaTextBox);
            this.Controls.Add(this.btnSeguinte);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CRUD_Morada";
            this.Text = "Criar Morada";
            this.Load += new System.EventHandler(this.CRUD_Morada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSeguinte;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox codPostalTextBox;
        private System.Windows.Forms.TextBox paisTextBox;
        private System.Windows.Forms.TextBox ruaTextBox;
        private RestGestDBDataSet restGestDBDataSet;
        private System.Windows.Forms.BindingSource pessoaSetBindingSource;
        private RestGestDBDataSetTableAdapters.PessoaSetTableAdapter pessoaSetTableAdapter;
        private RestGestDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox nomeComboBox;
    }
}