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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_CRUD_Restaurante = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_CRUD_Trabalhadores = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_CRUD_Menu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btn_CRUD_Categoria = new System.Windows.Forms.Button();
            this.btn_CRUD_MetodoPagamento = new System.Windows.Forms.Button();
            this.categoriaSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.CategoriaSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager();
            this.metodoPagamentoSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.MetodoPagamentoSetTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.categoriaSetDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(20, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 246);
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
            this.categoriaSetDataGridView.Location = new System.Drawing.Point(6, 19);
            this.categoriaSetDataGridView.Name = "categoriaSetDataGridView";
            this.categoriaSetDataGridView.ReadOnly = true;
            this.categoriaSetDataGridView.Size = new System.Drawing.Size(243, 220);
            this.categoriaSetDataGridView.TabIndex = 0;
            this.categoriaSetDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriaSetDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ativo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ativo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
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
            this.groupBox2.Location = new System.Drawing.Point(292, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 246);
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
            this.metodoPagamentoSetDataGridView.Location = new System.Drawing.Point(6, 19);
            this.metodoPagamentoSetDataGridView.Name = "metodoPagamentoSetDataGridView";
            this.metodoPagamentoSetDataGridView.ReadOnly = true;
            this.metodoPagamentoSetDataGridView.Size = new System.Drawing.Size(243, 220);
            this.metodoPagamentoSetDataGridView.TabIndex = 0;
            this.metodoPagamentoSetDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metodoPagamentoSetDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MetoPagamento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Metodo Pagamento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ativo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ativo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // metodoPagamentoSetBindingSource
            // 
            this.metodoPagamentoSetBindingSource.DataMember = "MetodoPagamentoSet";
            this.metodoPagamentoSetBindingSource.DataSource = this.restauranteDataSet3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_CRUD_Restaurante);
            this.groupBox3.Location = new System.Drawing.Point(20, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 75);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Restaurante";
            // 
            // btn_CRUD_Restaurante
            // 
            this.btn_CRUD_Restaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CRUD_Restaurante.Location = new System.Drawing.Point(29, 24);
            this.btn_CRUD_Restaurante.Name = "btn_CRUD_Restaurante";
            this.btn_CRUD_Restaurante.Size = new System.Drawing.Size(110, 34);
            this.btn_CRUD_Restaurante.TabIndex = 9;
            this.btn_CRUD_Restaurante.Text = "Criar/Editar Restaurante";
            this.btn_CRUD_Restaurante.UseVisualStyleBackColor = true;
            this.btn_CRUD_Restaurante.Click += new System.EventHandler(this.btn_CRUD_Restaurante_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_CRUD_Trabalhadores);
            this.groupBox4.Location = new System.Drawing.Point(195, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(177, 75);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trabalhadores";
            // 
            // btn_CRUD_Trabalhadores
            // 
            this.btn_CRUD_Trabalhadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CRUD_Trabalhadores.Location = new System.Drawing.Point(35, 24);
            this.btn_CRUD_Trabalhadores.Name = "btn_CRUD_Trabalhadores";
            this.btn_CRUD_Trabalhadores.Size = new System.Drawing.Size(110, 34);
            this.btn_CRUD_Trabalhadores.TabIndex = 10;
            this.btn_CRUD_Trabalhadores.Text = "Criar/Editar Trabalhadores";
            this.btn_CRUD_Trabalhadores.UseVisualStyleBackColor = true;
            this.btn_CRUD_Trabalhadores.Click += new System.EventHandler(this.btn_CRUD_Trabalhadores_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_CRUD_Menu);
            this.groupBox5.Location = new System.Drawing.Point(372, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(175, 75);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Itens Menus";
            // 
            // btn_CRUD_Menu
            // 
            this.btn_CRUD_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CRUD_Menu.Location = new System.Drawing.Point(34, 24);
            this.btn_CRUD_Menu.Name = "btn_CRUD_Menu";
            this.btn_CRUD_Menu.Size = new System.Drawing.Size(110, 34);
            this.btn_CRUD_Menu.TabIndex = 11;
            this.btn_CRUD_Menu.Text = "Criar/Editar Itens Menu";
            this.btn_CRUD_Menu.UseVisualStyleBackColor = true;
            this.btn_CRUD_Menu.Click += new System.EventHandler(this.btn_CRUD_Menu_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 397);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btn_CRUD_Categoria
            // 
            this.btn_CRUD_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CRUD_Categoria.Location = new System.Drawing.Point(167, 356);
            this.btn_CRUD_Categoria.Name = "btn_CRUD_Categoria";
            this.btn_CRUD_Categoria.Size = new System.Drawing.Size(110, 34);
            this.btn_CRUD_Categoria.TabIndex = 7;
            this.btn_CRUD_Categoria.Text = "Criar/Editar Categoria";
            this.btn_CRUD_Categoria.UseVisualStyleBackColor = true;
            this.btn_CRUD_Categoria.Click += new System.EventHandler(this.btn_CRUD_Categoria_Click);
            // 
            // btn_CRUD_MetodoPagamento
            // 
            this.btn_CRUD_MetodoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CRUD_MetodoPagamento.Location = new System.Drawing.Point(437, 356);
            this.btn_CRUD_MetodoPagamento.Name = "btn_CRUD_MetodoPagamento";
            this.btn_CRUD_MetodoPagamento.Size = new System.Drawing.Size(110, 34);
            this.btn_CRUD_MetodoPagamento.TabIndex = 8;
            this.btn_CRUD_MetodoPagamento.Text = "Criar/Editar Metodo Pagamento";
            this.btn_CRUD_MetodoPagamento.UseVisualStyleBackColor = true;
            this.btn_CRUD_MetodoPagamento.Click += new System.EventHandler(this.btn_CRUD_MetodoPagamento_Click);
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
            // Restaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 449);
            this.Controls.Add(this.btn_CRUD_MetodoPagamento);
            this.Controls.Add(this.btn_CRUD_Categoria);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btn_CRUD_Categoria;
        private System.Windows.Forms.Button btn_CRUD_MetodoPagamento;
        private System.Windows.Forms.Button btn_CRUD_Restaurante;
        private System.Windows.Forms.Button btn_CRUD_Trabalhadores;
        private System.Windows.Forms.Button btn_CRUD_Menu;
    }
}