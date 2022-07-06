namespace Projeto_DA_Restaurante
{
    partial class CRUD_Pedido
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.valorTotalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxtrabalhador = new System.Windows.Forms.ComboBox();
            this.comboBoxcliente = new System.Windows.Forms.ComboBox();
            this.comboBoxrestaurante = new System.Windows.Forms.ComboBox();
            this.comboBoxestado = new System.Windows.Forms.ComboBox();
            this.comboBoxItemMenu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 147);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConcluir
            // 
            this.btnConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Location = new System.Drawing.Point(348, 147);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(90, 40);
            this.btnConcluir.TabIndex = 14;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // valorTotalTextBox
            // 
            this.valorTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotalTextBox.Location = new System.Drawing.Point(114, 32);
            this.valorTotalTextBox.Name = "valorTotalTextBox";
            this.valorTotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.valorTotalTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Trabalhador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Restaurante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Estado:";
            // 
            // comboBoxtrabalhador
            // 
            this.comboBoxtrabalhador.FormattingEnabled = true;
            this.comboBoxtrabalhador.Location = new System.Drawing.Point(114, 62);
            this.comboBoxtrabalhador.Name = "comboBoxtrabalhador";
            this.comboBoxtrabalhador.Size = new System.Drawing.Size(100, 21);
            this.comboBoxtrabalhador.TabIndex = 25;
            // 
            // comboBoxcliente
            // 
            this.comboBoxcliente.FormattingEnabled = true;
            this.comboBoxcliente.Location = new System.Drawing.Point(114, 90);
            this.comboBoxcliente.Name = "comboBoxcliente";
            this.comboBoxcliente.Size = new System.Drawing.Size(100, 21);
            this.comboBoxcliente.TabIndex = 26;
            // 
            // comboBoxrestaurante
            // 
            this.comboBoxrestaurante.FormattingEnabled = true;
            this.comboBoxrestaurante.Location = new System.Drawing.Point(324, 34);
            this.comboBoxrestaurante.Name = "comboBoxrestaurante";
            this.comboBoxrestaurante.Size = new System.Drawing.Size(100, 21);
            this.comboBoxrestaurante.TabIndex = 27;
            // 
            // comboBoxestado
            // 
            this.comboBoxestado.FormattingEnabled = true;
            this.comboBoxestado.Location = new System.Drawing.Point(324, 62);
            this.comboBoxestado.Name = "comboBoxestado";
            this.comboBoxestado.Size = new System.Drawing.Size(100, 21);
            this.comboBoxestado.TabIndex = 28;
            // 
            // comboBoxItemMenu
            // 
            this.comboBoxItemMenu.FormattingEnabled = true;
            this.comboBoxItemMenu.Location = new System.Drawing.Point(324, 91);
            this.comboBoxItemMenu.Name = "comboBoxItemMenu";
            this.comboBoxItemMenu.Size = new System.Drawing.Size(100, 21);
            this.comboBoxItemMenu.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(241, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Item Menu:";
            // 
            // CRUD_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 207);
            this.Controls.Add(this.comboBoxItemMenu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxestado);
            this.Controls.Add(this.comboBoxrestaurante);
            this.Controls.Add(this.comboBoxcliente);
            this.Controls.Add(this.comboBoxtrabalhador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valorTotalTextBox);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnBack);
            this.Name = "CRUD_Pedido";
            this.Text = "CRUD_Pedido";
            this.Load += new System.EventHandler(this.CRUD_Pedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.TextBox valorTotalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxtrabalhador;
        private System.Windows.Forms.ComboBox comboBoxcliente;
        private System.Windows.Forms.ComboBox comboBoxrestaurante;
        private System.Windows.Forms.ComboBox comboBoxestado;
        private System.Windows.Forms.ComboBox comboBoxItemMenu;
        private System.Windows.Forms.Label label6;
    }
}