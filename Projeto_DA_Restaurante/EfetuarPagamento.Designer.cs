namespace Projeto_DA_Restaurante
{
    partial class EfetuarPagamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxvalor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxpromoçao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxpedido = new System.Windows.Forms.ComboBox();
            this.comboBoxmetodo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 148);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConcluir
            // 
            this.btnConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Location = new System.Drawing.Point(401, 148);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(90, 40);
            this.btnConcluir.TabIndex = 15;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Valor:";
            // 
            // textBoxvalor
            // 
            this.textBoxvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxvalor.Location = new System.Drawing.Point(146, 28);
            this.textBoxvalor.Name = "textBoxvalor";
            this.textBoxvalor.Size = new System.Drawing.Size(100, 22);
            this.textBoxvalor.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Metodo Pagamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(334, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // textBoxpromoçao
            // 
            this.textBoxpromoçao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpromoçao.Location = new System.Drawing.Point(334, 56);
            this.textBoxpromoçao.Name = "textBoxpromoçao";
            this.textBoxpromoçao.Size = new System.Drawing.Size(157, 22);
            this.textBoxpromoçao.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Promoção:";
            // 
            // comboBoxpedido
            // 
            this.comboBoxpedido.FormattingEnabled = true;
            this.comboBoxpedido.Location = new System.Drawing.Point(146, 87);
            this.comboBoxpedido.Name = "comboBoxpedido";
            this.comboBoxpedido.Size = new System.Drawing.Size(100, 21);
            this.comboBoxpedido.TabIndex = 27;
            // 
            // comboBoxmetodo
            // 
            this.comboBoxmetodo.FormattingEnabled = true;
            this.comboBoxmetodo.Location = new System.Drawing.Point(146, 56);
            this.comboBoxmetodo.Name = "comboBoxmetodo";
            this.comboBoxmetodo.Size = new System.Drawing.Size(100, 21);
            this.comboBoxmetodo.TabIndex = 28;
            // 
            // EfetuarPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 200);
            this.Controls.Add(this.comboBoxmetodo);
            this.Controls.Add(this.comboBoxpedido);
            this.Controls.Add(this.textBoxpromoçao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxvalor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnBack);
            this.Name = "EfetuarPagamento";
            this.Text = "Efetuar Pagamento";
            this.Load += new System.EventHandler(this.EfetuarPagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxvalor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxpromoçao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxpedido;
        private System.Windows.Forms.ComboBox comboBoxmetodo;
    }
}