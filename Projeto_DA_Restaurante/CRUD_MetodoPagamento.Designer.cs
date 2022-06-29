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
            System.Windows.Forms.Label metoPagamentoLabel;
            System.Windows.Forms.Label ativoLabel;
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.restauranteDataSet3 = new Projeto_DA_Restaurante.RestauranteDataSet3();
            this.metodoPagamentoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metodoPagamentoSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.MetodoPagamentoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager();
            this.metodoPagamentoSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.metodoPagamentoSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.metoPagamentoTextBox = new System.Windows.Forms.TextBox();
            this.ativoTextBox = new System.Windows.Forms.TextBox();
            metoPagamentoLabel = new System.Windows.Forms.Label();
            ativoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingNavigator)).BeginInit();
            this.metodoPagamentoSetBindingNavigator.SuspendLayout();
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
            // metodoPagamentoSetBindingSource
            // 
            this.metodoPagamentoSetBindingSource.DataMember = "MetodoPagamentoSet";
            this.metodoPagamentoSetBindingSource.DataSource = this.restauranteDataSet3;
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
            // metodoPagamentoSetBindingNavigator
            // 
            this.metodoPagamentoSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.metodoPagamentoSetBindingNavigator.BindingSource = this.metodoPagamentoSetBindingSource;
            this.metodoPagamentoSetBindingNavigator.CountItem = null;
            this.metodoPagamentoSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.metodoPagamentoSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.metodoPagamentoSetBindingNavigatorSaveItem});
            this.metodoPagamentoSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.metodoPagamentoSetBindingNavigator.MoveFirstItem = null;
            this.metodoPagamentoSetBindingNavigator.MoveLastItem = null;
            this.metodoPagamentoSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.metodoPagamentoSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.metodoPagamentoSetBindingNavigator.Name = "metodoPagamentoSetBindingNavigator";
            this.metodoPagamentoSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.metodoPagamentoSetBindingNavigator.Size = new System.Drawing.Size(338, 25);
            this.metodoPagamentoSetBindingNavigator.TabIndex = 10;
            this.metodoPagamentoSetBindingNavigator.Text = "bindingNavigator1";
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
            // metodoPagamentoSetBindingNavigatorSaveItem
            // 
            this.metodoPagamentoSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.metodoPagamentoSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("metodoPagamentoSetBindingNavigatorSaveItem.Image")));
            this.metodoPagamentoSetBindingNavigatorSaveItem.Name = "metodoPagamentoSetBindingNavigatorSaveItem";
            this.metodoPagamentoSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.metodoPagamentoSetBindingNavigatorSaveItem.Text = "Save Data";
            this.metodoPagamentoSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.metodoPagamentoSetBindingNavigatorSaveItem_Click);
            // 
            // metoPagamentoLabel
            // 
            metoPagamentoLabel.AutoSize = true;
            metoPagamentoLabel.Location = new System.Drawing.Point(53, 62);
            metoPagamentoLabel.Name = "metoPagamentoLabel";
            metoPagamentoLabel.Size = new System.Drawing.Size(91, 13);
            metoPagamentoLabel.TabIndex = 12;
            metoPagamentoLabel.Text = "Meto Pagamento:";
            // 
            // metoPagamentoTextBox
            // 
            this.metoPagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.metodoPagamentoSetBindingSource, "MetoPagamento", true));
            this.metoPagamentoTextBox.Location = new System.Drawing.Point(150, 59);
            this.metoPagamentoTextBox.Name = "metoPagamentoTextBox";
            this.metoPagamentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.metoPagamentoTextBox.TabIndex = 13;
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Location = new System.Drawing.Point(53, 88);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(34, 13);
            ativoLabel.TabIndex = 14;
            ativoLabel.Text = "Ativo:";
            // 
            // ativoTextBox
            // 
            this.ativoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.metodoPagamentoSetBindingSource, "Ativo", true));
            this.ativoTextBox.Location = new System.Drawing.Point(150, 85);
            this.ativoTextBox.Name = "ativoTextBox";
            this.ativoTextBox.Size = new System.Drawing.Size(100, 20);
            this.ativoTextBox.TabIndex = 15;
            // 
            // CRUD_MetodoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 200);
            this.Controls.Add(metoPagamentoLabel);
            this.Controls.Add(this.metoPagamentoTextBox);
            this.Controls.Add(ativoLabel);
            this.Controls.Add(this.ativoTextBox);
            this.Controls.Add(this.metodoPagamentoSetBindingNavigator);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnBack);
            this.Name = "CRUD_MetodoPagamento";
            this.Text = "CRUD_MetodoPagamento";
            this.Load += new System.EventHandler(this.CRUD_MetodoPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingNavigator)).EndInit();
            this.metodoPagamentoSetBindingNavigator.ResumeLayout(false);
            this.metodoPagamentoSetBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConcluir;
        private RestauranteDataSet3 restauranteDataSet3;
        private System.Windows.Forms.BindingSource metodoPagamentoSetBindingSource;
        private RestauranteDataSet3TableAdapters.MetodoPagamentoSetTableAdapter metodoPagamentoSetTableAdapter;
        private RestauranteDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator metodoPagamentoSetBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton metodoPagamentoSetBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox metoPagamentoTextBox;
        private System.Windows.Forms.TextBox ativoTextBox;
    }
}