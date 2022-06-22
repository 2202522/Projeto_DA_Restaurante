namespace Projeto_DA_Restaurante
{
    partial class RestauranteIndividual
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPedidosRestaurante = new System.Windows.Forms.Button();
            this.btnApagarTrabalhadores = new System.Windows.Forms.Button();
            this.btnCriarTrabalhadores = new System.Windows.Forms.Button();
            this.btnApagarMenu = new System.Windows.Forms.Button();
            this.btnCriarMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Restaurantes:";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(534, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 334);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trabalhadores";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 334);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btnPedidosRestaurante
            // 
            this.btnPedidosRestaurante.Location = new System.Drawing.Point(348, 86);
            this.btnPedidosRestaurante.Name = "btnPedidosRestaurante";
            this.btnPedidosRestaurante.Size = new System.Drawing.Size(87, 36);
            this.btnPedidosRestaurante.TabIndex = 12;
            this.btnPedidosRestaurante.Text = "Pedidos";
            this.btnPedidosRestaurante.UseVisualStyleBackColor = true;
            this.btnPedidosRestaurante.Click += new System.EventHandler(this.btnPedidosRestaurante_Click);
            // 
            // btnApagarTrabalhadores
            // 
            this.btnApagarTrabalhadores.Location = new System.Drawing.Point(873, 487);
            this.btnApagarTrabalhadores.Name = "btnApagarTrabalhadores";
            this.btnApagarTrabalhadores.Size = new System.Drawing.Size(87, 36);
            this.btnApagarTrabalhadores.TabIndex = 17;
            this.btnApagarTrabalhadores.Text = "Apagar";
            this.btnApagarTrabalhadores.UseVisualStyleBackColor = true;
            // 
            // btnCriarTrabalhadores
            // 
            this.btnCriarTrabalhadores.Location = new System.Drawing.Point(780, 487);
            this.btnCriarTrabalhadores.Name = "btnCriarTrabalhadores";
            this.btnCriarTrabalhadores.Size = new System.Drawing.Size(87, 36);
            this.btnCriarTrabalhadores.TabIndex = 18;
            this.btnCriarTrabalhadores.Text = "Associar";
            this.btnCriarTrabalhadores.UseVisualStyleBackColor = true;
            this.btnCriarTrabalhadores.Click += new System.EventHandler(this.btnCriarTrabalhadores_Click);
            // 
            // btnApagarMenu
            // 
            this.btnApagarMenu.Location = new System.Drawing.Point(392, 487);
            this.btnApagarMenu.Name = "btnApagarMenu";
            this.btnApagarMenu.Size = new System.Drawing.Size(87, 36);
            this.btnApagarMenu.TabIndex = 19;
            this.btnApagarMenu.Text = "Apagar";
            this.btnApagarMenu.UseVisualStyleBackColor = true;
            // 
            // btnCriarMenu
            // 
            this.btnCriarMenu.Location = new System.Drawing.Point(299, 487);
            this.btnCriarMenu.Name = "btnCriarMenu";
            this.btnCriarMenu.Size = new System.Drawing.Size(87, 36);
            this.btnCriarMenu.TabIndex = 20;
            this.btnCriarMenu.Text = "Associar";
            this.btnCriarMenu.UseVisualStyleBackColor = true;
            this.btnCriarMenu.Click += new System.EventHandler(this.btnCriarMenu_Click);
            // 
            // RestauranteIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 550);
            this.Controls.Add(this.btnCriarMenu);
            this.Controls.Add(this.btnApagarMenu);
            this.Controls.Add(this.btnCriarTrabalhadores);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnApagarTrabalhadores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPedidosRestaurante);
            this.Name = "RestauranteIndividual";
            this.Text = "RestauranteIndivi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPedidosRestaurante;
        private System.Windows.Forms.Button btnApagarTrabalhadores;
        private System.Windows.Forms.Button btnCriarTrabalhadores;
        private System.Windows.Forms.Button btnApagarMenu;
        private System.Windows.Forms.Button btnCriarMenu;
    }
}