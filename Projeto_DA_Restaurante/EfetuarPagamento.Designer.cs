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
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label referenciaLabel;
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.metodoPagamentoIdcomboBox = new System.Windows.Forms.ComboBox();
            this.metodoPagamentoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restGestDBDataSet1 = new Projeto_DA_Restaurante.RestGestDBDataSet();
            this.pedidoIdcomboBox = new System.Windows.Forms.ComboBox();
            this.referenciaComboBox = new System.Windows.Forms.ComboBox();
            this.promocaosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metodoPagamentoSetTableAdapter1 = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.MetodoPagamentoSetTableAdapter();
            this.promocaosTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.PromocaosTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.efetuarPagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            valorLabel = new System.Windows.Forms.Label();
            metodoPagamentoIdLabel = new System.Windows.Forms.Label();
            pedidoIdLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            referenciaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaosBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.Location = new System.Drawing.Point(47, 87);
            valorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(116, 20);
            valorLabel.TabIndex = 18;
            valorLabel.Text = "Valor a Pagar:";
            // 
            // metodoPagamentoIdLabel
            // 
            metodoPagamentoIdLabel.AutoSize = true;
            metodoPagamentoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            metodoPagamentoIdLabel.Location = new System.Drawing.Point(47, 119);
            metodoPagamentoIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            metodoPagamentoIdLabel.Name = "metodoPagamentoIdLabel";
            metodoPagamentoIdLabel.Size = new System.Drawing.Size(158, 20);
            metodoPagamentoIdLabel.TabIndex = 20;
            metodoPagamentoIdLabel.Text = "Metodo Pagamento:";
            // 
            // pedidoIdLabel
            // 
            pedidoIdLabel.AutoSize = true;
            pedidoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pedidoIdLabel.Location = new System.Drawing.Point(435, 87);
            pedidoIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pedidoIdLabel.Name = "pedidoIdLabel";
            pedidoIdLabel.Size = new System.Drawing.Size(132, 20);
            pedidoIdLabel.TabIndex = 22;
            pedidoIdLabel.Text = "Valor do Pedido:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataLabel.Location = new System.Drawing.Point(435, 120);
            dataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(50, 20);
            dataLabel.TabIndex = 24;
            dataLabel.Text = "Data:";
            // 
            // referenciaLabel
            // 
            referenciaLabel.AutoSize = true;
            referenciaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            referenciaLabel.Location = new System.Drawing.Point(47, 155);
            referenciaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            referenciaLabel.Name = "referenciaLabel";
            referenciaLabel.Size = new System.Drawing.Size(95, 20);
            referenciaLabel.TabIndex = 27;
            referenciaLabel.Text = "Referencia:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTextBox.Location = new System.Drawing.Point(221, 84);
            this.valorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(191, 26);
            this.valorTextBox.TabIndex = 19;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDateTimePicker.Location = new System.Drawing.Point(597, 117);
            this.dataDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(191, 26);
            this.dataDateTimePicker.TabIndex = 25;
            // 
            // metodoPagamentoIdcomboBox
            // 
            this.metodoPagamentoIdcomboBox.DataSource = this.metodoPagamentoSetBindingSource;
            this.metodoPagamentoIdcomboBox.DisplayMember = "MetoPagamento";
            this.metodoPagamentoIdcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metodoPagamentoIdcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metodoPagamentoIdcomboBox.FormattingEnabled = true;
            this.metodoPagamentoIdcomboBox.Location = new System.Drawing.Point(221, 116);
            this.metodoPagamentoIdcomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.metodoPagamentoIdcomboBox.Name = "metodoPagamentoIdcomboBox";
            this.metodoPagamentoIdcomboBox.Size = new System.Drawing.Size(191, 28);
            this.metodoPagamentoIdcomboBox.TabIndex = 26;
            this.metodoPagamentoIdcomboBox.ValueMember = "Id";
            // 
            // metodoPagamentoSetBindingSource
            // 
            this.metodoPagamentoSetBindingSource.DataMember = "MetodoPagamentoSet";
            this.metodoPagamentoSetBindingSource.DataSource = this.restGestDBDataSet1;
            // 
            // restGestDBDataSet1
            // 
            this.restGestDBDataSet1.DataSetName = "RestGestDBDataSet";
            this.restGestDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoIdcomboBox
            // 
            this.pedidoIdcomboBox.DisplayMember = "Id";
            this.pedidoIdcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pedidoIdcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedidoIdcomboBox.FormattingEnabled = true;
            this.pedidoIdcomboBox.Location = new System.Drawing.Point(597, 84);
            this.pedidoIdcomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.pedidoIdcomboBox.Name = "pedidoIdcomboBox";
            this.pedidoIdcomboBox.Size = new System.Drawing.Size(191, 28);
            this.pedidoIdcomboBox.TabIndex = 27;
            this.pedidoIdcomboBox.ValueMember = "Id";
            // 
            // referenciaComboBox
            // 
            this.referenciaComboBox.DataSource = this.promocaosBindingSource;
            this.referenciaComboBox.DisplayMember = "Referencia";
            this.referenciaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.referenciaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenciaComboBox.FormattingEnabled = true;
            this.referenciaComboBox.Location = new System.Drawing.Point(221, 151);
            this.referenciaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.referenciaComboBox.Name = "referenciaComboBox";
            this.referenciaComboBox.Size = new System.Drawing.Size(191, 28);
            this.referenciaComboBox.TabIndex = 28;
            this.referenciaComboBox.ValueMember = "IdPromocao";
            // 
            // promocaosBindingSource
            // 
            this.promocaosBindingSource.DataMember = "Promocaos";
            this.promocaosBindingSource.DataSource = this.restGestDBDataSet1;
            // 
            // metodoPagamentoSetTableAdapter1
            // 
            this.metodoPagamentoSetTableAdapter1.ClearBeforeFill = true;
            // 
            // promocaosTableAdapter
            // 
            this.promocaosTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.efetuarPagamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // efetuarPagamentoToolStripMenuItem
            // 
            this.efetuarPagamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.concluirToolStripMenuItem,
            this.voltarPedidosToolStripMenuItem});
            this.efetuarPagamentoToolStripMenuItem.Name = "efetuarPagamentoToolStripMenuItem";
            this.efetuarPagamentoToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.efetuarPagamentoToolStripMenuItem.Text = "Efetuar Pagamento";
            // 
            // concluirToolStripMenuItem
            // 
            this.concluirToolStripMenuItem.Name = "concluirToolStripMenuItem";
            this.concluirToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.concluirToolStripMenuItem.Text = "Concluir";
            this.concluirToolStripMenuItem.Click += new System.EventHandler(this.concluirToolStripMenuItem_Click);
            // 
            // voltarPedidosToolStripMenuItem
            // 
            this.voltarPedidosToolStripMenuItem.Name = "voltarPedidosToolStripMenuItem";
            this.voltarPedidosToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.voltarPedidosToolStripMenuItem.Text = "Voltar Pedidos";
            this.voltarPedidosToolStripMenuItem.Click += new System.EventHandler(this.voltarPedidosToolStripMenuItem_Click);
            // 
            // EfetuarPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(867, 265);
            this.Controls.Add(referenciaLabel);
            this.Controls.Add(this.referenciaComboBox);
            this.Controls.Add(this.pedidoIdcomboBox);
            this.Controls.Add(this.metodoPagamentoIdcomboBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(metodoPagamentoIdLabel);
            this.Controls.Add(pedidoIdLabel);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EfetuarPagamento";
            this.Text = "Efetuar Pagamento";
            this.Load += new System.EventHandler(this.EfetuarPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaosBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.ComboBox metodoPagamentoIdcomboBox;
        private System.Windows.Forms.ComboBox pedidoIdcomboBox;
        private RestGestDBDataSet restGestDBDataSet;
        private RestGestDBDataSetTableAdapters.MetodoPagamentoSetTableAdapter metodoPagamentoSetTableAdapter;
        private RestGestDBDataSetTableAdapters.PedidoItemMenuTableAdapter pedidoItemMenuTableAdapter;
        private RestGestDBDataSetTableAdapters.PedidoSetTableAdapter pedidoSetTableAdapter;
        private System.Windows.Forms.ComboBox referenciaComboBox;
        private RestGestDBDataSet restGestDBDataSet1;
        private System.Windows.Forms.BindingSource metodoPagamentoSetBindingSource;
        private RestGestDBDataSetTableAdapters.MetodoPagamentoSetTableAdapter metodoPagamentoSetTableAdapter1;
        private System.Windows.Forms.BindingSource promocaosBindingSource;
        private RestGestDBDataSetTableAdapters.PromocaosTableAdapter promocaosTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem efetuarPagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarPedidosToolStripMenuItem;
    }
}