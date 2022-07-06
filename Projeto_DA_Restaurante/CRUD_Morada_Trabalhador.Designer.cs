namespace Projeto_DA_Restaurante
{
    partial class CRUD_Morada_Trabalhador
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
            this.textBoxpais = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxrua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxcodpostal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxcidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSeguinte = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxpais
            // 
            this.textBoxpais.Location = new System.Drawing.Point(275, 25);
            this.textBoxpais.Name = "textBoxpais";
            this.textBoxpais.Size = new System.Drawing.Size(116, 20);
            this.textBoxpais.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Pais:";
            // 
            // textBoxrua
            // 
            this.textBoxrua.Location = new System.Drawing.Point(275, 57);
            this.textBoxrua.Name = "textBoxrua";
            this.textBoxrua.Size = new System.Drawing.Size(116, 20);
            this.textBoxrua.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Rua:";
            // 
            // textBoxcodpostal
            // 
            this.textBoxcodpostal.Location = new System.Drawing.Point(91, 57);
            this.textBoxcodpostal.Name = "textBoxcodpostal";
            this.textBoxcodpostal.Size = new System.Drawing.Size(116, 20);
            this.textBoxcodpostal.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cod. Postal:";
            // 
            // textBoxcidade
            // 
            this.textBoxcidade.Location = new System.Drawing.Point(91, 25);
            this.textBoxcidade.Name = "textBoxcidade";
            this.textBoxcidade.Size = new System.Drawing.Size(116, 20);
            this.textBoxcidade.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cidade:";
            // 
            // buttonSeguinte
            // 
            this.buttonSeguinte.Location = new System.Drawing.Point(318, 111);
            this.buttonSeguinte.Name = "buttonSeguinte";
            this.buttonSeguinte.Size = new System.Drawing.Size(86, 40);
            this.buttonSeguinte.TabIndex = 19;
            this.buttonSeguinte.Text = "Seguiente";
            this.buttonSeguinte.UseVisualStyleBackColor = true;
            this.buttonSeguinte.Click += new System.EventHandler(this.buttonSeguinte_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(12, 111);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(86, 40);
            this.buttonVoltar.TabIndex = 20;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // CRUD_Morada_Trabalhador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 163);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonSeguinte);
            this.Controls.Add(this.textBoxpais);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxrua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxcodpostal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxcidade);
            this.Controls.Add(this.label1);
            this.Name = "CRUD_Morada_Trabalhador";
            this.Text = "Criar Morada para Trabalhador";
            this.Load += new System.EventHandler(this.AssociarTrabalhador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxpais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxrua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxcodpostal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxcidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSeguinte;
        private System.Windows.Forms.Button buttonVoltar;
    }
}