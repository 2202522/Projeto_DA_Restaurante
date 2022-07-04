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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.metodoPagamentoIdcomboBox = new System.Windows.Forms.ComboBox();
            this.pedidoIdcomboBox = new System.Windows.Forms.ComboBox();
            this.referenciaComboBox = new System.Windows.Forms.ComboBox();
            this.restGestDBDataSet1 = new Projeto_DA_Restaurante.RestGestDBDataSet();
            this.metodoPagamentoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metodoPagamentoSetTableAdapter1 = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.MetodoPagamentoSetTableAdapter();
            this.promocaosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promocaosTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.PromocaosTableAdapter();
            valorLabel = new System.Windows.Forms.Label();
            metodoPagamentoIdLabel = new System.Windows.Forms.Label();
            pedidoIdLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            referenciaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.Location = new System.Drawing.Point(37, 53);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(93, 16);
            valorLabel.TabIndex = 18;
            valorLabel.Text = "Valor a Pagar:";
            // 
            // metodoPagamentoIdLabel
            // 
            metodoPagamentoIdLabel.AutoSize = true;
            metodoPagamentoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            metodoPagamentoIdLabel.Location = new System.Drawing.Point(37, 79);
            metodoPagamentoIdLabel.Name = "metodoPagamentoIdLabel";
            metodoPagamentoIdLabel.Size = new System.Drawing.Size(129, 16);
            metodoPagamentoIdLabel.TabIndex = 20;
            metodoPagamentoIdLabel.Text = "Metodo Pagamento:";
            // 
            // pedidoIdLabel
            // 
            pedidoIdLabel.AutoSize = true;
            pedidoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pedidoIdLabel.Location = new System.Drawing.Point(328, 53);
            pedidoIdLabel.Name = "pedidoIdLabel";
            pedidoIdLabel.Size = new System.Drawing.Size(108, 16);
            pedidoIdLabel.TabIndex = 22;
            pedidoIdLabel.Text = "Valor do Pedido:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataLabel.Location = new System.Drawing.Point(328, 80);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(39, 16);
            dataLabel.TabIndex = 24;
            dataLabel.Text = "Data:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 167);
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
            this.btnConcluir.Location = new System.Drawing.Point(540, 167);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(90, 40);
            this.btnConcluir.TabIndex = 15;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // valorTextBox
            // 
            this.valorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTextBox.Location = new System.Drawing.Point(167, 50);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(144, 22);
            this.valorTextBox.TabIndex = 19;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDateTimePicker.Location = new System.Drawing.Point(449, 77);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(144, 22);
            this.dataDateTimePicker.TabIndex = 25;
            this.dataDateTimePicker.ValueChanged += new System.EventHandler(this.dataDateTimePicker_ValueChanged);
            // 
            // metodoPagamentoIdcomboBox
            // 
            this.metodoPagamentoIdcomboBox.DataSource = this.metodoPagamentoSetBindingSource;
            this.metodoPagamentoIdcomboBox.DisplayMember = "MetoPagamento";
            this.metodoPagamentoIdcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metodoPagamentoIdcomboBox.FormattingEnabled = true;
            this.metodoPagamentoIdcomboBox.Location = new System.Drawing.Point(167, 76);
            this.metodoPagamentoIdcomboBox.Name = "metodoPagamentoIdcomboBox";
            this.metodoPagamentoIdcomboBox.Size = new System.Drawing.Size(144, 24);
            this.metodoPagamentoIdcomboBox.TabIndex = 26;
            this.metodoPagamentoIdcomboBox.ValueMember = "Id";
            // 
            // pedidoIdcomboBox
            // 
            this.pedidoIdcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedidoIdcomboBox.FormattingEnabled = true;
            this.pedidoIdcomboBox.Location = new System.Drawing.Point(449, 50);
            this.pedidoIdcomboBox.Name = "pedidoIdcomboBox";
            this.pedidoIdcomboBox.Size = new System.Drawing.Size(144, 24);
            this.pedidoIdcomboBox.TabIndex = 27;
            this.pedidoIdcomboBox.ValueMember = "Id";
            // 
            // referenciaLabel
            // 
            referenciaLabel.AutoSize = true;
            referenciaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            referenciaLabel.Location = new System.Drawing.Point(37, 108);
            referenciaLabel.Name = "referenciaLabel";
            referenciaLabel.Size = new System.Drawing.Size(76, 16);
            referenciaLabel.TabIndex = 27;
            referenciaLabel.Text = "Referencia:";
            // 
            // referenciaComboBox
            // 
            this.referenciaComboBox.DataSource = this.promocaosBindingSource;
            this.referenciaComboBox.DisplayMember = "Referencia";
            this.referenciaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenciaComboBox.FormattingEnabled = true;
            this.referenciaComboBox.Location = new System.Drawing.Point(167, 105);
            this.referenciaComboBox.Name = "referenciaComboBox";
            this.referenciaComboBox.Size = new System.Drawing.Size(144, 24);
            this.referenciaComboBox.TabIndex = 28;
            this.referenciaComboBox.ValueMember = "IdPromocao";
            // 
            // restGestDBDataSet1
            // 
            this.restGestDBDataSet1.DataSetName = "RestGestDBDataSet";
            this.restGestDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metodoPagamentoSetBindingSource
            // 
            this.metodoPagamentoSetBindingSource.DataMember = "MetodoPagamentoSet";
            this.metodoPagamentoSetBindingSource.DataSource = this.restGestDBDataSet1;
            // 
            // metodoPagamentoSetTableAdapter1
            // 
            this.metodoPagamentoSetTableAdapter1.ClearBeforeFill = true;
            // 
            // promocaosBindingSource
            // 
            this.promocaosBindingSource.DataMember = "Promocaos";
            this.promocaosBindingSource.DataSource = this.restGestDBDataSet1;
            // 
            // promocaosTableAdapter
            // 
            this.promocaosTableAdapter.ClearBeforeFill = true;
            // 
            // EfetuarPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 234);
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
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnBack);
            this.Name = "EfetuarPagamento";
            this.Text = "Efetuar Pagamento";
            this.Load += new System.EventHandler(this.EfetuarPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConcluir;
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
    }
}