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
    public partial class CRUD_Trabalhadores : Form
    {
        public CRUD_Trabalhadores()
        {
            InitializeComponent();
        }

        private void pessoaSet_TrabalhadorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaSet_TrabalhadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet1);

        }

        private void CRUD_Trabalhadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet1.PessoaSet_Trabalhador' table. You can move, or remove it, as needed.
            this.pessoaSet_TrabalhadorTableAdapter.Fill(this.restauranteDataSet1.PessoaSet_Trabalhador);

        }

        private void btConcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            RestauranteIndividual restauranteIndividual = new RestauranteIndividual();
            restauranteIndividual.ShowDialog();
        }
    }
}
