namespace Projeto_DA_Restaurante
{
    partial class CRUD_Morada_Restaurante
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
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label codPostalLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label ruaLabel;
            System.Windows.Forms.Label restaurante_IdLabel;
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.codPostalTextBox = new System.Windows.Forms.TextBox();
            this.paisTextBox = new System.Windows.Forms.TextBox();
            this.ruaTextBox = new System.Windows.Forms.TextBox();
            this.restGestDBDataSet = new Projeto_DA_Restaurante.RestGestDBDataSet();
            this.moradaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.TableAdapterManager();
            this.restaurante_IdComboBox = new System.Windows.Forms.ComboBox();
            this.restauranteSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.RestauranteSetTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cRUDMoradaRestauranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarRestaurantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cidadeLabel = new System.Windows.Forms.Label();
            codPostalLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            ruaLabel = new System.Windows.Forms.Label();
            restaurante_IdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cidadeLabel.Location = new System.Drawing.Point(37, 90);
            cidadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(66, 20);
            cidadeLabel.TabIndex = 3;
            cidadeLabel.Text = "Cidade:";
            // 
            // codPostalLabel
            // 
            codPostalLabel.AutoSize = true;
            codPostalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codPostalLabel.Location = new System.Drawing.Point(37, 122);
            codPostalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codPostalLabel.Name = "codPostalLabel";
            codPostalLabel.Size = new System.Drawing.Size(96, 20);
            codPostalLabel.TabIndex = 5;
            codPostalLabel.Text = "Cod Postal:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paisLabel.Location = new System.Drawing.Point(320, 90);
            paisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(47, 20);
            paisLabel.TabIndex = 7;
            paisLabel.Text = "Pais:";
            // 
            // ruaLabel
            // 
            ruaLabel.AutoSize = true;
            ruaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ruaLabel.Location = new System.Drawing.Point(320, 122);
            ruaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ruaLabel.Name = "ruaLabel";
            ruaLabel.Size = new System.Drawing.Size(44, 20);
            ruaLabel.TabIndex = 9;
            ruaLabel.Text = "Rua:";
            // 
            // restaurante_IdLabel
            // 
            restaurante_IdLabel.AutoSize = true;
            restaurante_IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            restaurante_IdLabel.Location = new System.Drawing.Point(37, 160);
            restaurante_IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            restaurante_IdLabel.Name = "restaurante_IdLabel";
            restaurante_IdLabel.Size = new System.Drawing.Size(105, 20);
            restaurante_IdLabel.TabIndex = 20;
            restaurante_IdLabel.Text = "Restaurante:";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Location = new System.Drawing.Point(152, 85);
            this.cidadeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(132, 22);
            this.cidadeTextBox.TabIndex = 4;
            // 
            // codPostalTextBox
            // 
            this.codPostalTextBox.Location = new System.Drawing.Point(152, 120);
            this.codPostalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.codPostalTextBox.Name = "codPostalTextBox";
            this.codPostalTextBox.Size = new System.Drawing.Size(132, 22);
            this.codPostalTextBox.TabIndex = 6;
            // 
            // paisTextBox
            // 
            this.paisTextBox.Location = new System.Drawing.Point(423, 88);
            this.paisTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.paisTextBox.Name = "paisTextBox";
            this.paisTextBox.Size = new System.Drawing.Size(132, 22);
            this.paisTextBox.TabIndex = 8;
            // 
            // ruaTextBox
            // 
            this.ruaTextBox.Location = new System.Drawing.Point(423, 120);
            this.ruaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ruaTextBox.Name = "ruaTextBox";
            this.ruaTextBox.Size = new System.Drawing.Size(132, 22);
            this.ruaTextBox.TabIndex = 10;
            // 
            // restGestDBDataSet
            // 
            this.restGestDBDataSet.DataSetName = "RestGestDBDataSet";
            this.restGestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moradaSetBindingSource
            // 
            this.moradaSetBindingSource.DataMember = "MoradaSet";
            this.moradaSetBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaSetTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EstadoSetTableAdapter = null;
            this.tableAdapterManager.ItemMenuSetTableAdapter = null;
            this.tableAdapterManager.MetodoPagamentoSetTableAdapter = null;
            this.tableAdapterManager.MoradaSetTableAdapter = null;
            this.tableAdapterManager.PagamentoSetTableAdapter = null;
            this.tableAdapterManager.PedidoItemMenuTableAdapter = null;
            this.tableAdapterManager.PedidoSetTableAdapter = null;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_TrabalhadorTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.PromocaosTableAdapter = null;
            this.tableAdapterManager.RestauranteItemMenuTableAdapter = null;
            this.tableAdapterManager.RestauranteSetTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // restaurante_IdComboBox
            // 
            this.restaurante_IdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moradaSetBindingSource, "Restaurante_Id", true));
            this.restaurante_IdComboBox.DataSource = this.restauranteSetBindingSource;
            this.restaurante_IdComboBox.DisplayMember = "Nome";
            this.restaurante_IdComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restaurante_IdComboBox.FormattingEnabled = true;
            this.restaurante_IdComboBox.Location = new System.Drawing.Point(152, 156);
            this.restaurante_IdComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.restaurante_IdComboBox.Name = "restaurante_IdComboBox";
            this.restaurante_IdComboBox.Size = new System.Drawing.Size(132, 24);
            this.restaurante_IdComboBox.TabIndex = 21;
            this.restaurante_IdComboBox.ValueMember = "Id";
            // 
            // restauranteSetBindingSource
            // 
            this.restauranteSetBindingSource.DataMember = "RestauranteSet";
            this.restauranteSetBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // restauranteSetTableAdapter
            // 
            this.restauranteSetTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDMoradaRestauranteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cRUDMoradaRestauranteToolStripMenuItem
            // 
            this.cRUDMoradaRestauranteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.concluirToolStripMenuItem,
            this.voltarRestaurantToolStripMenuItem});
            this.cRUDMoradaRestauranteToolStripMenuItem.Name = "cRUDMoradaRestauranteToolStripMenuItem";
            this.cRUDMoradaRestauranteToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.cRUDMoradaRestauranteToolStripMenuItem.Text = "Morada_Restaurante";
            // 
            // concluirToolStripMenuItem
            // 
            this.concluirToolStripMenuItem.Name = "concluirToolStripMenuItem";
            this.concluirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.concluirToolStripMenuItem.Text = "Concluir";
            this.concluirToolStripMenuItem.Click += new System.EventHandler(this.concluirToolStripMenuItem_Click);
            // 
            // voltarRestaurantToolStripMenuItem
            // 
            this.voltarRestaurantToolStripMenuItem.Name = "voltarRestaurantToolStripMenuItem";
            this.voltarRestaurantToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.voltarRestaurantToolStripMenuItem.Text = "Voltar Restaurant";
            this.voltarRestaurantToolStripMenuItem.Click += new System.EventHandler(this.voltarRestaurantToolStripMenuItem_Click);
            // 
            // CRUD_Morada_Restaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(584, 244);
            this.Controls.Add(restaurante_IdLabel);
            this.Controls.Add(this.restaurante_IdComboBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(codPostalLabel);
            this.Controls.Add(this.codPostalTextBox);
            this.Controls.Add(paisLabel);
            this.Controls.Add(this.paisTextBox);
            this.Controls.Add(ruaLabel);
            this.Controls.Add(this.ruaTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CRUD_Morada_Restaurante";
            this.Text = "CRUD_Morada_Restaurante";
            this.Load += new System.EventHandler(this.CRUD_Morada_Restaurante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox codPostalTextBox;
        private System.Windows.Forms.TextBox paisTextBox;
        private System.Windows.Forms.TextBox ruaTextBox;
        private RestGestDBDataSet restGestDBDataSet;
        private System.Windows.Forms.BindingSource moradaSetBindingSource;
        private RestGestDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox restaurante_IdComboBox;
        private System.Windows.Forms.BindingSource restauranteSetBindingSource;
        private RestGestDBDataSetTableAdapters.RestauranteSetTableAdapter restauranteSetTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cRUDMoradaRestauranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarRestaurantToolStripMenuItem;
    }
}