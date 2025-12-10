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

namespace SaleManagement
{
    public partial class AdminRole : Form
    {
        SqlConnection conn;
        private string update;

        public AdminRole()
        {
            InitializeComponent();
            conn = new SqlConnection("Server = DESKTOP-DEI6HM2\\SQLEXPRESS; database = SaleManagement; integrated security = true;");
        }
        public void FillData()
        {
            string queryCustomers = "SELECT * FROM Customers";
            string queryEmployees = "SELECT * FROM Employees";
            string queryProduct = "SELECT * FROM Products";
            string queryOrders = "SELECT * FROM Orders";
            string queryOrderDetails = "SELECT * FROM OrderDetails";

            DataTable customersTable = new DataTable();
            DataTable employeesTable = new DataTable();
            DataTable productsTable = new DataTable();
            DataTable ordersTable = new DataTable();
            DataTable orderDetailsTable = new DataTable();

            SqlDataAdapter customerAdapter = new SqlDataAdapter(queryCustomers, conn);
            SqlDataAdapter employeeAdapter = new SqlDataAdapter(queryEmployees, conn);
            SqlDataAdapter productAdapter = new SqlDataAdapter(queryProduct, conn);
            SqlDataAdapter ordersAdapter = new SqlDataAdapter(queryOrders, conn);
            SqlDataAdapter orderdetailsAdapter = new SqlDataAdapter(queryOrderDetails, conn);

            customerAdapter.Fill(customersTable);
            employeeAdapter.Fill(employeesTable);
            productAdapter.Fill(productsTable);
            orderdetailsAdapter.Fill(orderDetailsTable);
            ordersAdapter.Fill(ordersTable);

            dgvCustomers.DataSource = customersTable;
            dgvEmployees.DataSource = employeesTable;
            dgvProduct.DataSource = productsTable;
            dgvOrders.DataSource = ordersTable;
            dgvOrderDetails.DataSource = orderDetailsTable;
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
            cbEmployeeStatistic.DataSource = table;
            cbEmployeeStatistic.ValueMember = "EmployeeID";
            cbEmployeeStatistic.DisplayMember = "Name";
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

            txtEmployeeID.Clear();
            txtEmployeeName.Clear();
            txtEmployeePosition.Clear();
            txtEmployeeLevel.Clear();
            txtEmployeeUsername.Clear();
            txtEmployeePassword.Clear();

            txtProductID.Clear();
            txtProductName.Clear();
            txtCategoryID.Clear();
            txtSupplierID.Clear();
            txtPrice.Clear();

            txtOrdersID.Clear();
            txtOrderDate.Clear();

            txtOrderDetailID.Clear();
            txtOrderID1.Clear();
            txtQuantity.Clear();
            txtTotalAmount.Clear();

        }

        private void AdminRole_Load(object sender, EventArgs e)
        {
            FillData();
            GetCustomers();
            GetEmployees();
            GetPaymentMethods();
            GetProducts();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO Employees (EmployeeID, Name, Position, Level, Username, Password) VALUES (@id, @name, @position, @level, @username, @password)";

            conn.Open();
            SqlCommand cmd = new SqlCommand(insert, conn);

            cmd.Parameters.AddWithValue("@id", txtEmployeeID.Text);
            cmd.Parameters.AddWithValue("@name", txtEmployeeName.Text);
            cmd.Parameters.AddWithValue("@position", txtEmployeePosition.Text);
            cmd.Parameters.AddWithValue("@level", txtEmployeeLevel.Text);
            cmd.Parameters.AddWithValue("@username", txtEmployeeUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtEmployeePassword.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            FillData(); // update DataGridView
            ClearData();
            MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];

                txtEmployeeID.Text = row.Cells["EmployeeID"].Value?.ToString();
                txtEmployeeName.Text = row.Cells["Name"].Value?.ToString();
                txtEmployeePosition.Text = row.Cells["Position"].Value?.ToString();
                txtEmployeeLevel.Text = row.Cells["Level"].Value?.ToString();
                txtEmployeeUsername.Text = row.Cells["Username"].Value?.ToString();
                txtEmployeePassword.Text = row.Cells["Password"].Value?.ToString();
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                string update = "UPDATE Employees SET Name = @name, Position = @position, Level = @level, Username = @username, Password = @password WHERE EmployeeID = @id";
                conn.Open();
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = txtEmployeeName.Text;
                cmd.Parameters.Add("@position", SqlDbType.VarChar);
                cmd.Parameters["@position"].Value = txtEmployeePosition.Text;
                cmd.Parameters.Add("@level", SqlDbType.Int);
                cmd.Parameters["@level"].Value = txtEmployeeLevel.Text;
                cmd.Parameters.Add("@username", SqlDbType.VarChar);
                cmd.Parameters["@username"].Value = txtEmployeeUsername.Text;
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = txtEmployeeID.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters["@password"].Value = txtEmployeePassword.Text;
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    FillData();
                    ClearData();
                    MessageBox.Show(this, "Updated successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                conn.Open();
                string delete = "DELETE FROM Employees WHERE EmployeeID = @id";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = txtEmployeeID.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
                FillData();
                ClearData();
                MessageBox.Show(this, "Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefreshEmployee_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string searchQuery = "SELECT * FROM Employees WHERE Name LIKE @search OR Position LIKE @search OR Username LIKE @search";

            SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearchEmployee.Text + "%");

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvEmployees.DataSource = dt;
            conn.Close();
        }

        // Manage Customer
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
            conn.Open();
            string searchQuery = "SELECT * FROM Customers WHERE Name LIKE @search OR Phone LIKE @search";

            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(searchQuery, conn))
            {
                cmd.Parameters.AddWithValue("@search", "%" + txtSearchCustomer.Text + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            dgvCustomers.DataSource = dt;
            conn.Close();
        }

        // Manage product
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

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
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

        // Orders
        private void btnAddOrders_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO Orders VALUES (@id, @customerID, @orderDate, @employeeID, @paymentMethodID)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(txtOrdersID.Text);
            cmd.Parameters.Add("@customerID", SqlDbType.Int);
            cmd.Parameters["@customerID"].Value = int.Parse(cbCustomer.SelectedValue.ToString());
            cmd.Parameters.Add("@orderDate", SqlDbType.VarChar).Value = txtOrderDate.Text;
            cmd.Parameters.Add("@employeeID", SqlDbType.Int);
            cmd.Parameters["@employeeID"].Value = int.Parse(cbEmployee.SelectedValue.ToString());
            cmd.Parameters.Add("@paymentMethodID", SqlDbType.Int);
            cmd.Parameters["@paymentMethodID"].Value = int.Parse(cbPaymentMethod.SelectedValue.ToString());
            cmd.ExecuteNonQuery();
            FillData();
            ClearData();
            conn.Close();
            MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvOrders.Rows[e.RowIndex];
                txtOrdersID.Text = row.Cells["OrderID"].Value.ToString();
                txtOrderDate.Text = row.Cells["OrderDate"].Value.ToString();
                cbCustomer.SelectedValue = row.Cells["CustomerID"].Value.ToString();
                cbEmployee.SelectedValue = row.Cells["EmployeeID"].Value.ToString();
                cbPaymentMethod.SelectedValue = row.Cells["PaymentMethodID"].Value.ToString();

            }
        }

