﻿namespace PMS.Frm.Store
{
    partial class FrmProductOutSelect
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductOutSelect));
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_productOut = new System.Windows.Forms.GroupBox();
            this.grb_applyProduce = new System.Windows.Forms.GroupBox();
            this.txt_produceNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_applyProduce = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.txt_factory = new System.Windows.Forms.TextBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_outputCode = new System.Windows.Forms.TextBox();
            this.lbl_orderCode = new System.Windows.Forms.Label();
            this.lbl_selectOutput = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.factoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_close = new System.Windows.Forms.Button();
            this.grb_productOut.SuspendLayout();
            this.grb_applyProduce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(223, 577);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 101;
            this.btn_submit.Text = "确认";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(416, 577);
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
            this.lbl_title.Text = "产品出库";
            // 
            // grb_productOut
            // 
            this.grb_productOut.Controls.Add(this.dataGridView2);
            this.grb_productOut.Controls.Add(this.lbl_selectOutput);
            this.grb_productOut.Controls.Add(this.label6);
            this.grb_productOut.Controls.Add(this.grb_applyProduce);
            this.grb_productOut.Controls.Add(this.btn_select);
            this.grb_productOut.Controls.Add(this.txt_factory);
            this.grb_productOut.Controls.Add(this.txt_num);
            this.grb_productOut.Controls.Add(this.label3);
            this.grb_productOut.Controls.Add(this.txt_product);
            this.grb_productOut.Controls.Add(this.label2);
            this.grb_productOut.Controls.Add(this.label1);
            this.grb_productOut.Controls.Add(this.dataGridView1);
            this.grb_productOut.Controls.Add(this.txt_outputCode);
            this.grb_productOut.Controls.Add(this.lbl_orderCode);
            this.grb_productOut.Location = new System.Drawing.Point(33, 66);
            this.grb_productOut.Name = "grb_productOut";
            this.grb_productOut.Size = new System.Drawing.Size(641, 474);
            this.grb_productOut.TabIndex = 103;
            this.grb_productOut.TabStop = false;
            // 
            // grb_applyProduce
            // 
            this.grb_applyProduce.Controls.Add(this.txt_produceNum);
            this.grb_applyProduce.Controls.Add(this.label4);
            this.grb_applyProduce.Controls.Add(this.btn_applyProduce);
            this.grb_applyProduce.Location = new System.Drawing.Point(326, 87);
            this.grb_applyProduce.Name = "grb_applyProduce";
            this.grb_applyProduce.Size = new System.Drawing.Size(276, 35);
            this.grb_applyProduce.TabIndex = 131;
            this.grb_applyProduce.TabStop = false;
            // 
            // txt_produceNum
            // 
            this.txt_produceNum.Location = new System.Drawing.Point(78, 12);
            this.txt_produceNum.Name = "txt_produceNum";
            this.txt_produceNum.Size = new System.Drawing.Size(100, 21);
            this.txt_produceNum.TabIndex = 134;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 133;
            this.label4.Text = "生产数量：";
            // 
            // btn_applyProduce
            // 
            this.btn_applyProduce.Location = new System.Drawing.Point(192, 10);
            this.btn_applyProduce.Name = "btn_applyProduce";
            this.btn_applyProduce.Size = new System.Drawing.Size(75, 23);
            this.btn_applyProduce.TabIndex = 130;
            this.btn_applyProduce.Text = "申请生产";
            this.btn_applyProduce.UseVisualStyleBackColor = true;
            this.btn_applyProduce.Click += new System.EventHandler(this.btn_applyProduce_Click);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(18, 99);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 128;
            this.btn_select.Text = "刷新库存";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // txt_factory
            // 
            this.txt_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_factory.Enabled = false;
            this.txt_factory.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_factory.Location = new System.Drawing.Point(380, 24);
            this.txt_factory.MaxLength = 20;
            this.txt_factory.Name = "txt_factory";
            this.txt_factory.Size = new System.Drawing.Size(222, 21);
            this.txt_factory.TabIndex = 126;
            // 
            // txt_num
            // 
            this.txt_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_num.Enabled = false;
            this.txt_num.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_num.Location = new System.Drawing.Point(380, 62);
            this.txt_num.MaxLength = 20;
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(222, 21);
            this.txt_num.TabIndex = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(319, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 124;
            this.label3.Text = "出库数量：";
            // 
            // txt_product
            // 
            this.txt_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_product.Enabled = false;
            this.txt_product.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_product.Location = new System.Drawing.Point(77, 62);
            this.txt_product.MaxLength = 20;
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(222, 21);
            this.txt_product.TabIndex = 123;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 122;
            this.label2.Text = "出库产品：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(319, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 121;
            this.label1.Text = "工    厂：";
            this.label1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(600, 156);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // txt_outputCode
            // 
            this.txt_outputCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_outputCode.Enabled = false;
            this.txt_outputCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_outputCode.Location = new System.Drawing.Point(77, 24);
            this.txt_outputCode.MaxLength = 20;
            this.txt_outputCode.Name = "txt_outputCode";
            this.txt_outputCode.Size = new System.Drawing.Size(222, 21);
            this.txt_outputCode.TabIndex = 43;
            // 
            // lbl_orderCode
            // 
            this.lbl_orderCode.AutoSize = true;
            this.lbl_orderCode.ForeColor = System.Drawing.Color.Black;
            this.lbl_orderCode.Location = new System.Drawing.Point(16, 27);
            this.lbl_orderCode.Name = "lbl_orderCode";
            this.lbl_orderCode.Size = new System.Drawing.Size(65, 12);
            this.lbl_orderCode.TabIndex = 42;
            this.lbl_orderCode.Text = "出库单号：";
            // 
            // lbl_selectOutput
            // 
            this.lbl_selectOutput.AutoSize = true;
            this.lbl_selectOutput.ForeColor = System.Drawing.Color.Black;
            this.lbl_selectOutput.Location = new System.Drawing.Point(16, 284);
            this.lbl_selectOutput.Name = "lbl_selectOutput";
            this.lbl_selectOutput.Size = new System.Drawing.Size(77, 12);
            this.lbl_selectOutput.TabIndex = 137;
            this.lbl_selectOutput.Text = "可出库明细：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 136;
            this.label6.Text = "已出库明细：";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.factoryName,
            this.productName,
            this.num,
            this.outputDate,
            this.applyMember});
            this.dataGridView2.Location = new System.Drawing.Point(20, 155);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 20;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(600, 117);
            this.dataGridView2.TabIndex = 138;
            // 
            // factoryName
            // 
            this.factoryName.DataPropertyName = "factoryName";
            this.factoryName.HeaderText = "工厂";
            this.factoryName.Name = "factoryName";
            this.factoryName.ReadOnly = true;
            this.factoryName.Width = 170;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "产品";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 160;
            // 
            // num
            // 
            this.num.DataPropertyName = "num";
            this.num.HeaderText = "出库数量";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 80;
            // 
            // outputDate
            // 
            this.outputDate.DataPropertyName = "outputDate";
            this.outputDate.HeaderText = "出库日期";
            this.outputDate.Name = "outputDate";
            this.outputDate.ReadOnly = true;
            this.outputDate.Width = 80;
            // 
            // applyMember
            // 
            this.applyMember.DataPropertyName = "applyMember";
            this.applyMember.HeaderText = "申请人";
            this.applyMember.Name = "applyMember";
            this.applyMember.ReadOnly = true;
            this.applyMember.Width = 80;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(576, 577);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 105;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // FrmProductOutSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(711, 632);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.grb_productOut);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductOutSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出库管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProductOutSelect_FormClosed);
            this.Load += new System.EventHandler(this.FrmOrderDetail_Load);
            this.grb_productOut.ResumeLayout(false);
            this.grb_productOut.PerformLayout();
            this.grb_applyProduce.ResumeLayout(false);
            this.grb_applyProduce.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_productOut;
        private System.Windows.Forms.TextBox txt_outputCode;
        private System.Windows.Forms.Label lbl_orderCode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_factory;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_applyProduce;
        private System.Windows.Forms.GroupBox grb_applyProduce;
        private System.Windows.Forms.TextBox txt_produceNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_selectOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyMember;
        private System.Windows.Forms.Button btn_close;
    }
}