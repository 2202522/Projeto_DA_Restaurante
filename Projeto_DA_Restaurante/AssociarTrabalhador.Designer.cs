namespace Projeto_DA_Restaurante
{
    partial class AssociarTrabalhador
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
            System.Windows.Forms.Label salarioLabel;
            System.Windows.Forms.Label posicaoLabel;
            System.Windows.Forms.Label restauranteIdLabel;
            System.Windows.Forms.Label idLabel;
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.restGestDBDataSet = new Projeto_DA_Restaurante.RestGestDBDataSet();
            this.pessoaSet_TrabalhadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSet_TrabalhadorTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.PessoaSet_TrabalhadorTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.TableAdapterManager();
            this.salarioTextBox = new System.Windows.Forms.TextBox();
            this.posicaoTextBox = new System.Windows.Forms.TextBox();
            this.restauranteIdComboBox = new System.Windows.Forms.ComboBox();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.pedidoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.PedidoSetTableAdapter();
            this.pessoaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.PessoaSetTableAdapter();
            this.restauranteSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.RestauranteSetTableAdapter();
            salarioLabel = new System.Windows.Forms.Label();
            posicaoLabel = new System.Windows.Forms.Label();
            restauranteIdLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_TrabalhadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 140);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConcluir
            // 
            this.btnConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Location = new System.Drawing.Point(228, 140);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(90, 40);
            this.btnConcluir.TabIndex = 10;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // restGestDBDataSet
            // 
            this.restGestDBDataSet.DataSetName = "RestGestDBDataSet";
            this.restGestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaSet_TrabalhadorBindingSource
            // 
            this.pessoaSet_TrabalhadorBindingSource.DataMember = "PessoaSet_Trabalhador";
            this.pessoaSet_TrabalhadorBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // pessoaSet_TrabalhadorTableAdapter
            // 
            this.pessoaSet_TrabalhadorTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PedidoSetTableAdapter = this.pedidoSetTableAdapter;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_TrabalhadorTableAdapter = this.pessoaSet_TrabalhadorTableAdapter;
            this.tableAdapterManager.PessoaSetTableAdapter = this.pessoaSetTableAdapter;
            this.tableAdapterManager.PromocaosTableAdapter = null;
            this.tableAdapterManager.RestauranteItemMenuTableAdapter = null;
            this.tableAdapterManager.RestauranteSetTableAdapter = this.restauranteSetTableAdapter;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // salarioLabel
            // 
            salarioLabel.AutoSize = true;
            salarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            salarioLabel.Location = new System.Drawing.Point(60, 81);
            salarioLabel.Name = "salarioLabel";
            salarioLabel.Size = new System.Drawing.Size(53, 16);
            salarioLabel.TabIndex = 11;
            salarioLabel.Text = "Salario:";
            // 
            // salarioTextBox
            // 
            this.salarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_TrabalhadorBindingSource, "Salario", true));
            this.salarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarioTextBox.Location = new System.Drawing.Point(146, 78);
            this.salarioTextBox.Name = "salarioTextBox";
            this.salarioTextBox.Size = new System.Drawing.Size(121, 22);
            this.salarioTextBox.TabIndex = 12;
            // 
            // posicaoLabel
            // 
            posicaoLabel.AutoSize = true;
            posicaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            posicaoLabel.Location = new System.Drawing.Point(60, 107);
            posicaoLabel.Name = "posicaoLabel";
            posicaoLabel.Size = new System.Drawing.Size(60, 16);
            posicaoLabel.TabIndex = 13;
            posicaoLabel.Text = "Posicao:";
            // 
            // posicaoTextBox
            // 
            this.posicaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_TrabalhadorBindingSource, "Posicao", true));
            this.posicaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posicaoTextBox.Location = new System.Drawing.Point(146, 104);
            this.posicaoTextBox.Name = "posicaoTextBox";
            this.posicaoTextBox.Size = new System.Drawing.Size(121, 22);
            this.posicaoTextBox.TabIndex = 14;
            // 
            // restauranteIdLabel
            // 
            restauranteIdLabel.AutoSize = true;
            restauranteIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            restauranteIdLabel.Location = new System.Drawing.Point(60, 53);
            restauranteIdLabel.Name = "restauranteIdLabel";
            restauranteIdLabel.Size = new System.Drawing.Size(83, 16);
            restauranteIdLabel.TabIndex = 15;
            restauranteIdLabel.Text = "Restaurante:";
            // 
            // restauranteIdComboBox
            // 
            this.restauranteIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_TrabalhadorBindingSource, "RestauranteId", true));
            this.restauranteIdComboBox.DataSource = this.restauranteSetBindingSource;
            this.restauranteIdComboBox.DisplayMember = "Nome";
            this.restauranteIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restauranteIdComboBox.FormattingEnabled = true;
            this.restauranteIdComboBox.Location = new System.Drawing.Point(146, 50);
            this.restauranteIdComboBox.Name = "restauranteIdComboBox";
            this.restauranteIdComboBox.Size = new System.Drawing.Size(121, 24);
            this.restauranteIdComboBox.TabIndex = 16;
            this.restauranteIdComboBox.ValueMember = "Id";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(60, 24);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(66, 16);
            idLabel.TabIndex = 17;
            idLabel.Text = "Utilizador:";
            // 
            // idComboBox
            // 
            this.idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_TrabalhadorBindingSource, "Id", true));
            this.idComboBox.DataSource = this.pessoaSetBindingSource;
            this.idComboBox.DisplayMember = "Nome";
            this.idComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(146, 21);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(121, 24);
            this.idComboBox.TabIndex = 18;
            this.idComboBox.ValueMember = "Id";
            // 
            // pedidoSetBindingSource
            // 
            this.pedidoSetBindingSource.DataMember = "PedidoSet";
            this.pedidoSetBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // pedidoSetTableAdapter
            // 
            this.pedidoSetTableAdapter.ClearBeforeFill = true;
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
            // restauranteSetBindingSource
            // 
            this.restauranteSetBindingSource.DataMember = "RestauranteSet";
            this.restauranteSetBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // restauranteSetTableAdapter
            // 
            this.restauranteSetTableAdapter.ClearBeforeFill = true;
            // 
            // AssociarTrabalhador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 200);
            this.Controls.Add(salarioLabel);
            this.Controls.Add(this.salarioTextBox);
            this.Controls.Add(posicaoLabel);
            this.Controls.Add(this.posicaoTextBox);
            this.Controls.Add(restauranteIdLabel);
            this.Controls.Add(this.restauranteIdComboBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnBack);
            this.Name = "AssociarTrabalhador";
            this.Text = "Associar Trabalhador";
            this.Load += new System.EventHandler(this.AssociarTrabalhador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_TrabalhadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConcluir;
        private RestGestDBDataSet restGestDBDataSet;
        private System.Windows.Forms.BindingSource pessoaSet_TrabalhadorBindingSource;
        private RestGestDBDataSetTableAdapters.PessoaSet_TrabalhadorTableAdapter pessoaSet_TrabalhadorTableAdapter;
        private RestGestDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private RestGestDBDataSetTableAdapters.PedidoSetTableAdapter pedidoSetTableAdapter;
        private System.Windows.Forms.TextBox salarioTextBox;
        private System.Windows.Forms.TextBox posicaoTextBox;
        private System.Windows.Forms.ComboBox restauranteIdComboBox;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.BindingSource pedidoSetBindingSource;
        private RestGestDBDataSetTableAdapters.PessoaSetTableAdapter pessoaSetTableAdapter;
        private System.Windows.Forms.BindingSource pessoaSetBindingSource;
        private RestGestDBDataSetTableAdapters.RestauranteSetTableAdapter restauranteSetTableAdapter;
        private System.Windows.Forms.BindingSource restauranteSetBindingSource;
    }
}