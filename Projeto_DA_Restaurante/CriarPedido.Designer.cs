namespace Projeto_DA_Restaurante
{
    partial class CriarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarPedido));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label valorTotalLabel;
            System.Windows.Forms.Label restauranteIdLabel;
            System.Windows.Forms.Label clienteIdLabel;
            System.Windows.Forms.Label trabalhadorIdLabel;
            System.Windows.Forms.Label estadoIdLabel;
            this.restauranteDataSet1 = new Projeto_DA_Restaurante.RestauranteDataSet1();
            this.pedidoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.PedidoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.TableAdapterManager();
            this.pedidoSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pedidoSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.valorTotalTextBox = new System.Windows.Forms.TextBox();
            this.restauranteIdTextBox = new System.Windows.Forms.TextBox();
            this.clienteIdComboBox = new System.Windows.Forms.ComboBox();
            this.trabalhadorIdComboBox = new System.Windows.Forms.ComboBox();
            this.estadoIdTextBox = new System.Windows.Forms.TextBox();
            this.tbConcluir = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            valorTotalLabel = new System.Windows.Forms.Label();
            restauranteIdLabel = new System.Windows.Forms.Label();
            clienteIdLabel = new System.Windows.Forms.Label();
            trabalhadorIdLabel = new System.Windows.Forms.Label();
            estadoIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetBindingNavigator)).BeginInit();
            this.pedidoSetBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // restauranteDataSet1
            // 
            this.restauranteDataSet1.DataSetName = "RestauranteDataSet1";
            this.restauranteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoSetBindingSource
            // 
            this.pedidoSetBindingSource.DataMember = "PedidoSet";
            this.pedidoSetBindingSource.DataSource = this.restauranteDataSet1;
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
            this.tableAdapterManager.PagamentoSetTableAdapter = null;
            this.tableAdapterManager.PedidoItemMenuTableAdapter = null;
            this.tableAdapterManager.PedidoSetTableAdapter = this.pedidoSetTableAdapter;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_TrabalhadorTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.RestauranteItemMenuTableAdapter = null;
            this.tableAdapterManager.RestauranteSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pedidoSetBindingNavigator
            // 
            this.pedidoSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pedidoSetBindingNavigator.BindingSource = this.pedidoSetBindingSource;
            this.pedidoSetBindingNavigator.CountItem = null;
            this.pedidoSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pedidoSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pedidoSetBindingNavigatorSaveItem});
            this.pedidoSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pedidoSetBindingNavigator.MoveFirstItem = null;
            this.pedidoSetBindingNavigator.MoveLastItem = null;
            this.pedidoSetBindingNavigator.MoveNextItem = null;
            this.pedidoSetBindingNavigator.MovePreviousItem = null;
            this.pedidoSetBindingNavigator.Name = "pedidoSetBindingNavigator";
            this.pedidoSetBindingNavigator.PositionItem = null;
            this.pedidoSetBindingNavigator.Size = new System.Drawing.Size(688, 25);
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
            // pedidoSetBindingNavigatorSaveItem
            // 
            this.pedidoSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pedidoSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pedidoSetBindingNavigatorSaveItem.Image")));
            this.pedidoSetBindingNavigatorSaveItem.Name = "pedidoSetBindingNavigatorSaveItem";
            this.pedidoSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pedidoSetBindingNavigatorSaveItem.Text = "Save Data";
            this.pedidoSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.pedidoSetBindingNavigatorSaveItem_Click_1);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(54, 58);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(30, 24);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(195, 56);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(121, 29);
            this.idTextBox.TabIndex = 2;
            // 
            // valorTotalLabel
            // 
            valorTotalLabel.AutoSize = true;
            valorTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorTotalLabel.Location = new System.Drawing.Point(54, 93);
            valorTotalLabel.Name = "valorTotalLabel";
            valorTotalLabel.Size = new System.Drawing.Size(105, 24);
            valorTotalLabel.TabIndex = 3;
            valorTotalLabel.Text = "Valor Total:";
            // 
            // valorTotalTextBox
            // 
            this.valorTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "ValorTotal", true));
            this.valorTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotalTextBox.Location = new System.Drawing.Point(195, 91);
            this.valorTotalTextBox.Name = "valorTotalTextBox";
            this.valorTotalTextBox.Size = new System.Drawing.Size(121, 29);
            this.valorTotalTextBox.TabIndex = 4;
            // 
            // restauranteIdLabel
            // 
            restauranteIdLabel.AutoSize = true;
            restauranteIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            restauranteIdLabel.Location = new System.Drawing.Point(54, 129);
            restauranteIdLabel.Name = "restauranteIdLabel";
            restauranteIdLabel.Size = new System.Drawing.Size(135, 24);
            restauranteIdLabel.TabIndex = 5;
            restauranteIdLabel.Text = "Restaurante Id:";
            // 
            // restauranteIdTextBox
            // 
            this.restauranteIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "RestauranteId", true));
            this.restauranteIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restauranteIdTextBox.Location = new System.Drawing.Point(195, 126);
            this.restauranteIdTextBox.Name = "restauranteIdTextBox";
            this.restauranteIdTextBox.Size = new System.Drawing.Size(121, 29);
            this.restauranteIdTextBox.TabIndex = 6;
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clienteIdLabel.Location = new System.Drawing.Point(378, 56);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(93, 24);
            clienteIdLabel.TabIndex = 7;
            clienteIdLabel.Text = "Cliente Id:";
            // 
            // clienteIdComboBox
            // 
            this.clienteIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "ClienteId", true));
            this.clienteIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteIdComboBox.FormattingEnabled = true;
            this.clienteIdComboBox.Location = new System.Drawing.Point(535, 50);
            this.clienteIdComboBox.Name = "clienteIdComboBox";
            this.clienteIdComboBox.Size = new System.Drawing.Size(121, 32);
            this.clienteIdComboBox.TabIndex = 8;
            // 
            // trabalhadorIdLabel
            // 
            trabalhadorIdLabel.AutoSize = true;
            trabalhadorIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trabalhadorIdLabel.Location = new System.Drawing.Point(378, 93);
            trabalhadorIdLabel.Name = "trabalhadorIdLabel";
            trabalhadorIdLabel.Size = new System.Drawing.Size(137, 24);
            trabalhadorIdLabel.TabIndex = 9;
            trabalhadorIdLabel.Text = "Trabalhador Id:";
            // 
            // trabalhadorIdComboBox
            // 
            this.trabalhadorIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "TrabalhadorId", true));
            this.trabalhadorIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trabalhadorIdComboBox.FormattingEnabled = true;
            this.trabalhadorIdComboBox.Location = new System.Drawing.Point(535, 87);
            this.trabalhadorIdComboBox.Name = "trabalhadorIdComboBox";
            this.trabalhadorIdComboBox.Size = new System.Drawing.Size(121, 32);
            this.trabalhadorIdComboBox.TabIndex = 10;
            // 
            // estadoIdLabel
            // 
            estadoIdLabel.AutoSize = true;
            estadoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoIdLabel.Location = new System.Drawing.Point(54, 164);
            estadoIdLabel.Name = "estadoIdLabel";
            estadoIdLabel.Size = new System.Drawing.Size(93, 24);
            estadoIdLabel.TabIndex = 11;
            estadoIdLabel.Text = "Estado Id:";
            // 
            // estadoIdTextBox
            // 
            this.estadoIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoSetBindingSource, "EstadoId", true));
            this.estadoIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoIdTextBox.Location = new System.Drawing.Point(195, 161);
            this.estadoIdTextBox.Name = "estadoIdTextBox";
            this.estadoIdTextBox.Size = new System.Drawing.Size(121, 29);
            this.estadoIdTextBox.TabIndex = 12;
            // 
            // tbConcluir
            // 
            this.tbConcluir.Location = new System.Drawing.Point(512, 161);
            this.tbConcluir.Name = "tbConcluir";
            this.tbConcluir.Size = new System.Drawing.Size(144, 39);
            this.tbConcluir.TabIndex = 13;
            this.tbConcluir.Text = "Concluir";
            this.tbConcluir.UseVisualStyleBackColor = true;
            this.tbConcluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // CriarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 223);
            this.Controls.Add(this.tbConcluir);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(valorTotalLabel);
            this.Controls.Add(this.valorTotalTextBox);
            this.Controls.Add(restauranteIdLabel);
            this.Controls.Add(this.restauranteIdTextBox);
            this.Controls.Add(clienteIdLabel);
            this.Controls.Add(this.clienteIdComboBox);
            this.Controls.Add(trabalhadorIdLabel);
            this.Controls.Add(this.trabalhadorIdComboBox);
            this.Controls.Add(estadoIdLabel);
            this.Controls.Add(this.estadoIdTextBox);
            this.Controls.Add(this.pedidoSetBindingNavigator);
            this.Name = "CriarPedido";
            this.Text = "CriarPedido";
            this.Load += new System.EventHandler(this.CriarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetBindingNavigator)).EndInit();
            this.pedidoSetBindingNavigator.ResumeLayout(false);
            this.pedidoSetBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestauranteDataSet1 restauranteDataSet1;
        private System.Windows.Forms.BindingSource pedidoSetBindingSource;
        private RestauranteDataSet1TableAdapters.PedidoSetTableAdapter pedidoSetTableAdapter;
        private RestauranteDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pedidoSetBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton pedidoSetBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox valorTotalTextBox;
        private System.Windows.Forms.TextBox restauranteIdTextBox;
        private System.Windows.Forms.ComboBox clienteIdComboBox;
        private System.Windows.Forms.ComboBox trabalhadorIdComboBox;
        private System.Windows.Forms.TextBox estadoIdTextBox;
        private System.Windows.Forms.Button tbConcluir;
    }
}