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
            this.grb_productIn = new System.Windows.Forms.GroupBox();
            this.txt_inputNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_specs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_stockNum_new = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_expiresDate_new = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_produceDate_new = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_inputDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_factory = new System.Windows.Forms.TextBox();
            this.lbl_orderCode = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_stockNum_old = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_expiresDate_old = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_produceDate_old = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.grb_productIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_productIn
            // 
            this.grb_productIn.Controls.Add(this.txt_stockNum_old);
            this.grb_productIn.Controls.Add(this.label8);
            this.grb_productIn.Controls.Add(this.dtp_expiresDate_old);
            this.grb_productIn.Controls.Add(this.label9);
            this.grb_productIn.Controls.Add(this.dtp_produceDate_old);
            this.grb_productIn.Controls.Add(this.label10);
            this.grb_productIn.Controls.Add(this.txt_name);
            this.grb_productIn.Controls.Add(this.label7);
            this.grb_productIn.Controls.Add(this.txt_inputNum);
            this.grb_productIn.Controls.Add(this.label1);
            this.grb_productIn.Controls.Add(this.txt_specs);
            this.grb_productIn.Controls.Add(this.label6);
            this.grb_productIn.Controls.Add(this.txt_remark);
            this.grb_productIn.Controls.Add(this.label5);
            this.grb_productIn.Controls.Add(this.txt_stockNum_new);
            this.grb_productIn.Controls.Add(this.label4);
            this.grb_productIn.Controls.Add(this.dtp_expiresDate_new);
            this.grb_productIn.Controls.Add(this.label3);
            this.grb_productIn.Controls.Add(this.dtp_produceDate_new);
            this.grb_productIn.Controls.Add(this.label2);
            this.grb_productIn.Controls.Add(this.dtp_inputDate);
            this.grb_productIn.Controls.Add(this.label11);
            this.grb_productIn.Controls.Add(this.txt_factory);
            this.grb_productIn.Controls.Add(this.lbl_orderCode);
            this.grb_productIn.Location = new System.Drawing.Point(12, 85);
            this.grb_productIn.Name = "grb_productIn";
            this.grb_productIn.Size = new System.Drawing.Size(657, 358);
            this.grb_productIn.TabIndex = 103;
            this.grb_productIn.TabStop = false;
            // 
            // txt_inputNum
            // 
            this.txt_inputNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_inputNum.Enabled = false;
            this.txt_inputNum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_inputNum.Location = new System.Drawing.Point(97, 100);
            this.txt_inputNum.MaxLength = 20;
            this.txt_inputNum.Name = "txt_inputNum";
            this.txt_inputNum.Size = new System.Drawing.Size(222, 21);
            this.txt_inputNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 143;
            this.label1.Text = "入库数量：";
            // 
            // txt_specs
            // 
            this.txt_specs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_specs.Enabled = false;
            this.txt_specs.Location = new System.Drawing.Point(412, 57);
            this.txt_specs.Name = "txt_specs";
            this.txt_specs.Size = new System.Drawing.Size(222, 21);
            this.txt_specs.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(347, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 141;
            this.label6.Text = "规    格：";
            // 
            // txt_remark
            // 
            this.txt_remark.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_remark.Location = new System.Drawing.Point(97, 270);
            this.txt_remark.MaxLength = 100;
            this.txt_remark.Multiline = true;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(537, 70);
            this.txt_remark.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(34, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 139;
            this.label5.Text = "备    注：";
            // 
            // txt_stockNum_new
            // 
            this.txt_stockNum_new.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_stockNum_new.Location = new System.Drawing.Point(410, 230);
            this.txt_stockNum_new.MaxLength = 12;
            this.txt_stockNum_new.Name = "txt_stockNum_new";
            this.txt_stockNum_new.Size = new System.Drawing.Size(222, 21);
            this.txt_stockNum_new.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(334, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 126;
            this.label4.Text = "新库存数量：";
            // 
            // dtp_expiresDate_new
            // 
            this.dtp_expiresDate_new.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_expiresDate_new.Location = new System.Drawing.Point(413, 188);
            this.dtp_expiresDate_new.Name = "dtp_expiresDate_new";
            this.dtp_expiresDate_new.Size = new System.Drawing.Size(222, 21);
            this.dtp_expiresDate_new.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(347, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 125;
            this.label3.Text = "新过期日：";
            // 
            // dtp_produceDate_new
            // 
            this.dtp_produceDate_new.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_produceDate_new.Location = new System.Drawing.Point(413, 146);
            this.dtp_produceDate_new.Name = "dtp_produceDate_new";
            this.dtp_produceDate_new.Size = new System.Drawing.Size(219, 21);
            this.dtp_produceDate_new.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(335, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 123;
            this.label2.Text = "新生产日期：";
            // 
            // dtp_inputDate
            // 
            this.dtp_inputDate.Enabled = false;
            this.dtp_inputDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inputDate.Location = new System.Drawing.Point(413, 100);
            this.dtp_inputDate.Name = "dtp_inputDate";
            this.dtp_inputDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_inputDate.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(347, 103);
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
            this.txt_factory.Location = new System.Drawing.Point(97, 15);
            this.txt_factory.MaxLength = 20;
            this.txt_factory.Name = "txt_factory";
            this.txt_factory.Size = new System.Drawing.Size(535, 21);
            this.txt_factory.TabIndex = 1;
            // 
            // lbl_orderCode
            // 
            this.lbl_orderCode.AutoSize = true;
            this.lbl_orderCode.ForeColor = System.Drawing.Color.Black;
            this.lbl_orderCode.Location = new System.Drawing.Point(34, 18);
            this.lbl_orderCode.Name = "lbl_orderCode";
            this.lbl_orderCode.Size = new System.Drawing.Size(65, 12);
            this.lbl_orderCode.TabIndex = 42;
            this.lbl_orderCode.Text = "工    厂：";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_title.Location = new System.Drawing.Point(299, 35);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(124, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "库存设置";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(381, 466);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 102;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(235, 466);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 101;
            this.btn_submit.Text = "确认";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(97, 57);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(222, 21);
            this.txt_name.TabIndex = 144;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(35, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 145;
            this.label7.Text = "名    称：";
            // 
            // txt_stockNum_old
            // 
            this.txt_stockNum_old.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_stockNum_old.Enabled = false;
            this.txt_stockNum_old.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_stockNum_old.Location = new System.Drawing.Point(98, 227);
            this.txt_stockNum_old.MaxLength = 12;
            this.txt_stockNum_old.Name = "txt_stockNum_old";
            this.txt_stockNum_old.Size = new System.Drawing.Size(222, 21);
            this.txt_stockNum_old.TabIndex = 148;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(23, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 151;
            this.label8.Text = "原库存数量：";
            // 
            // dtp_expiresDate_old
            // 
            this.dtp_expiresDate_old.Enabled = false;
            this.dtp_expiresDate_old.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_expiresDate_old.Location = new System.Drawing.Point(101, 185);
            this.dtp_expiresDate_old.Name = "dtp_expiresDate_old";
            this.dtp_expiresDate_old.Size = new System.Drawing.Size(222, 21);
            this.dtp_expiresDate_old.TabIndex = 147;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(35, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 150;
            this.label9.Text = "原过期日：";
            // 
            // dtp_produceDate_old
            // 
            this.dtp_produceDate_old.Enabled = false;
            this.dtp_produceDate_old.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_produceDate_old.Location = new System.Drawing.Point(101, 143);
            this.dtp_produceDate_old.Name = "dtp_produceDate_old";
            this.dtp_produceDate_old.Size = new System.Drawing.Size(219, 21);
            this.dtp_produceDate_old.TabIndex = 146;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(20, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 149;
            this.label10.Text = "原生产日期：";
            // 
            // FrmInventoryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(699, 514);
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
        private System.Windows.Forms.DateTimePicker dtp_produceDate_new;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_expiresDate_new;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_specs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_stockNum_new;
        private System.Windows.Forms.TextBox txt_inputNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_stockNum_old;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_expiresDate_old;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_produceDate_old;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label7;
    }
}