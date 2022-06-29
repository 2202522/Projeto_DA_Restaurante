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



        private void CRUD_Trabalhadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet3.PessoaSet_Trabalhador' table. You can move, or remove it, as needed.
            this.pessoaSet_TrabalhadorTableAdapter.Fill(this.restauranteDataSet3.PessoaSet_Trabalhador);
            // TODO: This line of code loads data into the 'restauranteDataSet3.PessoaSet_Trabalhador' table. You can move, or remove it, as needed.
            this.pessoaSet_TrabalhadorTableAdapter.Fill(this.restauranteDataSet3.PessoaSet_Trabalhador);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trabalhadores trabalhadores = new Trabalhadores();
            trabalhadores.ShowDialog();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trabalhadores trabalhadores = new Trabalhadores();
            trabalhadores.ShowDialog();
        }

        private void pessoaSet_TrabalhadorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaSet_TrabalhadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }

        private void pessoaSet_TrabalhadorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaSet_TrabalhadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }
    }
}
