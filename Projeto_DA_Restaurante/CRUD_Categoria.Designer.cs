namespace Projeto_DA_Restaurante
{
    partial class CRUD_Categoria
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label ativoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_Categoria));
            this.restauranteDataSet3 = new Projeto_DA_Restaurante.RestauranteDataSet3();
            this.categoriaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.CategoriaSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager();
            this.categoriaSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.categoriaSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.ativoTextBox = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            ativoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingNavigator)).BeginInit();
            this.categoriaSetBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(53, 61);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Location = new System.Drawing.Point(53, 87);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(34, 13);
            ativoLabel.TabIndex = 5;
            ativoLabel.Text = "Ativo:";
            // 
            // restauranteDataSet3
            // 
            this.restauranteDataSet3.DataSetName = "RestauranteDataSet3";
            this.restauranteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaSetBindingSource
            // 
            this.categoriaSetBindingSource.DataMember = "CategoriaSet";
            this.categoriaSetBindingSource.DataSource = this.restauranteDataSet3;
            // 
            // categoriaSetTableAdapter
            // 
            this.categoriaSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaSetTableAdapter = this.categoriaSetTableAdapter;
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
            this.tableAdapterManager.RestauranteSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriaSetBindingNavigator
            // 
            this.categoriaSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.categoriaSetBindingNavigator.BindingSource = this.categoriaSetBindingSource;
            this.categoriaSetBindingNavigator.CountItem = null;
            this.categoriaSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.categoriaSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.categoriaSetBindingNavigatorSaveItem});
            this.categoriaSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.categoriaSetBindingNavigator.MoveFirstItem = null;
            this.categoriaSetBindingNavigator.MoveLastItem = null;
            this.categoriaSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.categoriaSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.categoriaSetBindingNavigator.Name = "categoriaSetBindingNavigator";
            this.categoriaSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.categoriaSetBindingNavigator.Size = new System.Drawing.Size(330, 25);
            this.categoriaSetBindingNavigator.TabIndex = 0;
            this.categoriaSetBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // categoriaSetBindingNavigatorSaveItem
            // 
            this.categoriaSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoriaSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriaSetBindingNavigatorSaveItem.Image")));
            this.categoriaSetBindingNavigatorSaveItem.Name = "categoriaSetBindingNavigatorSaveItem";
            this.categoriaSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.categoriaSetBindingNavigatorSaveItem.Text = "Save Data";
            this.categoriaSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.categoriaSetBindingNavigatorSaveItem_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaSetBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(97, 58);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // ativoTextBox
            // 
            this.ativoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaSetBindingSource, "Ativo", true));
            this.ativoTextBox.Location = new System.Drawing.Point(97, 84);
            this.ativoTextBox.Name = "ativoTextBox";
            this.ativoTextBox.Size = new System.Drawing.Size(100, 20);
            this.ativoTextBox.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 140);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 7;
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
            this.btnConcluir.TabIndex = 8;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // CRUD_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 192);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(ativoLabel);
            this.Controls.Add(this.ativoTextBox);
            this.Controls.Add(this.categoriaSetBindingNavigator);
            this.Name = "CRUD_Categoria";
            this.Text = "CRUD_Categoria";
            this.Load += new System.EventHandler(this.CRUD_Categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingNavigator)).EndInit();
            this.categoriaSetBindingNavigator.ResumeLayout(false);
            this.categoriaSetBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestauranteDataSet3 restauranteDataSet3;
        private System.Windows.Forms.BindingSource categoriaSetBindingSource;
        private RestauranteDataSet3TableAdapters.CategoriaSetTableAdapter categoriaSetTableAdapter;
        private RestauranteDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator categoriaSetBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton categoriaSetBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox ativoTextBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConcluir;
    }
}