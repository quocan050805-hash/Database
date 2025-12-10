
﻿namespace SaleManagement
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCustomer = new System.Windows.Forms.TabPage();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.txtEmployeeLevel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnRefreshEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmployeePassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmployeeUsername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.tabPageStatistics = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabPageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCustomer);
            this.tabControl1.Controls.Add(this.tabPageEmployee);
            this.tabControl1.Controls.Add(this.tabPageProduct);
            this.tabControl1.Controls.Add(this.tabPageStatistics);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(911, 609);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.Controls.Add(this.txtSearchCustomer);
            this.tabPageCustomer.Controls.Add(this.label6);
            this.tabPageCustomer.Controls.Add(this.dgvCustomers);
            this.tabPageCustomer.Controls.Add(this.btnRefresh);
            this.tabPageCustomer.Controls.Add(this.btnDelete);
            this.tabPageCustomer.Controls.Add(this.btnUpdate);
            this.tabPageCustomer.Controls.Add(this.btnAdd);
            this.tabPageCustomer.Controls.Add(this.label5);
            this.tabPageCustomer.Controls.Add(this.txtCustomerEmail);
            this.tabPageCustomer.Controls.Add(this.label3);
            this.tabPageCustomer.Controls.Add(this.txtCustomerPhone);
            this.tabPageCustomer.Controls.Add(this.label4);
            this.tabPageCustomer.Controls.Add(this.txtCustomerName);
            this.tabPageCustomer.Controls.Add(this.label2);
            this.tabPageCustomer.Controls.Add(this.txtCustomerID);
            this.tabPageCustomer.Controls.Add(this.label1);
            this.tabPageCustomer.Location = new System.Drawing.Point(4, 25);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomer.Size = new System.Drawing.Size(903, 580);
            this.tabPageCustomer.TabIndex = 0;
            this.tabPageCustomer.Text = "Manage Customer";
            this.tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(391, 525);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(245, 22);
            this.txtSearchCustomer.TabIndex = 16;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 531);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Search\r\n";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(78, 271);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(743, 221);
            this.dgvCustomers.TabIndex = 14;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(700, 161);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 33);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(511, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 33);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(305, 161);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 33);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(134, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 33);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "List of Customer";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(632, 103);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(143, 22);
            this.txtCustomerEmail.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(632, 45);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(143, 22);
            this.txtCustomerPhone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(221, 103);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(143, 22);
            this.txtCustomerName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(221, 45);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(143, 22);
            this.txtCustomerID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.Controls.Add(this.txtEmployeeLevel);
            this.tabPageEmployee.Controls.Add(this.label13);
            this.tabPageEmployee.Controls.Add(this.txtSearchEmployee);
            this.tabPageEmployee.Controls.Add(this.label7);
            this.tabPageEmployee.Controls.Add(this.dgvEmployees);
            this.tabPageEmployee.Controls.Add(this.btnRefreshEmployee);
            this.tabPageEmployee.Controls.Add(this.btnDeleteEmployee);
            this.tabPageEmployee.Controls.Add(this.btnUpdateEmployee);
            this.tabPageEmployee.Controls.Add(this.btnAddEmployee);
            this.tabPageEmployee.Controls.Add(this.label8);
            this.tabPageEmployee.Controls.Add(this.txtEmployeePassword);
            this.tabPageEmployee.Controls.Add(this.label9);
            this.tabPageEmployee.Controls.Add(this.txtEmployeeUsername);
            this.tabPageEmployee.Controls.Add(this.label10);
            this.tabPageEmployee.Controls.Add(this.txtEmployeeName);
            this.tabPageEmployee.Controls.Add(this.label11);
            this.tabPageEmployee.Controls.Add(this.txtEmployeeID);
            this.tabPageEmployee.Controls.Add(this.label12);
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee.Size = new System.Drawing.Size(903, 580);
            this.tabPageEmployee.TabIndex = 1;
            this.tabPageEmployee.Text = "Manage Employee";
            this.tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // txtEmployeeLevel
            // 
            this.txtEmployeeLevel.Location = new System.Drawing.Point(225, 126);
            this.txtEmployeeLevel.Name = "txtEmployeeLevel";
            this.txtEmployeeLevel.Size = new System.Drawing.Size(143, 22);
            this.txtEmployeeLevel.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(135, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 16);
            this.label13.TabIndex = 34;
            this.label13.Text = "Level";
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Location = new System.Drawing.Point(393, 519);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(245, 22);
            this.txtSearchEmployee.TabIndex = 32;
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtSearchEmployee_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Search\r\n";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(80, 265);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(743, 221);
            this.dgvEmployees.TabIndex = 30;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
            // 
            // btnRefreshEmployee
            // 
            this.btnRefreshEmployee.Location = new System.Drawing.Point(694, 179);
            this.btnRefreshEmployee.Name = "btnRefreshEmployee";
            this.btnRefreshEmployee.Size = new System.Drawing.Size(83, 33);
            this.btnRefreshEmployee.TabIndex = 29;
            this.btnRefreshEmployee.Text = "Refresh";
            this.btnRefreshEmployee.UseVisualStyleBackColor = true;
            this.btnRefreshEmployee.Click += new System.EventHandler(this.btnRefreshEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(505, 179);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(83, 33);
            this.btnDeleteEmployee.TabIndex = 28;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(299, 179);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(83, 33);
            this.btnUpdateEmployee.TabIndex = 27;
            this.btnUpdateEmployee.Text = "Update";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(128, 179);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(83, 33);
            this.btnAddEmployee.TabIndex = 26;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "List of Employee";
            // 
            // txtEmployeePassword
            // 
            this.txtEmployeePassword.Location = new System.Drawing.Point(634, 74);
            this.txtEmployeePassword.Name = "txtEmployeePassword";
            this.txtEmployeePassword.Size = new System.Drawing.Size(143, 22);
            this.txtEmployeePassword.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(544, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Password";
            // 
            // txtEmployeeUsername
            // 
            this.txtEmployeeUsername.Location = new System.Drawing.Point(634, 33);
            this.txtEmployeeUsername.Name = "txtEmployeeUsername";
            this.txtEmployeeUsername.Size = new System.Drawing.Size(143, 22);
            this.txtEmployeeUsername.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(544, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Username";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(225, 74);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(143, 22);
            this.txtEmployeeName.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(135, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Name";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(225, 33);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(143, 22);
            this.txtEmployeeID.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(135, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "ID";
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Location = new System.Drawing.Point(4, 25);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Size = new System.Drawing.Size(903, 580);
            this.tabPageProduct.TabIndex = 2;
            this.tabPageProduct.Text = "Manage Product";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // tabPageStatistics
            // 
            this.tabPageStatistics.Location = new System.Drawing.Point(4, 25);
            this.tabPageStatistics.Name = "tabPageStatistics";
            this.tabPageStatistics.Size = new System.Drawing.Size(903, 580);
            this.tabPageStatistics.TabIndex = 3;
            this.tabPageStatistics.Text = "Statistics";
            this.tabPageStatistics.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 609);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCustomer.ResumeLayout(false);
            this.tabPageCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabPageEmployee.ResumeLayout(false);
            this.tabPageEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCustomer;
        private System.Windows.Forms.TabPage tabPageEmployee;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.TabPage tabPageStatistics;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmployeeLevel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnRefreshEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmployeePassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmployeeUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label12;
    }
}
