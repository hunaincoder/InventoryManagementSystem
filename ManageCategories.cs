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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Cyberland Computers\Documents\Inventorydb.mdf"";Integrated Security=True;Connect Timeout=30");

        public object GridCustomer { get; private set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void Populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from tblCategory";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                GridCategories.DataSource = ds.Tables[0];

                Con.Close();

            }
            catch
            {

            }
        }
        private void btnAddCat_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("AddCategory", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CatID", txtCatID.Text);
                cmd.Parameters.AddWithValue("@CatName", txtCatName.Text);
                cmd.Parameters.AddWithValue("@SubCat", txtSubCat.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Added");
                Con.Close();
                Populate();
            }
            catch
            {

            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void GridCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridCategories.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = GridCategories.SelectedRows[0];
                txtCatID.Text = GridCategories.SelectedRows[0].Cells[0].Value.ToString();
                txtCatName.Text = GridCategories.SelectedRows[0].Cells[1].Value.ToString();
                txtSubCat.Text = GridCategories.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void btnEditCat_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("UpdateCategory", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CatID", txtCatID.Text);
                cmd.Parameters.AddWithValue("@CatName", txtCatName.Text);
                cmd.Parameters.AddWithValue("@SubCat", txtSubCat.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Updated");
                Con.Close();
                Populate();
            }
            catch
            {

            }
        }


        private void btnClearCatRec_Click(object sender, EventArgs e)
        {
            txtCatID.Text = "";
            txtCatName.Text = "";
            txtSubCat.Text = "";
        }

        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
            if (txtCatID.Text == "")
            {
                MessageBox.Show("Enter Category ID");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("DeleteCategory", Con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CatID", txtCatID.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Deleted");
                    Con.Close();
                    Populate();
                }
                catch
                {

                }
            }
        }


        private void txtCatID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCatHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}
