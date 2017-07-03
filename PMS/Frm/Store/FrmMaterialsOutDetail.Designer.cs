namespace PMS.Frm.Store
{
    partial class FrmMaterialsOutDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaterialsOutDetail));
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_materialsOut = new System.Windows.Forms.GroupBox();
            this.cmb_factory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_applyDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_outputStatus = new System.Windows.Forms.ComboBox();
            this.cmb_outputType = new System.Windows.Forms.ComboBox();
            this.lbl_outputStatus = new System.Windows.Forms.Label();
            this.lbl_outputType = new System.Windows.Forms.Label();
            this.lbl_applyMember = new System.Windows.Forms.Label();
            this.cmb_applyBy = new System.Windows.Forms.ComboBox();
            this.txt_produceCode = new System.Windows.Forms.TextBox();
            this.lbl_orderCode = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.grb_new = new System.Windows.Forms.GroupBox();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmb_specs = new System.Windows.Forms.ComboBox();
            this.lbl_specs = new System.Windows.Forms.Label();
            this.cmb_materials = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_AddNew = new System.Windows.Forms.Button();
            this.grb_detail = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestOutputWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specsId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.requestOutputNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realityOutputNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.materialsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_materialsOut.SuspendLayout();
            this.grb_new.SuspendLayout();
            this.grb_detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(524, 548);
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
            this.lbl_title.Location = new System.Drawing.Point(326, 35);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(152, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "原料出库单";
            // 
            // grb_materialsOut
            // 
            this.grb_materialsOut.Controls.Add(this.cmb_factory);
            this.grb_materialsOut.Controls.Add(this.label7);
            this.grb_materialsOut.Controls.Add(this.txt_remark);
            this.grb_materialsOut.Controls.Add(this.label5);
            this.grb_materialsOut.Controls.Add(this.dtp_applyDate);
            this.grb_materialsOut.Controls.Add(this.label3);
            this.grb_materialsOut.Controls.Add(this.cmb_outputStatus);
            this.grb_materialsOut.Controls.Add(this.cmb_outputType);
            this.grb_materialsOut.Controls.Add(this.lbl_outputStatus);
            this.grb_materialsOut.Controls.Add(this.lbl_outputType);
            this.grb_materialsOut.Controls.Add(this.lbl_applyMember);
            this.grb_materialsOut.Controls.Add(this.cmb_applyBy);
            this.grb_materialsOut.Controls.Add(this.txt_produceCode);
            this.grb_materialsOut.Controls.Add(this.lbl_orderCode);
            this.grb_materialsOut.Location = new System.Drawing.Point(31, 85);
            this.grb_materialsOut.Name = "grb_materialsOut";
            this.grb_materialsOut.Size = new System.Drawing.Size(733, 193);
            this.grb_materialsOut.TabIndex = 103;
            this.grb_materialsOut.TabStop = false;
            // 
            // cmb_factory
            // 
            this.cmb_factory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_factory.FormattingEnabled = true;
            this.cmb_factory.Location = new System.Drawing.Point(79, 112);
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.Size = new System.Drawing.Size(281, 20);
            this.cmb_factory.TabIndex = 144;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(16, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 145;
            this.label7.Text = "出库工厂：";
            // 
            // txt_remark
            // 
            this.txt_remark.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_remark.Location = new System.Drawing.Point(79, 152);
            this.txt_remark.MaxLength = 100;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(625, 21);
            this.txt_remark.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 139;
            this.label5.Text = "备    注：";
            // 
            // dtp_applyDate
            // 
            this.dtp_applyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_applyDate.Location = new System.Drawing.Point(448, 111);
            this.dtp_applyDate.Name = "dtp_applyDate";
            this.dtp_applyDate.Size = new System.Drawing.Size(256, 21);
            this.dtp_applyDate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(382, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 125;
            this.label3.Text = "申请日期：";
            // 
            // cmb_outputStatus
            // 
            this.cmb_outputStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_outputStatus.FormattingEnabled = true;
            this.cmb_outputStatus.Items.AddRange(new object[] {
            "请求出库",
            "完成出库"});
            this.cmb_outputStatus.Location = new System.Drawing.Point(448, 25);
            this.cmb_outputStatus.Name = "cmb_outputStatus";
            this.cmb_outputStatus.Size = new System.Drawing.Size(256, 20);
            this.cmb_outputStatus.TabIndex = 2;
            // 
            // cmb_outputType
            // 
            this.cmb_outputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_outputType.FormattingEnabled = true;
            this.cmb_outputType.Items.AddRange(new object[] {
            "生产申请",
            "其他申请"});
            this.cmb_outputType.Location = new System.Drawing.Point(80, 25);
            this.cmb_outputType.Name = "cmb_outputType";
            this.cmb_outputType.Size = new System.Drawing.Size(280, 20);
            this.cmb_outputType.TabIndex = 1;
            // 
            // lbl_outputStatus
            // 
            this.lbl_outputStatus.AutoSize = true;
            this.lbl_outputStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_outputStatus.Location = new System.Drawing.Point(382, 29);
            this.lbl_outputStatus.Name = "lbl_outputStatus";
            this.lbl_outputStatus.Size = new System.Drawing.Size(65, 12);
            this.lbl_outputStatus.TabIndex = 115;
            this.lbl_outputStatus.Text = "出库状态：";
            // 
            // lbl_outputType
            // 
            this.lbl_outputType.AutoSize = true;
            this.lbl_outputType.ForeColor = System.Drawing.Color.Red;
            this.lbl_outputType.Location = new System.Drawing.Point(16, 28);
            this.lbl_outputType.Name = "lbl_outputType";
            this.lbl_outputType.Size = new System.Drawing.Size(65, 12);
            this.lbl_outputType.TabIndex = 113;
            this.lbl_outputType.Text = "出库类型：";
            // 
            // lbl_applyMember
            // 
            this.lbl_applyMember.AutoSize = true;
            this.lbl_applyMember.ForeColor = System.Drawing.Color.Red;
            this.lbl_applyMember.Location = new System.Drawing.Point(382, 72);
            this.lbl_applyMember.Name = "lbl_applyMember";
            this.lbl_applyMember.Size = new System.Drawing.Size(65, 12);
            this.lbl_applyMember.TabIndex = 112;
            this.lbl_applyMember.Text = "申 请 人：";
            // 
            // cmb_applyBy
            // 
            this.cmb_applyBy.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_applyBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_applyBy.FormattingEnabled = true;
            this.cmb_applyBy.Location = new System.Drawing.Point(448, 69);
            this.cmb_applyBy.Name = "cmb_applyBy";
            this.cmb_applyBy.Size = new System.Drawing.Size(256, 20);
            this.cmb_applyBy.TabIndex = 4;
            // 
            // txt_produceCode
            // 
            this.txt_produceCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_produceCode.Enabled = false;
            this.txt_produceCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_produceCode.Location = new System.Drawing.Point(79, 69);
            this.txt_produceCode.MaxLength = 20;
            this.txt_produceCode.Name = "txt_produceCode";
            this.txt_produceCode.Size = new System.Drawing.Size(281, 21);
            this.txt_produceCode.TabIndex = 3;
            // 
            // lbl_orderCode
            // 
            this.lbl_orderCode.AutoSize = true;
            this.lbl_orderCode.ForeColor = System.Drawing.Color.Black;
            this.lbl_orderCode.Location = new System.Drawing.Point(16, 72);
            this.lbl_orderCode.Name = "lbl_orderCode";
            this.lbl_orderCode.Size = new System.Drawing.Size(65, 12);
            this.lbl_orderCode.TabIndex = 42;
            this.lbl_orderCode.Text = "生产单号：";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(334, 548);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(71, 23);
            this.btn_submit.TabIndex = 106;
            this.btn_submit.Text = "确认";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(524, 548);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 103;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(37, 548);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 111;
            this.btn_print.Text = "打印";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // grb_new
            // 
            this.grb_new.Controls.Add(this.cmb_type);
            this.grb_new.Controls.Add(this.label20);
            this.grb_new.Controls.Add(this.txt_num);
            this.grb_new.Controls.Add(this.label19);
            this.grb_new.Controls.Add(this.cmb_specs);
            this.grb_new.Controls.Add(this.lbl_specs);
            this.grb_new.Controls.Add(this.cmb_materials);
            this.grb_new.Controls.Add(this.label15);
            this.grb_new.Controls.Add(this.btn_AddNew);
            this.grb_new.Location = new System.Drawing.Point(12, 155);
            this.grb_new.Name = "grb_new";
            this.grb_new.Size = new System.Drawing.Size(604, 67);
            this.grb_new.TabIndex = 17;
            this.grb_new.TabStop = false;
            this.grb_new.Text = "新增出库";
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "一般原料",
            "自制原料",
            "其他原料"});
            this.cmb_type.Location = new System.Drawing.Point(66, 14);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(155, 20);
            this.cmb_type.TabIndex = 153;
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.cmb_type_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(6, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 152;
            this.label20.Text = "原料类型：";
            // 
            // txt_num
            // 
            this.txt_num.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_num.Location = new System.Drawing.Point(324, 40);
            this.txt_num.MaxLength = 20;
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(155, 21);
            this.txt_num.TabIndex = 151;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(260, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 150;
            this.label19.Text = "数量(件)：";
            // 
            // cmb_specs
            // 
            this.cmb_specs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_specs.FormattingEnabled = true;
            this.cmb_specs.Location = new System.Drawing.Point(66, 40);
            this.cmb_specs.Name = "cmb_specs";
            this.cmb_specs.Size = new System.Drawing.Size(155, 20);
            this.cmb_specs.TabIndex = 149;
            // 
            // lbl_specs
            // 
            this.lbl_specs.AutoSize = true;
            this.lbl_specs.ForeColor = System.Drawing.Color.Black;
            this.lbl_specs.Location = new System.Drawing.Point(4, 43);
            this.lbl_specs.Name = "lbl_specs";
            this.lbl_specs.Size = new System.Drawing.Size(65, 12);
            this.lbl_specs.TabIndex = 148;
            this.lbl_specs.Text = "原料规格：";
            // 
            // cmb_materials
            // 
            this.cmb_materials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_materials.FormattingEnabled = true;
            this.cmb_materials.Location = new System.Drawing.Point(327, 14);
            this.cmb_materials.Name = "cmb_materials";
            this.cmb_materials.Size = new System.Drawing.Size(152, 20);
            this.cmb_materials.TabIndex = 147;
            this.cmb_materials.SelectedIndexChanged += new System.EventHandler(this.cmb_materials_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(260, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 146;
            this.label15.Text = "原料名称：";
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Location = new System.Drawing.Point(504, 12);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(75, 43);
            this.btn_AddNew.TabIndex = 124;
            this.btn_AddNew.Text = "增加";
            this.btn_AddNew.UseVisualStyleBackColor = true;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // grb_detail
            // 
            this.grb_detail.Controls.Add(this.grb_new);
            this.grb_detail.Controls.Add(this.dataGridView1);
            this.grb_detail.Location = new System.Drawing.Point(31, 284);
            this.grb_detail.Name = "grb_detail";
            this.grb_detail.Size = new System.Drawing.Size(733, 242);
            this.grb_detail.TabIndex = 112;
            this.grb_detail.TabStop = false;
            this.grb_detail.Text = "出库原料";
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
            this.requestOutputWeight,
            this.specsId,
            this.requestOutputNum,
            this.realityOutputNum,
            this.statusName,
            this.outputBtn,
            this.deleteBtn,
            this.materialsId,
            this.statusCode});
            this.dataGridView1.Location = new System.Drawing.Point(12, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(706, 127);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
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
            this.materialsName.Width = 160;
            // 
            // requestOutputWeight
            // 
            this.requestOutputWeight.DataPropertyName = "requestOutputWeight";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.requestOutputWeight.DefaultCellStyle = dataGridViewCellStyle3;
            this.requestOutputWeight.HeaderText = "请求重量";
            this.requestOutputWeight.Name = "requestOutputWeight";
            this.requestOutputWeight.ReadOnly = true;
            // 
            // specsId
            // 
            this.specsId.DataPropertyName = "specsId";
            this.specsId.HeaderText = "规格";
            this.specsId.Name = "specsId";
            this.specsId.ReadOnly = true;
            this.specsId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.specsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.specsId.Width = 80;
            // 
            // requestOutputNum
            // 
            this.requestOutputNum.DataPropertyName = "requestOutputNum";
            this.requestOutputNum.HeaderText = "请求数";
            this.requestOutputNum.Name = "requestOutputNum";
            this.requestOutputNum.ReadOnly = true;
            this.requestOutputNum.Width = 70;
            // 
            // realityOutputNum
            // 
            this.realityOutputNum.DataPropertyName = "realityOutputNum";
            this.realityOutputNum.HeaderText = "出库数";
            this.realityOutputNum.Name = "realityOutputNum";
            this.realityOutputNum.ReadOnly = true;
            this.realityOutputNum.Width = 70;
            // 
            // statusName
            // 
            this.statusName.DataPropertyName = "statusName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusName.DefaultCellStyle = dataGridViewCellStyle4;
            this.statusName.HeaderText = "状态";
            this.statusName.Name = "statusName";
            this.statusName.ReadOnly = true;
            this.statusName.Width = 70;
            // 
            // outputBtn
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = "出库";
            this.outputBtn.DefaultCellStyle = dataGridViewCellStyle5;
            this.outputBtn.HeaderText = "出库";
            this.outputBtn.Name = "outputBtn";
            this.outputBtn.ReadOnly = true;
            this.outputBtn.Width = 60;
            // 
            // deleteBtn
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = "删除";
            this.deleteBtn.DefaultCellStyle = dataGridViewCellStyle6;
            this.deleteBtn.HeaderText = "删除";
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ReadOnly = true;
            this.deleteBtn.Width = 60;
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
            // FrmMaterialsOutDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 583);
            this.Controls.Add(this.grb_detail);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.grb_materialsOut);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMaterialsOutDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "原料出库管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMaterialsOutDetail_FormClosed);
            this.Load += new System.EventHandler(this.FrmMaterialsOutDetail_Load);
            this.grb_materialsOut.ResumeLayout(false);
            this.grb_materialsOut.PerformLayout();
            this.grb_new.ResumeLayout(false);
            this.grb_new.PerformLayout();
            this.grb_detail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_materialsOut;
        private System.Windows.Forms.TextBox txt_produceCode;
        private System.Windows.Forms.Label lbl_orderCode;
        private System.Windows.Forms.Label lbl_outputStatus;
        private System.Windows.Forms.Label lbl_outputType;
        private System.Windows.Forms.Label lbl_applyMember;
        private System.Windows.Forms.ComboBox cmb_applyBy;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cmb_outputStatus;
        private System.Windows.Forms.ComboBox cmb_outputType;
        private System.Windows.Forms.DateTimePicker dtp_applyDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_factory;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.GroupBox grb_new;
        private System.Windows.Forms.Button btn_AddNew;
        private System.Windows.Forms.GroupBox grb_detail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmb_specs;
        private System.Windows.Forms.Label lbl_specs;
        private System.Windows.Forms.ComboBox cmb_materials;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestOutputWeight;
        private System.Windows.Forms.DataGridViewComboBoxColumn specsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestOutputNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn realityOutputNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusName;
        private System.Windows.Forms.DataGridViewButtonColumn outputBtn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCode;
    }
}