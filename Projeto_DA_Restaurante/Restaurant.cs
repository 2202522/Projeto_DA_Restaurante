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
        public Restaurant()
        {
            InitializeComponent();
        }

        private void categoriaSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }

        private void Restaurant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet3.MetodoPagamentoSet' table. You can move, or remove it, as needed.
            this.metodoPagamentoSetTableAdapter.Fill(this.restauranteDataSet3.MetodoPagamentoSet);
            // TODO: This line of code loads data into the 'restauranteDataSet3.CategoriaSet' table. You can move, or remove it, as needed.
            this.categoriaSetTableAdapter.Fill(this.restauranteDataSet3.CategoriaSet);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.ShowDialog();
        }

        private void btn_CRUD_Categoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Categoria cRUD_Categoria = new CRUD_Categoria();
            cRUD_Categoria.ShowDialog();
        }

        private void btn_CRUD_MetodoPagamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_MetodoPagamento cRUD_MetodoPagamento = new CRUD_MetodoPagamento();
            cRUD_MetodoPagamento.ShowDialog();
        }

        private void btn_CRUD_Restaurante_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Restaurant cRUD_Restaurant = new CRUD_Restaurant();
            cRUD_Restaurant.ShowDialog();
        }

        private void btn_CRUD_Trabalhadores_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trabalhadores trabalhadores = new Trabalhadores();
            trabalhadores.ShowDialog();
        }

        private void btn_CRUD_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }
    }
}
