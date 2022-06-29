﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;



namespace Projeto_DA_Restaurante
{
    public partial class CRUD_Morada : Form
    {
        public CRUD_Morada()
        {
            InitializeComponent();
        }

        private void CRUD_Morada_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet3.MoradaSet' table. You can move, or remove it, as needed.
            this.moradaSetTableAdapter.Fill(this.restauranteDataSet3.MoradaSet);

        }

        private void btnSeguinte_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Utilizador cRUD_Cliente = new CRUD_Utilizador();
            cRUD_Cliente.ShowDialog();

        }

        private void moradaSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moradaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }
    }
}
