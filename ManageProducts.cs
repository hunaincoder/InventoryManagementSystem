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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Cyberland Computers\Documents\Inventorydb.mdf"";Integrated Security=True;Connect Timeout=30");

        void FillcomboSearch()
        {
            try
            {
                Con.Open();

                string categoryName = comboSearch.SelectedValue.ToString();

                using (SqlCommand command = new SqlCommand("SearchProductsByCategory", Con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CategoryName", categoryName);

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    GridProduct.DataSource = ds.Tables[0];
                }

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filling the combo search: " + ex.Message);
            }
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
                    comboSearch.ValueMember = "CatName";
                    comboSearch.DataSource = dt;
                }

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filling the category: " + ex.Message);
            }
        }


        void FillBrand()
        {
            try
            {
                Con.Open();

                using (SqlCommand command = new SqlCommand("GetBrands", Con))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    dt.Columns.Add("BrandName", typeof(string));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }

                    comboBrand.ValueMember = "BrandName";
                    comboBrand.DataSource = dt;
                }

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filling the brand: " + ex.Message);
            }
        }


        void FillVendor()
        {
            try
            {
                Con.Open();

                using (SqlCommand command = new SqlCommand("GetVendors", Con))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    dt.Columns.Add("VenName", typeof(string));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }

                    comboVendor.ValueMember = "VenName";
                    comboVendor.DataSource = dt;
                }

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filling the vendor: " + ex.Message);
            }
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            try
            {
                string categoryName = comboCat.Text;
                string brandName = comboBrand.Text;
                string vendorName = comboVendor.Text;
                int categoryId = GetCategoryId(categoryName);
                int brandId = GetBrandId(brandName);
                int vendorId = GetVendorId(vendorName);
                int prodId = int.Parse(txtProdID.Text); 
                int productId = InsertProduct(prodId, txtProdName.Text, txtProdQty.Text, txtProdPrice.Text);
                InsertProductBrand(prodId, brandId, categoryId,vendorId);
                MessageBox.Show("Product successfully added.");
                PopulateGrid();
                ClearProductForm();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private int GetCategoryId(string categoryName)
        {
            int categoryId = 0;

            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Cyberland Computers\Documents\Inventorydb.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                using (SqlCommand command = new SqlCommand("SELECT dbo.GetCategoryId(@CategoryName)", connection))
                {
                    command.Parameters.AddWithValue("@CategoryName", categoryName);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            categoryId = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while retrieving the CategoryID: " + ex.Message);
                    }
                }
            }

            return categoryId;
        }



        private int GetBrandId(string brandName)
        {
            int brandId = 0;

            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Cyberland Computers\Documents\Inventorydb.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                using (SqlCommand command = new SqlCommand("SELECT dbo.GetBrandId(@BrandName)", connection))
                {
                    command.Parameters.AddWithValue("@BrandName", brandName);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            brandId = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while retrieving the BrandID: " + ex.Message);
                    }
                }
            }

            return brandId;
        }


        private int GetVendorId(string vendorName)
        {
            int vendorId = 0;

            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Cyberland Computers\Documents\Inventorydb.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                using (SqlCommand command = new SqlCommand("SELECT dbo.GetVendorId(@VendorName)", connection))
                {
                    command.Parameters.AddWithValue("@VendorName", vendorName);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            vendorId = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while retrieving the VendorID: " + ex.Message);
                    }
                }
            }

            return vendorId;
        }

        private int InsertProduct(int productID, string productName, string productQuantity, string productPrice)
        {
            int insertedProductID = 0;

            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Cyberland Computers\Documents\Inventorydb.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                using (SqlCommand command = new SqlCommand("InsertProduct", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ProductID", productID);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@ProductQuantity", productQuantity);
                    command.Parameters.AddWithValue("@ProductPrice", productPrice);
                    command.Parameters.Add("@InsertedProductID", SqlDbType.Int).Direction = ParameterDirection.Output;

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        insertedProductID = Convert.ToInt32(command.Parameters["@InsertedProductID"].Value);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while inserting the product: " + ex.Message);
                    }
                }
            }

            return insertedProductID;
        }


        private void InsertProductBrand(int productId, int brandId, int categoryId, int vendorId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("InsertProductBrand", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ProductID", productId);
                        command.Parameters.AddWithValue("@BrandID", brandId);
                        command.Parameters.AddWithValue("@CategoryID", categoryId);
                        command.Parameters.AddWithValue("@VendorID", vendorId);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting in the prod_brand_cat_ven Table: " + ex.Message);
            }
        }



        private void ClearProductForm()
        {
            txtProdID.Text = "";
            txtProdName.Text = string.Empty;
            txtProdQty.Text = string.Empty;
            txtProdPrice.Text = string.Empty;
            comboCat.SelectedIndex = -1;
            comboBrand.SelectedIndex = -1;
            comboVendor.SelectedIndex = -1;
        }

        private void PopulateGrid()
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

                Con.Close();
            }
            catch
            {

            }
        }


        private void ManageProducts_Load(object sender, EventArgs e)
        {
            PopulateGrid();
            FillCategory();
            FillBrand();
            FillVendor();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = GridProduct.SelectedRows[0];
                txtProdID.Text = GridProduct.SelectedRows[0].Cells[0].Value.ToString();
                txtProdName.Text = GridProduct.SelectedRows[0].Cells[1].Value.ToString();
                txtProdQty.Text = GridProduct.SelectedRows[0].Cells[2].Value.ToString();
                txtProdPrice.Text = GridProduct.SelectedRows[0].Cells[3].Value.ToString();
                comboBrand.Text = GridProduct.SelectedRows[0].Cells[4].Value.ToString();
                comboCat.Text = GridProduct.SelectedRows[0].Cells[5].Value.ToString();
                comboVendor.Text = GridProduct.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void btnClearProdRec_Click(object sender, EventArgs e)
        {
            txtProdID.Text = "";
            txtProdName.Text = "";
            txtProdQty.Text = "";
            txtProdPrice.Text = "";
            comboCat.Text = "";
            comboBrand.Text = "";
            comboVendor.Text = "";
        }

        private int UpdateProduct(int productId, string productName, string productQuantity, string productPrice)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("UpdateProduct", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ProdID", productId);
                        command.Parameters.AddWithValue("@ProdName", productName);
                        command.Parameters.AddWithValue("@ProdQty", productQuantity);
                        command.Parameters.AddWithValue("@ProdPrice", productPrice);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product updated successfully.");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the product: " + ex.Message);
            }
            return productId;
        }


        private void UpdateProductBrand(int productId, int brandId, int categoryId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("UpdateProductBrand", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ProdID", productId);
                        command.Parameters.AddWithValue("@BrandID", brandId);
                        command.Parameters.AddWithValue("@CategoryID", categoryId);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product brand and category updated successfully.");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the product brand and category: " + ex.Message);
            }
        }



        private void btnEditProd_Click(object sender, EventArgs e)
        {
            try
            {
                string categoryName = comboCat.Text;
                string brandName = comboBrand.Text;
                int categoryId = GetCategoryId(categoryName);
                int brandId = GetBrandId(brandName);
                int prodId = int.Parse(txtProdID.Text);
                int productId = UpdateProduct(prodId, txtProdName.Text, txtProdQty.Text, txtProdPrice.Text);
                UpdateProductBrand(prodId, brandId, categoryId);
                ClearProductForm();
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DeleteProduct(int productId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("DeleteProduct", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ProdID", productId);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Product deleted successfully.");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the product: " + ex.Message);
            }
        }


        private void btnDeleteProd_Click(object sender, EventArgs e)
        {
            int productId;
            if (int.TryParse(txtProdID.Text, out productId)&& GridProduct.SelectedRows.Count > 0)
            {
                DeleteProduct(productId);
            }
            else
            {
                MessageBox.Show("Invalid product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillcomboSearch();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProdHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}
