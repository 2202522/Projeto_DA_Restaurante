using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA_Restaurante
{
    public partial class CRUD_Pedido : Form
    {
        RestauranteContext restauranteContext;
        public CRUD_Pedido()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }

        private void CRUD_Pedido_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restGestDBDataSet.EstadoSet' table. You can move, or remove it, as needed.
            this.estadoSetTableAdapter.Fill(this.restGestDBDataSet.EstadoSet);
            // TODO: This line of code loads data into the 'restGestDBDataSet.PessoaSet' table. You can move, or remove it, as needed.
            this.pessoaSetTableAdapter.Fill(this.restGestDBDataSet.PessoaSet);
            // TODO: This line of code loads data into the 'restGestDBDataSet.PessoaSet_Cliente' table. You can move, or remove it, as needed.
            this.pessoaSet_ClienteTableAdapter.Fill(this.restGestDBDataSet.PessoaSet_Cliente);
            // TODO: This line of code loads data into the 'restGestDBDataSet.RestauranteSet' table. You can move, or remove it, as needed.
            this.restauranteSetTableAdapter.Fill(this.restGestDBDataSet.RestauranteSet);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pedidos pedido = new Pedidos();
            pedido.ShowDialog();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            Pedido pedidos = new Pedido();
            pedidos.ValorTotal = Convert.ToDouble(valorTotalTextBox.Text);
            pedidos.TrabalhadorId = Convert.ToInt32(trabalhadorIdcomboBox.SelectedValue);
            pedidos.ClienteId = Convert.ToInt32(clienteIdcomboBox.SelectedValue);
            pedidos.RestauranteId = Convert.ToInt32(restauranteIdComboBox.SelectedValue);
            pedidos.EstadoId = Convert.ToInt32(estadoIdcomboBox.SelectedValue);
            restauranteContext.PedidoSet.Add(pedidos);
            restauranteContext.SaveChanges();

            this.Hide();
            Pedidos pedido = new Pedidos();
            pedido.ShowDialog();
        }

    }
}
