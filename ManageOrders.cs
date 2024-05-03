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
    public partial class ManageOrders : Form
    {
        private DataTable table = new DataTable();
        private DataRow selectedProduct;
        int flag = 0;
        private int sum = 0;
        public ManageOrders()
        {
            InitializeComponent();
            GridProduct.SelectionChanged += GridProduct_SelectionChanged;
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Qty", typeof(int));
            table.Columns.Add("UnitPrice", typeof(decimal));
            table.Columns.Add("TotalPrice", typeof(decimal));

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Cyberland Computers\Documents\Inventorydb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void GridCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustID.Text = GridCustomers.SelectedRows[0].Cells[0].Value.ToString();
            txtCustName.Text = GridCustomers.SelectedRows[0].Cells[1].Value.ToString();
        }


        void FillCategory()
        {
            try
            {
                Con.Open();

                using (SqlCommand command = new SqlCommand("GetCategories", Con))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    dt.Columns.Add("CatName", typeof(string));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }

                    comboCat.ValueMember = "CatName";
                    comboCat.DataSource = dt;
                }

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filling the category: " + ex.Message);
            }
        }

        private void PopulateCustomers()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from tblCustomer";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                GridCustomers.DataSource = ds.Tables[0];
                GridCustomers.Columns[0].Width = 40;
                GridCustomers.Columns[2].Width = 70;

                Con.Close();

            }
            catch
            {

            }
        }

        private void PopulateProducts()
        {
            try
            {
                Con.Open();

                String Myquery = "SELECT * FROM vw_ProductDetails";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                GridProduct.DataSource = ds.Tables[0];
                GridProduct.Columns[0].Width = 40;
                GridProduct.Columns[2].Width = 50;
                GridProduct.Columns[3].Width = 50;
                GridProduct.Columns[4].Width = 80;

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while populating the products: " + ex.Message);
            }
        }

        int num = 0;
        int uprice, totalprice, qty;
        string product;
        
        private void ManageOrders_Load(object sender, EventArgs e)
        {
            PopulateCustomers();
            PopulateProducts();
            FillCategory();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        
        private void GridProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (GridProduct.SelectedRows.Count > 0)
            {
                selectedProduct = ((DataRowView)GridProduct.SelectedRows[0].DataBoundItem).Row;
                stock = Convert.ToInt32(GridProduct.CurrentRow.Cells["ProdQty"].Value);
                product = GridProduct.CurrentRow.Cells["ProdName"].Value.ToString();
                uprice = Convert.ToInt32(GridProduct.CurrentRow.Cells["ProdPrice"].Value);
                flag = 1;
            }
        }
        int stock;
        private void GridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product = GridProduct.SelectedRows[0].Cells[1].Value.ToString();
            stock = Convert.ToInt32(GridProduct.SelectedRows[0].Cells[2].Value.ToString());
            uprice = Convert.ToInt32(GridProduct.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;
        }
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            
            if (txtQty.Text == "")
            {
                MessageBox.Show("Enter Quantity of the Product");
            }
            else if(flag == 0){
                MessageBox.Show("Select the Product");
            }
            else if (Convert.ToInt32(txtQty.Text)>stock)
            {
                MessageBox.Show("Not Enough Stock Available");
            }
            else
            {
                num = num + 1;
                qty = Convert.ToInt32(txtQty.Text);
                totalprice = qty * uprice;
                table.Rows.Add(num, product, qty, uprice, totalprice);
                gridOrder.DataSource=table;
                flag = 0;
                UpdateProductStock();
            }
            sum = sum + totalprice;
            lblRs.Text="Rs "+sum.ToString();
        }

        private void btnInsertOrder_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text==""||txtCustID.Text==""||txtCustName.Text==""||lblRs.Text=="")
            {
                MessageBox.Show("Fill all the data fields properly");
            }
            else if (gridOrder.Rows.Count == 0) 
            {
                MessageBox.Show("Add products to the order before inserting");
            }
            else
            {
                Con.Open();
                decimal totalAmount = decimal.Parse(lblRs.Text.Replace("Rs ", ""));
                SqlCommand cmd = new SqlCommand("INSERT INTO tblOrder VALUES (" + txtOrderID.Text + ", " + txtCustID.Text + ", '" + datePicker.Text + "', " + totalAmount + ")", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully");
                Con.Close();
            }
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            ViewOrders view=new ViewOrders();
            view.Show();    
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        void UpdateProductStock()
        {
            Con.Open();
            int newQty = stock - Convert.ToInt32(txtQty.Text);
            int id= Convert.ToInt32(GridProduct.SelectedRows[0].Cells[0].Value.ToString());
            string query = "Update tblProduct set ProdQty=" + newQty + " where ProdId=" + id + ";";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            PopulateProducts();
        }

        private void comboCat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("GetProductsByCategory", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoryName", comboCat.SelectedValue.ToString());

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                GridProduct.DataSource = ds.Tables[0];

                Con.Close();
            }
            catch
            {
               
            }
        }

    }
}
