namespace PMS.Frm.Finance
{
    partial class FrmAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccounts));
            this.btn_export = new System.Windows.Forms.Button();
            this.lbl_tile = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_factory = new System.Windows.Forms.ComboBox();
            this.lbl_saler = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_type_r = new System.Windows.Forms.RadioButton();
            this.rdb_type_p = new System.Windows.Forms.RadioButton();
            this.cmb_customer = new System.Windows.Forms.ComboBox();
            this.lbl_stockNum = new System.Windows.Forms.Label();
            this.dtp_begin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_query = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.orderCode = new System.Windows.Forms.DataGridViewLinkColumn();
            this.factoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountsDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curPricePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(154, 186);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 9;
            this.btn_export.Text = "导出";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // lbl_tile
            // 
            this.lbl_tile.AutoSize = true;
            this.lbl_tile.Font = new System.Drawing.Font("宋体", 20F);
            this.lbl_tile.Location = new System.Drawing.Point(433, 47);
            this.lbl_tile.Name = "lbl_tile";
            this.lbl_tile.Size = new System.Drawing.Size(174, 27);
            this.lbl_tile.TabIndex = 67;
            this.lbl_tile.Text = "往来账目列表";
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
            this.customerName,
            this.orderCode,
            this.factoryName,
            this.accountsDate,
            this.curPricePlan,
            this.curPrice,
            this.totalPrice,
            this.customerId});
            this.dataGridView1.Location = new System.Drawing.Point(36, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 453);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_factory);
            this.groupBox1.Controls.Add(this.lbl_saler);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdb_type_r);
            this.groupBox1.Controls.Add(this.rdb_type_p);
            this.groupBox1.Controls.Add(this.cmb_customer);
            this.groupBox1.Controls.Add(this.lbl_stockNum);
            this.groupBox1.Controls.Add(this.dtp_begin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtp_end);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(36, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 91);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cmb_factory
            // 
            this.cmb_factory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_factory.FormattingEnabled = true;
            this.cmb_factory.Location = new System.Drawing.Point(384, 54);
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.Size = new System.Drawing.Size(261, 20);
            this.cmb_factory.TabIndex = 108;
            // 
            // lbl_saler
            // 
            this.lbl_saler.AutoSize = true;
            this.lbl_saler.ForeColor = System.Drawing.Color.Black;
            this.lbl_saler.Location = new System.Drawing.Point(312, 57);
            this.lbl_saler.Name = "lbl_saler";
            this.lbl_saler.Size = new System.Drawing.Size(65, 12);
            this.lbl_saler.TabIndex = 109;
            this.lbl_saler.Text = "工    厂：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 107;
            this.label1.Text = "类    型：";
            // 
            // rdb_type_r
            // 
            this.rdb_type_r.AutoSize = true;
            this.rdb_type_r.Checked = true;
            this.rdb_type_r.Location = new System.Drawing.Point(79, 20);
            this.rdb_type_r.Name = "rdb_type_r";
            this.rdb_type_r.Size = new System.Drawing.Size(47, 16);
            this.rdb_type_r.TabIndex = 105;
            this.rdb_type_r.TabStop = true;
            this.rdb_type_r.Text = "应收";
            this.rdb_type_r.UseVisualStyleBackColor = true;
            this.rdb_type_r.CheckedChanged += new System.EventHandler(this.rdb_type_p_CheckedChanged);
            // 
            // rdb_type_p
            // 
            this.rdb_type_p.AutoSize = true;
            this.rdb_type_p.Location = new System.Drawing.Point(179, 20);
            this.rdb_type_p.Name = "rdb_type_p";
            this.rdb_type_p.Size = new System.Drawing.Size(47, 16);
            this.rdb_type_p.TabIndex = 106;
            this.rdb_type_p.Text = "应付";
            this.rdb_type_p.UseVisualStyleBackColor = true;
            // 
            // cmb_customer
            // 
            this.cmb_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_customer.FormattingEnabled = true;
            this.cmb_customer.Location = new System.Drawing.Point(78, 54);
            this.cmb_customer.Name = "cmb_customer";
            this.cmb_customer.Size = new System.Drawing.Size(181, 20);
            this.cmb_customer.TabIndex = 2;
            // 
            // lbl_stockNum
            // 
            this.lbl_stockNum.AutoSize = true;
            this.lbl_stockNum.ForeColor = System.Drawing.Color.Black;
            this.lbl_stockNum.Location = new System.Drawing.Point(7, 57);
            this.lbl_stockNum.Name = "lbl_stockNum";
            this.lbl_stockNum.Size = new System.Drawing.Size(65, 12);
            this.lbl_stockNum.TabIndex = 104;
            this.lbl_stockNum.Text = "客    户：";
            // 
            // dtp_begin
            // 
            this.dtp_begin.Location = new System.Drawing.Point(383, 19);
            this.dtp_begin.Name = "dtp_begin";
            this.dtp_begin.Size = new System.Drawing.Size(119, 21);
            this.dtp_begin.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 102;
            this.label5.Text = "账目日期：";
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(526, 19);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(119, 21);
            this.dtp_end.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 88;
            this.label4.Text = "：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(44, 186);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(75, 23);
            this.btn_query.TabIndex = 8;
            this.btn_query.Text = "查询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "customerName";
            this.customerName.HeaderText = "客户";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.customerName.Width = 250;
            // 
            // orderCode
            // 
            this.orderCode.DataPropertyName = "orderCode";
            this.orderCode.HeaderText = "订单编号";
            this.orderCode.Name = "orderCode";
            this.orderCode.ReadOnly = true;
            this.orderCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orderCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.orderCode.Width = 120;
            // 
            // factoryName
            // 
            this.factoryName.DataPropertyName = "factoryName";
            this.factoryName.HeaderText = "工厂";
            this.factoryName.Name = "factoryName";
            this.factoryName.ReadOnly = true;
            this.factoryName.Width = 200;
            // 
            // accountsDate
            // 
            this.accountsDate.DataPropertyName = "accountsDate";
            this.accountsDate.HeaderText = "账目日期";
            this.accountsDate.Name = "accountsDate";
            this.accountsDate.ReadOnly = true;
            // 
            // curPricePlan
            // 
            this.curPricePlan.DataPropertyName = "curPricePlan";
            this.curPricePlan.HeaderText = "应收";
            this.curPricePlan.Name = "curPricePlan";
            this.curPricePlan.ReadOnly = true;
            // 
            // curPrice
            // 
            this.curPrice.DataPropertyName = "curPrice";
            this.curPrice.HeaderText = "实收";
            this.curPrice.Name = "curPrice";
            this.curPrice.ReadOnly = true;
            // 
            // totalPrice
            // 
            this.totalPrice.DataPropertyName = "totalPrice";
            this.totalPrice.HeaderText = "未收";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // customerId
            // 
            this.customerId.DataPropertyName = "customerId";
            this.customerId.HeaderText = "customerId";
            this.customerId.Name = "customerId";
            this.customerId.Visible = false;
            // 
            // FrmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 696);
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
            this.Name = "FrmAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "往来账目";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAccounts_FormClosed);
            this.Load += new System.EventHandler(this.FrmAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbl_tile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label lbl_stockNum;
        private System.Windows.Forms.DateTimePicker dtp_begin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.ComboBox cmb_customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_type_r;
        private System.Windows.Forms.RadioButton rdb_type_p;
        private System.Windows.Forms.ComboBox cmb_factory;
        private System.Windows.Forms.Label lbl_saler;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewLinkColumn customerName;
        private System.Windows.Forms.DataGridViewLinkColumn orderCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountsDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn curPricePlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn curPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;

    }
}