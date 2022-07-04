namespace Projeto_DA_Restaurante
{
    partial class Associar_Menu_Restaurante
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label restaurante_IdLabel;
            System.Windows.Forms.Label itemMenu_IdLabel;
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.itemMenu_IdComboBox = new System.Windows.Forms.ComboBox();
            this.itemMenuSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restGestDBDataSet = new Projeto_DA_Restaurante.RestGestDBDataSet();
            this.restaurante_IdcomboBox = new System.Windows.Forms.ComboBox();
            this.restauranteSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.RestauranteSetTableAdapter();
            this.itemMenuSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.ItemMenuSetTableAdapter();
            restaurante_IdLabel = new System.Windows.Forms.Label();
            itemMenu_IdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemMenuSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // restaurante_IdLabel
            // 
            restaurante_IdLabel.AutoSize = true;
            restaurante_IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            restaurante_IdLabel.Location = new System.Drawing.Point(40, 52);
            restaurante_IdLabel.Name = "restaurante_IdLabel";
            restaurante_IdLabel.Size = new System.Drawing.Size(83, 16);
            restaurante_IdLabel.TabIndex = 19;
            restaurante_IdLabel.Text = "Restaurante:";
            // 
            // itemMenu_IdLabel
            // 
            itemMenu_IdLabel.AutoSize = true;
            itemMenu_IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            itemMenu_IdLabel.Location = new System.Drawing.Point(40, 78);
            itemMenu_IdLabel.Name = "itemMenu_IdLabel";
            itemMenu_IdLabel.Size = new System.Drawing.Size(71, 16);
            itemMenu_IdLabel.TabIndex = 21;
            itemMenu_IdLabel.Text = "Item Menu:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 140);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConcluir
            // 
            this.btnConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Location = new System.Drawing.Point(228, 140);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(90, 40);
            this.btnConcluir.TabIndex = 18;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // itemMenu_IdComboBox
            // 
            this.itemMenu_IdComboBox.DataSource = this.itemMenuSetBindingSource;
            this.itemMenu_IdComboBox.DisplayMember = "Nome";
            this.itemMenu_IdComboBox.FormattingEnabled = true;
            this.itemMenu_IdComboBox.Location = new System.Drawing.Point(143, 77);
            this.itemMenu_IdComboBox.Name = "itemMenu_IdComboBox";
            this.itemMenu_IdComboBox.Size = new System.Drawing.Size(121, 21);
            this.itemMenu_IdComboBox.TabIndex = 22;
            this.itemMenu_IdComboBox.ValueMember = "Id";
            // 
            // itemMenuSetBindingSource
            // 
            this.itemMenuSetBindingSource.DataMember = "ItemMenuSet";
            this.itemMenuSetBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // restGestDBDataSet
            // 
            this.restGestDBDataSet.DataSetName = "RestGestDBDataSet";
            this.restGestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restaurante_IdcomboBox
            // 
            this.restaurante_IdcomboBox.DataSource = this.restauranteSetBindingSource;
            this.restaurante_IdcomboBox.DisplayMember = "Nome";
            this.restaurante_IdcomboBox.FormattingEnabled = true;
            this.restaurante_IdcomboBox.Location = new System.Drawing.Point(143, 51);
            this.restaurante_IdcomboBox.Name = "restaurante_IdcomboBox";
            this.restaurante_IdcomboBox.Size = new System.Drawing.Size(121, 21);
            this.restaurante_IdcomboBox.TabIndex = 23;
            this.restaurante_IdcomboBox.ValueMember = "Id";
            // 
            // restauranteSetBindingSource
            // 
            this.restauranteSetBindingSource.DataMember = "RestauranteSet";
            this.restauranteSetBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // restauranteSetTableAdapter
            // 
            this.restauranteSetTableAdapter.ClearBeforeFill = true;
            // 
            // itemMenuSetTableAdapter
            // 
            this.itemMenuSetTableAdapter.ClearBeforeFill = true;
            // 
            // Associar_Menu_Restaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 200);
            this.Controls.Add(this.restaurante_IdcomboBox);
            this.Controls.Add(restaurante_IdLabel);
            this.Controls.Add(itemMenu_IdLabel);
            this.Controls.Add(this.itemMenu_IdComboBox);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnBack);
            this.Name = "Associar_Menu_Restaurante";
            this.Text = "Associar a um Restaurante um Menu";
            this.Load += new System.EventHandler(this.Associar_Menu_Restaurante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemMenuSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.ComboBox itemMenu_IdComboBox;
        private System.Windows.Forms.ComboBox restaurante_IdcomboBox;
        private RestGestDBDataSet restGestDBDataSet;
        private System.Windows.Forms.BindingSource restauranteSetBindingSource;
        private RestGestDBDataSetTableAdapters.RestauranteSetTableAdapter restauranteSetTableAdapter;
        private System.Windows.Forms.BindingSource itemMenuSetBindingSource;
        private RestGestDBDataSetTableAdapters.ItemMenuSetTableAdapter itemMenuSetTableAdapter;
    }
}