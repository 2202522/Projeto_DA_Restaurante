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
        public Menu()
        {
            InitializeComponent();
        }



        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restGestDBDataSet.ItemMenuSet' table. You can move, or remove it, as needed.
            this.itemMenuSetTableAdapter.Fill(this.restGestDBDataSet.ItemMenuSet);
            // TODO: This line of code loads data into the 'restGestDBDataSet.ItemMenuSet' table. You can move, or remove it, as needed.
            this.itemMenuSetTableAdapter.Fill(this.restGestDBDataSet.ItemMenuSet);
        }

        private void itemMenuSetBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.itemMenuSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restGestDBDataSet);

        }

        private void itemMenuSetBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.itemMenuSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restGestDBDataSet);

        }

        private void associarRestauranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Associar_Menu_Restaurante associar_Menu_Restaurante = new Associar_Menu_Restaurante();
            associar_Menu_Restaurante.ShowDialog();
        }

        private void criarEditarItensMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Menu cRUD_Menu = new CRUD_Menu();
            cRUD_Menu.ShowDialog();
        }

        private void voltarRestaurantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Restaurant restaurant = new Restaurant();
            restaurant.ShowDialog();
        }
    }
}
