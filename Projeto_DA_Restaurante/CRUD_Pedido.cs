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
        public CRUD_Pedido()
        {
            InitializeComponent();
        }

        private void pedidoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }

        private void CRUD_Pedido_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet3.PedidoSet' table. You can move, or remove it, as needed.
            this.pedidoSetTableAdapter.Fill(this.restauranteDataSet3.PedidoSet);
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pedidos pedido = new Pedidos();
            pedido.ShowDialog();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pedidos pedido = new Pedidos();
            pedido.ShowDialog();
        }

        private void restauranteIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
