namespace PMS.Frm.Store
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductOutSelect));
            this.btn_close = new System.Windows.Forms.Button();
            this.grb_productOut = new System.Windows.Forms.GroupBox();
            this.txt_realityOutputNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_outputNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.txt_outputStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbl_selectOutput = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grb_applyProduce = new System.Windows.Forms.GroupBox();
            this.txt_produceNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_applyProduce = new System.Windows.Forms.Button();
            this.txt_factory = new System.Windows.Forms.TextBox();
            this.txt_specs = new System.Windows.Forms.TextBox();
            this.lbl_specs = new System.Windows.Forms.Label();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_outputCode = new System.Windows.Forms.TextBox();
            this.lbl_orderCode = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputCode = new System.Windows.Forms.DataGridViewLinkColumn();
            this.specsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_productOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.grb_applyProduce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(576, 624);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 105;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // grb_productOut
            // 
            this.grb_productOut.Controls.Add(this.txt_realityOutputNum);
            this.grb_productOut.Controls.Add(this.label3);
            this.grb_productOut.Controls.Add(this.txt_outputNum);
            this.grb_productOut.Controls.Add(this.label7);
            this.grb_productOut.Controls.Add(this.btn_select);
            this.grb_productOut.Controls.Add(this.txt_outputStatus);
            this.grb_productOut.Controls.Add(this.label5);
            this.grb_productOut.Controls.Add(this.dataGridView2);
            this.grb_productOut.Controls.Add(this.lbl_selectOutput);
            this.grb_productOut.Controls.Add(this.label6);
            this.grb_productOut.Controls.Add(this.grb_applyProduce);
            this.grb_productOut.Controls.Add(this.txt_factory);
            this.grb_productOut.Controls.Add(this.txt_specs);
            this.grb_productOut.Controls.Add(this.lbl_specs);
            this.grb_productOut.Controls.Add(this.txt_product);
            this.grb_productOut.Controls.Add(this.label2);
            this.grb_productOut.Controls.Add(this.label1);
            this.grb_productOut.Controls.Add(this.dataGridView1);
            this.grb_productOut.Controls.Add(this.txt_outputCode);
            this.grb_productOut.Controls.Add(this.lbl_orderCode);
            this.grb_productOut.Location = new System.Drawing.Point(33, 66);
            this.grb_productOut.Name = "grb_productOut";
            this.grb_productOut.Size = new System.Drawing.Size(641, 539);
            this.grb_productOut.TabIndex = 103;
            this.grb_productOut.TabStop = false;
            // 
            // txt_realityOutputNum
            // 
            this.txt_realityOutputNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_realityOutputNum.Enabled = false;
            this.txt_realityOutputNum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_realityOutputNum.Location = new System.Drawing.Point(77, 138);
            this.txt_realityOutputNum.MaxLength = 20;
            this.txt_realityOutputNum.Name = "txt_realityOutputNum";
            this.txt_realityOutputNum.Size = new System.Drawing.Size(222, 21);
            this.txt_realityOutputNum.TabIndex = 142;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 143;
            this.label3.Text = "出库数量：";
            // 
            // txt_outputNum
            // 
            this.txt_outputNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_outputNum.Enabled = false;
            this.txt_outputNum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_outputNum.Location = new System.Drawing.Point(380, 99);
            this.txt_outputNum.MaxLength = 20;
            this.txt_outputNum.Name = "txt_outputNum";
            this.txt_outputNum.Size = new System.Drawing.Size(222, 21);
            this.txt_outputNum.TabIndex = 140;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(319, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 141;
            this.label7.Text = "请求数量：";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(90, 331);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 5;
            this.btn_select.Text = "刷新库存";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // txt_outputStatus
            // 
            this.txt_outputStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_outputStatus.Enabled = false;
            this.txt_outputStatus.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_outputStatus.Location = new System.Drawing.Point(77, 99);
            this.txt_outputStatus.MaxLength = 20;
            this.txt_outputStatus.Name = "txt_outputStatus";
            this.txt_outputStatus.Size = new System.Drawing.Size(222, 21);
            this.txt_outputStatus.TabIndex = 138;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 139;
            this.label5.Text = "出库状态：";
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
            this.productName,
            this.inputCode,
            this.specsName,
            this.num,
            this.outputDate,
            this.applyMember});
            this.dataGridView2.Location = new System.Drawing.Point(20, 189);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 20;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(610, 117);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // lbl_selectOutput
            // 
            this.lbl_selectOutput.AutoSize = true;
            this.lbl_selectOutput.ForeColor = System.Drawing.Color.Black;
            this.lbl_selectOutput.Location = new System.Drawing.Point(16, 336);
            this.lbl_selectOutput.Name = "lbl_selectOutput";
            this.lbl_selectOutput.Size = new System.Drawing.Size(77, 12);
            this.lbl_selectOutput.TabIndex = 137;
            this.lbl_selectOutput.Text = "可出库明细：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 136;
            this.label6.Text = "已出库明细：";
            // 
            // grb_applyProduce
            // 
            this.grb_applyProduce.Controls.Add(this.txt_produceNum);
            this.grb_applyProduce.Controls.Add(this.label4);
            this.grb_applyProduce.Controls.Add(this.btn_applyProduce);
            this.grb_applyProduce.Location = new System.Drawing.Point(319, 126);
            this.grb_applyProduce.Name = "grb_applyProduce";
            this.grb_applyProduce.Size = new System.Drawing.Size(287, 39);
            this.grb_applyProduce.TabIndex = 131;
            this.grb_applyProduce.TabStop = false;
            // 
            // txt_produceNum
            // 
            this.txt_produceNum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_produceNum.Location = new System.Drawing.Point(60, 12);
            this.txt_produceNum.MaxLength = 10;
            this.txt_produceNum.Name = "txt_produceNum";
            this.txt_produceNum.Size = new System.Drawing.Size(138, 21);
            this.txt_produceNum.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 133;
            this.label4.Text = "生产数量：";
            // 
            // btn_applyProduce
            // 
            this.btn_applyProduce.Location = new System.Drawing.Point(204, 10);
            this.btn_applyProduce.Name = "btn_applyProduce";
            this.btn_applyProduce.Size = new System.Drawing.Size(75, 23);
            this.btn_applyProduce.TabIndex = 7;
            this.btn_applyProduce.Text = "申请生产";
            this.btn_applyProduce.UseVisualStyleBackColor = true;
            this.btn_applyProduce.Click += new System.EventHandler(this.btn_applyProduce_Click);
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
            this.txt_factory.TabIndex = 2;
            // 
            // txt_specs
            // 
            this.txt_specs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_specs.Enabled = false;
            this.txt_specs.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_specs.Location = new System.Drawing.Point(380, 62);
            this.txt_specs.MaxLength = 20;
            this.txt_specs.Name = "txt_specs";
            this.txt_specs.Size = new System.Drawing.Size(222, 21);
            this.txt_specs.TabIndex = 4;
            // 
            // lbl_specs
            // 
            this.lbl_specs.AutoSize = true;
            this.lbl_specs.ForeColor = System.Drawing.Color.Black;
            this.lbl_specs.Location = new System.Drawing.Point(319, 65);
            this.lbl_specs.Name = "lbl_specs";
            this.lbl_specs.Size = new System.Drawing.Size(65, 12);
            this.lbl_specs.TabIndex = 124;
            this.lbl_specs.Text = "成品规格：";
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
            this.txt_product.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 122;
            this.label2.Text = "出库成品：";
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
            this.dataGridView1.Location = new System.Drawing.Point(18, 361);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(600, 156);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.txt_outputCode.TabIndex = 1;
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
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_title.Location = new System.Drawing.Point(282, 23);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(124, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "成品出库";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(416, 624);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 102;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(223, 624);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 101;
            this.btn_submit.Text = "确认";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "成品";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 140;
            // 
            // inputCode
            // 
            this.inputCode.DataPropertyName = "inputCode";
            this.inputCode.HeaderText = "入库单号";
            this.inputCode.Name = "inputCode";
            this.inputCode.ReadOnly = true;
            this.inputCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.inputCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.inputCode.Width = 120;
            // 
            // specsName
            // 
            this.specsName.DataPropertyName = "specsName";
            this.specsName.HeaderText = "规格";
            this.specsName.Name = "specsName";
            this.specsName.ReadOnly = true;
            this.specsName.Width = 80;
            // 
            // num
            // 
            this.num.DataPropertyName = "num";
            this.num.HeaderText = "数量";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 60;
            // 
            // outputDate
            // 
            this.outputDate.DataPropertyName = "outputDate";
            this.outputDate.HeaderText = "日期";
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
            this.applyMember.Width = 70;
            // 
            // FrmProductOutSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(710, 665);
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
            this.Load += new System.EventHandler(this.FrmProductOutSelect_Load);
            this.grb_productOut.ResumeLayout(false);
            this.grb_productOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.grb_applyProduce.ResumeLayout(false);
            this.grb_applyProduce.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox txt_specs;
        private System.Windows.Forms.Label lbl_specs;
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
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_outputStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_outputNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_realityOutputNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewLinkColumn inputCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn specsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyMember;
    }
}