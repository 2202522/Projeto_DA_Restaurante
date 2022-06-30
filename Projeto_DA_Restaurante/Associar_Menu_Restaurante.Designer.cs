namespace Projeto_DA_Restaurante
{
    partial class Associar_Menu_Restaurante
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
            System.Windows.Forms.Label restaurante_IdLabel;
            System.Windows.Forms.Label itemMenu_IdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Associar_Menu_Restaurante));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.restauranteDataSet3 = new Projeto_DA_Restaurante.RestauranteDataSet3();
            this.restauranteItemMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteItemMenuTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.RestauranteItemMenuTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager();
            this.itemMenuSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.ItemMenuSetTableAdapter();
            this.restauranteItemMenuBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.restauranteItemMenuBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.restaurante_IdTextBox = new System.Windows.Forms.TextBox();
            this.itemMenu_IdComboBox = new System.Windows.Forms.ComboBox();
            this.itemMenuSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            restaurante_IdLabel = new System.Windows.Forms.Label();
            itemMenu_IdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteItemMenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteItemMenuBindingNavigator)).BeginInit();
            this.restauranteItemMenuBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemMenuSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // restaurante_IdLabel
            // 
            restaurante_IdLabel.AutoSize = true;
            restaurante_IdLabel.Location = new System.Drawing.Point(57, 59);
            restaurante_IdLabel.Name = "restaurante_IdLabel";
            restaurante_IdLabel.Size = new System.Drawing.Size(80, 13);
            restaurante_IdLabel.TabIndex = 19;
            restaurante_IdLabel.Text = "Restaurante Id:";
            // 
            // itemMenu_IdLabel
            // 
            itemMenu_IdLabel.AutoSize = true;
            itemMenu_IdLabel.Location = new System.Drawing.Point(57, 85);
            itemMenu_IdLabel.Name = "itemMenu_IdLabel";
            itemMenu_IdLabel.Size = new System.Drawing.Size(72, 13);
            itemMenu_IdLabel.TabIndex = 21;
            itemMenu_IdLabel.Text = "Item Menu Id:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 140);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConcluir
            // 
            this.btnConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Location = new System.Drawing.Point(228, 140);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(90, 40);
            this.btnConcluir.TabIndex = 18;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // restauranteDataSet3
            // 
            this.restauranteDataSet3.DataSetName = "RestauranteDataSet3";
            this.restauranteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restauranteItemMenuBindingSource
            // 
            this.restauranteItemMenuBindingSource.DataMember = "RestauranteItemMenu";
            this.restauranteItemMenuBindingSource.DataSource = this.restauranteDataSet3;
            // 
            // restauranteItemMenuTableAdapter
            // 
            this.restauranteItemMenuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaSetTableAdapter = null;
            this.tableAdapterManager.EstadoSetTableAdapter = null;
            this.tableAdapterManager.ItemMenuSetTableAdapter = this.itemMenuSetTableAdapter;
            this.tableAdapterManager.MetodoPagamentoSetTableAdapter = null;
            this.tableAdapterManager.MoradaSetTableAdapter = null;
            this.tableAdapterManager.PagamentoSetTableAdapter = null;
            this.tableAdapterManager.PedidoItemMenuTableAdapter = null;
            this.tableAdapterManager.PedidoSetTableAdapter = null;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_TrabalhadorTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.RestauranteItemMenuTableAdapter = this.restauranteItemMenuTableAdapter;
            this.tableAdapterManager.RestauranteSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemMenuSetTableAdapter
            // 
            this.itemMenuSetTableAdapter.ClearBeforeFill = true;
            // 
            // restauranteItemMenuBindingNavigator
            // 
            this.restauranteItemMenuBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.restauranteItemMenuBindingNavigator.BindingSource = this.restauranteItemMenuBindingSource;
            this.restauranteItemMenuBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.restauranteItemMenuBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.restauranteItemMenuBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.restauranteItemMenuBindingNavigatorSaveItem});
            this.restauranteItemMenuBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.restauranteItemMenuBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.restauranteItemMenuBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.restauranteItemMenuBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.restauranteItemMenuBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.restauranteItemMenuBindingNavigator.Name = "restauranteItemMenuBindingNavigator";
            this.restauranteItemMenuBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.restauranteItemMenuBindingNavigator.Size = new System.Drawing.Size(338, 25);
            this.restauranteItemMenuBindingNavigator.TabIndex = 19;
            this.restauranteItemMenuBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // restauranteItemMenuBindingNavigatorSaveItem
            // 
            this.restauranteItemMenuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.restauranteItemMenuBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("restauranteItemMenuBindingNavigatorSaveItem.Image")));
            this.restauranteItemMenuBindingNavigatorSaveItem.Name = "restauranteItemMenuBindingNavigatorSaveItem";
            this.restauranteItemMenuBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.restauranteItemMenuBindingNavigatorSaveItem.Text = "Save Data";
            this.restauranteItemMenuBindingNavigatorSaveItem.Click += new System.EventHandler(this.restauranteItemMenuBindingNavigatorSaveItem_Click);
            // 
            // restaurante_IdTextBox
            // 
            this.restaurante_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restauranteItemMenuBindingSource, "Restaurante_Id", true));
            this.restaurante_IdTextBox.Location = new System.Drawing.Point(143, 56);
            this.restaurante_IdTextBox.Name = "restaurante_IdTextBox";
            this.restaurante_IdTextBox.Size = new System.Drawing.Size(121, 20);
            this.restaurante_IdTextBox.TabIndex = 20;
            // 
            // itemMenu_IdComboBox
            // 
            this.itemMenu_IdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restauranteItemMenuBindingSource, "ItemMenu_Id", true));
            this.itemMenu_IdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemMenuSetBindingSource, "Id", true));
            this.itemMenu_IdComboBox.DataSource = this.itemMenuSetBindingSource;
            this.itemMenu_IdComboBox.DisplayMember = "Nome";
            this.itemMenu_IdComboBox.FormattingEnabled = true;
            this.itemMenu_IdComboBox.Location = new System.Drawing.Point(143, 82);
            this.itemMenu_IdComboBox.Name = "itemMenu_IdComboBox";
            this.itemMenu_IdComboBox.Size = new System.Drawing.Size(121, 21);
            this.itemMenu_IdComboBox.TabIndex = 22;
            this.itemMenu_IdComboBox.ValueMember = "Id";
            // 
            // itemMenuSetBindingSource
            // 
            this.itemMenuSetBindingSource.DataMember = "ItemMenuSet";
            this.itemMenuSetBindingSource.DataSource = this.restauranteDataSet3;
            // 
            // Associar_Menu_Restaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 200);
            this.Controls.Add(restaurante_IdLabel);
            this.Controls.Add(this.restaurante_IdTextBox);
            this.Controls.Add(itemMenu_IdLabel);
            this.Controls.Add(this.itemMenu_IdComboBox);
            this.Controls.Add(this.restauranteItemMenuBindingNavigator);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnBack);
            this.Name = "Associar_Menu_Restaurante";
            this.Text = "Associar_Menu_Restaurante";
            this.Load += new System.EventHandler(this.Associar_Menu_Restaurante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteItemMenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteItemMenuBindingNavigator)).EndInit();
            this.restauranteItemMenuBindingNavigator.ResumeLayout(false);
            this.restauranteItemMenuBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemMenuSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConcluir;
        private RestauranteDataSet3 restauranteDataSet3;
        private System.Windows.Forms.BindingSource restauranteItemMenuBindingSource;
        private RestauranteDataSet3TableAdapters.RestauranteItemMenuTableAdapter restauranteItemMenuTableAdapter;
        private RestauranteDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator restauranteItemMenuBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton restauranteItemMenuBindingNavigatorSaveItem;
        private RestauranteDataSet3TableAdapters.ItemMenuSetTableAdapter itemMenuSetTableAdapter;
        private System.Windows.Forms.TextBox restaurante_IdTextBox;
        private System.Windows.Forms.ComboBox itemMenu_IdComboBox;
        private System.Windows.Forms.BindingSource itemMenuSetBindingSource;
    }
}