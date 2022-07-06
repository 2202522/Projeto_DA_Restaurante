namespace Projeto_DA_Restaurante
{
    partial class Promocoes
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
            this.dataGridViewPromocoes = new System.Windows.Forms.DataGridView();
            this.referenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentagemPromocaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promocaosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restGestDBDataSet = new Projeto_DA_Restaurante.RestGestDBDataSet();
            this.promocaosTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.PromocaosTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.promocoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarCodigosDePromoçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarMainPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromocoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPromocoes
            // 
            this.dataGridViewPromocoes.AllowUserToAddRows = false;
            this.dataGridViewPromocoes.AllowUserToDeleteRows = false;
            this.dataGridViewPromocoes.AutoGenerateColumns = false;
            this.dataGridViewPromocoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPromocoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referenciaDataGridViewTextBoxColumn,
            this.percentagemPromocaoDataGridViewTextBoxColumn});
            this.dataGridViewPromocoes.DataSource = this.promocaosBindingSource;
            this.dataGridViewPromocoes.Location = new System.Drawing.Point(13, 70);
            this.dataGridViewPromocoes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPromocoes.Name = "dataGridViewPromocoes";
            this.dataGridViewPromocoes.ReadOnly = true;
            this.dataGridViewPromocoes.RowHeadersWidth = 51;
            this.dataGridViewPromocoes.Size = new System.Drawing.Size(353, 185);
            this.dataGridViewPromocoes.TabIndex = 9;
            // 
            // referenciaDataGridViewTextBoxColumn
            // 
            this.referenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia";
            this.referenciaDataGridViewTextBoxColumn.HeaderText = "Referencia";
            this.referenciaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.referenciaDataGridViewTextBoxColumn.Name = "referenciaDataGridViewTextBoxColumn";
            this.referenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.referenciaDataGridViewTextBoxColumn.Width = 125;
            // 
            // percentagemPromocaoDataGridViewTextBoxColumn
            // 
            this.percentagemPromocaoDataGridViewTextBoxColumn.DataPropertyName = "PercentagemPromocao";
            this.percentagemPromocaoDataGridViewTextBoxColumn.HeaderText = "Percentagem Promoção";
            this.percentagemPromocaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.percentagemPromocaoDataGridViewTextBoxColumn.Name = "percentagemPromocaoDataGridViewTextBoxColumn";
            this.percentagemPromocaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.percentagemPromocaoDataGridViewTextBoxColumn.Width = 120;
            // 
            // promocaosBindingSource
            // 
            this.promocaosBindingSource.DataMember = "Promocaos";
            this.promocaosBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // restGestDBDataSet
            // 
            this.restGestDBDataSet.DataSetName = "RestGestDBDataSet";
            this.restGestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // promocaosTableAdapter
            // 
            this.promocaosTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promocoesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // promocoesToolStripMenuItem
            // 
            this.promocoesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarCodigosDePromoçãoToolStripMenuItem,
            this.voltarMainPageToolStripMenuItem});
            this.promocoesToolStripMenuItem.Name = "promocoesToolStripMenuItem";
            this.promocoesToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.promocoesToolStripMenuItem.Text = "Promocoes";
            // 
            // criarCodigosDePromoçãoToolStripMenuItem
            // 
            this.criarCodigosDePromoçãoToolStripMenuItem.Name = "criarCodigosDePromoçãoToolStripMenuItem";
            this.criarCodigosDePromoçãoToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.criarCodigosDePromoçãoToolStripMenuItem.Text = "Criar Codigos de Promoção";
            this.criarCodigosDePromoçãoToolStripMenuItem.Click += new System.EventHandler(this.criarCodigosDePromoçãoToolStripMenuItem_Click);
            // 
            // voltarMainPageToolStripMenuItem
            // 
            this.voltarMainPageToolStripMenuItem.Name = "voltarMainPageToolStripMenuItem";
            this.voltarMainPageToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.voltarMainPageToolStripMenuItem.Text = "Voltar Main Page";
            this.voltarMainPageToolStripMenuItem.Click += new System.EventHandler(this.voltarMainPageToolStripMenuItem_Click);
            // 
            // Promocoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(384, 287);
            this.Controls.Add(this.dataGridViewPromocoes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Promocoes";
            this.Text = "Promocoes";
            this.Load += new System.EventHandler(this.Promocoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromocoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPromocoes;
        private RestGestDBDataSet restGestDBDataSet;
        private System.Windows.Forms.BindingSource promocaosBindingSource;
        private RestGestDBDataSetTableAdapters.PromocaosTableAdapter promocaosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentagemPromocaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem promocoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarCodigosDePromoçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarMainPageToolStripMenuItem;
    }
}