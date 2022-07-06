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
    public partial class Menu : Form
    {
        RestauranteContext restauranteContext;
        public Menu()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }



        private void Menu_Load(object sender, EventArgs e)
        {
            dataGridViewMenu.DataSource = restauranteContext.ItemMenuSet.ToList();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Restaurant restaurant = new Restaurant();
            restaurant.ShowDialog();
        }

        private void btn_CRUD_Itens_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Menu cRUD_Menu = new CRUD_Menu();
            cRUD_Menu.ShowDialog();
        }

        private void btn_Associar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Associar_Menu_Restaurante associar_Menu_Restaurante = new Associar_Menu_Restaurante();
            associar_Menu_Restaurante.ShowDialog();
        }
    }
}
