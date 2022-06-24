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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_Categoria));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label ativoLabel;
            this.restauranteDataSet1 = new Projeto_DA_Restaurante.RestauranteDataSet1();
            this.categoriaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.CategoriaSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.TableAdapterManager();
            this.categoriaSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.categoriaSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.ativoTextBox = new System.Windows.Forms.TextBox();
            this.btnCategoria = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ativoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingNavigator)).BeginInit();
            this.categoriaSetBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // restauranteDataSet1
            // 
            this.restauranteDataSet1.DataSetName = "RestauranteDataSet1";
            this.restauranteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaSetBindingSource
            // 
            this.categoriaSetBindingSource.DataMember = "CategoriaSet";
            this.categoriaSetBindingSource.DataSource = this.restauranteDataSet1;
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
            this.tableAdapterManager.PagamentoSetTableAdapter = null;
            this.tableAdapterManager.PedidoItemMenuTableAdapter = null;
            this.tableAdapterManager.PedidoSetTableAdapter = null;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_TrabalhadorTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.RestauranteItemMenuTableAdapter = null;
            this.tableAdapterManager.RestauranteSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriaSetBindingNavigator
            // 
            this.categoriaSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.categoriaSetBindingNavigator.BindingSource = this.categoriaSetBindingSource;
            this.categoriaSetBindingNavigator.CountItem = null;
            this.categoriaSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.categoriaSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.categoriaSetBindingNavigatorSaveItem});
            this.categoriaSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.categoriaSetBindingNavigator.MoveFirstItem = null;
            this.categoriaSetBindingNavigator.MoveLastItem = null;
            this.categoriaSetBindingNavigator.MoveNextItem = null;
            this.categoriaSetBindingNavigator.MovePreviousItem = null;
            this.categoriaSetBindingNavigator.Name = "categoriaSetBindingNavigator";
            this.categoriaSetBindingNavigator.PositionItem = null;
            this.categoriaSetBindingNavigator.Size = new System.Drawing.Size(774, 25);
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
            // categoriaSetBindingNavigatorSaveItem
            // 
            this.categoriaSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoriaSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriaSetBindingNavigatorSaveItem.Image")));
            this.categoriaSetBindingNavigatorSaveItem.Name = "categoriaSetBindingNavigatorSaveItem";
            this.categoriaSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.categoriaSetBindingNavigatorSaveItem.Text = "Save Data";
            this.categoriaSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.categoriaSetBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(96, 55);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(35, 25);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaSetBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(176, 49);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(207, 31);
            this.idTextBox.TabIndex = 2;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(96, 89);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(74, 25);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaSetBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(176, 86);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(207, 31);
            this.nomeTextBox.TabIndex = 4;
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ativoLabel.Location = new System.Drawing.Point(96, 126);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(66, 25);
            ativoLabel.TabIndex = 5;
            ativoLabel.Text = "Ativo:";
            // 
            // ativoTextBox
            // 
            this.ativoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaSetBindingSource, "Ativo", true));
            this.ativoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ativoTextBox.Location = new System.Drawing.Point(176, 123);
            this.ativoTextBox.Name = "ativoTextBox";
            this.ativoTextBox.Size = new System.Drawing.Size(207, 31);
            this.ativoTextBox.TabIndex = 6;
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(638, 193);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(124, 50);
            this.btnCategoria.TabIndex = 11;
            this.btnCategoria.Text = "Concluir";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // CRUD_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 255);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(ativoLabel);
            this.Controls.Add(this.ativoTextBox);
            this.Controls.Add(this.categoriaSetBindingNavigator);
            this.Name = "CRUD_Categoria";
            this.Text = "CRUD_Categoria";
            this.Load += new System.EventHandler(this.CRUD_Categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingNavigator)).EndInit();
            this.categoriaSetBindingNavigator.ResumeLayout(false);
            this.categoriaSetBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestauranteDataSet1 restauranteDataSet1;
        private System.Windows.Forms.BindingSource categoriaSetBindingSource;
        private RestauranteDataSet1TableAdapters.CategoriaSetTableAdapter categoriaSetTableAdapter;
        private RestauranteDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator categoriaSetBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton categoriaSetBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox ativoTextBox;
        private System.Windows.Forms.Button btnCategoria;
    }
}