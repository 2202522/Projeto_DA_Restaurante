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
            this.restGestDBDataSet = new Projeto_DA_Restaurante.RestGestDBDataSet();
            this.pessoaSet_TrabalhadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSet_TrabalhadorTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.PessoaSet_TrabalhadorTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.TableAdapterManager();
            this.pedidoSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.PedidoSetTableAdapter();
            this.pessoaSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.PessoaSetTableAdapter();
            this.restauranteSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.RestauranteSetTableAdapter();
            this.salarioTextBox = new System.Windows.Forms.TextBox();
            this.posicaoTextBox = new System.Windows.Forms.TextBox();
            this.restauranteIdComboBox = new System.Windows.Forms.ComboBox();
            this.restauranteSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.pessoaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.associarTrabalhadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarTrabalhadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            salarioLabel = new System.Windows.Forms.Label();
            posicaoLabel = new System.Windows.Forms.Label();
            restauranteIdLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_TrabalhadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salarioLabel
            // 
            salarioLabel.AutoSize = true;
            salarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            salarioLabel.Location = new System.Drawing.Point(77, 130);
            salarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            salarioLabel.Name = "salarioLabel";
            salarioLabel.Size = new System.Drawing.Size(66, 20);
            salarioLabel.TabIndex = 11;
            salarioLabel.Text = "Salario:";
            // 
            // posicaoLabel
            // 
            posicaoLabel.AutoSize = true;
            posicaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            posicaoLabel.Location = new System.Drawing.Point(77, 162);
            posicaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            posicaoLabel.Name = "posicaoLabel";
            posicaoLabel.Size = new System.Drawing.Size(74, 20);
            posicaoLabel.TabIndex = 13;
            posicaoLabel.Text = "Posicao:";
            // 
            // restauranteIdLabel
            // 
            restauranteIdLabel.AutoSize = true;
            restauranteIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            restauranteIdLabel.Location = new System.Drawing.Point(77, 95);
            restauranteIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            restauranteIdLabel.Name = "restauranteIdLabel";
            restauranteIdLabel.Size = new System.Drawing.Size(105, 20);
            restauranteIdLabel.TabIndex = 15;
            restauranteIdLabel.Text = "Restaurante:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(77, 60);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(85, 20);
            idLabel.TabIndex = 17;
            idLabel.Text = "Utilizador:";
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
            // pedidoSetTableAdapter
            // 
            this.pedidoSetTableAdapter.ClearBeforeFill = true;
            // 
            // pessoaSetTableAdapter
            // 
            this.pessoaSetTableAdapter.ClearBeforeFill = true;
            // 
            // restauranteSetTableAdapter
            // 
            this.restauranteSetTableAdapter.ClearBeforeFill = true;
            // 
            // salarioTextBox
            // 
            this.salarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_TrabalhadorBindingSource, "Salario", true));
            this.salarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarioTextBox.Location = new System.Drawing.Point(192, 126);
            this.salarioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.salarioTextBox.Name = "salarioTextBox";
            this.salarioTextBox.Size = new System.Drawing.Size(160, 26);
            this.salarioTextBox.TabIndex = 12;
            // 
            // posicaoTextBox
            // 
            this.posicaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_TrabalhadorBindingSource, "Posicao", true));
            this.posicaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posicaoTextBox.Location = new System.Drawing.Point(192, 158);
            this.posicaoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.posicaoTextBox.Name = "posicaoTextBox";
            this.posicaoTextBox.Size = new System.Drawing.Size(160, 26);
            this.posicaoTextBox.TabIndex = 14;
            // 
            // restauranteIdComboBox
            // 
            this.restauranteIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_TrabalhadorBindingSource, "RestauranteId", true));
            this.restauranteIdComboBox.DataSource = this.restauranteSetBindingSource;
            this.restauranteIdComboBox.DisplayMember = "Nome";
            this.restauranteIdComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restauranteIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restauranteIdComboBox.FormattingEnabled = true;
            this.restauranteIdComboBox.Location = new System.Drawing.Point(192, 92);
            this.restauranteIdComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.restauranteIdComboBox.Name = "restauranteIdComboBox";
            this.restauranteIdComboBox.Size = new System.Drawing.Size(160, 28);
            this.restauranteIdComboBox.TabIndex = 16;
            this.restauranteIdComboBox.ValueMember = "Id";
            // 
            // restauranteSetBindingSource
            // 
            this.restauranteSetBindingSource.DataMember = "RestauranteSet";
            this.restauranteSetBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // idComboBox
            // 
            this.idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_TrabalhadorBindingSource, "Id", true));
            this.idComboBox.DataSource = this.pessoaSetBindingSource;
            this.idComboBox.DisplayMember = "Nome";
            this.idComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(192, 56);
            this.idComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(160, 28);
            this.idComboBox.TabIndex = 18;
            this.idComboBox.ValueMember = "Id";
            // 
            // pessoaSetBindingSource
            // 
            this.pessoaSetBindingSource.DataMember = "PessoaSet";
            this.pessoaSetBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // pedidoSetBindingSource
            // 
            this.pedidoSetBindingSource.DataMember = "PedidoSet";
            this.pedidoSetBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.associarTrabalhadorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(451, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // associarTrabalhadorToolStripMenuItem
            // 
            this.associarTrabalhadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.concluirToolStripMenuItem,
            this.voltarTrabalhadoresToolStripMenuItem});
            this.associarTrabalhadorToolStripMenuItem.Name = "associarTrabalhadorToolStripMenuItem";
            this.associarTrabalhadorToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.associarTrabalhadorToolStripMenuItem.Text = "Associar Trabalhador";
            // 
            // concluirToolStripMenuItem
            // 
            this.concluirToolStripMenuItem.Name = "concluirToolStripMenuItem";
            this.concluirToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.concluirToolStripMenuItem.Text = "Concluir";
            this.concluirToolStripMenuItem.Click += new System.EventHandler(this.concluirToolStripMenuItem_Click);
            // 
            // voltarTrabalhadoresToolStripMenuItem
            // 
            this.voltarTrabalhadoresToolStripMenuItem.Name = "voltarTrabalhadoresToolStripMenuItem";
            this.voltarTrabalhadoresToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.voltarTrabalhadoresToolStripMenuItem.Text = "Voltar Trabalhadores";
            this.voltarTrabalhadoresToolStripMenuItem.Click += new System.EventHandler(this.voltarTrabalhadoresToolStripMenuItem_Click);
            // 
            // AssociarTrabalhador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(451, 246);
            this.Controls.Add(salarioLabel);
            this.Controls.Add(this.salarioTextBox);
            this.Controls.Add(posicaoLabel);
            this.Controls.Add(this.posicaoTextBox);
            this.Controls.Add(restauranteIdLabel);
            this.Controls.Add(this.restauranteIdComboBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AssociarTrabalhador";
            this.Text = "Associar Trabalhador";
            this.Load += new System.EventHandler(this.AssociarTrabalhador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_TrabalhadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem associarTrabalhadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarTrabalhadoresToolStripMenuItem;
    }
}