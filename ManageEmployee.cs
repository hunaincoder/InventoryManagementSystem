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
    public partial class ManageEmployee : Form
    {
        public ManageEmployee()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Cyberland Computers\Documents\Inventorydb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PopulateGrid()
        {
            try
            {
                Con.Open();
                string query = "SELECT * FROM vwEmployeeDetails";  // Use the view instead of the original query
                SqlDataAdapter da = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                GridEmployee.DataSource = ds.Tables[0];

                Con.Close();
            }
            catch
            {
                // Handle exceptions
            }
        }

        void FillAssignedBy()
        {
            string query = "select distinct e.EmpName from tblEmployee e,tblAccess,tblEmp_Access Ea,tblEmp_User Eu,tblUser u where e.EmpId=Eu.EmpId and u.UserId=Eu.UserID and e.EmpId=Ea.EmpId and ea.AccLvl>=3 ";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("EmpName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboAssignedBy.ValueMember = "EmpName";
                comboAssignedBy.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
        void FillAccessLvl()
        {
            string query = "select * from tblAccess where AccLvl<=3";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("AccLvl", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboAccLvl.ValueMember = "AccLvl";
                comboAccLvl.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
        void FillUser()
        {
            string query = "select * from tblUser";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("UserID", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboUserID.ValueMember = "UserID";
                comboUserID.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            try
            {
                string userID = comboUserID.Text;
                string accLvl = comboAccLvl.Text;
                string assignedBy = comboAssignedBy.Text;
                int userId = int.Parse(userID);
                int acclvl = int.Parse(accLvl); 
                int empId = int.Parse(txtEmpID.Text);
                int emplpoyeeId = InsertEmployee(empId, txtEmpName.Text, txtEmpDesig.Text, txtEmpSched.Text);
                InsertEmpAccess(empId, acclvl);
                InsertEmpUser(empId,userId,dateAssigned.Text,comboAssignedBy.Text);
                PopulateGrid();
                ClearProductForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ClearProductForm()
        {
            txtEmpID.Text = "";
            txtEmpName.Text = string.Empty;
            txtEmpDesig.Text = string.Empty;
            txtEmpSched.Text = string.Empty;
            comboUserID.SelectedIndex = -1;
            comboAccLvl.SelectedIndex = -1;
            comboAssignedBy.SelectedIndex = -1;
            dateAssigned.Text = string.Empty;
        }
        private int InsertEmployee(int employeeID, string employeeName, string employeeDesignation, string employeeSchedule)
        {

            {
                string query = "INSERT INTO tblEmployee (EmpID,EmpName, EmpDesig, EmpSched) VALUES (@EmpID,@EmpName, @EmpDesig, @EmpSched); SELECT SCOPE_IDENTITY();";
                SqlCommand command = new SqlCommand(query, Con);

                command.Parameters.AddWithValue("@EmpID", employeeID);
                command.Parameters.AddWithValue("@EmpName", employeeName);
                command.Parameters.AddWithValue("@EmpDesig", employeeDesignation);
                command.Parameters.AddWithValue("@EmpSched", employeeSchedule);

                try
                {
                    Con.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        employeeID = Convert.ToInt32(result);
                        Con.Close();
                        MessageBox.Show("Employee Added Successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while inserting the Employee: " + ex.Message);
                }
            }
            return employeeID;
        }

        private void InsertEmpAccess(int employeeId, int accessLvl)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Cyberland Computers\Documents\Inventorydb.mdf"";Integrated Security=True;Connect Timeout=30"))
                {
                    string query = "INSERT INTO tblEmp_Access (EmpID, AccLvl) VALUES (@EmpID, @AccLvl);";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmpID", employeeId);
                        command.Parameters.AddWithValue("@AccLvl", accessLvl);
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Employee Access Details Added Successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting in the Emp_Access Table: " + ex.Message);
            }
        }

        private void InsertEmpUser(int employeeId, int userId, string dateAssigned, string assignedBy)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Cyberland Computers\Documents\Inventorydb.mdf"";Integrated Security=True;Connect Timeout=30"))
                {
                    string query = "INSERT INTO tblEmp_User (EmpID, UserID, AssignedDate, AssignedBy) VALUES (@EmpID, @UserID, @AssignedDate, @AssignedBy);";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmpID", employeeId);
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@AssignedDate", dateAssigned);
                        command.Parameters.AddWithValue("@AssignedBy", assignedBy);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Employee User Details Added Successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting in the Emp_User Table: " + ex.Message);
            }
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            PopulateGrid();
            FillUser();
            FillAccessLvl();
            FillAssignedBy();
        }

        private void GridEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = GridEmployee.SelectedRows[0];
                txtEmpID.Text = GridEmployee.SelectedRows[0].Cells[0].Value.ToString();
                txtEmpName.Text = GridEmployee.SelectedRows[0].Cells[1].Value.ToString();
                txtEmpDesig.Text = GridEmployee.SelectedRows[0].Cells[2].Value.ToString();
                txtEmpSched.Text = GridEmployee.SelectedRows[0].Cells[3].Value.ToString();
                comboUserID.Text = GridEmployee.SelectedRows[0].Cells[6].Value.ToString();
                comboAccLvl.Text = GridEmployee.SelectedRows[0].Cells[5].Value.ToString();
                dateAssigned.Text = GridEmployee.SelectedRows[0].Cells[7].Value.ToString();
                comboAssignedBy.Text = GridEmployee.SelectedRows[0].Cells[8].Value.ToString();
            }
        }

        private void UpdateEmpUser(int employeeId, int userId, string dateAssigned, string assignedBy)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Cyberland Computers\Documents\Inventorydb.mdf"";Integrated Security=True;Connect Timeout=30"))
                {
                    string query = "Update tblEmp_User set EmpID=@EmpID, UserID=@UserID, AssignedDate=@AssignedDate, AssignedBy=@AssignedBy;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmpID", employeeId);
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@AssignedDate", dateAssigned);
                        command.Parameters.AddWithValue("@AssignedBy", assignedBy);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Employee User Details Updated Successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting in the Emp_User Table: " + ex.Message);
            }
        }
        private void UpdateEmpAccess(int employeeId, int accessLvl)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Cyberland Computers\Documents\Inventorydb.mdf"";Integrated Security=True;Connect Timeout=30"))
                {
                    string query = "Update tblEmp_Access set EmpID=@EmpID, AccLvl=@AccLvl where EmpID=@EmpID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmpID", employeeId);
                        command.Parameters.AddWithValue("@AccLvl", accessLvl);
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Employee Access Details Added Successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting in the Emp_Access Table: " + ex.Message);
            }
        }
        private int UpdateEmployee(int employeeID, string employeeName, string employeeDesignation, string employeeSchedule)
        {

            {
                string query = "Update tblEmployee set EmpID=@EmpID,EmpName=@EmpName, EmpDesig=@EmpDesig, EmpSched=@EmpSched where EmpID=@EmpID;";
                SqlCommand command = new SqlCommand(query, Con);

                command.Parameters.AddWithValue("@EmpID", employeeID);
                command.Parameters.AddWithValue("@EmpName", employeeName);
                command.Parameters.AddWithValue("@EmpDesig", employeeDesignation);
                command.Parameters.AddWithValue("@EmpSched", employeeSchedule);

                try
                {
                    Con.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        employeeID = Convert.ToInt32(result);
                        Con.Close();
                        MessageBox.Show("Employee Updated Successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the Employee: " + ex.Message);
                }
            }
            return employeeID;
        }
        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            try
            {
                string userID = comboUserID.Text;
                string accLvl = comboAccLvl.Text;
                string assignedBy = comboAssignedBy.Text;
                int userId = int.Parse(userID);
                int acclvl = int.Parse(accLvl);
                int empId = int.Parse(txtEmpID.Text);
                int emplpoyeeId = UpdateEmployee(empId, txtEmpName.Text, txtEmpDesig.Text, txtEmpSched.Text);
                UpdateEmpAccess(empId, acclvl);
                UpdateEmpUser(empId, userId, dateAssigned.Text, comboAssignedBy.Text);
                PopulateGrid();
                ClearProductForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DeleteEmployee(int employeeId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
                {
                    string deleteEmpUser = "DELETE FROM tblEmp_User WHERE EmpID = @EmpID;";
                    using (SqlCommand deleteEmpUserr = new SqlCommand(deleteEmpUser, connection))
                    {
                        deleteEmpUserr.Parameters.AddWithValue("@EmpID", employeeId);
                        connection.Open();
                        deleteEmpUserr.ExecuteNonQuery();
                        connection.Close();
                    }

                    string deleteEmpAccess = "DELETE FROM tblEmp_Access WHERE EmpID = @EmpID;";
                    using (SqlCommand deleteEmpAccesss = new SqlCommand(deleteEmpAccess, connection))
                    {
                        deleteEmpAccesss.Parameters.AddWithValue("@EmpID", employeeId);
                        connection.Open();
                        deleteEmpAccesss.ExecuteNonQuery();
                        connection.Close();
                    }

                    string deleteEmployeeQuery = "DELETE FROM tblEmployee WHERE EmpID = @EmpID;";
                    using (SqlCommand deleteEmployeeCommand = new SqlCommand(deleteEmployeeQuery, connection))
                    {
                        connection.Open();
                        deleteEmployeeCommand.Parameters.AddWithValue("@EmpID", employeeId);
                        deleteEmployeeCommand.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                MessageBox.Show("Employee deleted successfully.");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the Employee: " + ex.Message);
            }
        }
        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            int employeeId;
            if (int.TryParse(txtEmpID.Text, out employeeId) && GridEmployee.SelectedRows.Count > 0)
            {
                DeleteEmployee(employeeId);
            }
            else
            {
                MessageBox.Show("Invalid Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEmpHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}
