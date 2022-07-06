using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA_Restaurante
{
    public partial class CRUD_Restaurant : Form
    {
        List<Morada> moradas;
        RestauranteContext restauranteContext;
        public CRUD_Restaurant()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }
        
        private void CRUD_Restaurant_Load(object sender, EventArgs e)
        {
            comboBoxrua.DataSource = restauranteContext.MoradaSet.ToList();
            moradas = restauranteContext.MoradaSet.ToList();
            comboBoxrua.ValueMember = "Id";
            comboBoxrua.DisplayMember = "Rua";
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            //Morada morada = comboBoxrua.SelectedItem as Morada;
            //restaurante.Morada.Id = Convert.ToInt32(comboBoxrua.SelectedValue);
            //int index = comboBoxrua.SelectedIndex;
            //restaurante.Morada = moradas[index];

            Restaurante restaurante = new Restaurante();
            restaurante.Nome = nomeTextBox.Text;           
            int index = comboBoxrua.SelectedIndex;
            restaurante.Morada = moradas[index];
            restauranteContext.RestauranteSet.Add(restaurante);
            restauranteContext.SaveChanges();

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

        private void restaurante_idComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
