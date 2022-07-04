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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pessoaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restGestDBDataSet1 = new Projeto_DA_Restaurante.RestGestDBDataSet();
            this.btnCliente = new System.Windows.Forms.Button();
            this.pessoaSetTableAdapter1 = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.PessoaSetTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet1)).BeginInit();
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
            this.btnHome.Text = "Back";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(247, 197);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Utilizadores";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.pessoaSetBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 180);
            this.dataGridView1.TabIndex = 0;
            // 
            // pessoaSetBindingSource
            // 
            this.pessoaSetBindingSource.DataMember = "PessoaSet";
            this.pessoaSetBindingSource.DataSource = this.restGestDBDataSet1;
            // 
            // restGestDBDataSet1
            // 
            this.restGestDBDataSet1.DataSetName = "RestGestDBDataSet";
            this.restGestDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(565, 229);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(120, 46);
            this.btnCliente.TabIndex = 28;
            this.btnCliente.Text = "Criar/Editar Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // pessoaSetTableAdapter1
            // 
            this.pessoaSetTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Telemovel";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telemovel";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Utilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 300);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEditarClientes);
            this.Controls.Add(this.btnHome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Utilizadores";
            this.Text = "Utilizadores";
            this.Load += new System.EventHandler(this.Utilizadores_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEditarClientes;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ToolStripButton pessoaSetBindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCliente;
        private RestGestDBDataSet restGestDBDataSet;
        private RestGestDBDataSetTableAdapters.PessoaSetTableAdapter pessoaSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telemovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RestGestDBDataSet restGestDBDataSet1;
        private System.Windows.Forms.BindingSource pessoaSetBindingSource;
        private RestGestDBDataSetTableAdapters.PessoaSetTableAdapter pessoaSetTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}