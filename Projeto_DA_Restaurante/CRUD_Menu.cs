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
        List<Restaurante> restaurantes;
        List<Categoria> categorias;
        RestauranteContext restauranteContext;
        public CRUD_Menu()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }

        private void CRUD_Menu_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = restauranteContext.CategoriaSet.ToList();
            categorias = restauranteContext.CategoriaSet.ToList();
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Nome";

            comboBoxrestaurante.DataSource = restauranteContext.RestauranteSet.ToList();
            restaurantes = restauranteContext.RestauranteSet.ToList();
            comboBoxrestaurante.ValueMember = "Id";
            comboBoxrestaurante.DisplayMember = "Nome";
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
            itemMenu.Nome = nometextBox.Text;
            itemMenu.Fotografia = fotografiatextBox.Text;
            itemMenu.Preco = Convert.ToDouble(precotextBox.Text);
            itemMenu.Ingredientes = ingredientestextBox.Text;
            itemMenu.Ativo = ativotextBox.Text; //alterar para bolean
            int index = comboBox1.SelectedIndex;
            itemMenu.Categoria = categorias[index];

            restauranteContext.ItemMenuSet.Add(itemMenu);
            restauranteContext.SaveChanges();

            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }
    }
}
