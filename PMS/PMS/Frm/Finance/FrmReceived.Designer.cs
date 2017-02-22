namespace PMS.Frm.Finance
{
    partial class FrmReceived
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReceived));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_orderStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_saler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_customer = new System.Windows.Forms.ComboBox();
            this.lbl_stockNum = new System.Windows.Forms.Label();
            this.dtp_begin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.cmb_factory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_saler = new System.Windows.Forms.Label();
            this.btn_query = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbl_tile = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.salerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiveDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_orderStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_saler);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_customer);
            this.groupBox1.Controls.Add(this.lbl_stockNum);
            this.groupBox1.Controls.Add(this.dtp_begin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.cmb_factory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_end);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_saler);
            this.groupBox1.Location = new System.Drawing.Point(36, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1132, 83);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cmb_orderStatus
            // 
            this.cmb_orderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_orderStatus.FormattingEnabled = true;
            this.cmb_orderStatus.Location = new System.Drawing.Point(350, 48);
            this.cmb_orderStatus.Name = "cmb_orderStatus";
            this.cmb_orderStatus.Size = new System.Drawing.Size(120, 20);
            this.cmb_orderStatus.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(288, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 108;
            this.label3.Text = "收款状态：";
            // 
            // cmb_saler
            // 
            this.cmb_saler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_saler.FormattingEnabled = true;
            this.cmb_saler.Location = new System.Drawing.Point(558, 16);
            this.cmb_saler.Name = "cmb_saler";
            this.cmb_saler.Size = new System.Drawing.Size(120, 20);
            this.cmb_saler.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(496, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 106;
            this.label1.Text = "销    售：";
            // 
            // cmb_customer
            // 
            this.cmb_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_customer.FormattingEnabled = true;
            this.cmb_customer.Location = new System.Drawing.Point(350, 16);
            this.cmb_customer.Name = "cmb_customer";
            this.cmb_customer.Size = new System.Drawing.Size(120, 20);
            this.cmb_customer.TabIndex = 105;
            // 
            // lbl_stockNum
            // 
            this.lbl_stockNum.AutoSize = true;
            this.lbl_stockNum.ForeColor = System.Drawing.Color.Black;
            this.lbl_stockNum.Location = new System.Drawing.Point(288, 19);
            this.lbl_stockNum.Name = "lbl_stockNum";
            this.lbl_stockNum.Size = new System.Drawing.Size(65, 12);
            this.lbl_stockNum.TabIndex = 104;
            this.lbl_stockNum.Text = "客    户：";
            // 
            // dtp_begin
            // 
            this.dtp_begin.Location = new System.Drawing.Point(558, 46);
            this.dtp_begin.Name = "dtp_begin";
            this.dtp_begin.Size = new System.Drawing.Size(119, 21);
            this.dtp_begin.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 102;
            this.label5.Text = "交货日期：";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(89, 48);
            this.txt_name.MaxLength = 20;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(178, 21);
            this.txt_name.TabIndex = 4;
            // 
            // cmb_factory
            // 
            this.cmb_factory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_factory.FormattingEnabled = true;
            this.cmb_factory.Location = new System.Drawing.Point(89, 16);
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.Size = new System.Drawing.Size(178, 20);
            this.cmb_factory.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 98;
            this.label2.Text = "产品名称：";
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(701, 46);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(119, 21);
            this.dtp_end.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(683, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 88;
            this.label4.Text = "：";
            // 
            // lbl_saler
            // 
            this.lbl_saler.AutoSize = true;
            this.lbl_saler.ForeColor = System.Drawing.Color.Black;
            this.lbl_saler.Location = new System.Drawing.Point(25, 19);
            this.lbl_saler.Name = "lbl_saler";
            this.lbl_saler.Size = new System.Drawing.Size(65, 12);
            this.lbl_saler.TabIndex = 84;
            this.lbl_saler.Text = "工    厂：";
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(45, 174);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(75, 23);
            this.btn_query.TabIndex = 9;
            this.btn_query.Text = "查询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
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
            this.factoryName,
            this.customerName,
            this.salerName,
            this.orderCode,
            this.orderPrice,
            this.orderStatus,
            this.deliveryDate,
            this.ReceivedStatus,
            this.receivedPrice,
            this.receiveDetail,
            this.customerId});
            this.dataGridView1.Location = new System.Drawing.Point(30, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1138, 476);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbl_tile
            // 
            this.lbl_tile.AutoSize = true;
            this.lbl_tile.Font = new System.Drawing.Font("宋体", 20F);
            this.lbl_tile.Location = new System.Drawing.Point(539, 40);
            this.lbl_tile.Name = "lbl_tile";
            this.lbl_tile.Size = new System.Drawing.Size(120, 27);
            this.lbl_tile.TabIndex = 67;
            this.lbl_tile.Text = "收款列表";
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(155, 174);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 10;
            this.btn_export.Text = "导出";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // factoryName
            // 
            this.factoryName.DataPropertyName = "factoryName";
            this.factoryName.HeaderText = "工厂";
            this.factoryName.Name = "factoryName";
            this.factoryName.ReadOnly = true;
            this.factoryName.Width = 160;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "customerName";
            this.customerName.HeaderText = "客户";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.customerName.Width = 160;
            // 
            // salerName
            // 
            this.salerName.DataPropertyName = "salerName";
            this.salerName.HeaderText = "销售";
            this.salerName.Name = "salerName";
            this.salerName.ReadOnly = true;
            this.salerName.Width = 80;
            // 
            // orderCode
            // 
            this.orderCode.DataPropertyName = "orderCode";
            this.orderCode.HeaderText = "订单编号";
            this.orderCode.Name = "orderCode";
            this.orderCode.ReadOnly = true;
            this.orderCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orderCode.Width = 160;
            // 
            // orderPrice
            // 
            this.orderPrice.DataPropertyName = "orderPrice";
            this.orderPrice.HeaderText = "订单金额";
            this.orderPrice.Name = "orderPrice";
            this.orderPrice.ReadOnly = true;
            // 
            // orderStatus
            // 
            this.orderStatus.DataPropertyName = "orderStatus";
            this.orderStatus.HeaderText = "订单状态";
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.ReadOnly = true;
            this.orderStatus.Width = 80;
            // 
            // deliveryDate
            // 
            this.deliveryDate.DataPropertyName = "deliveryDate";
            this.deliveryDate.HeaderText = "交货日期";
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.ReadOnly = true;
            this.deliveryDate.Width = 80;
            // 
            // ReceivedStatus
            // 
            this.ReceivedStatus.DataPropertyName = "receivedStatus";
            this.ReceivedStatus.HeaderText = "收款状态";
            this.ReceivedStatus.Name = "ReceivedStatus";
            this.ReceivedStatus.ReadOnly = true;
            // 
            // receivedPrice
            // 
            this.receivedPrice.DataPropertyName = "receivedPrice";
            this.receivedPrice.HeaderText = "收款金额";
            this.receivedPrice.Name = "receivedPrice";
            this.receivedPrice.ReadOnly = true;
            // 
            // receiveDetail
            // 
            this.receiveDetail.DataPropertyName = "receiveDetail";
            this.receiveDetail.HeaderText = "收款明细";
            this.receiveDetail.Name = "receiveDetail";
            this.receiveDetail.Text = "";
            this.receiveDetail.Width = 80;
            // 
            // customerId
            // 
            this.customerId.DataPropertyName = "customerId";
            this.customerId.HeaderText = "customerId";
            this.customerId.Name = "customerId";
            this.customerId.Visible = false;
            // 
            // FrmReceived
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 696);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.lbl_tile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_query);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReceived";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收款管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmReceived_FormClosed);
            this.Load += new System.EventHandler(this.FrmReceived_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbl_tile;
        private System.Windows.Forms.Label lbl_saler;
        private System.Windows.Forms.ComboBox cmb_factory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label lbl_stockNum;
        private System.Windows.Forms.DateTimePicker dtp_begin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.ComboBox cmb_customer;
        private System.Windows.Forms.ComboBox cmb_orderStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_saler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryName;
        private System.Windows.Forms.DataGridViewLinkColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn salerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedPrice;
        private System.Windows.Forms.DataGridViewButtonColumn receiveDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;

    }
}