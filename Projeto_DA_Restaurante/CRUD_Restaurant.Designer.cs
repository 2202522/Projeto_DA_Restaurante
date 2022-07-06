namespace Projeto_DA_Restaurante
{
    partial class CRUD_Restaurant
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
            System.Windows.Forms.Label nomeLabel;
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.moradaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restGestDBDataSet = new Projeto_DA_Restaurante.RestGestDBDataSet();
            this.moradaSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.MoradaSetTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cRUDRestaurantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarRestaurantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moradaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(70, 98);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(47, 16);
            nomeLabel.TabIndex = 12;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(184, 94);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(160, 22);
            this.nomeTextBox.TabIndex = 13;
            // 
            // moradaSetBindingSource
            // 
            this.moradaSetBindingSource.DataMember = "MoradaSet";
            this.moradaSetBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // restGestDBDataSet
            // 
            this.restGestDBDataSet.DataSetName = "RestGestDBDataSet";
            this.restGestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moradaSetTableAdapter
            // 
            this.moradaSetTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDRestaurantToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(451, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cRUDRestaurantToolStripMenuItem
            // 
            this.cRUDRestaurantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.concluirToolStripMenuItem,
            this.voltarRestaurantToolStripMenuItem});
            this.cRUDRestaurantToolStripMenuItem.Name = "cRUDRestaurantToolStripMenuItem";
            this.cRUDRestaurantToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.cRUDRestaurantToolStripMenuItem.Text = "Restaurante";
            this.cRUDRestaurantToolStripMenuItem.Click += new System.EventHandler(this.cRUDRestaurantToolStripMenuItem_Click);
            // 
            // concluirToolStripMenuItem
            // 
            this.concluirToolStripMenuItem.Name = "concluirToolStripMenuItem";
            this.concluirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.concluirToolStripMenuItem.Text = "Concluir";
            this.concluirToolStripMenuItem.Click += new System.EventHandler(this.concluirToolStripMenuItem_Click);
            // 
            // voltarRestaurantToolStripMenuItem
            // 
            this.voltarRestaurantToolStripMenuItem.Name = "voltarRestaurantToolStripMenuItem";
            this.voltarRestaurantToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.voltarRestaurantToolStripMenuItem.Text = "Voltar Restaurant";
            this.voltarRestaurantToolStripMenuItem.Click += new System.EventHandler(this.voltarRestaurantToolStripMenuItem_Click);
            // 
            // CRUD_Restaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(451, 179);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CRUD_Restaurant";
            this.Text = "CRUD_Restaurant";
            this.Load += new System.EventHandler(this.CRUD_Restaurant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moradaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nomeTextBox;
        private RestGestDBDataSet restGestDBDataSet;
        private System.Windows.Forms.BindingSource moradaSetBindingSource;
        private RestGestDBDataSetTableAdapters.MoradaSetTableAdapter moradaSetTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cRUDRestaurantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarRestaurantToolStripMenuItem;
    }
}