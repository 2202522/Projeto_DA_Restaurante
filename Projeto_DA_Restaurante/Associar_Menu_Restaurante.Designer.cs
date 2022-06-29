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
            this.restauranteDataSet3 = new Projeto_DA_Restaurante.RestauranteDataSet3();
            this.restauranteItemMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteItemMenuTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.RestauranteItemMenuTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager();
            this.restauranteItemMenuBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.restaurante_IdTextBox = new System.Windows.Forms.TextBox();
            this.itemMenu_IdTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.restauranteItemMenuBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            restaurante_IdLabel = new System.Windows.Forms.Label();
            itemMenu_IdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteItemMenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteItemMenuBindingNavigator)).BeginInit();
            this.restauranteItemMenuBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            this.tableAdapterManager.ItemMenuSetTableAdapter = null;
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
            // restauranteItemMenuBindingNavigator
            // 
            this.restauranteItemMenuBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.restauranteItemMenuBindingNavigator.BindingSource = this.restauranteItemMenuBindingSource;
            this.restauranteItemMenuBindingNavigator.CountItem = null;
            this.restauranteItemMenuBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.restauranteItemMenuBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.restauranteItemMenuBindingNavigatorSaveItem});
            this.restauranteItemMenuBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.restauranteItemMenuBindingNavigator.MoveFirstItem = null;
            this.restauranteItemMenuBindingNavigator.MoveLastItem = null;
            this.restauranteItemMenuBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.restauranteItemMenuBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.restauranteItemMenuBindingNavigator.Name = "restauranteItemMenuBindingNavigator";
            this.restauranteItemMenuBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.restauranteItemMenuBindingNavigator.Size = new System.Drawing.Size(330, 25);
            this.restauranteItemMenuBindingNavigator.TabIndex = 0;
            this.restauranteItemMenuBindingNavigator.Text = "bindingNavigator1";
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
            // restaurante_IdLabel
            // 
            restaurante_IdLabel.AutoSize = true;
            restaurante_IdLabel.Location = new System.Drawing.Point(60, 63);
            restaurante_IdLabel.Name = "restaurante_IdLabel";
            restaurante_IdLabel.Size = new System.Drawing.Size(80, 13);
            restaurante_IdLabel.TabIndex = 1;
            restaurante_IdLabel.Text = "Restaurante Id:";
            // 
            // restaurante_IdTextBox
            // 
            this.restaurante_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restauranteItemMenuBindingSource, "Restaurante_Id", true));
            this.restaurante_IdTextBox.Location = new System.Drawing.Point(146, 60);
            this.restaurante_IdTextBox.Name = "restaurante_IdTextBox";
            this.restaurante_IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.restaurante_IdTextBox.TabIndex = 2;
            // 
            // itemMenu_IdLabel
            // 
            itemMenu_IdLabel.AutoSize = true;
            itemMenu_IdLabel.Location = new System.Drawing.Point(60, 89);
            itemMenu_IdLabel.Name = "itemMenu_IdLabel";
            itemMenu_IdLabel.Size = new System.Drawing.Size(72, 13);
            itemMenu_IdLabel.TabIndex = 3;
            itemMenu_IdLabel.Text = "Item Menu Id:";
            // 
            // itemMenu_IdTextBox
            // 
            this.itemMenu_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restauranteItemMenuBindingSource, "ItemMenu_Id", true));
            this.itemMenu_IdTextBox.Location = new System.Drawing.Point(146, 86);
            this.itemMenu_IdTextBox.Name = "itemMenu_IdTextBox";
            this.itemMenu_IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemMenu_IdTextBox.TabIndex = 4;
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
            // restauranteItemMenuBindingNavigatorSaveItem
            // 
            this.restauranteItemMenuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.restauranteItemMenuBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("restauranteItemMenuBindingNavigatorSaveItem.Image")));
            this.restauranteItemMenuBindingNavigatorSaveItem.Name = "restauranteItemMenuBindingNavigatorSaveItem";
            this.restauranteItemMenuBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.restauranteItemMenuBindingNavigatorSaveItem.Text = "Save Data";
            this.restauranteItemMenuBindingNavigatorSaveItem.Click += new System.EventHandler(this.restauranteItemMenuBindingNavigatorSaveItem_Click);
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
            // Associar_Menu_Restaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 192);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(restaurante_IdLabel);
            this.Controls.Add(this.restaurante_IdTextBox);
            this.Controls.Add(itemMenu_IdLabel);
            this.Controls.Add(this.itemMenu_IdTextBox);
            this.Controls.Add(this.restauranteItemMenuBindingNavigator);
            this.Name = "Associar_Menu_Restaurante";
            this.Text = "Associar_Menu_Restaurante";
            this.Load += new System.EventHandler(this.Associar_Menu_Restaurante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteItemMenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteItemMenuBindingNavigator)).EndInit();
            this.restauranteItemMenuBindingNavigator.ResumeLayout(false);
            this.restauranteItemMenuBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestauranteDataSet3 restauranteDataSet3;
        private System.Windows.Forms.BindingSource restauranteItemMenuBindingSource;
        private RestauranteDataSet3TableAdapters.RestauranteItemMenuTableAdapter restauranteItemMenuTableAdapter;
        private RestauranteDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator restauranteItemMenuBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton restauranteItemMenuBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox restaurante_IdTextBox;
        private System.Windows.Forms.TextBox itemMenu_IdTextBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConcluir;
    }
}