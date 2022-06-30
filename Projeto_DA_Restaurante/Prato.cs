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
    public partial class Prato : Form
    {
        public Prato()
        {
            InitializeComponent();
        }

        private void pedidoItemMenuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidoItemMenuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }

        private void Prato_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet3.PedidoItemMenu' table. You can move, or remove it, as needed.
            this.pedidoItemMenuTableAdapter.Fill(this.restauranteDataSet3.PedidoItemMenu);
            string constr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurante;Persist Security Info=True;User ID=sa;Password=Restaurante_2022";
            using (SqlConnection con = new SqlConnection(constr)) 
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT Id, Nome FROM ItemMenuSet", con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    itemMenu_IdComboBox.DataSource = dt;
                    itemMenu_IdComboBox.DisplayMember = "Nome";
                    itemMenu_IdComboBox.ValueMember = "Id";
                }
            }
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

        private void pedidoItemMenuBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidoItemMenuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }

        private void itemMenu_IdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
