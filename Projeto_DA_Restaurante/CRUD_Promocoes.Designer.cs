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
            this.referenciaLabel = new System.Windows.Forms.Label();
            this.percentagemPromocaoLabel = new System.Windows.Forms.Label();
            this.referenciaTextBox = new System.Windows.Forms.TextBox();
            this.percentagemPromocaoTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cRUdPromocoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarPromocoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // referenciaLabel
            // 
            this.referenciaLabel.AutoSize = true;
            this.referenciaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenciaLabel.Location = new System.Drawing.Point(33, 75);
            this.referenciaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.referenciaLabel.Name = "referenciaLabel";
            this.referenciaLabel.Size = new System.Drawing.Size(95, 20);
            this.referenciaLabel.TabIndex = 10;
            this.referenciaLabel.Text = "Referencia:";
            // 
            // percentagemPromocaoLabel
            // 
            this.percentagemPromocaoLabel.AutoSize = true;
            this.percentagemPromocaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentagemPromocaoLabel.Location = new System.Drawing.Point(33, 107);
            this.percentagemPromocaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.percentagemPromocaoLabel.Name = "percentagemPromocaoLabel";
            this.percentagemPromocaoLabel.Size = new System.Drawing.Size(194, 20);
            this.percentagemPromocaoLabel.TabIndex = 12;
            this.percentagemPromocaoLabel.Text = "Percentagem Promocao:";
            // 
            // referenciaTextBox
            // 
            this.referenciaTextBox.Location = new System.Drawing.Point(254, 74);
            this.referenciaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.referenciaTextBox.Name = "referenciaTextBox";
            this.referenciaTextBox.Size = new System.Drawing.Size(207, 22);
            this.referenciaTextBox.TabIndex = 11;
            // 
            // percentagemPromocaoTextBox
            // 
            this.percentagemPromocaoTextBox.Location = new System.Drawing.Point(254, 106);
            this.percentagemPromocaoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.percentagemPromocaoTextBox.Name = "percentagemPromocaoTextBox";
            this.percentagemPromocaoTextBox.Size = new System.Drawing.Size(207, 22);
            this.percentagemPromocaoTextBox.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUdPromocoesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cRUdPromocoesToolStripMenuItem
            // 
            this.cRUdPromocoesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.concluirToolStripMenuItem,
            this.voltarPromocoesToolStripMenuItem});
            this.cRUdPromocoesToolStripMenuItem.Name = "cRUdPromocoesToolStripMenuItem";
            this.cRUdPromocoesToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.cRUdPromocoesToolStripMenuItem.Text = "Promocoes";
            // 
            // concluirToolStripMenuItem
            // 
            this.concluirToolStripMenuItem.Name = "concluirToolStripMenuItem";
            this.concluirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.concluirToolStripMenuItem.Text = "Concluir";
            this.concluirToolStripMenuItem.Click += new System.EventHandler(this.concluirToolStripMenuItem_Click);
            // 
            // voltarPromocoesToolStripMenuItem
            // 
            this.voltarPromocoesToolStripMenuItem.Name = "voltarPromocoesToolStripMenuItem";
            this.voltarPromocoesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.voltarPromocoesToolStripMenuItem.Text = "Voltar Promocoes";
            this.voltarPromocoesToolStripMenuItem.Click += new System.EventHandler(this.voltarPromocoesToolStripMenuItem_Click);
            // 
            // CRUD_Promocoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(491, 209);
            this.Controls.Add(this.referenciaLabel);
            this.Controls.Add(this.referenciaTextBox);
            this.Controls.Add(this.percentagemPromocaoLabel);
            this.Controls.Add(this.percentagemPromocaoTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CRUD_Promocoes";
            this.Text = "CRUD_Promocoes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox referenciaTextBox;
        private System.Windows.Forms.TextBox percentagemPromocaoTextBox;
        private System.Windows.Forms.Label referenciaLabel;
        private System.Windows.Forms.Label percentagemPromocaoLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cRUdPromocoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarPromocoesToolStripMenuItem;
    }
}