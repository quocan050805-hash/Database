
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SaleManagement
{
    public partial class AdminDashboard : Form
    {
        SqlConnection conn;
        public AdminDashboard()
        {
            InitializeComponent();
            conn = new SqlConnection("Server = DESKTOP-Q71GJ8F\\SQLEXPRESS; database = SaleManagement; integrated security = true;");
        }

        public void FillData()
        {
            string query = "select * from Customers ";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            ad.Fill(tbl);
            dgvCustomers.DataSource = tbl;
            conn.Close();
        }

        public void ClearData()
        {
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtCustomerPhone.Clear();
            txtCustomerEmail.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string insert = "insert into Customers values (@id,@name,@phone,@email)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Value = txtCustomerID.Text;
            cmd.Parameters.Add("@name", SqlDbType.VarChar);
            cmd.Parameters["@name"].Value = txtCustomerName.Text;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar);
            cmd.Parameters["@phone"].Value = txtCustomerPhone.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar);
            cmd.Parameters["@email"].Value = txtCustomerEmail.Text;
            cmd.ExecuteNonQuery();
            FillData();
            ClearData();
            MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCustomers.Rows[e.RowIndex];
                txtCustomerID.Text = row.Cells["CustomerID"].Value.ToString();
                txtCustomerName.Text = row.Cells["Name"].Value.ToString();
                txtCustomerPhone.Text = row.Cells["Phone"].Value.ToString();
                txtCustomerEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                string update = "update Customers set Name =@name, Phone = @phone, Email=@email" + " where CustomerID = @id";
                conn.Open();
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = txtCustomerName.Text;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar);
                cmd.Parameters["@phone"].Value = txtCustomerPhone.Text;
                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = txtCustomerEmail.Text;
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = txtCustomerID.Text;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    FillData();
                    ClearData();
                    MessageBox.Show(this, "Updated successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                conn.Open();
                string delete = "delete from Customers where CustomerID = @id";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = txtCustomerID.Text;
                cmd.ExecuteNonQuery();
                FillData();
                ClearData();
                MessageBox.Show(this, "Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchCustomer.Text.Trim();
            if (string.IsNullOrEmpty(searchValue))
            {
                FillData(); // Hiển thị toàn bộ dữ liệu nếu ô tìm kiếm trống
                return;
            }

            string query = "SELECT * FROM Customers WHERE " +
                           "CustomerID LIKE @search OR " +
                           "Name LIKE @search OR " +
                           "Phone LIKE @search OR " +
                           "Email LIKE @search";

            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            ad.SelectCommand.Parameters.AddWithValue("@search", "%" + searchValue + "%");
            ad.Fill(tbl);
            dgvCustomers.DataSource = tbl;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string insert = "insert into Employees values (@id,@name,@level,@username,@password)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Value = txtCustomerID.Text;
            cmd.Parameters.Add("@name", SqlDbType.VarChar);
            cmd.Parameters["@name"].Value = txtCustomerName.Text;
            cmd.Parameters.Add("@level", SqlDbType.VarChar);
            cmd.Parameters["@level"].Value = txtCustomerPhone.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar);
            cmd.Parameters["@email"].Value = txtCustomerEmail.Text;
            cmd.ExecuteNonQuery();
            FillData();
            ClearData();
            MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnRefreshEmployee_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
