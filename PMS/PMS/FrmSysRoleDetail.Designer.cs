namespace PMS
{
    partial class FrmSysRoleDetail
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
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.lbl_role = new System.Windows.Forms.Label();
            this.grb_role = new System.Windows.Forms.GroupBox();
            this.grb_finance = new System.Windows.Forms.GroupBox();
            this.chk_finance_paid = new System.Windows.Forms.CheckBox();
            this.chk_finance_receive = new System.Windows.Forms.CheckBox();
            this.chk_finance_purchase = new System.Windows.Forms.CheckBox();
            this.chk_finance_sale = new System.Windows.Forms.CheckBox();
            this.chk_finance = new System.Windows.Forms.CheckBox();
            this.grb_purchase = new System.Windows.Forms.GroupBox();
            this.chk_purchase_order = new System.Windows.Forms.CheckBox();
            this.chk_purchase_plan = new System.Windows.Forms.CheckBox();
            this.chk_purchase_materials = new System.Windows.Forms.CheckBox();
            this.chk_purchase_provider = new System.Windows.Forms.CheckBox();
            this.chk_purchase = new System.Windows.Forms.CheckBox();
            this.grb_produce = new System.Windows.Forms.GroupBox();
            this.chk_produce_plan = new System.Windows.Forms.CheckBox();
            this.chk_produce = new System.Windows.Forms.CheckBox();
            this.grb_factory = new System.Windows.Forms.GroupBox();
            this.chk_factory_materials_out = new System.Windows.Forms.CheckBox();
            this.chk_factory_materials_in = new System.Windows.Forms.CheckBox();
            this.chk_factory_product_transfer = new System.Windows.Forms.CheckBox();
            this.chk_factory_product_out = new System.Windows.Forms.CheckBox();
            this.chk_factory_product_in = new System.Windows.Forms.CheckBox();
            this.chk_factory = new System.Windows.Forms.CheckBox();
            this.grb_sale = new System.Windows.Forms.GroupBox();
            this.chk_sale_order = new System.Windows.Forms.CheckBox();
            this.chk_sale_customer = new System.Windows.Forms.CheckBox();
            this.chk_sale = new System.Windows.Forms.CheckBox();
            this.chk_product = new System.Windows.Forms.CheckBox();
            this.grb_product = new System.Windows.Forms.GroupBox();
            this.chk_product_set = new System.Windows.Forms.CheckBox();
            this.chk_product_query = new System.Windows.Forms.CheckBox();
            this.chk_sys = new System.Windows.Forms.CheckBox();
            this.grb_sys = new System.Windows.Forms.GroupBox();
            this.chk_sys_role = new System.Windows.Forms.CheckBox();
            this.chk_sys_factory = new System.Windows.Forms.CheckBox();
            this.chk_sys_company = new System.Windows.Forms.CheckBox();
            this.chk_sys_user = new System.Windows.Forms.CheckBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.grb_role.SuspendLayout();
            this.grb_finance.SuspendLayout();
            this.grb_purchase.SuspendLayout();
            this.grb_produce.SuspendLayout();
            this.grb_factory.SuspendLayout();
            this.grb_sale.SuspendLayout();
            this.grb_product.SuspendLayout();
            this.grb_sys.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_role
            // 
            this.cmb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Location = new System.Drawing.Point(75, 17);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(121, 20);
            this.cmb_role.TabIndex = 1;
            this.cmb_role.SelectedIndexChanged += new System.EventHandler(this.cmb_role_SelectedIndexChanged);
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Location = new System.Drawing.Point(28, 20);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(41, 12);
            this.lbl_role.TabIndex = 11;
            this.lbl_role.Text = "角色：";
            // 
            // grb_role
            // 
            this.grb_role.Controls.Add(this.grb_finance);
            this.grb_role.Controls.Add(this.chk_finance);
            this.grb_role.Controls.Add(this.grb_purchase);
            this.grb_role.Controls.Add(this.chk_purchase);
            this.grb_role.Controls.Add(this.grb_produce);
            this.grb_role.Controls.Add(this.chk_produce);
            this.grb_role.Controls.Add(this.grb_factory);
            this.grb_role.Controls.Add(this.chk_factory);
            this.grb_role.Controls.Add(this.grb_sale);
            this.grb_role.Controls.Add(this.chk_sale);
            this.grb_role.Controls.Add(this.chk_product);
            this.grb_role.Controls.Add(this.grb_product);
            this.grb_role.Controls.Add(this.chk_sys);
            this.grb_role.Controls.Add(this.grb_sys);
            this.grb_role.Location = new System.Drawing.Point(30, 52);
            this.grb_role.Name = "grb_role";
            this.grb_role.Size = new System.Drawing.Size(867, 500);
            this.grb_role.TabIndex = 12;
            this.grb_role.TabStop = false;
            this.grb_role.Text = "菜单管理";
            // 
            // grb_finance
            // 
            this.grb_finance.Controls.Add(this.chk_finance_paid);
            this.grb_finance.Controls.Add(this.chk_finance_receive);
            this.grb_finance.Controls.Add(this.chk_finance_purchase);
            this.grb_finance.Controls.Add(this.chk_finance_sale);
            this.grb_finance.Enabled = false;
            this.grb_finance.Location = new System.Drawing.Point(33, 454);
            this.grb_finance.Name = "grb_finance";
            this.grb_finance.Size = new System.Drawing.Size(800, 40);
            this.grb_finance.TabIndex = 13;
            this.grb_finance.TabStop = false;
            // 
            // chk_finance_paid
            // 
            this.chk_finance_paid.AutoSize = true;
            this.chk_finance_paid.Location = new System.Drawing.Point(367, 17);
            this.chk_finance_paid.Name = "chk_finance_paid";
            this.chk_finance_paid.Size = new System.Drawing.Size(60, 16);
            this.chk_finance_paid.TabIndex = 30;
            this.chk_finance_paid.Text = "应付款";
            this.chk_finance_paid.UseVisualStyleBackColor = true;
            // 
            // chk_finance_receive
            // 
            this.chk_finance_receive.AutoSize = true;
            this.chk_finance_receive.Location = new System.Drawing.Point(249, 17);
            this.chk_finance_receive.Name = "chk_finance_receive";
            this.chk_finance_receive.Size = new System.Drawing.Size(60, 16);
            this.chk_finance_receive.TabIndex = 29;
            this.chk_finance_receive.Text = "应收款";
            this.chk_finance_receive.UseVisualStyleBackColor = true;
            // 
            // chk_finance_purchase
            // 
            this.chk_finance_purchase.AutoSize = true;
            this.chk_finance_purchase.Location = new System.Drawing.Point(137, 17);
            this.chk_finance_purchase.Name = "chk_finance_purchase";
            this.chk_finance_purchase.Size = new System.Drawing.Size(72, 16);
            this.chk_finance_purchase.TabIndex = 28;
            this.chk_finance_purchase.Text = "采购报表";
            this.chk_finance_purchase.UseVisualStyleBackColor = true;
            // 
            // chk_finance_sale
            // 
            this.chk_finance_sale.AutoSize = true;
            this.chk_finance_sale.Location = new System.Drawing.Point(20, 17);
            this.chk_finance_sale.Name = "chk_finance_sale";
            this.chk_finance_sale.Size = new System.Drawing.Size(72, 16);
            this.chk_finance_sale.TabIndex = 27;
            this.chk_finance_sale.Text = "销售报表";
            this.chk_finance_sale.UseVisualStyleBackColor = true;
            // 
            // chk_finance
            // 
            this.chk_finance.AutoSize = true;
            this.chk_finance.Location = new System.Drawing.Point(33, 438);
            this.chk_finance.Name = "chk_finance";
            this.chk_finance.Size = new System.Drawing.Size(72, 16);
            this.chk_finance.TabIndex = 26;
            this.chk_finance.Text = "财务管理";
            this.chk_finance.UseVisualStyleBackColor = true;
            this.chk_finance.CheckedChanged += new System.EventHandler(this.chk_finance_CheckedChanged);
            // 
            // grb_purchase
            // 
            this.grb_purchase.Controls.Add(this.chk_purchase_order);
            this.grb_purchase.Controls.Add(this.chk_purchase_plan);
            this.grb_purchase.Controls.Add(this.chk_purchase_materials);
            this.grb_purchase.Controls.Add(this.chk_purchase_provider);
            this.grb_purchase.Enabled = false;
            this.grb_purchase.Location = new System.Drawing.Point(33, 381);
            this.grb_purchase.Name = "grb_purchase";
            this.grb_purchase.Size = new System.Drawing.Size(800, 40);
            this.grb_purchase.TabIndex = 11;
            this.grb_purchase.TabStop = false;
            // 
            // chk_purchase_order
            // 
            this.chk_purchase_order.AutoSize = true;
            this.chk_purchase_order.Location = new System.Drawing.Point(368, 17);
            this.chk_purchase_order.Name = "chk_purchase_order";
            this.chk_purchase_order.Size = new System.Drawing.Size(72, 16);
            this.chk_purchase_order.TabIndex = 25;
            this.chk_purchase_order.Text = "采购订单";
            this.chk_purchase_order.UseVisualStyleBackColor = true;
            // 
            // chk_purchase_plan
            // 
            this.chk_purchase_plan.AutoSize = true;
            this.chk_purchase_plan.Location = new System.Drawing.Point(250, 17);
            this.chk_purchase_plan.Name = "chk_purchase_plan";
            this.chk_purchase_plan.Size = new System.Drawing.Size(72, 16);
            this.chk_purchase_plan.TabIndex = 24;
            this.chk_purchase_plan.Text = "采购计划";
            this.chk_purchase_plan.UseVisualStyleBackColor = true;
            // 
            // chk_purchase_materials
            // 
            this.chk_purchase_materials.AutoSize = true;
            this.chk_purchase_materials.Location = new System.Drawing.Point(137, 17);
            this.chk_purchase_materials.Name = "chk_purchase_materials";
            this.chk_purchase_materials.Size = new System.Drawing.Size(72, 16);
            this.chk_purchase_materials.TabIndex = 23;
            this.chk_purchase_materials.Text = "原料管理";
            this.chk_purchase_materials.UseVisualStyleBackColor = true;
            // 
            // chk_purchase_provider
            // 
            this.chk_purchase_provider.AutoSize = true;
            this.chk_purchase_provider.Location = new System.Drawing.Point(20, 17);
            this.chk_purchase_provider.Name = "chk_purchase_provider";
            this.chk_purchase_provider.Size = new System.Drawing.Size(84, 16);
            this.chk_purchase_provider.TabIndex = 22;
            this.chk_purchase_provider.Text = "供应商管理";
            this.chk_purchase_provider.UseVisualStyleBackColor = true;
            // 
            // chk_purchase
            // 
            this.chk_purchase.AutoSize = true;
            this.chk_purchase.Location = new System.Drawing.Point(33, 365);
            this.chk_purchase.Name = "chk_purchase";
            this.chk_purchase.Size = new System.Drawing.Size(72, 16);
            this.chk_purchase.TabIndex = 21;
            this.chk_purchase.Text = "采购管理";
            this.chk_purchase.UseVisualStyleBackColor = true;
            this.chk_purchase.CheckedChanged += new System.EventHandler(this.chk_purchase_CheckedChanged);
            // 
            // grb_produce
            // 
            this.grb_produce.Controls.Add(this.chk_produce_plan);
            this.grb_produce.Enabled = false;
            this.grb_produce.Location = new System.Drawing.Point(33, 311);
            this.grb_produce.Name = "grb_produce";
            this.grb_produce.Size = new System.Drawing.Size(800, 40);
            this.grb_produce.TabIndex = 9;
            this.grb_produce.TabStop = false;
            // 
            // chk_produce_plan
            // 
            this.chk_produce_plan.AutoSize = true;
            this.chk_produce_plan.Location = new System.Drawing.Point(20, 15);
            this.chk_produce_plan.Name = "chk_produce_plan";
            this.chk_produce_plan.Size = new System.Drawing.Size(72, 16);
            this.chk_produce_plan.TabIndex = 20;
            this.chk_produce_plan.Text = "生产计划";
            this.chk_produce_plan.UseVisualStyleBackColor = true;
            // 
            // chk_produce
            // 
            this.chk_produce.AutoSize = true;
            this.chk_produce.Location = new System.Drawing.Point(33, 294);
            this.chk_produce.Name = "chk_produce";
            this.chk_produce.Size = new System.Drawing.Size(72, 16);
            this.chk_produce.TabIndex = 19;
            this.chk_produce.Text = "生产管理";
            this.chk_produce.UseVisualStyleBackColor = true;
            this.chk_produce.CheckedChanged += new System.EventHandler(this.chk_produce_CheckedChanged);
            // 
            // grb_factory
            // 
            this.grb_factory.Controls.Add(this.chk_factory_materials_out);
            this.grb_factory.Controls.Add(this.chk_factory_materials_in);
            this.grb_factory.Controls.Add(this.chk_factory_product_transfer);
            this.grb_factory.Controls.Add(this.chk_factory_product_out);
            this.grb_factory.Controls.Add(this.chk_factory_product_in);
            this.grb_factory.Enabled = false;
            this.grb_factory.Location = new System.Drawing.Point(33, 237);
            this.grb_factory.Name = "grb_factory";
            this.grb_factory.Size = new System.Drawing.Size(800, 40);
            this.grb_factory.TabIndex = 7;
            this.grb_factory.TabStop = false;
            // 
            // chk_factory_materials_out
            // 
            this.chk_factory_materials_out.AutoSize = true;
            this.chk_factory_materials_out.Location = new System.Drawing.Point(481, 15);
            this.chk_factory_materials_out.Name = "chk_factory_materials_out";
            this.chk_factory_materials_out.Size = new System.Drawing.Size(72, 16);
            this.chk_factory_materials_out.TabIndex = 18;
            this.chk_factory_materials_out.Text = "原来出库";
            this.chk_factory_materials_out.UseVisualStyleBackColor = true;
            // 
            // chk_factory_materials_in
            // 
            this.chk_factory_materials_in.AutoSize = true;
            this.chk_factory_materials_in.Location = new System.Drawing.Point(368, 15);
            this.chk_factory_materials_in.Name = "chk_factory_materials_in";
            this.chk_factory_materials_in.Size = new System.Drawing.Size(72, 16);
            this.chk_factory_materials_in.TabIndex = 17;
            this.chk_factory_materials_in.Text = "原料入库";
            this.chk_factory_materials_in.UseVisualStyleBackColor = true;
            // 
            // chk_factory_product_transfer
            // 
            this.chk_factory_product_transfer.AutoSize = true;
            this.chk_factory_product_transfer.Location = new System.Drawing.Point(250, 15);
            this.chk_factory_product_transfer.Name = "chk_factory_product_transfer";
            this.chk_factory_product_transfer.Size = new System.Drawing.Size(72, 16);
            this.chk_factory_product_transfer.TabIndex = 16;
            this.chk_factory_product_transfer.Text = "商品调拨";
            this.chk_factory_product_transfer.UseVisualStyleBackColor = true;
            // 
            // chk_factory_product_out
            // 
            this.chk_factory_product_out.AutoSize = true;
            this.chk_factory_product_out.Location = new System.Drawing.Point(137, 15);
            this.chk_factory_product_out.Name = "chk_factory_product_out";
            this.chk_factory_product_out.Size = new System.Drawing.Size(72, 16);
            this.chk_factory_product_out.TabIndex = 15;
            this.chk_factory_product_out.Text = "商品出库";
            this.chk_factory_product_out.UseVisualStyleBackColor = true;
            // 
            // chk_factory_product_in
            // 
            this.chk_factory_product_in.AutoSize = true;
            this.chk_factory_product_in.Location = new System.Drawing.Point(20, 15);
            this.chk_factory_product_in.Name = "chk_factory_product_in";
            this.chk_factory_product_in.Size = new System.Drawing.Size(72, 16);
            this.chk_factory_product_in.TabIndex = 14;
            this.chk_factory_product_in.Text = "商品入库";
            this.chk_factory_product_in.UseVisualStyleBackColor = true;
            // 
            // chk_factory
            // 
            this.chk_factory.AutoSize = true;
            this.chk_factory.Location = new System.Drawing.Point(33, 222);
            this.chk_factory.Name = "chk_factory";
            this.chk_factory.Size = new System.Drawing.Size(72, 16);
            this.chk_factory.TabIndex = 13;
            this.chk_factory.Text = "库存管理";
            this.chk_factory.UseVisualStyleBackColor = true;
            this.chk_factory.CheckedChanged += new System.EventHandler(this.chk_factory_CheckedChanged);
            // 
            // grb_sale
            // 
            this.grb_sale.Controls.Add(this.chk_sale_order);
            this.grb_sale.Controls.Add(this.chk_sale_customer);
            this.grb_sale.Enabled = false;
            this.grb_sale.Location = new System.Drawing.Point(34, 169);
            this.grb_sale.Name = "grb_sale";
            this.grb_sale.Size = new System.Drawing.Size(800, 40);
            this.grb_sale.TabIndex = 5;
            this.grb_sale.TabStop = false;
            // 
            // chk_sale_order
            // 
            this.chk_sale_order.AutoSize = true;
            this.chk_sale_order.Location = new System.Drawing.Point(137, 15);
            this.chk_sale_order.Name = "chk_sale_order";
            this.chk_sale_order.Size = new System.Drawing.Size(72, 16);
            this.chk_sale_order.TabIndex = 12;
            this.chk_sale_order.Text = "订单管理";
            this.chk_sale_order.UseVisualStyleBackColor = true;
            // 
            // chk_sale_customer
            // 
            this.chk_sale_customer.AutoSize = true;
            this.chk_sale_customer.Location = new System.Drawing.Point(20, 15);
            this.chk_sale_customer.Name = "chk_sale_customer";
            this.chk_sale_customer.Size = new System.Drawing.Size(72, 16);
            this.chk_sale_customer.TabIndex = 11;
            this.chk_sale_customer.Text = "客户管理";
            this.chk_sale_customer.UseVisualStyleBackColor = true;
            // 
            // chk_sale
            // 
            this.chk_sale.AutoSize = true;
            this.chk_sale.Location = new System.Drawing.Point(33, 154);
            this.chk_sale.Name = "chk_sale";
            this.chk_sale.Size = new System.Drawing.Size(72, 16);
            this.chk_sale.TabIndex = 10;
            this.chk_sale.Text = "销售管理";
            this.chk_sale.UseVisualStyleBackColor = true;
            this.chk_sale.CheckedChanged += new System.EventHandler(this.chk_sale_CheckedChanged);
            // 
            // chk_product
            // 
            this.chk_product.AutoSize = true;
            this.chk_product.Location = new System.Drawing.Point(33, 86);
            this.chk_product.Name = "chk_product";
            this.chk_product.Size = new System.Drawing.Size(72, 16);
            this.chk_product.TabIndex = 7;
            this.chk_product.Text = "商品管理";
            this.chk_product.UseVisualStyleBackColor = true;
            this.chk_product.CheckedChanged += new System.EventHandler(this.chk_product_CheckedChanged);
            // 
            // grb_product
            // 
            this.grb_product.Controls.Add(this.chk_product_set);
            this.grb_product.Controls.Add(this.chk_product_query);
            this.grb_product.Enabled = false;
            this.grb_product.Location = new System.Drawing.Point(33, 102);
            this.grb_product.Name = "grb_product";
            this.grb_product.Size = new System.Drawing.Size(800, 40);
            this.grb_product.TabIndex = 3;
            this.grb_product.TabStop = false;
            // 
            // chk_product_set
            // 
            this.chk_product_set.AutoSize = true;
            this.chk_product_set.Location = new System.Drawing.Point(138, 16);
            this.chk_product_set.Name = "chk_product_set";
            this.chk_product_set.Size = new System.Drawing.Size(96, 16);
            this.chk_product_set.TabIndex = 9;
            this.chk_product_set.Text = "设置商品信息";
            this.chk_product_set.UseVisualStyleBackColor = true;
            // 
            // chk_product_query
            // 
            this.chk_product_query.AutoSize = true;
            this.chk_product_query.Location = new System.Drawing.Point(21, 16);
            this.chk_product_query.Name = "chk_product_query";
            this.chk_product_query.Size = new System.Drawing.Size(96, 16);
            this.chk_product_query.TabIndex = 8;
            this.chk_product_query.Text = "查询销售商品";
            this.chk_product_query.UseVisualStyleBackColor = true;
            // 
            // chk_sys
            // 
            this.chk_sys.AutoSize = true;
            this.chk_sys.Location = new System.Drawing.Point(34, 20);
            this.chk_sys.Name = "chk_sys";
            this.chk_sys.Size = new System.Drawing.Size(72, 16);
            this.chk_sys.TabIndex = 2;
            this.chk_sys.Tag = "1";
            this.chk_sys.Text = "系统设置";
            this.chk_sys.UseVisualStyleBackColor = true;
            this.chk_sys.CheckedChanged += new System.EventHandler(this.chk_sys_CheckedChanged);
            // 
            // grb_sys
            // 
            this.grb_sys.Controls.Add(this.chk_sys_role);
            this.grb_sys.Controls.Add(this.chk_sys_factory);
            this.grb_sys.Controls.Add(this.chk_sys_company);
            this.grb_sys.Controls.Add(this.chk_sys_user);
            this.grb_sys.Enabled = false;
            this.grb_sys.Location = new System.Drawing.Point(34, 34);
            this.grb_sys.Name = "grb_sys";
            this.grb_sys.Size = new System.Drawing.Size(800, 40);
            this.grb_sys.TabIndex = 1;
            this.grb_sys.TabStop = false;
            // 
            // chk_sys_role
            // 
            this.chk_sys_role.AutoSize = true;
            this.chk_sys_role.Location = new System.Drawing.Point(137, 15);
            this.chk_sys_role.Name = "chk_sys_role";
            this.chk_sys_role.Size = new System.Drawing.Size(72, 16);
            this.chk_sys_role.TabIndex = 6;
            this.chk_sys_role.Text = "角色管理";
            this.chk_sys_role.UseVisualStyleBackColor = true;
            // 
            // chk_sys_factory
            // 
            this.chk_sys_factory.AutoSize = true;
            this.chk_sys_factory.Location = new System.Drawing.Point(249, 15);
            this.chk_sys_factory.Name = "chk_sys_factory";
            this.chk_sys_factory.Size = new System.Drawing.Size(72, 16);
            this.chk_sys_factory.TabIndex = 5;
            this.chk_sys_factory.Text = "库房管理";
            this.chk_sys_factory.UseVisualStyleBackColor = true;
            // 
            // chk_sys_company
            // 
            this.chk_sys_company.AutoSize = true;
            this.chk_sys_company.Location = new System.Drawing.Point(367, 15);
            this.chk_sys_company.Name = "chk_sys_company";
            this.chk_sys_company.Size = new System.Drawing.Size(72, 16);
            this.chk_sys_company.TabIndex = 4;
            this.chk_sys_company.Text = "公司信息";
            this.chk_sys_company.UseVisualStyleBackColor = true;
            // 
            // chk_sys_user
            // 
            this.chk_sys_user.AutoSize = true;
            this.chk_sys_user.Location = new System.Drawing.Point(20, 15);
            this.chk_sys_user.Name = "chk_sys_user";
            this.chk_sys_user.Size = new System.Drawing.Size(72, 16);
            this.chk_sys_user.TabIndex = 3;
            this.chk_sys_user.Tag = "101";
            this.chk_sys_user.Text = "用户管理";
            this.chk_sys_user.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(300, 565);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 50;
            this.btn_submit.Text = "确定";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(518, 565);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 51;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // FrmSysRoleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.grb_role);
            this.Controls.Add(this.cmb_role);
            this.Controls.Add(this.lbl_role);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSysRoleDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmSysUser_Load);
            this.grb_role.ResumeLayout(false);
            this.grb_role.PerformLayout();
            this.grb_finance.ResumeLayout(false);
            this.grb_finance.PerformLayout();
            this.grb_purchase.ResumeLayout(false);
            this.grb_purchase.PerformLayout();
            this.grb_produce.ResumeLayout(false);
            this.grb_produce.PerformLayout();
            this.grb_factory.ResumeLayout(false);
            this.grb_factory.PerformLayout();
            this.grb_sale.ResumeLayout(false);
            this.grb_sale.PerformLayout();
            this.grb_product.ResumeLayout(false);
            this.grb_product.PerformLayout();
            this.grb_sys.ResumeLayout(false);
            this.grb_sys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_role;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.GroupBox grb_role;
        private System.Windows.Forms.GroupBox grb_finance;
        private System.Windows.Forms.CheckBox chk_finance_paid;
        private System.Windows.Forms.CheckBox chk_finance_receive;
        private System.Windows.Forms.CheckBox chk_finance_purchase;
        private System.Windows.Forms.CheckBox chk_finance_sale;
        private System.Windows.Forms.CheckBox chk_finance;
        private System.Windows.Forms.GroupBox grb_purchase;
        private System.Windows.Forms.CheckBox chk_purchase_order;
        private System.Windows.Forms.CheckBox chk_purchase_plan;
        private System.Windows.Forms.CheckBox chk_purchase_materials;
        private System.Windows.Forms.CheckBox chk_purchase_provider;
        private System.Windows.Forms.GroupBox grb_produce;
        private System.Windows.Forms.CheckBox chk_produce_plan;
        private System.Windows.Forms.CheckBox chk_produce;
        private System.Windows.Forms.GroupBox grb_factory;
        private System.Windows.Forms.CheckBox chk_factory_materials_out;
        private System.Windows.Forms.CheckBox chk_factory_materials_in;
        private System.Windows.Forms.CheckBox chk_factory_product_transfer;
        private System.Windows.Forms.CheckBox chk_factory_product_out;
        private System.Windows.Forms.CheckBox chk_factory_product_in;
        private System.Windows.Forms.CheckBox chk_factory;
        private System.Windows.Forms.GroupBox grb_sale;
        private System.Windows.Forms.CheckBox chk_sale_order;
        private System.Windows.Forms.CheckBox chk_sale_customer;
        private System.Windows.Forms.CheckBox chk_sale;
        private System.Windows.Forms.CheckBox chk_product;
        private System.Windows.Forms.GroupBox grb_product;
        private System.Windows.Forms.CheckBox chk_product_set;
        private System.Windows.Forms.CheckBox chk_product_query;
        private System.Windows.Forms.CheckBox chk_sys;
        private System.Windows.Forms.GroupBox grb_sys;
        private System.Windows.Forms.CheckBox chk_sys_role;
        private System.Windows.Forms.CheckBox chk_sys_factory;
        private System.Windows.Forms.CheckBox chk_sys_company;
        private System.Windows.Forms.CheckBox chk_sys_user;
        private System.Windows.Forms.CheckBox chk_purchase;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;

    }
}