namespace Projeto_DA_Restaurante
{
    partial class CriarPrato
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
            this.txbIngredientes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPrecoPrato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCriarRestaurante = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNomePrato = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txbIngredientes
            // 
            this.txbIngredientes.Location = new System.Drawing.Point(196, 126);
            this.txbIngredientes.Name = "txbIngredientes";
            this.txbIngredientes.Size = new System.Drawing.Size(174, 20);
            this.txbIngredientes.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(410, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Preço:";
            // 
            // txbPrecoPrato
            // 
            this.txbPrecoPrato.Location = new System.Drawing.Point(196, 183);
            this.txbPrecoPrato.Name = "txbPrecoPrato";
            this.txbPrecoPrato.Size = new System.Drawing.Size(174, 20);
            this.txbPrecoPrato.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ingredientes:";
            // 
            // btnCriarRestaurante
            // 
            this.btnCriarRestaurante.Location = new System.Drawing.Point(628, 183);
            this.btnCriarRestaurante.Name = "btnCriarRestaurante";
            this.btnCriarRestaurante.Size = new System.Drawing.Size(120, 46);
            this.btnCriarRestaurante.TabIndex = 13;
            this.btnCriarRestaurante.Text = "Criar";
            this.btnCriarRestaurante.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome:";
            // 
            // txbNomePrato
            // 
            this.txbNomePrato.Location = new System.Drawing.Point(196, 74);
            this.txbNomePrato.Name = "txbNomePrato";
            this.txbNomePrato.Size = new System.Drawing.Size(174, 20);
            this.txbNomePrato.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(410, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fotografia:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(566, 73);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(182, 21);
            this.cbCategoria.TabIndex = 22;
            // 
            // CriarPrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 255);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbIngredientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPrecoPrato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCriarRestaurante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNomePrato);
            this.Name = "CriarPrato";
            this.Text = "CriarPrato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbIngredientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPrecoPrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCriarRestaurante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNomePrato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCategoria;
    }
}