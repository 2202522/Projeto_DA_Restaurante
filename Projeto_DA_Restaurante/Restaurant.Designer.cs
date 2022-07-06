namespace Projeto_DA_Restaurante
{
    partial class Restaurant
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCategorias = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMetodo = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_CRUD_Restaurante = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_CRUD_Trabalhadores = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_CRUD_Menu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btn_CRUD_Categoria = new System.Windows.Forms.Button();
            this.btn_CRUD_MetodoPagamento = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMetodo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewCategorias);
            this.groupBox1.Location = new System.Drawing.Point(20, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // dataGridViewCategorias
            // 
            this.dataGridViewCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategorias.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewCategorias.Name = "dataGridViewCategorias";
            this.dataGridViewCategorias.Size = new System.Drawing.Size(245, 221);
            this.dataGridViewCategorias.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewMetodo);
            this.groupBox2.Location = new System.Drawing.Point(292, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Metodo de Pagamento";
            // 
            // dataGridViewMetodo
            // 
            this.dataGridViewMetodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMetodo.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewMetodo.Name = "dataGridViewMetodo";
            this.dataGridViewMetodo.Size = new System.Drawing.Size(243, 221);
            this.dataGridViewMetodo.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_CRUD_Restaurante);
            this.groupBox3.Location = new System.Drawing.Point(20, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 75);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Restaurante";
            // 
            // btn_CRUD_Restaurante
            // 
            this.btn_CRUD_Restaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CRUD_Restaurante.Location = new System.Drawing.Point(29, 24);
            this.btn_CRUD_Restaurante.Name = "btn_CRUD_Restaurante";
            this.btn_CRUD_Restaurante.Size = new System.Drawing.Size(110, 34);
            this.btn_CRUD_Restaurante.TabIndex = 9;
            this.btn_CRUD_Restaurante.Text = "Criar/Editar Restaurante";
            this.btn_CRUD_Restaurante.UseVisualStyleBackColor = true;
            this.btn_CRUD_Restaurante.Click += new System.EventHandler(this.btn_CRUD_Restaurante_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_CRUD_Trabalhadores);
            this.groupBox4.Location = new System.Drawing.Point(195, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(177, 75);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trabalhadores";
            // 
            // btn_CRUD_Trabalhadores
            // 
            this.btn_CRUD_Trabalhadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CRUD_Trabalhadores.Location = new System.Drawing.Point(35, 24);
            this.btn_CRUD_Trabalhadores.Name = "btn_CRUD_Trabalhadores";
            this.btn_CRUD_Trabalhadores.Size = new System.Drawing.Size(110, 34);
            this.btn_CRUD_Trabalhadores.TabIndex = 10;
            this.btn_CRUD_Trabalhadores.Text = "Criar/Editar Trabalhadores";
            this.btn_CRUD_Trabalhadores.UseVisualStyleBackColor = true;
            this.btn_CRUD_Trabalhadores.Click += new System.EventHandler(this.btn_CRUD_Trabalhadores_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_CRUD_Menu);
            this.groupBox5.Location = new System.Drawing.Point(372, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(175, 75);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Itens Menus";
            // 
            // btn_CRUD_Menu
            // 
            this.btn_CRUD_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CRUD_Menu.Location = new System.Drawing.Point(34, 24);
            this.btn_CRUD_Menu.Name = "btn_CRUD_Menu";
            this.btn_CRUD_Menu.Size = new System.Drawing.Size(110, 34);
            this.btn_CRUD_Menu.TabIndex = 11;
            this.btn_CRUD_Menu.Text = "Criar/Editar Itens Menu";
            this.btn_CRUD_Menu.UseVisualStyleBackColor = true;
            this.btn_CRUD_Menu.Click += new System.EventHandler(this.btn_CRUD_Menu_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 397);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btn_CRUD_Categoria
            // 
            this.btn_CRUD_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CRUD_Categoria.Location = new System.Drawing.Point(167, 356);
            this.btn_CRUD_Categoria.Name = "btn_CRUD_Categoria";
            this.btn_CRUD_Categoria.Size = new System.Drawing.Size(110, 34);
            this.btn_CRUD_Categoria.TabIndex = 7;
            this.btn_CRUD_Categoria.Text = "Criar/Editar Categoria";
            this.btn_CRUD_Categoria.UseVisualStyleBackColor = true;
            this.btn_CRUD_Categoria.Click += new System.EventHandler(this.btn_CRUD_Categoria_Click);
            // 
            // btn_CRUD_MetodoPagamento
            // 
            this.btn_CRUD_MetodoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CRUD_MetodoPagamento.Location = new System.Drawing.Point(437, 356);
            this.btn_CRUD_MetodoPagamento.Name = "btn_CRUD_MetodoPagamento";
            this.btn_CRUD_MetodoPagamento.Size = new System.Drawing.Size(110, 34);
            this.btn_CRUD_MetodoPagamento.TabIndex = 8;
            this.btn_CRUD_MetodoPagamento.Text = "Criar/Editar Metodo Pagamento";
            this.btn_CRUD_MetodoPagamento.UseVisualStyleBackColor = true;
            this.btn_CRUD_MetodoPagamento.Click += new System.EventHandler(this.btn_CRUD_MetodoPagamento_Click);
            // 
            // Restaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 449);
            this.Controls.Add(this.btn_CRUD_MetodoPagamento);
            this.Controls.Add(this.btn_CRUD_Categoria);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Restaurant";
            this.Text = "Restaurant";
            this.Load += new System.EventHandler(this.Restaurant_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMetodo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btn_CRUD_Categoria;
        private System.Windows.Forms.Button btn_CRUD_MetodoPagamento;
        private System.Windows.Forms.Button btn_CRUD_Restaurante;
        private System.Windows.Forms.Button btn_CRUD_Trabalhadores;
        private System.Windows.Forms.Button btn_CRUD_Menu;
        private System.Windows.Forms.DataGridView dataGridViewCategorias;
        private System.Windows.Forms.DataGridView dataGridViewMetodo;
    }
}