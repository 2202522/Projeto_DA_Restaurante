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
    public partial class GestaoRestaurantes : Form
    {
        public GestaoRestaurantes()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage=new MainPage();
            mainPage.ShowDialog();
        }

        private void GestaoRestaurantes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet1.MetodoPagamentoSet' table. You can move, or remove it, as needed.
            this.metodoPagamentoSetTableAdapter.Fill(this.restauranteDataSet1.MetodoPagamentoSet);
            // TODO: This line of code loads data into the 'restauranteDataSet1.RestauranteSet' table. You can move, or remove it, as needed.
            this.restauranteSetTableAdapter.Fill(this.restauranteDataSet1.RestauranteSet);
            // TODO: This line of code loads data into the 'restauranteDataSet1.CategoriaSet' table. You can move, or remove it, as needed.
            this.categoriaSetTableAdapter.Fill(this.restauranteDataSet1.CategoriaSet);
            
        }

        private void btnCriarRestaurante_Click(object sender, EventArgs e)
        {
            this.Hide();
            CriarRestaurante criarRestaurante = new CriarRestaurante();
            criarRestaurante.ShowDialog();
        }

        private void btnAbrirRestaurante_Click(object sender, EventArgs e)
        {
            this.Hide();
            RestauranteIndividual restauranteIndividual = new RestauranteIndividual();
            restauranteIndividual.ShowDialog();
        }

        private void categoriaSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Categoria cRUD_Categoria = new CRUD_Categoria();
            cRUD_Categoria.ShowDialog();
        }

        private void categoriaSetBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet1);
        }

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_MetodoPagamento crUD_MetodoPagamento = new CRUD_MetodoPagamento();
            crUD_MetodoPagamento.ShowDialog();
        }

        private void restauranteSetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
