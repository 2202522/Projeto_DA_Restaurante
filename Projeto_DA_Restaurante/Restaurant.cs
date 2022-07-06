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
    public partial class Restaurant : Form
    {
        RestauranteContext restauranteContext;

        public Restaurant()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }

        private void categoriaSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }

        private void Restaurant_Load(object sender, EventArgs e)
        {
            metodoPagamentoSetDataGridView.DataSource = restauranteContext.MetodoPagamentoSet.ToList();
            categoriaSetDataGridView.DataSource = restauranteContext.CategoriaSet.ToList();
        }

        private void criarEditarRestauranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Restaurant cRUD_Restaurant = new CRUD_Restaurant();
            cRUD_Restaurant.ShowDialog();
        }

        private void criarEditarTrabalhadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trabalhadores trabalhadores = new Trabalhadores();
            trabalhadores.ShowDialog();
        }

        private void criarEditarItensMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void criarEditarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Categoria cRUD_Categoria = new CRUD_Categoria();
            cRUD_Categoria.ShowDialog();
        }

        private void criarEditarMetodoPagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_MetodoPagamento cRUD_MetodoPagamento = new CRUD_MetodoPagamento();
            cRUD_MetodoPagamento.ShowDialog();
        }

        private void voltarMainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.ShowDialog();
        }
    }
}
