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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.ShowDialog();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FinalizarPedido finalizarPedido = new FinalizarPedido();
            finalizarPedido.ShowDialog();
        }

        private void btnAssociar_Click(object sender, EventArgs e)
        {
            AssociarCliente associarCliente = new AssociarCliente();
            associarCliente.ShowDialog();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarItem adicionarItem = new AdicionarItem();
            adicionarItem.ShowDialog();
        }

        private void btnApagarPedidos_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarPedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            CriarPedido criarPedido = new CriarPedido();
            criarPedido.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet1.PedidoSet' table. You can move, or remove it, as needed.
            this.pedidoSetTableAdapter.Fill(this.restauranteDataSet1.PedidoSet);
            // TODO: This line of code loads data into the 'restauranteDataSet1.RestauranteSet' table. You can move, or remove it, as needed.
            this.restauranteSetTableAdapter.Fill(this.restauranteDataSet1.RestauranteSet);
        }

        private void restauranteSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.restauranteSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet1);
        }
    }
}
