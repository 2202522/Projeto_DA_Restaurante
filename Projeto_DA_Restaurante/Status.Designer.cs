namespace Projeto_DA_Restaurante
{
    partial class Status
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
            this.estadoSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteDataSet3 = new Projeto_DA_Restaurante.RestauranteDataSet3();
            this.estadoSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.EstadoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager();
            this.estadoSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.CRUD_Estado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingNavigator)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.estadoSetDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // estadoSetDataGridView
            // 
            this.estadoSetDataGridView.AllowUserToAddRows = false;
            this.estadoSetDataGridView.AllowUserToDeleteRows = false;
            this.estadoSetDataGridView.AutoGenerateColumns = false;
            this.estadoSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estadoSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.estadoSetDataGridView.DataSource = this.estadoSetBindingSource;
            this.estadoSetDataGridView.Location = new System.Drawing.Point(6, 19);
            this.estadoSetDataGridView.Name = "estadoSetDataGridView";
            this.estadoSetDataGridView.ReadOnly = true;
            this.estadoSetDataGridView.Size = new System.Drawing.Size(143, 185);
            this.estadoSetDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn2.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // estadoSetBindingSource
            // 
            this.estadoSetBindingSource.DataMember = "EstadoSet";
            this.estadoSetBindingSource.DataSource = this.restauranteDataSet3;
            // 
            // restauranteDataSet3
            // 
            this.restauranteDataSet3.DataSetName = "RestauranteDataSet3";
            this.restauranteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadoSetTableAdapter
            // 
            this.estadoSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaSetTableAdapter = null;
            this.tableAdapterManager.EstadoSetTableAdapter = this.estadoSetTableAdapter;
            this.tableAdapterManager.ItemMenuSetTableAdapter = null;
            this.tableAdapterManager.MetodoPagamentoSetTableAdapter = null;
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
            // estadoSetBindingNavigator
            // 
            this.estadoSetBindingNavigator.AddNewItem = null;
            this.estadoSetBindingNavigator.BindingSource = this.estadoSetBindingSource;
            this.estadoSetBindingNavigator.CountItem = null;
            this.estadoSetBindingNavigator.DeleteItem = null;
            this.estadoSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.estadoSetBindingNavigator.MoveFirstItem = null;
            this.estadoSetBindingNavigator.MoveLastItem = null;
            this.estadoSetBindingNavigator.MoveNextItem = null;
            this.estadoSetBindingNavigator.MovePreviousItem = null;
            this.estadoSetBindingNavigator.Name = "estadoSetBindingNavigator";
            this.estadoSetBindingNavigator.PositionItem = null;
            this.estadoSetBindingNavigator.Size = new System.Drawing.Size(285, 25);
            this.estadoSetBindingNavigator.TabIndex = 1;
            this.estadoSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 262);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CRUD_Estado
            // 
            this.CRUD_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRUD_Estado.Location = new System.Drawing.Point(183, 47);
            this.CRUD_Estado.Name = "CRUD_Estado";
            this.CRUD_Estado.Size = new System.Drawing.Size(90, 40);
            this.CRUD_Estado.TabIndex = 9;
            this.CRUD_Estado.Text = "Criar/Editar Estado";
            this.CRUD_Estado.UseVisualStyleBackColor = true;
            this.CRUD_Estado.Click += new System.EventHandler(this.CRUD_Estado_Click);
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 314);
            this.Controls.Add(this.CRUD_Estado);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.estadoSetBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "Status";
            this.Text = "State";
            this.Load += new System.EventHandler(this.State_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingNavigator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private RestauranteDataSet3 restauranteDataSet3;
        private System.Windows.Forms.BindingSource estadoSetBindingSource;
        private RestauranteDataSet3TableAdapters.EstadoSetTableAdapter estadoSetTableAdapter;
        private RestauranteDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator estadoSetBindingNavigator;
        private System.Windows.Forms.DataGridView estadoSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button CRUD_Estado;
    }
}