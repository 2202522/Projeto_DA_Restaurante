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
        RestauranteContext restauranteContext;
        public Utilizadores()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }

       

        private void Utilizadores_Load(object sender, EventArgs e)
        {
            dataGridViewcliente.DataSource = restauranteContext.PessoaSet.ToList();

            dataGridViewmorada.DataSource = restauranteContext.MoradaSet.ToList();
            dataGridViewrestaurante.DataSource = restauranteContext.RestauranteSet.ToList();
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

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Morada cRUD_Morada = new CRUD_Morada();
            cRUD_Morada.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
