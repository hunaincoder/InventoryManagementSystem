using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagement
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Cyberland Computers\Documents\Inventorydb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void lable1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void Populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from tblUser";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder=new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                GridUser.DataSource= ds.Tables[0];

                Con.Close();

            }
            catch
            {

            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
{
    try
    {
        Con.Open();
        SqlCommand cmd = new SqlCommand("InsertUser", Con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@UserID", txtUserID.Text);
        cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
        cmd.Parameters.AddWithValue("@UserFName", txtUserFName.Text);
        cmd.Parameters.AddWithValue("@UserPass", txtUserPass.Text);
        cmd.Parameters.AddWithValue("@UserPhone", txtUserPhone.Text);

        cmd.ExecuteNonQuery();
        MessageBox.Show("User Successfully Added");
        Con.Close();
        Populate();
            
     }
    catch
    {
        // Handle any exceptions here
    }
}


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnUserHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridUser.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = GridUser.SelectedRows[0];
                txtUserID.Text = GridUser.SelectedRows[0].Cells[0].Value.ToString();
                txtUserName.Text = GridUser.SelectedRows[0].Cells[1].Value.ToString();
                txtUserFName.Text = GridUser.SelectedRows[0].Cells[2].Value.ToString();
                txtUserPass.Text = GridUser.SelectedRows[0].Cells[3].Value.ToString();
                txtUserPhone.Text = GridUser.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                e.CellStyle.ForeColor = Color.Black; 
            }
        }


        private void ManageUsers_Load(object sender, EventArgs e)
        {

            Populate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text =="") {
                MessageBox.Show("Enter User ID");
            }
            else
            {
                Con.Open();
                using (SqlCommand cmd = new SqlCommand("DeleteUser", Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", txtUserID.Text);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("User Successfully Deleted");
                Con.Close();
                Populate();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserID.Text = "";
            txtUserName.Text = "";
            txtUserFName.Text = "";
            txtUserPass.Text = "";
            txtUserPhone.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UpdateUser", Con))
                {
                    Con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", txtUserID.Text);
                    cmd.Parameters.AddWithValue("@Uname", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@Ufullname", txtUserFName.Text);
                    cmd.Parameters.AddWithValue("@Upassword", txtUserPass.Text);
                    cmd.Parameters.AddWithValue("@Uphone", txtUserPhone.Text);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("user Successfully Updated");
                Con.Close();
                Populate();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
