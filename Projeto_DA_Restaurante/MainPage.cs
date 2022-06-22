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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnRestaurante_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestaoRestaurantes gestaoRestaurantes = new GestaoRestaurantes();
            gestaoRestaurantes.ShowDialog();
        }

        private void btnUtilizador_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utilizadores utilizadores = new Utilizadores();
            utilizadores.ShowDialog();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pedidos pedidos=new Pedidos();
            pedidos.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
