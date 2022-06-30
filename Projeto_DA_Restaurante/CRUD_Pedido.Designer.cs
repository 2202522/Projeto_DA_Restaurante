namespace Projeto_DA_Restaurante
{
    partial class CRUD_Pedido
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
            System.Windows.Forms.Label valorTotalLabel;
            System.Windows.Forms.Label restauranteIdLabel;
            System.Windows.Forms.Label clienteIdLabel;
            System.Windows.Forms.Label trabalhadorIdLabel;
            System.Windows.Forms.Label estadoIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_Pedido));
            this.restauranteDataSet3 = new Projeto_DA_Restaurante.RestauranteDataSet3();
            this.pedidoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.PedidoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager();
            this.pedidoSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pedidoSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.valorTotalTextBox = new System.Windows.Forms.TextBox();
            this.clienteIdTextBox = new System.Windows.Forms.TextBox();
            this.trabalhadorIdTextBox = new System.Windows.Forms.TextBox();
            this.estadoIdTextBox = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.restauranteIdComboBox = new System.Windows.Forms.ComboBox();
            valorTotalLabel = new System.Windows.Forms.Label();
            restauranteIdLabel = new System.Windows.Forms.Label();
            clienteIdLabel = new System.Windows.Forms.Label();
            trabalhadorIdLabel = new System.Windows.Forms.Label();
            estadoIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetBindingNavigator)).BeginInit();
            this.pedidoSetBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // valorTotalLabel
            // 
            valorTotalLabel.AutoSize = true;
            valorTotalLabel.Location = new System.Drawing.Point(26, 53);
            valorTotalLabel.Name = "valorTotalLabel";
            valorTotalLabel.Size = new System.Drawing.Size(61, 13);
            valorTotalLabel.TabIndex = 3;
            valorTotalLabel.Text = "Valor Total:";
            // 
            // restauranteIdLabel
            // 
            restauranteIdLabel.AutoSize = true;
            restauranteIdLabel.Location = new System.Drawing.Point(26, 79);
            restauranteIdLabel.Name = "restauranteIdLabel";
            restauranteIdLabel.Size = new System.Drawing.Size(80, 13);
            restauranteIdLabel.TabIndex = 5;
            restauranteIdLabel.Text = "Restaurante Id:";
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.Location = new System.Drawing.Point(26, 105);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(54, 13);
            clienteIdLabel.TabIndex = 7;
            clienteIdLabel.Text = "Cliente Id:";
            // 
            // trabalhadorIdLabel
            // 
            trabalhadorIdLabel.AutoSize = true;
            trabalhadorIdLabel.Location = new System.Drawing.Point(232, 53);
            trabalhadorIdLabel.Name = "trabalhadorIdLabel";
            trabalhadorIdLabel.Size = new System.Drawing.Size(79, 13);
            trabalhadorIdLabel.TabIndex = 9;
            trabalhadorIdLabel.Text = "Trabalhador Id:";
            // 
            // estadoIdLabel
            // 
            estadoIdLabel.AutoSize = true;
            estadoIdLabel.Location = new System.Drawing.Point(232, 79);
            estadoIdLabel.Name = "estadoIdLabel";
            estadoIdLabel.Size = new System.Drawing.Size(55, 13);
            estadoIdLabel.TabIndex = 11;
            estadoIdLabel.Text = "Estado Id:";
            // 
            // restauranteDataSet3
            // 
            this.restauranteDataSet3.DataSetName = "RestauranteDataSet3";
            this.restauranteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoSetBindingSource
            // 
            this.pedidoSetBindingSource.DataMember = "PedidoSet";
            this.pedidoSetBindingSource.DataSource = this.restauranteDataSet3;
            // 
            // pedidoSetTableAdapter
            // 
            this.pedidoSetTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PedidoSetTableAdapter = this.pedidoSetTableAdapter;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_TrabalhadorTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.RestauranteItemMenuTableAdapter = null;
            this.tableAdapterManager.RestauranteSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pedidoSetBindingNavigator
            // 
            this.pedidoSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pedidoSetBindingNavigator.BindingSource = this.pedidoSetBindingSource;
            this.pedidoSetBindingNavigator.CountItem = null;
            this.pedidoSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pedidoSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pedidoSetBindingNavigatorSaveItem});
            this.pedidoSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pedidoSetBindingNavigator.MoveFirstItem = null;
            this.pedidoSetBindingNavigator.MoveLastItem = null;
            this.pedidoSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pedidoSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pedidoSetBindingNavigator.Name = "pedidoSetBindingNavigator";
            this.pedidoSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pedidoSetBindingNavigator.Size = new System.Drawing.Size(458, 25);
            this.pedidoSetBindingNavigator.TabIndex = 0;
            this.pedidoSetBindingNavigator.Text = "bindingNavigator1";
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
            // pedidoSetBindingNavigatorSaveItem
            // 
            this.pedidoSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pedidoSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pedidoSetBindingNavigatorSaveItem.Image")));
            this.pedidoSetBindingNavigatorSaveItem.Name = "pedidoSetBindingNavigatorSaveItem";
            this.pedidoSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pedidoSetBindingNavigatorSaveItem.Text = "Save Data";
            this.pedidoSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.pedidoSetBindingNavigatorSaveItem_Click);
            // 
            // valorTotalTextBox
            // 
            this.valorTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "ValorTotal", true));
            this.valorTotalTextBox.Location = new System.Drawing.Point(112, 50);
            this.valorTotalTextBox.Name = "valorTotalTextBox";
            this.valorTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTotalTextBox.TabIndex = 4;
            // 
            // clienteIdTextBox
            // 
            this.clienteIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "ClienteId", true));
            this.clienteIdTextBox.Location = new System.Drawing.Point(112, 102);
            this.clienteIdTextBox.Name = "clienteIdTextBox";
            this.clienteIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.clienteIdTextBox.TabIndex = 8;
            // 
            // trabalhadorIdTextBox
            // 
            this.trabalhadorIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "TrabalhadorId", true));
            this.trabalhadorIdTextBox.Location = new System.Drawing.Point(318, 50);
            this.trabalhadorIdTextBox.Name = "trabalhadorIdTextBox";
            this.trabalhadorIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.trabalhadorIdTextBox.TabIndex = 10;
            // 
            // estadoIdTextBox
            // 
            this.estadoIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "EstadoId", true));
            this.estadoIdTextBox.Location = new System.Drawing.Point(318, 76);
            this.estadoIdTextBox.Name = "estadoIdTextBox";
            this.estadoIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.estadoIdTextBox.TabIndex = 12;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 147);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConcluir
            // 
            this.btnConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Location = new System.Drawing.Point(348, 147);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(90, 40);
            this.btnConcluir.TabIndex = 14;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // restauranteIdComboBox
            // 
            this.restauranteIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "RestauranteId", true));
            this.restauranteIdComboBox.FormattingEnabled = true;
            this.restauranteIdComboBox.Location = new System.Drawing.Point(112, 75);
            this.restauranteIdComboBox.Name = "restauranteIdComboBox";
            this.restauranteIdComboBox.Size = new System.Drawing.Size(100, 21);
            this.restauranteIdComboBox.TabIndex = 15;
