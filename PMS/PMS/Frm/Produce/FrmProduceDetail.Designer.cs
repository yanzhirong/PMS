namespace PMS.Frm.Produce
{
    partial class FrmProduceDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduceDetail));
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_produce = new System.Windows.Forms.GroupBox();
            this.txt_produceCode = new System.Windows.Forms.TextBox();
            this.cmb_factory = new System.Windows.Forms.ComboBox();
            this.cmb_product = new System.Windows.Forms.ComboBox();
            this.dtp_applyDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_applyBy = new System.Windows.Forms.ComboBox();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.lbl_outputStatus = new System.Windows.Forms.Label();
            this.lbl_outputType = new System.Windows.Forms.Label();
            this.lbl_applyMember = new System.Windows.Forms.Label();
            this.lbl_orderCode = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.grb_produce.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(256, 379);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 101;
            this.btn_submit.Text = "确认";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(383, 379);
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
            this.lbl_title.Location = new System.Drawing.Point(293, 44);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(124, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "生产订单";
            // 
            // grb_produce
            // 
            this.grb_produce.Controls.Add(this.txt_produceCode);
            this.grb_produce.Controls.Add(this.cmb_factory);
            this.grb_produce.Controls.Add(this.cmb_product);
            this.grb_produce.Controls.Add(this.dtp_applyDate);
            this.grb_produce.Controls.Add(this.cmb_applyBy);
            this.grb_produce.Controls.Add(this.txt_remark);
            this.grb_produce.Controls.Add(this.label9);
            this.grb_produce.Controls.Add(this.txt_num);
            this.grb_produce.Controls.Add(this.label1);
            this.grb_produce.Controls.Add(this.label8);
            this.grb_produce.Controls.Add(this.label7);
            this.grb_produce.Controls.Add(this.dtp_deliveryDate);
            this.grb_produce.Controls.Add(this.label11);
            this.grb_produce.Controls.Add(this.cmb_status);
            this.grb_produce.Controls.Add(this.lbl_outputStatus);
            this.grb_produce.Controls.Add(this.lbl_outputType);
            this.grb_produce.Controls.Add(this.lbl_applyMember);
            this.grb_produce.Controls.Add(this.lbl_orderCode);
            this.grb_produce.Location = new System.Drawing.Point(31, 85);
            this.grb_produce.Name = "grb_produce";
            this.grb_produce.Size = new System.Drawing.Size(634, 267);
            this.grb_produce.TabIndex = 103;
            this.grb_produce.TabStop = false;
            // 
            // txt_produceCode
            // 
            this.txt_produceCode.BackColor = System.Drawing.Color.LightGray;
            this.txt_produceCode.Enabled = false;
            this.txt_produceCode.Location = new System.Drawing.Point(78, 25);
            this.txt_produceCode.Name = "txt_produceCode";
            this.txt_produceCode.Size = new System.Drawing.Size(220, 21);
            this.txt_produceCode.TabIndex = 134;
            // 
            // cmb_factory
            // 
            this.cmb_factory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_factory.FormattingEnabled = true;
            this.cmb_factory.Items.AddRange(new object[] {
            "生产申请",
            "特殊申请"});
            this.cmb_factory.Location = new System.Drawing.Point(385, 116);
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.Size = new System.Drawing.Size(221, 20);
            this.cmb_factory.TabIndex = 133;
            // 
            // cmb_product
            // 
            this.cmb_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_product.FormattingEnabled = true;
            this.cmb_product.Items.AddRange(new object[] {
            "生产申请",
            "特殊申请"});
            this.cmb_product.Location = new System.Drawing.Point(77, 116);
            this.cmb_product.Name = "cmb_product";
            this.cmb_product.Size = new System.Drawing.Size(221, 20);
            this.cmb_product.TabIndex = 132;
            // 
            // dtp_applyDate
            // 
            this.dtp_applyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_applyDate.Location = new System.Drawing.Point(384, 69);
            this.dtp_applyDate.Name = "dtp_applyDate";
            this.dtp_applyDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_applyDate.TabIndex = 131;
            // 
            // cmb_applyBy
            // 
            this.cmb_applyBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_applyBy.FormattingEnabled = true;
            this.cmb_applyBy.Items.AddRange(new object[] {
            "生产申请",
            "特殊申请"});
            this.cmb_applyBy.Location = new System.Drawing.Point(77, 70);
            this.cmb_applyBy.Name = "cmb_applyBy";
            this.cmb_applyBy.Size = new System.Drawing.Size(221, 20);
            this.cmb_applyBy.TabIndex = 130;
            // 
            // txt_remark
            // 
            this.txt_remark.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_remark.Location = new System.Drawing.Point(77, 216);
            this.txt_remark.MaxLength = 20;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(529, 21);
            this.txt_remark.TabIndex = 121;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(16, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 122;
            this.label9.Text = "备    注：";
            // 
            // txt_num
            // 
            this.txt_num.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_num.Location = new System.Drawing.Point(78, 164);
            this.txt_num.MaxLength = 20;
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(220, 21);
            this.txt_num.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 128;
            this.label1.Text = "生产数量：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(320, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 126;
            this.label8.Text = "申请日期：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(320, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 123;
            this.label7.Text = "工    厂：";
            // 
            // dtp_deliveryDate
            // 
            this.dtp_deliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_deliveryDate.Location = new System.Drawing.Point(384, 164);
            this.dtp_deliveryDate.Name = "dtp_deliveryDate";
            this.dtp_deliveryDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_deliveryDate.TabIndex = 118;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(320, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 119;
            this.label11.Text = "交货日期：";
            // 
            // cmb_status
            // 
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "财务未确认",
            "财务已确认",
            "物料已入库"});
            this.cmb_status.Location = new System.Drawing.Point(384, 25);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(222, 20);
            this.cmb_status.TabIndex = 117;
            // 
            // lbl_outputStatus
            // 
            this.lbl_outputStatus.AutoSize = true;
            this.lbl_outputStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_outputStatus.Location = new System.Drawing.Point(320, 29);
            this.lbl_outputStatus.Name = "lbl_outputStatus";
            this.lbl_outputStatus.Size = new System.Drawing.Size(65, 12);
            this.lbl_outputStatus.TabIndex = 115;
            this.lbl_outputStatus.Text = "生产状态：";
            // 
            // lbl_outputType
            // 
            this.lbl_outputType.AutoSize = true;
            this.lbl_outputType.ForeColor = System.Drawing.Color.Red;
            this.lbl_outputType.Location = new System.Drawing.Point(16, 28);
            this.lbl_outputType.Name = "lbl_outputType";
            this.lbl_outputType.Size = new System.Drawing.Size(65, 12);
            this.lbl_outputType.TabIndex = 113;
            this.lbl_outputType.Text = "生产单号：";
            // 
            // lbl_applyMember
            // 
            this.lbl_applyMember.AutoSize = true;
            this.lbl_applyMember.ForeColor = System.Drawing.Color.Red;
            this.lbl_applyMember.Location = new System.Drawing.Point(16, 73);
            this.lbl_applyMember.Name = "lbl_applyMember";
            this.lbl_applyMember.Size = new System.Drawing.Size(65, 12);
            this.lbl_applyMember.TabIndex = 112;
            this.lbl_applyMember.Text = "申 请 者：";
            // 
            // lbl_orderCode
            // 
            this.lbl_orderCode.AutoSize = true;
            this.lbl_orderCode.ForeColor = System.Drawing.Color.Red;
            this.lbl_orderCode.Location = new System.Drawing.Point(16, 119);
            this.lbl_orderCode.Name = "lbl_orderCode";
            this.lbl_orderCode.Size = new System.Drawing.Size(65, 12);
            this.lbl_orderCode.TabIndex = 42;
            this.lbl_orderCode.Text = "产    品：";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(562, 379);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 106;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // FrmProduceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(702, 442);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.grb_produce);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProduceDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生产管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProduceDetail_FormClosed);
            this.Load += new System.EventHandler(this.FrmProduceDetail_Load);
            this.grb_produce.ResumeLayout(false);
            this.grb_produce.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_produce;
        private System.Windows.Forms.Label lbl_orderCode;
        private System.Windows.Forms.Label lbl_outputStatus;
        private System.Windows.Forms.Label lbl_outputType;
        private System.Windows.Forms.Label lbl_applyMember;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.DateTimePicker dtp_deliveryDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_applyBy;
        private System.Windows.Forms.ComboBox cmb_factory;
        private System.Windows.Forms.ComboBox cmb_product;
        private System.Windows.Forms.DateTimePicker dtp_applyDate;
        private System.Windows.Forms.TextBox txt_produceCode;
    }
}