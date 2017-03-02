namespace PMS.Frm.Purchase
{
    partial class FrmPurchaseManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPurchaseManage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_factory = new System.Windows.Forms.ComboBox();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_begin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_saler = new System.Windows.Forms.Label();
            this.txt_materialsName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_query = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbl_tile = new System.Windows.Forms.Label();
            this.btn_addNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.queryStore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.factoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_status);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmb_factory);
            this.groupBox1.Controls.Add(this.cmb_type);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtp_end);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_begin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_saler);
            this.groupBox1.Controls.Add(this.txt_materialsName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 83);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cmb_status
            // 
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Location = new System.Drawing.Point(475, 51);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(118, 20);
            this.cmb_status.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(415, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 94;
            this.label7.Text = "采购状态：";
            // 
            // cmb_factory
            // 
            this.cmb_factory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_factory.FormattingEnabled = true;
            this.cmb_factory.Location = new System.Drawing.Point(84, 49);
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.Size = new System.Drawing.Size(118, 20);
            this.cmb_factory.TabIndex = 4;
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "",
            "生产申请",
            "特殊申请"});
            this.cmb_type.Location = new System.Drawing.Point(288, 51);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(118, 20);
            this.cmb_type.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(228, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 92;
            this.label6.Text = "申请类别：";
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(475, 16);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(119, 21);
            this.dtp_end.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 88;
            this.label4.Text = "：";
            // 
            // dtp_begin
            // 
            this.dtp_begin.Location = new System.Drawing.Point(288, 16);
            this.dtp_begin.Name = "dtp_begin";
            this.dtp_begin.Size = new System.Drawing.Size(119, 21);
            this.dtp_begin.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 86;
            this.label3.Text = "交货日期：";
            // 
            // lbl_saler
            // 
            this.lbl_saler.AutoSize = true;
            this.lbl_saler.ForeColor = System.Drawing.Color.Black;
            this.lbl_saler.Location = new System.Drawing.Point(25, 52);
            this.lbl_saler.Name = "lbl_saler";
            this.lbl_saler.Size = new System.Drawing.Size(65, 12);
            this.lbl_saler.TabIndex = 84;
            this.lbl_saler.Text = "工    厂：";
            // 
            // txt_materialsName
            // 
            this.txt_materialsName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_materialsName.Location = new System.Drawing.Point(84, 14);
            this.txt_materialsName.MaxLength = 50;
            this.txt_materialsName.Name = "txt_materialsName";
            this.txt_materialsName.Size = new System.Drawing.Size(118, 21);
            this.txt_materialsName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "物料名称：";
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(30, 172);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(75, 23);
            this.btn_query.TabIndex = 7;
            this.btn_query.Text = "查询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1102, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbl_tile
            // 
            this.lbl_tile.AutoSize = true;
            this.lbl_tile.Font = new System.Drawing.Font("宋体", 20F);
            this.lbl_tile.Location = new System.Drawing.Point(458, 40);
            this.lbl_tile.Name = "lbl_tile";
            this.lbl_tile.Size = new System.Drawing.Size(174, 27);
            this.lbl_tile.TabIndex = 67;
            this.lbl_tile.Text = "采购订单列表";
            // 
            // btn_addNew
            // 
            this.btn_addNew.Location = new System.Drawing.Point(136, 172);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.Size = new System.Drawing.Size(75, 23);
            this.btn_addNew.TabIndex = 8;
            this.btn_addNew.Text = "新增";
            this.btn_addNew.UseVisualStyleBackColor = true;
            this.btn_addNew.Click += new System.EventHandler(this.btn_addNew_Click);
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
            this.materialsName,
            this.numDisplay,
            this.produceCode,
            this.deliveryDate,
            this.status,
            this.applyMember,
            this.modifyBtn,
            this.deleteBtn,
            this.queryStore,
            this.factoryId,
            this.materialsId,
            this.statusCode});
            this.dataGridView1.Location = new System.Drawing.Point(30, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1034, 439);
            this.dataGridView1.TabIndex = 9;
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
            this.factoryName.Width = 110;
            // 
            // materialsName
            // 
            this.materialsName.DataPropertyName = "materialsName";
            this.materialsName.HeaderText = "物料";
            this.materialsName.Name = "materialsName";
            this.materialsName.ReadOnly = true;
            this.materialsName.Width = 140;
            // 
            // numDisplay
            // 
            this.numDisplay.DataPropertyName = "numDisplay";
            this.numDisplay.HeaderText = "数量";
            this.numDisplay.Name = "numDisplay";
            this.numDisplay.ReadOnly = true;
            this.numDisplay.Width = 80;
            // 
            // produceCode
            // 
            this.produceCode.DataPropertyName = "produceCode";
            this.produceCode.HeaderText = "生产单号";
            this.produceCode.Name = "produceCode";
            this.produceCode.ReadOnly = true;
            this.produceCode.Width = 200;
            // 
            // deliveryDate
            // 
            this.deliveryDate.DataPropertyName = "deliveryDate";
            this.deliveryDate.HeaderText = "交货日期";
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.ReadOnly = true;
            this.deliveryDate.Width = 80;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.status.DefaultCellStyle = dataGridViewCellStyle2;
            this.status.HeaderText = "采购状态";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 80;
            // 
            // applyMember
            // 
            this.applyMember.DataPropertyName = "applyMember";
            this.applyMember.HeaderText = "申请人";
            this.applyMember.Name = "applyMember";
            this.applyMember.Width = 80;
            // 
            // modifyBtn
            // 
            this.modifyBtn.DataPropertyName = "modifyBtn";
            this.modifyBtn.HeaderText = "编辑";
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Width = 80;
            // 
            // deleteBtn
            // 
            this.deleteBtn.DataPropertyName = "deleteBtn";
            this.deleteBtn.HeaderText = "删除";
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Width = 80;
            // 
            // queryStore
            // 
            this.queryStore.DataPropertyName = "queryStore";
            this.queryStore.HeaderText = "库存";
            this.queryStore.Name = "queryStore";
            this.queryStore.Width = 80;
            // 
            // factoryId
            // 
            this.factoryId.DataPropertyName = "factoryId";
            this.factoryId.HeaderText = "factoryId";
            this.factoryId.Name = "factoryId";
            this.factoryId.Visible = false;
            // 
            // materialsId
            // 
            this.materialsId.DataPropertyName = "materialsId";
            this.materialsId.HeaderText = "materialsId";
            this.materialsId.Name = "materialsId";
            this.materialsId.Visible = false;
            // 
            // statusCode
            // 
            this.statusCode.DataPropertyName = "statusCode";
            this.statusCode.HeaderText = "statusCode";
            this.statusCode.Name = "statusCode";
            this.statusCode.Visible = false;
            // 
            // FrmPurchaseManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 684);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_addNew);
            this.Controls.Add(this.lbl_tile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_query);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPurchaseManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采购管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPurchaseManage_FormClosed);
            this.Load += new System.EventHandler(this.FrmPurchaseManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.TextBox txt_materialsName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbl_tile;
        private System.Windows.Forms.Label lbl_saler;
        private System.Windows.Forms.ComboBox cmb_factory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_begin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_addNew;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn produceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyMember;
        private System.Windows.Forms.DataGridViewButtonColumn modifyBtn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteBtn;
        private System.Windows.Forms.DataGridViewButtonColumn queryStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCode;

    }
}