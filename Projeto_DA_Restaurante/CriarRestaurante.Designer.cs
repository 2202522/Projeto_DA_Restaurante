namespace Projeto_DA_Restaurante
{
    partial class CriarRestaurante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarRestaurante));
            this.btnCriarRestauranteView = new System.Windows.Forms.Button();
            this.restauranteDataSet1 = new Projeto_DA_Restaurante.RestauranteDataSet1();
            this.restauranteSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.RestauranteSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.TableAdapterManager();
            this.restauranteSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.restauranteSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingNavigator)).BeginInit();
            this.restauranteSetBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(30, 53);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(74, 25);
            nomeLabel.TabIndex = 5;
            nomeLabel.Text = "Nome:";
            // 
            // btnCriarRestauranteView
            // 
            this.btnCriarRestauranteView.Location = new System.Drawing.Point(281, 134);
            this.btnCriarRestauranteView.Name = "btnCriarRestauranteView";
            this.btnCriarRestauranteView.Size = new System.Drawing.Size(138, 45);
            this.btnCriarRestauranteView.TabIndex = 2;
            this.btnCriarRestauranteView.Text = "Concluir";
            this.btnCriarRestauranteView.UseVisualStyleBackColor = true;
            this.btnCriarRestauranteView.Click += new System.EventHandler(this.btnCriarRestauranteView_Click);
            // 
            // restauranteDataSet1
            // 
            this.restauranteDataSet1.DataSetName = "RestauranteDataSet1";
            this.restauranteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restauranteSetBindingSource
            // 
            this.restauranteSetBindingSource.DataMember = "RestauranteSet";
            this.restauranteSetBindingSource.DataSource = this.restauranteDataSet1;
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
            this.tableAdapterManager.PagamentoSetTableAdapter = null;
            this.tableAdapterManager.PedidoItemMenuTableAdapter = null;
            this.tableAdapterManager.PedidoSetTableAdapter = null;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_TrabalhadorTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.RestauranteItemMenuTableAdapter = null;
            this.tableAdapterManager.RestauranteSetTableAdapter = this.restauranteSetTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // restauranteSetBindingNavigator
            // 
            this.restauranteSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.restauranteSetBindingNavigator.BindingSource = this.restauranteSetBindingSource;
            this.restauranteSetBindingNavigator.CountItem = null;
            this.restauranteSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.restauranteSetBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restauranteSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.restauranteSetBindingNavigatorSaveItem});
            this.restauranteSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.restauranteSetBindingNavigator.MoveFirstItem = null;
            this.restauranteSetBindingNavigator.MoveLastItem = null;
            this.restauranteSetBindingNavigator.MoveNextItem = null;
            this.restauranteSetBindingNavigator.MovePreviousItem = null;
            this.restauranteSetBindingNavigator.Name = "restauranteSetBindingNavigator";
            this.restauranteSetBindingNavigator.PositionItem = null;
            this.restauranteSetBindingNavigator.Size = new System.Drawing.Size(436, 25);
            this.restauranteSetBindingNavigator.TabIndex = 3;
            this.restauranteSetBindingNavigator.Text = "bindingNavigator1";
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
            // restauranteSetBindingNavigatorSaveItem
            // 
            this.restauranteSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.restauranteSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("restauranteSetBindingNavigatorSaveItem.Image")));
            this.restauranteSetBindingNavigatorSaveItem.Name = "restauranteSetBindingNavigatorSaveItem";
            this.restauranteSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.restauranteSetBindingNavigatorSaveItem.Text = "Save Data";
            this.restauranteSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.restauranteSetBindingNavigatorSaveItem_Click_1);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restauranteSetBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(110, 53);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(202, 31);
            this.nomeTextBox.TabIndex = 6;
            // 
            // CriarRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 197);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.restauranteSetBindingNavigator);
            this.Controls.Add(this.btnCriarRestauranteView);
            this.Name = "CriarRestaurante";
            this.Text = "CriarRestaurante";
            this.Load += new System.EventHandler(this.CriarRestaurante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingNavigator)).EndInit();
            this.restauranteSetBindingNavigator.ResumeLayout(false);
            this.restauranteSetBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarRestauranteView;
        private RestauranteDataSet1 restauranteDataSet1;
        private System.Windows.Forms.BindingSource restauranteSetBindingSource;
        private RestauranteDataSet1TableAdapters.RestauranteSetTableAdapter restauranteSetTableAdapter;
        private RestauranteDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator restauranteSetBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton restauranteSetBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nomeTextBox;
    }
}