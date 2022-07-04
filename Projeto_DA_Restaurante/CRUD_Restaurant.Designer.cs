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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.moradaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restGestDBDataSet = new Projeto_DA_Restaurante.RestGestDBDataSet();
            this.moradaSetTableAdapter = new Projeto_DA_Restaurante.RestGestDBDataSetTableAdapters.MoradaSetTableAdapter();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moradaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(64, 57);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 12;
            nomeLabel.Text = "Nome:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 140);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 40);
            this.btnBack.TabIndex = 8;
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
            this.btnConcluir.TabIndex = 9;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(149, 54);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(121, 20);
            this.nomeTextBox.TabIndex = 13;
            this.nomeTextBox.TextChanged += new System.EventHandler(this.nomeTextBox_TextChanged);
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
            // CRUD_Restaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 200);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnBack);
            this.Name = "CRUD_Restaurant";
            this.Text = "CRUD_Restaurant";
            this.Load += new System.EventHandler(this.CRUD_Restaurant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moradaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restGestDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.TextBox nomeTextBox;
        private RestGestDBDataSet restGestDBDataSet;
        private System.Windows.Forms.BindingSource moradaSetBindingSource;
        private RestGestDBDataSetTableAdapters.MoradaSetTableAdapter moradaSetTableAdapter;
    }
}