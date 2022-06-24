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
    public partial class CriarPedido : Form
    {
        public CriarPedido()
        {
            InitializeComponent();
        }

        private void pedidoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet1);

        }

        private void pedidoSetBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet1);

        }

        private void CriarPedido_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet1.PedidoSet' table. You can move, or remove it, as needed.
            this.pedidoSetTableAdapter.Fill(this.restauranteDataSet1.PedidoSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pedidos pedidos = new Pedidos();
            pedidos.ShowDialog();
        }
    }
}
