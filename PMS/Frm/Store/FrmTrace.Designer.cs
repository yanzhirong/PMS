namespace PMS.Frm.Store
{
    partial class FrmTrace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrace));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_begin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_materialsSpecs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_materialsName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_materialsInputCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_productOutputCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_productSpecs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_producrtName = new System.Windows.Forms.TextBox();
            this.cmb_factory = new System.Windows.Forms.ComboBox();
            this.lbl_saler = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_query = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.orderCode = new System.Windows.Forms.DataGridViewLinkColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbl_tile = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
            this.cmb_customer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_customer);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtp_begin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtp_end);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_materialsSpecs);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_materialsName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_materialsInputCode);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_productOutputCode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_productSpecs);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_producrtName);
            this.groupBox1.Controls.Add(this.cmb_factory);
            this.groupBox1.Controls.Add(this.lbl_saler);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(34, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1154, 125);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // dtp_begin
            // 
            this.dtp_begin.Location = new System.Drawing.Point(789, 21);
            this.dtp_begin.Name = "dtp_begin";
            this.dtp_begin.Size = new System.Drawing.Size(105, 21);
            this.dtp_begin.TabIndex = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(691, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 123;
            this.label5.Text = "出库日期：";
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(914, 20);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(105, 21);
            this.dtp_end.TabIndex = 121;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(899, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 122;
            this.label9.Text = "：";
            // 
            // txt_materialsSpecs
            // 
            this.txt_materialsSpecs.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_materialsSpecs.Location = new System.Drawing.Point(420, 95);
            this.txt_materialsSpecs.MaxLength = 50;
            this.txt_materialsSpecs.Name = "txt_materialsSpecs";
            this.txt_materialsSpecs.Size = new System.Drawing.Size(232, 21);
            this.txt_materialsSpecs.TabIndex = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(352, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 119;
            this.label3.Text = "原料规格：";
            // 
            // txt_materialsName
            // 
            this.txt_materialsName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_materialsName.Location = new System.Drawing.Point(89, 95);
            this.txt_materialsName.MaxLength = 50;
            this.txt_materialsName.Name = "txt_materialsName";
            this.txt_materialsName.Size = new System.Drawing.Size(231, 21);
            this.txt_materialsName.TabIndex = 116;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 117;
            this.label4.Text = "原料名称：";
            // 
            // txt_materialsInputCode
            // 
            this.txt_materialsInputCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_materialsInputCode.Location = new System.Drawing.Point(789, 89);
            this.txt_materialsInputCode.MaxLength = 50;
            this.txt_materialsInputCode.Name = "txt_materialsInputCode";
            this.txt_materialsInputCode.Size = new System.Drawing.Size(231, 21);
            this.txt_materialsInputCode.TabIndex = 114;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(691, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 115;
            this.label8.Text = "原料入库单号：";
            // 
            // txt_productOutputCode
            // 
            this.txt_productOutputCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_productOutputCode.Location = new System.Drawing.Point(789, 57);
            this.txt_productOutputCode.MaxLength = 50;
            this.txt_productOutputCode.Name = "txt_productOutputCode";
            this.txt_productOutputCode.Size = new System.Drawing.Size(231, 21);
            this.txt_productOutputCode.TabIndex = 112;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(691, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 113;
            this.label7.Text = "成品出库单号：";
            // 
            // txt_productSpecs
            // 
            this.txt_productSpecs.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_productSpecs.Location = new System.Drawing.Point(420, 57);
            this.txt_productSpecs.MaxLength = 50;
            this.txt_productSpecs.Name = "txt_productSpecs";
            this.txt_productSpecs.Size = new System.Drawing.Size(232, 21);
            this.txt_productSpecs.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(352, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 111;
            this.label1.Text = "成品规格：";
            // 
            // txt_producrtName
            // 
            this.txt_producrtName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_producrtName.Location = new System.Drawing.Point(89, 57);
            this.txt_producrtName.MaxLength = 50;
            this.txt_producrtName.Name = "txt_producrtName";
            this.txt_producrtName.Size = new System.Drawing.Size(231, 21);
            this.txt_producrtName.TabIndex = 4;
            // 
            // cmb_factory
            // 
            this.cmb_factory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_factory.FormattingEnabled = true;
            this.cmb_factory.Location = new System.Drawing.Point(89, 24);
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.Size = new System.Drawing.Size(231, 20);
            this.cmb_factory.TabIndex = 3;
            // 
            // lbl_saler
            // 
            this.lbl_saler.AutoSize = true;
            this.lbl_saler.ForeColor = System.Drawing.Color.Black;
            this.lbl_saler.Location = new System.Drawing.Point(21, 27);
            this.lbl_saler.Name = "lbl_saler";
            this.lbl_saler.Size = new System.Drawing.Size(65, 12);
            this.lbl_saler.TabIndex = 84;
            this.lbl_saler.Text = "工    厂：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 98;
            this.label2.Text = "成品名称：";
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(45, 217);
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
            this.customerId,
            this.customerName,
            this.orderCode,
            this.productName,
            this.specsName,
            this.outputCode,
            this.outputNum,
            this.outputDate,
            this.outputDetail});
            this.dataGridView1.Location = new System.Drawing.Point(30, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1158, 445);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.factoryName.Width = 200;
            // 
            // customerId
            // 
            this.customerId.DataPropertyName = "customerId";
            this.customerId.HeaderText = "customerId";
            this.customerId.Name = "customerId";
            this.customerId.Visible = false;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "customerName";
            this.customerName.HeaderText = "客户名称";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.customerName.Width = 160;
            // 
            // orderCode
            // 
            this.orderCode.DataPropertyName = "orderCode";
            this.orderCode.HeaderText = "销售单号";
            this.orderCode.Name = "orderCode";
            this.orderCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orderCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.orderCode.Width = 120;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "成品名称";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 160;
            // 
            // specsName
            // 
            this.specsName.DataPropertyName = "specsName";
            this.specsName.HeaderText = "成品规格";
            this.specsName.Name = "specsName";
            this.specsName.ReadOnly = true;
            // 
            // outputCode
            // 
            this.outputCode.DataPropertyName = "outputCode";
            this.outputCode.HeaderText = "出库单号";
            this.outputCode.Name = "outputCode";
            this.outputCode.ReadOnly = true;
            this.outputCode.Width = 120;
            // 
            // outputNum
            // 
            this.outputNum.DataPropertyName = "outputNum";
            this.outputNum.HeaderText = "出库数量";
            this.outputNum.Name = "outputNum";
            this.outputNum.ReadOnly = true;
            this.outputNum.Width = 80;
            // 
            // outputDate
            // 
            this.outputDate.DataPropertyName = "outputDate";
            this.outputDate.HeaderText = "出库日期";
            this.outputDate.Name = "outputDate";
            this.outputDate.ReadOnly = true;
            this.outputDate.Width = 80;
            // 
            // outputDetail
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "查看";
            this.outputDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.outputDetail.HeaderText = "出库明细";
            this.outputDetail.Name = "outputDetail";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1214, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbl_tile
            // 
            this.lbl_tile.AutoSize = true;
            this.lbl_tile.Font = new System.Drawing.Font("宋体", 20F);
            this.lbl_tile.Location = new System.Drawing.Point(481, 41);
            this.lbl_tile.Name = "lbl_tile";
            this.lbl_tile.Size = new System.Drawing.Size(120, 27);
            this.lbl_tile.TabIndex = 67;
            this.lbl_tile.Text = "追溯查询";
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(155, 217);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 10;
            this.btn_export.Text = "导出";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // cmb_customer
            // 
            this.cmb_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_customer.FormattingEnabled = true;
            this.cmb_customer.Location = new System.Drawing.Point(420, 23);
            this.cmb_customer.Name = "cmb_customer";
            this.cmb_customer.Size = new System.Drawing.Size(231, 20);
            this.cmb_customer.TabIndex = 124;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(352, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 125;
            this.label6.Text = "客    户：";
            // 
            // FrmTrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 708);
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
            this.Name = "FrmTrace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "追溯管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTrace_FormClosed);
            this.Load += new System.EventHandler(this.FrmTrace_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.TextBox txt_producrtName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbl_tile;
        private System.Windows.Forms.Label lbl_saler;
        private System.Windows.Forms.ComboBox cmb_factory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.TextBox txt_materialsInputCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_productOutputCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_productSpecs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_materialsSpecs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_materialsName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_begin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;
        private System.Windows.Forms.DataGridViewLinkColumn customerName;
        private System.Windows.Forms.DataGridViewLinkColumn orderCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn specsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputDate;
        private System.Windows.Forms.DataGridViewButtonColumn outputDetail;
        private System.Windows.Forms.ComboBox cmb_customer;
        private System.Windows.Forms.Label label6;

    }
}