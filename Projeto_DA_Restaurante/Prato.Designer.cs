namespace Projeto_DA_Restaurante
{
    partial class Prato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prato));
            System.Windows.Forms.Label pedido_IdLabel;
            System.Windows.Forms.Label itemMenu_IdLabel;
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.restauranteDataSet3 = new Projeto_DA_Restaurante.RestauranteDataSet3();
            this.pedidoItemMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoItemMenuTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.PedidoItemMenuTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager();
            this.pedidoItemMenuBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pedidoItemMenuBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pedido_IdComboBox = new System.Windows.Forms.ComboBox();
            this.itemMenu_IdComboBox = new System.Windows.Forms.ComboBox();
            pedido_IdLabel = new System.Windows.Forms.Label();
            itemMenu_IdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoItemMenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoItemMenuBindingNavigator)).BeginInit();
            this.pedidoItemMenuBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            // restauranteDataSet3
            // 
            this.restauranteDataSet3.DataSetName = "RestauranteDataSet3";
            this.restauranteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoItemMenuBindingSource
            // 
            this.pedidoItemMenuBindingSource.DataMember = "PedidoItemMenu";
            this.pedidoItemMenuBindingSource.DataSource = this.restauranteDataSet3;
            // 
            // pedidoItemMenuTableAdapter
            // 
            this.pedidoItemMenuTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PedidoItemMenuTableAdapter = this.pedidoItemMenuTableAdapter;
            this.tableAdapterManager.PedidoSetTableAdapter = null;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_TrabalhadorTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.RestauranteItemMenuTableAdapter = null;
            this.tableAdapterManager.RestauranteSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pedidoItemMenuBindingNavigator
            // 
            this.pedidoItemMenuBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pedidoItemMenuBindingNavigator.BindingSource = this.pedidoItemMenuBindingSource;
            this.pedidoItemMenuBindingNavigator.CountItem = null;
            this.pedidoItemMenuBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pedidoItemMenuBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pedidoItemMenuBindingNavigatorSaveItem});
            this.pedidoItemMenuBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pedidoItemMenuBindingNavigator.MoveFirstItem = null;
            this.pedidoItemMenuBindingNavigator.MoveLastItem = null;
            this.pedidoItemMenuBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pedidoItemMenuBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pedidoItemMenuBindingNavigator.Name = "pedidoItemMenuBindingNavigator";
            this.pedidoItemMenuBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pedidoItemMenuBindingNavigator.Size = new System.Drawing.Size(333, 25);
            this.pedidoItemMenuBindingNavigator.TabIndex = 11;
            this.pedidoItemMenuBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // pedidoItemMenuBindingNavigatorSaveItem
            // 
            this.pedidoItemMenuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pedidoItemMenuBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pedidoItemMenuBindingNavigatorSaveItem.Image")));
            this.pedidoItemMenuBindingNavigatorSaveItem.Name = "pedidoItemMenuBindingNavigatorSaveItem";
            this.pedidoItemMenuBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pedidoItemMenuBindingNavigatorSaveItem.Text = "Save Data";
            this.pedidoItemMenuBindingNavigatorSaveItem.Click += new System.EventHandler(this.pedidoItemMenuBindingNavigatorSaveItem_Click_1);
            // 
            // pedido_IdLabel
            // 
            pedido_IdLabel.AutoSize = true;
            pedido_IdLabel.Location = new System.Drawing.Point(59, 55);
            pedido_IdLabel.Name = "pedido_IdLabel";
            pedido_IdLabel.Size = new System.Drawing.Size(55, 13);
            pedido_IdLabel.TabIndex = 11;
            pedido_IdLabel.Text = "Pedido Id:";
            // 
            // pedido_IdComboBox
            // 
            this.pedido_IdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoItemMenuBindingSource, "Pedido_Id", true));
            this.pedido_IdComboBox.FormattingEnabled = true;
            this.pedido_IdComboBox.Location = new System.Drawing.Point(137, 52);
            this.pedido_IdComboBox.Name = "pedido_IdComboBox";
            this.pedido_IdComboBox.Size = new System.Drawing.Size(121, 21);
            this.pedido_IdComboBox.TabIndex = 12;
            // 
            // itemMenu_IdLabel
            // 
            itemMenu_IdLabel.AutoSize = true;
            itemMenu_IdLabel.Location = new System.Drawing.Point(59, 82);
            itemMenu_IdLabel.Name = "itemMenu_IdLabel";
            itemMenu_IdLabel.Size = new System.Drawing.Size(72, 13);
            itemMenu_IdLabel.TabIndex = 13;
            itemMenu_IdLabel.Text = "Item Menu Id:";
            // 
            // itemMenu_IdComboBox
            // 
            this.itemMenu_IdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoItemMenuBindingSource, "ItemMenu_Id", true));
            this.itemMenu_IdComboBox.FormattingEnabled = true;
            this.itemMenu_IdComboBox.Location = new System.Drawing.Point(137, 79);
            this.itemMenu_IdComboBox.Name = "itemMenu_IdComboBox";
            this.itemMenu_IdComboBox.Size = new System.Drawing.Size(121, 21);
            this.itemMenu_IdComboBox.TabIndex = 14;
            this.itemMenu_IdComboBox.SelectedIndexChanged += new System.EventHandler(this.itemMenu_IdComboBox_SelectedIndexChanged);
            // 
            // Prato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 200);
            this.Controls.Add(pedido_IdLabel);
            this.Controls.Add(this.pedido_IdComboBox);
            this.Controls.Add(itemMenu_IdLabel);
            this.Controls.Add(this.itemMenu_IdComboBox);
            this.Controls.Add(this.pedidoItemMenuBindingNavigator);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConcluir);
            this.Name = "Prato";
            this.Text = "Prato";
            this.Load += new System.EventHandler(this.Prato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoItemMenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoItemMenuBindingNavigator)).EndInit();
            this.pedidoItemMenuBindingNavigator.ResumeLayout(false);
            this.pedidoItemMenuBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Button btnBack;
        private RestauranteDataSet3 restauranteDataSet3;
        private System.Windows.Forms.BindingSource pedidoItemMenuBindingSource;
        private RestauranteDataSet3TableAdapters.PedidoItemMenuTableAdapter pedidoItemMenuTableAdapter;
        private RestauranteDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pedidoItemMenuBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pedidoItemMenuBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox pedido_IdComboBox;
        private System.Windows.Forms.ComboBox itemMenu_IdComboBox;
    }
}