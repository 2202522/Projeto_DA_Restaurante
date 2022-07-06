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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label pedido_IdLabel;
            System.Windows.Forms.Label itemMenu_IdLabel;
            this.pedido_IdComboBox = new System.Windows.Forms.ComboBox();
            this.pedidoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restGestDBDataSet = new Projeto_DA_Restaurante.RestGestDBDataSet();
            this.itemMenu_IdComboBox = new System.Windows.Forms.ComboBox();
            this.itemMenuSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemMenuSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.ItemMenuSetTableAdapter();
            this.pedidoSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.PedidoSetTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.associarPratoAUmPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pedido_IdLabel = new System.Windows.Forms.Label();
            itemMenu_IdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMenuSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pedido_IdLabel
            // 
            pedido_IdLabel.AutoSize = true;
            pedido_IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pedido_IdLabel.Location = new System.Drawing.Point(65, 100);
            pedido_IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pedido_IdLabel.Name = "pedido_IdLabel";
            pedido_IdLabel.Size = new System.Drawing.Size(65, 20);
            pedido_IdLabel.TabIndex = 11;
            pedido_IdLabel.Text = "Pedido:";
            // 
            // itemMenu_IdLabel
            // 
            itemMenu_IdLabel.AutoSize = true;
            itemMenu_IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            itemMenu_IdLabel.Location = new System.Drawing.Point(65, 133);
            itemMenu_IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            itemMenu_IdLabel.Name = "itemMenu_IdLabel";
            itemMenu_IdLabel.Size = new System.Drawing.Size(92, 20);
            itemMenu_IdLabel.TabIndex = 13;
            itemMenu_IdLabel.Text = "Item Menu:";
            // 
            // pedido_IdComboBox
            // 
            this.pedido_IdComboBox.DataSource = this.pedidoSetBindingSource;
            this.pedido_IdComboBox.DisplayMember = "ValorTotal";
            this.pedido_IdComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pedido_IdComboBox.FormattingEnabled = true;
            this.pedido_IdComboBox.Location = new System.Drawing.Point(186, 99);
            this.pedido_IdComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.pedido_IdComboBox.Name = "pedido_IdComboBox";
            this.pedido_IdComboBox.Size = new System.Drawing.Size(160, 24);
            this.pedido_IdComboBox.TabIndex = 12;
            this.pedido_IdComboBox.ValueMember = "Id";
            // 
            // pedidoSetBindingSource
            // 
            this.pedidoSetBindingSource.DataMember = "PedidoSet";
            this.pedidoSetBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // restGestDBDataSet
            // 
            this.restGestDBDataSet.DataSetName = "RestGestDBDataSet";
            this.restGestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemMenu_IdComboBox
            // 
            this.itemMenu_IdComboBox.DataSource = this.itemMenuSetBindingSource;
            this.itemMenu_IdComboBox.DisplayMember = "Nome";
            this.itemMenu_IdComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemMenu_IdComboBox.FormattingEnabled = true;
            this.itemMenu_IdComboBox.Location = new System.Drawing.Point(186, 132);
            this.itemMenu_IdComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemMenu_IdComboBox.Name = "itemMenu_IdComboBox";
            this.itemMenu_IdComboBox.Size = new System.Drawing.Size(160, 24);
            this.itemMenu_IdComboBox.TabIndex = 14;
            this.itemMenu_IdComboBox.ValueMember = "Id";
            // 
            // itemMenuSetBindingSource
            // 
            this.itemMenuSetBindingSource.DataMember = "ItemMenuSet";
            this.itemMenuSetBindingSource.DataSource = this.restGestDBDataSet;
            // 
            // itemMenuSetTableAdapter
            // 
            this.itemMenuSetTableAdapter.ClearBeforeFill = true;
            // 
            // pedidoSetTableAdapter
            // 
            this.pedidoSetTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.associarPratoAUmPedidoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // associarPratoAUmPedidoToolStripMenuItem
            // 
            this.associarPratoAUmPedidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.concluirToolStripMenuItem,
            this.voltarPedidosToolStripMenuItem});
            this.associarPratoAUmPedidoToolStripMenuItem.Name = "associarPratoAUmPedidoToolStripMenuItem";
            this.associarPratoAUmPedidoToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.associarPratoAUmPedidoToolStripMenuItem.Text = "Associar prato a um pedido";
            // 
            // concluirToolStripMenuItem
            // 
            this.concluirToolStripMenuItem.Name = "concluirToolStripMenuItem";
            this.concluirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.concluirToolStripMenuItem.Text = "Concluir";
            this.concluirToolStripMenuItem.Click += new System.EventHandler(this.concluirToolStripMenuItem_Click);
            // 
            // voltarPedidosToolStripMenuItem
            // 
            this.voltarPedidosToolStripMenuItem.Name = "voltarPedidosToolStripMenuItem";
            this.voltarPedidosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.voltarPedidosToolStripMenuItem.Text = "Voltar Pedidos";
            this.voltarPedidosToolStripMenuItem.Click += new System.EventHandler(this.voltarPedidosToolStripMenuItem_Click);
            // 
            // Prato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(444, 246);
            this.Controls.Add(pedido_IdLabel);
            this.Controls.Add(this.pedido_IdComboBox);
            this.Controls.Add(itemMenu_IdLabel);
            this.Controls.Add(this.itemMenu_IdComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Prato";
            this.Text = "Associar prato a um pedido";
            this.Load += new System.EventHandler(this.Prato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedidoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMenuSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox pedido_IdComboBox;
        private System.Windows.Forms.ComboBox itemMenu_IdComboBox;
        private RestGestDBDataSet restGestDBDataSet;
        private System.Windows.Forms.BindingSource itemMenuSetBindingSource;
        private RestGestDBDataSetTableAdapters.ItemMenuSetTableAdapter itemMenuSetTableAdapter;
        private System.Windows.Forms.BindingSource pedidoSetBindingSource;
        private RestGestDBDataSetTableAdapters.PedidoSetTableAdapter pedidoSetTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem associarPratoAUmPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarPedidosToolStripMenuItem;
    }
}