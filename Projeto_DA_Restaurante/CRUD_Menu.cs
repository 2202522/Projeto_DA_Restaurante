using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA_Restaurante
{
    public partial class CRUD_Menu : Form
    {

        RestauranteContext restauranteContext;
        public CRUD_Menu()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();

        }

        private void CRUD_Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restGestDBDataSet.CategoriaSet' table. You can move, or remove it, as needed.
            this.categoriaSetTableAdapter.Fill(this.restGestDBDataSet.CategoriaSet);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void btnCocluir_Click(object sender, EventArgs e)
        {
            ItemMenu itemMenu = new ItemMenu();
            itemMenu.Nome = nomeTextBox.Text;            
            itemMenu.Fotografia = fotografiaTextBox.Text;
            itemMenu.Preco = Convert.ToDouble(precoTextBox.Text);
            itemMenu.Ingredientes = ingredientesTextBox.Text;
            itemMenu.Ativo = ativoTextBox.Text; //alterar para bolean
            itemMenu.CategoriaId = Convert.ToInt32(categoriacomboBox.SelectedValue);
            restauranteContext.ItemMenuSet.Add(itemMenu);
            restauranteContext.SaveChanges();

            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void fotografiaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoriacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void categoriaSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
