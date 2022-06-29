using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA_Restaurante
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void pedidoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet3);

        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
          
            // TODO: This line of code loads data into the 'restauranteDataSet3.PedidoSet' table. You can move, or remove it, as needed.
            this.pedidoSetTableAdapter.Fill(this.restauranteDataSet3.PedidoSet);

            //SqlConnection sqlCon;
            //string conString;
            //string sqlQuery;

            //conString = "Projeto_DA_Restaurante.Properties.Settings.RestauranteConnectionString";
            //sqlCon = new SqlConnection(conString);
            //sqlCon.Open();
            //sqlQuery = "SELECT * FROM PedidoSet";
            //SqlDataAdapter dscmd = new SqlDataAdapter(sqlQuery, sqlCon);
            //DataTable dtData = new DataTable();
            //dscmd.Fill(dtData);
            //pedidoSetDataGridView.DataSource = dtData;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.ShowDialog();
        }

        private void CRUD_Pedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Pedido cRUD_Pedido = new CRUD_Pedido();
            cRUD_Pedido.ShowDialog();
        }

        private void Exportar_Click(object sender, EventArgs e)
        {
            if (pedidoSetDataGridView.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "ListaPedidos.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                { 
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Não foi possivel guardar os dados" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(pedidoSetDataGridView.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in pedidoSetDataGridView.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in pedidoSetDataGridView.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Exportado com sucesso", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Sem dados para exportar", "Info");
            }
        }
    }
}
