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
    public partial class RestauranteIndividual : Form
    {
        public RestauranteIndividual()
        {
            InitializeComponent();
        }

        private void btnPedidosRestaurante_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pedidos pedidos = new Pedidos();
            pedidos.ShowDialog();
        }

        private void itemMenuSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemMenuSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet1);

        }

        private void RestauranteIndividual_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet1.PessoaSet_Trabalhador' table. You can move, or remove it, as needed.
            this.pessoaSet_TrabalhadorTableAdapter.Fill(this.restauranteDataSet1.PessoaSet_Trabalhador);
            // TODO: This line of code loads data into the 'restauranteDataSet1.ItemMenuSet' table. You can move, or remove it, as needed.
            this.itemMenuSetTableAdapter.Fill(this.restauranteDataSet1.ItemMenuSet);

        }

        private void btnEditarMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Menu cRUD_Menu = new CRUD_Menu();
            cRUD_Menu.ShowDialog();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestaoRestaurantes gestaoRestaurantes = new GestaoRestaurantes();
            gestaoRestaurantes.ShowDialog();
        }

        private void btnApagarTrabalhadores_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Trabalhadores cRUD_Trabalhadores = new CRUD_Trabalhadores();
            cRUD_Trabalhadores.ShowDialog();
        }
    }
}
