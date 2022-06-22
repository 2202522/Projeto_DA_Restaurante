namespace Projeto_DA_Restaurante
{
    partial class AssociarCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbValorPedido = new System.Windows.Forms.TextBox();
            this.btnConcluirAssociacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cliente:";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(171, 76);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(174, 21);
            this.cbCliente.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor:";
            // 
            // txbValorPedido
            // 
            this.txbValorPedido.Location = new System.Drawing.Point(506, 77);
            this.txbValorPedido.Name = "txbValorPedido";
            this.txbValorPedido.Size = new System.Drawing.Size(174, 20);
            this.txbValorPedido.TabIndex = 6;
            // 
            // btnConcluirAssociacao
            // 
            this.btnConcluirAssociacao.Location = new System.Drawing.Point(506, 138);
            this.btnConcluirAssociacao.Name = "btnConcluirAssociacao";
            this.btnConcluirAssociacao.Size = new System.Drawing.Size(174, 38);
            this.btnConcluirAssociacao.TabIndex = 10;
            this.btnConcluirAssociacao.Text = "Concluir";
            this.btnConcluirAssociacao.UseVisualStyleBackColor = true;
            // 
            // AssociarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 223);
            this.Controls.Add(this.btnConcluirAssociacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbValorPedido);
            this.Name = "AssociarCliente";
            this.Text = "AssociarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbValorPedido;
        private System.Windows.Forms.Button btnConcluirAssociacao;
    }
}