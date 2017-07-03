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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPurchaseDetail));
            this.btn_print_jx = new System.Windows.Forms.Button();
            this.btn_print_sh = new System.Windows.Forms.Button();
            this.grb_cancel = new System.Windows.Forms.GroupBox();
            this.txt_cancelReason = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.grb_purchase = new System.Windows.Forms.GroupBox();
            this.dtp_purchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_payType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_orderPrice = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_advisePrice = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_AddNew = new System.Windows.Forms.Button();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmb_specs = new System.Windows.Forms.ComboBox();
            this.lbl_specs = new System.Windows.Forms.Label();
            this.cmb_materials = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_purchaseCode = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_factory = new System.Windows.Forms.ComboBox();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.cmb_supplier = new System.Windows.Forms.ComboBox();
            this.lbl_outputStatus = new System.Windows.Forms.Label();
            this.lbl_outputType = new System.Windows.Forms.Label();
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specs = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.queryStore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.materialsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_cancel.SuspendLayout();
            this.grb_purchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grb_address.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_print_jx
            // 
            this.btn_print_jx.Location = new System.Drawing.Point(31, 615);
            this.btn_print_jx.Name = "btn_print_jx";
            this.btn_print_jx.Size = new System.Drawing.Size(75, 23);
            this.btn_print_jx.TabIndex = 120;
            this.btn_print_jx.Text = "打印-嘉兴";
            this.btn_print_jx.UseVisualStyleBackColor = true;
            this.btn_print_jx.Click += new System.EventHandler(this.btn_print_jx_Click);
            // 
            // btn_print_sh
            // 
            this.btn_print_sh.Location = new System.Drawing.Point(122, 615);
            this.btn_print_sh.Name = "btn_print_sh";
            this.btn_print_sh.Size = new System.Drawing.Size(81, 23);
            this.btn_print_sh.TabIndex = 119;
            this.btn_print_sh.Text = "打印-上海";
            this.btn_print_sh.UseVisualStyleBackColor = true;
            this.btn_print_sh.Click += new System.EventHandler(this.btn_print_sh_Click);
            // 
            // grb_cancel
            // 
            this.grb_cancel.Controls.Add(this.txt_cancelReason);
            this.grb_cancel.Controls.Add(this.label16);
            this.grb_cancel.Location = new System.Drawing.Point(31, 557);
            this.grb_cancel.Name = "grb_cancel";
            this.grb_cancel.Size = new System.Drawing.Size(634, 42);
            this.grb_cancel.TabIndex = 118;
            this.grb_cancel.TabStop = false;
            // 
            // txt_cancelReason
            // 
            this.txt_cancelReason.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_cancelReason.Location = new System.Drawing.Point(77, 13);
            this.txt_cancelReason.MaxLength = 100;
            this.txt_cancelReason.Name = "txt_cancelReason";
            this.txt_cancelReason.Size = new System.Drawing.Size(529, 21);
            this.txt_cancelReason.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(10, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 116;
            this.label16.Text = "取消原因：";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(562, 615);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 106;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // grb_purchase
            // 
            this.grb_purchase.Controls.Add(this.dtp_purchaseDate);
            this.grb_purchase.Controls.Add(this.label12);
            this.grb_purchase.Controls.Add(this.cmb_payType);
            this.grb_purchase.Controls.Add(this.label1);
            this.grb_purchase.Controls.Add(this.label22);
            this.grb_purchase.Controls.Add(this.cmb_type);
            this.grb_purchase.Controls.Add(this.label20);
            this.grb_purchase.Controls.Add(this.label8);
            this.grb_purchase.Controls.Add(this.txt_orderPrice);
            this.grb_purchase.Controls.Add(this.label18);
            this.grb_purchase.Controls.Add(this.lbl_advisePrice);
            this.grb_purchase.Controls.Add(this.label21);
            this.grb_purchase.Controls.Add(this.txt_price);
            this.grb_purchase.Controls.Add(this.label17);
            this.grb_purchase.Controls.Add(this.btn_AddNew);
            this.grb_purchase.Controls.Add(this.txt_num);
            this.grb_purchase.Controls.Add(this.label19);
            this.grb_purchase.Controls.Add(this.cmb_specs);
            this.grb_purchase.Controls.Add(this.lbl_specs);
            this.grb_purchase.Controls.Add(this.cmb_materials);
            this.grb_purchase.Controls.Add(this.label15);
            this.grb_purchase.Controls.Add(this.txt_purchaseCode);
            this.grb_purchase.Controls.Add(this.dataGridView1);
            this.grb_purchase.Controls.Add(this.cmb_factory);
            this.grb_purchase.Controls.Add(this.txt_remark);
            this.grb_purchase.Controls.Add(this.label9);
            this.grb_purchase.Controls.Add(this.label7);
            this.grb_purchase.Controls.Add(this.dtp_deliveryDate);
            this.grb_purchase.Controls.Add(this.label11);
            this.grb_purchase.Controls.Add(this.cmb_status);
            this.grb_purchase.Controls.Add(this.cmb_supplier);
            this.grb_purchase.Controls.Add(this.lbl_outputStatus);
            this.grb_purchase.Controls.Add(this.lbl_outputType);
            this.grb_purchase.Controls.Add(this.label10);
            this.grb_purchase.Controls.Add(this.grb_address);
            this.grb_purchase.Location = new System.Drawing.Point(31, 85);
            this.grb_purchase.Name = "grb_purchase";
            this.grb_purchase.Size = new System.Drawing.Size(634, 466);
            this.grb_purchase.TabIndex = 103;
            this.grb_purchase.TabStop = false;
            // 
            // dtp_purchaseDate
            // 
            this.dtp_purchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_purchaseDate.Location = new System.Drawing.Point(384, 86);
            this.dtp_purchaseDate.Name = "dtp_purchaseDate";
            this.dtp_purchaseDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_purchaseDate.TabIndex = 149;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(320, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 150;
            this.label12.Text = "采购日期：";
            // 
            // cmb_payType
            // 
            this.cmb_payType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_payType.FormattingEnabled = true;
            this.cmb_payType.Items.AddRange(new object[] {
            "财务未确认",
            "财务已确认",
            "原料已入库"});
            this.cmb_payType.Location = new System.Drawing.Point(294, 406);
            this.cmb_payType.Name = "cmb_payType";
            this.cmb_payType.Size = new System.Drawing.Size(222, 20);
            this.cmb_payType.TabIndex = 147;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(223, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 148;
            this.label1.Text = "付款方式：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(352, 374);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 12);
            this.label22.TabIndex = 146;
            this.label22.Text = "元";
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "一般原料",
            "自制原料",
            "其他原料"});
            this.cmb_type.Location = new System.Drawing.Point(75, 341);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(93, 20);
            this.cmb_type.TabIndex = 145;
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.cmb_type_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(10, 344);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 144;
            this.label20.Text = "原料类型：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(176, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 143;
            this.label8.Text = "元";
            // 
            // txt_orderPrice
            // 
            this.txt_orderPrice.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_orderPrice.Location = new System.Drawing.Point(74, 405);
            this.txt_orderPrice.MaxLength = 12;
            this.txt_orderPrice.Name = "txt_orderPrice";
            this.txt_orderPrice.Size = new System.Drawing.Size(94, 21);
            this.txt_orderPrice.TabIndex = 141;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(9, 408);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 142;
            this.label18.Text = "采购总价：";
            // 
            // lbl_advisePrice
            // 
            this.lbl_advisePrice.AutoSize = true;
            this.lbl_advisePrice.ForeColor = System.Drawing.Color.Black;
            this.lbl_advisePrice.Location = new System.Drawing.Point(461, 374);
            this.lbl_advisePrice.Name = "lbl_advisePrice";
            this.lbl_advisePrice.Size = new System.Drawing.Size(11, 12);
            this.lbl_advisePrice.TabIndex = 140;
            this.lbl_advisePrice.Text = "0";
            // 
            // label21
            // 
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(378, 374);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 14);
            this.label21.TabIndex = 139;
            this.label21.Text = "上次采购价格：";
            // 
            // txt_price
            // 
            this.txt_price.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_price.Location = new System.Drawing.Point(216, 371);
            this.txt_price.MaxLength = 20;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(134, 21);
            this.txt_price.TabIndex = 138;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(178, 376);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 137;
            this.label17.Text = "单价：";
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Location = new System.Drawing.Point(531, 341);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(75, 45);
            this.btn_AddNew.TabIndex = 136;
            this.btn_AddNew.Text = "增加";
            this.btn_AddNew.UseVisualStyleBackColor = true;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // txt_num
            // 
            this.txt_num.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_num.Location = new System.Drawing.Point(74, 371);
            this.txt_num.MaxLength = 20;
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(94, 21);
            this.txt_num.TabIndex = 135;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(10, 376);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 134;
            this.label19.Text = "数量(件)：";
            // 
            // cmb_specs
            // 
            this.cmb_specs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_specs.FormattingEnabled = true;
            this.cmb_specs.Location = new System.Drawing.Point(416, 341);
            this.cmb_specs.Name = "cmb_specs";
            this.cmb_specs.Size = new System.Drawing.Size(100, 20);
            this.cmb_specs.TabIndex = 133;
            this.cmb_specs.SelectedIndexChanged += new System.EventHandler(this.cmb_specs_SelectedIndexChanged);
            // 
            // lbl_specs
            // 
            this.lbl_specs.AutoSize = true;
            this.lbl_specs.ForeColor = System.Drawing.Color.Black;
            this.lbl_specs.Location = new System.Drawing.Point(380, 344);
            this.lbl_specs.Name = "lbl_specs";
            this.lbl_specs.Size = new System.Drawing.Size(41, 12);
            this.lbl_specs.TabIndex = 132;
            this.lbl_specs.Text = "规格：";
            // 
            // cmb_materials
            // 
            this.cmb_materials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_materials.FormattingEnabled = true;
            this.cmb_materials.Location = new System.Drawing.Point(216, 341);
            this.cmb_materials.Name = "cmb_materials";
            this.cmb_materials.Size = new System.Drawing.Size(152, 20);
            this.cmb_materials.TabIndex = 131;
            this.cmb_materials.SelectedIndexChanged += new System.EventHandler(this.cmb_materials_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(178, 344);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 130;
            this.label15.Text = "原料：";
            // 
            // txt_purchaseCode
            // 
            this.txt_purchaseCode.Enabled = false;
            this.txt_purchaseCode.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_purchaseCode.Location = new System.Drawing.Point(77, 22);
            this.txt_purchaseCode.MaxLength = 20;
            this.txt_purchaseCode.Name = "txt_purchaseCode";
            this.txt_purchaseCode.Size = new System.Drawing.Size(220, 21);
            this.txt_purchaseCode.TabIndex = 129;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.materialsName,
            this.specs,
            this.num,
            this.price,
            this.deliveryDate,
            this.deleteBtn,
            this.queryStore,
            this.materialsId,
            this.produceCode,
            this.applyBy,
            this.applyType,
            this.applyDate});
            this.dataGridView1.Location = new System.Drawing.Point(12, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(594, 109);
            this.dataGridView1.TabIndex = 128;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // cmb_factory
            // 
            this.cmb_factory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_factory.FormattingEnabled = true;
            this.cmb_factory.Items.AddRange(new object[] {
            "生产申请",
            "特殊申请"});
            this.cmb_factory.Location = new System.Drawing.Point(76, 54);
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.Size = new System.Drawing.Size(221, 20);
            this.cmb_factory.TabIndex = 6;
            this.cmb_factory.SelectedIndexChanged += new System.EventHandler(this.cmb_factory_SelectedIndexChanged);
            // 
            // txt_remark
            // 
            this.txt_remark.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_remark.Location = new System.Drawing.Point(74, 436);
            this.txt_remark.MaxLength = 100;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(529, 21);
            this.txt_remark.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 122;
            this.label9.Text = "备    注：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(15, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 123;
            this.label7.Text = "库    房：";
            // 
            // dtp_deliveryDate
            // 
            this.dtp_deliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_deliveryDate.Location = new System.Drawing.Point(384, 55);
            this.dtp_deliveryDate.Name = "dtp_deliveryDate";
            this.dtp_deliveryDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_deliveryDate.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(320, 58);
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
            "原料已入库"});
            this.cmb_status.Location = new System.Drawing.Point(384, 25);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(222, 20);
            this.cmb_status.TabIndex = 2;
            // 
            // cmb_supplier
            // 
            this.cmb_supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_supplier.FormattingEnabled = true;
            this.cmb_supplier.Location = new System.Drawing.Point(76, 86);
            this.cmb_supplier.Name = "cmb_supplier";
            this.cmb_supplier.Size = new System.Drawing.Size(221, 20);
            this.cmb_supplier.TabIndex = 10;
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
            this.lbl_outputType.Text = "采购单号：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(16, 89);
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
            this.grb_address.Location = new System.Drawing.Point(9, 111);
            this.grb_address.Name = "grb_address";
            this.grb_address.Size = new System.Drawing.Size(610, 104);
            this.grb_address.TabIndex = 73;
            this.grb_address.TabStop = false;
            this.grb_address.Text = "收货地址：";
            // 
            // txt_telephone
            // 
            this.txt_telephone.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_telephone.Location = new System.Drawing.Point(385, 73);
            this.txt_telephone.MaxLength = 20;
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(212, 21);
            this.txt_telephone.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(311, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 71;
            this.label2.Text = "联系电话：";
            // 
            // txt_manager
            // 
            this.txt_manager.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_manager.Location = new System.Drawing.Point(67, 73);
            this.txt_manager.MaxLength = 20;
            this.txt_manager.Name = "txt_manager";
            this.txt_manager.Size = new System.Drawing.Size(223, 21);
            this.txt_manager.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 69;
            this.label5.Text = "联 系 人：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(408, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 64;
            this.label13.Text = "区：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 56;
            this.label6.Text = "省：";
            // 
            // cmb_province
            // 
            this.cmb_province.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_province.FormattingEnabled = true;
            this.cmb_province.Location = new System.Drawing.Point(68, 19);
            this.cmb_province.Name = "cmb_province";
            this.cmb_province.Size = new System.Drawing.Size(115, 20);
            this.cmb_province.TabIndex = 11;
            this.cmb_province.SelectedIndexChanged += new System.EventHandler(this.cmb_province_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 49;
            this.label4.Text = "市：";
            // 
            // cmb_city
            // 
            this.cmb_city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Location = new System.Drawing.Point(244, 19);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(115, 20);
            this.cmb_city.TabIndex = 12;
            this.cmb_city.SelectedIndexChanged += new System.EventHandler(this.cmb_city_SelectedIndexChanged);
            // 
            // txt_address
            // 
            this.txt_address.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_address.Location = new System.Drawing.Point(66, 46);
            this.txt_address.MaxLength = 100;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(531, 21);
            this.txt_address.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 63;
            this.label3.Text = "地    址：";
            // 
            // cmb_district
            // 
            this.cmb_district.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_district.FormattingEnabled = true;
            this.cmb_district.Location = new System.Drawing.Point(443, 19);
            this.cmb_district.Name = "cmb_district";
            this.cmb_district.Size = new System.Drawing.Size(115, 20);
            this.cmb_district.TabIndex = 1;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_title.Location = new System.Drawing.Point(303, 42);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(96, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "采购单";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(450, 615);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 102;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(341, 615);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 101;
            this.btn_submit.Text = "确认";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // materialsName
            // 
            this.materialsName.DataPropertyName = "materialsName";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.materialsName.DefaultCellStyle = dataGridViewCellStyle2;
            this.materialsName.HeaderText = "原料";
            this.materialsName.Name = "materialsName";
            this.materialsName.ReadOnly = true;
            this.materialsName.Width = 140;
            // 
            // specs
            // 
            this.specs.DataPropertyName = "specs";
            this.specs.HeaderText = "规格";
            this.specs.Name = "specs";
            this.specs.Width = 80;
            // 
            // num
            // 
            this.num.DataPropertyName = "num";
            this.num.HeaderText = "数量";
            this.num.Name = "num";
            this.num.Width = 60;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "单价";
            this.price.Name = "price";
            this.price.Width = 60;
            // 
            // deliveryDate
            // 
            this.deliveryDate.DataPropertyName = "deliveryDate";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deliveryDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.deliveryDate.HeaderText = "交货日期";
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.ReadOnly = true;
            // 
            // deleteBtn
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "删除";
            this.deleteBtn.DefaultCellStyle = dataGridViewCellStyle4;
            this.deleteBtn.HeaderText = "删除";
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Width = 60;
            // 
            // queryStore
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = "查看";
            this.queryStore.DefaultCellStyle = dataGridViewCellStyle5;
            this.queryStore.HeaderText = "库存";
            this.queryStore.Name = "queryStore";
            this.queryStore.Width = 60;
            // 
            // materialsId
            // 
            this.materialsId.DataPropertyName = "materialsId";
            this.materialsId.HeaderText = "materialsId";
            this.materialsId.Name = "materialsId";
            this.materialsId.Visible = false;
            // 
            // produceCode
            // 
            this.produceCode.DataPropertyName = "produceCode";
            this.produceCode.HeaderText = "produceCode";
            this.produceCode.Name = "produceCode";
            this.produceCode.Visible = false;
            // 
            // applyBy
            // 
            this.applyBy.DataPropertyName = "applyBy";
            this.applyBy.HeaderText = "applyBy";
            this.applyBy.Name = "applyBy";
            this.applyBy.Visible = false;
            // 
            // applyType
            // 
            this.applyType.DataPropertyName = "applyType";
            this.applyType.HeaderText = "applyType";
            this.applyType.Name = "applyType";
            this.applyType.Visible = false;
            // 
            // applyDate
            // 
            this.applyDate.DataPropertyName = "applyDate";
            this.applyDate.HeaderText = "applyDate";
            this.applyDate.Name = "applyDate";
            this.applyDate.Visible = false;
            // 
            // FrmPurchaseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(702, 653);
            this.Controls.Add(this.btn_print_jx);
            this.Controls.Add(this.btn_print_sh);
            this.Controls.Add(this.grb_cancel);
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
            this.grb_cancel.ResumeLayout(false);
            this.grb_cancel.PerformLayout();
            this.grb_purchase.ResumeLayout(false);
            this.grb_purchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grb_address.ResumeLayout(false);
            this.grb_address.PerformLayout();
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
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.DateTimePicker dtp_deliveryDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_factory;
        private System.Windows.Forms.GroupBox grb_cancel;
        private System.Windows.Forms.TextBox txt_cancelReason;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_print_sh;
        private System.Windows.Forms.Button btn_print_jx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_purchaseCode;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_orderPrice;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_advisePrice;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_AddNew;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmb_specs;
        private System.Windows.Forms.Label lbl_specs;
        private System.Windows.Forms.ComboBox cmb_materials;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmb_payType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_purchaseDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsName;
        private System.Windows.Forms.DataGridViewComboBoxColumn specs;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDate;
        private System.Windows.Forms.DataGridViewButtonColumn deleteBtn;
        private System.Windows.Forms.DataGridViewButtonColumn queryStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn produceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyDate;
    }
}