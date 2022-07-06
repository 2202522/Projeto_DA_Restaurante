namespace Projeto_DA_Restaurante
{
    partial class CRUD_Menu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label fotografiaLabel;
            System.Windows.Forms.Label ingredientesLabel;
            System.Windows.Forms.Label precoLabel;
            System.Windows.Forms.Label ativoLabel;
            System.Windows.Forms.Label categoriaIdLabel;
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.ingredientesTextBox = new System.Windows.Forms.TextBox();
            this.ativoTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.categoriacomboBox = new System.Windows.Forms.ComboBox();
            this.categoriaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fotografiaTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.criarUmItemParaOMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nomeLabel = new System.Windows.Forms.Label();
            fotografiaLabel = new System.Windows.Forms.Label();
            ingredientesLabel = new System.Windows.Forms.Label();
            precoLabel = new System.Windows.Forms.Label();
            ativoLabel = new System.Windows.Forms.Label();
            categoriaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(16, 88);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(58, 20);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // fotografiaLabel
            // 
            fotografiaLabel.AutoSize = true;
            fotografiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fotografiaLabel.Location = new System.Drawing.Point(16, 156);
            fotografiaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fotografiaLabel.Name = "fotografiaLabel";
            fotografiaLabel.Size = new System.Drawing.Size(89, 20);
            fotografiaLabel.TabIndex = 5;
            fotografiaLabel.Text = "Fotografia:";
            // 
            // ingredientesLabel
            // 
            ingredientesLabel.AutoSize = true;
            ingredientesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ingredientesLabel.Location = new System.Drawing.Point(16, 120);
            ingredientesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ingredientesLabel.Name = "ingredientesLabel";
            ingredientesLabel.Size = new System.Drawing.Size(105, 20);
            ingredientesLabel.TabIndex = 7;
            ingredientesLabel.Text = "Ingredientes:";
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precoLabel.Location = new System.Drawing.Point(289, 88);
            precoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new System.Drawing.Size(58, 20);
            precoLabel.TabIndex = 9;
            precoLabel.Text = "Preco:";
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ativoLabel.Location = new System.Drawing.Point(289, 120);
            ativoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(51, 20);
            ativoLabel.TabIndex = 11;
            ativoLabel.Text = "Ativo:";
            // 
            // categoriaIdLabel
            // 
            categoriaIdLabel.AutoSize = true;
            categoriaIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoriaIdLabel.Location = new System.Drawing.Point(289, 156);
            categoriaIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            categoriaIdLabel.Name = "categoriaIdLabel";
            categoriaIdLabel.Size = new System.Drawing.Size(86, 20);
            categoriaIdLabel.TabIndex = 13;
            categoriaIdLabel.Text = "Categoria:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(132, 87);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(148, 22);
            this.nomeTextBox.TabIndex = 18;
            // 
            // ingredientesTextBox
            // 
            this.ingredientesTextBox.Location = new System.Drawing.Point(132, 119);
            this.ingredientesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ingredientesTextBox.Name = "ingredientesTextBox";
            this.ingredientesTextBox.Size = new System.Drawing.Size(148, 22);
            this.ingredientesTextBox.TabIndex = 20;
            // 
            // ativoTextBox
            // 
            this.ativoTextBox.Location = new System.Drawing.Point(408, 118);
            this.ativoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ativoTextBox.Name = "ativoTextBox";
            this.ativoTextBox.Size = new System.Drawing.Size(148, 22);
            this.ativoTextBox.TabIndex = 22;
            // 
            // precoTextBox
            // 
            this.precoTextBox.Location = new System.Drawing.Point(408, 87);
            this.precoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(148, 22);
            this.precoTextBox.TabIndex = 23;
            // 
            // categoriacomboBox
            // 
            this.categoriacomboBox.DataSource = this.categoriaSetBindingSource;
            this.categoriacomboBox.DisplayMember = "Nome";
            this.categoriacomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriacomboBox.FormattingEnabled = true;
            this.categoriacomboBox.Location = new System.Drawing.Point(408, 156);
            this.categoriacomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoriacomboBox.Name = "categoriacomboBox";
            this.categoriacomboBox.Size = new System.Drawing.Size(147, 24);
            this.categoriacomboBox.TabIndex = 24;
            this.categoriacomboBox.ValueMember = "Id";
            // 
            // categoriaSetBindingSource
            // 
            this.categoriaSetBindingSource.DataMember = "CategoriaSet";
            // 
            // fotografiaTextBox
            // 
            this.fotografiaTextBox.Location = new System.Drawing.Point(132, 157);
            this.fotografiaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fotografiaTextBox.Name = "fotografiaTextBox";
            this.fotografiaTextBox.Size = new System.Drawing.Size(148, 22);
            this.fotografiaTextBox.TabIndex = 25;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarUmItemParaOMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 28);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // criarUmItemParaOMenuToolStripMenuItem
            // 
            this.criarUmItemParaOMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.concluirToolStripMenuItem,
            this.voltarMenuToolStripMenuItem});
            this.criarUmItemParaOMenuToolStripMenuItem.Name = "criarUmItemParaOMenuToolStripMenuItem";
            this.criarUmItemParaOMenuToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.criarUmItemParaOMenuToolStripMenuItem.Text = "Criar um item para o Menu";
            // 
            // concluirToolStripMenuItem
            // 
            this.concluirToolStripMenuItem.Name = "concluirToolStripMenuItem";
            this.concluirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.concluirToolStripMenuItem.Text = "Concluir";
            this.concluirToolStripMenuItem.Click += new System.EventHandler(this.concluirToolStripMenuItem_Click);
            // 
            // voltarMenuToolStripMenuItem
            // 
            this.voltarMenuToolStripMenuItem.Name = "voltarMenuToolStripMenuItem";
            this.voltarMenuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.voltarMenuToolStripMenuItem.Text = "Voltar Menu";
            this.voltarMenuToolStripMenuItem.Click += new System.EventHandler(this.voltarMenuToolStripMenuItem_Click);
            // 
            // CRUD_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(599, 252);
            this.Controls.Add(this.fotografiaTextBox);
            this.Controls.Add(this.categoriacomboBox);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(this.ativoTextBox);
            this.Controls.Add(this.ingredientesTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(fotografiaLabel);
            this.Controls.Add(ingredientesLabel);
            this.Controls.Add(precoLabel);
            this.Controls.Add(ativoLabel);
            this.Controls.Add(categoriaIdLabel);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CRUD_Menu";
            this.Text = "Criar um item para o Menu";
            this.Load += new System.EventHandler(this.CRUD_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox ingredientesTextBox;
        private System.Windows.Forms.TextBox ativoTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.ComboBox categoriacomboBox;
        private RestGestDBDataSet restGestDBDataSet;
        private System.Windows.Forms.BindingSource categoriaSetBindingSource;
        private RestGestDBDataSetTableAdapters.CategoriaSetTableAdapter categoriaSetTableAdapter;
        private System.Windows.Forms.TextBox fotografiaTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem criarUmItemParaOMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarMenuToolStripMenuItem;
    }
}