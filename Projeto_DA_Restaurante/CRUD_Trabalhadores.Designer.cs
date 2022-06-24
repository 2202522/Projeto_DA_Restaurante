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
            System.Windows.Forms.Label salarioLabel;
            System.Windows.Forms.Label posicaoLabel;
            System.Windows.Forms.Label restauranteIdLabel;
            System.Windows.Forms.Label idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_Trabalhadores));
            this.restauranteDataSet1 = new Projeto_DA_Restaurante.RestauranteDataSet1();
            this.pessoaSet_TrabalhadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSet_TrabalhadorTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.PessoaSet_TrabalhadorTableAdapter();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.TableAdapterManager();
            this.pessoaSet_TrabalhadorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.salarioTextBox = new System.Windows.Forms.TextBox();
            this.posicaoTextBox = new System.Windows.Forms.TextBox();
            this.restauranteIdTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pessoaSet_TrabalhadorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btConcluir = new System.Windows.Forms.Button();
            salarioLabel = new System.Windows.Forms.Label();
            posicaoLabel = new System.Windows.Forms.Label();
            restauranteIdLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_TrabalhadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_TrabalhadorBindingNavigator)).BeginInit();
            this.pessoaSet_TrabalhadorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // restauranteDataSet1
            // 
            this.restauranteDataSet1.DataSetName = "RestauranteDataSet1";
            this.restauranteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaSet_TrabalhadorBindingSource
            // 
            this.pessoaSet_TrabalhadorBindingSource.DataMember = "PessoaSet_Trabalhador";
            this.pessoaSet_TrabalhadorBindingSource.DataSource = this.restauranteDataSet1;
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
            this.tableAdapterManager.PagamentoSetTableAdapter = null;
            this.tableAdapterManager.PedidoItemMenuTableAdapter = null;
            this.tableAdapterManager.PedidoSetTableAdapter = null;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_TrabalhadorTableAdapter = this.pessoaSet_TrabalhadorTableAdapter;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.RestauranteItemMenuTableAdapter = null;
            this.tableAdapterManager.RestauranteSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pessoaSet_TrabalhadorBindingNavigator
            // 
            this.pessoaSet_TrabalhadorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pessoaSet_TrabalhadorBindingNavigator.BindingSource = this.pessoaSet_TrabalhadorBindingSource;
            this.pessoaSet_TrabalhadorBindingNavigator.CountItem = null;
            this.pessoaSet_TrabalhadorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pessoaSet_TrabalhadorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pessoaSet_TrabalhadorBindingNavigatorSaveItem});
            this.pessoaSet_TrabalhadorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pessoaSet_TrabalhadorBindingNavigator.MoveFirstItem = null;
            this.pessoaSet_TrabalhadorBindingNavigator.MoveLastItem = null;
            this.pessoaSet_TrabalhadorBindingNavigator.MoveNextItem = null;
            this.pessoaSet_TrabalhadorBindingNavigator.MovePreviousItem = null;
            this.pessoaSet_TrabalhadorBindingNavigator.Name = "pessoaSet_TrabalhadorBindingNavigator";
            this.pessoaSet_TrabalhadorBindingNavigator.PositionItem = null;
            this.pessoaSet_TrabalhadorBindingNavigator.Size = new System.Drawing.Size(646, 25);
            this.pessoaSet_TrabalhadorBindingNavigator.TabIndex = 0;
            this.pessoaSet_TrabalhadorBindingNavigator.Text = "bindingNavigator1";
            // 
            // salarioLabel
            // 
            salarioLabel.AutoSize = true;
            salarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            salarioLabel.Location = new System.Drawing.Point(44, 94);
            salarioLabel.Name = "salarioLabel";
            salarioLabel.Size = new System.Drawing.Size(62, 20);
            salarioLabel.TabIndex = 1;
            salarioLabel.Text = "Salario:";
            // 
            // salarioTextBox
            // 
            this.salarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_TrabalhadorBindingSource, "Salario", true));
            this.salarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarioTextBox.Location = new System.Drawing.Point(111, 91);
            this.salarioTextBox.Name = "salarioTextBox";
            this.salarioTextBox.Size = new System.Drawing.Size(156, 26);
            this.salarioTextBox.TabIndex = 2;
            // 
            // posicaoLabel
            // 
            posicaoLabel.AutoSize = true;
            posicaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            posicaoLabel.Location = new System.Drawing.Point(321, 60);
            posicaoLabel.Name = "posicaoLabel";
            posicaoLabel.Size = new System.Drawing.Size(69, 20);
            posicaoLabel.TabIndex = 3;
            posicaoLabel.Text = "Posicao:";
            // 
            // posicaoTextBox
            // 
            this.posicaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_TrabalhadorBindingSource, "Posicao", true));
            this.posicaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posicaoTextBox.Location = new System.Drawing.Point(447, 57);
            this.posicaoTextBox.Name = "posicaoTextBox";
            this.posicaoTextBox.Size = new System.Drawing.Size(156, 26);
            this.posicaoTextBox.TabIndex = 4;
            // 
            // restauranteIdLabel
            // 
            restauranteIdLabel.AutoSize = true;
            restauranteIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            restauranteIdLabel.Location = new System.Drawing.Point(321, 95);
            restauranteIdLabel.Name = "restauranteIdLabel";
            restauranteIdLabel.Size = new System.Drawing.Size(120, 20);
            restauranteIdLabel.TabIndex = 5;
            restauranteIdLabel.Text = "Restaurante Id:";
            // 
            // restauranteIdTextBox
            // 
            this.restauranteIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_TrabalhadorBindingSource, "RestauranteId", true));
            this.restauranteIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restauranteIdTextBox.Location = new System.Drawing.Point(447, 92);
            this.restauranteIdTextBox.Name = "restauranteIdTextBox";
            this.restauranteIdTextBox.Size = new System.Drawing.Size(156, 26);
            this.restauranteIdTextBox.TabIndex = 6;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(44, 60);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaSet_TrabalhadorBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(111, 57);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(156, 26);
            this.idTextBox.TabIndex = 8;
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
            // pessoaSet_TrabalhadorBindingNavigatorSaveItem
            // 
            this.pessoaSet_TrabalhadorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pessoaSet_TrabalhadorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pessoaSet_TrabalhadorBindingNavigatorSaveItem.Image")));
            this.pessoaSet_TrabalhadorBindingNavigatorSaveItem.Name = "pessoaSet_TrabalhadorBindingNavigatorSaveItem";
            this.pessoaSet_TrabalhadorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pessoaSet_TrabalhadorBindingNavigatorSaveItem.Text = "Save Data";
            this.pessoaSet_TrabalhadorBindingNavigatorSaveItem.Click += new System.EventHandler(this.pessoaSet_TrabalhadorBindingNavigatorSaveItem_Click);
            // 
            // btConcluir
            // 
            this.btConcluir.Location = new System.Drawing.Point(459, 147);
            this.btConcluir.Name = "btConcluir";
            this.btConcluir.Size = new System.Drawing.Size(144, 48);
            this.btConcluir.TabIndex = 16;
            this.btConcluir.Text = "Concluir";
            this.btConcluir.UseVisualStyleBackColor = true;
            this.btConcluir.Click += new System.EventHandler(this.btConcluir_Click);
            // 
            // CRUD_Trabalhadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 240);
            this.Controls.Add(this.btConcluir);
            this.Controls.Add(salarioLabel);
            this.Controls.Add(this.salarioTextBox);
            this.Controls.Add(posicaoLabel);
            this.Controls.Add(this.posicaoTextBox);
            this.Controls.Add(restauranteIdLabel);
            this.Controls.Add(this.restauranteIdTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.pessoaSet_TrabalhadorBindingNavigator);
            this.Name = "CRUD_Trabalhadores";
            this.Text = "CRUD_Trabalhadores";
            this.Load += new System.EventHandler(this.CRUD_Trabalhadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_TrabalhadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSet_TrabalhadorBindingNavigator)).EndInit();
            this.pessoaSet_TrabalhadorBindingNavigator.ResumeLayout(false);
            this.pessoaSet_TrabalhadorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestauranteDataSet1 restauranteDataSet1;
        private System.Windows.Forms.BindingSource pessoaSet_TrabalhadorBindingSource;
        private RestauranteDataSet1TableAdapters.PessoaSet_TrabalhadorTableAdapter pessoaSet_TrabalhadorTableAdapter;
        private RestauranteDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pessoaSet_TrabalhadorBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton pessoaSet_TrabalhadorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox salarioTextBox;
        private System.Windows.Forms.TextBox posicaoTextBox;
        private System.Windows.Forms.TextBox restauranteIdTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button btConcluir;
    }
}