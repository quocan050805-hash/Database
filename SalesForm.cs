
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

namespace AdminDashboard
{
    public partial class SalesForm : Form
    {
        SqlConnection conn;
        public SalesForm()
        {
            InitializeComponent();
            conn = new SqlConnection("Server = DESKTOP-DEI6HM2\\SQLEXPRESS; database = SaleManagement; integrated security = true;");
        }

        public void FillData()
        {
            string queryCustomers = "SELECT * FROM Customers";
            string queryProduct = "SELECT * FROM Products";

            DataTable customersTable = new DataTable();
            DataTable productsTable = new DataTable();

            SqlDataAdapter customerAdapter = new SqlDataAdapter(queryCustomers, conn);
            SqlDataAdapter productAdapter = new SqlDataAdapter(queryProduct, conn);

            customerAdapter.Fill(customersTable);
            productAdapter.Fill(productsTable);
            dgvCustomers.DataSource = customersTable;
            dgvProduct.DataSource = productsTable;
        }

        public void GetCustomers()
        {
            conn.Open();
            string query = "select CustomerID,Name from Customers";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            cbCustomer.DataSource = table;
            cbCustomer.ValueMember = "CustomerID";
            cbCustomer.DisplayMember = "Name";
            cbCustomerStatistic.DataSource = table;
            cbCustomerStatistic.ValueMember = "CustomerID";
            cbCustomerStatistic.DisplayMember = "Name";
            conn.Close();
        }


        public void GetEmployees()
        {
            conn.Open();
            string query = "select EmployeeID,Name from Employees";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            cbEmployee.DataSource = table;
            cbEmployee.ValueMember = "EmployeeID";
            cbEmployee.DisplayMember = "Name";
            conn.Close();
        }

        public void GetPaymentMethods()
        {
            conn.Open();
            string query = "select PaymentMethodID,MethodName from PaymentMethods";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            cbPaymentMethod.DataSource = table;
            cbPaymentMethod.ValueMember = "PaymentMethodID";
            cbPaymentMethod.DisplayMember = "MethodName";
            conn.Close();
        }

        public void GetProducts()
        {
            conn.Open();
            string query = "select ProductID,ProductName from Products";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            cbProduct.DataSource = table;
            cbProduct.ValueMember = "ProductID";
            cbProduct.DisplayMember = "ProductName";
            conn.Close();
        }
        public void ClearData()
        {
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtCustomerPhone.Clear();
            txtCustomerEmail.Clear();


            txtProductID.Clear();
            txtProductName.Clear();
            txtCategoryID.Clear();
            txtSupplierID.Clear();
            txtPrice.Clear();

            txtOrderID.Clear();
            txtOrderDate.Clear();

            txtOrderDetailID.Clear();
            txtQuantity.Clear();
            txtTotalAmount.Clear();

        }

