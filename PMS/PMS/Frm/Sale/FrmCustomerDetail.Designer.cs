namespace PMS.Frm.Sale
{
    partial class FrmCustomerDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerDetail));
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_customer = new System.Windows.Forms.GroupBox();
            this.btn_paid = new System.Windows.Forms.Button();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_saler = new System.Windows.Forms.Label();
            this.cmb_saler = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.grb_manager = new System.Windows.Forms.GroupBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_manager = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_zip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_telephone2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grb_address = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_province = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_district = new System.Windows.Forms.ComboBox();
            this.txt_fax = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_telephone1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_customer.SuspendLayout();
            this.grb_manager.SuspendLayout();
            this.grb_address.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(254, 573);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 101;
            this.btn_submit.Text = "确认";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(433, 573);
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
            this.lbl_title.Location = new System.Drawing.Point(275, 41);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(124, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "客户信息";
            // 
            // grb_customer
            // 
            this.grb_customer.Controls.Add(this.btn_paid);
            this.grb_customer.Controls.Add(this.txt_remark);
            this.grb_customer.Controls.Add(this.label17);
            this.grb_customer.Controls.Add(this.lbl_saler);
            this.grb_customer.Controls.Add(this.cmb_saler);
            this.grb_customer.Controls.Add(this.label10);
            this.grb_customer.Controls.Add(this.cmb_type);
            this.grb_customer.Controls.Add(this.grb_manager);
            this.grb_customer.Controls.Add(this.txt_zip);
            this.grb_customer.Controls.Add(this.label7);
            this.grb_customer.Controls.Add(this.txt_telephone2);
            this.grb_customer.Controls.Add(this.label2);
            this.grb_customer.Controls.Add(this.grb_address);
            this.grb_customer.Controls.Add(this.txt_fax);
            this.grb_customer.Controls.Add(this.label16);
            this.grb_customer.Controls.Add(this.txt_name);
            this.grb_customer.Controls.Add(this.label15);
            this.grb_customer.Controls.Add(this.txt_telephone1);
            this.grb_customer.Controls.Add(this.label5);
            this.grb_customer.Controls.Add(this.txt_code);
            this.grb_customer.Controls.Add(this.label1);
            this.grb_customer.Location = new System.Drawing.Point(31, 84);
            this.grb_customer.Name = "grb_customer";
            this.grb_customer.Size = new System.Drawing.Size(641, 470);
            this.grb_customer.TabIndex = 103;
            this.grb_customer.TabStop = false;
            // 
            // btn_paid
            // 
            this.btn_paid.Location = new System.Drawing.Point(8, 397);
            this.btn_paid.Name = "btn_paid";
            this.btn_paid.Size = new System.Drawing.Size(96, 23);
            this.btn_paid.TabIndex = 16;
            this.btn_paid.Text = "设定支付信息";
            this.btn_paid.UseVisualStyleBackColor = true;
            this.btn_paid.Click += new System.EventHandler(this.btn_paid_Click);
            // 
            // txt_remark
            // 
            this.txt_remark.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_remark.Location = new System.Drawing.Point(69, 434);
            this.txt_remark.MaxLength = 100;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(556, 21);
            this.txt_remark.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 437);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 85;
            this.label17.Text = "备    注：";
            // 
            // lbl_saler
            // 
            this.lbl_saler.AutoSize = true;
            this.lbl_saler.ForeColor = System.Drawing.Color.Red;
            this.lbl_saler.Location = new System.Drawing.Point(332, 26);
            this.lbl_saler.Name = "lbl_saler";
            this.lbl_saler.Size = new System.Drawing.Size(65, 12);
            this.lbl_saler.TabIndex = 82;
            this.lbl_saler.Text = "销    售：";
            this.lbl_saler.Visible = false;
            // 
            // cmb_saler
            // 
            this.cmb_saler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_saler.FormattingEnabled = true;
            this.cmb_saler.Location = new System.Drawing.Point(403, 20);
            this.cmb_saler.Name = "cmb_saler";
            this.cmb_saler.Size = new System.Drawing.Size(222, 20);
            this.cmb_saler.TabIndex = 2;
            this.cmb_saler.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(6, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 79;
            this.label10.Text = "客户类型：";
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "",
            "销售客户",
            "供应商"});
            this.cmb_type.Location = new System.Drawing.Point(77, 20);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(221, 20);
            this.cmb_type.TabIndex = 1;
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.cmb_type_SelectedIndexChanged);
            // 
            // grb_manager
            // 
            this.grb_manager.Controls.Add(this.txt_mobile);
            this.grb_manager.Controls.Add(this.label9);
            this.grb_manager.Controls.Add(this.txt_position);
            this.grb_manager.Controls.Add(this.label8);
            this.grb_manager.Controls.Add(this.txt_manager);
            this.grb_manager.Controls.Add(this.label11);
            this.grb_manager.Location = new System.Drawing.Point(8, 318);
            this.grb_manager.Name = "grb_manager";
            this.grb_manager.Size = new System.Drawing.Size(623, 66);
            this.grb_manager.TabIndex = 74;
            this.grb_manager.TabStop = false;
            this.grb_manager.Text = "联系人：";
            // 
            // txt_mobile
            // 
            this.txt_mobile.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_mobile.Location = new System.Drawing.Point(478, 26);
            this.txt_mobile.MaxLength = 20;
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(139, 21);
            this.txt_mobile.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(431, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 67;
            this.label9.Text = "电话：";
            // 
            // txt_position
            // 
            this.txt_position.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_position.Location = new System.Drawing.Point(276, 26);
            this.txt_position.MaxLength = 10;
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(127, 21);
            this.txt_position.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 65;
            this.label8.Text = "职务：";
            // 
            // txt_manager
            // 
            this.txt_manager.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_manager.Location = new System.Drawing.Point(68, 26);
            this.txt_manager.MaxLength = 10;
            this.txt_manager.Name = "txt_manager";
            this.txt_manager.Size = new System.Drawing.Size(138, 21);
            this.txt_manager.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 63;
            this.label11.Text = "姓名：";
            // 
            // txt_zip
            // 
            this.txt_zip.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_zip.Location = new System.Drawing.Point(402, 280);
            this.txt_zip.MaxLength = 20;
            this.txt_zip.Name = "txt_zip";
            this.txt_zip.Size = new System.Drawing.Size(223, 21);
            this.txt_zip.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 77;
            this.label7.Text = "邮    编：";
            // 
            // txt_telephone2
            // 
            this.txt_telephone2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_telephone2.Location = new System.Drawing.Point(403, 240);
            this.txt_telephone2.MaxLength = 20;
            this.txt_telephone2.Name = "txt_telephone2";
            this.txt_telephone2.Size = new System.Drawing.Size(222, 21);
            this.txt_telephone2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 75;
            this.label2.Text = "备用电话：";
            // 
            // grb_address
            // 
            this.grb_address.Controls.Add(this.label13);
            this.grb_address.Controls.Add(this.label6);
            this.grb_address.Controls.Add(this.cmb_province);
            this.grb_address.Controls.Add(this.label4);
            this.grb_address.Controls.Add(this.cmb_city);
            this.grb_address.Controls.Add(this.txt_address);
            this.grb_address.Controls.Add(this.label3);
            this.grb_address.Controls.Add(this.cmb_district);
            this.grb_address.ForeColor = System.Drawing.Color.Red;
            this.grb_address.Location = new System.Drawing.Point(8, 131);
            this.grb_address.Name = "grb_address";
            this.grb_address.Size = new System.Drawing.Size(623, 97);
            this.grb_address.TabIndex = 73;
            this.grb_address.TabStop = false;
            this.grb_address.Text = "地  址：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(392, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 64;
            this.label13.Text = "区：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 56;
            this.label6.Text = "省：";
            // 
            // cmb_province
            // 
            this.cmb_province.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_province.FormattingEnabled = true;
            this.cmb_province.Location = new System.Drawing.Point(69, 23);
            this.cmb_province.Name = "cmb_province";
            this.cmb_province.Size = new System.Drawing.Size(115, 20);
            this.cmb_province.TabIndex = 5;
            this.cmb_province.SelectedIndexChanged += new System.EventHandler(this.cmb_province_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 49;
            this.label4.Text = "市：";
            // 
            // cmb_city
            // 
            this.cmb_city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Location = new System.Drawing.Point(244, 23);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(115, 20);
            this.cmb_city.TabIndex = 6;
            this.cmb_city.SelectedIndexChanged += new System.EventHandler(this.cmb_city_SelectedIndexChanged);
            // 
            // txt_address
            // 
            this.txt_address.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_address.Location = new System.Drawing.Point(66, 63);
            this.txt_address.MaxLength = 100;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(551, 21);
            this.txt_address.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 63;
            this.label3.Text = "地址：";
            // 
            // cmb_district
            // 
            this.cmb_district.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_district.FormattingEnabled = true;
            this.cmb_district.Location = new System.Drawing.Point(443, 23);
            this.cmb_district.Name = "cmb_district";
            this.cmb_district.Size = new System.Drawing.Size(115, 20);
            this.cmb_district.TabIndex = 7;
            // 
            // txt_fax
            // 
            this.txt_fax.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_fax.Location = new System.Drawing.Point(75, 280);
            this.txt_fax.MaxLength = 20;
            this.txt_fax.Name = "txt_fax";
            this.txt_fax.Size = new System.Drawing.Size(223, 21);
            this.txt_fax.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 283);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 66;
            this.label16.Text = "传    真：";
            // 
            // txt_name
            // 
            this.txt_name.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_name.Location = new System.Drawing.Point(74, 91);
            this.txt_name.MaxLength = 100;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(551, 21);
            this.txt_name.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(5, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 62;
            this.label15.Text = "客户名称：";
            // 
            // txt_telephone1
            // 
            this.txt_telephone1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_telephone1.Location = new System.Drawing.Point(76, 240);
            this.txt_telephone1.MaxLength = 20;
            this.txt_telephone1.Name = "txt_telephone1";
            this.txt_telephone1.Size = new System.Drawing.Size(222, 21);
            this.txt_telephone1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 52;
            this.label5.Text = "联系电话：";
            // 
            // txt_code
            // 
            this.txt_code.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_code.Location = new System.Drawing.Point(76, 56);
            this.txt_code.MaxLength = 20;
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(222, 21);
            this.txt_code.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 42;
            this.label1.Text = "客户代码：";
            // 
            // FrmCustomerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(701, 617);
            this.Controls.Add(this.grb_customer);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCustomerDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCustomerDetail_FormClosed);
            this.Load += new System.EventHandler(this.FrmCustomerDetail_Load);
            this.grb_customer.ResumeLayout(false);
            this.grb_customer.PerformLayout();
            this.grb_manager.ResumeLayout(false);
            this.grb_manager.PerformLayout();
            this.grb_address.ResumeLayout(false);
            this.grb_address.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_customer;
        private System.Windows.Forms.TextBox txt_fax;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmb_district;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb_province;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_telephone1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_address;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.GroupBox grb_manager;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_position;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_manager;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_zip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_telephone2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_saler;
        private System.Windows.Forms.ComboBox cmb_saler;
        private System.Windows.Forms.Button btn_paid;
    }
}