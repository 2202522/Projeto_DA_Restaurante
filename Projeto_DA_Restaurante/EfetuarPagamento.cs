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
        public EfetuarPagamento()
        {
            InitializeComponent();
        }

        private void pagamentoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pagamentoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }

        private void EfetuarPagamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet3.PagamentoSet' table. You can move, or remove it, as needed.
            this.pagamentoSetTableAdapter.Fill(this.restauranteDataSet3.PagamentoSet);
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

        private void pagamentoSetBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pagamentoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }

        private void metodoPagamentoIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
