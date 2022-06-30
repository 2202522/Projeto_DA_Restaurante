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
    public partial class Associar_Menu_Restaurante : Form
    {
        public Associar_Menu_Restaurante()
        {
            InitializeComponent();
        }

        private void Associar_Menu_Restaurante_Load(object sender, EventArgs e)
        {            
            // TODO: This line of code loads data into the 'restauranteDataSet3.ItemMenuSet' table. You can move, or remove it, as needed.
            this.itemMenuSetTableAdapter.Fill(this.restauranteDataSet3.ItemMenuSet);
            // TODO: This line of code loads data into the 'restauranteDataSet3.RestauranteItemMenu' table. You can move, or remove it, as needed.
            this.restauranteItemMenuTableAdapter.Fill(this.restauranteDataSet3.RestauranteItemMenu);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void restauranteItemMenuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.restauranteItemMenuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);
        }
    }
}
