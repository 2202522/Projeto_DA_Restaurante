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
            this.restauranteDataSet3 = new Projeto_DA_Restaurante.RestauranteDataSet3();
            this.valorTotalTextBox = new System.Windows.Forms.TextBox();
            this.restauranteIdComboBox = new System.Windows.Forms.ComboBox();
            this.restauranteSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restGestDBDataSet = new Projeto_DA_Restaurante.RestGestDBDataSet();
            this.clienteIdcomboBox = new System.Windows.Forms.ComboBox();
            this.pessoaSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trabalhadorIdcomboBox = new System.Windows.Forms.ComboBox();
            this.pessoaSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.estadoIdcomboBox = new System.Windows.Forms.ComboBox();
            this.estadoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.RestauranteSetTableAdapter();
            this.pessoaSetClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSet_ClienteTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.PessoaSet_ClienteTableAdapter();
            this.pessoaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.PessoaSetTableAdapter();
            this.fKClienteinheritsPessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.EstadoSetTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cRUDPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            valorTotalLabel = new System.Windows.Forms.Label();
            restauranteIdLabel = new System.Windows.Forms.Label();
            clienteIdLabel = new System.Windows.Forms.Label();
            trabalhadorIdLabel = new System.Windows.Forms.Label();
            estadoIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClienteinheritsPessoaBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // valorTotalLabel
            // 
            valorTotalLabel.AutoSize = true;
            valorTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorTotalLabel.Location = new System.Drawing.Point(38, 83);
            valorTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valorTotalLabel.Name = "valorTotalLabel";
            valorTotalLabel.Size = new System.Drawing.Size(95, 20);
            valorTotalLabel.TabIndex = 3;
            valorTotalLabel.Text = "Valor Total:";
            // 
            // restauranteIdLabel
            // 
            restauranteIdLabel.AutoSize = true;
            restauranteIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            restauranteIdLabel.Location = new System.Drawing.Point(38, 115);
            restauranteIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            restauranteIdLabel.Name = "restauranteIdLabel";
            restauranteIdLabel.Size = new System.Drawing.Size(105, 20);
            restauranteIdLabel.TabIndex = 5;
            restauranteIdLabel.Text = "Restaurante:";
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clienteIdLabel.Location = new System.Drawing.Point(38, 147);
            clienteIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(66, 20);
            clienteIdLabel.TabIndex = 7;
            clienteIdLabel.Text = "Cliente:";
            // 
            // trabalhadorIdLabel
            // 
            trabalhadorIdLabel.AutoSize = true;
            trabalhadorIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trabalhadorIdLabel.Location = new System.Drawing.Point(312, 83);
            trabalhadorIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            trabalhadorIdLabel.Name = "trabalhadorIdLabel";
            trabalhadorIdLabel.Size = new System.Drawing.Size(103, 20);
            trabalhadorIdLabel.TabIndex = 9;
            trabalhadorIdLabel.Text = "Trabalhador:";
            // 
            // estadoIdLabel
            // 
            estadoIdLabel.AutoSize = true;
            estadoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoIdLabel.Location = new System.Drawing.Point(312, 115);
            estadoIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            estadoIdLabel.Name = "estadoIdLabel";
            estadoIdLabel.Size = new System.Drawing.Size(66, 20);
            estadoIdLabel.TabIndex = 11;
            estadoIdLabel.Text = "Estado:";
            // 
            // restauranteDataSet3
            // 
            this.restauranteDataSet3.DataSetName = "RestauranteDataSet3";
            this.restauranteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // valorTotalTextBox
            // 
            this.valorTotalTextBox.Location = new System.Drawing.Point(147, 82);
            this.valorTotalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.valorTotalTextBox.Name = "valorTotalTextBox";
            this.valorTotalTextBox.Size = new System.Drawing.Size(132, 22);
            this.valorTotalTextBox.TabIndex = 4;
            // 
            // restauranteIdComboBox
            // 
            this.restauranteIdComboBox.DataSource = this.restauranteSetBindingSource;
            this.restauranteIdComboBox.DisplayMember = "Nome";
            this.restauranteIdComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restauranteIdComboBox.FormattingEnabled = true;
            this.restauranteIdComboBox.Location = new System.Drawing.Point(147, 114);
            this.restauranteIdComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.restauranteIdComboBox.Name = "restauranteIdComboBox";
            this.restauranteIdComboBox.Size = new System.Drawing.Size(132, 24);
            this.restauranteIdComboBox.TabIndex = 15;
            this.restauranteIdComboBox.ValueMember = "Id";
            // 
            // restauranteSetBindingSource
            // 
            this.restauranteSetBindingSource.DataMember = "RestauranteSet";
            this.restauranteSetBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // restGestDBDataSet
            // 
            this.restGestDBDataSet.DataSetName = "RestGestDBDataSet";
            this.restGestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteIdcomboBox
            // 
            this.clienteIdcomboBox.DataSource = this.pessoaSetBindingSource1;
            this.clienteIdcomboBox.DisplayMember = "Nome";
            this.clienteIdcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clienteIdcomboBox.FormattingEnabled = true;
            this.clienteIdcomboBox.Location = new System.Drawing.Point(147, 146);
            this.clienteIdcomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.clienteIdcomboBox.Name = "clienteIdcomboBox";
            this.clienteIdcomboBox.Size = new System.Drawing.Size(132, 24);
            this.clienteIdcomboBox.TabIndex = 16;
            this.clienteIdcomboBox.ValueMember = "Id";
            // 
            // pessoaSetBindingSource1
            // 
            this.pessoaSetBindingSource1.DataMember = "PessoaSet";
            this.pessoaSetBindingSource1.DataSource = this.restGestDBDataSet;
            // 
            // trabalhadorIdcomboBox
            // 
            this.trabalhadorIdcomboBox.DataSource = this.pessoaSetBindingSource2;
            this.trabalhadorIdcomboBox.DisplayMember = "Nome";
            this.trabalhadorIdcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trabalhadorIdcomboBox.FormattingEnabled = true;
            this.trabalhadorIdcomboBox.Location = new System.Drawing.Point(434, 82);
            this.trabalhadorIdcomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.trabalhadorIdcomboBox.Name = "trabalhadorIdcomboBox";
            this.trabalhadorIdcomboBox.Size = new System.Drawing.Size(132, 24);
            this.trabalhadorIdcomboBox.TabIndex = 17;
            this.trabalhadorIdcomboBox.ValueMember = "Id";
            // 
            // pessoaSetBindingSource2
            // 
            this.pessoaSetBindingSource2.DataMember = "PessoaSet";
            this.pessoaSetBindingSource2.DataSource = this.restGestDBDataSet;
            // 
            // estadoIdcomboBox
            // 
            this.estadoIdcomboBox.DataSource = this.estadoSetBindingSource;
            this.estadoIdcomboBox.DisplayMember = "estado";
            this.estadoIdcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.estadoIdcomboBox.FormattingEnabled = true;
            this.estadoIdcomboBox.Location = new System.Drawing.Point(434, 114);
            this.estadoIdcomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.estadoIdcomboBox.Name = "estadoIdcomboBox";
            this.estadoIdcomboBox.Size = new System.Drawing.Size(132, 24);
            this.estadoIdcomboBox.TabIndex = 18;
            this.estadoIdcomboBox.ValueMember = "Id";
            // 
            // estadoSetBindingSource
            // 
            this.estadoSetBindingSource.DataMember = "EstadoSet";
            this.estadoSetBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // restauranteSetTableAdapter
            // 
            this.restauranteSetTableAdapter.ClearBeforeFill = true;
            // 
            // pessoaSetClienteBindingSource
            // 
            this.pessoaSetClienteBindingSource.DataMember = "PessoaSet_Cliente";
            this.pessoaSetClienteBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // pessoaSet_ClienteTableAdapter
            // 
            this.pessoaSet_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // pessoaSetBindingSource
            // 
            this.pessoaSetBindingSource.DataMember = "PessoaSet";
            this.pessoaSetBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // pessoaSetTableAdapter
            // 
            this.pessoaSetTableAdapter.ClearBeforeFill = true;
            // 
            // fKClienteinheritsPessoaBindingSource
            // 
            this.fKClienteinheritsPessoaBindingSource.DataMember = "FK_Cliente_inherits_Pessoa";
            this.fKClienteinheritsPessoaBindingSource.DataSource = this.pessoaSetBindingSource;
            // 
            // estadoSetTableAdapter
            // 
            this.estadoSetTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDPedidoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cRUDPedidoToolStripMenuItem
            // 
            this.cRUDPedidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.concluirToolStripMenuItem,
            this.voltarToolStripMenuItem});
            this.cRUDPedidoToolStripMenuItem.Name = "cRUDPedidoToolStripMenuItem";
            this.cRUDPedidoToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.cRUDPedidoToolStripMenuItem.Text = "Pedido";
            // 
            // concluirToolStripMenuItem
            // 
            this.concluirToolStripMenuItem.Name = "concluirToolStripMenuItem";
            this.concluirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.concluirToolStripMenuItem.Text = "Concluir";
            this.concluirToolStripMenuItem.Click += new System.EventHandler(this.concluirToolStripMenuItem_Click);
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.voltarToolStripMenuItem.Text = "Voltar Pedidos";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // CRUD_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(611, 255);
            this.Controls.Add(this.estadoIdcomboBox);
            this.Controls.Add(this.trabalhadorIdcomboBox);
            this.Controls.Add(this.clienteIdcomboBox);
            this.Controls.Add(this.restauranteIdComboBox);
            this.Controls.Add(valorTotalLabel);
            this.Controls.Add(this.valorTotalTextBox);
            this.Controls.Add(restauranteIdLabel);
            this.Controls.Add(clienteIdLabel);
            this.Controls.Add(trabalhadorIdLabel);
            this.Controls.Add(estadoIdLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CRUD_Pedido";
            this.Text = "CRUD_Pedido";
            this.Load += new System.EventHandler(this.CRUD_Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClienteinheritsPessoaBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestauranteDataSet3 restauranteDataSet3;
        private System.Windows.Forms.TextBox valorTotalTextBox;
        private System.Windows.Forms.ComboBox restauranteIdComboBox;
        private System.Windows.Forms.ComboBox clienteIdcomboBox;
        private System.Windows.Forms.ComboBox trabalhadorIdcomboBox;
        private System.Windows.Forms.ComboBox estadoIdcomboBox;
        private RestGestDBDataSet restGestDBDataSet;
        private System.Windows.Forms.BindingSource restauranteSetBindingSource;
        private RestGestDBDataSetTableAdapters.RestauranteSetTableAdapter restauranteSetTableAdapter;
        private System.Windows.Forms.BindingSource pessoaSetClienteBindingSource;
        private RestGestDBDataSetTableAdapters.PessoaSet_ClienteTableAdapter pessoaSet_ClienteTableAdapter;
        private System.Windows.Forms.BindingSource pessoaSetBindingSource;
        private RestGestDBDataSetTableAdapters.PessoaSetTableAdapter pessoaSetTableAdapter;
        private System.Windows.Forms.BindingSource pessoaSetBindingSource1;
        private System.Windows.Forms.BindingSource pessoaSetBindingSource2;
        private System.Windows.Forms.BindingSource fKClienteinheritsPessoaBindingSource;
        private System.Windows.Forms.BindingSource estadoSetBindingSource;
        private RestGestDBDataSetTableAdapters.EstadoSetTableAdapter estadoSetTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cRUDPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
    }
}