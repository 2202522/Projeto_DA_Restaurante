namespace Projeto_DA_Restaurante
{
    partial class CRUD_Utilizador
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label telemovelLabel;
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.telemovelTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cRUDClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguinteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarUtilizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nomeLabel = new System.Windows.Forms.Label();
            telemovelLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(108, 83);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(58, 20);
            nomeLabel.TabIndex = 25;
            nomeLabel.Text = "Nome:";
            // 
            // telemovelLabel
            // 
            telemovelLabel.AutoSize = true;
            telemovelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telemovelLabel.Location = new System.Drawing.Point(108, 115);
            telemovelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telemovelLabel.Name = "telemovelLabel";
            telemovelLabel.Size = new System.Drawing.Size(90, 20);
            telemovelLabel.TabIndex = 27;
            telemovelLabel.Text = "Telemovel:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(212, 79);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(132, 26);
            this.nomeTextBox.TabIndex = 26;
            // 
            // telemovelTextBox
            // 
            this.telemovelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telemovelTextBox.Location = new System.Drawing.Point(212, 111);
            this.telemovelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telemovelTextBox.Name = "telemovelTextBox";
            this.telemovelTextBox.Size = new System.Drawing.Size(132, 26);
            this.telemovelTextBox.TabIndex = 28;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDClienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(519, 28);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cRUDClienteToolStripMenuItem
            // 
            this.cRUDClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seguinteToolStripMenuItem,
            this.voltarUtilizadoresToolStripMenuItem});
            this.cRUDClienteToolStripMenuItem.Name = "cRUDClienteToolStripMenuItem";
            this.cRUDClienteToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.cRUDClienteToolStripMenuItem.Text = "Cliente";
            // 
            // seguinteToolStripMenuItem
            // 
            this.seguinteToolStripMenuItem.Name = "seguinteToolStripMenuItem";
            this.seguinteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.seguinteToolStripMenuItem.Text = "Seguinte";
            this.seguinteToolStripMenuItem.Click += new System.EventHandler(this.seguinteToolStripMenuItem_Click);
            // 
            // voltarUtilizadoresToolStripMenuItem
            // 
            this.voltarUtilizadoresToolStripMenuItem.Name = "voltarUtilizadoresToolStripMenuItem";
            this.voltarUtilizadoresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.voltarUtilizadoresToolStripMenuItem.Text = "Voltar Utilizadores";
            this.voltarUtilizadoresToolStripMenuItem.Click += new System.EventHandler(this.voltarUtilizadoresToolStripMenuItem_Click);
            // 
            // CRUD_Utilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(519, 236);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(telemovelLabel);
            this.Controls.Add(this.telemovelTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CRUD_Utilizador";
            this.Text = "CRUD_Cliente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox telemovelTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cRUDClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguinteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarUtilizadoresToolStripMenuItem;
    }
}