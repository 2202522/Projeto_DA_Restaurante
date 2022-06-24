﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA_Restaurante
{
    public partial class CRUD_MetodoPagamento : Form
    {
        public CRUD_MetodoPagamento()
        {
            InitializeComponent();
        }

        private void metodoPagamentoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.metodoPagamentoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet1);

        }

        private void CRUD_MetodoPagamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet1.MetodoPagamentoSet' table. You can move, or remove it, as needed.
            this.metodoPagamentoSetTableAdapter.Fill(this.restauranteDataSet1.MetodoPagamentoSet);

        }

        private void metoPagamentoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestaoRestaurantes gestaoRestaurantes = new GestaoRestaurantes();
            gestaoRestaurantes.ShowDialog();
        }
    }
}
