namespace Projeto_DA_Restaurante
{
    partial class AssociarMenu
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
            this.cbNomePrato = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPrecoPrato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbingredientes = new System.Windows.Forms.TextBox();
            this.btnAssociarPrato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbNomePrato
            // 
            this.cbNomePrato.FormattingEnabled = true;
            this.cbNomePrato.Location = new System.Drawing.Point(127, 64);
            this.cbNomePrato.Name = "cbNomePrato";
            this.cbNomePrato.Size = new System.Drawing.Size(182, 21);
            this.cbNomePrato.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Fotografia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Preço:";
            // 
            // txbPrecoPrato
            // 
            this.txbPrecoPrato.Location = new System.Drawing.Point(127, 118);
            this.txbPrecoPrato.Name = "txbPrecoPrato";
            this.txbPrecoPrato.Size = new System.Drawing.Size(182, 20);
            this.txbPrecoPrato.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ingredientes:";
            // 
            // txbingredientes
            // 
            this.txbingredientes.Location = new System.Drawing.Point(535, 118);
            this.txbingredientes.Name = "txbingredientes";
            this.txbingredientes.Size = new System.Drawing.Size(182, 20);
            this.txbingredientes.TabIndex = 30;
            // 
            // btnAssociarPrato
            // 
            this.btnAssociarPrato.Location = new System.Drawing.Point(570, 168);
            this.btnAssociarPrato.Name = "btnAssociarPrato";
            this.btnAssociarPrato.Size = new System.Drawing.Size(147, 46);
            this.btnAssociarPrato.TabIndex = 31;
            this.btnAssociarPrato.Text = "Associar";
            this.btnAssociarPrato.UseVisualStyleBackColor = true;
            // 
            // AssociarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 255);
            this.Controls.Add(this.btnAssociarPrato);
            this.Controls.Add(this.txbingredientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPrecoPrato);
            this.Controls.Add(this.cbNomePrato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "AssociarMenu";
            this.Text = "CriarMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNomePrato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPrecoPrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbingredientes;
        private System.Windows.Forms.Button btnAssociarPrato;
    }
}