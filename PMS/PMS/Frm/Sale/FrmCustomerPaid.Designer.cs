namespace PMS.Frm.Sale
{
    partial class FrmCustomerPaid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerPaid));
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_customer = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grb_alipay = new System.Windows.Forms.GroupBox();
            this.txt_alipayMobile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_alipayName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_alipayAccount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_creditLimit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grb_bank = new System.Windows.Forms.GroupBox();
            this.txt_bankMobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_bankName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bankAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_subBank = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_bank = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.grb_customer.SuspendLayout();
            this.grb_alipay.SuspendLayout();
            this.grb_bank.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(226, 573);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 101;
            this.btn_submit.Text = "确认";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(410, 573);
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
            this.lbl_title.Location = new System.Drawing.Point(249, 35);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(236, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "客户支付信息设定";
            // 
            // grb_customer
            // 
            this.grb_customer.Controls.Add(this.label4);
            this.grb_customer.Controls.Add(this.grb_alipay);
            this.grb_customer.Controls.Add(this.txt_remark);
            this.grb_customer.Controls.Add(this.label17);
            this.grb_customer.Controls.Add(this.txt_creditLimit);
            this.grb_customer.Controls.Add(this.label12);
            this.grb_customer.Controls.Add(this.grb_bank);
            this.grb_customer.Controls.Add(this.txt_name);
            this.grb_customer.Controls.Add(this.label15);
            this.grb_customer.Location = new System.Drawing.Point(31, 84);
            this.grb_customer.Name = "grb_customer";
            this.grb_customer.Size = new System.Drawing.Size(641, 470);
            this.grb_customer.TabIndex = 103;
            this.grb_customer.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 86;
            this.label4.Text = "RMB";
            // 
            // grb_alipay
            // 
            this.grb_alipay.Controls.Add(this.txt_alipayMobile);
            this.grb_alipay.Controls.Add(this.label6);
            this.grb_alipay.Controls.Add(this.txt_alipayName);
            this.grb_alipay.Controls.Add(this.label7);
            this.grb_alipay.Controls.Add(this.txt_alipayAccount);
            this.grb_alipay.Controls.Add(this.label9);
            this.grb_alipay.Location = new System.Drawing.Point(10, 265);
            this.grb_alipay.Name = "grb_alipay";
            this.grb_alipay.Size = new System.Drawing.Size(623, 125);
            this.grb_alipay.TabIndex = 75;
            this.grb_alipay.TabStop = false;
            this.grb_alipay.Text = "支付宝：";
            // 
            // txt_alipayMobile
            // 
            this.txt_alipayMobile.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_alipayMobile.Location = new System.Drawing.Point(97, 93);
            this.txt_alipayMobile.MaxLength = 50;
            this.txt_alipayMobile.Name = "txt_alipayMobile";
            this.txt_alipayMobile.Size = new System.Drawing.Size(518, 21);
            this.txt_alipayMobile.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 67;
            this.label6.Text = "账户手机号：";
            // 
            // txt_alipayName
            // 
            this.txt_alipayName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_alipayName.Location = new System.Drawing.Point(97, 60);
            this.txt_alipayName.MaxLength = 50;
            this.txt_alipayName.Name = "txt_alipayName";
            this.txt_alipayName.Size = new System.Drawing.Size(518, 21);
            this.txt_alipayName.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 65;
            this.label7.Text = "支付宝姓名：";
            // 
            // txt_alipayAccount
            // 
            this.txt_alipayAccount.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_alipayAccount.Location = new System.Drawing.Point(97, 26);
            this.txt_alipayAccount.MaxLength = 50;
            this.txt_alipayAccount.Name = "txt_alipayAccount";
            this.txt_alipayAccount.Size = new System.Drawing.Size(518, 21);
            this.txt_alipayAccount.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 63;
            this.label9.Text = "支付宝账号：";
            // 
            // txt_remark
            // 
            this.txt_remark.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_remark.Location = new System.Drawing.Point(107, 434);
            this.txt_remark.MaxLength = 100;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(518, 21);
            this.txt_remark.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 437);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 85;
            this.label17.Text = "备    注：";
            // 
            // txt_creditLimit
            // 
            this.txt_creditLimit.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_creditLimit.Location = new System.Drawing.Point(107, 398);
            this.txt_creditLimit.MaxLength = 10;
            this.txt_creditLimit.Name = "txt_creditLimit";
            this.txt_creditLimit.Size = new System.Drawing.Size(135, 21);
            this.txt_creditLimit.TabIndex = 10;
            this.txt_creditLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_creditLimit_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(24, 401);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 81;
            this.label12.Text = "信用额度：";
            // 
            // grb_bank
            // 
            this.grb_bank.Controls.Add(this.txt_bankMobile);
            this.grb_bank.Controls.Add(this.label3);
            this.grb_bank.Controls.Add(this.txt_bankName);
            this.grb_bank.Controls.Add(this.label2);
            this.grb_bank.Controls.Add(this.txt_bankAccount);
            this.grb_bank.Controls.Add(this.label1);
            this.grb_bank.Controls.Add(this.txt_subBank);
            this.grb_bank.Controls.Add(this.label8);
            this.grb_bank.Controls.Add(this.txt_bank);
            this.grb_bank.Controls.Add(this.label11);
            this.grb_bank.Location = new System.Drawing.Point(10, 49);
            this.grb_bank.Name = "grb_bank";
            this.grb_bank.Size = new System.Drawing.Size(623, 207);
            this.grb_bank.TabIndex = 74;
            this.grb_bank.TabStop = false;
            this.grb_bank.Text = "银行：";
            // 
            // txt_bankMobile
            // 
            this.txt_bankMobile.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_bankMobile.Location = new System.Drawing.Point(97, 163);
            this.txt_bankMobile.MaxLength = 50;
            this.txt_bankMobile.Name = "txt_bankMobile";
            this.txt_bankMobile.Size = new System.Drawing.Size(518, 21);
            this.txt_bankMobile.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 71;
            this.label3.Text = "账号电话：";
            // 
            // txt_bankName
            // 
            this.txt_bankName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_bankName.Location = new System.Drawing.Point(97, 127);
            this.txt_bankName.MaxLength = 50;
            this.txt_bankName.Name = "txt_bankName";
            this.txt_bankName.Size = new System.Drawing.Size(518, 21);
            this.txt_bankName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 69;
            this.label2.Text = "账号姓名：";
            // 
            // txt_bankAccount
            // 
            this.txt_bankAccount.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_bankAccount.Location = new System.Drawing.Point(97, 93);
            this.txt_bankAccount.MaxLength = 50;
            this.txt_bankAccount.Name = "txt_bankAccount";
            this.txt_bankAccount.Size = new System.Drawing.Size(518, 21);
            this.txt_bankAccount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 67;
            this.label1.Text = "银行账号：";
            // 
            // txt_subBank
            // 
            this.txt_subBank.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_subBank.Location = new System.Drawing.Point(97, 60);
            this.txt_subBank.MaxLength = 50;
            this.txt_subBank.Name = "txt_subBank";
            this.txt_subBank.Size = new System.Drawing.Size(518, 21);
            this.txt_subBank.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 65;
            this.label8.Text = "开户支行：";
            // 
            // txt_bank
            // 
            this.txt_bank.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_bank.Location = new System.Drawing.Point(97, 26);
            this.txt_bank.MaxLength = 50;
            this.txt_bank.Name = "txt_bank";
            this.txt_bank.Size = new System.Drawing.Size(518, 21);
            this.txt_bank.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 63;
            this.label11.Text = "开户银行：";
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_name.Location = new System.Drawing.Point(107, 20);
            this.txt_name.MaxLength = 50;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(518, 21);
            this.txt_name.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(16, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 62;
            this.label15.Text = "客户名称：";
            // 
            // FrmCustomerPaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(701, 616);
            this.Controls.Add(this.grb_customer);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCustomerPaid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCustomerDetail_FormClosed);
            this.Load += new System.EventHandler(this.FrmCustomerPaid_Load);
            this.grb_customer.ResumeLayout(false);
            this.grb_customer.PerformLayout();
            this.grb_alipay.ResumeLayout(false);
            this.grb_alipay.PerformLayout();
            this.grb_bank.ResumeLayout(false);
            this.grb_bank.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_customer;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox grb_bank;
        private System.Windows.Forms.TextBox txt_subBank;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_bank;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_creditLimit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grb_alipay;
        private System.Windows.Forms.TextBox txt_alipayMobile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_alipayName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_alipayAccount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_bankMobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_bankName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_bankAccount;
        private System.Windows.Forms.Label label1;
    }
}