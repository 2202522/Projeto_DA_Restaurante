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
    public partial class Associar_Menu_Restaurante : Form
    {
        List<Restaurante> restaurantes;
        List<ItemMenu> items;
        RestauranteContext restauranteContext;
        public Associar_Menu_Restaurante()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }

        private void Associar_Menu_Restaurante_Load(object sender, EventArgs e)
        {
            comboBoxItemMenu.DataSource = restauranteContext.ItemMenuSet.ToList();
            items = restauranteContext.ItemMenuSet.ToList();
            comboBoxItemMenu.ValueMember = "Id";
            comboBoxItemMenu.DisplayMember = "Nome";

            comboBoxrestaurante.DataSource = restauranteContext.RestauranteSet.ToList();
            restaurantes = restauranteContext.RestauranteSet.ToList();
            comboBoxrestaurante.ValueMember = "Id";
            comboBoxrestaurante.DisplayMember = "Nome";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            //Associar_Menu_Restaurante itemMenu = new Associar_Menu_Restaurante();
            //itemMenu.Resta = Convert.ToInt32(restaurante_IdcomboBox.SelectedValue);
            //itemMenu.Menu = Convert.ToInt32(itemMenu_IdComboBox.SelectedValue);
            //restauranteContext.Associar_Menu_Restaurante.Add(itemMenu);
            //restauranteContext.SaveChanges();

            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }


    }
}
