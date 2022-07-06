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

        private void associarTrabalhadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Morada_Trabalhador associarTrabalhador = new CRUD_Morada_Trabalhador();
            associarTrabalhador.ShowDialog();
        }

        private void criarEditarTrabalhadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Morada_Trabalhador cRUD_Morada_Trabalhador = new CRUD_Morada_Trabalhador();
            cRUD_Morada_Trabalhador.ShowDialog();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Restaurant restaurant = new Restaurant();
            restaurant.ShowDialog();
        }
    }
}
