using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ManageProducts prod=new ManageProducts();
            prod.Show();
            this.Hide();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
      
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            ManageBrand brand = new ManageBrand();
            brand.Show();
            this.Hide();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            ManageCategories cat = new ManageCategories();
            cat.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ManageUsers user = new ManageUsers();
            user.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ManageOrders order = new ManageOrders();
            order.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ManageCustomers cust = new ManageCustomers();
            cust.Show();
            this.Hide();
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            ManageVendors vend = new ManageVendors();
            vend.Show();
            this.Hide();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ManageEmployee emp = new ManageEmployee();
            emp.Show();
            this.Hide();
        }
    }
}
