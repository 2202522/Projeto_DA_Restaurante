using System;
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
            Restaurant restaurant = new Restaurant();
            restaurant.ShowDialog();
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
            Pedidos pedidos = new Pedidos();
            pedidos.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Status status = new Status();
            status.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vendas vendas = new Vendas();
            vendas.ShowDialog();
        }

        private void btnPromocoes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Promocoes promocoes = new Promocoes();
            promocoes.ShowDialog();
        }
    }
}
