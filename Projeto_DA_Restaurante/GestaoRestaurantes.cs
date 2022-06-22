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
    public partial class GestaoRestaurantes : Form
    {
        public GestaoRestaurantes()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage=new MainPage();
            mainPage.ShowDialog();
        }

        private void GestaoRestaurantes_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnCriarRestaurante_Click(object sender, EventArgs e)
        {
            CriarRestaurante criarRestaurante = new CriarRestaurante();
            criarRestaurante.ShowDialog();
        }
    }
}
