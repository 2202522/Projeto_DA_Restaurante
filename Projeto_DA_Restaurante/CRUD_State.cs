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
    public partial class CRUD_State : Form
    {
        RestauranteContext restauranteContext;
        public CRUD_State()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }

        private void CRUD_State_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Status state = new Status();
            state.ShowDialog();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado();
            estado.estado = estadoTextBox.Text;
            restauranteContext.EstadoSet.Add(estado);
            restauranteContext.SaveChanges();

            this.Hide();
            Status state = new Status();
            state.ShowDialog();
        }
    }
}
