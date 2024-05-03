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
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Cyberland Computers\Documents\Inventorydb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void Populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from tblCustomer";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                GridCustomer.DataSource = ds.Tables[0];

                Con.Close();

            }
            catch
            {

            }
        }
        private void txtUserFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("AddCustomer", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustID", txtCustID.Text);
                cmd.Parameters.AddWithValue("@CustName", txtCustName.Text);
                cmd.Parameters.AddWithValue("@CustPhone", txtCustPhone.Text);
                cmd.Parameters.AddWithValue("@CustAddress", txtCustAddress.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Added");
                Con.Close();
                Populate();
            }
            catch
            {
         
            }
        }


        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustID.Text == "")
            {
                MessageBox.Show("Enter Customer ID");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("DeleteCustomer", Con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustID", txtCustID.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Deleted");
                    Con.Close();
                    Populate();
                }
                catch
                {
 
                }
            }
        }


        private void GridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = GridCustomer.SelectedRows[0];
                txtCustID.Text = GridCustomer.SelectedRows[0].Cells[0].Value.ToString();
                txtCustName.Text = GridCustomer.SelectedRows[0].Cells[1].Value.ToString();
                txtCustPhone.Text = GridCustomer.SelectedRows[0].Cells[2].Value.ToString();
                txtCustAddress.Text = GridCustomer.SelectedRows[0].Cells[3].Value.ToString();
                Con.Open();
                SqlDataAdapter sda=new SqlDataAdapter("select Count(*) from tblOrder where CustID="+txtCustID.Text+"",Con);
                DataTable dt=new DataTable();
                sda.Fill(dt);
                lblOrder.Text = dt.Rows[0][0].ToString();

                SqlDataAdapter sda1 = new SqlDataAdapter("select Sum(totalAmount) from tblOrder where CustID=" + txtCustID.Text + "", Con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                lblAmount.Text = dt1.Rows[0][0].ToString();
                Con.Close();

                SqlDataAdapter sda2 = new SqlDataAdapter("select Max(OrderDate) from tblOrder where CustID=" + txtCustID.Text + "", Con);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                lblDate.Text = dt2.Rows[0][0].ToString();
                Con.Close();
            }
        }

        private void btnClearCustRec_Click(object sender, EventArgs e)
        {
            txtCustID.Text = "";
            txtCustName.Text = "";
            txtCustPhone.Text = "";
            txtCustAddress.Text = "";
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("UpdateCustomer", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustID", txtCustID.Text);
                cmd.Parameters.AddWithValue("@CustName", txtCustName.Text);
                cmd.Parameters.AddWithValue("@CustPhone", txtCustPhone.Text);
                cmd.Parameters.AddWithValue("@CustAddress", txtCustAddress.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Updated");
                Con.Close();
                Populate();
            }
            catch
            {

            }
        }


        private void btnCustHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}
