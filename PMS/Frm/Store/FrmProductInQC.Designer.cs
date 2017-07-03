namespace PMS.Frm.Store
{
    partial class FrmProductInQC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductInQC));
            this.grb_QC = new System.Windows.Forms.GroupBox();
            this.cmb_inspecter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_QCDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_checker = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_result = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_inputNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_productType = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_specsName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_produceCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_excuteStandard = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_produceDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_factoryName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.deleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grb_QC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_QC
            // 
            this.grb_QC.Controls.Add(this.cmb_inspecter);
            this.grb_QC.Controls.Add(this.label4);
            this.grb_QC.Controls.Add(this.dtp_QCDate);
            this.grb_QC.Controls.Add(this.label3);
            this.grb_QC.Controls.Add(this.cmb_checker);
            this.grb_QC.Controls.Add(this.label2);
            this.grb_QC.Controls.Add(this.cmb_result);
            this.grb_QC.Controls.Add(this.label1);
            this.grb_QC.Controls.Add(this.txt_inputNum);
            this.grb_QC.Controls.Add(this.label8);
            this.grb_QC.Controls.Add(this.txt_productType);
            this.grb_QC.Controls.Add(this.label9);
            this.grb_QC.Controls.Add(this.txt_specsName);
            this.grb_QC.Controls.Add(this.label10);
            this.grb_QC.Controls.Add(this.txt_productName);
            this.grb_QC.Controls.Add(this.label11);
            this.grb_QC.Controls.Add(this.txt_produceCode);
            this.grb_QC.Controls.Add(this.label7);
            this.grb_QC.Controls.Add(this.txt_excuteStandard);
            this.grb_QC.Controls.Add(this.label6);
            this.grb_QC.Controls.Add(this.txt_produceDate);
            this.grb_QC.Controls.Add(this.label5);
            this.grb_QC.Controls.Add(this.dataGridView1);
            this.grb_QC.Controls.Add(this.txt_factoryName);
            this.grb_QC.Controls.Add(this.label15);
            this.grb_QC.Location = new System.Drawing.Point(31, 70);
            this.grb_QC.Name = "grb_QC";
            this.grb_QC.Size = new System.Drawing.Size(619, 475);
            this.grb_QC.TabIndex = 103;
            this.grb_QC.TabStop = false;
            // 
            // cmb_inspecter
            // 
            this.cmb_inspecter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_inspecter.FormattingEnabled = true;
            this.cmb_inspecter.Location = new System.Drawing.Point(87, 443);
            this.cmb_inspecter.Name = "cmb_inspecter";
            this.cmb_inspecter.Size = new System.Drawing.Size(205, 20);
            this.cmb_inspecter.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(16, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 87;
            this.label4.Text = "检 验 员：";
            // 
            // dtp_QCDate
            // 
            this.dtp_QCDate.Location = new System.Drawing.Point(393, 410);
            this.dtp_QCDate.Name = "dtp_QCDate";
            this.dtp_QCDate.Size = new System.Drawing.Size(205, 21);
            this.dtp_QCDate.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(322, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 85;
            this.label3.Text = "检验日期：";
            // 
            // cmb_checker
            // 
            this.cmb_checker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_checker.FormattingEnabled = true;
            this.cmb_checker.Location = new System.Drawing.Point(393, 443);
            this.cmb_checker.Name = "cmb_checker";
            this.cmb_checker.Size = new System.Drawing.Size(205, 20);
            this.cmb_checker.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(322, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 82;
            this.label2.Text = "审 核 员：";
            // 
            // cmb_result
            // 
            this.cmb_result.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_result.FormattingEnabled = true;
            this.cmb_result.Items.AddRange(new object[] {
            "不合格",
            "合格"});
            this.cmb_result.Location = new System.Drawing.Point(87, 410);
            this.cmb_result.Name = "cmb_result";
            this.cmb_result.Size = new System.Drawing.Size(205, 20);
            this.cmb_result.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 80;
            this.label1.Text = "结    论：";
            // 
            // txt_inputNum
            // 
            this.txt_inputNum.Enabled = false;
            this.txt_inputNum.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_inputNum.Location = new System.Drawing.Point(393, 23);
            this.txt_inputNum.MaxLength = 50;
            this.txt_inputNum.Name = "txt_inputNum";
            this.txt_inputNum.Size = new System.Drawing.Size(205, 21);
            this.txt_inputNum.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(322, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 78;
            this.label8.Text = "入库数量：";
            // 
            // txt_productType
            // 
            this.txt_productType.Enabled = false;
            this.txt_productType.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_productType.Location = new System.Drawing.Point(393, 63);
            this.txt_productType.MaxLength = 50;
            this.txt_productType.Name = "txt_productType";
            this.txt_productType.Size = new System.Drawing.Size(205, 21);
            this.txt_productType.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(322, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 76;
            this.label9.Text = "成品类型：";
            // 
            // txt_specsName
            // 
            this.txt_specsName.Enabled = false;
            this.txt_specsName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_specsName.Location = new System.Drawing.Point(87, 98);
            this.txt_specsName.MaxLength = 50;
            this.txt_specsName.Name = "txt_specsName";
            this.txt_specsName.Size = new System.Drawing.Size(205, 21);
            this.txt_specsName.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(16, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 74;
            this.label10.Text = "成品规格：";
            // 
            // txt_productName
            // 
            this.txt_productName.Enabled = false;
            this.txt_productName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_productName.Location = new System.Drawing.Point(87, 63);
            this.txt_productName.MaxLength = 50;
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(205, 21);
            this.txt_productName.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(16, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 72;
            this.label11.Text = "成品名称：";
            // 
            // txt_produceCode
            // 
            this.txt_produceCode.Enabled = false;
            this.txt_produceCode.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_produceCode.Location = new System.Drawing.Point(87, 133);
            this.txt_produceCode.MaxLength = 50;
            this.txt_produceCode.Name = "txt_produceCode";
            this.txt_produceCode.Size = new System.Drawing.Size(205, 21);
            this.txt_produceCode.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 70;
            this.label7.Text = "生产单号：";
            // 
            // txt_excuteStandard
            // 
            this.txt_excuteStandard.Enabled = false;
            this.txt_excuteStandard.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_excuteStandard.Location = new System.Drawing.Point(393, 96);
            this.txt_excuteStandard.MaxLength = 50;
            this.txt_excuteStandard.Name = "txt_excuteStandard";
            this.txt_excuteStandard.Size = new System.Drawing.Size(205, 21);
            this.txt_excuteStandard.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(322, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 68;
            this.label6.Text = "执行标准：";
            // 
            // txt_produceDate
            // 
            this.txt_produceDate.Enabled = false;
            this.txt_produceDate.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_produceDate.Location = new System.Drawing.Point(393, 133);
            this.txt_produceDate.MaxLength = 50;
            this.txt_produceDate.Name = "txt_produceDate";
            this.txt_produceDate.Size = new System.Drawing.Size(205, 21);
            this.txt_produceDate.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(322, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 66;
            this.label5.Text = "生产日期：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.target,
            this.result,
            this.deleteBtn});
            this.dataGridView1.Location = new System.Drawing.Point(18, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(583, 217);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_factoryName
            // 
            this.txt_factoryName.Enabled = false;
            this.txt_factoryName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_factoryName.Location = new System.Drawing.Point(87, 25);
            this.txt_factoryName.MaxLength = 50;
            this.txt_factoryName.Name = "txt_factoryName";
            this.txt_factoryName.Size = new System.Drawing.Size(205, 21);
            this.txt_factoryName.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(16, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 62;
            this.label15.Text = "库房名称：";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_title.Location = new System.Drawing.Point(273, 25);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(124, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "质检报告";
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(49, 571);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 6;
            this.btn_print.Text = "打印";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(248, 571);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 104;
            this.btn_submit.Text = "确认";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(355, 571);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 105;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 10;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "项目";
            this.name.Name = "name";
            this.name.Width = 180;
            // 
            // target
            // 
            this.target.DataPropertyName = "target";
            this.target.HeaderText = "指标";
            this.target.Name = "target";
            this.target.Width = 200;
            // 
            // result
            // 
            this.result.DataPropertyName = "result";
            this.result.HeaderText = "结果";
            this.result.Items.AddRange(new object[] {
            "不合格",
            "合格"});
            this.result.Name = "result";
            this.result.Width = 80;
            // 
            // deleteBtn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "删除";
            this.deleteBtn.DefaultCellStyle = dataGridViewCellStyle2;
            this.deleteBtn.HeaderText = "删除";
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ReadOnly = true;
            this.deleteBtn.Text = "";
            this.deleteBtn.Width = 60;
            // 
            // FrmProductInQC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(692, 625);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.grb_QC);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_print);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductInQC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "质检报告";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProductInQC_FormClosed);
            this.Load += new System.EventHandler(this.FrmProductInQC_Load);
            this.grb_QC.ResumeLayout(false);
            this.grb_QC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_QC;
        private System.Windows.Forms.TextBox txt_factoryName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_produceDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_excuteStandard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_inputNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_productType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_specsName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_produceCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_checker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_result;
        private System.Windows.Forms.ComboBox cmb_inspecter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_QCDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn target;
        private System.Windows.Forms.DataGridViewComboBoxColumn result;
        private System.Windows.Forms.DataGridViewButtonColumn deleteBtn;
    }
}