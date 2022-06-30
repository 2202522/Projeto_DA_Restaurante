namespace Projeto_DA_Restaurante
{
    partial class Vendas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConsultarVendas = new System.Windows.Forms.Button();
            this.btnConsultarVendidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(32, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens mais Vendidos";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(279, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 251);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total de vendas ultimos 7 dias";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 346);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConsultarVendas
            // 
            this.btnConsultarVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarVendas.Location = new System.Drawing.Point(389, 291);
            this.btnConsultarVendas.Name = "btnConsultarVendas";
            this.btnConsultarVendas.Size = new System.Drawing.Size(90, 40);
            this.btnConsultarVendas.TabIndex = 10;
            this.btnConsultarVendas.Text = "Consultar";
            this.btnConsultarVendas.UseVisualStyleBackColor = true;
            this.btnConsultarVendas.Click += new System.EventHandler(this.btnConsultarVendas_Click);
            // 
            // btnConsultarVendidos
            // 
            this.btnConsultarVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarVendidos.Location = new System.Drawing.Point(142, 291);
            this.btnConsultarVendidos.Name = "btnConsultarVendidos";
            this.btnConsultarVendidos.Size = new System.Drawing.Size(90, 40);
            this.btnConsultarVendidos.TabIndex = 11;
            this.btnConsultarVendidos.Text = "Consultar";
            this.btnConsultarVendidos.UseVisualStyleBackColor = true;
            this.btnConsultarVendidos.Click += new System.EventHandler(this.btnConsultarVendidos_Click);
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 409);
            this.Controls.Add(this.btnConsultarVendidos);
            this.Controls.Add(this.btnConsultarVendas);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Vendas";
            this.Text = "Vendas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConsultarVendas;
        private System.Windows.Forms.Button btnConsultarVendidos;
    }
}