namespace PMS.Frm.Finance
{
    partial class FrmPaidDetailAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaidDetailAdd));
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_productOut = new System.Windows.Forms.GroupBox();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.txt_otherType = new System.Windows.Forms.TextBox();
            this.cmb_paidType = new System.Windows.Forms.ComboBox();
            this.dtp_paidDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_paidMoney = new System.Windows.Forms.TextBox();
            this.lbl_orderCode = new System.Windows.Forms.Label();
            this.grb_productOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(224, 329);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 101;
            this.btn_submit.Text = "确认";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(417, 329);
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
            this.lbl_title.Location = new System.Drawing.Point(259, 26);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(180, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "新增付款明细";
            // 
            // grb_productOut
            // 
            this.grb_productOut.Controls.Add(this.txt_remark);
            this.grb_productOut.Controls.Add(this.txt_otherType);
            this.grb_productOut.Controls.Add(this.cmb_paidType);
            this.grb_productOut.Controls.Add(this.dtp_paidDate);
            this.grb_productOut.Controls.Add(this.label5);
            this.grb_productOut.Controls.Add(this.label3);
            this.grb_productOut.Controls.Add(this.label2);
            this.grb_productOut.Controls.Add(this.label1);
            this.grb_productOut.Controls.Add(this.txt_paidMoney);
            this.grb_productOut.Controls.Add(this.lbl_orderCode);
            this.grb_productOut.Location = new System.Drawing.Point(33, 66);
            this.grb_productOut.Name = "grb_productOut";
            this.grb_productOut.Size = new System.Drawing.Size(641, 234);
            this.grb_productOut.TabIndex = 103;
            this.grb_productOut.TabStop = false;
            // 
            // txt_remark
            // 
            this.txt_remark.BackColor = System.Drawing.Color.White;
            this.txt_remark.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_remark.Location = new System.Drawing.Point(77, 160);
            this.txt_remark.MaxLength = 100;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(525, 21);
            this.txt_remark.TabIndex = 5;
            // 
            // txt_otherType
            // 
            this.txt_otherType.BackColor = System.Drawing.Color.White;
            this.txt_otherType.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_otherType.Location = new System.Drawing.Point(380, 87);
            this.txt_otherType.MaxLength = 30;
            this.txt_otherType.Name = "txt_otherType";
            this.txt_otherType.Size = new System.Drawing.Size(222, 21);
            this.txt_otherType.TabIndex = 4;
            // 
            // cmb_paidType
            // 
            this.cmb_paidType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_paidType.FormattingEnabled = true;
            this.cmb_paidType.Location = new System.Drawing.Point(77, 88);
            this.cmb_paidType.Name = "cmb_paidType";
            this.cmb_paidType.Size = new System.Drawing.Size(222, 20);
            this.cmb_paidType.TabIndex = 3;
            // 
            // dtp_paidDate
            // 
            this.dtp_paidDate.Location = new System.Drawing.Point(380, 21);
            this.dtp_paidDate.Name = "dtp_paidDate";
            this.dtp_paidDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_paidDate.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 138;
            this.label5.Text = "备    注：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(319, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 124;
            this.label3.Text = "其他方式：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 122;
            this.label2.Text = "付款方式：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(319, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 121;
            this.label1.Text = "付款日期：";
            this.label1.Visible = false;
            // 
            // txt_paidMoney
            // 
            this.txt_paidMoney.BackColor = System.Drawing.Color.White;
            this.txt_paidMoney.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_paidMoney.Location = new System.Drawing.Point(77, 24);
            this.txt_paidMoney.MaxLength = 20;
            this.txt_paidMoney.Name = "txt_paidMoney";
            this.txt_paidMoney.Size = new System.Drawing.Size(222, 21);
            this.txt_paidMoney.TabIndex = 1;
            this.txt_paidMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_paidMoney_KeyPress);
            // 
            // lbl_orderCode
            // 
            this.lbl_orderCode.AutoSize = true;
            this.lbl_orderCode.ForeColor = System.Drawing.Color.Black;
            this.lbl_orderCode.Location = new System.Drawing.Point(16, 27);
            this.lbl_orderCode.Name = "lbl_orderCode";
            this.lbl_orderCode.Size = new System.Drawing.Size(53, 12);
            this.lbl_orderCode.TabIndex = 42;
            this.lbl_orderCode.Text = "付款金额";
            // 
            // FrmPaidDetailAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(711, 381);
            this.Controls.Add(this.grb_productOut);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPaidDetailAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "付款管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPaidDetailAdd_FormClosed);
            this.Load += new System.EventHandler(this.FrmPaidDetailAdd_Load);
            this.grb_productOut.ResumeLayout(false);
            this.grb_productOut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_productOut;
        private System.Windows.Forms.TextBox txt_paidMoney;
        private System.Windows.Forms.Label lbl_orderCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_paidDate;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.TextBox txt_otherType;
        private System.Windows.Forms.ComboBox cmb_paidType;
    }
}