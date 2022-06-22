namespace Projeto_DA_Restaurante
{
    partial class GestaoRestaurantes
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCriarRestauranteView = new System.Windows.Forms.Button();
            this.btnAbrirRestaurante = new System.Windows.Forms.Button();
            this.categoriaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteDataSet = new Projeto_DA_Restaurante.RestauranteDataSet();
            this.categoriaSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSetTableAdapters.CategoriaSetTableAdapter();
            this.metodoPagamentoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteDataSet1 = new Projeto_DA_Restaurante.RestauranteDataSet1();
            this.metodoPagamentoSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.MetodoPagamentoSetTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.restauranteSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteDataSet2 = new Projeto_DA_Restaurante.RestauranteDataSet2();
            this.restauranteSetTableAdapter = new Projeto_DA_Restaurante.RestauranteDataSet2TableAdapters.RestauranteSetTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new Projeto_DA_Restaurante.RestauranteDataSetTableAdapters.TableAdapterManager();
            this.tableAdapterManager1 = new Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.TableAdapterManager();
            this.categoriaSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaSetTableAdapter1 = new Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.CategoriaSetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 494);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(87, 36);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCriarRestauranteView
            // 
            this.btnCriarRestauranteView.Location = new System.Drawing.Point(342, 81);
            this.btnCriarRestauranteView.Name = "btnCriarRestauranteView";
            this.btnCriarRestauranteView.Size = new System.Drawing.Size(87, 36);
            this.btnCriarRestauranteView.TabIndex = 1;
            this.btnCriarRestauranteView.Text = "Criar";
            this.btnCriarRestauranteView.UseVisualStyleBackColor = true;
            this.btnCriarRestauranteView.Click += new System.EventHandler(this.btnCriarRestaurante_Click);
            // 
            // btnAbrirRestaurante
            // 
            this.btnAbrirRestaurante.Location = new System.Drawing.Point(435, 81);
            this.btnAbrirRestaurante.Name = "btnAbrirRestaurante";
            this.btnAbrirRestaurante.Size = new System.Drawing.Size(87, 36);
            this.btnAbrirRestaurante.TabIndex = 3;
            this.btnAbrirRestaurante.Text = "Abrir";
            this.btnAbrirRestaurante.UseVisualStyleBackColor = true;
            this.btnAbrirRestaurante.Click += new System.EventHandler(this.btnAbrirRestaurante_Click);
            // 
            // categoriaSetBindingSource
            // 
            this.categoriaSetBindingSource.DataMember = "CategoriaSet";
            this.categoriaSetBindingSource.DataSource = this.restauranteDataSet;
            // 
            // restauranteDataSet
            // 
            this.restauranteDataSet.DataSetName = "RestauranteDataSet";
            this.restauranteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaSetTableAdapter
            // 
            this.categoriaSetTableAdapter.ClearBeforeFill = true;
            // 
            // metodoPagamentoSetBindingSource
            // 
            this.metodoPagamentoSetBindingSource.DataMember = "MetodoPagamentoSet";
            this.metodoPagamentoSetBindingSource.DataSource = this.restauranteDataSet1;
            // 
            // restauranteDataSet1
            // 
            this.restauranteDataSet1.DataSetName = "RestauranteDataSet1";
            this.restauranteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metodoPagamentoSetTableAdapter
            // 
            this.metodoPagamentoSetTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 311);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorias";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(532, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 334);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Metodos Pagamento";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.restauranteSetBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // restauranteSetBindingSource
            // 
            this.restauranteSetBindingSource.DataMember = "RestauranteSet";
            this.restauranteSetBindingSource.DataSource = this.restauranteDataSet2;
            // 
            // restauranteDataSet2
            // 
            this.restauranteDataSet2.DataSetName = "RestauranteDataSet2";
            this.restauranteDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restauranteSetTableAdapter
            // 
            this.restauranteSetTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Restaurantes:";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaSetTableAdapter = this.categoriaSetTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_Restaurante.RestauranteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CategoriaSetTableAdapter = null;
            this.tableAdapterManager1.EstadoSetTableAdapter = null;
            this.tableAdapterManager1.ItemMenuSetTableAdapter = null;
            this.tableAdapterManager1.MetodoPagamentoSetTableAdapter = this.metodoPagamentoSetTableAdapter;
            this.tableAdapterManager1.MoradaSetTableAdapter = null;
            this.tableAdapterManager1.PagamentoSetTableAdapter = null;
            this.tableAdapterManager1.PedidoItemMenuTableAdapter = null;
            this.tableAdapterManager1.PedidoSetTableAdapter = null;
            this.tableAdapterManager1.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager1.PessoaSet_TrabalhadorTableAdapter = null;
            this.tableAdapterManager1.PessoaSetTableAdapter = null;
            this.tableAdapterManager1.RestauranteItemMenuTableAdapter = null;
            this.tableAdapterManager1.RestauranteSetTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Projeto_DA_Restaurante.RestauranteDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriaSetBindingSource1
            // 
            this.categoriaSetBindingSource1.DataMember = "CategoriaSet";
            this.categoriaSetBindingSource1.DataSource = this.restauranteDataSet1;
            // 
            // categoriaSetTableAdapter1
            // 
            this.categoriaSetTableAdapter1.ClearBeforeFill = true;
            // 
            // GestaoRestaurantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAbrirRestaurante);
            this.Controls.Add(this.btnCriarRestauranteView);
            this.Controls.Add(this.btnHome);
            this.Name = "GestaoRestaurantes";
            this.Text = "GestaoRestaurantes";
            this.Load += new System.EventHandler(this.GestaoRestaurantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagamentoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCriarRestauranteView;
        private System.Windows.Forms.Button btnAbrirRestaurante;
        private RestauranteDataSet restauranteDataSet;
        private System.Windows.Forms.BindingSource categoriaSetBindingSource;
        private RestauranteDataSetTableAdapters.CategoriaSetTableAdapter categoriaSetTableAdapter;
        private RestauranteDataSet1 restauranteDataSet1;
        private System.Windows.Forms.BindingSource metodoPagamentoSetBindingSource;
        private RestauranteDataSet1TableAdapters.MetodoPagamentoSetTableAdapter metodoPagamentoSetTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private RestauranteDataSet2 restauranteDataSet2;
        private System.Windows.Forms.BindingSource restauranteSetBindingSource;
        private RestauranteDataSet2TableAdapters.RestauranteSetTableAdapter restauranteSetTableAdapter;
        private System.Windows.Forms.Label label1;
        private RestauranteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private RestauranteDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource categoriaSetBindingSource1;
        private RestauranteDataSet1TableAdapters.CategoriaSetTableAdapter categoriaSetTableAdapter1;
    }
}