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
        public CRUD_Restaurant()
        {
            InitializeComponent();
        }
        
        private void CRUD_Restaurant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet3.MoradaSet' table. You can move, or remove it, as needed.
            this.moradaSetTableAdapter.Fill(this.restauranteDataSet3.MoradaSet);
            // TODO: This line of code loads data into the 'restauranteDataSet3.RestauranteSet' table. You can move, or remove it, as needed.
            this.restauranteSetTableAdapter.Fill(this.restauranteDataSet3.RestauranteSet);

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

        private void restaurante_idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void restauranteSetBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.restauranteSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }
    }
}
