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
    public partial class Status : Form
    {
        RestauranteContext restauranteContext;
        public Status()
        {
            InitializeComponent();
            restauranteContext = new RestauranteContext();
        }

        private void State_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = restauranteContext.EstadoSet.ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.ShowDialog();
        }

        private void CRUD_Estado_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_State cRUD_State = new CRUD_State();
            cRUD_State.ShowDialog();
        }
    }
}
