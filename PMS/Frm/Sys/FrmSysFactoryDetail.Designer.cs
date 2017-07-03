namespace PMS.Frm.Sys
{
    partial class FrmSysFactoryDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSysFactoryDetail));
            this.lbl_role = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_factory = new System.Windows.Forms.GroupBox();
            this.txt_zip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fax = new System.Windows.Forms.TextBox();
            this.lbl_fax = new System.Windows.Forms.Label();
            this.txt_telphone = new System.Windows.Forms.TextBox();
            this.lbl_telphone = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.grb_address = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_province = new System.Windows.Forms.ComboBox();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_district = new System.Windows.Forms.ComboBox();
            this.grb_factory.SuspendLayout();
            this.grb_address.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Location = new System.Drawing.Point(28, 54);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(0, 12);
            this.lbl_role.TabIndex = 11;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(203, 443);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 6;
            this.btn_submit.Text = "确定";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(385, 439);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 27);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_title.Location = new System.Drawing.Point(273, 39);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(124, 27);
            this.lbl_title.TabIndex = 66;
            this.lbl_title.Text = "工厂信息";
            // 
            // grb_factory
            // 
            this.grb_factory.Controls.Add(this.grb_address);
            this.grb_factory.Controls.Add(this.txt_zip);
            this.grb_factory.Controls.Add(this.label1);
            this.grb_factory.Controls.Add(this.txt_fax);
            this.grb_factory.Controls.Add(this.lbl_fax);
            this.grb_factory.Controls.Add(this.txt_telphone);
            this.grb_factory.Controls.Add(this.lbl_telphone);
            this.grb_factory.Controls.Add(this.txt_name);
            this.grb_factory.Controls.Add(this.lbl_name);
            this.grb_factory.Location = new System.Drawing.Point(57, 90);
            this.grb_factory.Name = "grb_factory";
            this.grb_factory.Size = new System.Drawing.Size(558, 324);
            this.grb_factory.TabIndex = 67;
            this.grb_factory.TabStop = false;
            // 
            // txt_zip
            // 
            this.txt_zip.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_zip.Location = new System.Drawing.Point(121, 265);
            this.txt_zip.MaxLength = 50;
            this.txt_zip.Name = "txt_zip";
            this.txt_zip.Size = new System.Drawing.Size(400, 21);
            this.txt_zip.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 68;
            this.label1.Text = "邮    编：";
            // 
            // txt_fax
            // 
            this.txt_fax.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_fax.Location = new System.Drawing.Point(121, 221);
            this.txt_fax.MaxLength = 50;
            this.txt_fax.Name = "txt_fax";
            this.txt_fax.Size = new System.Drawing.Size(400, 21);
            this.txt_fax.TabIndex = 4;
            // 
            // lbl_fax
            // 
            this.lbl_fax.AutoSize = true;
            this.lbl_fax.Location = new System.Drawing.Point(30, 224);
            this.lbl_fax.Name = "lbl_fax";
            this.lbl_fax.Size = new System.Drawing.Size(65, 12);
            this.lbl_fax.TabIndex = 66;
            this.lbl_fax.Text = "传    真：";
            // 
            // txt_telphone
            // 
            this.txt_telphone.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_telphone.Location = new System.Drawing.Point(121, 176);
            this.txt_telphone.MaxLength = 50;
            this.txt_telphone.Name = "txt_telphone";
            this.txt_telphone.Size = new System.Drawing.Size(400, 21);
            this.txt_telphone.TabIndex = 3;
            // 
            // lbl_telphone
            // 
            this.lbl_telphone.AutoSize = true;
            this.lbl_telphone.Location = new System.Drawing.Point(30, 179);
            this.lbl_telphone.Name = "lbl_telphone";
            this.lbl_telphone.Size = new System.Drawing.Size(65, 12);
            this.lbl_telphone.TabIndex = 65;
            this.lbl_telphone.Text = "联系电话：";
            // 
            // txt_name
            // 
            this.txt_name.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_name.Location = new System.Drawing.Point(121, 27);
            this.txt_name.MaxLength = 100;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(400, 21);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(30, 30);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(65, 12);
            this.lbl_name.TabIndex = 63;
            this.lbl_name.Text = "工厂名称：";
            // 
            // grb_address
            // 
            this.grb_address.Controls.Add(this.label6);
            this.grb_address.Controls.Add(this.cmb_province);
            this.grb_address.Controls.Add(this.cmb_city);
            this.grb_address.Controls.Add(this.txt_address);
            this.grb_address.Controls.Add(this.label3);
            this.grb_address.Controls.Add(this.cmb_district);
            this.grb_address.ForeColor = System.Drawing.Color.Black;
            this.grb_address.Location = new System.Drawing.Point(22, 66);
            this.grb_address.Name = "grb_address";
            this.grb_address.Size = new System.Drawing.Size(510, 97);
            this.grb_address.TabIndex = 74;
            this.grb_address.TabStop = false;
            this.grb_address.Text = "工厂地址：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 56;
            this.label6.Text = "省 市 区：";
            // 
            // cmb_province
            // 
            this.cmb_province.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_province.FormattingEnabled = true;
            this.cmb_province.Location = new System.Drawing.Point(99, 25);
            this.cmb_province.Name = "cmb_province";
            this.cmb_province.Size = new System.Drawing.Size(115, 20);
            this.cmb_province.TabIndex = 5;
            this.cmb_province.SelectedIndexChanged += new System.EventHandler(this.cmb_province_SelectedIndexChanged);
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
            this.txt_address.Location = new System.Drawing.Point(99, 63);
            this.txt_address.MaxLength = 100;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(400, 21);
            this.txt_address.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 63;
            this.label3.Text = "详细地址：";
            // 
            // cmb_district
            // 
            this.cmb_district.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_district.FormattingEnabled = true;
            this.cmb_district.Location = new System.Drawing.Point(384, 23);
            this.cmb_district.Name = "cmb_district";
            this.cmb_district.Size = new System.Drawing.Size(115, 20);
            this.cmb_district.TabIndex = 7;
            // 
            // FrmSysFactoryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 504);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.grb_factory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSysFactoryDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工厂管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSysFactoryDetail_FormClosed);
            this.Load += new System.EventHandler(this.FrmSysFactoryDetail_Load);
            this.grb_factory.ResumeLayout(false);
            this.grb_factory.PerformLayout();
            this.grb_address.ResumeLayout(false);
            this.grb_address.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_factory;
        private System.Windows.Forms.TextBox txt_fax;
        private System.Windows.Forms.Label lbl_fax;
        private System.Windows.Forms.TextBox txt_telphone;
        private System.Windows.Forms.Label lbl_telphone;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_zip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_province;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_district;

    }
}