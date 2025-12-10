
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
using AdminDashboard;
using ClosedXML.Excel;

namespace SaleManagement
{
    public partial class LoginForm : Form
    {
        SqlConnection conn;

        public LoginForm()
        {
            InitializeComponent();
            conn = new SqlConnection("Server = DESKTOP-DEI6HM2\\SQLEXPRESS; database = SaleManagement; integrated security = true;");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string query = "select * from Employees where Username =@username and Password =@password";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar);
            cmd.Parameters["@username"].Value = username;
            cmd.Parameters.AddWithValue("@password", SqlDbType.VarChar);
            cmd.Parameters["@password"].Value = password;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int role = int.Parse(reader["Level"].ToString());
                if (role == 1)
                {
                    MessageBox.Show(this, "Login successful! ", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    AdminRole adminRole = new AdminRole();
                    adminRole.ShowDialog();
                    this.Dispose();
                }
                if (role == 2)
                {
                    MessageBox.Show(this, "Login successful! ", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    SalesForm salesForm = new SalesForm();
                    salesForm.ShowDialog();
                    this.Dispose();
                }
                if (role == 3)
                {
                    MessageBox.Show(this, "Login successful! ", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    WarehouseForm warehouseForm = new WarehouseForm();
                    warehouseForm.ShowDialog();
                    this.Dispose();
                }
            }
            conn.Close();

        }
    }
}
