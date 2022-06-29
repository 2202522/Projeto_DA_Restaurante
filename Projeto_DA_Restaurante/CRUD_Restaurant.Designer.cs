namespace Projeto_DA_Restaurante
{
    partial class CRUD_Restaurant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_Restaurant));
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label restaurante_idLabel;
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.restauranteDataSet3 = new Projeto_DA_Restaurante.RestauranteDataSet3();
            this.restauranteSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.RestauranteSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager();
            this.restauranteSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.restauranteSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.restaurante_idTextBox = new System.Windows.Forms.TextBox();
            nomeLabel = new System.Windows.Forms.Label();
            restaurante_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingNavigator)).BeginInit();
            this.restauranteSetBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 140);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 8;
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
            this.btnConcluir.TabIndex = 9;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // restauranteDataSet3
            // 
            this.restauranteDataSet3.DataSetName = "RestauranteDataSet3";
            this.restauranteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restauranteSetBindingSource
            // 
            this.restauranteSetBindingSource.DataMember = "RestauranteSet";
            this.restauranteSetBindingSource.DataSource = this.restauranteDataSet3;
            // 
            // restauranteSetTableAdapter
            // 
            this.restauranteSetTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.RestauranteItemMenuTableAdapter = null;
            this.tableAdapterManager.RestauranteSetTableAdapter = this.restauranteSetTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // restauranteSetBindingNavigator
            // 
            this.restauranteSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.restauranteSetBindingNavigator.BindingSource = this.restauranteSetBindingSource;
            this.restauranteSetBindingNavigator.CountItem = null;
            this.restauranteSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.restauranteSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.restauranteSetBindingNavigatorSaveItem});
            this.restauranteSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.restauranteSetBindingNavigator.MoveFirstItem = null;
            this.restauranteSetBindingNavigator.MoveLastItem = null;
            this.restauranteSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.restauranteSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.restauranteSetBindingNavigator.Name = "restauranteSetBindingNavigator";
            this.restauranteSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.restauranteSetBindingNavigator.Size = new System.Drawing.Size(338, 25);
            this.restauranteSetBindingNavigator.TabIndex = 10;
            this.restauranteSetBindingNavigator.Text = "bindingNavigator1";
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
            // restauranteSetBindingNavigatorSaveItem
            // 
            this.restauranteSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.restauranteSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("restauranteSetBindingNavigatorSaveItem.Image")));
            this.restauranteSetBindingNavigatorSaveItem.Name = "restauranteSetBindingNavigatorSaveItem";
            this.restauranteSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.restauranteSetBindingNavigatorSaveItem.Text = "Save Data";
            this.restauranteSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.restauranteSetBindingNavigatorSaveItem_Click_1);
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(53, 58);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 12;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restauranteSetBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(138, 55);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 13;
            // 
            // restaurante_idLabel
            // 
            restaurante_idLabel.AutoSize = true;
            restaurante_idLabel.Location = new System.Drawing.Point(53, 84);
            restaurante_idLabel.Name = "restaurante_idLabel";
            restaurante_idLabel.Size = new System.Drawing.Size(60, 13);
            restaurante_idLabel.TabIndex = 14;
            restaurante_idLabel.Text = "ID Morada:";
            // 
            // restaurante_idTextBox
            // 
            this.restaurante_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restauranteSetBindingSource, "Restaurante_id", true));
            this.restaurante_idTextBox.Location = new System.Drawing.Point(138, 81);
            this.restaurante_idTextBox.Name = "restaurante_idTextBox";
            this.restaurante_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.restaurante_idTextBox.TabIndex = 15;
            // 
            // CRUD_Restaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 200);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(restaurante_idLabel);
            this.Controls.Add(this.restaurante_idTextBox);
            this.Controls.Add(this.restauranteSetBindingNavigator);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnBack);
            this.Name = "CRUD_Restaurant";
            this.Text = "CRUD_Restaurant";
            this.Load += new System.EventHandler(this.CRUD_Restaurant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingNavigator)).EndInit();
            this.restauranteSetBindingNavigator.ResumeLayout(false);
            this.restauranteSetBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConcluir;
        private RestauranteDataSet3 restauranteDataSet3;
        private System.Windows.Forms.BindingSource restauranteSetBindingSource;
        private RestauranteDataSet3TableAdapters.RestauranteSetTableAdapter restauranteSetTableAdapter;
        private RestauranteDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator restauranteSetBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton restauranteSetBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox restaurante_idTextBox;
    }
}