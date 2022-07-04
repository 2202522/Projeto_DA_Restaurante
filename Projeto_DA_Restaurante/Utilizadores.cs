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
            // TODO: This line of code loads data into the 'restGestDBDataSet1.PessoaSet' table. You can move, or remove it, as needed.
            this.pessoaSetTableAdapter1.Fill(this.restGestDBDataSet1.PessoaSet);

            // this.moradaSetTableAdapter.Fill(this.restauranteDataSet3.MoradaSet);

        }

        private void btnEditarClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Utilizador cRUD_Utilizador = new CRUD_Utilizador();
            cRUD_Utilizador.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.ShowDialog();
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
