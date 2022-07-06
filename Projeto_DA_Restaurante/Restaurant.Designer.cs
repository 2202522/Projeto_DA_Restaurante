namespace Projeto_DA_Restaurante
{
    partial class Restaurant
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.categoriaSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteDataSet3 = new Projeto_DA_Restaurante.RestauranteDataSet3();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metodoPagamentoSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoPagamentoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.CategoriaSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager();
            this.metodoPagamentoSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.MetodoPagamentoSetTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.restaurantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarEditarRestauranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarEditarTrabalhadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarEditarItensMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarEditarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarEditarMetodoPagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarMainPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.categoriaSetDataGridView);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(13, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(453, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // categoriaSetDataGridView
            // 
            this.categoriaSetDataGridView.AllowUserToAddRows = false;
            this.categoriaSetDataGridView.AllowUserToDeleteRows = false;
            this.categoriaSetDataGridView.AutoGenerateColumns = false;
            this.categoriaSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriaSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.categoriaSetDataGridView.DataSource = this.categoriaSetBindingSource;
            this.categoriaSetDataGridView.Location = new System.Drawing.Point(8, 23);
            this.categoriaSetDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.categoriaSetDataGridView.Name = "categoriaSetDataGridView";
            this.categoriaSetDataGridView.ReadOnly = true;
            this.categoriaSetDataGridView.RowHeadersWidth = 51;
            this.categoriaSetDataGridView.Size = new System.Drawing.Size(433, 177);
            this.categoriaSetDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ativo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ativo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // categoriaSetBindingSource
            // 
            this.categoriaSetBindingSource.DataMember = "CategoriaSet";
            this.categoriaSetBindingSource.DataSource = this.restauranteDataSet3;
            // 
            // restauranteDataSet3
            // 
            this.restauranteDataSet3.DataSetName = "RestauranteDataSet3";
            this.restauranteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metodoPagamentoSetDataGridView);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(13, 316);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(453, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Metodo de Pagamento";
            // 
            // metodoPagamentoSetDataGridView
            // 
            this.metodoPagamentoSetDataGridView.AllowUserToAddRows = false;
            this.metodoPagamentoSetDataGridView.AllowUserToDeleteRows = false;
            this.metodoPagamentoSetDataGridView.AutoGenerateColumns = false;
            this.metodoPagamentoSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metodoPagamentoSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.metodoPagamentoSetDataGridView.DataSource = this.metodoPagamentoSetBindingSource;
            this.metodoPagamentoSetDataGridView.Location = new System.Drawing.Point(8, 23);
            this.metodoPagamentoSetDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.metodoPagamentoSetDataGridView.Name = "metodoPagamentoSetDataGridView";
            this.metodoPagamentoSetDataGridView.ReadOnly = true;
            this.metodoPagamentoSetDataGridView.RowHeadersWidth = 51;
            this.metodoPagamentoSetDataGridView.Size = new System.Drawing.Size(433, 180);
            this.metodoPagamentoSetDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MetoPagamento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Metodo Pagamento";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ativo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ativo";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // metodoPagamentoSetBindingSource
            // 
            this.metodoPagamentoSetBindingSource.DataMember = "MetodoPagamentoSet";
            this.metodoPagamentoSetBindingSource.DataSource = this.restauranteDataSet3;
            // 
            // categoriaSetTableAdapter
            // 
            this.categoriaSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaSetTableAdapter = this.categoriaSetTableAdapter;
            this.tableAdapterManager.EstadoSetTableAdapter = null;
            this.tableAdapterManager.ItemMenuSetTableAdapter = null;
            this.tableAdapterManager.MetodoPagamentoSetTableAdapter = this.metodoPagamentoSetTableAdapter;
            this.tableAdapterManager.MoradaSetTableAdapter = null;
            this.tableAdapterManager.PagamentoSetTableAdapter = null;
            this.tableAdapterManager.PedidoItemMenuTableAdapter = null;
            this.tableAdapterManager.PedidoSetTableAdapter = null;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_TrabalhadorTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.RestauranteItemMenuTableAdapter = null;
            this.tableAdapterManager.RestauranteSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // metodoPagamentoSetTableAdapter
            // 
            this.metodoPagamentoSetTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurantToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // restaurantToolStripMenuItem
            // 
            this.restaurantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarEditarRestauranteToolStripMenuItem,
            this.criarEditarTrabalhadoresToolStripMenuItem,
            this.criarEditarItensMenuToolStripMenuItem,
            this.criarEditarCategoriaToolStripMenuItem,
            this.criarEditarMetodoPagamentoToolStripMenuItem,
            this.voltarMainPageToolStripMenuItem});
            this.restaurantToolStripMenuItem.Name = "restaurantToolStripMenuItem";
            this.restaurantToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.restaurantToolStripMenuItem.Text = "Restaurante";
            // 
            // criarEditarRestauranteToolStripMenuItem
            // 
            this.criarEditarRestauranteToolStripMenuItem.Name = "criarEditarRestauranteToolStripMenuItem";
            this.criarEditarRestauranteToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.criarEditarRestauranteToolStripMenuItem.Text = "Criar/Editar Restaurante";
            this.criarEditarRestauranteToolStripMenuItem.Click += new System.EventHandler(this.criarEditarRestauranteToolStripMenuItem_Click);
            // 
            // criarEditarTrabalhadoresToolStripMenuItem
            // 
            this.criarEditarTrabalhadoresToolStripMenuItem.Name = "criarEditarTrabalhadoresToolStripMenuItem";
            this.criarEditarTrabalhadoresToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.criarEditarTrabalhadoresToolStripMenuItem.Text = "Criar/Editar Trabalhadores";
            this.criarEditarTrabalhadoresToolStripMenuItem.Click += new System.EventHandler(this.criarEditarTrabalhadoresToolStripMenuItem_Click);
            // 
            // criarEditarItensMenuToolStripMenuItem
            // 
            this.criarEditarItensMenuToolStripMenuItem.Name = "criarEditarItensMenuToolStripMenuItem";
            this.criarEditarItensMenuToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.criarEditarItensMenuToolStripMenuItem.Text = "Criar/Editar Itens Menu";
            this.criarEditarItensMenuToolStripMenuItem.Click += new System.EventHandler(this.criarEditarItensMenuToolStripMenuItem_Click);
            // 
            // criarEditarCategoriaToolStripMenuItem
            // 
            this.criarEditarCategoriaToolStripMenuItem.Name = "criarEditarCategoriaToolStripMenuItem";
            this.criarEditarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.criarEditarCategoriaToolStripMenuItem.Text = "Criar/Editar Categoria";
            this.criarEditarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.criarEditarCategoriaToolStripMenuItem_Click);
            // 
            // criarEditarMetodoPagamentoToolStripMenuItem
            // 
            this.criarEditarMetodoPagamentoToolStripMenuItem.Name = "criarEditarMetodoPagamentoToolStripMenuItem";
            this.criarEditarMetodoPagamentoToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.criarEditarMetodoPagamentoToolStripMenuItem.Text = "Criar/Editar Metodo Pagamento";
            this.criarEditarMetodoPagamentoToolStripMenuItem.Click += new System.EventHandler(this.criarEditarMetodoPagamentoToolStripMenuItem_Click);
            // 
            // voltarMainPageToolStripMenuItem
            // 
            this.voltarMainPageToolStripMenuItem.Name = "voltarMainPageToolStripMenuItem";
            this.voltarMainPageToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.voltarMainPageToolStripMenuItem.Text = "Voltar Main Page";
            this.voltarMainPageToolStripMenuItem.Click += new System.EventHandler(this.voltarMainPageToolStripMenuItem_Click);
            // 
            // Restaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(500, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Restaurant";
            this.Text = "Restaurant";
            this.Load += new System.EventHandler(this.Restaurant_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private RestauranteDataSet3 restauranteDataSet3;
        private System.Windows.Forms.BindingSource categoriaSetBindingSource;
        private RestauranteDataSet3TableAdapters.CategoriaSetTableAdapter categoriaSetTableAdapter;
        private RestauranteDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView categoriaSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private RestauranteDataSet3TableAdapters.MetodoPagamentoSetTableAdapter metodoPagamentoSetTableAdapter;
        private System.Windows.Forms.BindingSource metodoPagamentoSetBindingSource;
        private System.Windows.Forms.DataGridView metodoPagamentoSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restaurantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarEditarRestauranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarEditarTrabalhadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarEditarItensMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarEditarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarEditarMetodoPagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarMainPageToolStripMenuItem;
    }
}