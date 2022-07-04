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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCocluir = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.ingredientesTextBox = new System.Windows.Forms.TextBox();
            this.ativoTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.categoriacomboBox = new System.Windows.Forms.ComboBox();
            this.categoriaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fotografiaTextBox = new System.Windows.Forms.TextBox();
            nomeLabel = new System.Windows.Forms.Label();
            fotografiaLabel = new System.Windows.Forms.Label();
            ingredientesLabel = new System.Windows.Forms.Label();
            precoLabel = new System.Windows.Forms.Label();
            ativoLabel = new System.Windows.Forms.Label();
            categoriaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(12, 52);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(47, 16);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // fotografiaLabel
            // 
            fotografiaLabel.AutoSize = true;
            fotografiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fotografiaLabel.Location = new System.Drawing.Point(12, 107);
            fotografiaLabel.Name = "fotografiaLabel";
            fotografiaLabel.Size = new System.Drawing.Size(71, 16);
            fotografiaLabel.TabIndex = 5;
            fotografiaLabel.Text = "Fotografia:";
            // 
            // ingredientesLabel
            // 
            ingredientesLabel.AutoSize = true;
            ingredientesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ingredientesLabel.Location = new System.Drawing.Point(12, 78);
            ingredientesLabel.Name = "ingredientesLabel";
            ingredientesLabel.Size = new System.Drawing.Size(84, 16);
            ingredientesLabel.TabIndex = 7;
            ingredientesLabel.Text = "Ingredientes:";
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precoLabel.Location = new System.Drawing.Point(217, 52);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new System.Drawing.Size(46, 16);
            precoLabel.TabIndex = 9;
            precoLabel.Text = "Preco:";
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ativoLabel.Location = new System.Drawing.Point(217, 78);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(40, 16);
            ativoLabel.TabIndex = 11;
            ativoLabel.Text = "Ativo:";
            // 
            // categoriaIdLabel
            // 
            categoriaIdLabel.AutoSize = true;
            categoriaIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoriaIdLabel.Location = new System.Drawing.Point(217, 107);
            categoriaIdLabel.Name = "categoriaIdLabel";
            categoriaIdLabel.Size = new System.Drawing.Size(69, 16);
            categoriaIdLabel.TabIndex = 13;
            categoriaIdLabel.Text = "Categoria:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 196);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCocluir
            // 
            this.btnCocluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCocluir.Location = new System.Drawing.Point(347, 196);
            this.btnCocluir.Name = "btnCocluir";
            this.btnCocluir.Size = new System.Drawing.Size(90, 40);
            this.btnCocluir.TabIndex = 17;
            this.btnCocluir.Text = "Concluir";
            this.btnCocluir.UseVisualStyleBackColor = true;
            this.btnCocluir.Click += new System.EventHandler(this.btnCocluir_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(99, 51);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(112, 20);
            this.nomeTextBox.TabIndex = 18;
            // 
            // ingredientesTextBox
            // 
            this.ingredientesTextBox.Location = new System.Drawing.Point(99, 77);
            this.ingredientesTextBox.Name = "ingredientesTextBox";
            this.ingredientesTextBox.Size = new System.Drawing.Size(112, 20);
            this.ingredientesTextBox.TabIndex = 20;
            // 
            // ativoTextBox
            // 
            this.ativoTextBox.Location = new System.Drawing.Point(306, 76);
            this.ativoTextBox.Name = "ativoTextBox";
            this.ativoTextBox.Size = new System.Drawing.Size(112, 20);
            this.ativoTextBox.TabIndex = 22;
            // 
            // precoTextBox
            // 
            this.precoTextBox.Location = new System.Drawing.Point(306, 51);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(112, 20);
            this.precoTextBox.TabIndex = 23;
            // 
            // categoriacomboBox
            // 
            this.categoriacomboBox.DataSource = this.categoriaSetBindingSource;
            this.categoriacomboBox.DisplayMember = "Nome";
            this.categoriacomboBox.FormattingEnabled = true;
            this.categoriacomboBox.Location = new System.Drawing.Point(306, 107);
            this.categoriacomboBox.Name = "categoriacomboBox";
            this.categoriacomboBox.Size = new System.Drawing.Size(111, 21);
            this.categoriacomboBox.TabIndex = 24;
            this.categoriacomboBox.ValueMember = "Id";
            this.categoriacomboBox.SelectedIndexChanged += new System.EventHandler(this.categoriacomboBox_SelectedIndexChanged);
            // 
            // categoriaSetBindingSource
            // 
            this.categoriaSetBindingSource.DataMember = "CategoriaSet";
            this.categoriaSetBindingSource.CurrentChanged += new System.EventHandler(this.categoriaSetBindingSource_CurrentChanged);
            // 
            // fotografiaTextBox
            // 
            this.fotografiaTextBox.Location = new System.Drawing.Point(99, 108);
            this.fotografiaTextBox.Name = "fotografiaTextBox";
            this.fotografiaTextBox.Size = new System.Drawing.Size(112, 20);
            this.fotografiaTextBox.TabIndex = 25;
            this.fotografiaTextBox.TextChanged += new System.EventHandler(this.fotografiaTextBox_TextChanged);
            // 
            // CRUD_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 248);
            this.Controls.Add(this.fotografiaTextBox);
            this.Controls.Add(this.categoriacomboBox);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(this.ativoTextBox);
            this.Controls.Add(this.ingredientesTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.btnCocluir);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(fotografiaLabel);
            this.Controls.Add(ingredientesLabel);
            this.Controls.Add(precoLabel);
            this.Controls.Add(ativoLabel);
            this.Controls.Add(categoriaIdLabel);
            this.Name = "CRUD_Menu";
            this.Text = "Criar um item para o Menu";
            this.Load += new System.EventHandler(this.CRUD_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCocluir;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox ingredientesTextBox;
        private System.Windows.Forms.TextBox ativoTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.ComboBox categoriacomboBox;
        private RestGestDBDataSet restGestDBDataSet;
        private System.Windows.Forms.BindingSource categoriaSetBindingSource;
        private RestGestDBDataSetTableAdapters.CategoriaSetTableAdapter categoriaSetTableAdapter;
        private System.Windows.Forms.TextBox fotografiaTextBox;
    }
}