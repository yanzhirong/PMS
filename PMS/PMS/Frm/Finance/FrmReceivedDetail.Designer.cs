namespace PMS.Frm.Finance
{
    partial class FrmReceivedDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReceivedDetail));
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_productOut = new System.Windows.Forms.GroupBox();
            this.lbl_selectOutput = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_customer = new System.Windows.Forms.TextBox();
            this.txt_receiveStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_orderStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_orderCode = new System.Windows.Forms.TextBox();
            this.lbl_orderCode = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_receivedMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_orderPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.receivedMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_productOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(225, 458);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 101;
            this.btn_submit.Text = "确认";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(418, 458);
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
            this.lbl_title.Location = new System.Drawing.Point(282, 23);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(124, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "收款明细";
            // 
            // grb_productOut
            // 
            this.grb_productOut.Controls.Add(this.dataGridView1);
            this.grb_productOut.Controls.Add(this.txt_receivedMoney);
            this.grb_productOut.Controls.Add(this.label4);
            this.grb_productOut.Controls.Add(this.txt_orderPrice);
            this.grb_productOut.Controls.Add(this.label5);
            this.grb_productOut.Controls.Add(this.lbl_selectOutput);
            this.grb_productOut.Controls.Add(this.btn_add);
            this.grb_productOut.Controls.Add(this.txt_customer);
            this.grb_productOut.Controls.Add(this.txt_receiveStatus);
            this.grb_productOut.Controls.Add(this.label3);
            this.grb_productOut.Controls.Add(this.txt_orderStatus);
            this.grb_productOut.Controls.Add(this.label2);
            this.grb_productOut.Controls.Add(this.label1);
            this.grb_productOut.Controls.Add(this.txt_orderCode);
            this.grb_productOut.Controls.Add(this.lbl_orderCode);
            this.grb_productOut.Location = new System.Drawing.Point(33, 66);
            this.grb_productOut.Name = "grb_productOut";
            this.grb_productOut.Size = new System.Drawing.Size(641, 371);
            this.grb_productOut.TabIndex = 103;
            this.grb_productOut.TabStop = false;
            // 
            // lbl_selectOutput
            // 
            this.lbl_selectOutput.AutoSize = true;
            this.lbl_selectOutput.ForeColor = System.Drawing.Color.Black;
            this.lbl_selectOutput.Location = new System.Drawing.Point(16, 144);
            this.lbl_selectOutput.Name = "lbl_selectOutput";
            this.lbl_selectOutput.Size = new System.Drawing.Size(65, 12);
            this.lbl_selectOutput.TabIndex = 137;
            this.lbl_selectOutput.Text = "收款明细：";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(18, 324);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "新增收款";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_select_Click);
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
            // txt_receiveStatus
            // 
            this.txt_receiveStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_receiveStatus.Enabled = false;
            this.txt_receiveStatus.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_receiveStatus.Location = new System.Drawing.Point(380, 62);
            this.txt_receiveStatus.MaxLength = 20;
            this.txt_receiveStatus.Name = "txt_receiveStatus";
            this.txt_receiveStatus.Size = new System.Drawing.Size(222, 21);
            this.txt_receiveStatus.TabIndex = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(319, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 124;
            this.label3.Text = "收款状态：";
            // 
            // txt_orderStatus
            // 
            this.txt_orderStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_orderStatus.Enabled = false;
            this.txt_orderStatus.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_orderStatus.Location = new System.Drawing.Point(77, 62);
            this.txt_orderStatus.MaxLength = 20;
            this.txt_orderStatus.Name = "txt_orderStatus";
            this.txt_orderStatus.Size = new System.Drawing.Size(222, 21);
            this.txt_orderStatus.TabIndex = 123;
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
            this.label1.Visible = false;
            // 
            // txt_orderCode
            // 
            this.txt_orderCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_orderCode.Enabled = false;
            this.txt_orderCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_orderCode.Location = new System.Drawing.Point(77, 24);
            this.txt_orderCode.MaxLength = 20;
            this.txt_orderCode.Name = "txt_orderCode";
            this.txt_orderCode.Size = new System.Drawing.Size(222, 21);
            this.txt_orderCode.TabIndex = 43;
            // 
            // lbl_orderCode
            // 
            this.lbl_orderCode.AutoSize = true;
            this.lbl_orderCode.ForeColor = System.Drawing.Color.Black;
            this.lbl_orderCode.Location = new System.Drawing.Point(16, 27);
            this.lbl_orderCode.Name = "lbl_orderCode";
            this.lbl_orderCode.Size = new System.Drawing.Size(65, 12);
            this.lbl_orderCode.TabIndex = 42;
            this.lbl_orderCode.Text = "销售单号：";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(578, 458);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 105;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // txt_receivedMoney
            // 
            this.txt_receivedMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_receivedMoney.Enabled = false;
            this.txt_receivedMoney.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_receivedMoney.Location = new System.Drawing.Point(380, 102);
            this.txt_receivedMoney.MaxLength = 20;
            this.txt_receivedMoney.Name = "txt_receivedMoney";
            this.txt_receivedMoney.Size = new System.Drawing.Size(222, 21);
            this.txt_receivedMoney.TabIndex = 141;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(319, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 140;
            this.label4.Text = "已收金额：";
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
            this.label5.Text = "应收金额：";
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
            this.receivedMoney,
            this.receivedDate,
            this.receivedType,
            this.remark});
            this.dataGridView1.Location = new System.Drawing.Point(18, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(600, 144);
            this.dataGridView1.TabIndex = 1;
            // 
            // receivedMoney
            // 
            this.receivedMoney.DataPropertyName = "receivedMoney";
            this.receivedMoney.HeaderText = "收款金额";
            this.receivedMoney.Name = "receivedMoney";
            this.receivedMoney.ReadOnly = true;
            this.receivedMoney.Width = 120;
            // 
            // receivedDate
            // 
            this.receivedDate.DataPropertyName = "receivedDate";
            this.receivedDate.HeaderText = "收款日期";
            this.receivedDate.Name = "receivedDate";
            this.receivedDate.ReadOnly = true;
            this.receivedDate.Width = 120;
            // 
            // receivedType
            // 
            this.receivedType.DataPropertyName = "receivedType";
            this.receivedType.HeaderText = "收款方式";
            this.receivedType.Name = "receivedType";
            this.receivedType.ReadOnly = true;
            this.receivedType.Width = 120;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "收款备注";
            this.remark.Name = "remark";
            this.remark.Width = 200;
            // 
            // FrmReceivedDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(711, 517);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.grb_productOut);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReceivedDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收款管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmReceivedDetail_FormClosed);
            this.Load += new System.EventHandler(this.FrmReceivedDetail_Load);
            this.grb_productOut.ResumeLayout(false);
            this.grb_productOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_productOut;
        private System.Windows.Forms.TextBox txt_orderCode;
        private System.Windows.Forms.Label lbl_orderCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_customer;
        private System.Windows.Forms.TextBox txt_receiveStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_orderStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_selectOutput;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_receivedMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_orderPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedType;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
    }
}