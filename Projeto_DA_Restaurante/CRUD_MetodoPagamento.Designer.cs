namespace Projeto_DA_Restaurante
{
    partial class CRUD_MetodoPagamento
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
            this.metoPagamentoTextBox = new System.Windows.Forms.TextBox();
            this.ativoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cRUDMetodoPagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarRestaurantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metoPagamentoTextBox
            // 
            this.metoPagamentoTextBox.Location = new System.Drawing.Point(171, 81);
            this.metoPagamentoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.metoPagamentoTextBox.Name = "metoPagamentoTextBox";
            this.metoPagamentoTextBox.Size = new System.Drawing.Size(233, 22);
            this.metoPagamentoTextBox.TabIndex = 10;
            // 
            // ativoTextBox
            // 
            this.ativoTextBox.Location = new System.Drawing.Point(171, 124);
            this.ativoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ativoTextBox.Name = "ativoTextBox";
            this.ativoTextBox.Size = new System.Drawing.Size(233, 22);
            this.ativoTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome Metodo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ativo:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDMetodoPagamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(451, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cRUDMetodoPagamentoToolStripMenuItem
            // 
            this.cRUDMetodoPagamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.concluirToolStripMenuItem,
            this.voltarRestaurantToolStripMenuItem});
            this.cRUDMetodoPagamentoToolStripMenuItem.Name = "cRUDMetodoPagamentoToolStripMenuItem";
            this.cRUDMetodoPagamentoToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.cRUDMetodoPagamentoToolStripMenuItem.Text = "MetodoPagamento";
            // 
            // concluirToolStripMenuItem
            // 
            this.concluirToolStripMenuItem.Name = "concluirToolStripMenuItem";
            this.concluirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.concluirToolStripMenuItem.Text = "Concluir";
            this.concluirToolStripMenuItem.Click += new System.EventHandler(this.concluirToolStripMenuItem_Click);
            // 
            // voltarRestaurantToolStripMenuItem
            // 
            this.voltarRestaurantToolStripMenuItem.Name = "voltarRestaurantToolStripMenuItem";
            this.voltarRestaurantToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.voltarRestaurantToolStripMenuItem.Text = "Voltar Restaurant";
            this.voltarRestaurantToolStripMenuItem.Click += new System.EventHandler(this.voltarRestaurantToolStripMenuItem_Click);
            // 
            // CRUD_MetodoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(451, 209);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ativoTextBox);
            this.Controls.Add(this.metoPagamentoTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CRUD_MetodoPagamento";
            this.Text = "CRUD_MetodoPagamento";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox metoPagamentoTextBox;
        private System.Windows.Forms.TextBox ativoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cRUDMetodoPagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarRestaurantToolStripMenuItem;
    }
}