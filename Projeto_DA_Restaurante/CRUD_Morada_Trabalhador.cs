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
    public partial class CRUD_Morada_Trabalhador : Form
    {

        RestauranteContext restauranteContext;
        public CRUD_Morada_Trabalhador()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trabalhadores trabalhadores = new Trabalhadores();
            trabalhadores.ShowDialog();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
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

        private void AssociarTrabalhador_Load(object sender, EventArgs e)
        {

        }

        private void buttonSeguinte_Click(object sender, EventArgs e)
        {

            Morada morada = new Morada();
            morada.Cidade = textBoxcidade.Text;
            morada.CodPostal = int.Parse(textBoxcodpostal.Text);
            morada.Rua = textBoxrua.Text;
            morada.Pais = textBoxpais.Text;
            restauranteContext.MoradaSet.Add(morada);
            restauranteContext.SaveChanges();

            this.Hide();
            CRUD_Trabalhadores cRUD_Trabalhadores = new CRUD_Trabalhadores();
            cRUD_Trabalhadores.ShowDialog();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trabalhadores trabalhadores = new Trabalhadores();
            trabalhadores.ShowDialog();
        }
    }
}
