namespace Projeto_DA_Restaurante
{
    partial class Trabalhadores
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
            this.dataGridViewTrabalhadores = new System.Windows.Forms.DataGridView();
            this.btn_CRUD_Trabalhadores = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrabalhadores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewTrabalhadores);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 246);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabalhadores";
            // 
            // dataGridViewTrabalhadores
            // 
            this.dataGridViewTrabalhadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrabalhadores.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewTrabalhadores.Name = "dataGridViewTrabalhadores";
            this.dataGridViewTrabalhadores.Size = new System.Drawing.Size(343, 221);
            this.dataGridViewTrabalhadores.TabIndex = 0;
            // 
            // btn_CRUD_Trabalhadores
            // 
            this.btn_CRUD_Trabalhadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CRUD_Trabalhadores.Location = new System.Drawing.Point(275, 280);
            this.btn_CRUD_Trabalhadores.Name = "btn_CRUD_Trabalhadores";
            this.btn_CRUD_Trabalhadores.Size = new System.Drawing.Size(92, 34);
            this.btn_CRUD_Trabalhadores.TabIndex = 11;
            this.btn_CRUD_Trabalhadores.Text = "Criar/Editar Trabalhadores";
            this.btn_CRUD_Trabalhadores.UseVisualStyleBackColor = true;
            this.btn_CRUD_Trabalhadores.Click += new System.EventHandler(this.btn_CRUD_Trabalhadores_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 326);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Trabalhadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 378);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn_CRUD_Trabalhadores);
            this.Controls.Add(this.groupBox1);
            this.Name = "Trabalhadores";
            this.Text = "Trabalhadores";
            this.Load += new System.EventHandler(this.Trabalhadores_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrabalhadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_CRUD_Trabalhadores;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridViewTrabalhadores;
    }
}