namespace Projeto_DA_Restaurante
{
    partial class CRUD_Menu
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label fotografiaLabel;
            System.Windows.Forms.Label ingredientesLabel;
            System.Windows.Forms.Label precoLabel;
            System.Windows.Forms.Label ativoLabel;
            System.Windows.Forms.Label categoriaIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_Menu));
            this.restauranteDataSet1 = new Projeto_DA_Restaurante.RestauranteDataSet1();
            this.itemMenuSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemMenuSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.ItemMenuSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.TableAdapterManager();
            this.itemMenuSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.fotografiaTextBox = new System.Windows.Forms.TextBox();
            this.ingredientesTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.ativoTextBox = new System.Windows.Forms.TextBox();
            this.categoriaIdComboBox = new System.Windows.Forms.ComboBox();
            this.btConcluir = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.itemMenuSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            fotografiaLabel = new System.Windows.Forms.Label();
            ingredientesLabel = new System.Windows.Forms.Label();
            precoLabel = new System.Windows.Forms.Label();
            ativoLabel = new System.Windows.Forms.Label();
            categoriaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMenuSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMenuSetBindingNavigator)).BeginInit();
            this.itemMenuSetBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // restauranteDataSet1
            // 
            this.restauranteDataSet1.DataSetName = "RestauranteDataSet1";
            this.restauranteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemMenuSetBindingSource
            // 
            this.itemMenuSetBindingSource.DataMember = "ItemMenuSet";
            this.itemMenuSetBindingSource.DataSource = this.restauranteDataSet1;
            // 
            // itemMenuSetTableAdapter
            // 
            this.itemMenuSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaSetTableAdapter = null;
            this.tableAdapterManager.EstadoSetTableAdapter = null;
            this.tableAdapterManager.ItemMenuSetTableAdapter = this.itemMenuSetTableAdapter;
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
            // itemMenuSetBindingNavigator
            // 
            this.itemMenuSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.itemMenuSetBindingNavigator.BindingSource = this.itemMenuSetBindingSource;
            this.itemMenuSetBindingNavigator.CountItem = null;
            this.itemMenuSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.itemMenuSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.itemMenuSetBindingNavigatorSaveItem});
            this.itemMenuSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.itemMenuSetBindingNavigator.MoveFirstItem = null;
            this.itemMenuSetBindingNavigator.MoveLastItem = null;
            this.itemMenuSetBindingNavigator.MoveNextItem = null;
            this.itemMenuSetBindingNavigator.MovePreviousItem = null;
            this.itemMenuSetBindingNavigator.Name = "itemMenuSetBindingNavigator";
            this.itemMenuSetBindingNavigator.PositionItem = null;
            this.itemMenuSetBindingNavigator.Size = new System.Drawing.Size(695, 25);
            this.itemMenuSetBindingNavigator.TabIndex = 0;
            this.itemMenuSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(52, 53);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemMenuSetBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(160, 50);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(177, 26);
            this.idTextBox.TabIndex = 2;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(53, 98);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(55, 20);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemMenuSetBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(160, 95);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(177, 26);
            this.nomeTextBox.TabIndex = 4;
            // 
            // fotografiaLabel
            // 
            fotografiaLabel.AutoSize = true;
            fotografiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fotografiaLabel.Location = new System.Drawing.Point(52, 141);
            fotografiaLabel.Name = "fotografiaLabel";
            fotografiaLabel.Size = new System.Drawing.Size(86, 20);
            fotografiaLabel.TabIndex = 5;
            fotografiaLabel.Text = "Fotografia:";
            // 
            // fotografiaTextBox
            // 
            this.fotografiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemMenuSetBindingSource, "Fotografia", true));
            this.fotografiaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fotografiaTextBox.Location = new System.Drawing.Point(160, 138);
            this.fotografiaTextBox.Name = "fotografiaTextBox";
            this.fotografiaTextBox.Size = new System.Drawing.Size(177, 26);
            this.fotografiaTextBox.TabIndex = 6;
            this.fotografiaTextBox.TextChanged += new System.EventHandler(this.fotografiaTextBox_TextChanged);
            // 
            // ingredientesLabel
            // 
            ingredientesLabel.AutoSize = true;
            ingredientesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ingredientesLabel.Location = new System.Drawing.Point(52, 187);
            ingredientesLabel.Name = "ingredientesLabel";
            ingredientesLabel.Size = new System.Drawing.Size(102, 20);
            ingredientesLabel.TabIndex = 7;
            ingredientesLabel.Text = "Ingredientes:";
            // 
            // ingredientesTextBox
            // 
            this.ingredientesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemMenuSetBindingSource, "Ingredientes", true));
            this.ingredientesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientesTextBox.Location = new System.Drawing.Point(160, 184);
            this.ingredientesTextBox.Name = "ingredientesTextBox";
            this.ingredientesTextBox.Size = new System.Drawing.Size(177, 26);
            this.ingredientesTextBox.TabIndex = 8;
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precoLabel.Location = new System.Drawing.Point(354, 98);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new System.Drawing.Size(54, 20);
            precoLabel.TabIndex = 9;
            precoLabel.Text = "Preco:";
            // 
            // precoTextBox
            // 
            this.precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemMenuSetBindingSource, "Preco", true));
            this.precoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoTextBox.Location = new System.Drawing.Point(460, 95);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(177, 26);
            this.precoTextBox.TabIndex = 10;
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ativoLabel.Location = new System.Drawing.Point(354, 141);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(48, 20);
            ativoLabel.TabIndex = 11;
            ativoLabel.Text = "Ativo:";
            // 
            // ativoTextBox
            // 
            this.ativoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemMenuSetBindingSource, "Ativo", true));
            this.ativoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ativoTextBox.Location = new System.Drawing.Point(460, 138);
            this.ativoTextBox.Name = "ativoTextBox";
            this.ativoTextBox.Size = new System.Drawing.Size(177, 26);
            this.ativoTextBox.TabIndex = 12;
            // 
            // categoriaIdLabel
            // 
            categoriaIdLabel.AutoSize = true;
            categoriaIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoriaIdLabel.Location = new System.Drawing.Point(354, 187);
            categoriaIdLabel.Name = "categoriaIdLabel";
            categoriaIdLabel.Size = new System.Drawing.Size(100, 20);
            categoriaIdLabel.TabIndex = 13;
            categoriaIdLabel.Text = "Categoria Id:";
            // 
            // categoriaIdComboBox
            // 
            this.categoriaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemMenuSetBindingSource, "CategoriaId", true));
            this.categoriaIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaIdComboBox.FormattingEnabled = true;
            this.categoriaIdComboBox.Location = new System.Drawing.Point(460, 184);
            this.categoriaIdComboBox.Name = "categoriaIdComboBox";
            this.categoriaIdComboBox.Size = new System.Drawing.Size(177, 28);
            this.categoriaIdComboBox.TabIndex = 14;
            this.categoriaIdComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriaIdComboBox_SelectedIndexChanged);
            // 
            // btConcluir
            // 
            this.btConcluir.Location = new System.Drawing.Point(493, 246);
            this.btConcluir.Name = "btConcluir";
            this.btConcluir.Size = new System.Drawing.Size(144, 48);
            this.btConcluir.TabIndex = 15;
            this.btConcluir.Text = "Concluir";
            this.btConcluir.UseVisualStyleBackColor = true;
            this.btConcluir.Click += new System.EventHandler(this.btConcluir_Click);
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
            // itemMenuSetBindingNavigatorSaveItem
            // 
            this.itemMenuSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemMenuSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("itemMenuSetBindingNavigatorSaveItem.Image")));
            this.itemMenuSetBindingNavigatorSaveItem.Name = "itemMenuSetBindingNavigatorSaveItem";
            this.itemMenuSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.itemMenuSetBindingNavigatorSaveItem.Text = "Save Data";
            this.itemMenuSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.itemMenuSetBindingNavigatorSaveItem_Click_1);
            // 
            // CRUD_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 332);
            this.Controls.Add(this.btConcluir);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(fotografiaLabel);
            this.Controls.Add(this.fotografiaTextBox);
            this.Controls.Add(ingredientesLabel);
            this.Controls.Add(this.ingredientesTextBox);
            this.Controls.Add(precoLabel);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(ativoLabel);
            this.Controls.Add(this.ativoTextBox);
            this.Controls.Add(categoriaIdLabel);
            this.Controls.Add(this.categoriaIdComboBox);
            this.Controls.Add(this.itemMenuSetBindingNavigator);
            this.Name = "CRUD_Menu";
            this.Text = "CRUD_Menu";
            this.Load += new System.EventHandler(this.CRUD_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMenuSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMenuSetBindingNavigator)).EndInit();
            this.itemMenuSetBindingNavigator.ResumeLayout(false);
            this.itemMenuSetBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestauranteDataSet1 restauranteDataSet1;
        private System.Windows.Forms.BindingSource itemMenuSetBindingSource;
        private RestauranteDataSet1TableAdapters.ItemMenuSetTableAdapter itemMenuSetTableAdapter;
        private RestauranteDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator itemMenuSetBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton itemMenuSetBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox fotografiaTextBox;
        private System.Windows.Forms.TextBox ingredientesTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.TextBox ativoTextBox;
        private System.Windows.Forms.ComboBox categoriaIdComboBox;
        private System.Windows.Forms.Button btConcluir;
    }
}