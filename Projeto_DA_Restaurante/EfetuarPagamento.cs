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

            comboBoxpedido.DataSource = restauranteContext.PedidoSet.ToList();
            comboBoxpedido.ValueMember = "Id";
            comboBoxpedido.DisplayMember = "Referencia";

            comboBoxmetodo.DataSource = restauranteContext.MetodoPagamentoSet.ToList();
            comboBoxmetodo.ValueMember = "Id";
            comboBoxmetodo.DisplayMember = "MetoPagamento";

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

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            Pagamento pagamento = new Pagamento();
            pagamento.Valor = Convert.ToDouble(textBoxvalor.Text);
            pagamento.Data = Convert.ToDateTime(dateTimePicker1.Text);
            pagamento.PedidoId = Convert.ToInt32(comboBoxpedido.SelectedValue);
            pagamento.MetodoPagamentoId = Convert.ToInt32(comboBoxmetodo.SelectedValue);
            pagamento.PromocaoIdPromocao = Convert.ToInt32(textBoxpromoçao.Text);
            restauranteContext.PagamentoSet.Add(pagamento);
            restauranteContext.SaveChanges();

            this.Hide();
            Pedidos pedido = new Pedidos();
            pedido.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pedidos pedido = new Pedidos();
            pedido.ShowDialog();
        }

    }
}
