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
        RestauranteContext restauranteContext;
        List<Morada> moradas;
        public CRUD_Cliente()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }

        private void CRUD_Cliente_Load(object sender, EventArgs e)
        {
            ruaComboBox.DataSource = restauranteContext.MoradaSet.ToList();
            moradas = restauranteContext.MoradaSet.ToList();
            ruaComboBox.ValueMember = "Id";
            ruaComboBox.DisplayMember = "Rua";
        }

        private void buttonSeguinte_Click(object sender, EventArgs e)
        {
            //Morada morada = ruaComboBox.SelectedItem as Morada;
            Cliente cliente = new Cliente();
            cliente.Nome = textBoxnome.Text;
            cliente.Telemovel = int.Parse(textBoxtelemovel.Text);
            cliente.NumContribuiente = int.Parse(textBoxcontribuinte.Text);
            int index = ruaComboBox.SelectedIndex;
            cliente.Morada = moradas[index];
            restauranteContext.PessoaSet.Add(cliente);
            restauranteContext.SaveChanges();
            this.Hide();
            Utilizadores utilizadores = new Utilizadores();
            utilizadores.ShowDialog();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utilizadores utilizadores = new Utilizadores();
            utilizadores.ShowDialog();
        }

        private void btnBackM_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Morada cRUD_Morada = new CRUD_Morada();
            cRUD_Morada.ShowDialog();
        }
    }
}