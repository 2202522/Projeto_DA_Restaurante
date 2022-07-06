namespace Projeto_DA_Restaurante
{
    partial class Utilizadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Utilizadores));
            this.btnEditarClientes = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pessoaSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pessoaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewmorada = new System.Windows.Forms.DataGridView();
            this.dataGridViewcliente = new System.Windows.Forms.DataGridView();
            this.dataGridViewrestaurante = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmorada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrestaurante)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditarClientes
            // 
            this.btnEditarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarClientes.Location = new System.Drawing.Point(691, 229);
            this.btnEditarClientes.Name = "btnEditarClientes";
            this.btnEditarClientes.Size = new System.Drawing.Size(120, 46);
            this.btnEditarClientes.TabIndex = 22;
            this.btnEditarClientes.Text = "Criar/Editar Utilizador";
            this.btnEditarClientes.UseVisualStyleBackColor = true;
            this.btnEditarClientes.Click += new System.EventHandler(this.btnEditarClientes_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 250);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(82, 38);
            this.btnHome.TabIndex = 20;
            this.btnHome.Text = "Voltar";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pessoaSetBindingNavigatorSaveItem
            // 
            this.pessoaSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pessoaSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pessoaSetBindingNavigatorSaveItem.Image")));
            this.pessoaSetBindingNavigatorSaveItem.Name = "pessoaSetBindingNavigatorSaveItem";
            this.pessoaSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.pessoaSetBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // dataGridViewmorada
            // 
            this.dataGridViewmorada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmorada.Location = new System.Drawing.Point(12, 34);
            this.dataGridViewmorada.Name = "dataGridViewmorada";
            this.dataGridViewmorada.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewmorada.TabIndex = 29;
            // 
            // dataGridViewcliente
            // 
            this.dataGridViewcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcliente.Location = new System.Drawing.Point(284, 34);
            this.dataGridViewcliente.Name = "dataGridViewcliente";
            this.dataGridViewcliente.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewcliente.TabIndex = 30;
            // 
            // dataGridViewrestaurante
            // 
            this.dataGridViewrestaurante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewrestaurante.Location = new System.Drawing.Point(565, 34);
            this.dataGridViewrestaurante.Name = "dataGridViewrestaurante";
            this.dataGridViewrestaurante.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewrestaurante.TabIndex = 31;
            // 
            // Utilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 300);
            this.Controls.Add(this.dataGridViewrestaurante);
            this.Controls.Add(this.dataGridViewcliente);
            this.Controls.Add(this.dataGridViewmorada);
            this.Controls.Add(this.btnEditarClientes);
            this.Controls.Add(this.btnHome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Utilizadores";
            this.Text = "Utilizadores";
            this.Load += new System.EventHandler(this.Utilizadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmorada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrestaurante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEditarClientes;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ToolStripButton pessoaSetBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource pessoaSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dataGridViewmorada;
        private System.Windows.Forms.DataGridView dataGridViewcliente;
        private System.Windows.Forms.DataGridView dataGridViewrestaurante;
    }
}