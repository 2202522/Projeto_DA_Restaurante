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
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCriarClientesView = new System.Windows.Forms.Button();
            this.btnEliminarClientes = new System.Windows.Forms.Button();
            this.btnEditarClientes = new System.Windows.Forms.Button();
            this.btnConsultarClientes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(24, 493);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(109, 47);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gestão de Clientes";
            // 
            // btnCriarClientesView
            // 
            this.btnCriarClientesView.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarClientesView.Location = new System.Drawing.Point(94, 124);
            this.btnCriarClientesView.Margin = new System.Windows.Forms.Padding(4);
            this.btnCriarClientesView.Name = "btnCriarClientesView";
            this.btnCriarClientesView.Size = new System.Drawing.Size(160, 57);
            this.btnCriarClientesView.TabIndex = 14;
            this.btnCriarClientesView.Text = "Criar";
            this.btnCriarClientesView.UseVisualStyleBackColor = true;
            // 
            // btnEliminarClientes
            // 
            this.btnEliminarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarClientes.Location = new System.Drawing.Point(94, 210);
            this.btnEliminarClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarClientes.Name = "btnEliminarClientes";
            this.btnEliminarClientes.Size = new System.Drawing.Size(160, 57);
            this.btnEliminarClientes.TabIndex = 15;
            this.btnEliminarClientes.Text = "Eliminar";
            this.btnEliminarClientes.UseVisualStyleBackColor = true;
            // 
            // btnEditarClientes
            // 
            this.btnEditarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarClientes.Location = new System.Drawing.Point(94, 301);
            this.btnEditarClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarClientes.Name = "btnEditarClientes";
            this.btnEditarClientes.Size = new System.Drawing.Size(160, 57);
            this.btnEditarClientes.TabIndex = 16;
            this.btnEditarClientes.Text = "Editar";
            this.btnEditarClientes.UseVisualStyleBackColor = true;
            // 
            // btnConsultarClientes
            // 
            this.btnConsultarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarClientes.Location = new System.Drawing.Point(94, 396);
            this.btnConsultarClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarClientes.Name = "btnConsultarClientes";
            this.btnConsultarClientes.Size = new System.Drawing.Size(160, 57);
            this.btnConsultarClientes.TabIndex = 17;
            this.btnConsultarClientes.Text = "Consultar";
            this.btnConsultarClientes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(385, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 460);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Clientes";
            // 
            // Utilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 567);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConsultarClientes);
            this.Controls.Add(this.btnEditarClientes);
            this.Controls.Add(this.btnEliminarClientes);
            this.Controls.Add(this.btnCriarClientesView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Utilizadores";
            this.Text = "Utilizadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCriarClientesView;
        private System.Windows.Forms.Button btnEliminarClientes;
        private System.Windows.Forms.Button btnEditarClientes;
        private System.Windows.Forms.Button btnConsultarClientes;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}