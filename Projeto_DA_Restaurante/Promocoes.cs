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
    public partial class Promocoes : Form
    {
        RestauranteContext restauranteContext;
        public Promocoes()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }

        private void Promocoes_Load(object sender, EventArgs e)
        {

            dataGridViewPromocoes.DataSource = restauranteContext.Promocaos.ToList();
        }

        private void criarCodigosDePromoçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Promocoes cRUD_Promocoes = new CRUD_Promocoes();
            cRUD_Promocoes.ShowDialog();
        }

        private void voltarMainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.ShowDialog();
        }
    }
}
