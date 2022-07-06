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
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.restGestDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restGestDBDataSet = new Projeto_DA_Restaurante.RestGestDBDataSet();
            this.restauranteDataSet3 = new Projeto_DA_Restaurante.RestauranteDataSet3();
            this.estadoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.EstadoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager();
            this.estadoSetTableAdapter1 = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.EstadoSetTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarEditarEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarMainPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.estadoSetDataGridView);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(13, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(275, 300);
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
            this.estadoDataGridViewTextBoxColumn});
            this.estadoSetDataGridView.DataSource = this.estadoSetBindingSource1;
            this.estadoSetDataGridView.Location = new System.Drawing.Point(8, 23);
            this.estadoSetDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.estadoSetDataGridView.Name = "estadoSetDataGridView";
            this.estadoSetDataGridView.ReadOnly = true;
            this.estadoSetDataGridView.RowHeadersWidth = 51;
            this.estadoSetDataGridView.Size = new System.Drawing.Size(259, 271);
            this.estadoSetDataGridView.TabIndex = 0;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 150;
            // 
            // estadoSetBindingSource1
            // 
            this.estadoSetBindingSource1.DataMember = "EstadoSet";
            this.estadoSetBindingSource1.DataSource = this.restGestDBDataSetBindingSource;
            // 
            // restGestDBDataSetBindingSource
            // 
            this.restGestDBDataSetBindingSource.DataSource = this.restGestDBDataSet;
            this.restGestDBDataSetBindingSource.Position = 0;
            // 
            // restGestDBDataSet
            // 
            this.restGestDBDataSet.DataSetName = "RestGestDBDataSet";
            this.restGestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // estadoSetTableAdapter1
            // 
            this.estadoSetTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(311, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stateToolStripMenuItem
            // 
            this.stateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarEditarEstadoToolStripMenuItem,
            this.voltarMainPageToolStripMenuItem});
            this.stateToolStripMenuItem.Name = "stateToolStripMenuItem";
            this.stateToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.stateToolStripMenuItem.Text = "State";
            // 
            // criarEditarEstadoToolStripMenuItem
            // 
            this.criarEditarEstadoToolStripMenuItem.Name = "criarEditarEstadoToolStripMenuItem";
            this.criarEditarEstadoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.criarEditarEstadoToolStripMenuItem.Text = "Criar/Editar Estado";
            this.criarEditarEstadoToolStripMenuItem.Click += new System.EventHandler(this.criarEditarEstadoToolStripMenuItem_Click);
            // 
            // voltarMainPageToolStripMenuItem
            // 
            this.voltarMainPageToolStripMenuItem.Name = "voltarMainPageToolStripMenuItem";
            this.voltarMainPageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.voltarMainPageToolStripMenuItem.Text = "Voltar Main Page";
            this.voltarMainPageToolStripMenuItem.Click += new System.EventHandler(this.voltarMainPageToolStripMenuItem_Click);
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(311, 393);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Status";
            this.Text = "State";
            this.Load += new System.EventHandler(this.State_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarEditarEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarMainPageToolStripMenuItem;
    }
}