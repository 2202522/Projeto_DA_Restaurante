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

        private void concluirToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void voltarRestaurantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Restaurant restaurant = new Restaurant();
            restaurant.ShowDialog();
        }

        private void cRUDCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
