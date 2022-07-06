using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA_Restaurante
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void btnConsultarVendidos_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarVendas_Click(object sender, EventArgs e)
        {

        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            SqlConnection sqlCon;
            string sqlQuery;

            string conString = ConfigurationManager.ConnectionStrings["RestauranteContainer"].ConnectionString;
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();

            sqlQuery = "SELECT TOP 10 COUNT(IM.Id) As 'Total',IM.Nome,PS.Nome FROM ItemMenuSet IM LEFT JOIN PedidoItemMenu PIM ON PIM.ItemMenu_Id = IM.Id LEFT JOIN PedidoSet P ON P.Id = PIM.Pedido_Id LEFT JOIN PessoaSet_Cliente C ON C.Id = P.ClienteId LEFT JOIN PessoaSet PS ON PS.Id = C.idpessoa GROUP BY IM.Nome,PS.Nome ORDER BY COUNT(IM.Id)";
            SqlDataAdapter dscmd = new SqlDataAdapter(sqlQuery, sqlCon);
            DataTable dtData = new DataTable();
            dscmd.Fill(dtData);
            dataGridPedidosClientes.DataSource = dtData;

            sqlQuery = "  SELECT *  FROM PagamentoSet WHERE[Data] >= DATEADD(day, -7, GETDATE()) AND[Data] <= GETDATE()";
            SqlDataAdapter dscmt = new SqlDataAdapter(sqlQuery, sqlCon);
            DataTable dtDataU = new DataTable();
            dscmt.Fill(dtDataU);
            dataGridultimos7dias.DataSource = dtDataU;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void voltarMainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.ShowDialog();
        }
    }
}
