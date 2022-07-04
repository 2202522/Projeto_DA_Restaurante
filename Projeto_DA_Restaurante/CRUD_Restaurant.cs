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
        RestauranteContext restauranteContext;
        public CRUD_Restaurant()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }
        
        private void CRUD_Restaurant_Load(object sender, EventArgs e)
        {            
            //string constr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurante;Persist Security Info=True;User ID=sa;Password=Restaurante_2022";
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT Id, Rua FROM MoradaSet", con))
            //    {
            //        DataTable dt = new DataTable();
            //        sda.Fill(dt);
            //        restaurante_idComboBox.DataSource = dt;
            //        restaurante_idComboBox.DisplayMember = "Rua";
            //        restaurante_idComboBox.ValueMember = "Id";
            //    }
            //}
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            Restaurante restaurante = new Restaurante();
            restaurante.Nome = nomeTextBox.Text;
            restauranteContext.RestauranteSet.Add(restaurante);
            restauranteContext.SaveChanges();

            this.Hide();
            CRUD_Morada_Restaurante cRUD_Morada_Restaurante = new CRUD_Morada_Restaurante();
            cRUD_Morada_Restaurante.ShowDialog();
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
