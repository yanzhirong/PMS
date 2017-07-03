namespace PMS.Frm.Sale
{
    partial class FrmOrderDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderDetail));
            this.grb_cancel = new System.Windows.Forms.GroupBox();
            this.txt_cancelReason = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.grb_saleOrder = new System.Windows.Forms.GroupBox();
            this.grb_produceAdd = new System.Windows.Forms.GroupBox();
            this.lbl_minPrice = new System.Windows.Forms.Label();
            this.lbl_advisePrice = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_AddNew = new System.Windows.Forms.Button();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmb_specs = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_product = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_orderStatusCode = new System.Windows.Forms.TextBox();
            this.grb_price = new System.Windows.Forms.GroupBox();
            this.cmb_factory = new System.Windows.Forms.ComboBox();
            this.txt_transPrice = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cmb_payType = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_priceRemark = new System.Windows.Forms.TextBox();
            this.dtp_deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_orderPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advisePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_orderStatus = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_saler = new System.Windows.Forms.ComboBox();
            this.lbl_saler = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_customer = new System.Windows.Forms.ComboBox();
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
            this.txt_orderCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.grb_cancel.SuspendLayout();
            this.grb_saleOrder.SuspendLayout();
            this.grb_produceAdd.SuspendLayout();
            this.grb_price.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grb_address.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_cancel
            // 
            this.grb_cancel.Controls.Add(this.txt_cancelReason);
            this.grb_cancel.Controls.Add(this.label18);
            this.grb_cancel.Enabled = false;
            this.grb_cancel.Location = new System.Drawing.Point(31, 673);
            this.grb_cancel.Name = "grb_cancel";
            this.grb_cancel.Size = new System.Drawing.Size(641, 38);
            this.grb_cancel.TabIndex = 115;
            this.grb_cancel.TabStop = false;
            // 
            // txt_cancelReason
            // 
            this.txt_cancelReason.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_cancelReason.Location = new System.Drawing.Point(73, 11);
            this.txt_cancelReason.MaxLength = 100;
            this.txt_cancelReason.Name = "txt_cancelReason";
            this.txt_cancelReason.Size = new System.Drawing.Size(542, 21);
            this.txt_cancelReason.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(6, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 112;
            this.label18.Text = "取消原因：";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(321, 720);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 103;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // grb_saleOrder
            // 
            this.grb_saleOrder.Controls.Add(this.grb_produceAdd);
            this.grb_saleOrder.Controls.Add(this.txt_orderStatusCode);
            this.grb_saleOrder.Controls.Add(this.grb_price);
            this.grb_saleOrder.Controls.Add(this.label7);
            this.grb_saleOrder.Controls.Add(this.dataGridView1);
            this.grb_saleOrder.Controls.Add(this.txt_orderStatus);
            this.grb_saleOrder.Controls.Add(this.label14);
            this.grb_saleOrder.Controls.Add(this.cmb_saler);
            this.grb_saleOrder.Controls.Add(this.lbl_saler);
            this.grb_saleOrder.Controls.Add(this.label10);
            this.grb_saleOrder.Controls.Add(this.cmb_customer);
            this.grb_saleOrder.Controls.Add(this.grb_address);
            this.grb_saleOrder.Controls.Add(this.txt_orderCode);
            this.grb_saleOrder.Controls.Add(this.label1);
            this.grb_saleOrder.Location = new System.Drawing.Point(31, 72);
            this.grb_saleOrder.Name = "grb_saleOrder";
            this.grb_saleOrder.Size = new System.Drawing.Size(641, 600);
            this.grb_saleOrder.TabIndex = 103;
            this.grb_saleOrder.TabStop = false;
            // 
            // grb_produceAdd
            // 
            this.grb_produceAdd.Controls.Add(this.lbl_minPrice);
            this.grb_produceAdd.Controls.Add(this.lbl_advisePrice);
            this.grb_produceAdd.Controls.Add(this.label20);
            this.grb_produceAdd.Controls.Add(this.label21);
            this.grb_produceAdd.Controls.Add(this.txt_price);
            this.grb_produceAdd.Controls.Add(this.label17);
            this.grb_produceAdd.Controls.Add(this.btn_AddNew);
            this.grb_produceAdd.Controls.Add(this.txt_num);
            this.grb_produceAdd.Controls.Add(this.label19);
            this.grb_produceAdd.Controls.Add(this.cmb_specs);
            this.grb_produceAdd.Controls.Add(this.label16);
            this.grb_produceAdd.Controls.Add(this.cmb_product);
            this.grb_produceAdd.Controls.Add(this.label15);
            this.grb_produceAdd.Location = new System.Drawing.Point(9, 392);
            this.grb_produceAdd.Name = "grb_produceAdd";
            this.grb_produceAdd.Size = new System.Drawing.Size(615, 79);
            this.grb_produceAdd.TabIndex = 111;
            this.grb_produceAdd.TabStop = false;
            this.grb_produceAdd.Text = "新增销售成品";
            // 
            // lbl_minPrice
            // 
            this.lbl_minPrice.AutoSize = true;
            this.lbl_minPrice.ForeColor = System.Drawing.Color.Black;
            this.lbl_minPrice.Location = new System.Drawing.Point(436, 53);
            this.lbl_minPrice.Name = "lbl_minPrice";
            this.lbl_minPrice.Size = new System.Drawing.Size(11, 12);
            this.lbl_minPrice.TabIndex = 123;
            this.lbl_minPrice.Text = "0";
            // 
            // lbl_advisePrice
            // 
            this.lbl_advisePrice.AutoSize = true;
            this.lbl_advisePrice.ForeColor = System.Drawing.Color.Black;
            this.lbl_advisePrice.Location = new System.Drawing.Point(295, 53);
            this.lbl_advisePrice.Name = "lbl_advisePrice";
            this.lbl_advisePrice.Size = new System.Drawing.Size(11, 12);
            this.lbl_advisePrice.TabIndex = 122;
            this.lbl_advisePrice.Text = "0";
            // 
            // label20
            // 
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(354, 53);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 14);
            this.label20.TabIndex = 121;
            this.label20.Text = "最低销售单价：";
            // 
            // label21
            // 
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(207, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 14);
            this.label21.TabIndex = 120;
            this.label21.Text = "建议销售单价：";
            // 
            // txt_price
            // 
            this.txt_price.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_price.Location = new System.Drawing.Point(43, 50);
            this.txt_price.MaxLength = 20;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(158, 21);
            this.txt_price.TabIndex = 119;
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_KeyPress_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(6, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 118;
            this.label17.Text = "单价：";
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Location = new System.Drawing.Point(534, 20);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(75, 47);
            this.btn_AddNew.TabIndex = 117;
            this.btn_AddNew.Text = "增加";
            this.btn_AddNew.UseVisualStyleBackColor = true;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // txt_num
            // 
            this.txt_num.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_num.Location = new System.Drawing.Point(417, 20);
            this.txt_num.MaxLength = 20;
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(99, 21);
            this.txt_num.TabIndex = 116;
            this.txt_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(354, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 115;
            this.label19.Text = "数量(件)：";
            // 
            // cmb_specs
            // 
            this.cmb_specs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_specs.FormattingEnabled = true;
            this.cmb_specs.Location = new System.Drawing.Point(245, 22);
            this.cmb_specs.Name = "cmb_specs";
            this.cmb_specs.Size = new System.Drawing.Size(100, 20);
            this.cmb_specs.TabIndex = 114;
            this.cmb_specs.SelectedIndexChanged += new System.EventHandler(this.cmb_specs_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(207, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 113;
            this.label16.Text = "规格：";
            // 
            // cmb_product
            // 
            this.cmb_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_product.FormattingEnabled = true;
            this.cmb_product.Location = new System.Drawing.Point(43, 22);
            this.cmb_product.Name = "cmb_product";
            this.cmb_product.Size = new System.Drawing.Size(158, 20);
            this.cmb_product.TabIndex = 112;
            this.cmb_product.SelectedIndexChanged += new System.EventHandler(this.cmb_product_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(6, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 111;
            this.label15.Text = "成品：";
            // 
            // txt_orderStatusCode
            // 
            this.txt_orderStatusCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_orderStatusCode.Enabled = false;
            this.txt_orderStatusCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_orderStatusCode.Location = new System.Drawing.Point(603, 78);
            this.txt_orderStatusCode.MaxLength = 20;
            this.txt_orderStatusCode.Name = "txt_orderStatusCode";
            this.txt_orderStatusCode.Size = new System.Drawing.Size(10, 21);
            this.txt_orderStatusCode.TabIndex = 110;
            this.txt_orderStatusCode.Visible = false;
            // 
            // grb_price
            // 
            this.grb_price.Controls.Add(this.cmb_factory);
            this.grb_price.Controls.Add(this.txt_transPrice);
            this.grb_price.Controls.Add(this.label23);
            this.grb_price.Controls.Add(this.cmb_payType);
            this.grb_price.Controls.Add(this.label22);
            this.grb_price.Controls.Add(this.label12);
            this.grb_price.Controls.Add(this.txt_priceRemark);
            this.grb_price.Controls.Add(this.dtp_deliveryDate);
            this.grb_price.Controls.Add(this.label11);
            this.grb_price.Controls.Add(this.label8);
            this.grb_price.Controls.Add(this.txt_orderPrice);
            this.grb_price.Controls.Add(this.label9);
            this.grb_price.Location = new System.Drawing.Point(9, 474);
            this.grb_price.Name = "grb_price";
            this.grb_price.Size = new System.Drawing.Size(620, 117);
            this.grb_price.TabIndex = 111;
            this.grb_price.TabStop = false;
            // 
            // cmb_factory
            // 
            this.cmb_factory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_factory.FormattingEnabled = true;
            this.cmb_factory.Location = new System.Drawing.Point(281, 52);
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.Size = new System.Drawing.Size(323, 20);
            this.cmb_factory.TabIndex = 15;
            // 
            // txt_transPrice
            // 
            this.txt_transPrice.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_transPrice.Location = new System.Drawing.Point(281, 20);
            this.txt_transPrice.MaxLength = 12;
            this.txt_transPrice.Name = "txt_transPrice";
            this.txt_transPrice.Size = new System.Drawing.Size(135, 21);
            this.txt_transPrice.TabIndex = 151;
            this.txt_transPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_transPrice_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(218, 23);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 152;
            this.label23.Text = "运输费用：";
            // 
            // cmb_payType
            // 
            this.cmb_payType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_payType.FormattingEnabled = true;
            this.cmb_payType.Items.AddRange(new object[] {
            "财务未确认",
            "财务已确认",
            "原料已入库"});
            this.cmb_payType.Location = new System.Drawing.Point(499, 20);
            this.cmb_payType.Name = "cmb_payType";
            this.cmb_payType.Size = new System.Drawing.Size(105, 20);
            this.cmb_payType.TabIndex = 149;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(436, 23);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 150;
            this.label22.Text = "付款方式：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(217, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 111;
            this.label12.Text = "出货工厂：";
            // 
            // txt_priceRemark
            // 
            this.txt_priceRemark.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_priceRemark.Location = new System.Drawing.Point(65, 84);
            this.txt_priceRemark.MaxLength = 100;
            this.txt_priceRemark.Name = "txt_priceRemark";
            this.txt_priceRemark.Size = new System.Drawing.Size(541, 21);
            this.txt_priceRemark.TabIndex = 16;
            // 
            // dtp_deliveryDate
            // 
            this.dtp_deliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_deliveryDate.Location = new System.Drawing.Point(65, 53);
            this.dtp_deliveryDate.Name = "dtp_deliveryDate";
            this.dtp_deliveryDate.Size = new System.Drawing.Size(136, 21);
            this.dtp_deliveryDate.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(6, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 109;
            this.label11.Text = "交货日期：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 114;
            this.label8.Text = "备    注：";
            // 
            // txt_orderPrice
            // 
            this.txt_orderPrice.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_orderPrice.Location = new System.Drawing.Point(66, 20);
            this.txt_orderPrice.MaxLength = 12;
            this.txt_orderPrice.Name = "txt_orderPrice";
            this.txt_orderPrice.Size = new System.Drawing.Size(135, 21);
            this.txt_orderPrice.TabIndex = 14;
            this.txt_orderPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 112;
            this.label9.Text = "成品总价：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(7, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 108;
            this.label7.Text = "销售成品：";
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
            this.productId,
            this.specsId,
            this.productName,
            this.specsName,
            this.num,
            this.price,
            this.advisePrice,
            this.deleteBtn});
            this.dataGridView1.Location = new System.Drawing.Point(8, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(616, 139);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // productId
            // 
            this.productId.DataPropertyName = "productId";
            this.productId.HeaderText = "productId";
            this.productId.Name = "productId";
            this.productId.Visible = false;
            // 
            // specsId
            // 
            this.specsId.DataPropertyName = "specsId";
            this.specsId.HeaderText = "specsId";
            this.specsId.Name = "specsId";
            this.specsId.Visible = false;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productName";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.productName.DefaultCellStyle = dataGridViewCellStyle2;
            this.productName.HeaderText = "成品";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 180;
            // 
            // specsName
            // 
            this.specsName.DataPropertyName = "specsName";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.specsName.DefaultCellStyle = dataGridViewCellStyle3;
            this.specsName.HeaderText = "规格";
            this.specsName.Name = "specsName";
            this.specsName.ReadOnly = true;
            this.specsName.Width = 80;
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
            this.price.HeaderText = "销售单价";
            this.price.Name = "price";
            this.price.Width = 80;
            // 
            // advisePrice
            // 
            this.advisePrice.DataPropertyName = "advisePrice";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.advisePrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.advisePrice.HeaderText = "建议单价";
            this.advisePrice.Name = "advisePrice";
            this.advisePrice.ReadOnly = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.DataPropertyName = "deleteBtn";
            this.deleteBtn.HeaderText = "删除";
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Width = 70;
            // 
            // txt_orderStatus
            // 
            this.txt_orderStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_orderStatus.Enabled = false;
            this.txt_orderStatus.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_orderStatus.Location = new System.Drawing.Point(402, 19);
            this.txt_orderStatus.MaxLength = 20;
            this.txt_orderStatus.Name = "txt_orderStatus";
            this.txt_orderStatus.Size = new System.Drawing.Size(222, 21);
            this.txt_orderStatus.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(331, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 86;
            this.label14.Text = "销    售：";
            // 
            // cmb_saler
            // 
            this.cmb_saler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_saler.FormattingEnabled = true;
            this.cmb_saler.Location = new System.Drawing.Point(402, 57);
            this.cmb_saler.Name = "cmb_saler";
            this.cmb_saler.Size = new System.Drawing.Size(222, 20);
            this.cmb_saler.TabIndex = 4;
            // 
            // lbl_saler
            // 
            this.lbl_saler.AutoSize = true;
            this.lbl_saler.ForeColor = System.Drawing.Color.Black;
            this.lbl_saler.Location = new System.Drawing.Point(332, 26);
            this.lbl_saler.Name = "lbl_saler";
            this.lbl_saler.Size = new System.Drawing.Size(65, 12);
            this.lbl_saler.TabIndex = 82;
            this.lbl_saler.Text = "订单状态：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(6, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 79;
            this.label10.Text = "客    户：";
            // 
            // cmb_customer
            // 
            this.cmb_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_customer.FormattingEnabled = true;
            this.cmb_customer.Location = new System.Drawing.Point(74, 56);
            this.cmb_customer.Name = "cmb_customer";
            this.cmb_customer.Size = new System.Drawing.Size(221, 20);
            this.cmb_customer.TabIndex = 3;
            this.cmb_customer.SelectedIndexChanged += new System.EventHandler(this.cmb_customer_SelectedIndexChanged);
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
            this.grb_address.Location = new System.Drawing.Point(6, 93);
            this.grb_address.Name = "grb_address";
            this.grb_address.Size = new System.Drawing.Size(623, 130);
            this.grb_address.TabIndex = 73;
            this.grb_address.TabStop = false;
            this.grb_address.Text = "地  址：";
            // 
            // txt_telephone
            // 
            this.txt_telephone.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_telephone.Location = new System.Drawing.Point(397, 90);
            this.txt_telephone.MaxLength = 20;
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(221, 21);
            this.txt_telephone.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(326, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 71;
            this.label2.Text = "联系电话：";
            // 
            // txt_manager
            // 
            this.txt_manager.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_manager.Location = new System.Drawing.Point(68, 90);
            this.txt_manager.MaxLength = 10;
            this.txt_manager.Name = "txt_manager";
            this.txt_manager.Size = new System.Drawing.Size(223, 21);
            this.txt_manager.TabIndex = 9;
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
            this.cmb_province.TabIndex = 5;
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
            this.cmb_city.TabIndex = 6;
            this.cmb_city.SelectedIndexChanged += new System.EventHandler(this.cmb_city_SelectedIndexChanged);
            // 
            // txt_address
            // 
            this.txt_address.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_address.Location = new System.Drawing.Point(68, 53);
            this.txt_address.MaxLength = 100;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(550, 21);
            this.txt_address.TabIndex = 8;
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
            this.cmb_district.TabIndex = 7;
            // 
            // txt_orderCode
            // 
            this.txt_orderCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_orderCode.Enabled = false;
            this.txt_orderCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_orderCode.Location = new System.Drawing.Point(74, 19);
            this.txt_orderCode.MaxLength = 20;
            this.txt_orderCode.Name = "txt_orderCode";
            this.txt_orderCode.Size = new System.Drawing.Size(222, 21);
            this.txt_orderCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 42;
            this.label1.Text = "订单编号：";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_title.Location = new System.Drawing.Point(275, 36);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(124, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "销售订单";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(406, 720);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 102;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(233, 721);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 101;
            this.btn_submit.Text = "确认";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // FrmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(701, 757);
            this.Controls.Add(this.grb_cancel);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.grb_saleOrder);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrderDetail";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "订单管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOrderDetail_FormClosed);
            this.Load += new System.EventHandler(this.FrmOrderDetail_Load);
            this.grb_cancel.ResumeLayout(false);
            this.grb_cancel.PerformLayout();
            this.grb_saleOrder.ResumeLayout(false);
            this.grb_saleOrder.PerformLayout();
            this.grb_produceAdd.ResumeLayout(false);
            this.grb_produceAdd.PerformLayout();
            this.grb_price.ResumeLayout(false);
            this.grb_price.PerformLayout();
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
        private System.Windows.Forms.GroupBox grb_saleOrder;
        private System.Windows.Forms.ComboBox cmb_district;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_province;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_orderCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_address;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_customer;
        private System.Windows.Forms.Label lbl_saler;
        private System.Windows.Forms.TextBox txt_orderStatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_saler;
        private System.Windows.Forms.TextBox txt_telephone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_manager;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grb_price;
        private System.Windows.Forms.TextBox txt_priceRemark;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_orderPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtp_deliveryDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_factory;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_orderStatusCode;
        private System.Windows.Forms.GroupBox grb_cancel;
        private System.Windows.Forms.TextBox txt_cancelReason;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox grb_produceAdd;
        private System.Windows.Forms.Button btn_AddNew;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmb_specs;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmb_product;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_minPrice;
        private System.Windows.Forms.Label lbl_advisePrice;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn specsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn specsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn advisePrice;
        private System.Windows.Forms.DataGridViewButtonColumn deleteBtn;
        private System.Windows.Forms.ComboBox cmb_payType;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_transPrice;
        private System.Windows.Forms.Label label23;
    }
}