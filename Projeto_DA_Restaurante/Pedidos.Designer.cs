namespace Projeto_DA_Restaurante
{
    partial class Pedidos
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
            this.DataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.CRUD_Pedido = new System.Windows.Forms.Button();
            this.Exportar = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.btnAdicionarPrato = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPedidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewPedidos
            // 
            this.DataGridViewPedidos.AllowUserToAddRows = false;
            this.DataGridViewPedidos.AllowUserToDeleteRows = false;
            this.DataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPedidos.Location = new System.Drawing.Point(9, 19);
            this.DataGridViewPedidos.Name = "DataGridViewPedidos";
            this.DataGridViewPedidos.ReadOnly = true;
            this.DataGridViewPedidos.Size = new System.Drawing.Size(544, 220);
            this.DataGridViewPedidos.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGridViewPedidos);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 248);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 340);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CRUD_Pedido
            // 
            this.CRUD_Pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRUD_Pedido.Location = new System.Drawing.Point(389, 282);
            this.CRUD_Pedido.Name = "CRUD_Pedido";
            this.CRUD_Pedido.Size = new System.Drawing.Size(90, 40);
            this.CRUD_Pedido.TabIndex = 8;
            this.CRUD_Pedido.Text = "Criar/Editar Pedido";
            this.CRUD_Pedido.UseVisualStyleBackColor = true;
            this.CRUD_Pedido.Click += new System.EventHandler(this.CRUD_Pedido_Click);
            // 
            // Exportar
            // 
            this.Exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exportar.Location = new System.Drawing.Point(485, 282);
            this.Exportar.Name = "Exportar";
            this.Exportar.Size = new System.Drawing.Size(90, 40);
            this.Exportar.TabIndex = 9;
            this.Exportar.Text = "Exportar (PDF)";
            this.Exportar.UseVisualStyleBackColor = true;
            this.Exportar.Click += new System.EventHandler(this.Exportar_Click);
            // 
            // btnPagamento
            // 
            this.btnPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamento.Location = new System.Drawing.Point(197, 282);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(90, 40);
            this.btnPagamento.TabIndex = 10;
            this.btnPagamento.Text = "Efetuar Pagamento";
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // btnAdicionarPrato
            // 
            this.btnAdicionarPrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarPrato.Location = new System.Drawing.Point(293, 282);
            this.btnAdicionarPrato.Name = "btnAdicionarPrato";
            this.btnAdicionarPrato.Size = new System.Drawing.Size(90, 40);
            this.btnAdicionarPrato.TabIndex = 11;
            this.btnAdicionarPrato.Text = " Associar Prato a um Pedido";
            this.btnAdicionarPrato.UseVisualStyleBackColor = true;
            this.btnAdicionarPrato.Click += new System.EventHandler(this.btnAdicionarPrato_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 392);
            this.Controls.Add(this.btnAdicionarPrato);
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.Exportar);
            this.Controls.Add(this.CRUD_Pedido);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPedidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridViewPedidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button CRUD_Pedido;
        private System.Windows.Forms.Button Exportar;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Button btnAdicionarPrato;
    }
}