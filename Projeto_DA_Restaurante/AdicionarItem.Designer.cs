namespace Projeto_DA_Restaurante
{
    partial class AdicionarItem
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
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPrato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbQuantidadeItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(529, 142);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(174, 38);
            this.btnAdicionarItem.TabIndex = 15;
            this.btnAdicionarItem.Text = "Adicionar";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Prato:";
            // 
            // cbPrato
            // 
            this.cbPrato.FormattingEnabled = true;
            this.cbPrato.Location = new System.Drawing.Point(172, 80);
            this.cbPrato.Name = "cbPrato";
            this.cbPrato.Size = new System.Drawing.Size(174, 21);
            this.cbPrato.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quantidade:";
            // 
            // txbQuantidadeItem
            // 
            this.txbQuantidadeItem.Location = new System.Drawing.Point(529, 81);
            this.txbQuantidadeItem.Name = "txbQuantidadeItem";
            this.txbQuantidadeItem.Size = new System.Drawing.Size(174, 20);
            this.txbQuantidadeItem.TabIndex = 11;
            // 
            // AdicionarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 223);
            this.Controls.Add(this.btnAdicionarItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPrato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbQuantidadeItem);
            this.Name = "AdicionarItem";
            this.Text = "AdicionarItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbQuantidadeItem;
    }
}