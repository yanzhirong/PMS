namespace PMS.Frm.Store
{
    partial class FrmInventoryDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventoryDetail));
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_productIn = new System.Windows.Forms.GroupBox();
            this.cmb_uint = new System.Windows.Forms.ComboBox();
            this.txt_inputNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_stockNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_expiresDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_produceDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_inputDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_factory = new System.Windows.Forms.TextBox();
            this.lbl_orderCode = new System.Windows.Forms.Label();
            this.txt_inputUnit = new System.Windows.Forms.TextBox();
            this.grb_productIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(237, 403);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 101;
            this.btn_submit.Text = "确认入库";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(383, 403);
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
            this.lbl_title.Size = new System.Drawing.Size(124, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "库存设置";
            // 
            // grb_productIn
            // 
            this.grb_productIn.Controls.Add(this.txt_inputUnit);
            this.grb_productIn.Controls.Add(this.cmb_uint);
            this.grb_productIn.Controls.Add(this.txt_inputNum);
            this.grb_productIn.Controls.Add(this.label1);
            this.grb_productIn.Controls.Add(this.txt_name);
            this.grb_productIn.Controls.Add(this.label6);
            this.grb_productIn.Controls.Add(this.txt_remark);
            this.grb_productIn.Controls.Add(this.label5);
            this.grb_productIn.Controls.Add(this.txt_stockNum);
            this.grb_productIn.Controls.Add(this.label4);
            this.grb_productIn.Controls.Add(this.dtp_expiresDate);
            this.grb_productIn.Controls.Add(this.label3);
            this.grb_productIn.Controls.Add(this.dtp_produceDate);
            this.grb_productIn.Controls.Add(this.label2);
            this.grb_productIn.Controls.Add(this.dtp_inputDate);
            this.grb_productIn.Controls.Add(this.label11);
            this.grb_productIn.Controls.Add(this.txt_factory);
            this.grb_productIn.Controls.Add(this.lbl_orderCode);
            this.grb_productIn.Location = new System.Drawing.Point(31, 85);
            this.grb_productIn.Name = "grb_productIn";
            this.grb_productIn.Size = new System.Drawing.Size(638, 300);
            this.grb_productIn.TabIndex = 103;
            this.grb_productIn.TabStop = false;
            // 
            // cmb_uint
            // 
            this.cmb_uint.Enabled = false;
            this.cmb_uint.FormattingEnabled = true;
            this.cmb_uint.Location = new System.Drawing.Point(250, 164);
            this.cmb_uint.Name = "cmb_uint";
            this.cmb_uint.Size = new System.Drawing.Size(54, 20);
            this.cmb_uint.TabIndex = 8;
            // 
            // txt_inputNum
            // 
            this.txt_inputNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_inputNum.Enabled = false;
            this.txt_inputNum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_inputNum.Location = new System.Drawing.Point(79, 74);
            this.txt_inputNum.MaxLength = 20;
            this.txt_inputNum.Name = "txt_inputNum";
            this.txt_inputNum.Size = new System.Drawing.Size(165, 21);
            this.txt_inputNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 143;
            this.label1.Text = "入库数量：";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(394, 33);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(222, 21);
            this.txt_name.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(329, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 141;
            this.label6.Text = "名    称：";
            // 
            // txt_remark
            // 
            this.txt_remark.Location = new System.Drawing.Point(79, 213);
            this.txt_remark.MaxLength = 100;
            this.txt_remark.Multiline = true;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(537, 70);
            this.txt_remark.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(16, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 139;
            this.label5.Text = "备    注：";
            // 
            // txt_stockNum
            // 
            this.txt_stockNum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_stockNum.Location = new System.Drawing.Point(79, 163);
            this.txt_stockNum.MaxLength = 10;
            this.txt_stockNum.Name = "txt_stockNum";
            this.txt_stockNum.Size = new System.Drawing.Size(165, 21);
            this.txt_stockNum.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(16, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 126;
            this.label4.Text = "库存数量：";
            // 
            // dtp_expiresDate
            // 
            this.dtp_expiresDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_expiresDate.Location = new System.Drawing.Point(394, 114);
            this.dtp_expiresDate.Name = "dtp_expiresDate";
            this.dtp_expiresDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_expiresDate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(328, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 125;
            this.label3.Text = "过 期 日：";
            // 
            // dtp_produceDate
            // 
            this.dtp_produceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_produceDate.Location = new System.Drawing.Point(82, 117);
            this.dtp_produceDate.Name = "dtp_produceDate";
            this.dtp_produceDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_produceDate.TabIndex = 5;
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
            // dtp_inputDate
            // 
            this.dtp_inputDate.Enabled = false;
            this.dtp_inputDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inputDate.Location = new System.Drawing.Point(395, 74);
            this.dtp_inputDate.Name = "dtp_inputDate";
            this.dtp_inputDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_inputDate.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(329, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 119;
            this.label11.Text = "入库日期：";
            // 
            // txt_factory
            // 
            this.txt_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_factory.Enabled = false;
            this.txt_factory.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_factory.Location = new System.Drawing.Point(79, 33);
            this.txt_factory.MaxLength = 20;
            this.txt_factory.Name = "txt_factory";
            this.txt_factory.Size = new System.Drawing.Size(222, 21);
            this.txt_factory.TabIndex = 1;
            // 
            // lbl_orderCode
            // 
            this.lbl_orderCode.AutoSize = true;
            this.lbl_orderCode.ForeColor = System.Drawing.Color.Black;
            this.lbl_orderCode.Location = new System.Drawing.Point(16, 36);
            this.lbl_orderCode.Name = "lbl_orderCode";
            this.lbl_orderCode.Size = new System.Drawing.Size(65, 12);
            this.lbl_orderCode.TabIndex = 42;
            this.lbl_orderCode.Text = "工    厂：";
            // 
            // txt_inputUnit
            // 
            this.txt_inputUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_inputUnit.Enabled = false;
            this.txt_inputUnit.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_inputUnit.Location = new System.Drawing.Point(251, 74);
            this.txt_inputUnit.MaxLength = 20;
            this.txt_inputUnit.Name = "txt_inputUnit";
            this.txt_inputUnit.Size = new System.Drawing.Size(50, 21);
            this.txt_inputUnit.TabIndex = 144;
            // 
            // FrmInventoryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(699, 459);
            this.Controls.Add(this.grb_productIn);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInventoryDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmInventoryDetail_FormClosed);
            this.Load += new System.EventHandler(this.FrmInventoryDetail_Load);
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
        private System.Windows.Forms.TextBox txt_factory;
        private System.Windows.Forms.Label lbl_orderCode;
        private System.Windows.Forms.DateTimePicker dtp_inputDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_produceDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_expiresDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_stockNum;
        private System.Windows.Forms.TextBox txt_inputNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_uint;
        private System.Windows.Forms.TextBox txt_inputUnit;
    }
}