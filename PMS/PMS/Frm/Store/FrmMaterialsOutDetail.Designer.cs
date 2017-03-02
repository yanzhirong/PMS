namespace PMS.Frm.Store
{
    partial class FrmMaterialsOutDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaterialsOutDetail));
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_materialsIn = new System.Windows.Forms.GroupBox();
            this.txt_applyNum = new System.Windows.Forms.TextBox();
            this.cmb_applyUnit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_outputNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_applyDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_materials = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_factory = new System.Windows.Forms.ComboBox();
            this.dtp_outputDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_outputStatus = new System.Windows.Forms.ComboBox();
            this.cmb_outputType = new System.Windows.Forms.ComboBox();
            this.lbl_outputStatus = new System.Windows.Forms.Label();
            this.lbl_outputType = new System.Windows.Forms.Label();
            this.lbl_applyMember = new System.Windows.Forms.Label();
            this.cmb_applyBy = new System.Windows.Forms.ComboBox();
            this.lbl_saler = new System.Windows.Forms.Label();
            this.txt_produceCode = new System.Windows.Forms.TextBox();
            this.lbl_orderCode = new System.Windows.Forms.Label();
            this.btn_output = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.grb_materialsIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(387, 420);
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
            this.lbl_title.Location = new System.Drawing.Point(272, 41);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(152, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "物料出库单";
            // 
            // grb_materialsIn
            // 
            this.grb_materialsIn.Controls.Add(this.txt_applyNum);
            this.grb_materialsIn.Controls.Add(this.cmb_applyUnit);
            this.grb_materialsIn.Controls.Add(this.label6);
            this.grb_materialsIn.Controls.Add(this.txt_remark);
            this.grb_materialsIn.Controls.Add(this.label5);
            this.grb_materialsIn.Controls.Add(this.txt_outputNum);
            this.grb_materialsIn.Controls.Add(this.label4);
            this.grb_materialsIn.Controls.Add(this.dtp_applyDate);
            this.grb_materialsIn.Controls.Add(this.label3);
            this.grb_materialsIn.Controls.Add(this.cmb_materials);
            this.grb_materialsIn.Controls.Add(this.label1);
            this.grb_materialsIn.Controls.Add(this.cmb_factory);
            this.grb_materialsIn.Controls.Add(this.dtp_outputDate);
            this.grb_materialsIn.Controls.Add(this.label11);
            this.grb_materialsIn.Controls.Add(this.cmb_outputStatus);
            this.grb_materialsIn.Controls.Add(this.cmb_outputType);
            this.grb_materialsIn.Controls.Add(this.lbl_outputStatus);
            this.grb_materialsIn.Controls.Add(this.lbl_outputType);
            this.grb_materialsIn.Controls.Add(this.lbl_applyMember);
            this.grb_materialsIn.Controls.Add(this.cmb_applyBy);
            this.grb_materialsIn.Controls.Add(this.lbl_saler);
            this.grb_materialsIn.Controls.Add(this.txt_produceCode);
            this.grb_materialsIn.Controls.Add(this.lbl_orderCode);
            this.grb_materialsIn.Location = new System.Drawing.Point(31, 85);
            this.grb_materialsIn.Name = "grb_materialsIn";
            this.grb_materialsIn.Size = new System.Drawing.Size(638, 306);
            this.grb_materialsIn.TabIndex = 103;
            this.grb_materialsIn.TabStop = false;
            // 
            // txt_applyNum
            // 
            this.txt_applyNum.BackColor = System.Drawing.Color.White;
            this.txt_applyNum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_applyNum.Location = new System.Drawing.Point(81, 114);
            this.txt_applyNum.MaxLength = 12;
            this.txt_applyNum.Name = "txt_applyNum";
            this.txt_applyNum.Size = new System.Drawing.Size(160, 21);
            this.txt_applyNum.TabIndex = 5;
            // 
            // cmb_applyUnit
            // 
            this.cmb_applyUnit.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_applyUnit.FormattingEnabled = true;
            this.cmb_applyUnit.Location = new System.Drawing.Point(247, 114);
            this.cmb_applyUnit.Name = "cmb_applyUnit";
            this.cmb_applyUnit.Size = new System.Drawing.Size(54, 20);
            this.cmb_applyUnit.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(16, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 141;
            this.label6.Text = "申请数量：";
            // 
            // txt_remark
            // 
            this.txt_remark.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_remark.Location = new System.Drawing.Point(79, 247);
            this.txt_remark.MaxLength = 100;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(537, 21);
            this.txt_remark.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 139;
            this.label5.Text = "备    注：";
            // 
            // txt_outputNum
            // 
            this.txt_outputNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_outputNum.Enabled = false;
            this.txt_outputNum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_outputNum.Location = new System.Drawing.Point(79, 202);
            this.txt_outputNum.MaxLength = 10;
            this.txt_outputNum.Name = "txt_outputNum";
            this.txt_outputNum.Size = new System.Drawing.Size(222, 21);
            this.txt_outputNum.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(16, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 126;
            this.label4.Text = "出库数量：";
            // 
            // dtp_applyDate
            // 
            this.dtp_applyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_applyDate.Location = new System.Drawing.Point(394, 114);
            this.dtp_applyDate.Name = "dtp_applyDate";
            this.dtp_applyDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_applyDate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(328, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 125;
            this.label3.Text = "申请日期：";
            // 
            // cmb_materials
            // 
            this.cmb_materials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_materials.FormattingEnabled = true;
            this.cmb_materials.Location = new System.Drawing.Point(79, 155);
            this.cmb_materials.Name = "cmb_materials";
            this.cmb_materials.Size = new System.Drawing.Size(222, 20);
            this.cmb_materials.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(328, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 121;
            this.label1.Text = "出库工厂：";
            // 
            // cmb_factory
            // 
            this.cmb_factory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_factory.FormattingEnabled = true;
            this.cmb_factory.Location = new System.Drawing.Point(394, 155);
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.Size = new System.Drawing.Size(222, 20);
            this.cmb_factory.TabIndex = 9;
            // 
            // dtp_outputDate
            // 
            this.dtp_outputDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_outputDate.Location = new System.Drawing.Point(394, 202);
            this.dtp_outputDate.Name = "dtp_outputDate";
            this.dtp_outputDate.Size = new System.Drawing.Size(222, 21);
            this.dtp_outputDate.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(328, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 119;
            this.label11.Text = "出库日期：";
            // 
            // cmb_outputStatus
            // 
            this.cmb_outputStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_outputStatus.FormattingEnabled = true;
            this.cmb_outputStatus.Items.AddRange(new object[] {
            "请求出库",
            "完成出库"});
            this.cmb_outputStatus.Location = new System.Drawing.Point(394, 25);
            this.cmb_outputStatus.Name = "cmb_outputStatus";
            this.cmb_outputStatus.Size = new System.Drawing.Size(222, 20);
            this.cmb_outputStatus.TabIndex = 2;
            // 
            // cmb_outputType
            // 
            this.cmb_outputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_outputType.FormattingEnabled = true;
            this.cmb_outputType.Items.AddRange(new object[] {
            "生产申请",
            "其他申请"});
            this.cmb_outputType.Location = new System.Drawing.Point(80, 25);
            this.cmb_outputType.Name = "cmb_outputType";
            this.cmb_outputType.Size = new System.Drawing.Size(221, 20);
            this.cmb_outputType.TabIndex = 1;
            // 
            // lbl_outputStatus
            // 
            this.lbl_outputStatus.AutoSize = true;
            this.lbl_outputStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_outputStatus.Location = new System.Drawing.Point(328, 29);
            this.lbl_outputStatus.Name = "lbl_outputStatus";
            this.lbl_outputStatus.Size = new System.Drawing.Size(65, 12);
            this.lbl_outputStatus.TabIndex = 115;
            this.lbl_outputStatus.Text = "出库状态：";
            // 
            // lbl_outputType
            // 
            this.lbl_outputType.AutoSize = true;
            this.lbl_outputType.ForeColor = System.Drawing.Color.Red;
            this.lbl_outputType.Location = new System.Drawing.Point(16, 28);
            this.lbl_outputType.Name = "lbl_outputType";
            this.lbl_outputType.Size = new System.Drawing.Size(65, 12);
            this.lbl_outputType.TabIndex = 113;
            this.lbl_outputType.Text = "出库类型：";
            // 
            // lbl_applyMember
            // 
            this.lbl_applyMember.AutoSize = true;
            this.lbl_applyMember.ForeColor = System.Drawing.Color.Red;
            this.lbl_applyMember.Location = new System.Drawing.Point(328, 72);
            this.lbl_applyMember.Name = "lbl_applyMember";
            this.lbl_applyMember.Size = new System.Drawing.Size(65, 12);
            this.lbl_applyMember.TabIndex = 112;
            this.lbl_applyMember.Text = "申 请 人：";
            // 
            // cmb_applyBy
            // 
            this.cmb_applyBy.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_applyBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_applyBy.FormattingEnabled = true;
            this.cmb_applyBy.Location = new System.Drawing.Point(394, 69);
            this.cmb_applyBy.Name = "cmb_applyBy";
            this.cmb_applyBy.Size = new System.Drawing.Size(222, 20);
            this.cmb_applyBy.TabIndex = 4;
            // 
            // lbl_saler
            // 
            this.lbl_saler.AutoSize = true;
            this.lbl_saler.ForeColor = System.Drawing.Color.Red;
            this.lbl_saler.Location = new System.Drawing.Point(16, 158);
            this.lbl_saler.Name = "lbl_saler";
            this.lbl_saler.Size = new System.Drawing.Size(65, 12);
            this.lbl_saler.TabIndex = 86;
            this.lbl_saler.Text = "出库物料：";
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
            // btn_output
            // 
            this.btn_output.Location = new System.Drawing.Point(245, 420);
            this.btn_output.Name = "btn_output";
            this.btn_output.Size = new System.Drawing.Size(71, 23);
            this.btn_output.TabIndex = 106;
            this.btn_output.Text = "出库";
            this.btn_output.UseVisualStyleBackColor = true;
            this.btn_output.Click += new System.EventHandler(this.btn_output_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(572, 420);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 103;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // FrmMaterialsOutDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(699, 471);
            this.Controls.Add(this.btn_output);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.grb_materialsIn);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMaterialsOutDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物料出库管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMaterialsOutDetail_FormClosed);
            this.Load += new System.EventHandler(this.FrmMaterialsOutDetail_Load);
            this.grb_materialsIn.ResumeLayout(false);
            this.grb_materialsIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_materialsIn;
        private System.Windows.Forms.TextBox txt_produceCode;
        private System.Windows.Forms.Label lbl_orderCode;
        private System.Windows.Forms.Label lbl_saler;
        private System.Windows.Forms.ComboBox cmb_materials;
        private System.Windows.Forms.Label lbl_outputStatus;
        private System.Windows.Forms.Label lbl_outputType;
        private System.Windows.Forms.Label lbl_applyMember;
        private System.Windows.Forms.ComboBox cmb_applyBy;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cmb_outputStatus;
        private System.Windows.Forms.ComboBox cmb_outputType;
        private System.Windows.Forms.DateTimePicker dtp_outputDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_factory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_applyDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_applyNum;
        private System.Windows.Forms.ComboBox cmb_applyUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_outputNum;
        private System.Windows.Forms.Button btn_output;
    }
}