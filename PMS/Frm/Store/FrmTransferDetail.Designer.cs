namespace PMS.Frm.Store
{
    partial class FrmTransferDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransferDetail));
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_transfer = new System.Windows.Forms.GroupBox();
            this.cmb_transferBy = new System.Windows.Forms.ComboBox();
            this.cmb_applyBy = new System.Windows.Forms.ComboBox();
            this.cmb_fromFactory = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_applyDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_transferObject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_toFactory = new System.Windows.Forms.ComboBox();
            this.dtp_transferDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.lbl_outputType = new System.Windows.Forms.Label();
            this.lbl_transferObject = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.grb_transfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(237, 545);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 101;
            this.btn_submit.Text = "确认入库";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(383, 545);
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
            this.lbl_title.Location = new System.Drawing.Point(312, 44);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(96, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "调拨单";
            // 
            // grb_transfer
            // 
            this.grb_transfer.Controls.Add(this.cmb_transferBy);
            this.grb_transfer.Controls.Add(this.cmb_applyBy);
            this.grb_transfer.Controls.Add(this.cmb_fromFactory);
            this.grb_transfer.Controls.Add(this.dataGridView1);
            this.grb_transfer.Controls.Add(this.label7);
            this.grb_transfer.Controls.Add(this.label6);
            this.grb_transfer.Controls.Add(this.txt_remark);
            this.grb_transfer.Controls.Add(this.label5);
            this.grb_transfer.Controls.Add(this.label4);
            this.grb_transfer.Controls.Add(this.dtp_applyDate);
            this.grb_transfer.Controls.Add(this.label3);
            this.grb_transfer.Controls.Add(this.cmb_transferObject);
            this.grb_transfer.Controls.Add(this.label2);
            this.grb_transfer.Controls.Add(this.label1);
            this.grb_transfer.Controls.Add(this.cmb_toFactory);
            this.grb_transfer.Controls.Add(this.dtp_transferDate);
            this.grb_transfer.Controls.Add(this.label11);
            this.grb_transfer.Controls.Add(this.cmb_type);
            this.grb_transfer.Controls.Add(this.lbl_outputType);
            this.grb_transfer.Controls.Add(this.lbl_transferObject);
            this.grb_transfer.Location = new System.Drawing.Point(31, 85);
            this.grb_transfer.Name = "grb_transfer";
            this.grb_transfer.Size = new System.Drawing.Size(638, 437);
            this.grb_transfer.TabIndex = 103;
            this.grb_transfer.TabStop = false;
            // 
            // cmb_transferBy
            // 
            this.cmb_transferBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_transferBy.Enabled = false;
            this.cmb_transferBy.FormattingEnabled = true;
            this.cmb_transferBy.Items.AddRange(new object[] {
            "请求入库",
            "完成入库"});
            this.cmb_transferBy.Location = new System.Drawing.Point(80, 300);
            this.cmb_transferBy.Name = "cmb_transferBy";
            this.cmb_transferBy.Size = new System.Drawing.Size(222, 20);
            this.cmb_transferBy.TabIndex = 9;
            // 
            // cmb_applyBy
            // 
            this.cmb_applyBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_applyBy.Enabled = false;
            this.cmb_applyBy.FormattingEnabled = true;
            this.cmb_applyBy.Items.AddRange(new object[] {
            "请求入库",
            "完成入库"});
            this.cmb_applyBy.Location = new System.Drawing.Point(81, 348);
            this.cmb_applyBy.Name = "cmb_applyBy";
            this.cmb_applyBy.Size = new System.Drawing.Size(222, 20);
            this.cmb_applyBy.TabIndex = 5;
            // 
            // cmb_fromFactory
            // 
            this.cmb_fromFactory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_fromFactory.FormattingEnabled = true;
            this.cmb_fromFactory.Location = new System.Drawing.Point(79, 72);
            this.cmb_fromFactory.Name = "cmb_fromFactory";
            this.cmb_fromFactory.Size = new System.Drawing.Size(222, 20);
            this.cmb_fromFactory.TabIndex = 7;
            this.cmb_fromFactory.SelectedIndexChanged += new System.EventHandler(this.cmb_fromFactory_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(598, 136);
            this.dataGridView1.TabIndex = 145;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(16, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 144;
            this.label7.Text = "调 拨 人：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(16, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 142;
            this.label6.Text = "来源工厂：";
            // 
            // txt_remark
            // 
            this.txt_remark.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_remark.Location = new System.Drawing.Point(79, 392);
            this.txt_remark.MaxLength = 100;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(537, 21);
            this.txt_remark.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 139;
            this.label5.Text = "备    注：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(16, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 126;
            this.label4.Text = "调拨数量：";
            // 
            // dtp_applyDate
            // 
            this.dtp_applyDate.Enabled = false;
            this.dtp_applyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_applyDate.Location = new System.Drawing.Point(395, 347);
            this.dtp_applyDate.Name = "dtp_applyDate";
            this.dtp_applyDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_applyDate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(329, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 125;
            this.label3.Text = "申请日期：";
            // 
            // cmb_transferObject
            // 
            this.cmb_transferObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_transferObject.FormattingEnabled = true;
            this.cmb_transferObject.Location = new System.Drawing.Point(394, 25);
            this.cmb_transferObject.Name = "cmb_transferObject";
            this.cmb_transferObject.Size = new System.Drawing.Size(222, 20);
            this.cmb_transferObject.TabIndex = 2;
            this.cmb_transferObject.SelectedIndexChanged += new System.EventHandler(this.cmb_transferObject_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 123;
            this.label2.Text = "申 请 人：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(328, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 121;
            this.label1.Text = "目标工厂：";
            // 
            // cmb_toFactory
            // 
            this.cmb_toFactory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_toFactory.FormattingEnabled = true;
            this.cmb_toFactory.Location = new System.Drawing.Point(394, 72);
            this.cmb_toFactory.Name = "cmb_toFactory";
            this.cmb_toFactory.Size = new System.Drawing.Size(222, 20);
            this.cmb_toFactory.TabIndex = 8;
            // 
            // dtp_transferDate
            // 
            this.dtp_transferDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_transferDate.Location = new System.Drawing.Point(394, 302);
            this.dtp_transferDate.Name = "dtp_transferDate";
            this.dtp_transferDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_transferDate.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(328, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 119;
            this.label11.Text = "调拨日期：";
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "",
            "成品调拨",
            "原料调拨"});
            this.cmb_type.Location = new System.Drawing.Point(80, 25);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(221, 20);
            this.cmb_type.TabIndex = 1;
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.cmb_type_SelectedIndexChanged);
            // 
            // lbl_outputType
            // 
            this.lbl_outputType.AutoSize = true;
            this.lbl_outputType.ForeColor = System.Drawing.Color.Red;
            this.lbl_outputType.Location = new System.Drawing.Point(16, 28);
            this.lbl_outputType.Name = "lbl_outputType";
            this.lbl_outputType.Size = new System.Drawing.Size(65, 12);
            this.lbl_outputType.TabIndex = 113;
            this.lbl_outputType.Text = "调拨类型：";
            // 
            // lbl_transferObject
            // 
            this.lbl_transferObject.AutoSize = true;
            this.lbl_transferObject.ForeColor = System.Drawing.Color.Red;
            this.lbl_transferObject.Location = new System.Drawing.Point(328, 28);
            this.lbl_transferObject.Name = "lbl_transferObject";
            this.lbl_transferObject.Size = new System.Drawing.Size(65, 12);
            this.lbl_transferObject.TabIndex = 86;
            this.lbl_transferObject.Text = "调拨成品：";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(572, 545);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 103;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // FrmTransferDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(717, 593);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.grb_transfer);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTransferDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "调拨管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTransferDetail_FormClosed);
            this.Load += new System.EventHandler(this.FrmTransferDetail_Load);
            this.grb_transfer.ResumeLayout(false);
            this.grb_transfer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_transfer;
        private System.Windows.Forms.Label lbl_transferObject;
        private System.Windows.Forms.ComboBox cmb_transferObject;
        private System.Windows.Forms.Label lbl_outputType;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cmb_applyBy;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.DateTimePicker dtp_transferDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_toFactory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_applyDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_transferBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_fromFactory;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}