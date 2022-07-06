namespace Projeto_DA_Restaurante
{
    partial class CRUD_Cliente
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
            this.textBoxcontribuinte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxtelemovel = new System.Windows.Forms.TextBox();
            this.Telemovel = new System.Windows.Forms.Label();
            this.textBoxnome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSeguinte = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.ruaComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxcontribuinte
            // 
            this.textBoxcontribuinte.Location = new System.Drawing.Point(121, 80);
            this.textBoxcontribuinte.Name = "textBoxcontribuinte";
            this.textBoxcontribuinte.Size = new System.Drawing.Size(116, 20);
            this.textBoxcontribuinte.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nrº Contribuinte:";
            // 
            // textBoxtelemovel
            // 
            this.textBoxtelemovel.Location = new System.Drawing.Point(335, 48);
            this.textBoxtelemovel.Name = "textBoxtelemovel";
            this.textBoxtelemovel.Size = new System.Drawing.Size(116, 20);
            this.textBoxtelemovel.TabIndex = 17;
            // 
            // Telemovel
            // 
            this.Telemovel.AutoSize = true;
            this.Telemovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telemovel.Location = new System.Drawing.Point(254, 49);
            this.Telemovel.Name = "Telemovel";
            this.Telemovel.Size = new System.Drawing.Size(75, 16);
            this.Telemovel.TabIndex = 16;
            this.Telemovel.Text = "Telemovel:";
            // 
            // textBoxnome
            // 
            this.textBoxnome.Location = new System.Drawing.Point(121, 48);
            this.textBoxnome.Name = "textBoxnome";
            this.textBoxnome.Size = new System.Drawing.Size(116, 20);
            this.textBoxnome.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nome:";
            // 
            // buttonSeguinte
            // 
            this.buttonSeguinte.Location = new System.Drawing.Point(371, 157);
            this.buttonSeguinte.Name = "buttonSeguinte";
            this.buttonSeguinte.Size = new System.Drawing.Size(86, 40);
            this.buttonSeguinte.TabIndex = 20;
            this.buttonSeguinte.Text = "Seguiente";
            this.buttonSeguinte.UseVisualStyleBackColor = true;
            this.buttonSeguinte.Click += new System.EventHandler(this.buttonSeguinte_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(12, 157);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(86, 40);
            this.buttonVoltar.TabIndex = 21;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // ruaComboBox
            // 
            this.ruaComboBox.FormattingEnabled = true;
            this.ruaComboBox.Location = new System.Drawing.Point(335, 81);
            this.ruaComboBox.Name = "ruaComboBox";
            this.ruaComboBox.Size = new System.Drawing.Size(116, 21);
            this.ruaComboBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Morada:";
            // 
            // CRUD_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ruaComboBox);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonSeguinte);
            this.Controls.Add(this.textBoxcontribuinte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxtelemovel);
            this.Controls.Add(this.Telemovel);
            this.Controls.Add(this.textBoxnome);
            this.Controls.Add(this.label5);
            this.Name = "CRUD_Cliente";
            this.Text = "CRUD_Cliente";
            this.Load += new System.EventHandler(this.CRUD_Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxcontribuinte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxtelemovel;
        private System.Windows.Forms.Label Telemovel;
        private System.Windows.Forms.TextBox textBoxnome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSeguinte;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.ComboBox ruaComboBox;
        private System.Windows.Forms.Label label1;
    }
}