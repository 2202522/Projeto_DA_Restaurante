namespace Projeto_DA_Restaurante
{
    partial class EfetuarPagamento
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
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label metodoPagamentoIdLabel;
            System.Windows.Forms.Label pedidoIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EfetuarPagamento));
            this.restauranteDataSet3 = new Projeto_DA_Restaurante.RestauranteDataSet3();
            this.pagamentoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagamentoSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.PagamentoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager();
            this.pagamentoSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.metodoPagamentoIdComboBox = new System.Windows.Forms.ComboBox();
            this.pedidoIdComboBox = new System.Windows.Forms.ComboBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.pagamentoSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            valorLabel = new System.Windows.Forms.Label();
            metodoPagamentoIdLabel = new System.Windows.Forms.Label();
            pedidoIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoSetBindingNavigator)).BeginInit();
            this.pagamentoSetBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // restauranteDataSet3
            // 
            this.restauranteDataSet3.DataSetName = "RestauranteDataSet3";
            this.restauranteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pagamentoSetBindingSource
            // 
            this.pagamentoSetBindingSource.DataMember = "PagamentoSet";
            this.pagamentoSetBindingSource.DataSource = this.restauranteDataSet3;
            // 
            // pagamentoSetTableAdapter
            // 
            this.pagamentoSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaSetTableAdapter = null;
            this.tableAdapterManager.EstadoSetTableAdapter = null;
            this.tableAdapterManager.ItemMenuSetTableAdapter = null;
            this.tableAdapterManager.MetodoPagamentoSetTableAdapter = null;
            this.tableAdapterManager.MoradaSetTableAdapter = null;
            this.tableAdapterManager.PagamentoSetTableAdapter = this.pagamentoSetTableAdapter;
            this.tableAdapterManager.PedidoItemMenuTableAdapter = null;
            this.tableAdapterManager.PedidoSetTableAdapter = null;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_TrabalhadorTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.RestauranteItemMenuTableAdapter = null;
            this.tableAdapterManager.RestauranteSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pagamentoSetBindingNavigator
            // 
            this.pagamentoSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pagamentoSetBindingNavigator.BindingSource = this.pagamentoSetBindingSource;
            this.pagamentoSetBindingNavigator.CountItem = null;
            this.pagamentoSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pagamentoSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pagamentoSetBindingNavigatorSaveItem});
            this.pagamentoSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pagamentoSetBindingNavigator.MoveFirstItem = null;
            this.pagamentoSetBindingNavigator.MoveLastItem = null;
            this.pagamentoSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pagamentoSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pagamentoSetBindingNavigator.Name = "pagamentoSetBindingNavigator";
            this.pagamentoSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pagamentoSetBindingNavigator.Size = new System.Drawing.Size(458, 25);
            this.pagamentoSetBindingNavigator.TabIndex = 0;
            this.pagamentoSetBindingNavigator.Text = "bindingNavigator1";
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
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(101, 56);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 3;
            valorLabel.Text = "Valor:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamentoSetBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(222, 53);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(121, 20);
            this.valorTextBox.TabIndex = 4;
            // 
            // metodoPagamentoIdLabel
            // 
            metodoPagamentoIdLabel.AutoSize = true;
            metodoPagamentoIdLabel.Location = new System.Drawing.Point(101, 82);
            metodoPagamentoIdLabel.Name = "metodoPagamentoIdLabel";
            metodoPagamentoIdLabel.Size = new System.Drawing.Size(115, 13);
            metodoPagamentoIdLabel.TabIndex = 5;
            metodoPagamentoIdLabel.Text = "Metodo Pagamento Id:";
            // 
            // metodoPagamentoIdComboBox
            // 
            this.metodoPagamentoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamentoSetBindingSource, "MetodoPagamentoId", true));
            this.metodoPagamentoIdComboBox.FormattingEnabled = true;
            this.metodoPagamentoIdComboBox.Location = new System.Drawing.Point(222, 79);
            this.metodoPagamentoIdComboBox.Name = "metodoPagamentoIdComboBox";
            this.metodoPagamentoIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.metodoPagamentoIdComboBox.TabIndex = 6;
            // 
            // pedidoIdLabel
            // 
            pedidoIdLabel.AutoSize = true;
            pedidoIdLabel.Location = new System.Drawing.Point(101, 109);
            pedidoIdLabel.Name = "pedidoIdLabel";
            pedidoIdLabel.Size = new System.Drawing.Size(55, 13);
            pedidoIdLabel.TabIndex = 7;
            pedidoIdLabel.Text = "Pedido Id:";
            // 
            // pedidoIdComboBox
            // 
            this.pedidoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamentoSetBindingSource, "PedidoId", true));
            this.pedidoIdComboBox.FormattingEnabled = true;
            this.pedidoIdComboBox.Location = new System.Drawing.Point(222, 106);
            this.pedidoIdComboBox.Name = "pedidoIdComboBox";
            this.pedidoIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.pedidoIdComboBox.TabIndex = 8;
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
            // pagamentoSetBindingNavigatorSaveItem
            // 
            this.pagamentoSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pagamentoSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pagamentoSetBindingNavigatorSaveItem.Image")));
            this.pagamentoSetBindingNavigatorSaveItem.Name = "pagamentoSetBindingNavigatorSaveItem";
            this.pagamentoSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pagamentoSetBindingNavigatorSaveItem.Text = "Save Data";
            this.pagamentoSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.pagamentoSetBindingNavigatorSaveItem_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 155);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConcluir
            // 
            this.btnConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Location = new System.Drawing.Point(356, 155);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(90, 40);
            this.btnConcluir.TabIndex = 15;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // EfetuarPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 207);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(metodoPagamentoIdLabel);
            this.Controls.Add(this.metodoPagamentoIdComboBox);
            this.Controls.Add(pedidoIdLabel);
            this.Controls.Add(this.pedidoIdComboBox);
            this.Controls.Add(this.pagamentoSetBindingNavigator);
            this.Name = "EfetuarPagamento";
            this.Text = "EfetuarPagamento";
            this.Load += new System.EventHandler(this.EfetuarPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoSetBindingNavigator)).EndInit();
            this.pagamentoSetBindingNavigator.ResumeLayout(false);
            this.pagamentoSetBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestauranteDataSet3 restauranteDataSet3;
        private System.Windows.Forms.BindingSource pagamentoSetBindingSource;
        private RestauranteDataSet3TableAdapters.PagamentoSetTableAdapter pagamentoSetTableAdapter;
        private RestauranteDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pagamentoSetBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pagamentoSetBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.ComboBox metodoPagamentoIdComboBox;
        private System.Windows.Forms.ComboBox pedidoIdComboBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConcluir;
    }
}