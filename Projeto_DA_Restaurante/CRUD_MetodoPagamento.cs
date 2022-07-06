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
    public partial class CRUD_MetodoPagamento : Form
    {
        RestauranteContext restauranteContext;

        public CRUD_MetodoPagamento()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }

        private void concluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetodoPagamento metodoPagamento = new MetodoPagamento();
            metodoPagamento.MetoPagamento = metoPagamentoTextBox.Text;
            metodoPagamento.Ativo = ativoTextBox.Text; //alterar para bolean
            restauranteContext.MetodoPagamentoSet.Add(metodoPagamento);
            restauranteContext.SaveChanges();

            this.Hide();
            Restaurant restaurant = new Restaurant();
            restaurant.ShowDialog();
        }

        private void voltarRestaurantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Restaurant restaurant = new Restaurant();
            restaurant.ShowDialog();
        }
    }
}
