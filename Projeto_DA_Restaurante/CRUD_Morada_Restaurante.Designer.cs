namespace Projeto_DA_Restaurante
{
    partial class CRUD_Morada_Restaurante
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
            this.btnCocluir = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.textBoxpais = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxrua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxcodpostal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxcidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCocluir
            // 
            this.btnCocluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCocluir.Location = new System.Drawing.Point(328, 116);
            this.btnCocluir.Name = "btnCocluir";
            this.btnCocluir.Size = new System.Drawing.Size(90, 40);
            this.btnCocluir.TabIndex = 19;
            this.btnCocluir.Text = "Concluir";
            this.btnCocluir.UseVisualStyleBackColor = true;
            this.btnCocluir.Click += new System.EventHandler(this.btnCocluir_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 116);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // textBoxpais
            // 
            this.textBoxpais.Location = new System.Drawing.Point(312, 32);
            this.textBoxpais.Name = "textBoxpais";
            this.textBoxpais.Size = new System.Drawing.Size(116, 20);
            this.textBoxpais.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Pais:";
            // 
            // textBoxrua
            // 
            this.textBoxrua.Location = new System.Drawing.Point(312, 64);
            this.textBoxrua.Name = "textBoxrua";
            this.textBoxrua.Size = new System.Drawing.Size(116, 20);
            this.textBoxrua.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Rua:";
            // 
            // textBoxcodpostal
            // 
            this.textBoxcodpostal.Location = new System.Drawing.Point(109, 67);
            this.textBoxcodpostal.Name = "textBoxcodpostal";
            this.textBoxcodpostal.Size = new System.Drawing.Size(116, 20);
            this.textBoxcodpostal.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cod. Postal:";
            // 
            // textBoxcidade
            // 
            this.textBoxcidade.Location = new System.Drawing.Point(109, 35);
            this.textBoxcidade.Name = "textBoxcidade";
            this.textBoxcidade.Size = new System.Drawing.Size(116, 20);
            this.textBoxcidade.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cidade:";
            // 
            // CRUD_Morada_Restaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 177);
            this.Controls.Add(this.textBoxpais);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxrua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxcodpostal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxcidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCocluir);
            this.Controls.Add(this.btnBack);
            this.Name = "CRUD_Morada_Restaurante";
            this.Text = "CRUD_Morada_Restaurante";
            this.Load += new System.EventHandler(this.CRUD_Morada_Restaurante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCocluir;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox textBoxpais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxrua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxcodpostal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxcidade;
        private System.Windows.Forms.Label label1;
    }
}