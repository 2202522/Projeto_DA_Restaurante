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
        RestauranteContext restauranteContext;
        public Trabalhadores()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }

        private void Trabalhadores_Load(object sender, EventArgs e)
        {
            dataGridViewTrabalhadores.DataSource = restauranteContext.PessoaSet.ToList();
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
            CRUD_Morada_Trabalhador associarTrabalhador = new CRUD_Morada_Trabalhador();
            associarTrabalhador.ShowDialog();
        }

        private void btn_CRUD_Trabalhadores_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Morada_Trabalhador cRUD_Morada_Trabalhador = new CRUD_Morada_Trabalhador();
            cRUD_Morada_Trabalhador.ShowDialog();
        }
    }
}
