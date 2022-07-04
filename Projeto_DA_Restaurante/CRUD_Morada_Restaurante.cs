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
    public partial class CRUD_Morada_Restaurante : Form
    {
        RestauranteContext restauranteContext;
        public CRUD_Morada_Restaurante()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }

        private void CRUD_Morada_Restaurante_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restGestDBDataSet.RestauranteSet' table. You can move, or remove it, as needed.
            this.restauranteSetTableAdapter.Fill(this.restGestDBDataSet.RestauranteSet);
            // TODO: This line of code loads data into the 'restGestDBDataSet.MoradaSet' table. You can move, or remove it, as needed.
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Restaurant restaurant = new Restaurant();
            restaurant.ShowDialog();
        }

        private void btnCocluir_Click(object sender, EventArgs e)
        {
            Morada morada = new Morada();
            morada.Rua = ruaTextBox.Text;
            morada.Cidade = cidadeTextBox.Text;
            morada.CodPostal = codPostalTextBox.Text;
            morada.Pais = paisTextBox.Text;
            morada.Restaurante= (Restaurante)restaurante_IdComboBox.SelectedValue;
            restauranteContext.MoradaSet.Add(morada);
            restauranteContext.SaveChanges();

            this.Hide();
            Restaurant restaurant = new Restaurant();
            restaurant.ShowDialog();
        }

        private void moradaSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moradaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restGestDBDataSet);

        }

        private void moradaSetBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.moradaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restGestDBDataSet);

        }
    }
}
