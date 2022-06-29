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
    public partial class Trabalhadores : Form
    {
        public Trabalhadores()
        {
            InitializeComponent();
        }

        private void pessoaSet_TrabalhadorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaSet_TrabalhadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }

        private void Trabalhadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet3.PessoaSet_Trabalhador' table. You can move, or remove it, as needed.
            this.pessoaSet_TrabalhadorTableAdapter.Fill(this.restauranteDataSet3.PessoaSet_Trabalhador);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Restaurant restaurant = new Restaurant();
            restaurant.ShowDialog();
        }

        private void btn_Associar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssociarTrabalhador associarTrabalhador = new AssociarTrabalhador();
            associarTrabalhador.ShowDialog();
        }

        private void btn_CRUD_Trabalhadores_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Trabalhadores cRUD_Trabalhadores = new CRUD_Trabalhadores();
            cRUD_Trabalhadores.ShowDialog();
        }
    }
}
