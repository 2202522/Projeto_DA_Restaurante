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
        public CRUD_State()
        {
            InitializeComponent();
        }

        private void estadoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estadoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }

        private void CRUD_State_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet3.EstadoSet' table. You can move, or remove it, as needed.
            this.estadoSetTableAdapter.Fill(this.restauranteDataSet3.EstadoSet);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Status state = new Status();
            state.ShowDialog();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Status state = new Status();
            state.ShowDialog();
        }
    }
}
