namespace Projeto_DA_Restaurante
{
    partial class CRUD_Pedido
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
            System.Windows.Forms.Label valorTotalLabel;
            System.Windows.Forms.Label restauranteIdLabel;
            System.Windows.Forms.Label clienteIdLabel;
            System.Windows.Forms.Label trabalhadorIdLabel;
            System.Windows.Forms.Label estadoIdLabel;
            this.restauranteDataSet3 = new Projeto_DA_Restaurante.RestauranteDataSet3();
            this.valorTotalTextBox = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.restauranteIdComboBox = new System.Windows.Forms.ComboBox();
            this.clienteIdcomboBox = new System.Windows.Forms.ComboBox();
            this.trabalhadorIdcomboBox = new System.Windows.Forms.ComboBox();
            this.estadoIdcomboBox = new System.Windows.Forms.ComboBox();
            this.restGestDBDataSet = new Projeto_DA_Restaurante.RestGestDBDataSet();
            this.restauranteSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.RestauranteSetTableAdapter();
            this.pessoaSetClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSet_ClienteTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.PessoaSet_ClienteTableAdapter();
            this.pessoaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.PessoaSetTableAdapter();
            this.fKClienteinheritsPessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.estadoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.EstadoSetTableAdapter();
            valorTotalLabel = new System.Windows.Forms.Label();
            restauranteIdLabel = new System.Windows.Forms.Label();
            clienteIdLabel = new System.Windows.Forms.Label();
            trabalhadorIdLabel = new System.Windows.Forms.Label();
            estadoIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClienteinheritsPessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // valorTotalLabel
            // 
            valorTotalLabel.AutoSize = true;
            valorTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorTotalLabel.Location = new System.Drawing.Point(26, 53);
            valorTotalLabel.Name = "valorTotalLabel";
            valorTotalLabel.Size = new System.Drawing.Size(76, 16);
            valorTotalLabel.TabIndex = 3;
            valorTotalLabel.Text = "Valor Total:";
            // 
            // restauranteIdLabel
            // 
            restauranteIdLabel.AutoSize = true;
            restauranteIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            restauranteIdLabel.Location = new System.Drawing.Point(26, 79);
            restauranteIdLabel.Name = "restauranteIdLabel";
            restauranteIdLabel.Size = new System.Drawing.Size(83, 16);
            restauranteIdLabel.TabIndex = 5;
            restauranteIdLabel.Text = "Restaurante:";
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clienteIdLabel.Location = new System.Drawing.Point(26, 105);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(51, 16);
            clienteIdLabel.TabIndex = 7;
            clienteIdLabel.Text = "Cliente:";
            // 
            // trabalhadorIdLabel
            // 
            trabalhadorIdLabel.AutoSize = true;
            trabalhadorIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trabalhadorIdLabel.Location = new System.Drawing.Point(232, 53);
            trabalhadorIdLabel.Name = "trabalhadorIdLabel";
            trabalhadorIdLabel.Size = new System.Drawing.Size(85, 16);
            trabalhadorIdLabel.TabIndex = 9;
            trabalhadorIdLabel.Text = "Trabalhador:";
            // 
            // estadoIdLabel
            // 
            estadoIdLabel.AutoSize = true;
            estadoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoIdLabel.Location = new System.Drawing.Point(232, 79);
            estadoIdLabel.Name = "estadoIdLabel";
            estadoIdLabel.Size = new System.Drawing.Size(53, 16);
            estadoIdLabel.TabIndex = 11;
            estadoIdLabel.Text = "Estado:";
            // 
            // restauranteDataSet3
            // 
            this.restauranteDataSet3.DataSetName = "RestauranteDataSet3";
            this.restauranteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // valorTotalTextBox
            // 
            this.valorTotalTextBox.Location = new System.Drawing.Point(108, 52);
            this.valorTotalTextBox.Name = "valorTotalTextBox";
            this.valorTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTotalTextBox.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 147);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConcluir
            // 
            this.btnConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Location = new System.Drawing.Point(348, 147);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(90, 40);
            this.btnConcluir.TabIndex = 14;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // restauranteIdComboBox
            // 
            this.restauranteIdComboBox.DataSource = this.restauranteSetBindingSource;
            this.restauranteIdComboBox.DisplayMember = "Nome";
            this.restauranteIdComboBox.FormattingEnabled = true;
            this.restauranteIdComboBox.Location = new System.Drawing.Point(108, 78);
            this.restauranteIdComboBox.Name = "restauranteIdComboBox";
            this.restauranteIdComboBox.Size = new System.Drawing.Size(100, 21);
            this.restauranteIdComboBox.TabIndex = 15;
            this.restauranteIdComboBox.ValueMember = "Id";
            // 
            // clienteIdcomboBox
            // 
            this.clienteIdcomboBox.DataSource = this.pessoaSetBindingSource1;
            this.clienteIdcomboBox.DisplayMember = "Nome";
            this.clienteIdcomboBox.FormattingEnabled = true;
            this.clienteIdcomboBox.Location = new System.Drawing.Point(108, 104);
            this.clienteIdcomboBox.Name = "clienteIdcomboBox";
            this.clienteIdcomboBox.Size = new System.Drawing.Size(100, 21);
            this.clienteIdcomboBox.TabIndex = 16;
            this.clienteIdcomboBox.ValueMember = "Id";
            // 
            // trabalhadorIdcomboBox
            // 
            this.trabalhadorIdcomboBox.DataSource = this.pessoaSetBindingSource2;
            this.trabalhadorIdcomboBox.DisplayMember = "Nome";
            this.trabalhadorIdcomboBox.FormattingEnabled = true;
            this.trabalhadorIdcomboBox.Location = new System.Drawing.Point(323, 52);
            this.trabalhadorIdcomboBox.Name = "trabalhadorIdcomboBox";
            this.trabalhadorIdcomboBox.Size = new System.Drawing.Size(100, 21);
            this.trabalhadorIdcomboBox.TabIndex = 17;
            this.trabalhadorIdcomboBox.ValueMember = "Id";
            // 
            // estadoIdcomboBox
            // 
            this.estadoIdcomboBox.DataSource = this.estadoSetBindingSource;
            this.estadoIdcomboBox.DisplayMember = "estado";
            this.estadoIdcomboBox.FormattingEnabled = true;
            this.estadoIdcomboBox.Location = new System.Drawing.Point(323, 78);
            this.estadoIdcomboBox.Name = "estadoIdcomboBox";
            this.estadoIdcomboBox.Size = new System.Drawing.Size(100, 21);
            this.estadoIdcomboBox.TabIndex = 18;
            this.estadoIdcomboBox.ValueMember = "Id";
            // 
            // restGestDBDataSet
            // 
            this.restGestDBDataSet.DataSetName = "RestGestDBDataSet";
            this.restGestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // pessoaSetClienteBindingSource
            // 
            this.pessoaSetClienteBindingSource.DataMember = "PessoaSet_Cliente";
            this.pessoaSetClienteBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // pessoaSet_ClienteTableAdapter
            // 
            this.pessoaSet_ClienteTableAdapter.ClearBeforeFill = true;
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
            // fKClienteinheritsPessoaBindingSource
            // 
            this.fKClienteinheritsPessoaBindingSource.DataMember = "FK_Cliente_inherits_Pessoa";
            this.fKClienteinheritsPessoaBindingSource.DataSource = this.pessoaSetBindingSource;
            // 
            // pessoaSetBindingSource1
            // 
            this.pessoaSetBindingSource1.DataMember = "PessoaSet";
            this.pessoaSetBindingSource1.DataSource = this.restGestDBDataSet;
            // 
            // pessoaSetBindingSource2
            // 
            this.pessoaSetBindingSource2.DataMember = "PessoaSet";
            this.pessoaSetBindingSource2.DataSource = this.restGestDBDataSet;
            // 
            // estadoSetBindingSource
            // 
            this.estadoSetBindingSource.DataMember = "EstadoSet";
            this.estadoSetBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // estadoSetTableAdapter
            // 
            this.estadoSetTableAdapter.ClearBeforeFill = true;
            // 
            // CRUD_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 207);
            this.Controls.Add(this.estadoIdcomboBox);
            this.Controls.Add(this.trabalhadorIdcomboBox);
            this.Controls.Add(this.clienteIdcomboBox);
            this.Controls.Add(this.restauranteIdComboBox);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(valorTotalLabel);
            this.Controls.Add(this.valorTotalTextBox);
            this.Controls.Add(restauranteIdLabel);
            this.Controls.Add(clienteIdLabel);
            this.Controls.Add(trabalhadorIdLabel);
            this.Controls.Add(estadoIdLabel);
            this.Name = "CRUD_Pedido";
            this.Text = "CRUD_Pedido";
            this.Load += new System.EventHandler(this.CRUD_Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClienteinheritsPessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestauranteDataSet3 restauranteDataSet3;
        private System.Windows.Forms.TextBox valorTotalTextBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.ComboBox restauranteIdComboBox;
        private System.Windows.Forms.ComboBox clienteIdcomboBox;
        private System.Windows.Forms.ComboBox trabalhadorIdcomboBox;
        private System.Windows.Forms.ComboBox estadoIdcomboBox;
        private RestGestDBDataSet restGestDBDataSet;
        private System.Windows.Forms.BindingSource restauranteSetBindingSource;
        private RestGestDBDataSetTableAdapters.RestauranteSetTableAdapter restauranteSetTableAdapter;
        private System.Windows.Forms.BindingSource pessoaSetClienteBindingSource;
        private RestGestDBDataSetTableAdapters.PessoaSet_ClienteTableAdapter pessoaSet_ClienteTableAdapter;
        private System.Windows.Forms.BindingSource pessoaSetBindingSource;
        private RestGestDBDataSetTableAdapters.PessoaSetTableAdapter pessoaSetTableAdapter;
        private System.Windows.Forms.BindingSource pessoaSetBindingSource1;
        private System.Windows.Forms.BindingSource pessoaSetBindingSource2;
        private System.Windows.Forms.BindingSource fKClienteinheritsPessoaBindingSource;
        private System.Windows.Forms.BindingSource estadoSetBindingSource;
        private RestGestDBDataSetTableAdapters.EstadoSetTableAdapter estadoSetTableAdapter;
    }
}