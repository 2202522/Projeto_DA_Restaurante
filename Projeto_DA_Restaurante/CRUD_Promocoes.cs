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
    public partial class CRUD_Promocoes : Form
    {
        RestauranteContext restauranteContext;
        public CRUD_Promocoes()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Promocoes promocoes = new Promocoes();
            promocoes.ShowDialog();
        }

        private void CRUD_Promocoes_Load(object sender, EventArgs e)
        {

        }

        private void concluirbutton_Click(object sender, EventArgs e)
        {
            Promocao promocao = new Promocao();
            promocao.PercentagemPromocao= Convert.ToDouble(percentagemPromocaoTextBox.Text);
            promocao.Referencia= referenciaTextBox.Text;

            restauranteContext.Promocaos.Add(promocao);
            restauranteContext.SaveChanges();

            this.Hide();
            Promocoes promocoes = new Promocoes();
            promocoes.ShowDialog();
        }
    }
}
