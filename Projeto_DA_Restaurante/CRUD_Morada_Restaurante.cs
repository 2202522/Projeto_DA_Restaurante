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
            morada.Rua = textBoxrua.Text;
            morada.Cidade = textBoxcidade.Text;
            morada.CodPostal = int.Parse(textBoxcodpostal.Text);
            morada.Pais = textBoxpais.Text;
            //morada.Restaurante= (Restaurante)restaurante_IdComboBox.SelectedValue;
            restauranteContext.MoradaSet.Add(morada);
            restauranteContext.SaveChanges();

            this.Hide();
            CRUD_Restaurant cRUD_Restaurant = new CRUD_Restaurant();
            cRUD_Restaurant.ShowDialog();
        }


    }
}
