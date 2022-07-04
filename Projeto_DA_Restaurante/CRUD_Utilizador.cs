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
    public partial class CRUD_Utilizador : Form
    {
        RestauranteContext restauranteContext;
        public CRUD_Utilizador()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }        

        private void CRUD_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void btnSeguinte_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = nomeTextBox.Text;
            pessoa.Telemovel = int.Parse(telemovelTextBox.Text);
            restauranteContext.PessoaSet.Add(pessoa);
            restauranteContext.SaveChanges();

            this.Hide();
            CRUD_Morada cRUD_Morada = new CRUD_Morada();
            cRUD_Morada.ShowDialog();
        }

        private void voltarbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utilizadores utilizadores = new Utilizadores();
            utilizadores.ShowDialog();
        }
    }
}
