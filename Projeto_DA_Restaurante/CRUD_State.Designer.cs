namespace Projeto_DA_Restaurante
{
    partial class CRUD_State
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
            System.Windows.Forms.Label estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_State));
            this.restauranteDataSet3 = new Projeto_DA_Restaurante.RestauranteDataSet3();
            this.estadoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.EstadoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager();
            this.estadoSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.estadoSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingNavigator)).BeginInit();
            this.estadoSetBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            // estadoSetBindingNavigator
            // 
            this.estadoSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.estadoSetBindingNavigator.BindingSource = this.estadoSetBindingSource;
            this.estadoSetBindingNavigator.CountItem = null;
            this.estadoSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.estadoSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.estadoSetBindingNavigatorSaveItem});
            this.estadoSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.estadoSetBindingNavigator.MoveFirstItem = null;
            this.estadoSetBindingNavigator.MoveLastItem = null;
            this.estadoSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.estadoSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.estadoSetBindingNavigator.Name = "estadoSetBindingNavigator";
            this.estadoSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.estadoSetBindingNavigator.Size = new System.Drawing.Size(330, 25);
            this.estadoSetBindingNavigator.TabIndex = 0;
            this.estadoSetBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(59, 68);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 3;
            estadoLabel.Text = "Estado:";
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estadoSetBindingSource, "estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(107, 65);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.estadoTextBox.TabIndex = 4;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // estadoSetBindingNavigatorSaveItem
            // 
            this.estadoSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.estadoSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("estadoSetBindingNavigatorSaveItem.Image")));
            this.estadoSetBindingNavigatorSaveItem.Name = "estadoSetBindingNavigatorSaveItem";
            this.estadoSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.estadoSetBindingNavigatorSaveItem.Text = "Save Data";
            this.estadoSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.estadoSetBindingNavigatorSaveItem_Click);
            // 
            // btnConcluir
            // 
            this.btnConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Location = new System.Drawing.Point(228, 140);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(90, 40);
            this.btnConcluir.TabIndex = 9;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 140);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CRUD_State
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 192);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(this.estadoSetBindingNavigator);
            this.Name = "CRUD_State";
            this.Text = "CRUD_State";
            this.Load += new System.EventHandler(this.CRUD_State_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingNavigator)).EndInit();
            this.estadoSetBindingNavigator.ResumeLayout(false);
            this.estadoSetBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestauranteDataSet3 restauranteDataSet3;
        private System.Windows.Forms.BindingSource estadoSetBindingSource;
        private RestauranteDataSet3TableAdapters.EstadoSetTableAdapter estadoSetTableAdapter;
        private RestauranteDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator estadoSetBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton estadoSetBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Button btnBack;
    }
}