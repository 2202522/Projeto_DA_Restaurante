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
            this.itemMenu_IdComboBox = new System.Windows.Forms.ComboBox();
            this.itemMenuSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restGestDBDataSet = new Projeto_DA_Restaurante.RestGestDBDataSet();
            this.restaurante_IdcomboBox = new System.Windows.Forms.ComboBox();
            this.restauranteSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.RestauranteSetTableAdapter();
            this.itemMenuSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.ItemMenuSetTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.associarAUmRestauranteUmMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarItensMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            restaurante_IdLabel = new System.Windows.Forms.Label();
            itemMenu_IdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemMenuSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // restaurante_IdLabel
            // 
            restaurante_IdLabel.AutoSize = true;
            restaurante_IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            restaurante_IdLabel.Location = new System.Drawing.Point(54, 81);
            restaurante_IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            restaurante_IdLabel.Name = "restaurante_IdLabel";
            restaurante_IdLabel.Size = new System.Drawing.Size(105, 20);
            restaurante_IdLabel.TabIndex = 19;
            restaurante_IdLabel.Text = "Restaurante:";
            // 
            // itemMenu_IdLabel
            // 
            itemMenu_IdLabel.AutoSize = true;
            itemMenu_IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            itemMenu_IdLabel.Location = new System.Drawing.Point(54, 113);
            itemMenu_IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            itemMenu_IdLabel.Name = "itemMenu_IdLabel";
            itemMenu_IdLabel.Size = new System.Drawing.Size(92, 20);
            itemMenu_IdLabel.TabIndex = 21;
            itemMenu_IdLabel.Text = "Item Menu:";
            // 
            // itemMenu_IdComboBox
            // 
            this.itemMenu_IdComboBox.DataSource = this.itemMenuSetBindingSource;
            this.itemMenu_IdComboBox.DisplayMember = "Nome";
            this.itemMenu_IdComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemMenu_IdComboBox.FormattingEnabled = true;
            this.itemMenu_IdComboBox.Location = new System.Drawing.Point(192, 112);
            this.itemMenu_IdComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemMenu_IdComboBox.Name = "itemMenu_IdComboBox";
            this.itemMenu_IdComboBox.Size = new System.Drawing.Size(160, 24);
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
            this.restaurante_IdcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restaurante_IdcomboBox.FormattingEnabled = true;
            this.restaurante_IdcomboBox.Location = new System.Drawing.Point(192, 80);
            this.restaurante_IdcomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.restaurante_IdcomboBox.Name = "restaurante_IdcomboBox";
            this.restaurante_IdcomboBox.Size = new System.Drawing.Size(160, 24);
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.associarAUmRestauranteUmMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(451, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // associarAUmRestauranteUmMenuToolStripMenuItem
            // 
            this.associarAUmRestauranteUmMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.concluirToolStripMenuItem,
            this.voltarItensMenuToolStripMenuItem});
            this.associarAUmRestauranteUmMenuToolStripMenuItem.Name = "associarAUmRestauranteUmMenuToolStripMenuItem";
            this.associarAUmRestauranteUmMenuToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
            this.associarAUmRestauranteUmMenuToolStripMenuItem.Text = "Associar a um Restaurante um Menu";
            // 
            // concluirToolStripMenuItem
            // 
            this.concluirToolStripMenuItem.Name = "concluirToolStripMenuItem";
            this.concluirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.concluirToolStripMenuItem.Text = "Concluir";
            this.concluirToolStripMenuItem.Click += new System.EventHandler(this.concluirToolStripMenuItem_Click);
            // 
            // voltarItensMenuToolStripMenuItem
            // 
            this.voltarItensMenuToolStripMenuItem.Name = "voltarItensMenuToolStripMenuItem";
            this.voltarItensMenuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.voltarItensMenuToolStripMenuItem.Text = "Voltar Itens Menu";
            this.voltarItensMenuToolStripMenuItem.Click += new System.EventHandler(this.voltarItensMenuToolStripMenuItem_Click);
            // 
            // Associar_Menu_Restaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(451, 246);
            this.Controls.Add(this.restaurante_IdcomboBox);
            this.Controls.Add(restaurante_IdLabel);
            this.Controls.Add(itemMenu_IdLabel);
            this.Controls.Add(this.itemMenu_IdComboBox);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Associar_Menu_Restaurante";
            this.Text = "Associar a um Restaurante um Menu";
            this.Load += new System.EventHandler(this.Associar_Menu_Restaurante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemMenuSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox itemMenu_IdComboBox;
        private System.Windows.Forms.ComboBox restaurante_IdcomboBox;
        private RestGestDBDataSet restGestDBDataSet;
        private System.Windows.Forms.BindingSource restauranteSetBindingSource;
        private RestGestDBDataSetTableAdapters.RestauranteSetTableAdapter restauranteSetTableAdapter;
        private System.Windows.Forms.BindingSource itemMenuSetBindingSource;
        private RestGestDBDataSetTableAdapters.ItemMenuSetTableAdapter itemMenuSetTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem associarAUmRestauranteUmMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarItensMenuToolStripMenuItem;
    }
}