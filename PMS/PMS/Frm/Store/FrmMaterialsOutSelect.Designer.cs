namespace PMS.Frm.Store
{
    partial class FrmMaterialsOutSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaterialsOutSelect));
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_materialsOut = new System.Windows.Forms.GroupBox();
            this.lbl_selectOutput = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.factoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_applyProduce = new System.Windows.Forms.GroupBox();
            this.cmb_purchaseUint = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_purchaseNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_applyPurchase = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_unitCode = new System.Windows.Forms.TextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.txt_unit = new System.Windows.Forms.TextBox();
            this.txt_factory = new System.Windows.Forms.TextBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_materials = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_outputCode = new System.Windows.Forms.TextBox();
            this.lbl_orderCode = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.grb_materialsOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.grb_applyProduce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.lbl_title.Location = new System.Drawing.Point(279, 27);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(124, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "物料出库";
            // 
            // grb_materialsOut
            // 
            this.grb_materialsOut.Controls.Add(this.lbl_selectOutput);
            this.grb_materialsOut.Controls.Add(this.label6);
            this.grb_materialsOut.Controls.Add(this.dataGridView2);
            this.grb_materialsOut.Controls.Add(this.grb_applyProduce);
            this.grb_materialsOut.Controls.Add(this.dataGridView1);
            this.grb_materialsOut.Controls.Add(this.txt_unitCode);
            this.grb_materialsOut.Controls.Add(this.btn_select);
            this.grb_materialsOut.Controls.Add(this.txt_unit);
            this.grb_materialsOut.Controls.Add(this.txt_factory);
            this.grb_materialsOut.Controls.Add(this.txt_num);
            this.grb_materialsOut.Controls.Add(this.label3);
            this.grb_materialsOut.Controls.Add(this.txt_materials);
            this.grb_materialsOut.Controls.Add(this.label2);
            this.grb_materialsOut.Controls.Add(this.label1);
            this.grb_materialsOut.Controls.Add(this.txt_outputCode);
            this.grb_materialsOut.Controls.Add(this.lbl_orderCode);
            this.grb_materialsOut.Location = new System.Drawing.Point(33, 66);
            this.grb_materialsOut.Name = "grb_materialsOut";
            this.grb_materialsOut.Size = new System.Drawing.Size(641, 474);
            this.grb_materialsOut.TabIndex = 103;
            this.grb_materialsOut.TabStop = false;
            // 
            // lbl_selectOutput
            // 
            this.lbl_selectOutput.AutoSize = true;
            this.lbl_selectOutput.ForeColor = System.Drawing.Color.Black;
            this.lbl_selectOutput.Location = new System.Drawing.Point(16, 287);
            this.lbl_selectOutput.Name = "lbl_selectOutput";
            this.lbl_selectOutput.Size = new System.Drawing.Size(77, 12);
            this.lbl_selectOutput.TabIndex = 135;
            this.lbl_selectOutput.Text = "可出库明细：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 134;
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
            this.materialsName,
            this.numDisplay,
            this.outputDate,
            this.applyMember});
            this.dataGridView2.Location = new System.Drawing.Point(18, 155);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 20;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(600, 117);
            this.dataGridView2.TabIndex = 11;
            // 
            // factoryName
            // 
            this.factoryName.DataPropertyName = "factoryName";
            this.factoryName.HeaderText = "工厂";
            this.factoryName.Name = "factoryName";
            this.factoryName.ReadOnly = true;
            this.factoryName.Width = 170;
            // 
            // materialsName
            // 
            this.materialsName.DataPropertyName = "materialsName";
            this.materialsName.HeaderText = "物料";
            this.materialsName.Name = "materialsName";
            this.materialsName.ReadOnly = true;
            this.materialsName.Width = 160;
            // 
            // numDisplay
            // 
            this.numDisplay.DataPropertyName = "numDisplay";
            this.numDisplay.HeaderText = "出库数量";
            this.numDisplay.Name = "numDisplay";
            this.numDisplay.ReadOnly = true;
            this.numDisplay.Width = 80;
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
            // grb_applyProduce
            // 
            this.grb_applyProduce.Controls.Add(this.cmb_purchaseUint);
            this.grb_applyProduce.Controls.Add(this.label5);
            this.grb_applyProduce.Controls.Add(this.txt_purchaseNum);
            this.grb_applyProduce.Controls.Add(this.label4);
            this.grb_applyProduce.Controls.Add(this.btn_applyPurchase);
            this.grb_applyProduce.Location = new System.Drawing.Point(219, 88);
            this.grb_applyProduce.Name = "grb_applyProduce";
            this.grb_applyProduce.Size = new System.Drawing.Size(383, 35);
            this.grb_applyProduce.TabIndex = 132;
            this.grb_applyProduce.TabStop = false;
            // 
            // cmb_purchaseUint
            // 
            this.cmb_purchaseUint.FormattingEnabled = true;
            this.cmb_purchaseUint.Location = new System.Drawing.Point(209, 12);
            this.cmb_purchaseUint.Name = "cmb_purchaseUint";
            this.cmb_purchaseUint.Size = new System.Drawing.Size(76, 20);
            this.cmb_purchaseUint.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(171, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 135;
            this.label5.Text = "单位：";
            // 
            // txt_purchaseNum
            // 
            this.txt_purchaseNum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_purchaseNum.Location = new System.Drawing.Point(65, 12);
            this.txt_purchaseNum.MaxLength = 12;
            this.txt_purchaseNum.Name = "txt_purchaseNum";
            this.txt_purchaseNum.Size = new System.Drawing.Size(100, 21);
            this.txt_purchaseNum.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 133;
            this.label4.Text = "购买数量：";
            // 
            // btn_applyPurchase
            // 
            this.btn_applyPurchase.Location = new System.Drawing.Point(302, 10);
            this.btn_applyPurchase.Name = "btn_applyPurchase";
            this.btn_applyPurchase.Size = new System.Drawing.Size(75, 23);
            this.btn_applyPurchase.TabIndex = 10;
            this.btn_applyPurchase.Text = "申请购买";
            this.btn_applyPurchase.UseVisualStyleBackColor = true;
            this.btn_applyPurchase.Click += new System.EventHandler(this.btn_applyPurchase_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(18, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(600, 165);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // txt_unitCode
            // 
            this.txt_unitCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_unitCode.Enabled = false;
            this.txt_unitCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_unitCode.Location = new System.Drawing.Point(99, 101);
            this.txt_unitCode.MaxLength = 20;
            this.txt_unitCode.Name = "txt_unitCode";
            this.txt_unitCode.Size = new System.Drawing.Size(37, 21);
            this.txt_unitCode.TabIndex = 7;
            this.txt_unitCode.Visible = false;
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(18, 99);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 6;
            this.btn_select.Text = "刷新库存";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // txt_unit
            // 
            this.txt_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_unit.Enabled = false;
            this.txt_unit.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_unit.Location = new System.Drawing.Point(565, 62);
            this.txt_unit.MaxLength = 20;
            this.txt_unit.Name = "txt_unit";
            this.txt_unit.Size = new System.Drawing.Size(37, 21);
            this.txt_unit.TabIndex = 5;
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
            // txt_num
            // 
            this.txt_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_num.Enabled = false;
            this.txt_num.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_num.Location = new System.Drawing.Point(380, 62);
            this.txt_num.MaxLength = 20;
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(179, 21);
            this.txt_num.TabIndex = 4;
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
            // txt_materials
            // 
            this.txt_materials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_materials.Enabled = false;
            this.txt_materials.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_materials.Location = new System.Drawing.Point(77, 62);
            this.txt_materials.MaxLength = 20;
            this.txt_materials.Name = "txt_materials";
            this.txt_materials.Size = new System.Drawing.Size(222, 21);
            this.txt_materials.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 122;
            this.label2.Text = "出库物料：";
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
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(576, 577);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 104;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // FrmMaterialsOutSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(711, 632);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.grb_materialsOut);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMaterialsOutSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物料出库管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMaterialsOutSelect_FormClosed);
            this.Load += new System.EventHandler(this.FrmMaterialsOutSelect_Load);
            this.grb_materialsOut.ResumeLayout(false);
            this.grb_materialsOut.PerformLayout();
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
        private System.Windows.Forms.GroupBox grb_materialsOut;
        private System.Windows.Forms.TextBox txt_outputCode;
        private System.Windows.Forms.Label lbl_orderCode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_unit;
        private System.Windows.Forms.TextBox txt_factory;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_materials;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.TextBox txt_unitCode;
        private System.Windows.Forms.GroupBox grb_applyProduce;
        private System.Windows.Forms.ComboBox cmb_purchaseUint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_purchaseNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_applyPurchase;
        private System.Windows.Forms.Label lbl_selectOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyMember;
        private System.Windows.Forms.Button btn_close;
    }
}