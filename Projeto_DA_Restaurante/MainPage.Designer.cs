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
            this.btnRestaurante = new System.Windows.Forms.Button();
            this.btnUtilizador = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRestaurante
            // 
            this.btnRestaurante.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurante.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRestaurante.Location = new System.Drawing.Point(65, 193);
            this.btnRestaurante.Name = "btnRestaurante";
            this.btnRestaurante.Size = new System.Drawing.Size(156, 84);
            this.btnRestaurante.TabIndex = 0;
            this.btnRestaurante.Text = "Restaurantes";
            this.btnRestaurante.UseVisualStyleBackColor = false;
            this.btnRestaurante.Click += new System.EventHandler(this.btnRestaurante_Click);
            // 
            // btnUtilizador
            // 
            this.btnUtilizador.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUtilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilizador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUtilizador.Location = new System.Drawing.Point(575, 192);
            this.btnUtilizador.Name = "btnUtilizador";
            this.btnUtilizador.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUtilizador.Size = new System.Drawing.Size(156, 84);
            this.btnUtilizador.TabIndex = 1;
            this.btnUtilizador.Text = "Utilizadores";
            this.btnUtilizador.UseVisualStyleBackColor = false;
            this.btnUtilizador.Click += new System.EventHandler(this.btnUtilizador_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.Location = new System.Drawing.Point(309, 193);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(152, 85);
            this.btnPedidos.TabIndex = 2;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "Home Page";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnUtilizador);
            this.Controls.Add(this.btnRestaurante);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestaurante;
        private System.Windows.Forms.Button btnUtilizador;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Label label1;
    }
}

