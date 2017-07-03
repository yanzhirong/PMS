namespace PMS.Frm.Store
{
    partial class FrmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventory));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_qc_s = new System.Windows.Forms.RadioButton();
            this.grb_type = new System.Windows.Forms.GroupBox();
            this.rdb_type_p = new System.Windows.Forms.RadioButton();
            this.rdb_type_m = new System.Windows.Forms.RadioButton();
            this.rdb_qc_a = new System.Windows.Forms.RadioButton();
            this.rdb_qc_f = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_stockNum = new System.Windows.Forms.TextBox();
            this.lbl_stockNum = new System.Windows.Forms.Label();
            this.dtp_inputDate_begin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.cmb_factory = new System.Windows.Forms.ComboBox();
            this.lbl_saler = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_inputDate_end = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_expiresDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_query = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiresDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbl_tile = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grb_type.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_qc_s);
            this.groupBox1.Controls.Add(this.grb_type);
            this.groupBox1.Controls.Add(this.rdb_qc_a);
            this.groupBox1.Controls.Add(this.rdb_qc_f);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_stockNum);
            this.groupBox1.Controls.Add(this.lbl_stockNum);
            this.groupBox1.Controls.Add(this.dtp_inputDate_begin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.cmb_factory);
            this.groupBox1.Controls.Add(this.lbl_saler);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_inputDate_end);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_expiresDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(36, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1005, 118);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // rdb_qc_s
            // 
            this.rdb_qc_s.AutoSize = true;
            this.rdb_qc_s.Location = new System.Drawing.Point(167, 60);
            this.rdb_qc_s.Name = "rdb_qc_s";
            this.rdb_qc_s.Size = new System.Drawing.Size(47, 16);
            this.rdb_qc_s.TabIndex = 109;
            this.rdb_qc_s.Text = "合格";
            this.rdb_qc_s.UseVisualStyleBackColor = true;
            // 
            // grb_type
            // 
            this.grb_type.Controls.Add(this.rdb_type_p);
            this.grb_type.Controls.Add(this.rdb_type_m);
            this.grb_type.Location = new System.Drawing.Point(3, 13);
            this.grb_type.Name = "grb_type";
            this.grb_type.Size = new System.Drawing.Size(164, 38);
            this.grb_type.TabIndex = 108;
            this.grb_type.TabStop = false;
            this.grb_type.Text = "类型";
            // 
            // rdb_type_p
            // 
            this.rdb_type_p.AutoSize = true;
            this.rdb_type_p.Checked = true;
            this.rdb_type_p.Location = new System.Drawing.Point(38, 10);
            this.rdb_type_p.Name = "rdb_type_p";
            this.rdb_type_p.Size = new System.Drawing.Size(47, 16);
            this.rdb_type_p.TabIndex = 3;
            this.rdb_type_p.TabStop = true;
            this.rdb_type_p.Text = "成品";
            this.rdb_type_p.UseVisualStyleBackColor = true;
            // 
            // rdb_type_m
            // 
            this.rdb_type_m.AutoSize = true;
            this.rdb_type_m.Location = new System.Drawing.Point(111, 10);
            this.rdb_type_m.Name = "rdb_type_m";
            this.rdb_type_m.Size = new System.Drawing.Size(47, 16);
            this.rdb_type_m.TabIndex = 4;
            this.rdb_type_m.Text = "原料";
            this.rdb_type_m.UseVisualStyleBackColor = true;
            // 
            // rdb_qc_a
            // 
            this.rdb_qc_a.AutoSize = true;
            this.rdb_qc_a.Checked = true;
            this.rdb_qc_a.Location = new System.Drawing.Point(114, 59);
            this.rdb_qc_a.Name = "rdb_qc_a";
            this.rdb_qc_a.Size = new System.Drawing.Size(47, 16);
            this.rdb_qc_a.TabIndex = 105;
            this.rdb_qc_a.TabStop = true;
            this.rdb_qc_a.Text = "所有";
            this.rdb_qc_a.UseVisualStyleBackColor = true;
            // 
            // rdb_qc_f
            // 
            this.rdb_qc_f.AutoSize = true;
            this.rdb_qc_f.Location = new System.Drawing.Point(220, 60);
            this.rdb_qc_f.Name = "rdb_qc_f";
            this.rdb_qc_f.Size = new System.Drawing.Size(59, 16);
            this.rdb_qc_f.TabIndex = 106;
            this.rdb_qc_f.Text = "不合格";
            this.rdb_qc_f.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 107;
            this.label6.Text = "质    检：";
            // 
            // txt_stockNum
            // 
            this.txt_stockNum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_stockNum.Location = new System.Drawing.Point(682, 89);
            this.txt_stockNum.MaxLength = 12;
            this.txt_stockNum.Name = "txt_stockNum";
            this.txt_stockNum.Size = new System.Drawing.Size(182, 21);
            this.txt_stockNum.TabIndex = 8;
            // 
            // lbl_stockNum
            // 
            this.lbl_stockNum.AutoSize = true;
            this.lbl_stockNum.ForeColor = System.Drawing.Color.Black;
            this.lbl_stockNum.Location = new System.Drawing.Point(610, 95);
            this.lbl_stockNum.Name = "lbl_stockNum";
            this.lbl_stockNum.Size = new System.Drawing.Size(65, 12);
            this.lbl_stockNum.TabIndex = 104;
            this.lbl_stockNum.Text = "库 存 数：";
            // 
            // dtp_inputDate_begin
            // 
            this.dtp_inputDate_begin.Location = new System.Drawing.Point(368, 90);
            this.dtp_inputDate_begin.Name = "dtp_inputDate_begin";
            this.dtp_inputDate_begin.Size = new System.Drawing.Size(105, 21);
            this.dtp_inputDate_begin.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 102;
            this.label5.Text = "入库日期：";
            // 
            // txt_name
            // 
            this.txt_name.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_name.Location = new System.Drawing.Point(368, 57);
            this.txt_name.MaxLength = 50;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(230, 21);
            this.txt_name.TabIndex = 4;
            // 
            // cmb_factory
            // 
            this.cmb_factory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_factory.FormattingEnabled = true;
            this.cmb_factory.Location = new System.Drawing.Point(682, 57);
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.Size = new System.Drawing.Size(182, 20);
            this.cmb_factory.TabIndex = 3;
            // 
            // lbl_saler
            // 
            this.lbl_saler.AutoSize = true;
            this.lbl_saler.ForeColor = System.Drawing.Color.Black;
            this.lbl_saler.Location = new System.Drawing.Point(610, 60);
            this.lbl_saler.Name = "lbl_saler";
            this.lbl_saler.Size = new System.Drawing.Size(65, 12);
            this.lbl_saler.TabIndex = 84;
            this.lbl_saler.Text = "工    厂：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(304, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 98;
            this.label2.Text = "名    称：";
            // 
            // dtp_inputDate_end
            // 
            this.dtp_inputDate_end.Location = new System.Drawing.Point(493, 89);
            this.dtp_inputDate_end.Name = "dtp_inputDate_end";
            this.dtp_inputDate_end.Size = new System.Drawing.Size(105, 21);
            this.dtp_inputDate_end.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 88;
            this.label4.Text = "：";
            // 
            // dtp_expiresDate
            // 
            this.dtp_expiresDate.Location = new System.Drawing.Point(112, 89);
            this.dtp_expiresDate.Name = "dtp_expiresDate";
            this.dtp_expiresDate.Size = new System.Drawing.Size(167, 21);
            this.dtp_expiresDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 86;
            this.label3.Text = "有 效 期：";
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
            this.type,
            this.inputCode,
            this.factoryName,
            this.name,
            this.specsName,
            this.stockNum,
            this.price,
            this.money,
            this.produceDate,
            this.inputDate,
            this.expiresDate,
            this.QC,
            this.modifyBtn});
            this.dataGridView1.Location = new System.Drawing.Point(30, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1389, 445);
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
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "类型";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 80;
            // 
            // inputCode
            // 
            this.inputCode.DataPropertyName = "inputCode";
            this.inputCode.HeaderText = "入库单号";
            this.inputCode.Name = "inputCode";
            this.inputCode.ReadOnly = true;
            this.inputCode.Width = 120;
            // 
            // factoryName
            // 
            this.factoryName.DataPropertyName = "factoryName";
            this.factoryName.HeaderText = "工厂";
            this.factoryName.Name = "factoryName";
            this.factoryName.ReadOnly = true;
            this.factoryName.Width = 200;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 160;
            // 
            // specsName
            // 
            this.specsName.DataPropertyName = "specsName";
            this.specsName.HeaderText = "规格";
            this.specsName.Name = "specsName";
            this.specsName.ReadOnly = true;
            // 
            // stockNum
            // 
            this.stockNum.DataPropertyName = "stockNum";
            this.stockNum.HeaderText = "库存数量";
            this.stockNum.Name = "stockNum";
            this.stockNum.ReadOnly = true;
            this.stockNum.Width = 80;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "单价";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // money
            // 
            this.money.DataPropertyName = "money";
            this.money.HeaderText = "金额";
            this.money.Name = "money";
            this.money.ReadOnly = true;
            // 
            // produceDate
            // 
            this.produceDate.DataPropertyName = "produceDate";
            this.produceDate.HeaderText = "生产日期";
            this.produceDate.Name = "produceDate";
            this.produceDate.ReadOnly = true;
            this.produceDate.Width = 80;
            // 
            // inputDate
            // 
            this.inputDate.DataPropertyName = "inputDate";
            this.inputDate.HeaderText = "入库日期";
            this.inputDate.Name = "inputDate";
            this.inputDate.ReadOnly = true;
            this.inputDate.Width = 80;
            // 
            // expiresDate
            // 
            this.expiresDate.DataPropertyName = "expiresDate";
            this.expiresDate.HeaderText = "有效日期";
            this.expiresDate.Name = "expiresDate";
            this.expiresDate.ReadOnly = true;
            this.expiresDate.Width = 80;
            // 
            // QC
            // 
            this.QC.DataPropertyName = "QC";
            this.QC.HeaderText = "质检";
            this.QC.Name = "QC";
            this.QC.ReadOnly = true;
            this.QC.Width = 80;
            // 
            // modifyBtn
            // 
            this.modifyBtn.DataPropertyName = "modifyBtn";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "编辑";
            this.modifyBtn.DefaultCellStyle = dataGridViewCellStyle2;
            this.modifyBtn.HeaderText = "编辑";
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Text = "编辑";
            this.modifyBtn.Width = 80;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1449, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbl_tile
            // 
            this.lbl_tile.AutoSize = true;
            this.lbl_tile.Font = new System.Drawing.Font("宋体", 20F);
            this.lbl_tile.Location = new System.Drawing.Point(632, 46);
            this.lbl_tile.Name = "lbl_tile";
            this.lbl_tile.Size = new System.Drawing.Size(120, 27);
            this.lbl_tile.TabIndex = 67;
            this.lbl_tile.Text = "库存列表";
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
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 708);
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
            this.Name = "FrmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmInventory_FormClosed);
            this.Load += new System.EventHandler(this.FrmInventory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grb_type.ResumeLayout(false);
            this.grb_type.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dtp_expiresDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_inputDate_end;
        private System.Windows.Forms.TextBox txt_stockNum;
        private System.Windows.Forms.Label lbl_stockNum;
        private System.Windows.Forms.DateTimePicker dtp_inputDate_begin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.RadioButton rdb_qc_a;
        private System.Windows.Forms.RadioButton rdb_qc_f;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grb_type;
        private System.Windows.Forms.RadioButton rdb_type_p;
        private System.Windows.Forms.RadioButton rdb_type_m;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn specsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn money;
        private System.Windows.Forms.DataGridViewTextBoxColumn produceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiresDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn QC;
        private System.Windows.Forms.DataGridViewButtonColumn modifyBtn;
        private System.Windows.Forms.RadioButton rdb_qc_s;

    }
}