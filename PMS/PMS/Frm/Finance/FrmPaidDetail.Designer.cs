namespace PMS.Frm.Finance
{
    partial class FrmPaidDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaidDetail));
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_productOut = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_paidPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_orderPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_selectOutput = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_customer = new System.Windows.Forms.TextBox();
            this.txt_paidStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_purchaseStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_purchaseCode = new System.Windows.Forms.TextBox();
            this.lbl_orderCode = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.paidMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_productOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_title.Location = new System.Drawing.Point(282, 23);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(124, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "付款明细";
            // 
            // grb_productOut
            // 
            this.grb_productOut.Controls.Add(this.dataGridView1);
            this.grb_productOut.Controls.Add(this.txt_paidPrice);
            this.grb_productOut.Controls.Add(this.label4);
            this.grb_productOut.Controls.Add(this.txt_orderPrice);
            this.grb_productOut.Controls.Add(this.label5);
            this.grb_productOut.Controls.Add(this.lbl_selectOutput);
            this.grb_productOut.Controls.Add(this.btn_add);
            this.grb_productOut.Controls.Add(this.txt_customer);
            this.grb_productOut.Controls.Add(this.txt_paidStatus);
            this.grb_productOut.Controls.Add(this.label3);
            this.grb_productOut.Controls.Add(this.txt_purchaseStatus);
            this.grb_productOut.Controls.Add(this.label2);
            this.grb_productOut.Controls.Add(this.label1);
            this.grb_productOut.Controls.Add(this.txt_purchaseCode);
            this.grb_productOut.Controls.Add(this.lbl_orderCode);
            this.grb_productOut.Location = new System.Drawing.Point(33, 66);
            this.grb_productOut.Name = "grb_productOut";
            this.grb_productOut.Size = new System.Drawing.Size(641, 371);
            this.grb_productOut.TabIndex = 103;
            this.grb_productOut.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paidMoney,
            this.paidDate,
            this.paidType,
            this.remark});
            this.dataGridView1.Location = new System.Drawing.Point(18, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(600, 144);
            this.dataGridView1.TabIndex = 1;
            // 
            // txt_paidPrice
            // 
            this.txt_paidPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_paidPrice.Enabled = false;
            this.txt_paidPrice.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_paidPrice.Location = new System.Drawing.Point(380, 102);
            this.txt_paidPrice.MaxLength = 20;
            this.txt_paidPrice.Name = "txt_paidPrice";
            this.txt_paidPrice.Size = new System.Drawing.Size(222, 21);
            this.txt_paidPrice.TabIndex = 141;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(319, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 140;
            this.label4.Text = "已付金额：";
            // 
            // txt_orderPrice
            // 
            this.txt_orderPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_orderPrice.Enabled = false;
            this.txt_orderPrice.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_orderPrice.Location = new System.Drawing.Point(77, 102);
            this.txt_orderPrice.MaxLength = 20;
            this.txt_orderPrice.Name = "txt_orderPrice";
            this.txt_orderPrice.Size = new System.Drawing.Size(222, 21);
            this.txt_orderPrice.TabIndex = 139;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 138;
            this.label5.Text = "应付金额：";
            // 
            // lbl_selectOutput
            // 
            this.lbl_selectOutput.AutoSize = true;
            this.lbl_selectOutput.ForeColor = System.Drawing.Color.Black;
            this.lbl_selectOutput.Location = new System.Drawing.Point(16, 144);
            this.lbl_selectOutput.Name = "lbl_selectOutput";
            this.lbl_selectOutput.Size = new System.Drawing.Size(65, 12);
            this.lbl_selectOutput.TabIndex = 137;
            this.lbl_selectOutput.Text = "付款明细：";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(18, 324);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "新增付款";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_customer
            // 
            this.txt_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_customer.Enabled = false;
            this.txt_customer.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_customer.Location = new System.Drawing.Point(380, 24);
            this.txt_customer.MaxLength = 20;
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.Size = new System.Drawing.Size(222, 21);
            this.txt_customer.TabIndex = 126;
            // 
            // txt_paidStatus
            // 
            this.txt_paidStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_paidStatus.Enabled = false;
            this.txt_paidStatus.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_paidStatus.Location = new System.Drawing.Point(380, 62);
            this.txt_paidStatus.MaxLength = 20;
            this.txt_paidStatus.Name = "txt_paidStatus";
            this.txt_paidStatus.Size = new System.Drawing.Size(222, 21);
            this.txt_paidStatus.TabIndex = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(319, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 124;
            this.label3.Text = "付款状态：";
            // 
            // txt_purchaseStatus
            // 
            this.txt_purchaseStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_purchaseStatus.Enabled = false;
            this.txt_purchaseStatus.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_purchaseStatus.Location = new System.Drawing.Point(77, 62);
            this.txt_purchaseStatus.MaxLength = 20;
            this.txt_purchaseStatus.Name = "txt_purchaseStatus";
            this.txt_purchaseStatus.Size = new System.Drawing.Size(222, 21);
            this.txt_purchaseStatus.TabIndex = 123;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 122;
            this.label2.Text = "订单状态：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(319, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 121;
            this.label1.Text = "客    户：";
            // 
            // txt_purchaseCode
            // 
            this.txt_purchaseCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_purchaseCode.Enabled = false;
            this.txt_purchaseCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_purchaseCode.Location = new System.Drawing.Point(77, 24);
            this.txt_purchaseCode.MaxLength = 20;
            this.txt_purchaseCode.Name = "txt_purchaseCode";
            this.txt_purchaseCode.Size = new System.Drawing.Size(222, 21);
            this.txt_purchaseCode.TabIndex = 43;
            // 
            // lbl_orderCode
            // 
            this.lbl_orderCode.AutoSize = true;
            this.lbl_orderCode.ForeColor = System.Drawing.Color.Black;
            this.lbl_orderCode.Location = new System.Drawing.Point(16, 27);
            this.lbl_orderCode.Name = "lbl_orderCode";
            this.lbl_orderCode.Size = new System.Drawing.Size(65, 12);
            this.lbl_orderCode.TabIndex = 42;
            this.lbl_orderCode.Text = "采购单号：";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(578, 458);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 105;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // paidMoney
            // 
            this.paidMoney.DataPropertyName = "paidMoney";
            this.paidMoney.HeaderText = "付款金额";
            this.paidMoney.Name = "paidMoney";
            this.paidMoney.ReadOnly = true;
            this.paidMoney.Width = 120;
            // 
            // paidDate
            // 
            this.paidDate.DataPropertyName = "paidDate";
            this.paidDate.HeaderText = "付款日期";
            this.paidDate.Name = "paidDate";
            this.paidDate.ReadOnly = true;
            this.paidDate.Width = 120;
            // 
            // paidType
            // 
            this.paidType.DataPropertyName = "paidType";
            this.paidType.HeaderText = "付款方式";
            this.paidType.Name = "paidType";
            this.paidType.ReadOnly = true;
            this.paidType.Width = 120;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "付款备注";
            this.remark.Name = "remark";
            this.remark.Width = 200;
            // 
            // FrmPaidDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(711, 517);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.grb_productOut);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPaidDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "付款管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPaidDetail_FormClosed);
            this.Load += new System.EventHandler(this.FrmPaidDetail_Load);
            this.grb_productOut.ResumeLayout(false);
            this.grb_productOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_productOut;
        private System.Windows.Forms.TextBox txt_purchaseCode;
        private System.Windows.Forms.Label lbl_orderCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_customer;
        private System.Windows.Forms.TextBox txt_paidStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_purchaseStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_selectOutput;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_paidPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_orderPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidType;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
    }
}