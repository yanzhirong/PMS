namespace PMS.Frm.Store
{
    partial class FrmProductOutDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductOutDetail));
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_productOut = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_factory = new System.Windows.Forms.ComboBox();
            this.dtp_deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_outputStatus = new System.Windows.Forms.ComboBox();
            this.cmb_outputType = new System.Windows.Forms.ComboBox();
            this.cmb_customer = new System.Windows.Forms.ComboBox();
            this.lbl_outputStatus = new System.Windows.Forms.Label();
            this.lbl_outputType = new System.Windows.Forms.Label();
            this.lbl_applyMember = new System.Windows.Forms.Label();
            this.cmb_apply = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_saler = new System.Windows.Forms.Label();
            this.cmb_saler = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grb_address = new System.Windows.Forms.GroupBox();
            this.txt_outputCode = new System.Windows.Forms.TextBox();
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
            this.lbl_orderCode = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.grb_productOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grb_address.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(223, 577);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 101;
            this.btn_submit.Text = "确认";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(416, 577);
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
            this.lbl_title.Location = new System.Drawing.Point(274, 45);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(152, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "产品出库单";
            // 
            // grb_productOut
            // 
            this.grb_productOut.Controls.Add(this.label1);
            this.grb_productOut.Controls.Add(this.cmb_factory);
            this.grb_productOut.Controls.Add(this.dtp_deliveryDate);
            this.grb_productOut.Controls.Add(this.label11);
            this.grb_productOut.Controls.Add(this.cmb_outputStatus);
            this.grb_productOut.Controls.Add(this.cmb_outputType);
            this.grb_productOut.Controls.Add(this.cmb_customer);
            this.grb_productOut.Controls.Add(this.lbl_outputStatus);
            this.grb_productOut.Controls.Add(this.lbl_outputType);
            this.grb_productOut.Controls.Add(this.lbl_applyMember);
            this.grb_productOut.Controls.Add(this.cmb_apply);
            this.grb_productOut.Controls.Add(this.lbl_saler);
            this.grb_productOut.Controls.Add(this.cmb_saler);
            this.grb_productOut.Controls.Add(this.label10);
            this.grb_productOut.Controls.Add(this.grb_address);
            this.grb_productOut.Controls.Add(this.txt_orderCode);
            this.grb_productOut.Controls.Add(this.lbl_orderCode);
            this.grb_productOut.Location = new System.Drawing.Point(31, 85);
            this.grb_productOut.Name = "grb_productOut";
            this.grb_productOut.Size = new System.Drawing.Size(645, 295);
            this.grb_productOut.TabIndex = 103;
            this.grb_productOut.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(320, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 121;
            this.label1.Text = "工    厂：";
            // 
            // cmb_factory
            // 
            this.cmb_factory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_factory.FormattingEnabled = true;
            this.cmb_factory.Location = new System.Drawing.Point(394, 254);
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.Size = new System.Drawing.Size(222, 20);
            this.cmb_factory.TabIndex = 120;
            // 
            // dtp_deliveryDate
            // 
            this.dtp_deliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_deliveryDate.Location = new System.Drawing.Point(75, 251);
            this.dtp_deliveryDate.Name = "dtp_deliveryDate";
            this.dtp_deliveryDate.Size = new System.Drawing.Size(93, 21);
            this.dtp_deliveryDate.TabIndex = 118;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(10, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 119;
            this.label11.Text = "交货日期：";
            // 
            // cmb_outputStatus
            // 
            this.cmb_outputStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_outputStatus.FormattingEnabled = true;
            this.cmb_outputStatus.Items.AddRange(new object[] {
            "请求出库",
            "完成出库"});
            this.cmb_outputStatus.Location = new System.Drawing.Point(394, 25);
            this.cmb_outputStatus.Name = "cmb_outputStatus";
            this.cmb_outputStatus.Size = new System.Drawing.Size(222, 20);
            this.cmb_outputStatus.TabIndex = 117;
            // 
            // cmb_outputType
            // 
            this.cmb_outputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_outputType.FormattingEnabled = true;
            this.cmb_outputType.Items.AddRange(new object[] {
            "销售订单",
            "特殊申请"});
            this.cmb_outputType.Location = new System.Drawing.Point(76, 25);
            this.cmb_outputType.Name = "cmb_outputType";
            this.cmb_outputType.Size = new System.Drawing.Size(221, 20);
            this.cmb_outputType.TabIndex = 116;
            // 
            // cmb_customer
            // 
            this.cmb_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_customer.FormattingEnabled = true;
            this.cmb_customer.Location = new System.Drawing.Point(76, 89);
            this.cmb_customer.Name = "cmb_customer";
            this.cmb_customer.Size = new System.Drawing.Size(221, 20);
            this.cmb_customer.TabIndex = 1;
            this.cmb_customer.SelectedIndexChanged += new System.EventHandler(this.cmb_customer_SelectedIndexChanged);
            // 
            // lbl_outputStatus
            // 
            this.lbl_outputStatus.AutoSize = true;
            this.lbl_outputStatus.ForeColor = System.Drawing.Color.Black;
            this.lbl_outputStatus.Location = new System.Drawing.Point(320, 29);
            this.lbl_outputStatus.Name = "lbl_outputStatus";
            this.lbl_outputStatus.Size = new System.Drawing.Size(65, 12);
            this.lbl_outputStatus.TabIndex = 115;
            this.lbl_outputStatus.Text = "出库状态：";
            // 
            // lbl_outputType
            // 
            this.lbl_outputType.AutoSize = true;
            this.lbl_outputType.ForeColor = System.Drawing.Color.Black;
            this.lbl_outputType.Location = new System.Drawing.Point(16, 28);
            this.lbl_outputType.Name = "lbl_outputType";
            this.lbl_outputType.Size = new System.Drawing.Size(65, 12);
            this.lbl_outputType.TabIndex = 113;
            this.lbl_outputType.Text = "出库种类：";
            // 
            // lbl_applyMember
            // 
            this.lbl_applyMember.AutoSize = true;
            this.lbl_applyMember.ForeColor = System.Drawing.Color.Red;
            this.lbl_applyMember.Location = new System.Drawing.Point(320, 92);
            this.lbl_applyMember.Name = "lbl_applyMember";
            this.lbl_applyMember.Size = new System.Drawing.Size(65, 12);
            this.lbl_applyMember.TabIndex = 112;
            this.lbl_applyMember.Text = "申 请 者：";
            // 
            // cmb_apply
            // 
            this.cmb_apply.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_apply.FormattingEnabled = true;
            this.cmb_apply.Location = new System.Drawing.Point(394, 89);
            this.cmb_apply.Name = "cmb_apply";
            this.cmb_apply.Size = new System.Drawing.Size(222, 20);
            this.cmb_apply.TabIndex = 111;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(38, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 108;
            this.label7.Text = "出库产品：";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 408);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(643, 145);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // lbl_saler
            // 
            this.lbl_saler.AutoSize = true;
            this.lbl_saler.ForeColor = System.Drawing.Color.Black;
            this.lbl_saler.Location = new System.Drawing.Point(320, 60);
            this.lbl_saler.Name = "lbl_saler";
            this.lbl_saler.Size = new System.Drawing.Size(65, 12);
            this.lbl_saler.TabIndex = 86;
            this.lbl_saler.Text = "销    售：";
            // 
            // cmb_saler
            // 
            this.cmb_saler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_saler.FormattingEnabled = true;
            this.cmb_saler.Location = new System.Drawing.Point(394, 57);
            this.cmb_saler.Name = "cmb_saler";
            this.cmb_saler.Size = new System.Drawing.Size(222, 20);
            this.cmb_saler.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(16, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 79;
            this.label10.Text = "客    户：";
            // 
            // grb_address
            // 
            this.grb_address.Controls.Add(this.txt_outputCode);
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
            this.grb_address.Location = new System.Drawing.Point(9, 115);
            this.grb_address.Name = "grb_address";
            this.grb_address.Size = new System.Drawing.Size(623, 130);
            this.grb_address.TabIndex = 73;
            this.grb_address.TabStop = false;
            this.grb_address.Text = "地  址：";
            // 
            // txt_outputCode
            // 
            this.txt_outputCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_outputCode.Enabled = false;
            this.txt_outputCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_outputCode.Location = new System.Drawing.Point(581, 19);
            this.txt_outputCode.MaxLength = 20;
            this.txt_outputCode.Name = "txt_outputCode";
            this.txt_outputCode.Size = new System.Drawing.Size(26, 21);
            this.txt_outputCode.TabIndex = 120;
            this.txt_outputCode.Visible = false;
            // 
            // txt_telephone
            // 
            this.txt_telephone.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_telephone.Location = new System.Drawing.Point(385, 90);
            this.txt_telephone.MaxLength = 20;
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(222, 21);
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
            this.cmb_province.Location = new System.Drawing.Point(66, 23);
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
            this.txt_address.Size = new System.Drawing.Size(539, 21);
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
            // txt_orderCode
            // 
            this.txt_orderCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_orderCode.Enabled = false;
            this.txt_orderCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_orderCode.Location = new System.Drawing.Point(75, 56);
            this.txt_orderCode.MaxLength = 20;
            this.txt_orderCode.Name = "txt_orderCode";
            this.txt_orderCode.Size = new System.Drawing.Size(222, 21);
            this.txt_orderCode.TabIndex = 43;
            // 
            // lbl_orderCode
            // 
            this.lbl_orderCode.AutoSize = true;
            this.lbl_orderCode.ForeColor = System.Drawing.Color.Black;
            this.lbl_orderCode.Location = new System.Drawing.Point(16, 59);
            this.lbl_orderCode.Name = "lbl_orderCode";
            this.lbl_orderCode.Size = new System.Drawing.Size(65, 12);
            this.lbl_orderCode.TabIndex = 42;
            this.lbl_orderCode.Text = "订单编号：";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(321, 577);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 106;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // FrmProductOutDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(702, 610);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.grb_productOut);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductOutDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品出库管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProductOutDetail_FormClosed);
            this.Load += new System.EventHandler(this.FrmProductOutDetail_Load);
            this.grb_productOut.ResumeLayout(false);
            this.grb_productOut.PerformLayout();
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
        private System.Windows.Forms.GroupBox grb_productOut;
        private System.Windows.Forms.ComboBox cmb_district;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_province;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_orderCode;
        private System.Windows.Forms.Label lbl_orderCode;
        private System.Windows.Forms.GroupBox grb_address;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_customer;
        private System.Windows.Forms.Label lbl_saler;
        private System.Windows.Forms.ComboBox cmb_saler;
        private System.Windows.Forms.TextBox txt_telephone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_manager;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_outputStatus;
        private System.Windows.Forms.Label lbl_outputType;
        private System.Windows.Forms.Label lbl_applyMember;
        private System.Windows.Forms.ComboBox cmb_apply;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cmb_outputStatus;
        private System.Windows.Forms.ComboBox cmb_outputType;
        private System.Windows.Forms.DateTimePicker dtp_deliveryDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_outputCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_factory;
    }
}