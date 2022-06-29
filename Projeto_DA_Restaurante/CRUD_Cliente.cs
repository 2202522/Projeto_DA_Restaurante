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
    public partial class CRUD_Cliente : Form
    {
        public CRUD_Cliente()
        {
            InitializeComponent();
        }

        private void pessoaSet_ClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaSet_ClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }

        private void CRUD_Cliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet3.PessoaSet_Cliente' table. You can move, or remove it, as needed.
            this.pessoaSet_ClienteTableAdapter.Fill(this.restauranteDataSet3.PessoaSet_Cliente);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utilizadores utilizadores = new Utilizadores();
            utilizadores.ShowDialog();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utilizadores utilizadores = new Utilizadores();
            utilizadores.ShowDialog();
        }
    }
}
