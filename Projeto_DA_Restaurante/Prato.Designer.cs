namespace Projeto_DA_Restaurante
{
    partial class Prato
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
            System.Windows.Forms.Label pedido_IdLabel;
            System.Windows.Forms.Label itemMenu_IdLabel;
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pedido_IdComboBox = new System.Windows.Forms.ComboBox();
            this.itemMenu_IdComboBox = new System.Windows.Forms.ComboBox();
            pedido_IdLabel = new System.Windows.Forms.Label();
            itemMenu_IdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pedido_IdLabel
            // 
            pedido_IdLabel.AutoSize = true;
            pedido_IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pedido_IdLabel.Location = new System.Drawing.Point(51, 47);
            pedido_IdLabel.Name = "pedido_IdLabel";
            pedido_IdLabel.Size = new System.Drawing.Size(54, 16);
            pedido_IdLabel.TabIndex = 11;
            pedido_IdLabel.Text = "Pedido:";
            // 
            // itemMenu_IdLabel
            // 
            itemMenu_IdLabel.AutoSize = true;
            itemMenu_IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            itemMenu_IdLabel.Location = new System.Drawing.Point(51, 74);
            itemMenu_IdLabel.Name = "itemMenu_IdLabel";
            itemMenu_IdLabel.Size = new System.Drawing.Size(71, 16);
            itemMenu_IdLabel.TabIndex = 13;
            itemMenu_IdLabel.Text = "Item Menu:";
            // 
            // btnConcluir
            // 
            this.btnConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Location = new System.Drawing.Point(228, 140);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(90, 40);
            this.btnConcluir.TabIndex = 9;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 140);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pedido_IdComboBox
            // 
            this.pedido_IdComboBox.DisplayMember = "Id";
            this.pedido_IdComboBox.FormattingEnabled = true;
            this.pedido_IdComboBox.Location = new System.Drawing.Point(142, 46);
            this.pedido_IdComboBox.Name = "pedido_IdComboBox";
            this.pedido_IdComboBox.Size = new System.Drawing.Size(121, 21);
            this.pedido_IdComboBox.TabIndex = 12;
            this.pedido_IdComboBox.ValueMember = "Id";
            // 
            // itemMenu_IdComboBox
            // 
            this.itemMenu_IdComboBox.DisplayMember = "Id";
            this.itemMenu_IdComboBox.FormattingEnabled = true;
            this.itemMenu_IdComboBox.Location = new System.Drawing.Point(142, 73);
            this.itemMenu_IdComboBox.Name = "itemMenu_IdComboBox";
            this.itemMenu_IdComboBox.Size = new System.Drawing.Size(121, 21);
            this.itemMenu_IdComboBox.TabIndex = 14;
            this.itemMenu_IdComboBox.ValueMember = "Id";
            this.itemMenu_IdComboBox.SelectedIndexChanged += new System.EventHandler(this.itemMenu_IdComboBox_SelectedIndexChanged);
            // 
            // Prato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 200);
            this.Controls.Add(pedido_IdLabel);
            this.Controls.Add(this.pedido_IdComboBox);
            this.Controls.Add(itemMenu_IdLabel);
            this.Controls.Add(this.itemMenu_IdComboBox);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConcluir);
            this.Name = "Prato";
            this.Text = "Associar prato a um pedido";
            this.Load += new System.EventHandler(this.Prato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox pedido_IdComboBox;
        private System.Windows.Forms.ComboBox itemMenu_IdComboBox;

    }
}