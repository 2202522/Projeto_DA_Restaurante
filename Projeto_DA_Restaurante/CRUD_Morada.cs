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

        private void CRUD_Morada_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restGestDBDataSet.PessoaSet' table. You can move, or remove it, as needed.
            this.pessoaSetTableAdapter.Fill(this.restGestDBDataSet.PessoaSet);
        }

        private void btnSeguinte_Click(object sender, EventArgs e)
        {
            Morada morada = new Morada();
            morada.Cidade = cidadeTextBox.Text;
            morada.CodPostal = codPostalTextBox.Text;
            morada.Rua = ruaTextBox.Text;
            morada.Pais = paisTextBox.Text;
            morada.Pessoa.Id = Convert.ToInt32(nomeComboBox.SelectedValue);
            restauranteContext.MoradaSet.Add(morada);          
            restauranteContext.SaveChanges();

            this.Hide();
            Utilizadores utilizadores = new Utilizadores();
            utilizadores.ShowDialog();

        }

        private void nomeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pessoaSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restGestDBDataSet);

        }
    }
}
