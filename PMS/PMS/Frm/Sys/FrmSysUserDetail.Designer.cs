namespace PMS.Frm.Sys
{
    partial class FrmSysUserDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSysUserDetail));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pwd2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_sex = new System.Windows.Forms.ComboBox();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.lbl_title = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(55, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用 户 名：";
            // 
            // txt_name
            // 
            this.txt_name.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_name.Location = new System.Drawing.Point(126, 97);
            this.txt_name.MaxLength = 20;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(164, 21);
            this.txt_name.TabIndex = 1;
            // 
            // txt_pwd
            // 
            this.txt_pwd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_pwd.Location = new System.Drawing.Point(126, 145);
            this.txt_pwd.MaxLength = 20;
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(164, 21);
            this.txt_pwd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(55, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密    码：";
            // 
            // txt_pwd2
            // 
            this.txt_pwd2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_pwd2.Location = new System.Drawing.Point(397, 145);
            this.txt_pwd2.MaxLength = 20;
            this.txt_pwd2.Name = "txt_pwd2";
            this.txt_pwd2.PasswordChar = '*';
            this.txt_pwd2.Size = new System.Drawing.Size(164, 21);
            this.txt_pwd2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(326, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "性    别：";
            // 
            // cmb_sex
            // 
            this.cmb_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sex.FormattingEnabled = true;
            this.cmb_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmb_sex.Location = new System.Drawing.Point(398, 187);
            this.cmb_sex.Name = "cmb_sex";
            this.cmb_sex.Size = new System.Drawing.Size(163, 20);
            this.cmb_sex.TabIndex = 5;
            // 
            // txt_position
            // 
            this.txt_position.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_position.Location = new System.Drawing.Point(126, 240);
            this.txt_position.MaxLength = 20;
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(164, 21);
            this.txt_position.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "职    位：";
            // 
            // cmb_role
            // 
            this.cmb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmb_role.Location = new System.Drawing.Point(126, 192);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(163, 20);
            this.cmb_role.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(55, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "角    色：";
            // 
            // txt_email
            // 
            this.txt_email.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.txt_email.Location = new System.Drawing.Point(126, 289);
            this.txt_email.MaxLength = 40;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(164, 21);
            this.txt_email.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "邮    箱：";
            // 
            // txt_mobile
            // 
            this.txt_mobile.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.txt_mobile.Location = new System.Drawing.Point(398, 240);
            this.txt_mobile.MaxLength = 20;
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(164, 21);
            this.txt_mobile.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "手    机：";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(214, 348);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 10;
            this.btn_submit.Text = "确认";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(316, 348);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "生    日：";
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.Location = new System.Drawing.Point(399, 289);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(163, 21);
            this.dtp_birthday.TabIndex = 9;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_title.Location = new System.Drawing.Point(190, 39);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(180, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "用户信息设置";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmSysUserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(621, 411);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.dtp_birthday);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_mobile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_role);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_position);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_sex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_pwd2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSysUserDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSysUserDetail_FormClosed);
            this.Load += new System.EventHandler(this.FrmSysUserDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pwd2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_sex;
        private System.Windows.Forms.TextBox txt_position;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_role;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}