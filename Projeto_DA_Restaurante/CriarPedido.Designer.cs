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
            this.label2 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbValorPedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTrabalhador = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRestaurante = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEstadoPedido = new System.Windows.Forms.ComboBox();
            this.btnConcluirPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cliente:";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(204, 53);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(174, 21);
            this.cbCliente.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor:";
            // 
            // txbValorPedido
            // 
            this.txbValorPedido.Location = new System.Drawing.Point(553, 107);
            this.txbValorPedido.Name = "txbValorPedido";
            this.txbValorPedido.Size = new System.Drawing.Size(174, 20);
            this.txbValorPedido.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Trabalhador:";
            // 
            // cbTrabalhador
            // 
            this.cbTrabalhador.FormattingEnabled = true;
            this.cbTrabalhador.Location = new System.Drawing.Point(556, 53);
            this.cbTrabalhador.Name = "cbTrabalhador";
            this.cbTrabalhador.Size = new System.Drawing.Size(174, 21);
            this.cbTrabalhador.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Restaurante:";
            // 
            // cbRestaurante
            // 
            this.cbRestaurante.FormattingEnabled = true;
            this.cbRestaurante.Location = new System.Drawing.Point(201, 106);
            this.cbRestaurante.Name = "cbRestaurante";
            this.cbRestaurante.Size = new System.Drawing.Size(174, 21);
            this.cbRestaurante.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Estado:";
            // 
            // cbEstadoPedido
            // 
            this.cbEstadoPedido.FormattingEnabled = true;
            this.cbEstadoPedido.Location = new System.Drawing.Point(204, 158);
            this.cbEstadoPedido.Name = "cbEstadoPedido";
            this.cbEstadoPedido.Size = new System.Drawing.Size(174, 21);
            this.cbEstadoPedido.TabIndex = 14;
            // 
            // btnConcluirPedido
            // 
            this.btnConcluirPedido.Location = new System.Drawing.Point(556, 149);
            this.btnConcluirPedido.Name = "btnConcluirPedido";
            this.btnConcluirPedido.Size = new System.Drawing.Size(174, 38);
            this.btnConcluirPedido.TabIndex = 16;
            this.btnConcluirPedido.Text = "Concluir";
            this.btnConcluirPedido.UseVisualStyleBackColor = true;
            // 
            // CriarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 223);
            this.Controls.Add(this.btnConcluirPedido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbEstadoPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbRestaurante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTrabalhador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbValorPedido);
            this.Name = "CriarPedido";
            this.Text = "CriarPedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbValorPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTrabalhador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRestaurante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEstadoPedido;
        private System.Windows.Forms.Button btnConcluirPedido;
    }
}