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
        public Status()
        {
            InitializeComponent();
        }

        private void estadoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estadoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }

        private void State_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restGestDBDataSet.EstadoSet' table. You can move, or remove it, as needed.
            this.estadoSetTableAdapter1.Fill(this.restGestDBDataSet.EstadoSet);
            // TODO: This line of code loads data into the 'restauranteDataSet3.EstadoSet' table. You can move, or remove it, as needed.
            this.estadoSetTableAdapter.Fill(this.restauranteDataSet3.EstadoSet);
            // TODO: This line of code loads data into the 'restauranteDataSet3.EstadoSet' table. You can move, or remove it, as needed.
            this.estadoSetTableAdapter.Fill(this.restauranteDataSet3.EstadoSet);

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

        private void estadoSetBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void estadoSetBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {

        }

        private void estadoSetBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.estadoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }
    }
}
