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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventory));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_stockNum = new System.Windows.Forms.TextBox();
            this.lbl_stockNum = new System.Windows.Forms.Label();
            this.dtp_inputDate_begin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.cmb_factory = new System.Windows.Forms.ComboBox();
            this.rdb_type_p = new System.Windows.Forms.RadioButton();
            this.rdb_type_m = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_inputDate_end = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_expiresDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_saler = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_query = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiresDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbl_tile = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_stockNum);
            this.groupBox1.Controls.Add(this.lbl_stockNum);
            this.groupBox1.Controls.Add(this.dtp_inputDate_begin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.cmb_factory);
            this.groupBox1.Controls.Add(this.rdb_type_p);
            this.groupBox1.Controls.Add(this.rdb_type_m);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_inputDate_end);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_expiresDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_saler);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(997, 83);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txt_stockNum
            // 
            this.txt_stockNum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_stockNum.Location = new System.Drawing.Point(664, 47);
            this.txt_stockNum.MaxLength = 12;
            this.txt_stockNum.Name = "txt_stockNum";
            this.txt_stockNum.Size = new System.Drawing.Size(266, 21);
            this.txt_stockNum.TabIndex = 8;
            // 
            // lbl_stockNum
            // 
            this.lbl_stockNum.AutoSize = true;
            this.lbl_stockNum.ForeColor = System.Drawing.Color.Black;
            this.lbl_stockNum.Location = new System.Drawing.Point(593, 52);
            this.lbl_stockNum.Name = "lbl_stockNum";
            this.lbl_stockNum.Size = new System.Drawing.Size(65, 12);
            this.lbl_stockNum.TabIndex = 104;
            this.lbl_stockNum.Text = "库 存 数：";
            // 
            // dtp_inputDate_begin
            // 
            this.dtp_inputDate_begin.Location = new System.Drawing.Point(315, 46);
            this.dtp_inputDate_begin.Name = "dtp_inputDate_begin";
            this.dtp_inputDate_begin.Size = new System.Drawing.Size(119, 21);
            this.dtp_inputDate_begin.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 102;
            this.label5.Text = "入库日期：";
            // 
            // txt_name
            // 
            this.txt_name.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_name.Location = new System.Drawing.Point(664, 15);
            this.txt_name.MaxLength = 50;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(266, 21);
            this.txt_name.TabIndex = 4;
            // 
            // cmb_factory
            // 
            this.cmb_factory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_factory.FormattingEnabled = true;
            this.cmb_factory.Location = new System.Drawing.Point(316, 16);
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.Size = new System.Drawing.Size(265, 20);
            this.cmb_factory.TabIndex = 3;
            // 
            // rdb_type_p
            // 
            this.rdb_type_p.AutoSize = true;
            this.rdb_type_p.Checked = true;
            this.rdb_type_p.Location = new System.Drawing.Point(99, 17);
            this.rdb_type_p.Name = "rdb_type_p";
            this.rdb_type_p.Size = new System.Drawing.Size(47, 16);
            this.rdb_type_p.TabIndex = 1;
            this.rdb_type_p.TabStop = true;
            this.rdb_type_p.Text = "产品";
            this.rdb_type_p.UseVisualStyleBackColor = true;
            this.rdb_type_p.CheckedChanged += new System.EventHandler(this.rdb_type_p_CheckedChanged);
            // 
            // rdb_type_m
            // 
            this.rdb_type_m.AutoSize = true;
            this.rdb_type_m.Location = new System.Drawing.Point(172, 17);
            this.rdb_type_m.Name = "rdb_type_m";
            this.rdb_type_m.Size = new System.Drawing.Size(47, 16);
            this.rdb_type_m.TabIndex = 2;
            this.rdb_type_m.Text = "物料";
            this.rdb_type_m.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(593, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 98;
            this.label2.Text = "名    称：";
            // 
            // dtp_inputDate_end
            // 
            this.dtp_inputDate_end.Location = new System.Drawing.Point(462, 46);
            this.dtp_inputDate_end.Name = "dtp_inputDate_end";
            this.dtp_inputDate_end.Size = new System.Drawing.Size(119, 21);
            this.dtp_inputDate_end.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 88;
            this.label4.Text = "：";
            // 
            // dtp_expiresDate
            // 
            this.dtp_expiresDate.Location = new System.Drawing.Point(95, 46);
            this.dtp_expiresDate.Name = "dtp_expiresDate";
            this.dtp_expiresDate.Size = new System.Drawing.Size(119, 21);
            this.dtp_expiresDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 86;
            this.label3.Text = "有 效 期：";
            // 
            // lbl_saler
            // 
            this.lbl_saler.AutoSize = true;
            this.lbl_saler.ForeColor = System.Drawing.Color.Black;
            this.lbl_saler.Location = new System.Drawing.Point(244, 19);
            this.lbl_saler.Name = "lbl_saler";
            this.lbl_saler.Size = new System.Drawing.Size(65, 12);
            this.lbl_saler.TabIndex = 84;
            this.lbl_saler.Text = "工    厂：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "类    型：";
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
            this.type,
            this.inputCode,
            this.factoryName,
            this.name,
            this.inputNum,
            this.stockNum,
            this.produceDate,
            this.inputDate,
            this.expiresDate,
            this.modifyBtn});
            this.dataGridView1.Location = new System.Drawing.Point(30, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1003, 380);
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
            this.inputCode.Width = 160;
            // 
            // factoryName
            // 
            this.factoryName.DataPropertyName = "factoryName";
            this.factoryName.HeaderText = "工厂";
            this.factoryName.Name = "factoryName";
            this.factoryName.ReadOnly = true;
            this.factoryName.Width = 120;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 120;
            // 
            // inputNum
            // 
            this.inputNum.DataPropertyName = "inputNum";
            this.inputNum.HeaderText = "入库数量";
            this.inputNum.Name = "inputNum";
            this.inputNum.ReadOnly = true;
            this.inputNum.Width = 80;
            // 
            // stockNum
            // 
            this.stockNum.DataPropertyName = "stockNum";
            this.stockNum.HeaderText = "库存数量";
            this.stockNum.Name = "stockNum";
            this.stockNum.ReadOnly = true;
            this.stockNum.Width = 80;
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
            // modifyBtn
            // 
            this.modifyBtn.DataPropertyName = "modifyBtn";
            this.modifyBtn.HeaderText = "编辑";
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Text = "编辑";
            this.modifyBtn.Width = 80;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbl_tile
            // 
            this.lbl_tile.AutoSize = true;
            this.lbl_tile.Font = new System.Drawing.Font("宋体", 20F);
            this.lbl_tile.Location = new System.Drawing.Point(463, 44);
            this.lbl_tile.Name = "lbl_tile";
            this.lbl_tile.Size = new System.Drawing.Size(120, 27);
            this.lbl_tile.TabIndex = 67;
            this.lbl_tile.Text = "库存列表";
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
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 616);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.RadioButton rdb_type_p;
        private System.Windows.Forms.RadioButton rdb_type_m;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn produceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiresDate;
        private System.Windows.Forms.DataGridViewButtonColumn modifyBtn;

    }
}