        private void btnUpdateOrders_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                string update = "UPDATE Orders SET CustomerID = @customerId, OrderDate = @orderDate, EmployeeID = @employeeId, PaymentMethodID = @paymentMethodId WHERE OrderID = @id";
                conn.Open();
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.Add("@customerID", SqlDbType.Int);
                cmd.Parameters["@customerID"].Value = int.Parse(cbCustomer.SelectedValue.ToString());
                cmd.Parameters.Add("@orderDate", SqlDbType.VarChar).Value = txtOrderDate.Text;
                cmd.Parameters.Add("@employeeID", SqlDbType.Int);
                cmd.Parameters["@employeeID"].Value = int.Parse(cbEmployee.SelectedValue.ToString());
                cmd.Parameters.Add("@paymentMethodID", SqlDbType.Int);
                cmd.Parameters["@paymentMethodID"].Value = int.Parse(cbPaymentMethod.SelectedValue.ToString());
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = txtOrdersID.Text;
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    FillData();
                    ClearData();
                    MessageBox.Show(this, "Updated successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnDeleteOrders_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                string delete = "DELETE FROM Orders WHERE OrderID = @id";
                conn.Open();
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = txtOrdersID.Text;
                cmd.ExecuteNonQuery();
                FillData();
                ClearData();
                conn.Close();
                MessageBox.Show(this, "Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefreshOrders_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void txtSearchOrders_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string searchQuery = "SELECT * FROM Orders WHERE OrderID LIKE @search OR CustomerID LIKE @search OR EmployeeID LIKE @search OR PaymentMethodID LIKE @search";

            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(searchQuery, conn))
            {
                cmd.Parameters.AddWithValue("@search", "%" + txtSearchOrders.Text + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            dgvOrders.DataSource = dt;
            conn.Close();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
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

        // OrderDetail
        private void btnAddOrderDetails_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO OrderDetails VALUES (@id, @orderID, @productID, @quantity, @totalAmount)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = txtOrderDetailID.Text;
            cmd.Parameters.Add("@orderID", SqlDbType.Int).Value = txtOrderID1.Text;
            cmd.Parameters.Add("@productID", SqlDbType.Int).Value = cbProduct.SelectedValue.ToString();
            cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = txtQuantity.Text;
            cmd.Parameters.Add("@totalAmount", SqlDbType.Decimal).Value = txtTotalAmount.Text;
            cmd.ExecuteNonQuery();
            FillData();
            ClearData();
            conn.Close();
            MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvOrderDetails.Rows[e.RowIndex];
                txtOrderDetailID.Text = row.Cells["OrderDetailID"].Value.ToString();
                txtOrderID1.Text = row.Cells["OrderID"].Value.ToString();
                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtTotalAmount.Text = row.Cells["TotalAmount"].Value.ToString();

            }
        }

        private void btnUpdateOrderDetails_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                string update = "UPDATE OrderDetails SET OrderID = @orderID, ProductID = @productID, Quantity = @quantity, TotalAmount = @totalAmount WHERE OrderDetailID = @id";
                conn.Open();
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.Add("@orderID", SqlDbType.Int).Value = txtOrderID1.Text;
                cmd.Parameters.Add("@productID", SqlDbType.Int).Value = cbProduct.SelectedValue.ToString();
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = txtQuantity.Text;
                cmd.Parameters.Add("@totalAmount", SqlDbType.Decimal).Value = txtTotalAmount.Text;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = txtOrderDetailID.Text;
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

        private void btnDeleteOrderDetails_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                conn.Open();
                string delete = "DELETE FROM OrderDetails WHERE OrderDetailID = @id";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = txtOrderDetailID.Text;
                cmd.ExecuteNonQuery();
                FillData();
                ClearData();
                conn.Close();
                MessageBox.Show(this, "Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnRefreshOrderDetails_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void txtSearchLOrdersDetails_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string searchQuery = "SELECT * FROM OrderDetails WHERE OrderID LIKE @search OR ProductID LIKE @search";
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(searchQuery, conn))
            {
                cmd.Parameters.AddWithValue("@search", "%" + txtSearchLOrdersDetails.Text + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            dgvOrderDetails.DataSource = dt;
            conn.Close();
        }
    }
}
