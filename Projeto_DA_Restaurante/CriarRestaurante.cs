using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_DA_Restaurante
{
    public partial class CriarRestaurante : Form
    {

        public CriarRestaurante()
        {            
            InitializeComponent();
        }

        private void CriarRestaurante_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet1.RestauranteSet' table. You can move, or remove it, as needed.
            this.restauranteSetTableAdapter.Fill(this.restauranteDataSet1.RestauranteSet);

        }

        private void restauranteSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarRestaurante_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarRestauranteView_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestaoRestaurantes gestaoRestaurantes = new GestaoRestaurantes();
            gestaoRestaurantes.ShowDialog();
        }

        private void restauranteSetBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.restauranteSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet1);

        }
    }
}
