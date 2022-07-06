using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;



namespace Projeto_DA_Restaurante
{
    public partial class CRUD_Morada : Form
    {
        RestauranteContext restauranteContext;

        public CRUD_Morada()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }

        private void CRUD_Morada_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utilizadores utilizadores = new Utilizadores();
            utilizadores.ShowDialog(); 
        }

        private void buttonSeguinte_Click_1(object sender, EventArgs e)
        {

            Morada morada = new Morada();
            morada.Cidade = textBoxcidade.Text;
            morada.CodPostal = int.Parse(textBoxcodpostal.Text);
            morada.Rua = textBoxrua.Text;
            morada.Pais = textBoxpais.Text;
            restauranteContext.MoradaSet.Add(morada);
            restauranteContext.SaveChanges();

            this.Hide();
            CRUD_Cliente cRUD_Cliente = new CRUD_Cliente();
            cRUD_Cliente.ShowDialog();
        }
    }
}
