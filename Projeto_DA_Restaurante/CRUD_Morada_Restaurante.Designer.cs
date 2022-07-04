namespace Projeto_DA_Restaurante
{
    partial class CRUD_Morada_Restaurante
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
            System.Windows.Forms.Label restaurante_IdLabel;
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.codPostalTextBox = new System.Windows.Forms.TextBox();
            this.paisTextBox = new System.Windows.Forms.TextBox();
            this.ruaTextBox = new System.Windows.Forms.TextBox();
            this.btnCocluir = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.restGestDBDataSet = new Projeto_DA_Restaurante.RestGestDBDataSet();
            this.moradaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.TableAdapterManager();
            this.restaurante_IdComboBox = new System.Windows.Forms.ComboBox();
            this.restauranteSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.RestauranteSetTableAdapter();
            cidadeLabel = new System.Windows.Forms.Label();
            codPostalLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            ruaLabel = new System.Windows.Forms.Label();
            restaurante_IdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cidadeLabel.Location = new System.Drawing.Point(28, 50);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(54, 16);
            cidadeLabel.TabIndex = 3;
            cidadeLabel.Text = "Cidade:";
            // 
            // codPostalLabel
            // 
            codPostalLabel.AutoSize = true;
            codPostalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codPostalLabel.Location = new System.Drawing.Point(28, 76);
            codPostalLabel.Name = "codPostalLabel";
            codPostalLabel.Size = new System.Drawing.Size(76, 16);
            codPostalLabel.TabIndex = 5;
            codPostalLabel.Text = "Cod Postal:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paisLabel.Location = new System.Drawing.Point(240, 50);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(37, 16);
            paisLabel.TabIndex = 7;
            paisLabel.Text = "Pais:";
            // 
            // ruaLabel
            // 
            ruaLabel.AutoSize = true;
            ruaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ruaLabel.Location = new System.Drawing.Point(240, 76);
            ruaLabel.Name = "ruaLabel";
            ruaLabel.Size = new System.Drawing.Size(35, 16);
            ruaLabel.TabIndex = 9;
            ruaLabel.Text = "Rua:";
            // 
            // restaurante_IdLabel
            // 
            restaurante_IdLabel.AutoSize = true;
            restaurante_IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            restaurante_IdLabel.Location = new System.Drawing.Point(28, 107);
            restaurante_IdLabel.Name = "restaurante_IdLabel";
            restaurante_IdLabel.Size = new System.Drawing.Size(83, 16);
            restaurante_IdLabel.TabIndex = 20;
            restaurante_IdLabel.Text = "Restaurante:";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Location = new System.Drawing.Point(114, 46);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.cidadeTextBox.TabIndex = 4;
            // 
            // codPostalTextBox
            // 
            this.codPostalTextBox.Location = new System.Drawing.Point(114, 75);
            this.codPostalTextBox.Name = "codPostalTextBox";
            this.codPostalTextBox.Size = new System.Drawing.Size(100, 20);
            this.codPostalTextBox.TabIndex = 6;
            // 
            // paisTextBox
            // 
            this.paisTextBox.Location = new System.Drawing.Point(317, 49);
            this.paisTextBox.Name = "paisTextBox";
            this.paisTextBox.Size = new System.Drawing.Size(100, 20);
            this.paisTextBox.TabIndex = 8;
            // 
            // ruaTextBox
            // 
            this.ruaTextBox.Location = new System.Drawing.Point(317, 75);
            this.ruaTextBox.Name = "ruaTextBox";
            this.ruaTextBox.Size = new System.Drawing.Size(100, 20);
            this.ruaTextBox.TabIndex = 10;
            // 
            // btnCocluir
            // 
            this.btnCocluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCocluir.Location = new System.Drawing.Point(328, 163);
            this.btnCocluir.Name = "btnCocluir";
            this.btnCocluir.Size = new System.Drawing.Size(90, 40);
            this.btnCocluir.TabIndex = 19;
            this.btnCocluir.Text = "Concluir";
            this.btnCocluir.UseVisualStyleBackColor = true;
            this.btnCocluir.Click += new System.EventHandler(this.btnCocluir_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 163);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // restGestDBDataSet
            // 
            this.restGestDBDataSet.DataSetName = "RestGestDBDataSet";
            this.restGestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moradaSetBindingSource
            // 
            this.moradaSetBindingSource.DataMember = "MoradaSet";
            this.moradaSetBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaSetTableAdapter = null;
            this.tableAdapterManager.EstadoSetTableAdapter = null;
            this.tableAdapterManager.ItemMenuSetTableAdapter = null;
            this.tableAdapterManager.MetodoPagamentoSetTableAdapter = null;
            this.tableAdapterManager.PagamentoSetTableAdapter = null;
            this.tableAdapterManager.PedidoItemMenuTableAdapter = null;
            this.tableAdapterManager.PedidoSetTableAdapter = null;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_TrabalhadorTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.PromocaosTableAdapter = null;
            this.tableAdapterManager.RestauranteItemMenuTableAdapter = null;
            this.tableAdapterManager.RestauranteSetTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // restaurante_IdComboBox
            // 
            this.restaurante_IdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moradaSetBindingSource, "Restaurante_Id", true));
            this.restaurante_IdComboBox.DataSource = this.restauranteSetBindingSource;
            this.restaurante_IdComboBox.DisplayMember = "Nome";
            this.restaurante_IdComboBox.FormattingEnabled = true;
            this.restaurante_IdComboBox.Location = new System.Drawing.Point(114, 104);
            this.restaurante_IdComboBox.Name = "restaurante_IdComboBox";
            this.restaurante_IdComboBox.Size = new System.Drawing.Size(100, 21);
            this.restaurante_IdComboBox.TabIndex = 21;
            this.restaurante_IdComboBox.ValueMember = "Id";
            // 
            // restauranteSetBindingSource
            // 
            this.restauranteSetBindingSource.DataMember = "RestauranteSet";
            this.restauranteSetBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // restauranteSetTableAdapter
            // 
            this.restauranteSetTableAdapter.ClearBeforeFill = true;
            // 
            // CRUD_Morada_Restaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 223);
            this.Controls.Add(restaurante_IdLabel);
            this.Controls.Add(this.restaurante_IdComboBox);
            this.Controls.Add(this.btnCocluir);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(codPostalLabel);
            this.Controls.Add(this.codPostalTextBox);
            this.Controls.Add(paisLabel);
            this.Controls.Add(this.paisTextBox);
            this.Controls.Add(ruaLabel);
            this.Controls.Add(this.ruaTextBox);
            this.Name = "CRUD_Morada_Restaurante";
            this.Text = "CRUD_Morada_Restaurante";
            this.Load += new System.EventHandler(this.CRUD_Morada_Restaurante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox codPostalTextBox;
        private System.Windows.Forms.TextBox paisTextBox;
        private System.Windows.Forms.TextBox ruaTextBox;
        private System.Windows.Forms.Button btnCocluir;
        private System.Windows.Forms.Button btnBack;
        private RestGestDBDataSet restGestDBDataSet;
        private System.Windows.Forms.BindingSource moradaSetBindingSource;
        private RestGestDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox restaurante_IdComboBox;
        private System.Windows.Forms.BindingSource restauranteSetBindingSource;
        private RestGestDBDataSetTableAdapters.RestauranteSetTableAdapter restauranteSetTableAdapter;
    }
}