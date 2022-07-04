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
            this.btnBack = new System.Windows.Forms.Button();
            this.CRUD_Estado = new System.Windows.Forms.Button();
            this.restauranteDataSet3 = new Projeto_DA_Restaurante.RestauranteDataSet3();
            this.estadoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.EstadoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager();
            this.estadoSetDataGridView = new System.Windows.Forms.DataGridView();
            this.restGestDBDataSet = new Projeto_DA_Restaurante.RestGestDBDataSet();
            this.restGestDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.estadoSetTableAdapter1 = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.EstadoSetTableAdapter();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.estadoSetDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 296);
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
            this.CRUD_Estado.Location = new System.Drawing.Point(128, 296);
            this.CRUD_Estado.Name = "CRUD_Estado";
            this.CRUD_Estado.Size = new System.Drawing.Size(90, 40);
            this.CRUD_Estado.TabIndex = 9;
            this.CRUD_Estado.Text = " Criar/Editar Estado";
            this.CRUD_Estado.UseVisualStyleBackColor = true;
            this.CRUD_Estado.Click += new System.EventHandler(this.CRUD_Estado_Click);
            // 
            // restauranteDataSet3
            // 
            this.restauranteDataSet3.DataSetName = "RestauranteDataSet3";
            this.restauranteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadoSetBindingSource
            // 
            this.estadoSetBindingSource.DataMember = "EstadoSet";
            this.estadoSetBindingSource.DataSource = this.restauranteDataSet3;
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
            // estadoSetDataGridView
            // 
            this.estadoSetDataGridView.AllowUserToAddRows = false;
            this.estadoSetDataGridView.AllowUserToDeleteRows = false;
            this.estadoSetDataGridView.AutoGenerateColumns = false;
            this.estadoSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estadoSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estadoDataGridViewTextBoxColumn});
            this.estadoSetDataGridView.DataSource = this.estadoSetBindingSource1;
            this.estadoSetDataGridView.Location = new System.Drawing.Point(6, 19);
            this.estadoSetDataGridView.Name = "estadoSetDataGridView";
            this.estadoSetDataGridView.ReadOnly = true;
            this.estadoSetDataGridView.Size = new System.Drawing.Size(194, 220);
            this.estadoSetDataGridView.TabIndex = 0;
            // 
            // restGestDBDataSet
            // 
            this.restGestDBDataSet.DataSetName = "RestGestDBDataSet";
            this.restGestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restGestDBDataSetBindingSource
            // 
            this.restGestDBDataSetBindingSource.DataSource = this.restGestDBDataSet;
            this.restGestDBDataSetBindingSource.Position = 0;
            // 
            // estadoSetBindingSource1
            // 
            this.estadoSetBindingSource1.DataMember = "EstadoSet";
            this.estadoSetBindingSource1.DataSource = this.restGestDBDataSetBindingSource;
            // 
            // estadoSetTableAdapter1
            // 
            this.estadoSetTableAdapter1.ClearBeforeFill = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 150;
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 352);
            this.Controls.Add(this.CRUD_Estado);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Name = "Status";
            this.Text = "State";
            this.Load += new System.EventHandler(this.State_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button CRUD_Estado;
        private RestauranteDataSet3 restauranteDataSet3;
        private System.Windows.Forms.BindingSource estadoSetBindingSource;
        private RestauranteDataSet3TableAdapters.EstadoSetTableAdapter estadoSetTableAdapter;
        private RestauranteDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView estadoSetDataGridView;
        private System.Windows.Forms.BindingSource restGestDBDataSetBindingSource;
        private RestGestDBDataSet restGestDBDataSet;
        private System.Windows.Forms.BindingSource estadoSetBindingSource1;
        private RestGestDBDataSetTableAdapters.EstadoSetTableAdapter estadoSetTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}