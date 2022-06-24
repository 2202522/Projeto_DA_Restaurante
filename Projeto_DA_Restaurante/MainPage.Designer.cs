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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "MAIN PAGE";
            // 
            // btnUtilizador
            // 
            this.btnUtilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilizador.Location = new System.Drawing.Point(306, 189);
            this.btnUtilizador.Name = "btnUtilizador";
            this.btnUtilizador.Size = new System.Drawing.Size(189, 92);
            this.btnUtilizador.TabIndex = 3;
            this.btnUtilizador.Text = "Utilizadores";
            this.btnUtilizador.UseVisualStyleBackColor = true;
            this.btnUtilizador.Click += new System.EventHandler(this.btnUtilizador_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.Location = new System.Drawing.Point(535, 189);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(189, 92);
            this.btnPedidos.TabIndex = 4;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnRestaurante
            // 
            this.btnRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurante.Location = new System.Drawing.Point(77, 189);
            this.btnRestaurante.Name = "btnRestaurante";
            this.btnRestaurante.Size = new System.Drawing.Size(189, 92);
            this.btnRestaurante.TabIndex = 5;
            this.btnRestaurante.Text = "Restaurante";
            this.btnRestaurante.UseVisualStyleBackColor = true;
            this.btnRestaurante.Click += new System.EventHandler(this.btnRestaurante_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}