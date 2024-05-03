using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Cyberland Computers\Documents\Inventorydb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PopulateOrders()
        {
            try
            {
                Con.Open();
                String Myquery = "SELECT * FROM [dbo].[vwOrders]";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridViewOrder.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }


        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            PopulateOrders();
        }
        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();

        private void gridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (Font font = new Font("Century", 25, FontStyle.Bold))
            {
                using (Brush brush = Brushes.Red)
                {
                    string text = "Order Summary";
                    SizeF textSize = e.Graphics.MeasureString(text, font);
                    float centerX = (e.PageBounds.Width - textSize.Width) / 2;
                    float topY = 50;
                    PointF location = new PointF(centerX, topY);
                    e.Graphics.DrawString(text, font, brush, location);

                    Font font2 = new Font("Century", 20, FontStyle.Regular);
                    string text2 = "Order ID: " + gridViewOrder.SelectedRows[0].Cells[0].Value.ToString();
                    PointF location2 = new PointF(80, 120);
                    e.Graphics.DrawString(text2, font2, brush, location2);

                    Font font3 = new Font("Century", 20, FontStyle.Regular);
                    string text3 = "Customer ID: " + gridViewOrder.SelectedRows[0].Cells[1].Value.ToString();
                    PointF location3 = new PointF(80, 150); 
                    e.Graphics.DrawString(text3, font3, brush, location3);

                    Font font4 = new Font("Century", 20, FontStyle.Regular);
                    string text4 = "Customer Name: " + gridViewOrder.SelectedRows[0].Cells[2].Value.ToString();
                    PointF location4 = new PointF(80, 180); 
                    e.Graphics.DrawString(text4, font4, brush, location4);

                    Font font5 = new Font("Century", 20, FontStyle.Regular);
                    string text5 = "Order Date: " + gridViewOrder.SelectedRows[0].Cells[3].Value.ToString();
                    PointF location5 = new PointF(80, 210);
                    e.Graphics.DrawString(text5, font5, brush, location5);

                    Font font6 = new Font("Century", 20, FontStyle.Regular);
                    string text6 = "Total Amount: " + gridViewOrder.SelectedRows[0].Cells[4].Value.ToString();
                    PointF location6 = new PointF(80, 240);
                    e.Graphics.DrawString(text6, font6, brush, location6);
                }
            }
            e.HasMorePages = false;
        }
    }
}
