namespace Projeto_DA_Restaurante
{
    partial class CRUD_Utilizador
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label telemovelLabel;
            this.btnSeguinte = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.telemovelTextBox = new System.Windows.Forms.TextBox();
            this.voltarbutton = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            telemovelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(78, 44);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(47, 16);
            nomeLabel.TabIndex = 25;
            nomeLabel.Text = "Nome:";
            // 
            // telemovelLabel
            // 
            telemovelLabel.AutoSize = true;
            telemovelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telemovelLabel.Location = new System.Drawing.Point(78, 70);
            telemovelLabel.Name = "telemovelLabel";
            telemovelLabel.Size = new System.Drawing.Size(75, 16);
            telemovelLabel.TabIndex = 27;
            telemovelLabel.Text = "Telemovel:";
            // 
            // btnSeguinte
            // 
            this.btnSeguinte.Location = new System.Drawing.Point(295, 142);
            this.btnSeguinte.Name = "btnSeguinte";
            this.btnSeguinte.Size = new System.Drawing.Size(82, 38);
            this.btnSeguinte.TabIndex = 22;
            this.btnSeguinte.Text = "Seguite";
            this.btnSeguinte.UseVisualStyleBackColor = true;
            this.btnSeguinte.Click += new System.EventHandler(this.btnSeguinte_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(156, 41);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 22);
            this.nomeTextBox.TabIndex = 26;
            // 
            // telemovelTextBox
            // 
            this.telemovelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telemovelTextBox.Location = new System.Drawing.Point(156, 67);
            this.telemovelTextBox.Name = "telemovelTextBox";
            this.telemovelTextBox.Size = new System.Drawing.Size(100, 22);
            this.telemovelTextBox.TabIndex = 28;
            // 
            // voltarbutton
            // 
            this.voltarbutton.Location = new System.Drawing.Point(12, 142);
            this.voltarbutton.Name = "voltarbutton";
            this.voltarbutton.Size = new System.Drawing.Size(82, 38);
            this.voltarbutton.TabIndex = 31;
            this.voltarbutton.Text = "Voltar";
            this.voltarbutton.UseVisualStyleBackColor = true;
            this.voltarbutton.Click += new System.EventHandler(this.voltarbutton_Click);
            // 
            // CRUD_Utilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 192);
            this.Controls.Add(this.voltarbutton);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(telemovelLabel);
            this.Controls.Add(this.telemovelTextBox);
            this.Controls.Add(this.btnSeguinte);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CRUD_Utilizador";
            this.Text = "CRUD_Cliente";
            this.Load += new System.EventHandler(this.CRUD_Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSeguinte;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox telemovelTextBox;
        private System.Windows.Forms.Button voltarbutton;
    }
}