namespace PMS.Frm.Store
{
    partial class FrmProductInDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductInDetail));
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_productIn = new System.Windows.Forms.GroupBox();
            this.txt_produceNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_inputNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_expiresDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_product = new System.Windows.Forms.ComboBox();
            this.dtp_produceDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_factory = new System.Windows.Forms.ComboBox();
            this.dtp_inputDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_inputStatus = new System.Windows.Forms.ComboBox();
            this.cmb_inputType = new System.Windows.Forms.ComboBox();
            this.lbl_outputStatus = new System.Windows.Forms.Label();
            this.lbl_outputType = new System.Windows.Forms.Label();
            this.lbl_saler = new System.Windows.Forms.Label();
            this.txt_produceCode = new System.Windows.Forms.TextBox();
            this.lbl_orderCode = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.grb_productIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(237, 424);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 101;
            this.btn_submit.Text = "确认入库";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(383, 424);
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
            this.lbl_title.Text = "产品入库单";
            // 
            // grb_productIn
            // 
            this.grb_productIn.Controls.Add(this.txt_produceNum);
            this.grb_productIn.Controls.Add(this.label6);
            this.grb_productIn.Controls.Add(this.txt_remark);
            this.grb_productIn.Controls.Add(this.label5);
            this.grb_productIn.Controls.Add(this.txt_inputNum);
            this.grb_productIn.Controls.Add(this.label4);
            this.grb_productIn.Controls.Add(this.dtp_expiresDate);
            this.grb_productIn.Controls.Add(this.label3);
            this.grb_productIn.Controls.Add(this.cmb_product);
            this.grb_productIn.Controls.Add(this.dtp_produceDate);
            this.grb_productIn.Controls.Add(this.label2);
            this.grb_productIn.Controls.Add(this.label1);
            this.grb_productIn.Controls.Add(this.cmb_factory);
            this.grb_productIn.Controls.Add(this.dtp_inputDate);
            this.grb_productIn.Controls.Add(this.label11);
            this.grb_productIn.Controls.Add(this.cmb_inputStatus);
            this.grb_productIn.Controls.Add(this.cmb_inputType);
            this.grb_productIn.Controls.Add(this.lbl_outputStatus);
            this.grb_productIn.Controls.Add(this.lbl_outputType);
            this.grb_productIn.Controls.Add(this.lbl_saler);
            this.grb_productIn.Controls.Add(this.txt_produceCode);
            this.grb_productIn.Controls.Add(this.lbl_orderCode);
            this.grb_productIn.Location = new System.Drawing.Point(31, 85);
            this.grb_productIn.Name = "grb_productIn";
            this.grb_productIn.Size = new System.Drawing.Size(638, 316);
            this.grb_productIn.TabIndex = 103;
            this.grb_productIn.TabStop = false;
            // 
            // txt_produceNum
            // 
            this.txt_produceNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_produceNum.Enabled = false;
            this.txt_produceNum.Location = new System.Drawing.Point(394, 69);
            this.txt_produceNum.Name = "txt_produceNum";
            this.txt_produceNum.Size = new System.Drawing.Size(222, 21);
            this.txt_produceNum.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(329, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 141;
            this.label6.Text = "生产数量：";
            // 
            // txt_remark
            // 
            this.txt_remark.Location = new System.Drawing.Point(79, 256);
            this.txt_remark.MaxLength = 100;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(537, 21);
            this.txt_remark.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 139;
            this.label5.Text = "备    注：";
            // 
            // txt_inputNum
            // 
            this.txt_inputNum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_inputNum.Location = new System.Drawing.Point(79, 212);
            this.txt_inputNum.MaxLength = 10;
            this.txt_inputNum.Name = "txt_inputNum";
            this.txt_inputNum.Size = new System.Drawing.Size(222, 21);
            this.txt_inputNum.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(16, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 126;
            this.label4.Text = "入库数量：";
            // 
            // dtp_expiresDate
            // 
            this.dtp_expiresDate.Enabled = false;
            this.dtp_expiresDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_expiresDate.Location = new System.Drawing.Point(394, 114);
            this.dtp_expiresDate.Name = "dtp_expiresDate";
            this.dtp_expiresDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_expiresDate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(328, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 125;
            this.label3.Text = "过 期 日：";
            // 
            // cmb_product
            // 
            this.cmb_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_product.FormattingEnabled = true;
            this.cmb_product.Location = new System.Drawing.Point(79, 167);
            this.cmb_product.Name = "cmb_product";
            this.cmb_product.Size = new System.Drawing.Size(222, 20);
            this.cmb_product.TabIndex = 10;
            this.cmb_product.SelectedIndexChanged += new System.EventHandler(this.cmb_product_SelectedIndexChanged);
            // 
            // dtp_produceDate
            // 
            this.dtp_produceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_produceDate.Location = new System.Drawing.Point(82, 117);
            this.dtp_produceDate.Name = "dtp_produceDate";
            this.dtp_produceDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_produceDate.TabIndex = 9;
            this.dtp_produceDate.ValueChanged += new System.EventHandler(this.dtp_produceDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(16, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 123;
            this.label2.Text = "生产日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(328, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 121;
            this.label1.Text = "工    厂：";
            // 
            // cmb_factory
            // 
            this.cmb_factory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_factory.FormattingEnabled = true;
            this.cmb_factory.Location = new System.Drawing.Point(394, 167);
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.Size = new System.Drawing.Size(222, 20);
            this.cmb_factory.TabIndex = 11;
            // 
            // dtp_inputDate
            // 
            this.dtp_inputDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inputDate.Location = new System.Drawing.Point(394, 212);
            this.dtp_inputDate.Name = "dtp_inputDate";
            this.dtp_inputDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_inputDate.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(328, 215);
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
            // lbl_saler
            // 
            this.lbl_saler.AutoSize = true;
            this.lbl_saler.ForeColor = System.Drawing.Color.Red;
            this.lbl_saler.Location = new System.Drawing.Point(16, 170);
            this.lbl_saler.Name = "lbl_saler";
            this.lbl_saler.Size = new System.Drawing.Size(65, 12);
            this.lbl_saler.TabIndex = 86;
            this.lbl_saler.Text = "入库产品：";
            // 
            // txt_produceCode
            // 
            this.txt_produceCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_produceCode.Enabled = false;
            this.txt_produceCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_produceCode.Location = new System.Drawing.Point(79, 69);
            this.txt_produceCode.MaxLength = 20;
            this.txt_produceCode.Name = "txt_produceCode";
            this.txt_produceCode.Size = new System.Drawing.Size(222, 21);
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
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(572, 424);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 103;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // FrmProductInDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(699, 476);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.grb_productIn);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductInDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品入库管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProductInDetail_FormClosed);
            this.Load += new System.EventHandler(this.FrmProductInDetail_Load);
            this.grb_productIn.ResumeLayout(false);
            this.grb_productIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_productIn;
        private System.Windows.Forms.TextBox txt_produceCode;
        private System.Windows.Forms.Label lbl_orderCode;
        private System.Windows.Forms.Label lbl_saler;
        private System.Windows.Forms.ComboBox cmb_product;
        private System.Windows.Forms.Label lbl_outputStatus;
        private System.Windows.Forms.Label lbl_outputType;
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
        private System.Windows.Forms.DateTimePicker dtp_expiresDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_produceNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_inputNum;
    }
}