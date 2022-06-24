namespace Projeto_DA_Restaurante
{
    partial class CRUD_MetodoPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_MetodoPagamento));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label metoPagamentoLabel;
            System.Windows.Forms.Label ativoLabel;
            this.restauranteDataSet1 = new Projeto_DA_Restaurante.RestauranteDataSet1();
            this.metodoPagamentoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metodoPagamentoSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.MetodoPagamentoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.TableAdapterManager();
            this.metodoPagamentoSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.metodoPagamentoSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.metoPagamentoTextBox = new System.Windows.Forms.TextBox();
            this.ativoTextBox = new System.Windows.Forms.TextBox();
            this.btnMetodo = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            metoPagamentoLabel = new System.Windows.Forms.Label();
            ativoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingNavigator)).BeginInit();
            this.metodoPagamentoSetBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // restauranteDataSet1
            // 
            this.restauranteDataSet1.DataSetName = "RestauranteDataSet1";
            this.restauranteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metodoPagamentoSetBindingSource
            // 
            this.metodoPagamentoSetBindingSource.DataMember = "MetodoPagamentoSet";
            this.metodoPagamentoSetBindingSource.DataSource = this.restauranteDataSet1;
            // 
            // metodoPagamentoSetTableAdapter
            // 
            this.metodoPagamentoSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaSetTableAdapter = null;
            this.tableAdapterManager.EstadoSetTableAdapter = null;
            this.tableAdapterManager.ItemMenuSetTableAdapter = null;
            this.tableAdapterManager.MetodoPagamentoSetTableAdapter = this.metodoPagamentoSetTableAdapter;
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
            // metodoPagamentoSetBindingNavigator
            // 
            this.metodoPagamentoSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.metodoPagamentoSetBindingNavigator.BindingSource = this.metodoPagamentoSetBindingSource;
            this.metodoPagamentoSetBindingNavigator.CountItem = null;
            this.metodoPagamentoSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.metodoPagamentoSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.metodoPagamentoSetBindingNavigatorSaveItem});
            this.metodoPagamentoSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.metodoPagamentoSetBindingNavigator.MoveFirstItem = null;
            this.metodoPagamentoSetBindingNavigator.MoveLastItem = null;
            this.metodoPagamentoSetBindingNavigator.MoveNextItem = null;
            this.metodoPagamentoSetBindingNavigator.MovePreviousItem = null;
            this.metodoPagamentoSetBindingNavigator.Name = "metodoPagamentoSetBindingNavigator";
            this.metodoPagamentoSetBindingNavigator.PositionItem = null;
            this.metodoPagamentoSetBindingNavigator.Size = new System.Drawing.Size(774, 25);
            this.metodoPagamentoSetBindingNavigator.TabIndex = 0;
            this.metodoPagamentoSetBindingNavigator.Text = "bindingNavigator1";
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
            // metodoPagamentoSetBindingNavigatorSaveItem
            // 
            this.metodoPagamentoSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.metodoPagamentoSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("metodoPagamentoSetBindingNavigatorSaveItem.Image")));
            this.metodoPagamentoSetBindingNavigatorSaveItem.Name = "metodoPagamentoSetBindingNavigatorSaveItem";
            this.metodoPagamentoSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.metodoPagamentoSetBindingNavigatorSaveItem.Text = "Save Data";
            this.metodoPagamentoSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.metodoPagamentoSetBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(37, 65);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(35, 25);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.metodoPagamentoSetBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(248, 62);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(182, 31);
            this.idTextBox.TabIndex = 2;
            // 
            // metoPagamentoLabel
            // 
            metoPagamentoLabel.AutoSize = true;
            metoPagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            metoPagamentoLabel.Location = new System.Drawing.Point(37, 102);
            metoPagamentoLabel.Name = "metoPagamentoLabel";
            metoPagamentoLabel.Size = new System.Drawing.Size(205, 25);
            metoPagamentoLabel.TabIndex = 3;
            metoPagamentoLabel.Text = "Metodo Pagamento:";
            // 
            // metoPagamentoTextBox
            // 
            this.metoPagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.metodoPagamentoSetBindingSource, "MetoPagamento", true));
            this.metoPagamentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metoPagamentoTextBox.Location = new System.Drawing.Point(248, 99);
            this.metoPagamentoTextBox.Name = "metoPagamentoTextBox";
            this.metoPagamentoTextBox.Size = new System.Drawing.Size(182, 31);
            this.metoPagamentoTextBox.TabIndex = 4;
            this.metoPagamentoTextBox.TextChanged += new System.EventHandler(this.metoPagamentoTextBox_TextChanged);
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ativoLabel.Location = new System.Drawing.Point(37, 139);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(66, 25);
            ativoLabel.TabIndex = 5;
            ativoLabel.Text = "Ativo:";
            // 
            // ativoTextBox
            // 
            this.ativoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.metodoPagamentoSetBindingSource, "Ativo", true));
            this.ativoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ativoTextBox.Location = new System.Drawing.Point(248, 136);
            this.ativoTextBox.Name = "ativoTextBox";
            this.ativoTextBox.Size = new System.Drawing.Size(182, 31);
            this.ativoTextBox.TabIndex = 6;
            // 
            // btnMetodo
            // 
            this.btnMetodo.Location = new System.Drawing.Point(640, 184);
            this.btnMetodo.Name = "btnMetodo";
            this.btnMetodo.Size = new System.Drawing.Size(122, 59);
            this.btnMetodo.TabIndex = 12;
            this.btnMetodo.Text = "Concluir";
            this.btnMetodo.UseVisualStyleBackColor = true;
            this.btnMetodo.Click += new System.EventHandler(this.btnMetodo_Click);
            // 
            // CRUD_MetodoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 255);
            this.Controls.Add(this.btnMetodo);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(metoPagamentoLabel);
            this.Controls.Add(this.metoPagamentoTextBox);
            this.Controls.Add(ativoLabel);
            this.Controls.Add(this.ativoTextBox);
            this.Controls.Add(this.metodoPagamentoSetBindingNavigator);
            this.Name = "CRUD_MetodoPagamento";
            this.Text = "CRUD_MetodoPagamento";
            this.Load += new System.EventHandler(this.CRUD_MetodoPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingNavigator)).EndInit();
            this.metodoPagamentoSetBindingNavigator.ResumeLayout(false);
            this.metodoPagamentoSetBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestauranteDataSet1 restauranteDataSet1;
        private System.Windows.Forms.BindingSource metodoPagamentoSetBindingSource;
        private RestauranteDataSet1TableAdapters.MetodoPagamentoSetTableAdapter metodoPagamentoSetTableAdapter;
        private RestauranteDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator metodoPagamentoSetBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton metodoPagamentoSetBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox metoPagamentoTextBox;
        private System.Windows.Forms.TextBox ativoTextBox;
        private System.Windows.Forms.Button btnMetodo;
    }
}