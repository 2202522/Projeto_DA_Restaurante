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
        public CRUD_Categoria()
        {
            InitializeComponent();
        }

        private void categoriaSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }

        private void CRUD_Categoria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet3.CategoriaSet' table. You can move, or remove it, as needed.
            this.categoriaSetTableAdapter.Fill(this.restauranteDataSet3.CategoriaSet);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Restaurant restaurant = new Restaurant();
            restaurant.ShowDialog();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Restaurant restaurant = new Restaurant();
            restaurant.ShowDialog();
        }
    }
}
