namespace PMS.Frm.Store
{
    partial class FrmMaterialsInDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaterialsInDetail));
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_materialsIn = new System.Windows.Forms.GroupBox();
            this.txt_purchaseNum = new System.Windows.Forms.TextBox();
            this.cmb_purchaseUnit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_inputNum = new System.Windows.Forms.TextBox();
            this.cmb_inputUint = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_purchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_materials = new System.Windows.Forms.ComboBox();
            this.dtp_produceDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_factory = new System.Windows.Forms.ComboBox();
            this.dtp_inputDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_inputStatus = new System.Windows.Forms.ComboBox();
            this.cmb_inputType = new System.Windows.Forms.ComboBox();
            this.cmb_supplier = new System.Windows.Forms.ComboBox();
            this.lbl_outputStatus = new System.Windows.Forms.Label();
            this.lbl_outputType = new System.Windows.Forms.Label();
            this.lbl_applyMember = new System.Windows.Forms.Label();
            this.cmb_purchaseBy = new System.Windows.Forms.ComboBox();
            this.lbl_saler = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_purchaseCode = new System.Windows.Forms.TextBox();
            this.lbl_orderCode = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.grb_materialsIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(237, 459);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 101;
            this.btn_submit.Text = "确认入库";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(383, 459);
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
            this.lbl_title.Location = new System.Drawing.Point(272, 38);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(152, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "物料入库单";
            // 
            // grb_materialsIn
            // 
            this.grb_materialsIn.Controls.Add(this.txt_purchaseNum);
            this.grb_materialsIn.Controls.Add(this.cmb_purchaseUnit);
            this.grb_materialsIn.Controls.Add(this.label6);
            this.grb_materialsIn.Controls.Add(this.txt_remark);
            this.grb_materialsIn.Controls.Add(this.label5);
            this.grb_materialsIn.Controls.Add(this.txt_inputNum);
            this.grb_materialsIn.Controls.Add(this.cmb_inputUint);
            this.grb_materialsIn.Controls.Add(this.label4);
            this.grb_materialsIn.Controls.Add(this.dtp_purchaseDate);
            this.grb_materialsIn.Controls.Add(this.label3);
            this.grb_materialsIn.Controls.Add(this.cmb_materials);
            this.grb_materialsIn.Controls.Add(this.dtp_produceDate);
            this.grb_materialsIn.Controls.Add(this.label2);
            this.grb_materialsIn.Controls.Add(this.label1);
            this.grb_materialsIn.Controls.Add(this.cmb_factory);
            this.grb_materialsIn.Controls.Add(this.dtp_inputDate);
            this.grb_materialsIn.Controls.Add(this.label11);
            this.grb_materialsIn.Controls.Add(this.cmb_inputStatus);
            this.grb_materialsIn.Controls.Add(this.cmb_inputType);
            this.grb_materialsIn.Controls.Add(this.cmb_supplier);
            this.grb_materialsIn.Controls.Add(this.lbl_outputStatus);
            this.grb_materialsIn.Controls.Add(this.lbl_outputType);
            this.grb_materialsIn.Controls.Add(this.lbl_applyMember);
            this.grb_materialsIn.Controls.Add(this.cmb_purchaseBy);
            this.grb_materialsIn.Controls.Add(this.lbl_saler);
            this.grb_materialsIn.Controls.Add(this.label10);
            this.grb_materialsIn.Controls.Add(this.txt_purchaseCode);
            this.grb_materialsIn.Controls.Add(this.lbl_orderCode);
            this.grb_materialsIn.Location = new System.Drawing.Point(31, 85);
            this.grb_materialsIn.Name = "grb_materialsIn";
            this.grb_materialsIn.Size = new System.Drawing.Size(638, 349);
            this.grb_materialsIn.TabIndex = 103;
            this.grb_materialsIn.TabStop = false;
            // 
            // txt_purchaseNum
            // 
            this.txt_purchaseNum.BackColor = System.Drawing.Color.White;
            this.txt_purchaseNum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_purchaseNum.Location = new System.Drawing.Point(81, 114);
            this.txt_purchaseNum.MaxLength = 12;
            this.txt_purchaseNum.Name = "txt_purchaseNum";
            this.txt_purchaseNum.Size = new System.Drawing.Size(160, 21);
            this.txt_purchaseNum.TabIndex = 5;
            // 
            // cmb_purchaseUnit
            // 
            this.cmb_purchaseUnit.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_purchaseUnit.FormattingEnabled = true;
            this.cmb_purchaseUnit.Location = new System.Drawing.Point(247, 114);
            this.cmb_purchaseUnit.Name = "cmb_purchaseUnit";
            this.cmb_purchaseUnit.Size = new System.Drawing.Size(54, 20);
            this.cmb_purchaseUnit.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 141;
            this.label6.Text = "采购数量：";
            // 
            // txt_remark
            // 
            this.txt_remark.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_remark.Location = new System.Drawing.Point(79, 296);
            this.txt_remark.MaxLength = 100;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(537, 21);
            this.txt_remark.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 139;
            this.label5.Text = "备    注：";
            // 
            // txt_inputNum
            // 
            this.txt_inputNum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_inputNum.Location = new System.Drawing.Point(79, 252);
            this.txt_inputNum.MaxLength = 12;
            this.txt_inputNum.Name = "txt_inputNum";
            this.txt_inputNum.Size = new System.Drawing.Size(162, 21);
            this.txt_inputNum.TabIndex = 12;
            // 
            // cmb_inputUint
            // 
            this.cmb_inputUint.FormattingEnabled = true;
            this.cmb_inputUint.Location = new System.Drawing.Point(247, 252);
            this.cmb_inputUint.Name = "cmb_inputUint";
            this.cmb_inputUint.Size = new System.Drawing.Size(54, 20);
            this.cmb_inputUint.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(16, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 126;
            this.label4.Text = "入库数量：";
            // 
            // dtp_purchaseDate
            // 
            this.dtp_purchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_purchaseDate.Location = new System.Drawing.Point(394, 114);
            this.dtp_purchaseDate.Name = "dtp_purchaseDate";
            this.dtp_purchaseDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_purchaseDate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(328, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 125;
            this.label3.Text = "采购日期：";
            // 
            // cmb_materials
            // 
            this.cmb_materials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_materials.FormattingEnabled = true;
            this.cmb_materials.Location = new System.Drawing.Point(79, 207);
            this.cmb_materials.Name = "cmb_materials";
            this.cmb_materials.Size = new System.Drawing.Size(222, 20);
            this.cmb_materials.TabIndex = 10;
            // 
            // dtp_produceDate
            // 
            this.dtp_produceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_produceDate.Location = new System.Drawing.Point(394, 160);
            this.dtp_produceDate.Name = "dtp_produceDate";
            this.dtp_produceDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_produceDate.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(328, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 123;
            this.label2.Text = "生产日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(328, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 121;
            this.label1.Text = "工    厂：";
            // 
            // cmb_factory
            // 
            this.cmb_factory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_factory.FormattingEnabled = true;
            this.cmb_factory.Location = new System.Drawing.Point(394, 207);
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.Size = new System.Drawing.Size(222, 20);
            this.cmb_factory.TabIndex = 11;
            // 
            // dtp_inputDate
            // 
            this.dtp_inputDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inputDate.Location = new System.Drawing.Point(394, 252);
            this.dtp_inputDate.Name = "dtp_inputDate";
            this.dtp_inputDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_inputDate.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(328, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 119;
            this.label11.Text = "入库日期：";
            // 
            // cmb_inputStatus
            // 
            this.cmb_inputStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_inputStatus.FormattingEnabled = true;
            this.cmb_inputStatus.Items.AddRange(new object[] {
            "请求入库",
            "完成入库"});
            this.cmb_inputStatus.Location = new System.Drawing.Point(394, 25);
            this.cmb_inputStatus.Name = "cmb_inputStatus";
            this.cmb_inputStatus.Size = new System.Drawing.Size(222, 20);
            this.cmb_inputStatus.TabIndex = 2;
            // 
            // cmb_inputType
            // 
            this.cmb_inputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_inputType.FormattingEnabled = true;
            this.cmb_inputType.Location = new System.Drawing.Point(80, 25);
            this.cmb_inputType.Name = "cmb_inputType";
            this.cmb_inputType.Size = new System.Drawing.Size(221, 20);
            this.cmb_inputType.TabIndex = 1;
            // 
            // cmb_supplier
            // 
            this.cmb_supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_supplier.FormattingEnabled = true;
            this.cmb_supplier.Location = new System.Drawing.Point(80, 160);
            this.cmb_supplier.Name = "cmb_supplier";
            this.cmb_supplier.Size = new System.Drawing.Size(221, 20);
            this.cmb_supplier.TabIndex = 8;
            // 
            // lbl_outputStatus
            // 
            this.lbl_outputStatus.AutoSize = true;
            this.lbl_outputStatus.ForeColor = System.Drawing.Color.Black;
            this.lbl_outputStatus.Location = new System.Drawing.Point(328, 29);
            this.lbl_outputStatus.Name = "lbl_outputStatus";
            this.lbl_outputStatus.Size = new System.Drawing.Size(65, 12);
            this.lbl_outputStatus.TabIndex = 115;
            this.lbl_outputStatus.Text = "入库状态：";
            // 
            // lbl_outputType
            // 
            this.lbl_outputType.AutoSize = true;
            this.lbl_outputType.ForeColor = System.Drawing.Color.Black;
            this.lbl_outputType.Location = new System.Drawing.Point(16, 28);
            this.lbl_outputType.Name = "lbl_outputType";
            this.lbl_outputType.Size = new System.Drawing.Size(65, 12);
            this.lbl_outputType.TabIndex = 113;
            this.lbl_outputType.Text = "入库类型：";
            // 
            // lbl_applyMember
            // 
            this.lbl_applyMember.AutoSize = true;
            this.lbl_applyMember.ForeColor = System.Drawing.Color.Black;
            this.lbl_applyMember.Location = new System.Drawing.Point(328, 72);
            this.lbl_applyMember.Name = "lbl_applyMember";
            this.lbl_applyMember.Size = new System.Drawing.Size(65, 12);
            this.lbl_applyMember.TabIndex = 112;
            this.lbl_applyMember.Text = "采 购 员：";
            // 
            // cmb_purchaseBy
            // 
            this.cmb_purchaseBy.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_purchaseBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_purchaseBy.FormattingEnabled = true;
            this.cmb_purchaseBy.Location = new System.Drawing.Point(394, 69);
            this.cmb_purchaseBy.Name = "cmb_purchaseBy";
            this.cmb_purchaseBy.Size = new System.Drawing.Size(222, 20);
            this.cmb_purchaseBy.TabIndex = 4;
            // 
            // lbl_saler
            // 
            this.lbl_saler.AutoSize = true;
            this.lbl_saler.ForeColor = System.Drawing.Color.Red;
            this.lbl_saler.Location = new System.Drawing.Point(16, 210);
            this.lbl_saler.Name = "lbl_saler";
            this.lbl_saler.Size = new System.Drawing.Size(65, 12);
            this.lbl_saler.TabIndex = 86;
            this.lbl_saler.Text = "入库物料：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(16, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 79;
            this.label10.Text = "供 应 商：";
            // 
            // txt_purchaseCode
            // 
            this.txt_purchaseCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_purchaseCode.Enabled = false;
            this.txt_purchaseCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_purchaseCode.Location = new System.Drawing.Point(79, 69);
            this.txt_purchaseCode.MaxLength = 20;
            this.txt_purchaseCode.Name = "txt_purchaseCode";
            this.txt_purchaseCode.Size = new System.Drawing.Size(222, 21);
            this.txt_purchaseCode.TabIndex = 3;
            // 
            // lbl_orderCode
            // 
            this.lbl_orderCode.AutoSize = true;
            this.lbl_orderCode.ForeColor = System.Drawing.Color.Black;
            this.lbl_orderCode.Location = new System.Drawing.Point(16, 72);
            this.lbl_orderCode.Name = "lbl_orderCode";
            this.lbl_orderCode.Size = new System.Drawing.Size(65, 12);
            this.lbl_orderCode.TabIndex = 42;
            this.lbl_orderCode.Text = "采购单号：";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(572, 459);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 103;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // FrmMaterialsInDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(699, 501);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.grb_materialsIn);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMaterialsInDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物料入库管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMaterialsInDetail_FormClosed);
            this.Load += new System.EventHandler(this.FrmMaterialsInDetail_Load);
            this.grb_materialsIn.ResumeLayout(false);
            this.grb_materialsIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_materialsIn;
        private System.Windows.Forms.TextBox txt_purchaseCode;
        private System.Windows.Forms.Label lbl_orderCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_supplier;
        private System.Windows.Forms.Label lbl_saler;
        private System.Windows.Forms.ComboBox cmb_materials;
        private System.Windows.Forms.Label lbl_outputStatus;
        private System.Windows.Forms.Label lbl_outputType;
        private System.Windows.Forms.Label lbl_applyMember;
        private System.Windows.Forms.ComboBox cmb_purchaseBy;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cmb_inputStatus;
        private System.Windows.Forms.ComboBox cmb_inputType;
        private System.Windows.Forms.DateTimePicker dtp_inputDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_factory;
        private System.Windows.Forms.DateTimePicker dtp_produceDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_purchaseDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_inputUint;
        private System.Windows.Forms.TextBox txt_purchaseNum;
        private System.Windows.Forms.ComboBox cmb_purchaseUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_inputNum;
    }
}