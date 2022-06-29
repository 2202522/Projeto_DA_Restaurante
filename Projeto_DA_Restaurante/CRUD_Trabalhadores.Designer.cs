namespace Projeto_DA_Restaurante
{
    partial class CRUD_Trabalhadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_Trabalhadores));
            System.Windows.Forms.Label salarioLabel;
            System.Windows.Forms.Label posicaoLabel;
            System.Windows.Forms.Label restauranteIdLabel;
            System.Windows.Forms.Label idLabel;
            this.restauranteDataSet3 = new Projeto_DA_Restaurante.RestauranteDataSet3();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.pessoaSet_TrabalhadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSet_TrabalhadorTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.PessoaSet_TrabalhadorTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager();
            this.pessoaSet_TrabalhadorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pessoaSet_TrabalhadorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.salarioTextBox = new System.Windows.Forms.TextBox();
            this.posicaoTextBox = new System.Windows.Forms.TextBox();
            this.restauranteIdTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            salarioLabel = new System.Windows.Forms.Label();
            posicaoLabel = new System.Windows.Forms.Label();
            restauranteIdLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_TrabalhadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_TrabalhadorBindingNavigator)).BeginInit();
            this.pessoaSet_TrabalhadorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // restauranteDataSet3
            // 
            this.restauranteDataSet3.DataSetName = "RestauranteDataSet3";
            this.restauranteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // pessoaSet_TrabalhadorBindingSource
            // 
            this.pessoaSet_TrabalhadorBindingSource.DataMember = "PessoaSet_Trabalhador";
            this.pessoaSet_TrabalhadorBindingSource.DataSource = this.restauranteDataSet3;
            // 
            // pessoaSet_TrabalhadorTableAdapter
            // 
            this.pessoaSet_TrabalhadorTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PessoaSet_TrabalhadorTableAdapter = this.pessoaSet_TrabalhadorTableAdapter;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.RestauranteItemMenuTableAdapter = null;
            this.tableAdapterManager.RestauranteSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_Restaurante.RestauranteDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pessoaSet_TrabalhadorBindingNavigator
            // 
            this.pessoaSet_TrabalhadorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pessoaSet_TrabalhadorBindingNavigator.BindingSource = this.pessoaSet_TrabalhadorBindingSource;
            this.pessoaSet_TrabalhadorBindingNavigator.CountItem = null;
            this.pessoaSet_TrabalhadorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pessoaSet_TrabalhadorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pessoaSet_TrabalhadorBindingNavigatorSaveItem});
            this.pessoaSet_TrabalhadorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pessoaSet_TrabalhadorBindingNavigator.MoveFirstItem = null;
            this.pessoaSet_TrabalhadorBindingNavigator.MoveLastItem = null;
            this.pessoaSet_TrabalhadorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pessoaSet_TrabalhadorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pessoaSet_TrabalhadorBindingNavigator.Name = "pessoaSet_TrabalhadorBindingNavigator";
            this.pessoaSet_TrabalhadorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pessoaSet_TrabalhadorBindingNavigator.Size = new System.Drawing.Size(338, 25);
            this.pessoaSet_TrabalhadorBindingNavigator.TabIndex = 10;
            this.pessoaSet_TrabalhadorBindingNavigator.Text = "bindingNavigator1";
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
            // pessoaSet_TrabalhadorBindingNavigatorSaveItem
            // 
            this.pessoaSet_TrabalhadorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pessoaSet_TrabalhadorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pessoaSet_TrabalhadorBindingNavigatorSaveItem.Image")));
            this.pessoaSet_TrabalhadorBindingNavigatorSaveItem.Name = "pessoaSet_TrabalhadorBindingNavigatorSaveItem";
            this.pessoaSet_TrabalhadorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pessoaSet_TrabalhadorBindingNavigatorSaveItem.Text = "Save Data";
            this.pessoaSet_TrabalhadorBindingNavigatorSaveItem.Click += new System.EventHandler(this.pessoaSet_TrabalhadorBindingNavigatorSaveItem_Click_1);
            // 
            // salarioLabel
            // 
            salarioLabel.AutoSize = true;
            salarioLabel.Location = new System.Drawing.Point(60, 59);
            salarioLabel.Name = "salarioLabel";
            salarioLabel.Size = new System.Drawing.Size(42, 13);
            salarioLabel.TabIndex = 10;
            salarioLabel.Text = "Salario:";
            // 
            // salarioTextBox
            // 
            this.salarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_TrabalhadorBindingSource, "Salario", true));
            this.salarioTextBox.Location = new System.Drawing.Point(146, 56);
            this.salarioTextBox.Name = "salarioTextBox";
            this.salarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.salarioTextBox.TabIndex = 11;
            // 
            // posicaoLabel
            // 
            posicaoLabel.AutoSize = true;
            posicaoLabel.Location = new System.Drawing.Point(60, 85);
            posicaoLabel.Name = "posicaoLabel";
            posicaoLabel.Size = new System.Drawing.Size(48, 13);
            posicaoLabel.TabIndex = 12;
            posicaoLabel.Text = "Posicao:";
            // 
            // posicaoTextBox
            // 
            this.posicaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_TrabalhadorBindingSource, "Posicao", true));
            this.posicaoTextBox.Location = new System.Drawing.Point(146, 82);
            this.posicaoTextBox.Name = "posicaoTextBox";
            this.posicaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.posicaoTextBox.TabIndex = 13;
            // 
            // restauranteIdLabel
            // 
            restauranteIdLabel.AutoSize = true;
            restauranteIdLabel.Location = new System.Drawing.Point(60, 111);
            restauranteIdLabel.Name = "restauranteIdLabel";
            restauranteIdLabel.Size = new System.Drawing.Size(80, 13);
            restauranteIdLabel.TabIndex = 14;
            restauranteIdLabel.Text = "Restaurante Id:";
            // 
            // restauranteIdTextBox
            // 
            this.restauranteIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_TrabalhadorBindingSource, "RestauranteId", true));
            this.restauranteIdTextBox.Location = new System.Drawing.Point(146, 108);
            this.restauranteIdTextBox.Name = "restauranteIdTextBox";
            this.restauranteIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.restauranteIdTextBox.TabIndex = 15;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(60, 32);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 16;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_TrabalhadorBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(146, 29);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 17;
            // 
            // CRUD_Trabalhadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 200);
            this.Controls.Add(salarioLabel);
            this.Controls.Add(this.salarioTextBox);
            this.Controls.Add(posicaoLabel);
            this.Controls.Add(this.posicaoTextBox);
            this.Controls.Add(restauranteIdLabel);
            this.Controls.Add(this.restauranteIdTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.pessoaSet_TrabalhadorBindingNavigator);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnBack);
            this.Name = "CRUD_Trabalhadores";
            this.Text = "CRUD_Trabalhadores";
            this.Load += new System.EventHandler(this.CRUD_Trabalhadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_TrabalhadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_TrabalhadorBindingNavigator)).EndInit();
            this.pessoaSet_TrabalhadorBindingNavigator.ResumeLayout(false);
            this.pessoaSet_TrabalhadorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestauranteDataSet3 restauranteDataSet3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.BindingSource pessoaSet_TrabalhadorBindingSource;
        private RestauranteDataSet3TableAdapters.PessoaSet_TrabalhadorTableAdapter pessoaSet_TrabalhadorTableAdapter;
        private RestauranteDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pessoaSet_TrabalhadorBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pessoaSet_TrabalhadorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox salarioTextBox;
        private System.Windows.Forms.TextBox posicaoTextBox;
        private System.Windows.Forms.TextBox restauranteIdTextBox;
        private System.Windows.Forms.TextBox idTextBox;
    }
}