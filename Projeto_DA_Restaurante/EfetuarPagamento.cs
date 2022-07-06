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
    public partial class EfetuarPagamento : Form
    {
        RestauranteContext restauranteContext;
        public EfetuarPagamento()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }

        private void EfetuarPagamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restGestDBDataSet1.Promocaos' table. You can move, or remove it, as needed.
            this.promocaosTableAdapter.Fill(this.restGestDBDataSet1.Promocaos);
            // TODO: This line of code loads data into the 'restGestDBDataSet1.MetodoPagamentoSet' table. You can move, or remove it, as needed.
            this.metodoPagamentoSetTableAdapter1.Fill(this.restGestDBDataSet1.MetodoPagamentoSet);


            //string constr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurante;Persist Security Info=True;User ID=sa;Password=Restaurante_2022";
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT Id, MetoPagamento FROM MetodoPagamentoSet", con))
            //    {
            //        DataTable dt = new DataTable();
            //        sda.Fill(dt);

            //        metodoPagamentoIdComboBox.DataSource = dt;
            //        metodoPagamentoIdComboBox.DisplayMember = "MetoPagamento";
            //        metodoPagamentoIdComboBox.ValueMember = "Id";
            //    }
            //}
        }

        private void concluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pagamento pagamento = new Pagamento();
            pagamento.Valor = Convert.ToDouble(valorTextBox.Text);
            pagamento.Data = Convert.ToDateTime(dataDateTimePicker.Text);
            pagamento.PedidoId = Convert.ToInt32(pedidoIdcomboBox.SelectedValue);
            pagamento.MetodoPagamentoId = Convert.ToInt32(metodoPagamentoIdcomboBox.SelectedValue);
            restauranteContext.PagamentoSet.Add(pagamento);
            restauranteContext.SaveChanges();

            this.Hide();
            Pedidos pedido = new Pedidos();
            pedido.ShowDialog();
        }

        private void voltarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pedidos pedido = new Pedidos();
            pedido.ShowDialog();
        }
    }
}
