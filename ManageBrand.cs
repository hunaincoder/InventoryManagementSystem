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
    public partial class ManageBrand : Form
    {
        public ManageBrand()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Cyberland Computers\Documents\Inventorydb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("InsertBrand", Con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@BrandID", txtBrandID.Text);
                cmd.Parameters.AddWithValue("@BrandName", txtBrandName.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Brand Successfully Added");
                Con.Close();
                Populate();
            }
            catch
            {
   
            }
        }


        void Populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from tblBrand";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                GridBrands.DataSource = ds.Tables[0];

                Con.Close();

            }
            catch
            {

            }
        }

        private void ManageBrand_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void btnEditBrand_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("UpdateBrand", Con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@BrandID", txtBrandID.Text);
                cmd.Parameters.AddWithValue("@NewBrandID", txtBrandID.Text);
                cmd.Parameters.AddWithValue("@NewBrandName", txtBrandName.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Brand Successfully Updated");
                Con.Close();
                Populate();
            }
            catch
            {

            }
        }


        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            if (txtBrandID.Text == "")
            {
                MessageBox.Show("Enter Brand ID");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("DeleteBrand", Con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BrandID", txtBrandID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Brand Successfully Deleted");
                    Con.Close();
                    Populate();
                }
                catch
                {
     
                }
            }
        }


        private void btnClearBrandRec_Click(object sender, EventArgs e)
        {
            txtBrandID.Text = "";
            txtBrandName.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GridBrands_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridBrands.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = GridBrands.SelectedRows[0];
                txtBrandID.Text = GridBrands.SelectedRows[0].Cells[0].Value.ToString();
                txtBrandName.Text = GridBrands.SelectedRows[0].Cells[1].Value.ToString();           
            }
        }

        private void btnBrandHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}
