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
    public partial class CRUD_Categoria : Form
    {
        RestauranteContext restauranteContext;

        public CRUD_Categoria()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }

        private void CRUD_Categoria_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Restaurant restaurant = new Restaurant();
            restaurant.ShowDialog();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Nome = nomeTextBox.Text;
            categoria.Ativo = ativoTextBox.Text; //alterar para bolean
            restauranteContext.CategoriaSet.Add(categoria);
            restauranteContext.SaveChanges();
            
            this.Hide();
            Restaurant restaurant = new Restaurant();
            restaurant.ShowDialog();
        }

        private void ativoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
