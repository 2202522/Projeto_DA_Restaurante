namespace Projeto_DA_Restaurante
{
    partial class Pedidos
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
            this.pedidoSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteDataSet3 = new Projeto_DA_Restaurante.RestauranteDataSet3();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.CRUD_Pedido = new System.Windows.Forms.Button();
            this.Exportar = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.btnAdicionarPrato = new System.Windows.Forms.Button();
            this.pedidoSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.PedidoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pedidoSetDataGridView
            // 
            this.pedidoSetDataGridView.AllowUserToAddRows = false;
            this.pedidoSetDataGridView.AllowUserToDeleteRows = false;
            this.pedidoSetDataGridView.AutoGenerateColumns = false;
            this.pedidoSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedidoSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.pedidoSetDataGridView.DataSource = this.pedidoSetBindingSource;
            this.pedidoSetDataGridView.Location = new System.Drawing.Point(9, 19);
            this.pedidoSetDataGridView.Name = "pedidoSetDataGridView";
            this.pedidoSetDataGridView.ReadOnly = true;
            this.pedidoSetDataGridView.Size = new System.Drawing.Size(544, 220);
            this.pedidoSetDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ValorTotal";
            this.dataGridViewTextBoxColumn2.HeaderText = "ValorTotal";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RestauranteId";
            this.dataGridViewTextBoxColumn3.HeaderText = "RestauranteId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ClienteId";
            this.dataGridViewTextBoxColumn4.HeaderText = "ClienteId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TrabalhadorId";
            this.dataGridViewTextBoxColumn5.HeaderText = "TrabalhadorId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "EstadoId";
            this.dataGridViewTextBoxColumn6.HeaderText = "EstadoId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // pedidoSetBindingSource
            // 
            this.pedidoSetBindingSource.DataMember = "PedidoSet";
            this.pedidoSetBindingSource.DataSource = this.restauranteDataSet3;
            // 
            // restauranteDataSet3
            // 
            this.restauranteDataSet3.DataSetName = "RestauranteDataSet3";
            this.restauranteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pedidoSetDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 248);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 340);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CRUD_Pedido
            // 
            this.CRUD_Pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRUD_Pedido.Location = new System.Drawing.Point(389, 282);
            this.CRUD_Pedido.Name = "CRUD_Pedido";
            this.CRUD_Pedido.Size = new System.Drawing.Size(90, 40);
            this.CRUD_Pedido.TabIndex = 8;
            this.CRUD_Pedido.Text = "Criar/Editar Pedido";
            this.CRUD_Pedido.UseVisualStyleBackColor = true;
            this.CRUD_Pedido.Click += new System.EventHandler(this.CRUD_Pedido_Click);
            // 
            // Exportar
            // 
            this.Exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exportar.Location = new System.Drawing.Point(485, 282);
            this.Exportar.Name = "Exportar";
            this.Exportar.Size = new System.Drawing.Size(90, 40);
            this.Exportar.TabIndex = 9;
            this.Exportar.Text = "Exportar (PDF)";
            this.Exportar.UseVisualStyleBackColor = true;
            this.Exportar.Click += new System.EventHandler(this.Exportar_Click);
            // 
            // btnPagamento
            // 
            this.btnPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamento.Location = new System.Drawing.Point(197, 282);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(90, 40);
            this.btnPagamento.TabIndex = 10;
            this.btnPagamento.Text = "Efetuar Pagamento";
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // btnAdicionarPrato
            // 
            this.btnAdicionarPrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarPrato.Location = new System.Drawing.Point(293, 282);
            this.btnAdicionarPrato.Name = "btnAdicionarPrato";
            this.btnAdicionarPrato.Size = new System.Drawing.Size(90, 40);
            this.btnAdicionarPrato.TabIndex = 11;
            this.btnAdicionarPrato.Text = " Associar Prato a um Pedido";
            this.btnAdicionarPrato.UseVisualStyleBackColor = true;
            this.btnAdicionarPrato.Click += new System.EventHandler(this.btnAdicionarPrato_Click);
            // 
            // pedidoSetTableAdapter
            // 
            this.pedidoSetTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PessoaSet_TrabalhadorTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.RestauranteItemMenuTableAdapter = null;
            this.tableAdapterManager.RestauranteSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 392);
            this.Controls.Add(this.btnAdicionarPrato);
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.Exportar);
            this.Controls.Add(this.CRUD_Pedido);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RestauranteDataSet3 restauranteDataSet3;
        private System.Windows.Forms.BindingSource pedidoSetBindingSource;
        private RestauranteDataSet3TableAdapters.PedidoSetTableAdapter pedidoSetTableAdapter;
        private RestauranteDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pedidoSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button CRUD_Pedido;
        private System.Windows.Forms.Button Exportar;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Button btnAdicionarPrato;
    }
}