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
    public partial class ManageVendors : Form
    {
        public ManageVendors()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Cyberland Computers\Documents\Inventorydb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void label8_Click(object sender, EventArgs e)
        {

        }

        void Populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from tblVendor";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                GridVendors.DataSource = ds.Tables[0];

                Con.Close();

            }
            catch
            {

            }
        }
        private void btnAddVen_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("AddVendor", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VenID", txtVenID.Text);
                cmd.Parameters.AddWithValue("@VenName", txtVenName.Text);
                cmd.Parameters.AddWithValue("@VenContact", txtVenContact.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Vendor Successfully Added");
                Con.Close();
                Populate();
            }
            catch
            {
 
            }
        }


        private void btnEditVen_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("UpdateVendor", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VenID", txtVenID.Text);
                cmd.Parameters.AddWithValue("@VenName", txtVenName.Text);
                cmd.Parameters.AddWithValue("@VenContact", txtVenContact.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Vendor Successfully Updated");
                Con.Close();
                Populate();
            }
            catch
            {

            }
        }


        private void btnDeleteVen_Click(object sender, EventArgs e)
        {
            if (txtVenID.Text == "")
            {
                MessageBox.Show("Enter Vendor ID");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("DeleteVendor", Con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VenID", txtVenID.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vendor Successfully Deleted");
                    Con.Close();
                    Populate();
                }
                catch
                {
  
                }
            }
        }


        private void btnClearVenRec_Click(object sender, EventArgs e)
        {
            txtVenID.Text = "";
            txtVenName.Text = "";
            txtVenContact.Text = "";
        }

        private void ManageVendors_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void GridVendors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridVendors.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = GridVendors.SelectedRows[0];
                txtVenID.Text = GridVendors.SelectedRows[0].Cells[0].Value.ToString();
                txtVenName.Text = GridVendors.SelectedRows[0].Cells[1].Value.ToString();
                txtVenContact.Text = GridVendors.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVenHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}
