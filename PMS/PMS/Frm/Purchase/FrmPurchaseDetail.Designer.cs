namespace PMS.Frm.Purchase
{
    partial class FrmPurchaseDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPurchaseDetail));
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_purchase = new System.Windows.Forms.GroupBox();
            this.cmb_factory = new System.Windows.Forms.ComboBox();
            this.cmb_materials = new System.Windows.Forms.ComboBox();
            this.dtp_applyDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_applyBy = new System.Windows.Forms.ComboBox();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_unit = new System.Windows.Forms.ComboBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.cmb_supplier = new System.Windows.Forms.ComboBox();
            this.lbl_outputStatus = new System.Windows.Forms.Label();
            this.lbl_outputType = new System.Windows.Forms.Label();
            this.lbl_applyMember = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grb_address = new System.Windows.Forms.GroupBox();
            this.txt_telephone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_manager = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_province = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_district = new System.Windows.Forms.ComboBox();
            this.lbl_orderCode = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.grb_finance = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grb_purchase.SuspendLayout();
            this.grb_address.SuspendLayout();
            this.grb_finance.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(256, 512);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 101;
            this.btn_submit.Text = "确认";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(383, 512);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 102;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_title.Location = new System.Drawing.Point(293, 44);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(96, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "采购单";
            // 
            // grb_purchase
            // 
            this.grb_purchase.Controls.Add(this.cmb_factory);
            this.grb_purchase.Controls.Add(this.cmb_materials);
            this.grb_purchase.Controls.Add(this.dtp_applyDate);
            this.grb_purchase.Controls.Add(this.cmb_applyBy);
            this.grb_purchase.Controls.Add(this.txt_remark);
            this.grb_purchase.Controls.Add(this.label9);
            this.grb_purchase.Controls.Add(this.cmb_unit);
            this.grb_purchase.Controls.Add(this.txt_num);
            this.grb_purchase.Controls.Add(this.label1);
            this.grb_purchase.Controls.Add(this.label8);
            this.grb_purchase.Controls.Add(this.label7);
            this.grb_purchase.Controls.Add(this.dtp_deliveryDate);
            this.grb_purchase.Controls.Add(this.label11);
            this.grb_purchase.Controls.Add(this.cmb_status);
            this.grb_purchase.Controls.Add(this.cmb_type);
            this.grb_purchase.Controls.Add(this.cmb_supplier);
            this.grb_purchase.Controls.Add(this.lbl_outputStatus);
            this.grb_purchase.Controls.Add(this.lbl_outputType);
            this.grb_purchase.Controls.Add(this.lbl_applyMember);
            this.grb_purchase.Controls.Add(this.label10);
            this.grb_purchase.Controls.Add(this.grb_address);
            this.grb_purchase.Controls.Add(this.lbl_orderCode);
            this.grb_purchase.Location = new System.Drawing.Point(31, 85);
            this.grb_purchase.Name = "grb_purchase";
            this.grb_purchase.Size = new System.Drawing.Size(634, 347);
            this.grb_purchase.TabIndex = 103;
            this.grb_purchase.TabStop = false;
            // 
            // cmb_factory
            // 
            this.cmb_factory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_factory.FormattingEnabled = true;
            this.cmb_factory.Items.AddRange(new object[] {
            "生产申请",
            "特殊申请"});
            this.cmb_factory.Location = new System.Drawing.Point(385, 84);
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.Size = new System.Drawing.Size(221, 20);
            this.cmb_factory.TabIndex = 133;
            // 
            // cmb_materials
            // 
            this.cmb_materials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_materials.FormattingEnabled = true;
            this.cmb_materials.Items.AddRange(new object[] {
            "生产申请",
            "特殊申请"});
            this.cmb_materials.Location = new System.Drawing.Point(77, 84);
            this.cmb_materials.Name = "cmb_materials";
            this.cmb_materials.Size = new System.Drawing.Size(221, 20);
            this.cmb_materials.TabIndex = 132;
            // 
            // dtp_applyDate
            // 
            this.dtp_applyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_applyDate.Location = new System.Drawing.Point(384, 54);
            this.dtp_applyDate.Name = "dtp_applyDate";
            this.dtp_applyDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_applyDate.TabIndex = 131;
            // 
            // cmb_applyBy
            // 
            this.cmb_applyBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_applyBy.FormattingEnabled = true;
            this.cmb_applyBy.Items.AddRange(new object[] {
            "生产申请",
            "特殊申请"});
            this.cmb_applyBy.Location = new System.Drawing.Point(77, 55);
            this.cmb_applyBy.Name = "cmb_applyBy";
            this.cmb_applyBy.Size = new System.Drawing.Size(221, 20);
            this.cmb_applyBy.TabIndex = 130;
            // 
            // txt_remark
            // 
            this.txt_remark.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_remark.Location = new System.Drawing.Point(77, 313);
            this.txt_remark.MaxLength = 20;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(529, 21);
            this.txt_remark.TabIndex = 121;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(16, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 122;
            this.label9.Text = "备    注：";
            // 
            // cmb_unit
            // 
            this.cmb_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_unit.FormattingEnabled = true;
            this.cmb_unit.Location = new System.Drawing.Point(245, 115);
            this.cmb_unit.Name = "cmb_unit";
            this.cmb_unit.Size = new System.Drawing.Size(55, 20);
            this.cmb_unit.TabIndex = 129;
            // 
            // txt_num
            // 
            this.txt_num.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_num.Location = new System.Drawing.Point(78, 114);
            this.txt_num.MaxLength = 20;
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(164, 21);
            this.txt_num.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 128;
            this.label1.Text = "采购数量：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(320, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 126;
            this.label8.Text = "申请日期：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(320, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 123;
            this.label7.Text = "存储工厂：";
            // 
            // dtp_deliveryDate
            // 
            this.dtp_deliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_deliveryDate.Location = new System.Drawing.Point(384, 114);
            this.dtp_deliveryDate.Name = "dtp_deliveryDate";
            this.dtp_deliveryDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_deliveryDate.TabIndex = 118;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(320, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 119;
            this.label11.Text = "交货日期：";
            // 
            // cmb_status
            // 
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.Enabled = false;
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "财务未确认",
            "财务已确认",
            "物料已入库"});
            this.cmb_status.Location = new System.Drawing.Point(384, 25);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(222, 20);
            this.cmb_status.TabIndex = 117;
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.Enabled = false;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "生产申请",
            "特殊申请"});
            this.cmb_type.Location = new System.Drawing.Point(77, 25);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(221, 20);
            this.cmb_type.TabIndex = 116;
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.cmb_type_SelectedIndexChanged);
            // 
            // cmb_supplier
            // 
            this.cmb_supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_supplier.FormattingEnabled = true;
            this.cmb_supplier.Location = new System.Drawing.Point(76, 145);
            this.cmb_supplier.Name = "cmb_supplier";
            this.cmb_supplier.Size = new System.Drawing.Size(221, 20);
            this.cmb_supplier.TabIndex = 1;
            this.cmb_supplier.SelectedIndexChanged += new System.EventHandler(this.cmb_supplier_SelectedIndexChanged);
            // 
            // lbl_outputStatus
            // 
            this.lbl_outputStatus.AutoSize = true;
            this.lbl_outputStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_outputStatus.Location = new System.Drawing.Point(320, 29);
            this.lbl_outputStatus.Name = "lbl_outputStatus";
            this.lbl_outputStatus.Size = new System.Drawing.Size(65, 12);
            this.lbl_outputStatus.TabIndex = 115;
            this.lbl_outputStatus.Text = "采购状态：";
            // 
            // lbl_outputType
            // 
            this.lbl_outputType.AutoSize = true;
            this.lbl_outputType.ForeColor = System.Drawing.Color.Red;
            this.lbl_outputType.Location = new System.Drawing.Point(16, 28);
            this.lbl_outputType.Name = "lbl_outputType";
            this.lbl_outputType.Size = new System.Drawing.Size(65, 12);
            this.lbl_outputType.TabIndex = 113;
            this.lbl_outputType.Text = "申请种类：";
            // 
            // lbl_applyMember
            // 
            this.lbl_applyMember.AutoSize = true;
            this.lbl_applyMember.ForeColor = System.Drawing.Color.Red;
            this.lbl_applyMember.Location = new System.Drawing.Point(16, 58);
            this.lbl_applyMember.Name = "lbl_applyMember";
            this.lbl_applyMember.Size = new System.Drawing.Size(65, 12);
            this.lbl_applyMember.TabIndex = 112;
            this.lbl_applyMember.Text = "申 请 者：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(16, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 79;
            this.label10.Text = "供 应 商：";
            // 
            // grb_address
            // 
            this.grb_address.Controls.Add(this.txt_telephone);
            this.grb_address.Controls.Add(this.label2);
            this.grb_address.Controls.Add(this.txt_manager);
            this.grb_address.Controls.Add(this.label5);
            this.grb_address.Controls.Add(this.label13);
            this.grb_address.Controls.Add(this.label6);
            this.grb_address.Controls.Add(this.cmb_province);
            this.grb_address.Controls.Add(this.label4);
            this.grb_address.Controls.Add(this.cmb_city);
            this.grb_address.Controls.Add(this.txt_address);
            this.grb_address.Controls.Add(this.label3);
            this.grb_address.Controls.Add(this.cmb_district);
            this.grb_address.ForeColor = System.Drawing.Color.Red;
            this.grb_address.Location = new System.Drawing.Point(9, 172);
            this.grb_address.Name = "grb_address";
            this.grb_address.Size = new System.Drawing.Size(610, 130);
            this.grb_address.TabIndex = 73;
            this.grb_address.TabStop = false;
            this.grb_address.Text = "地  址：";
            // 
            // txt_telephone
            // 
            this.txt_telephone.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_telephone.Location = new System.Drawing.Point(385, 90);
            this.txt_telephone.MaxLength = 20;
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(212, 21);
            this.txt_telephone.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(311, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 71;
            this.label2.Text = "联系电话：";
            // 
            // txt_manager
            // 
            this.txt_manager.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_manager.Location = new System.Drawing.Point(67, 90);
            this.txt_manager.MaxLength = 20;
            this.txt_manager.Name = "txt_manager";
            this.txt_manager.Size = new System.Drawing.Size(223, 21);
            this.txt_manager.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 69;
            this.label5.Text = "联 系 人：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(408, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 64;
            this.label13.Text = "区：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 56;
            this.label6.Text = "省：";
            // 
            // cmb_province
            // 
            this.cmb_province.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_province.FormattingEnabled = true;
            this.cmb_province.Location = new System.Drawing.Point(68, 23);
            this.cmb_province.Name = "cmb_province";
            this.cmb_province.Size = new System.Drawing.Size(115, 20);
            this.cmb_province.TabIndex = 3;
            this.cmb_province.SelectedIndexChanged += new System.EventHandler(this.cmb_province_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 49;
            this.label4.Text = "市：";
            // 
            // cmb_city
            // 
            this.cmb_city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Location = new System.Drawing.Point(244, 23);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(115, 20);
            this.cmb_city.TabIndex = 4;
            this.cmb_city.SelectedIndexChanged += new System.EventHandler(this.cmb_city_SelectedIndexChanged);
            // 
            // txt_address
            // 
            this.txt_address.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_address.Location = new System.Drawing.Point(66, 53);
            this.txt_address.MaxLength = 20;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(531, 21);
            this.txt_address.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 63;
            this.label3.Text = "地    址：";
            // 
            // cmb_district
            // 
            this.cmb_district.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_district.FormattingEnabled = true;
            this.cmb_district.Location = new System.Drawing.Point(443, 23);
            this.cmb_district.Name = "cmb_district";
            this.cmb_district.Size = new System.Drawing.Size(115, 20);
            this.cmb_district.TabIndex = 4;
            // 
            // lbl_orderCode
            // 
            this.lbl_orderCode.AutoSize = true;
            this.lbl_orderCode.ForeColor = System.Drawing.Color.Red;
            this.lbl_orderCode.Location = new System.Drawing.Point(16, 87);
            this.lbl_orderCode.Name = "lbl_orderCode";
            this.lbl_orderCode.Size = new System.Drawing.Size(65, 12);
            this.lbl_orderCode.TabIndex = 42;
            this.lbl_orderCode.Text = "采购物料：";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(562, 512);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 106;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // grb_finance
            // 
            this.grb_finance.Controls.Add(this.label14);
            this.grb_finance.Controls.Add(this.txt_price);
            this.grb_finance.Controls.Add(this.label12);
            this.grb_finance.Location = new System.Drawing.Point(31, 437);
            this.grb_finance.Name = "grb_finance";
            this.grb_finance.Size = new System.Drawing.Size(634, 53);
            this.grb_finance.TabIndex = 115;
            this.grb_finance.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(177, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 12);
            this.label14.TabIndex = 117;
            this.label14.Text = "RMB";
            // 
            // txt_price
            // 
            this.txt_price.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_price.Location = new System.Drawing.Point(77, 18);
            this.txt_price.MaxLength = 10;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(95, 21);
            this.txt_price.TabIndex = 115;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(10, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 116;
            this.label12.Text = "采购价格：";
            // 
            // FrmPurchaseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(702, 550);
            this.Controls.Add(this.grb_finance);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.grb_purchase);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPurchaseDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采购管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPurchaseDetail_FormClosed);
            this.Load += new System.EventHandler(this.FrmPurchaseDetail_Load);
            this.grb_purchase.ResumeLayout(false);
            this.grb_purchase.PerformLayout();
            this.grb_address.ResumeLayout(false);
            this.grb_address.PerformLayout();
            this.grb_finance.ResumeLayout(false);
            this.grb_finance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_purchase;
        private System.Windows.Forms.ComboBox cmb_district;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_province;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_orderCode;
        private System.Windows.Forms.GroupBox grb_address;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_supplier;
        private System.Windows.Forms.TextBox txt_telephone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_manager;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_outputStatus;
        private System.Windows.Forms.Label lbl_outputType;
        private System.Windows.Forms.Label lbl_applyMember;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.DateTimePicker dtp_deliveryDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_unit;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_finance;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_applyBy;
        private System.Windows.Forms.ComboBox cmb_factory;
        private System.Windows.Forms.ComboBox cmb_materials;
        private System.Windows.Forms.DateTimePicker dtp_applyDate;
        private System.Windows.Forms.Label label14;
    }
}