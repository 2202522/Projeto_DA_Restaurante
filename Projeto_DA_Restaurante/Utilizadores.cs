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
    public partial class Utilizadores : Form
    {
        public Utilizadores()
        {
            InitializeComponent();
        }

       

        private void Utilizadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet3.MoradaSet' table. You can move, or remove it, as needed.
            this.moradaSetTableAdapter.Fill(this.restauranteDataSet3.MoradaSet);
            // TODO: This line of code loads data into the 'restauranteDataSet3.PessoaSet' table. You can move, or remove it, as needed.
            this.pessoaSetTableAdapter.Fill(this.restauranteDataSet3.PessoaSet);
            // TODO: This line of code loads data into the 'restauranteDataSet3.MoradaSet' table. You can move, or remove it, as needed.
            // this.moradaSetTableAdapter.Fill(this.restauranteDataSet3.MoradaSet);

        }

        private void btnEditarClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Morada cRUD_Morada = new CRUD_Morada();
            cRUD_Morada.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.ShowDialog();
        }

        private void pessoaSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }

        private void pessoaSetBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Cliente cRUD_Cliente = new CRUD_Cliente();
            cRUD_Cliente.ShowDialog();
        }
    }
}
