namespace Projeto_DA_Restaurante
{
    partial class MainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUtilizador = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnRestaurante = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnPromocoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "MAIN PAGE";
            // 
            // btnUtilizador
            // 
            this.btnUtilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilizador.Location = new System.Drawing.Point(95, 107);
            this.btnUtilizador.Name = "btnUtilizador";
            this.btnUtilizador.Size = new System.Drawing.Size(268, 85);
            this.btnUtilizador.TabIndex = 3;
            this.btnUtilizador.Text = "Utilizadores";
            this.btnUtilizador.UseVisualStyleBackColor = true;
            this.btnUtilizador.Click += new System.EventHandler(this.btnUtilizador_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.Location = new System.Drawing.Point(408, 107);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(268, 85);
            this.btnPedidos.TabIndex = 4;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnRestaurante
            // 
            this.btnRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurante.Location = new System.Drawing.Point(95, 214);
            this.btnRestaurante.Name = "btnRestaurante";
            this.btnRestaurante.Size = new System.Drawing.Size(268, 85);
            this.btnRestaurante.TabIndex = 5;
            this.btnRestaurante.Text = "Restaurante";
            this.btnRestaurante.UseVisualStyleBackColor = true;
            this.btnRestaurante.Click += new System.EventHandler(this.btnRestaurante_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(408, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 85);
            this.button1.TabIndex = 6;
            this.button1.Text = "Estado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.Location = new System.Drawing.Point(408, 324);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(268, 85);
            this.btnVendas.TabIndex = 8;
            this.btnVendas.Text = "Gestão de Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnPromocoes
            // 
            this.btnPromocoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromocoes.Location = new System.Drawing.Point(95, 324);
            this.btnPromocoes.Name = "btnPromocoes";
            this.btnPromocoes.Size = new System.Drawing.Size(268, 85);
            this.btnPromocoes.TabIndex = 7;
            this.btnPromocoes.Text = "Gestão de Promoções";
            this.btnPromocoes.UseVisualStyleBackColor = true;
            this.btnPromocoes.Click += new System.EventHandler(this.btnPromocoes_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnPromocoes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRestaurante);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnUtilizador);
            this.Controls.Add(this.label1);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUtilizador;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnRestaurante;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnPromocoes;
    }
}