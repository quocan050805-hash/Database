
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;


namespace AdminDashboard
{
    public partial class WarehouseForm : Form
    {
        SqlConnection conn;
        public WarehouseForm()
        {
            InitializeComponent();
            conn = new SqlConnection("Server = DESKTOP-DEI6HM2\\SQLEXPRESS; database = SaleManagement; integrated security = true;");
        }
        private void FillData()
        {

            string queryProduct = "SELECT * FROM Products";


            DataTable productsTable = new DataTable();


            SqlDataAdapter productAdapter = new SqlDataAdapter(queryProduct, conn);


            productAdapter.Fill(productsTable);



            dgvProduct.DataSource = productsTable;

        }

        private void ClearData()
        {


            txtProductID.Clear();
            txtProductName.Clear();
            txtCategoryID.Clear();
            txtSupplierID.Clear();
            txtPrice.Clear();


        }


        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProduct.Rows.Count == 0)
                {
                    MessageBox.Show("No data available to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Save Products Data",
                    FileName = "Products.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Products");
                        for (int i = 0; i < dgvProduct.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dgvProduct.Columns[i].HeaderText;
                        }
                        for (int i = 0; i < dgvProduct.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvProduct.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value = dgvProduct.Rows[i].Cells[j].Value?.ToString();
                            }
                        }
                        workbook.SaveAs(saveFileDialog.FileName);
                    }
                    MessageBox.Show("Exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchProduct_TextChanged_1(object sender, EventArgs e)
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

        private void btnAddProduct_Click_1(object sender, EventArgs e)
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

        private void btnUpdateProduct_Click_1(object sender, EventArgs e)
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

        private void btnDeleteProduct_Click_1(object sender, EventArgs e)
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

        private void btnRefreshProduct_Click_1(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
    