        // Manage customer
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
            conn.Close();
            MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                conn.Close();
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
                conn.Close();
                MessageBox.Show(this, "Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();

        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "SELECT * FROM Customers WHERE Name LIKE @search OR Phone LIKE @search";

            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(searchQuery, conn))
            {
                cmd.Parameters.AddWithValue("@search", "%" + txtSearchCustomer.Text + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            dgvCustomers.DataSource = dt;

        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            FillData();

            GetProducts();
            GetCustomers();
            GetEmployees();
            GetPaymentMethods();



        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO Products VALUES (@id, @name, @category, @supplier, @price)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = txtProductID.Text;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtProductName.Text;
            cmd.Parameters.Add("@category", SqlDbType.Int).Value = txtCategoryID.Text;
            cmd.Parameters.Add("@supplier", SqlDbType.Int).Value = txtSupplierID.Text;
            cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = txtPrice.Text;
            cmd.ExecuteNonQuery();
            FillData();
            ClearData();
            conn.Close();
            MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                string update = "UPDATE Products SET ProductName = @name, Category = @category, Supplier = @supplier, Price = @price WHERE ProductID = @id";
                conn.Open();
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtProductName.Text;
                cmd.Parameters.Add("@category", SqlDbType.Int).Value = txtCategoryID.Text;
                cmd.Parameters.Add("@supplier", SqlDbType.Int).Value = txtSupplierID.Text;
                cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = txtPrice.Text;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = txtProductID.Text;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    FillData();
                    ClearData();
                    MessageBox.Show(this, "Updated successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                conn.Open();
                string delete = "DELETE FROM Products WHERE ProductID = @id";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = txtProductID.Text;
                cmd.ExecuteNonQuery();
                FillData();
                ClearData();
                conn.Close();
                MessageBox.Show(this, "Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void btnRefreshProduct_Click(object sender, EventArgs e)
        {
            ClearData();

        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string searchQuery = "SELECT * FROM Products WHERE ProductName LIKE @search OR Price LIKE @search";
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(searchQuery, conn))
            {
                cmd.Parameters.AddWithValue("@search", "%" + txtSearchProduct.Text + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            dgvProduct.DataSource = dt;
            conn.Close();

        }

        private void btnRefreshOrder_Click(object sender, EventArgs e)
        {
            ClearData();

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProduct.Rows[e.RowIndex];
                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtCategoryID.Text = row.Cells["Category"].Value.ToString();
                txtSupplierID.Text = row.Cells["Supplier"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();

            }
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvOrder.Rows[e.RowIndex];
                txtOrderID.Text = row.Cells["OrderID"].Value.ToString();
                txtOrderDate.Text = row.Cells["OrderDate"].Value.ToString();
                cbCustomer.SelectedValue = row.Cells["CustomerID"].Value.ToString();
                cbEmployee.SelectedValue = row.Cells["EmployeeID"].Value.ToString();
                cbPaymentMethod.SelectedValue = row.Cells["PaymentMethodID"].Value.ToString();

            }
        }

        private void btnViewByDate_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpFrom.Value.Date;
            DateTime endDate = dtpTo.Value.Date;
            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be greater than end date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "select od.OrderDetailID, o.OrderID, o.OrderDate, od.ProductID, od.Quantity, od.TotalAmount, o.PaymentMethodID, o.EmployeeID, o.CustomerID from Orders o left join OrderDetails od on o.OrderID = od.OrderID where o.OrderDate between @startDate and @endDate order by o.OrderDate";
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@startDate", startDate);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@endDate", endDate);
            sqlDataAdapter.Fill(dataTable);

            dgvStatistic.DataSource = dataTable;
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("No data found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewByCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int customerID = (int)(cbCustomerStatistic.SelectedValue);
                string query = "select o.CustomerID, od.OrderDetailID, o.OrderID, o.OrderDate, od.ProductID, od.Quantity, od.TotalAmount, o.PaymentMethodID, o.EmployeeID from Orders o left join OrderDetails od on o.OrderID = od.OrderID where o.CustomerID = @cid order by o.OrderDate";
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@cid", customerID);
                sqlDataAdapter.Fill(dataTable);

                dgvStatistic.DataSource = dataTable;
                dgvStatistic.Refresh();

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No data found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
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
        private void LoadDataOrders()
        {
            string query = "select od.OrderDetailID, o.OrderID, o.OrderDate, od.ProductID, od.Quantity, od.TotalAmount, o.PaymentMethodID, o.EmployeeID, o.CustomerID from Orders o left join OrderDetails od on o.OrderID = od.OrderID";
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
            sqlDataAdapter.Fill(dataTable);
            dgvOrder.DataSource = dataTable;
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            string insert = "insert into Orders (OrderID, OrderDate, PaymentMethodID, EmployeeID, CustomerID) values(@oid, @date, @methodid, @empid, @cusid)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(insert, conn);

            cmd.Parameters.Add("@oid", SqlDbType.VarChar);
            cmd.Parameters["@oid"].Value = txtOrderID.Text;

            cmd.Parameters.Add("@date", SqlDbType.VarChar);
            cmd.Parameters["@date"].Value = txtOrderDate.Text;

            cmd.Parameters.Add("@methodid", SqlDbType.VarChar);
            cmd.Parameters["@methodid"].Value = cbPaymentMethod.SelectedValue.ToString();

            cmd.Parameters.Add("@empid", SqlDbType.VarChar);
            cmd.Parameters["@empid"].Value = cbEmployee.SelectedValue.ToString();

            cmd.Parameters.Add("@cusid", SqlDbType.VarChar);
            cmd.Parameters["@cusid"].Value = cbCustomer.SelectedValue.ToString();

            cmd.ExecuteNonQuery();
            conn.Close();

            string insert1 = "insert into OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, TotalAmount) values(@odid, @oid, @pid, @quantity, @total)";
            conn.Open();
            SqlCommand cmd1 = new SqlCommand(insert1, conn);

            cmd1.Parameters.Add("@odid", SqlDbType.VarChar);
            cmd1.Parameters["@odid"].Value = txtOrderDetailID.Text;

            cmd1.Parameters.Add("@oid", SqlDbType.VarChar);
            cmd1.Parameters["@oid"].Value = txtOrderID.Text;

            cmd1.Parameters.Add("@pid", SqlDbType.VarChar);
            cmd1.Parameters["@pid"].Value = cbProduct.SelectedValue.ToString();

            cmd1.Parameters.Add("@quantity", SqlDbType.Int);
            cmd1.Parameters["@quantity"].Value = int.Parse(txtQuantity.Text);

            cmd1.Parameters.Add("@total", SqlDbType.Float);
            cmd1.Parameters["@total"].Value = float.Parse(txtTotalAmount.Text);

            cmd1.ExecuteNonQuery();
            conn.Close();
            LoadDataOrders();
            ClearData();
            MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void txtQuantity_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                conn.Close(); // Đảm bảo đóng trước khi mở lại
                int productID = (int)cbProduct.SelectedValue;
                conn.Open();

                string query = "SELECT Price FROM Products WHERE ProductID = @pid";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@pid", productID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    float price = reader["Price"] != DBNull.Value ? Convert.ToSingle(reader["Price"]) : 0;
                    reader.Close(); // Đóng reader trước khi đóng connection

                    // Kiểm tra nếu giá trị là số hợp lệ
                    if (int.TryParse(txtQuantity.Text, out int quantity))
                    {
                        float totalAmount = price * quantity;
                        txtTotalAmount.Text = totalAmount.ToString();
                    }
                    else
                    {
                        txtTotalAmount.Text = "0"; // hoặc để trống, tùy bạn
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
