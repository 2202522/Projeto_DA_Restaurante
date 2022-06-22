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
    public partial class RestauranteIndividual : Form
    {
        public RestauranteIndividual()
        {
            InitializeComponent();
        }

        private void btnPedidosRestaurante_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pedidos pedidos = new Pedidos();
            pedidos.ShowDialog();
        }

        private void btnCriarMenu_Click(object sender, EventArgs e)
        {
            AssociarMenu criarMenu = new AssociarMenu();
            criarMenu.ShowDialog();
        }

        private void btnCriarTrabalhadores_Click(object sender, EventArgs e)
        {
            AssociarTrabalhadores associarTrabalhadores = new AssociarTrabalhadores();
            associarTrabalhadores.ShowDialog();
        }
    }
}
