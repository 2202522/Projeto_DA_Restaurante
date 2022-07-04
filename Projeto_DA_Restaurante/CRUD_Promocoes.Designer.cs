namespace Projeto_DA_Restaurante
{
    partial class CRUD_Promocoes
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
            System.Windows.Forms.Label referenciaLabel;
            System.Windows.Forms.Label percentagemPromocaoLabel;
            this.btnBack = new System.Windows.Forms.Button();
            this.concluirbutton = new System.Windows.Forms.Button();
            this.referenciaTextBox = new System.Windows.Forms.TextBox();
            this.percentagemPromocaoTextBox = new System.Windows.Forms.TextBox();
            referenciaLabel = new System.Windows.Forms.Label();
            percentagemPromocaoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 111);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // concluirbutton
            // 
            this.concluirbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concluirbutton.Location = new System.Drawing.Point(258, 111);
            this.concluirbutton.Name = "concluirbutton";
            this.concluirbutton.Size = new System.Drawing.Size(90, 40);
            this.concluirbutton.TabIndex = 9;
            this.concluirbutton.Text = "Concluir";
            this.concluirbutton.UseVisualStyleBackColor = true;
            this.concluirbutton.Click += new System.EventHandler(this.concluirbutton_Click);
            // 
            // referenciaLabel
            // 
            referenciaLabel.AutoSize = true;
            referenciaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            referenciaLabel.Location = new System.Drawing.Point(26, 30);
            referenciaLabel.Name = "referenciaLabel";
            referenciaLabel.Size = new System.Drawing.Size(76, 16);
            referenciaLabel.TabIndex = 10;
            referenciaLabel.Text = "Referencia:";
            // 
            // referenciaTextBox
            // 
            this.referenciaTextBox.Location = new System.Drawing.Point(192, 29);
            this.referenciaTextBox.Name = "referenciaTextBox";
            this.referenciaTextBox.Size = new System.Drawing.Size(156, 20);
            this.referenciaTextBox.TabIndex = 11;
            // 
            // percentagemPromocaoLabel
            // 
            percentagemPromocaoLabel.AutoSize = true;
            percentagemPromocaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            percentagemPromocaoLabel.Location = new System.Drawing.Point(26, 56);
            percentagemPromocaoLabel.Name = "percentagemPromocaoLabel";
            percentagemPromocaoLabel.Size = new System.Drawing.Size(157, 16);
            percentagemPromocaoLabel.TabIndex = 12;
            percentagemPromocaoLabel.Text = "Percentagem Promocao:";
            // 
            // percentagemPromocaoTextBox
            // 
            this.percentagemPromocaoTextBox.Location = new System.Drawing.Point(192, 55);
            this.percentagemPromocaoTextBox.Name = "percentagemPromocaoTextBox";
            this.percentagemPromocaoTextBox.Size = new System.Drawing.Size(156, 20);
            this.percentagemPromocaoTextBox.TabIndex = 13;
            // 
            // CRUD_Promocoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 170);
            this.Controls.Add(referenciaLabel);
            this.Controls.Add(this.referenciaTextBox);
            this.Controls.Add(percentagemPromocaoLabel);
            this.Controls.Add(this.percentagemPromocaoTextBox);
            this.Controls.Add(this.concluirbutton);
            this.Controls.Add(this.btnBack);
            this.Name = "CRUD_Promocoes";
            this.Text = "CRUD_Promocoes";
            this.Load += new System.EventHandler(this.CRUD_Promocoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button concluirbutton;
        private System.Windows.Forms.TextBox referenciaTextBox;
        private System.Windows.Forms.TextBox percentagemPromocaoTextBox;
    }
}