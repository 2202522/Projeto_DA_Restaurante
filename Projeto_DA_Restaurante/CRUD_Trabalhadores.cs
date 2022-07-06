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
        RestauranteContext restauranteContext;
        List<Morada> moradas;
        List<Restaurante> restaurantes;
        public CRUD_Trabalhadores()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }



        private void CRUD_Trabalhadores_Load(object sender, EventArgs e)
        {
            ComboBoxrua.DataSource = restauranteContext.MoradaSet.ToList();
            moradas = restauranteContext.MoradaSet.ToList();
            ComboBoxrua.ValueMember = "Id";
            ComboBoxrua.DisplayMember = "Rua";

            comboBoxrestaurante.DataSource = restauranteContext.RestauranteSet.ToList();
            restaurantes = restauranteContext.RestauranteSet.ToList();
            comboBoxrestaurante.ValueMember = "Id";
            comboBoxrestaurante.DisplayMember = "Nome";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trabalhadores trabalhadores = new Trabalhadores();
            trabalhadores.ShowDialog();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
 
            Trabalhador trabalhador = new Trabalhador();
            trabalhador.Nome = textBoxnome.Text;
            trabalhador.Telemovel = int.Parse(textBoxtelemovel.Text);
            trabalhador.Salario = Double.Parse(textBoxsalario.Text);
            trabalhador.Posicao = textBoxposicao.Text;
            int index = ComboBoxrua.SelectedIndex;
            trabalhador.Morada = moradas[index];
            int indexR = comboBoxrestaurante.SelectedIndex;
            trabalhador.Restaurante = restaurantes[indexR];
            restauranteContext.PessoaSet.Add(trabalhador);
            restauranteContext.SaveChanges();

            this.Hide();
            Trabalhadores trabalhadores = new Trabalhadores();
            trabalhadores.ShowDialog();
        }
    }
}
