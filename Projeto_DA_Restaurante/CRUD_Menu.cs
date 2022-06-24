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
    public partial class CRUD_Menu : Form
    {
        public CRUD_Menu()
        {
            InitializeComponent();
        }

        private void itemMenuSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemMenuSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet1);

        }

        private void itemMenuSetBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.itemMenuSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet1);

        }

        private void CRUD_Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet1.ItemMenuSet' table. You can move, or remove it, as needed.
            this.itemMenuSetTableAdapter.Fill(this.restauranteDataSet1.ItemMenuSet);

        }

        private void fotografiaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btConcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            RestauranteIndividual restauranteIndividual = new RestauranteIndividual();
            restauranteIndividual.ShowDialog();

        }

        private void categoriaIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
