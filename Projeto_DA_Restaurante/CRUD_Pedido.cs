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
        List<Restaurante> restaurantes;
        List<Estado> estados;
        List<Cliente> clientes;
        List<Trabalhador> trabalhadors;
        List<ItemMenu> itemMenus;
        RestauranteContext restauranteContext;
        public CRUD_Pedido()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }

        private void CRUD_Pedido_Load(object sender, EventArgs e)
        {
            comboBoxrestaurante.DataSource = restauranteContext.RestauranteSet.ToList();
            restaurantes = restauranteContext.RestauranteSet.ToList();
            comboBoxrestaurante.ValueMember = "Id";
            comboBoxrestaurante.DisplayMember = "Nome";

            comboBoxestado.DataSource = restauranteContext.EstadoSet.ToList();
            estados = restauranteContext.EstadoSet.ToList();
            comboBoxestado.ValueMember = "Id";
            comboBoxestado.DisplayMember = "estado";

            comboBoxcliente.DataSource = restauranteContext.PessoaSet.ToList();
            //clientes = restauranteContext.PessoaSet.ToList();
            comboBoxcliente.ValueMember = "Id";
            comboBoxcliente.DisplayMember = "Nome";

            comboBoxtrabalhador.DataSource = restauranteContext.PessoaSet.ToList();
            //trabalhadors = restauranteContext.PessoaSet.ToList();
            comboBoxtrabalhador.ValueMember = "Id";
            comboBoxtrabalhador.DisplayMember = "Nome";

            comboBoxItemMenu.DataSource = restauranteContext.ItemMenuSet.ToList();
            itemMenus = restauranteContext.ItemMenuSet.ToList();
            comboBoxItemMenu.ValueMember = "Id";
            comboBoxItemMenu.DisplayMember = "Nome";
        }

        private void concluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido pedidos = new Pedido();
            int index = comboBoxrestaurante.SelectedIndex;
            pedidos.Restaurante = restaurantes[index];
            int indexS = comboBoxestado.SelectedIndex;
            pedidos.Estado = estados[indexS];
            int indexI = comboBoxItemMenu.SelectedIndex;
            pedidos.ItemMenu = (ICollection<ItemMenu>)itemMenus[indexI];
            int indexC = comboBoxcliente.SelectedIndex;
            pedidos.Cliente = clientes[indexC];
            int indexT = comboBoxtrabalhador.SelectedIndex;
            pedidos.Trabalhador = trabalhadors[indexT];
            restauranteContext.PedidoSet.Add(pedidos);
            restauranteContext.SaveChanges();

            this.Hide();
            Pedidos pedido = new Pedidos();
            pedido.ShowDialog();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pedidos pedido = new Pedidos();
            pedido.ShowDialog();
        }
    }
}
