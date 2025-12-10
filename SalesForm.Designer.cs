
﻿namespace AdminDashboard
{
    partial class SalesForm
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
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageCustomer = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.btnRefreshProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPageStatistics = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.btnViewByCustomer = new System.Windows.Forms.Button();
            this.btnViewByDate = new System.Windows.Forms.Button();
            this.cbCustomerStatistic = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMakeOrder = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtOrderDetailID = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btnRefreshOrder = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabPageCustomer.SuspendLayout();
            this.tabPageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.tabPageStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageMakeOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(303, 427);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(175, 20);
            this.txtSearchCustomer.TabIndex = 16;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 431);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Search by name";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(58, 220);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(557, 180);
            this.dgvCustomers.TabIndex = 14;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(525, 131);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(62, 27);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(383, 131);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 27);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(229, 131);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(62, 27);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(100, 131);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 27);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "List of Customer";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(474, 84);
            this.txtCustomerEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(108, 20);
            this.txtCustomerEmail.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(474, 37);
            this.txtCustomerPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(108, 20);
            this.txtCustomerPhone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(166, 84);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(108, 20);
            this.txtCustomerName.TabIndex = 3;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(166, 37);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(108, 20);
            this.txtCustomerID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
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
            this.tabPageCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabPageCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageCustomer.Size = new System.Drawing.Size(675, 469);
            this.tabPageCustomer.TabIndex = 0;
            this.tabPageCustomer.Text = "Manage Customer";
            this.tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.txtSearchProduct);
            this.tabPageProduct.Controls.Add(this.label21);
            this.tabPageProduct.Controls.Add(this.label20);
            this.tabPageProduct.Controls.Add(this.dgvProduct);
            this.tabPageProduct.Controls.Add(this.btnRefreshProduct);
            this.tabPageProduct.Controls.Add(this.btnDeleteProduct);
            this.tabPageProduct.Controls.Add(this.btnUpdateProduct);
            this.tabPageProduct.Controls.Add(this.btnAddProduct);
            this.tabPageProduct.Controls.Add(this.txtPrice);
            this.tabPageProduct.Controls.Add(this.txtSupplierID);
            this.tabPageProduct.Controls.Add(this.txtCategoryID);
            this.tabPageProduct.Controls.Add(this.txtProductName);
            this.tabPageProduct.Controls.Add(this.txtProductID);
            this.tabPageProduct.Controls.Add(this.label19);
            this.tabPageProduct.Controls.Add(this.label18);
            this.tabPageProduct.Controls.Add(this.label17);
            this.tabPageProduct.Controls.Add(this.label16);
            this.tabPageProduct.Controls.Add(this.label15);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 22);
            this.tabPageProduct.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Size = new System.Drawing.Size(675, 469);
            this.tabPageProduct.TabIndex = 2;
            this.tabPageProduct.Text = "Manage Product";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(284, 428);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(160, 20);
            this.txtSearchProduct.TabIndex = 17;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(215, 431);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 16;
            this.label21.Text = "Search";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(309, 230);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "List of Product";
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(40, 253);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(614, 148);
            this.dgvProduct.TabIndex = 14;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // btnRefreshProduct
            // 
            this.btnRefreshProduct.Location = new System.Drawing.Point(534, 191);
            this.btnRefreshProduct.Name = "btnRefreshProduct";
            this.btnRefreshProduct.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshProduct.TabIndex = 13;
            this.btnRefreshProduct.Text = "Refresh";
            this.btnRefreshProduct.UseVisualStyleBackColor = true;
            this.btnRefreshProduct.Click += new System.EventHandler(this.btnRefreshProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(369, 191);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduct.TabIndex = 12;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(199, 191);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateProduct.TabIndex = 11;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(66, 191);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(407, 86);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(407, 29);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierID.TabIndex = 8;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(103, 140);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(100, 20);
            this.txtCategoryID.TabIndex = 7;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(103, 82);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 6;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(103, 29);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 20);
            this.txtProductID.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(335, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Price";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(335, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Supplier";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(37, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Category";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(37, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "ID";
            // 
            // tabPageStatistics
            // 
            this.tabPageStatistics.Controls.Add(this.label33);
            this.tabPageStatistics.Controls.Add(this.dgvStatistic);
            this.tabPageStatistics.Controls.Add(this.btnViewByCustomer);
            this.tabPageStatistics.Controls.Add(this.btnViewByDate);
            this.tabPageStatistics.Controls.Add(this.cbCustomerStatistic);
            this.tabPageStatistics.Controls.Add(this.label31);
            this.tabPageStatistics.Controls.Add(this.label30);
            this.tabPageStatistics.Controls.Add(this.label29);
            this.tabPageStatistics.Controls.Add(this.dtpTo);
            this.tabPageStatistics.Controls.Add(this.dtpFrom);
            this.tabPageStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageStatistics.Name = "tabPageStatistics";
            this.tabPageStatistics.Size = new System.Drawing.Size(675, 469);
            this.tabPageStatistics.TabIndex = 3;
            this.tabPageStatistics.Text = "Statistics";
            this.tabPageStatistics.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(308, 253);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(91, 13);
            this.label33.TabIndex = 11;
            this.label33.Text = "List of OrderDetail";
            // 
            // dgvStatistic
            // 
            this.dgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistic.Location = new System.Drawing.Point(49, 286);
            this.dgvStatistic.Name = "dgvStatistic";
            this.dgvStatistic.Size = new System.Drawing.Size(607, 153);
            this.dgvStatistic.TabIndex = 10;
            // 
            // btnViewByCustomer
            // 
            this.btnViewByCustomer.Location = new System.Drawing.Point(563, 126);
            this.btnViewByCustomer.Name = "btnViewByCustomer";
            this.btnViewByCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnViewByCustomer.TabIndex = 9;
            this.btnViewByCustomer.Text = "View";
            this.btnViewByCustomer.UseVisualStyleBackColor = true;
            this.btnViewByCustomer.Click += new System.EventHandler(this.btnViewByCustomer_Click);
            // 
            // btnViewByDate
            // 
            this.btnViewByDate.Location = new System.Drawing.Point(563, 70);
            this.btnViewByDate.Name = "btnViewByDate";
            this.btnViewByDate.Size = new System.Drawing.Size(75, 23);
            this.btnViewByDate.TabIndex = 8;
            this.btnViewByDate.Text = "View";
            this.btnViewByDate.UseVisualStyleBackColor = true;
            this.btnViewByDate.Click += new System.EventHandler(this.btnViewByDate_Click);
            // 
            // cbCustomerStatistic
            // 
            this.cbCustomerStatistic.FormattingEnabled = true;
            this.cbCustomerStatistic.Location = new System.Drawing.Point(103, 137);
            this.cbCustomerStatistic.Name = "cbCustomerStatistic";
            this.cbCustomerStatistic.Size = new System.Drawing.Size(121, 21);
            this.cbCustomerStatistic.TabIndex = 6;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(46, 140);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(51, 13);
            this.label31.TabIndex = 4;
            this.label31.Text = "Customer";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(287, 74);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(16, 13);
            this.label30.TabIndex = 3;
            this.label30.Text = "to";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(26, 75);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(30, 13);
            this.label29.TabIndex = 2;
            this.label29.Text = "Form";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(334, 68);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 1;
            this.dtpTo.Value = new System.DateTime(2025, 4, 2, 0, 0, 0, 0);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(73, 69);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(185, 20);
            this.dtpFrom.TabIndex = 0;
            this.dtpFrom.Value = new System.DateTime(2025, 4, 1, 0, 0, 0, 0);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCustomer);
            this.tabControl1.Controls.Add(this.tabPageProduct);
            this.tabControl1.Controls.Add(this.tabPageMakeOrder);
            this.tabControl1.Controls.Add(this.tabPageStatistics);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(683, 495);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageMakeOrder
            // 
            this.tabPageMakeOrder.Controls.Add(this.label24);
            this.tabPageMakeOrder.Controls.Add(this.label22);
            this.tabPageMakeOrder.Controls.Add(this.cbProduct);
            this.tabPageMakeOrder.Controls.Add(this.txtTotalAmount);
            this.tabPageMakeOrder.Controls.Add(this.txtQuantity);
            this.tabPageMakeOrder.Controls.Add(this.txtOrderDetailID);
            this.tabPageMakeOrder.Controls.Add(this.label26);
            this.tabPageMakeOrder.Controls.Add(this.label25);
            this.tabPageMakeOrder.Controls.Add(this.cbPaymentMethod);
            this.tabPageMakeOrder.Controls.Add(this.cbEmployee);
            this.tabPageMakeOrder.Controls.Add(this.cbCustomer);
            this.tabPageMakeOrder.Controls.Add(this.dgvOrder);
            this.tabPageMakeOrder.Controls.Add(this.btnRefreshOrder);
            this.tabPageMakeOrder.Controls.Add(this.btnMakeOrder);
            this.tabPageMakeOrder.Controls.Add(this.txtOrderDate);
            this.tabPageMakeOrder.Controls.Add(this.txtOrderID);
            this.tabPageMakeOrder.Controls.Add(this.label12);
            this.tabPageMakeOrder.Controls.Add(this.label11);
            this.tabPageMakeOrder.Controls.Add(this.label10);
            this.tabPageMakeOrder.Controls.Add(this.label9);
            this.tabPageMakeOrder.Controls.Add(this.label8);
            this.tabPageMakeOrder.Location = new System.Drawing.Point(4, 22);
            this.tabPageMakeOrder.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageMakeOrder.Name = "tabPageMakeOrder";
            this.tabPageMakeOrder.Size = new System.Drawing.Size(675, 469);
            this.tabPageMakeOrder.TabIndex = 4;
            this.tabPageMakeOrder.Text = "Make Order";
            this.tabPageMakeOrder.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(353, 85);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 13);
            this.label24.TabIndex = 31;
            this.label24.Text = "Product";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(49, 90);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 13);
            this.label22.TabIndex = 29;
            this.label22.Text = "OrderDetail ID";
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(447, 82);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(121, 21);
            this.cbProduct.TabIndex = 28;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(447, 172);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmount.TabIndex = 27;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(448, 129);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 26;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged_1);
            // 
            // txtOrderDetailID
            // 
            this.txtOrderDetailID.Location = new System.Drawing.Point(142, 83);
            this.txtOrderDetailID.Name = "txtOrderDetailID";
            this.txtOrderDetailID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderDetailID.TabIndex = 24;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(353, 172);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(67, 13);
            this.label26.TabIndex = 23;
            this.label26.Text = "TotalAmount";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(353, 129);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(46, 13);
            this.label25.TabIndex = 22;
            this.label25.Text = "Quantity";
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Location = new System.Drawing.Point(447, 40);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(121, 21);
            this.cbPaymentMethod.TabIndex = 21;
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(142, 214);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(121, 21);
            this.cbEmployee.TabIndex = 20;
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(142, 172);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbCustomer.TabIndex = 19;
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(46, 281);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(574, 134);
            this.dgvOrder.TabIndex = 15;
            this.dgvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellContentClick);
            // 
            // btnRefreshOrder
            // 
            this.btnRefreshOrder.Location = new System.Drawing.Point(550, 231);
            this.btnRefreshOrder.Name = "btnRefreshOrder";
            this.btnRefreshOrder.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshOrder.TabIndex = 14;
            this.btnRefreshOrder.Text = "Refresh";
            this.btnRefreshOrder.UseVisualStyleBackColor = true;
            this.btnRefreshOrder.Click += new System.EventHandler(this.btnRefreshOrder_Click);
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Location = new System.Drawing.Point(378, 231);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(75, 23);
            this.btnMakeOrder.TabIndex = 11;
            this.btnMakeOrder.Text = "Make Order";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(142, 129);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(100, 20);
            this.txtOrderDate.TabIndex = 8;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(142, 40);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderID.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(353, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "PaymentMethod";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Employee";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Customer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Order ID";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 495);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalesForm";
            this.Text = "SalesDashboard";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabPageCustomer.ResumeLayout(false);
            this.tabPageCustomer.PerformLayout();
            this.tabPageProduct.ResumeLayout(false);
            this.tabPageProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.tabPageStatistics.ResumeLayout(false);
            this.tabPageStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageMakeOrder.ResumeLayout(false);
            this.tabPageMakeOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.TabPage tabPageStatistics;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMakeOrder;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRefreshOrder;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnRefreshProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ComboBox cbCustomerStatistic;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnViewByCustomer;
        private System.Windows.Forms.Button btnViewByDate;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridView dgvStatistic;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtOrderDetailID;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
    }
}
