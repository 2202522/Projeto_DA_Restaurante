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
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewPromocoes = new System.Windows.Forms.DataGridView();
            this.promocaosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.referenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentagemPromocaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromocoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 225);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(186, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Criar Codigos de Promoção";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridViewPromocoes.Location = new System.Drawing.Point(12, 26);
            this.dataGridViewPromocoes.Name = "dataGridViewPromocoes";
            this.dataGridViewPromocoes.ReadOnly = true;
            this.dataGridViewPromocoes.Size = new System.Drawing.Size(265, 150);
            this.dataGridViewPromocoes.TabIndex = 9;
            // 
            // restGestDBDataSet
            // 
            // 
            // promocaosBindingSource
            // 
            this.promocaosBindingSource.DataMember = "Promocaos";
            // 
            // promocaosTableAdapter
            // 
            // 
            // referenciaDataGridViewTextBoxColumn
            // 
            this.referenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia";
            this.referenciaDataGridViewTextBoxColumn.HeaderText = "Referencia";
            this.referenciaDataGridViewTextBoxColumn.Name = "referenciaDataGridViewTextBoxColumn";
            this.referenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // percentagemPromocaoDataGridViewTextBoxColumn
            // 
            this.percentagemPromocaoDataGridViewTextBoxColumn.DataPropertyName = "PercentagemPromocao";
            this.percentagemPromocaoDataGridViewTextBoxColumn.HeaderText = "Percentagem Promoção";
            this.percentagemPromocaoDataGridViewTextBoxColumn.Name = "percentagemPromocaoDataGridViewTextBoxColumn";
            this.percentagemPromocaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.percentagemPromocaoDataGridViewTextBoxColumn.Width = 120;
            // 
            // Promocoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 277);
            this.Controls.Add(this.dataGridViewPromocoes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Name = "Promocoes";
            this.Text = "Promocoes";
            this.Load += new System.EventHandler(this.Promocoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromocoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewPromocoes;
        private System.Windows.Forms.BindingSource promocaosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentagemPromocaoDataGridViewTextBoxColumn;
    }
}