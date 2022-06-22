namespace Projeto_DA_Restaurante
{
    partial class AssociarTrabalhadores
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
            this.btnAssociarPrato = new System.Windows.Forms.Button();
            this.txbPosicao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPrecoPrato = new System.Windows.Forms.TextBox();
            this.cbNomePrato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAssociarPrato
            // 
            this.btnAssociarPrato.Location = new System.Drawing.Point(581, 160);
            this.btnAssociarPrato.Name = "btnAssociarPrato";
            this.btnAssociarPrato.Size = new System.Drawing.Size(147, 46);
            this.btnAssociarPrato.TabIndex = 39;
            this.btnAssociarPrato.Text = "Associar";
            this.btnAssociarPrato.UseVisualStyleBackColor = true;
            // 
            // txbPosicao
            // 
            this.txbPosicao.Location = new System.Drawing.Point(206, 122);
            this.txbPosicao.Name = "txbPosicao";
            this.txbPosicao.Size = new System.Drawing.Size(182, 20);
            this.txbPosicao.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Posição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 36;
            this.label3.Text = "Preço:";
            // 
            // txbPrecoPrato
            // 
            this.txbPrecoPrato.Location = new System.Drawing.Point(550, 65);
            this.txbPrecoPrato.Name = "txbPrecoPrato";
            this.txbPrecoPrato.Size = new System.Drawing.Size(182, 20);
            this.txbPrecoPrato.TabIndex = 35;
            // 
            // cbNomePrato
            // 
            this.cbNomePrato.FormattingEnabled = true;
            this.cbNomePrato.Location = new System.Drawing.Point(206, 65);
            this.cbNomePrato.Name = "cbNomePrato";
            this.cbNomePrato.Size = new System.Drawing.Size(182, 21);
            this.cbNomePrato.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nome:";
            // 
            // AssociarTrabalhadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 255);
            this.Controls.Add(this.btnAssociarPrato);
            this.Controls.Add(this.txbPosicao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPrecoPrato);
            this.Controls.Add(this.cbNomePrato);
            this.Controls.Add(this.label1);
            this.Name = "AssociarTrabalhadores";
            this.Text = "AssociarTrabalhadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAssociarPrato;
        private System.Windows.Forms.TextBox txbPosicao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPrecoPrato;
        private System.Windows.Forms.ComboBox cbNomePrato;
        private System.Windows.Forms.Label label1;
    }
}