//            this.restauranteIdComboBox.SelectedIndexChanged += new System.EventHandler(this.restauranteIdComboBox_SelectedIndexChanged);
            // 
            // CRUD_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 207);
            this.Controls.Add(this.restauranteIdComboBox);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(valorTotalLabel);
            this.Controls.Add(this.valorTotalTextBox);
            this.Controls.Add(restauranteIdLabel);
            this.Controls.Add(clienteIdLabel);
            this.Controls.Add(this.clienteIdTextBox);
            this.Controls.Add(trabalhadorIdLabel);
            this.Controls.Add(this.trabalhadorIdTextBox);
            this.Controls.Add(estadoIdLabel);
            this.Controls.Add(this.estadoIdTextBox);
            this.Controls.Add(this.pedidoSetBindingNavigator);
            this.Name = "CRUD_Pedido";
            this.Text = "CRUD_Pedido";
            this.Load += new System.EventHandler(this.CRUD_Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetBindingNavigator)).EndInit();
            this.pedidoSetBindingNavigator.ResumeLayout(false);
            this.pedidoSetBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestauranteDataSet3 restauranteDataSet3;
        private System.Windows.Forms.BindingSource pedidoSetBindingSource;
        private RestauranteDataSet3TableAdapters.PedidoSetTableAdapter pedidoSetTableAdapter;
        private RestauranteDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pedidoSetBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pedidoSetBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox valorTotalTextBox;
        private System.Windows.Forms.TextBox clienteIdTextBox;
        private System.Windows.Forms.TextBox trabalhadorIdTextBox;
        private System.Windows.Forms.TextBox estadoIdTextBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.ComboBox restauranteIdComboBox;
    }
}