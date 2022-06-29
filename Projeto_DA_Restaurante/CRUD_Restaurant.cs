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
    public partial class CRUD_Restaurant : Form
    {
        public CRUD_Restaurant()
        {
            InitializeComponent();
        }

        private void restauranteSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.restauranteSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }

        private void restauranteSetBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.restauranteSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }

        private void CRUD_Restaurant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet3.RestauranteSet' table. You can move, or remove it, as needed.
            this.restauranteSetTableAdapter.Fill(this.restauranteDataSet3.RestauranteSet);

        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Restaurant restaurant = new Restaurant();
            restaurant.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Restaurant restaurant = new Restaurant();
            restaurant.ShowDialog();
        }
    }
}
