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
    public partial class AssociarTrabalhador : Form
    {

        RestauranteContext restauranteContext;
        public AssociarTrabalhador()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }

        private void pessoaSet_TrabalhadorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaSet_TrabalhadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restGestDBDataSet);

        }

        private void pessoaSet_TrabalhadorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaSet_TrabalhadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restGestDBDataSet);

        }

        private void AssociarTrabalhador_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restGestDBDataSet.RestauranteSet' table. You can move, or remove it, as needed.
            this.restauranteSetTableAdapter.Fill(this.restGestDBDataSet.RestauranteSet);
            // TODO: This line of code loads data into the 'restGestDBDataSet.PessoaSet' table. You can move, or remove it, as needed.
            this.pessoaSetTableAdapter.Fill(this.restGestDBDataSet.PessoaSet);
            // TODO: This line of code loads data into the 'restGestDBDataSet.PedidoSet' table. You can move, or remove it, as needed.
            this.pedidoSetTableAdapter.Fill(this.restGestDBDataSet.PedidoSet);
            // TODO: This line of code loads data into the 'restGestDBDataSet.PessoaSet_Trabalhador' table. You can move, or remove it, as needed.
            this.pessoaSet_TrabalhadorTableAdapter.Fill(this.restGestDBDataSet.PessoaSet_Trabalhador);

        }

        private void concluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pessoa trabalhador = new Pessoa();
            //itemMenu.Fotografia = fotografiaTextBox.Text;
            //itemMenu.Preco = Convert.ToDouble(precoTextBox.Text);
            //itemMenu.Ingredientes = ingredientesTextBox.Text;
            //itemMenu.Ativo = ativoTextBox.Text; //alterar para bolean
            //itemMenu.CategoriaId = Convert.ToInt32(categoriacomboBox.SelectedValue);
            this.Hide();
            Trabalhadores trabalhadores = new Trabalhadores();
            trabalhadores.ShowDialog();
        }

        private void voltarTrabalhadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trabalhadores trabalhadores = new Trabalhadores();
            trabalhadores.ShowDialog();
        }
    }
}
