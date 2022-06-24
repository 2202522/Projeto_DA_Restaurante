namespace Projeto_DA_Restaurante
{
    partial class GestaoRestaurantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoRestaurantes));
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCriarRestauranteView = new System.Windows.Forms.Button();
            this.btnAbrirRestaurante = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.categoriaSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteDataSet1 = new Projeto_DA_Restaurante.RestauranteDataSet1();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metodoPagamentoSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoPagamentoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnMetodo = new System.Windows.Forms.Button();
            this.categoriaSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.CategoriaSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.TableAdapterManager();
            this.metodoPagamentoSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.MetodoPagamentoSetTableAdapter();
            this.restauranteSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.RestauranteSetTableAdapter();
            this.categoriaSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.restauranteSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteSetComboBox = new System.Windows.Forms.ComboBox();
            this.Restaurante = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingNavigator)).BeginInit();
            this.categoriaSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).BeginInit();
            this.Restaurante.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 511);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(107, 49);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCriarRestauranteView
            // 
            this.btnCriarRestauranteView.Location = new System.Drawing.Point(338, 34);
            this.btnCriarRestauranteView.Name = "btnCriarRestauranteView";
            this.btnCriarRestauranteView.Size = new System.Drawing.Size(87, 36);
            this.btnCriarRestauranteView.TabIndex = 1;
            this.btnCriarRestauranteView.Text = "Criar";
            this.btnCriarRestauranteView.UseVisualStyleBackColor = true;
            this.btnCriarRestauranteView.Click += new System.EventHandler(this.btnCriarRestaurante_Click);
            // 
            // btnAbrirRestaurante
            // 
            this.btnAbrirRestaurante.Location = new System.Drawing.Point(21, 34);
            this.btnAbrirRestaurante.Name = "btnAbrirRestaurante";
            this.btnAbrirRestaurante.Size = new System.Drawing.Size(87, 36);
            this.btnAbrirRestaurante.TabIndex = 3;
            this.btnAbrirRestaurante.Text = "Abrir";
            this.btnAbrirRestaurante.UseVisualStyleBackColor = true;
            this.btnAbrirRestaurante.Click += new System.EventHandler(this.btnAbrirRestaurante_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.categoriaSetDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 341);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorias";
            // 
            // categoriaSetDataGridView
            // 
            this.categoriaSetDataGridView.AllowUserToDeleteRows = false;
            this.categoriaSetDataGridView.AutoGenerateColumns = false;
            this.categoriaSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriaSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.categoriaSetDataGridView.DataSource = this.categoriaSetBindingSource;
            this.categoriaSetDataGridView.Location = new System.Drawing.Point(6, 25);
            this.categoriaSetDataGridView.Name = "categoriaSetDataGridView";
            this.categoriaSetDataGridView.ReadOnly = true;
            this.categoriaSetDataGridView.Size = new System.Drawing.Size(442, 310);
            this.categoriaSetDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.categoriaSetBindingSource.DataSource = this.restauranteDataSet1;
            // 
            // restauranteDataSet1
            // 
            this.restauranteDataSet1.DataSetName = "RestauranteDataSet1";
            this.restauranteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metodoPagamentoSetDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(532, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 341);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Metodos Pagamento";
            // 
            // metodoPagamentoSetDataGridView
            // 
            this.metodoPagamentoSetDataGridView.AutoGenerateColumns = false;
            this.metodoPagamentoSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metodoPagamentoSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.metodoPagamentoSetDataGridView.DataSource = this.metodoPagamentoSetBindingSource;
            this.metodoPagamentoSetDataGridView.Location = new System.Drawing.Point(6, 25);
            this.metodoPagamentoSetDataGridView.Name = "metodoPagamentoSetDataGridView";
            this.metodoPagamentoSetDataGridView.Size = new System.Drawing.Size(520, 310);
            this.metodoPagamentoSetDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MetoPagamento";
            this.dataGridViewTextBoxColumn5.HeaderText = "MetoPagamento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ativo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ativo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // metodoPagamentoSetBindingSource
            // 
            this.metodoPagamentoSetBindingSource.DataMember = "MetodoPagamentoSet";
            this.metodoPagamentoSetBindingSource.DataSource = this.restauranteDataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Restaurantes:";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(391, 489);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(87, 36);
            this.btnCategoria.TabIndex = 10;
            this.btnCategoria.Text = "Editar Categoria";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMetodo
            // 
            this.btnMetodo.Location = new System.Drawing.Point(971, 489);
            this.btnMetodo.Name = "btnMetodo";
            this.btnMetodo.Size = new System.Drawing.Size(87, 36);
            this.btnMetodo.TabIndex = 11;
            this.btnMetodo.Text = "Editar Metodo Pagamento";
            this.btnMetodo.UseVisualStyleBackColor = true;
            this.btnMetodo.Click += new System.EventHandler(this.btnMetodo_Click);
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
            this.tableAdapterManager.PagamentoSetTableAdapter = null;
            this.tableAdapterManager.PedidoItemMenuTableAdapter = null;
            this.tableAdapterManager.PedidoSetTableAdapter = null;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_TrabalhadorTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.RestauranteItemMenuTableAdapter = null;
            this.tableAdapterManager.RestauranteSetTableAdapter = this.restauranteSetTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // metodoPagamentoSetTableAdapter
            // 
            this.metodoPagamentoSetTableAdapter.ClearBeforeFill = true;
            // 
            // restauranteSetTableAdapter
            // 
            this.restauranteSetTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaSetBindingNavigator
            // 
            this.categoriaSetBindingNavigator.AddNewItem = null;
            this.categoriaSetBindingNavigator.BindingSource = this.categoriaSetBindingSource;
            this.categoriaSetBindingNavigator.CountItem = this.bindingNavigatorCountItem1;
            this.categoriaSetBindingNavigator.DeleteItem = null;
            this.categoriaSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator4});
            this.categoriaSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.categoriaSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.categoriaSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.categoriaSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.categoriaSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.categoriaSetBindingNavigator.Name = "categoriaSetBindingNavigator";
            this.categoriaSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem1;
            this.categoriaSetBindingNavigator.Size = new System.Drawing.Size(1093, 25);
            this.categoriaSetBindingNavigator.TabIndex = 12;
            this.categoriaSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // restauranteSetBindingSource
            // 
            this.restauranteSetBindingSource.DataMember = "RestauranteSet";
            this.restauranteSetBindingSource.DataSource = this.restauranteDataSet1;
            // 
            // restauranteSetComboBox
            // 
            this.restauranteSetComboBox.DataSource = this.restauranteSetBindingSource;
            this.restauranteSetComboBox.DisplayMember = "Nome";
            this.restauranteSetComboBox.FormattingEnabled = true;
            this.restauranteSetComboBox.Location = new System.Drawing.Point(129, 38);
            this.restauranteSetComboBox.Name = "restauranteSetComboBox";
            this.restauranteSetComboBox.Size = new System.Drawing.Size(173, 28);
            this.restauranteSetComboBox.TabIndex = 12;
            this.restauranteSetComboBox.ValueMember = "Id";
            this.restauranteSetComboBox.SelectedIndexChanged += new System.EventHandler(this.restauranteSetComboBox_SelectedIndexChanged);
            // 
            // Restaurante
            // 
            this.Restaurante.Controls.Add(this.restauranteSetComboBox);
            this.Restaurante.Controls.Add(this.label1);
            this.Restaurante.Controls.Add(this.btnCriarRestauranteView);
            this.Restaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restaurante.Location = new System.Drawing.Point(30, 44);
            this.Restaurante.Name = "Restaurante";
            this.Restaurante.Size = new System.Drawing.Size(454, 85);
            this.Restaurante.TabIndex = 13;
            this.Restaurante.TabStop = false;
            this.Restaurante.Text = "Restaurante";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAbrirRestaurante);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(532, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 85);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gestao de Menus/Trabalhadores";
            // 
            // GestaoRestaurantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1093, 572);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Restaurante);
            this.Controls.Add(this.categoriaSetBindingNavigator);
            this.Controls.Add(this.btnMetodo);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHome);
            this.Name = "GestaoRestaurantes";
            this.Text = "GestaoRestaurantes";
            this.Load += new System.EventHandler(this.GestaoRestaurantes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingNavigator)).EndInit();
            this.categoriaSetBindingNavigator.ResumeLayout(false);
            this.categoriaSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).EndInit();
            this.Restaurante.ResumeLayout(false);
            this.Restaurante.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCriarRestauranteView;
        private System.Windows.Forms.Button btnAbrirRestaurante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnMetodo;
        private RestauranteDataSet1 restauranteDataSet1;
        private System.Windows.Forms.BindingSource categoriaSetBindingSource;
        private RestauranteDataSet1TableAdapters.CategoriaSetTableAdapter categoriaSetTableAdapter;
        private RestauranteDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator categoriaSetBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.DataGridView categoriaSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private RestauranteDataSet1TableAdapters.RestauranteSetTableAdapter restauranteSetTableAdapter;
        private System.Windows.Forms.BindingSource restauranteSetBindingSource;
        private System.Windows.Forms.ComboBox restauranteSetComboBox;
        private RestauranteDataSet1TableAdapters.MetodoPagamentoSetTableAdapter metodoPagamentoSetTableAdapter;
        private System.Windows.Forms.BindingSource metodoPagamentoSetBindingSource;
        private System.Windows.Forms.DataGridView metodoPagamentoSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox Restaurante;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}