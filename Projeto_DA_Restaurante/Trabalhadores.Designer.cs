namespace Projeto_DA_Restaurante
{
    partial class Trabalhadores
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
            this.restauranteDataSet3 = new Projeto_DA_Restaurante.RestauranteDataSet3();
            this.pessoaSet_TrabalhadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSet_TrabalhadorTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.PessoaSet_TrabalhadorTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager();
            this.pessoaSet_TrabalhadorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.pessoaSet_TrabalhadorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_CRUD_Trabalhadores = new System.Windows.Forms.Button();
            this.btn_Associar = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_TrabalhadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_TrabalhadorBindingNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_TrabalhadorDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // restauranteDataSet3
            // 
            this.restauranteDataSet3.DataSetName = "RestauranteDataSet3";
            this.restauranteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaSet_TrabalhadorBindingSource
            // 
            this.pessoaSet_TrabalhadorBindingSource.DataMember = "PessoaSet_Trabalhador";
            this.pessoaSet_TrabalhadorBindingSource.DataSource = this.restauranteDataSet3;
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
            this.tableAdapterManager.PedidoSetTableAdapter = null;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_TrabalhadorTableAdapter = this.pessoaSet_TrabalhadorTableAdapter;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.RestauranteItemMenuTableAdapter = null;
            this.tableAdapterManager.RestauranteSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pessoaSet_TrabalhadorBindingNavigator
            // 
            this.pessoaSet_TrabalhadorBindingNavigator.AddNewItem = null;
            this.pessoaSet_TrabalhadorBindingNavigator.BindingSource = this.pessoaSet_TrabalhadorBindingSource;
            this.pessoaSet_TrabalhadorBindingNavigator.CountItem = null;
            this.pessoaSet_TrabalhadorBindingNavigator.DeleteItem = null;
            this.pessoaSet_TrabalhadorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pessoaSet_TrabalhadorBindingNavigator.MoveFirstItem = null;
            this.pessoaSet_TrabalhadorBindingNavigator.MoveLastItem = null;
            this.pessoaSet_TrabalhadorBindingNavigator.MoveNextItem = null;
            this.pessoaSet_TrabalhadorBindingNavigator.MovePreviousItem = null;
            this.pessoaSet_TrabalhadorBindingNavigator.Name = "pessoaSet_TrabalhadorBindingNavigator";
            this.pessoaSet_TrabalhadorBindingNavigator.PositionItem = null;
            this.pessoaSet_TrabalhadorBindingNavigator.Size = new System.Drawing.Size(390, 25);
            this.pessoaSet_TrabalhadorBindingNavigator.TabIndex = 0;
            this.pessoaSet_TrabalhadorBindingNavigator.Text = "bindingNavigator1";
            // 
            // pessoaSet_TrabalhadorDataGridView
            // 
            this.pessoaSet_TrabalhadorDataGridView.AllowUserToAddRows = false;
            this.pessoaSet_TrabalhadorDataGridView.AllowUserToDeleteRows = false;
            this.pessoaSet_TrabalhadorDataGridView.AutoGenerateColumns = false;
            this.pessoaSet_TrabalhadorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pessoaSet_TrabalhadorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.pessoaSet_TrabalhadorDataGridView.DataSource = this.pessoaSet_TrabalhadorBindingSource;
            this.pessoaSet_TrabalhadorDataGridView.Location = new System.Drawing.Point(6, 19);
            this.pessoaSet_TrabalhadorDataGridView.Name = "pessoaSet_TrabalhadorDataGridView";
            this.pessoaSet_TrabalhadorDataGridView.ReadOnly = true;
            this.pessoaSet_TrabalhadorDataGridView.Size = new System.Drawing.Size(343, 220);
            this.pessoaSet_TrabalhadorDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Salario";
            this.dataGridViewTextBoxColumn1.HeaderText = "Salario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Posicao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Posicao";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pessoaSet_TrabalhadorDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 246);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabalhadores";
            // 
            // btn_CRUD_Trabalhadores
            // 
            this.btn_CRUD_Trabalhadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CRUD_Trabalhadores.Location = new System.Drawing.Point(275, 280);
            this.btn_CRUD_Trabalhadores.Name = "btn_CRUD_Trabalhadores";
            this.btn_CRUD_Trabalhadores.Size = new System.Drawing.Size(92, 34);
            this.btn_CRUD_Trabalhadores.TabIndex = 11;
            this.btn_CRUD_Trabalhadores.Text = "Criar/Editar Trabalhadores";
            this.btn_CRUD_Trabalhadores.UseVisualStyleBackColor = true;
            this.btn_CRUD_Trabalhadores.Click += new System.EventHandler(this.btn_CRUD_Trabalhadores_Click);
            // 
            // btn_Associar
            // 
            this.btn_Associar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Associar.Location = new System.Drawing.Point(177, 280);
            this.btn_Associar.Name = "btn_Associar";
            this.btn_Associar.Size = new System.Drawing.Size(92, 34);
            this.btn_Associar.TabIndex = 12;
            this.btn_Associar.Text = "Associar Trabalhadores";
            this.btn_Associar.UseVisualStyleBackColor = true;
            this.btn_Associar.Click += new System.EventHandler(this.btn_Associar_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 326);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Trabalhadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 378);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn_Associar);
            this.Controls.Add(this.btn_CRUD_Trabalhadores);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pessoaSet_TrabalhadorBindingNavigator);
            this.Name = "Trabalhadores";
            this.Text = "Trabalhadores";
            this.Load += new System.EventHandler(this.Trabalhadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_TrabalhadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_TrabalhadorBindingNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_TrabalhadorDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestauranteDataSet3 restauranteDataSet3;
        private System.Windows.Forms.BindingSource pessoaSet_TrabalhadorBindingSource;
        private RestauranteDataSet3TableAdapters.PessoaSet_TrabalhadorTableAdapter pessoaSet_TrabalhadorTableAdapter;
        private RestauranteDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pessoaSet_TrabalhadorBindingNavigator;
        private System.Windows.Forms.DataGridView pessoaSet_TrabalhadorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_CRUD_Trabalhadores;
        private System.Windows.Forms.Button btn_Associar;
        private System.Windows.Forms.Button btnBack;
    }
}